from flask import Flask, render_template, request, redirect, flash, url_for, session
from mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
import re
app = Flask(__name__)
app.secret_key = 'potato'

bcrypt = Bcrypt(app)

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')


@app.route('/')
def index():

    return render_template('index.html')

@app.route('/register', methods=['POST'])
def register():
    print("got to PROCESS")
    print("*"*90)
    print(request.form)
    is_valid = True

    if not EMAIL_REGEX.match(request.form['email']):
        is_valid = False
        flash(u"Invalid email address", 'email')
    if (len(request.form['fname'])<2):
        print("fname too short")
        flash(u"Invalid first name entered", 'fname')
    if (len(request.form['lname'])<2):
        print("lname too short")
        flash(u"Invalid last name entered", 'lname')
    if (len(request.form['pword'])<8):
        print("password too short")
        flash(u"Invalid password entered", 'pword')
    if (request.form['cpword'] != request.form['pword']):
        print("cpword doesn't match")
        flash(u"Passwords don't match", 'cpword')
    if is_valid == False:
        return redirect('/')

    pw_hash = bcrypt.generate_password_hash(request.form['pword'])
    print(pw_hash)

    mysql = connectToMySQL("loginRegistration")
    query = "INSERT INTO logins (firstName, lastName, email, password) VALUES (%(fn)s, %(ln)s,%(em)s,%(pw)s);"
    data = {
        'fn': request.form['fname'],
        'ln': request.form['lname'],
        'em': request.form['email'],
        'pw': pw_hash
    }
    newUsr = mysql.query_db(query, data)
    print(newUsr)

    mysql = connectToMySQL("loginRegistration")
    query = "SELECT * FROM logins WHERE email = %(em)s"
    data = {
        'em' : request.form['email']
    }
    session['email'] = request.form['email']
    return redirect('/success')


@app.route('/login', methods=['POST'])
def login():
    print("Got to LOGIN")
    print("*"*90)
    is_valid = True

    print(request.form)
    if not EMAIL_REGEX.match(request.form['email']):
        is_valid = False
        flash(u"Invalid email address", 'email')

    pw_hash = bcrypt.generate_password_hash(request.form['pword'])
    print(pw_hash)

    mysql = connectToMySQL("loginRegistration")
    query = "SELECT * FROM logins WHERE email = %(em)s"
    data = {
        'em' : request.form['email']
    }
    logInfo = mysql.query_db(query, data)
    print(logInfo)
    if logInfo:
        print("Test working condition")
        if bcrypt.check_password_hash(logInfo[0]['password'], request.form['pword']):
            session['email'] = logInfo[0]['email']
            return redirect('/success')

    flash(u"Could not be logged in", 'login')
    return redirect('/')

@app.route('/success')
def success():
    if session:
        mysql = connectToMySQL("loginRegistration")
        query = "SELECT * FROM logins WHERE email = %(em)s"
        data = {
            'em' : session['email']
        }
        info = mysql.query_db(query, data)
        name = info[0]['firstName']
        return render_template('success.html', username = name)
    else:
        flash(u"Must be logged in", "login")
        return redirect('/')

@app.route('/logout')
def logout():
    session.clear()
    return redirect('/')

if __name__ == "__main__":
    app.run(debug=True)