from flask import Flask, render_template, request, redirect, url_for
from mysqlconnection import connectToMySQL
app = Flask(__name__)


@app.route('/users')
def index():
    mysql = connectToMySQL("usersSchema")
    users = mysql.query_db("SELECT * FROM users;")
    print(users)
    return render_template("index.html", all_users = users)

@app.route("/users/create", methods=["POST"])
def add_user_to_db():
    mysql = connectToMySQL('usersSchema')
    query = "INSERT INTO users (full_name, email, created_at, updated_at) VALUES (CONCAT(%(fn)s, ' ', %(ln)s), %(ema)s, NOW(), NOW());"
    data = {
        "fn": request.form["fname"],
        "ln": request.form["lname"],
        "ema": request.form["email"],
    }
    newUser = mysql.query_db(query, data)
    print(request.form)
    print(data)
    print(query)
    print(newUser)
    return redirect(url_for('userInfo',id=newUser))

@app.route("/users/new")
def newUserPage():
    return render_template('new.html')

@app.route("/users/<id>")
def userInfo(id):
    db_id=int(id)
    mysql = connectToMySQL("usersSchema")
    query = "SELECT * FROM users WHERE id=%(id)s;"
    data = {'id' : db_id}
    result = mysql.query_db(query, data)
    print(result)
    return render_template('user.html',user_id = db_id, user_info=result)

@app.route("/users/<id>/edit")
def editUserInfo(id):
    db_id=int(id)
    mysql = connectToMySQL("usersSchema")
    query = "SELECT full_name, email FROM users WHERE id=%(id)s;"
    data = {'id' : db_id}
    result = mysql.query_db(query, data)
    print(result)

    nameString = result[0]['full_name']
    print(nameString)
    nameList = str.split(nameString)
    print(nameList)
    first_name = nameList[0]
    last_name = nameList[1]
    return render_template('edit.html',edit_id =db_id, edit_info = result, fname=first_name, lname=last_name)

@app.route("/users/<id>/delete")
def deleteUser(id):
    db_id=int(id)
    mysql = connectToMySQL("usersSchema")
    query = "DELETE FROM users WHERE id=%(id)s;"
    data = {'id' : db_id}
    result = mysql.query_db(query,data)
    print(result)
    return redirect("/users")

@app.route("/users/<id>/update", methods=['POST'])
def updateUser(id):
    print("*"*50)
    db_id=int(id)
    fn = request.form["fname"]
    ln = request.form["lname"]
    fullName = fn+" "+ln
    print(fullName)
    mysql = connectToMySQL('usersSchema')
    query = "UPDATE users SET full_name =%(fullname)s , email=%(ema)s, updated_at=NOW() WHERE id= %(id)s;"
    data = {
        "fullname":fullName,
        "ema": request.form["email"],
        "id": db_id
    }
    result = mysql.query_db(query, data)
    print(request.form)
    print(data)
    print(query)
    print(result)
    return redirect(url_for('userInfo',id=db_id))


if __name__ == "__main__":
    app.run(debug=True)
