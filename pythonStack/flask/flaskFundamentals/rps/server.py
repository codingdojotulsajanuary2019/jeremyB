from flask import Flask, render_template, request, redirect, session
import random
app = Flask(__name__)
app.secret_key = "potato salad"


@app.route('/')
def index(player_choice=" ", cpu_choice=" "):
    if 'player_score' not in session:
        session['player_score']=0
    if 'cpu_score' not in session:
        session['cpu_score']=0
    if 'player_choice' not in session:
        session['player_choice'] = "none"
    if 'cpu_choice' not in session:
        session['cpu_choice'] = "none"

    if session['player_choice'] == session['cpu_choice']:
        outcome = 'Draw'
    elif session['player_choice'] == 'Rock' and session['cpu_choice'] == 'Scissors':
        outcome = 'Win'
        session['player_score']+=1
    elif session['player_choice'] == 'Paper' and session['cpu_choice'] == 'Rock':
        outcome = 'Win'
        session['player_score'] +=1
    elif session['player_choice'] == 'Scissors' and session['cpu_choice'] == 'Paper':
        outcome = 'Win'
        session['player_score']+=1
    else:
        outcome = 'Lose'
        session['cpu_score']+=1

    print(session['player_score'])
    print(session['cpu_score'])

    if session['player_choice'] == "Rock":
        player_text = "danger"
    elif session['player_choice'] == "Scissors":
        player_text = "warning"
    elif session['player_choice'] =="Paper":
        player_text = "info"
    else:
        player_text = "light"

    if session['cpu_choice'] == "Rock":
        cpu_text = "danger"
    elif session['cpu_choice'] == "Scissors":
        cpu_text = "warning"
    elif session['cpu_choice'] =="Paper":
        cpu_text = "info"
    else: cpu_text = "light"
        
    return render_template("index.html",player_display=session['player_choice'], cpu_display=session['cpu_choice'], outcome_sent=outcome, player_choice_color=player_text, cpu_wins_count=session['cpu_score'],player_wins_count=session['player_score'], cpu_choice_color=cpu_text)

@app.route('/result', methods=['POST'])
def choose_winner():
    print("Got input press")
    print(request.form)
    for x_val in request.form:
        print([x_val])
        if x_val == "paper.x":
          session['player_choice'] = "Paper"
        elif x_val == "scissors.x":
          session['player_choice'] = "Scissors"
        elif x_val == "rock.x":
           session['player_choice'] = "Rock"
    print(session['player_choice'])
    randNum = random.randint(1,3)
    if randNum == 1:
        session['cpu_choice'] = "Paper"
    elif randNum == 2:
        session['cpu_choice'] = "Scissors"
    elif randNum == 3:
        session['cpu_choice'] = "Rock"

    
    print(session['cpu_choice'])
    return redirect('/')
    
@app.route('/reset_score')
def score_reset():
        session.clear()
        return redirect('/')


if __name__=="__main__":
    app.run(debug=True)