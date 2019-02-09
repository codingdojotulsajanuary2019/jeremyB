from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = "potato salad"
import random

randNum = random.randint(1,100)

@app.route('/')
def index():
    print("home page","*"*50)
    print(randNum)

    return render_template("index.html")

@app.route('/number_get', methods=['POST'])
def get_num():
    print("^"*50)
    session['num'] = request.form['guess']
    print(session['num'])
    print(randNum)
    if(int(session['num']) ==randNum):
        return redirect('/you_win')
    return redirect('/bad_guess')

@app.route('/bad_guess')
def lowHigh():
    print("%"*50)
    if(int(session['num']) > randNum):
        response = "Too high!"
    elif(int(session['num']) < randNum):
        response = "Too low!"
    elif(int(session['num']) == randNum):
        return redirect('/you_win')
    return render_template('bad_guess.html', guess_message=response)

@app.route('/you_win')
def winner():
    print("&"*50)
    return render_template('you_win.html',divNum = randNum)


@app.route('/destroy', methods=['POST'])
def destroy():
    session.clear()
    return redirect('/')

if __name__=="__main__":
    app.run(debug=True)