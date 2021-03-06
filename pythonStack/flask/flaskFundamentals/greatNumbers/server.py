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
    if 'attempts' in session:
        session['attempts'] +=1
    else:
        session['attempts'] = 1
    session['num'] = request.form['guess']
    print(session['num'])
    print(randNum)
    if(int(session['num']) ==randNum):
        return redirect('/you_win')
    if session['attempts'] > 5:
        return redirect('/you_lose')
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
    return render_template('bad_guess.html', guess_message=response, guess_number=session['attempts'])

@app.route('/you_win')
def winner():
    print("&"*50)
    return render_template('you_win.html',divNum = randNum, guess_number=session['attempts'])

@app.route('/you_lose')
def loser():
    print("$"*50)
    return render_template('you_lose.html', divNum = randNum, guess_number=session['attempts'])


@app.route('/destroy', methods=['POST'])
def destroy():
    session.clear()
    return redirect('/')

if __name__=="__main__":
    app.run(debug=True)