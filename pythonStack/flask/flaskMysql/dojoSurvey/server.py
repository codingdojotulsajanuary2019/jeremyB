from flask import Flask, render_template, request, redirect, flash
from mysqlconnection import connectToMySQL
app = Flask(__name__)
app.secret_key = 'potato'

@app.route('/')
def index():
    mysql1 = connectToMySQL("dojoSurvey")
    mysql2 = connectToMySQL("dojoSurvey")
    languageQuery = mysql1.query_db("SELECT * FROM languages;")
    print(languageQuery)
    locationQuery = mysql2.query_db("SELECT * FROM locations;")
    print(locationQuery)
    print("index page")



    return render_template("index.html", langs = languageQuery, locals = locationQuery)

@app.route('/create', methods=['POST'])
def createUser():
    is_valid = True
    if len(request.form['name']) < 1:
        is_valid = False
        flash("Please enter a name")
    if (request.form['dojoLocal']=="Choose an Option"):
        is_valid = False
        flash("Please choose a location")
    if (request.form['favLang']=="Choose an Option"):
        is_valid = False
        flash("Please choose a language")
    if is_valid == False:
        return redirect("/")
    print("create page")
    print("*"*50)
    print(request.form)
    if is_valid:
        mysql1 = connectToMySQL("dojoSurvey")
        mysql2 = connectToMySQL("dojoSurvey")
        query1 = "SELECT * FROM languages WHERE name = %(lang)s;" 
        data1 = {
            "lang": request.form["favLang"]
        }
        languageQuery = mysql1.query_db(query1, data1)

        query2 = "SELECT * FROM locations WHERE name = %(loca)s;" 
        data2 = {
            "loca": request.form["dojoLocal"]
        }
        locationQuery = mysql2.query_db(query2, data2)
        print(languageQuery)
        print(locationQuery)
        locationId = locationQuery[0]['id']
        languageId = languageQuery[0]['id']
        print(locationId)
        print(languageId)
        mysql = connectToMySQL("dojoSurvey")
        query = "INSERT INTO users (name, comment, location_id, language_id) VALUES (%(name)s, %(comm)s, %(local)s, %(lang)s);"
        data = {
            "name": request.form["name"],
            "comm": request.form["comments"],
            "local": locationId,
            "lang": languageId
        }
        print("New User should start here")
        resultData = mysql.query_db(query, data)
        print(resultData)
    return redirect('/result')

@app.route('/result')
def results():
    print("results page")
    mysql = connectToMySQL("dojoSurvey")
    userQuery = mysql.query_db("SELECT * FROM users ORDER BY ID DESC LIMIT 1;")
    print(userQuery)

    langId = userQuery[0]['language_id']
    dojoId = userQuery[0]['location_id']
    mysql1 = connectToMySQL("dojoSurvey")
    mysql2 = connectToMySQL("dojoSurvey")
    query1 = "SELECT * FROM languages WHERE id = %(lang)s;" 
    data1 = {
        "lang": langId
    }
    languageQuery = mysql1.query_db(query1, data1)

    query2 = "SELECT * FROM locations WHERE id = %(loca)s;" 
    data2 = {
        "loca": dojoId
    }
    locationQuery = mysql2.query_db(query2, data2)
    print(languageQuery)
    print(locationQuery)
    language = languageQuery[0]['name']
    location = locationQuery[0]['name']
    
    return render_template('result.html', results = userQuery, lang = language, dojo = location)

if __name__ == "__main__":
    app.run(debug=True)