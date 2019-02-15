from flask import Flask, render_template, request, redirect, flash, url_for, session
from mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
import re
import datetime
from flask_humanize import Humanize
app = Flask(__name__)
humanize = Humanize(app)
app.secret_key = 'potato'

bcrypt = Bcrypt(app)

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')


@app.route('/')
def index():

    return render_template('index.html')


@app.route('/register', methods=['POST'])
def register():
    print("got to REGISTER")
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

    mysql = connectToMySQL("privateWall")
    query = "INSERT INTO users (firstName, lastName, email, password) VALUES (%(fn)s, %(ln)s,%(em)s,%(pw)s);"
    data = {
        'fn': request.form['fname'],
        'ln': request.form['lname'],
        'em': request.form['email'],
        'pw': pw_hash
    }
    newUsr = mysql.query_db(query, data)
    print(newUsr)

    mysql = connectToMySQL("privateWall")
    query = "SELECT * FROM users WHERE email = %(em)s"
    data = {
        'em' : request.form['email']
    }
    userInfo = mysql.query_db(query, data)
    session['id'] = userInfo[0]['id']
    session['name'] = userInfo[0]['firstName']
    print(userInfo)
    print(session['id'])
    session['email'] = request.form['email']
    return redirect('/wall')

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

    mysql = connectToMySQL("privateWall")
    query = "SELECT * FROM users WHERE email = %(em)s"
    data = {
        'em' : request.form['email']
    }
    logInfo = mysql.query_db(query, data)
    print(logInfo)
    if logInfo:
        print("Test working condition")
        if bcrypt.check_password_hash(logInfo[0]['password'], request.form['pword']):
            session['email'] = logInfo[0]['email']
            session['id'] = logInfo[0]['id']
            session['name'] = logInfo[0]['firstName']
            return redirect('/wall')

    flash(u"Could not be logged in", 'login')
    return redirect('/')

@app.route('/logout')
def logout():
    session.clear()
    return redirect('/')

@app.route('/wall')
def wall():
    print("*"*90)
    print("got to WALL")
    # Select datetime
    mysql3 = connectToMySQL("privateWall")
    query3 = "SELECT created_at FROM messages WHERE receive_id = %(id)s;"
    data3 = {
        'id':session['id']
    }
    messageTime = mysql3.query_db(query3,data3)
    print(messageTime)
    now = datetime.datetime.now()
    print(now)
    then = messageTime[0]['created_at']
    print(then)
    delta = now - then
    print(delta)
    # Select all messages sent to user
    mysql2 = connectToMySQL("privateWall")
    query2 = "SELECT messages.id, content, created_at, users.firstName FROM messages JOIN users ON messages.send_id = users.id WHERE receive_id = %(id)s;"
    data2 = {
        'id':session['id']
    }
    messageInfo = mysql2.query_db(query2, data2)
    number = len(messageInfo)
    print(messageInfo)
    print(number)
    #Select messages sent
    mysql3 = connectToMySQL("privateWall")
    query3 = "SELECT * FROM messages WHERE send_id = %(id)s"
    data3 = {
        'id':session['id']
    }
    allMess = mysql3.query_db(query3, data3)
    number2 = len(allMess)
    # Send message to user
    mysql1 = connectToMySQL("privateWall")
    query1 = "SELECT * FROM users WHERE id != %(id)s ORDER BY firstName ASC;"
    data1 = {
        'id':session['id']
    }
    userInfo = mysql1.query_db(query1, data1)
    print(userInfo)
    return render_template('wall.html', messages = messageInfo, users = userInfo, numMess = number, sentMess = number2, time_ago = now)

@app.route('/message/<id>', methods=['POST'])
def message(id):
    is_valid = True
    db_id = int(id)
    print("*"*90)
    print(request.form)
   
    if len(request.form['content']) < 5:
        flash(u"Please enter a longer message", 'message')
        return redirect('/wall')

    mysql = connectToMySQL("privateWall")
    query = "INSERT INTO messages (content, send_id, receive_id) VALUES (%(con)s, %(sid)s, %(rid)s);"
    data = {
        'con': request.form['content'],
        'sid': session['id'],
        'rid': db_id
    }
    messageSend = mysql.query_db(query, data)
    print(messageSend)

    return redirect('/wall')

@app.route('/delete/<id>')
def delete(id):
    db_id = int(id)
    mysql = connectToMySQL("privateWall")
    query = "DELETE FROM messages where id = %(id)s;"
    data = {
        'id': db_id
    }
    deleter = mysql.query_db(query, data)
    return redirect('/wall')

if __name__ == "__main__":
    app.run(debug=True)