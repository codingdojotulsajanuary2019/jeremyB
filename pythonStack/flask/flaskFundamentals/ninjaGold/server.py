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
    if 'turn' in session:
        session['turn'] +=1
    else:
        session['turn']=0
    if session['turn'] > 15 and session['coinage'] >= 225:
        winner_message = "show_me"
    else:
        winner_message = "hide_me"
    if session['turn'] > 15 and session['coinage'] < 225:
        loser_message = "show_me"
    else:
        loser_message = "hide_me"
    if session['turn'] > 15:
        game_message = "hide_me"
    else:
        game_message = "show_me"
    return render_template('/index.html', player_gold=session['coinage'], loser_show = loser_message, winner_show=winner_message, game_over=game_message)


@app.route('/gold_math', methods=['POST'])
def thatMoneyMath():
    print(session['turn'])
    if session['turn'] > 14:
        session['hidden_reset'] = 'show_me'
    else:  
        session['hidden_reset'] = 'hide_me'

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
        randNum = random.randint(-60,90)
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