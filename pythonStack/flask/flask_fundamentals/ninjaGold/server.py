from flask import Flask, render_template, request, redirect, session
import random
app = Flask(__name__)
app.secret_key = "potato salad"


@app.route('/')
def makeMoney():
    print("*"*50)
    if 'coinage' not in session:
        session['coinage']=0
    if 'message' not in session:
        session['message']=[]
    return render_template('/index.html', player_gold=session['coinage'])


@app.route('/gold_math', methods=['POST'])
def thatMoneyMath():
        if request.form['choice'] == 'farm':
            print('Farm was chosen')
            randNum = random.randint(10,20)
            print('Farm check: ', randNum)
            session['coinage'] += randNum
            print('gold: ',session['coinage'])
            session['message'].append("<p>The Farm earned you "+ str(randNum) + " gold.</p>")
            return redirect('/')
        elif request.form['choice'] == 'cave':
            print('Cave was chosen')
            randNum = random.randint(0,30)
            print('Cave check: ', randNum)
            session['coinage'] += randNum
            print('gold: ',session['coinage'])
            session['message'].append("<p>The Cave earned you "+ str(randNum) + " gold.</p>")
            return redirect('/')
        elif request.form['choice'] == 'house':
            print('House was chosen')
            randNum = 15
            print('House check: ', randNum)
            session['coinage'] += randNum
            print('gold: ',session['coinage'])
            session['message'].append("<p>The House earned you "+ str(randNum) + " gold.</p>")
            return redirect('/')
        elif request.form['choice'] == 'casino':
            print('Casino was chosen')
            randNum = random.randint(-60,60)
            print('Casino check: ', randNum)
            session['coinage'] += randNum
            print('gold: ',session['coinage'])
            if randNum > 0:
                session['message'].append("<p>The Casino earned you "+ str(randNum) + " gold.</p>")
            else:
                session['message'].append("<p class='loss_red'>The Casino lost you "+ str(randNum) + " gold.</p>")
            return redirect('/')
        elif request.form['choice'] == 'reset':
            session.clear()
            print('Reset game')
            return redirect('/')


if __name__=="__main__":
    app.run(debug=True)