from flask import Flask, render_template, request, redirect, flash, url_for
from mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
bcrypt = Bcrypt(app)
import re
app = Flask(__name__)
app.secret_key = 'potato'

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

@app.route('/')
def index():

    return render_template('index.html')

@app.route('/process', methods=['POST'])
def process():
    print("got to PROCESS")
    print("*"*50)
    is_valid = True
   
    if not EMAIL_REGEX.match(request.form['email']):
        is_valid = False
        flash("Invalid email address!")
        return redirect('/')
    
    mysql1 =connectToMySQL('emailValidation')
    query1 = "SELECT email FROM emails WHERE email = %(em)s;"
    data1 = {
        "em": request.form['email']
    }
    validateEmail = mysql1.query_db(query1, data1)
    print(validateEmail)
    if validateEmail != False:
        flash("Email already exists in database!") 
        return redirect('/')
    
    mysql = connectToMySQL('emailValidation')
    query = "INSERT INTO emails (email, created_at) VALUE (%(em)s, NOW());"
    data = {
        "em": request.form["email"]
    }
    newEmail = mysql.query_db(query, data)
    print(request.form)
    print(newEmail)
    
    if is_valid == True:
        flash(f"Succesfully added {request.form['email']}! Thank you!")

    return redirect(url_for('success'))

@app.route('/success')
def success():
    print("got to success")
    print("$"*50)
    mysql = connectToMySQL("emailValidation")
    emails = mysql.query_db("SELECT * FROM emails;")
    print(emails)
    return render_template("success.html", email_list = emails)

@app.route('/delete/<id>')
def delete(id):
    print("got to delete")
    print("*"*90)
    print(id)
    emailID = id
    print(emailID)
    mysql = connectToMySQL("emailValidation")
    query = "DELETE FROM emails WHERE id = %(id)s;"
    data = {'id': emailID }
    print(query)
    deleteEmail = mysql.query_db(query, data)
    print(deleteEmail)
    return redirect(url_for('success'))
    
if __name__ == "__main__":
    app.run(debug=True)