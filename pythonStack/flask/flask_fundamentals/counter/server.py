from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = "potato salad"


@app.route('/')
def index():
    if 'count' in session:
        session['count'] += 1
    else:
        session['count']=1
    print(session['count'])
    if 'increase_val' in session:
        num = session['increase_val']
    else:
        num = 2
    print('*'*50)
    print(num)
    return render_template("index.html", num_input = num)

@app.route('/count_page', methods = ['POST'])
def count_magic():
    print(request.form)
    session['increase_val'] = request.form['increase']
    print(session['increase_val'])
    session['count'] -= 1
    return redirect('/')

@app.route('/increase_page', methods = ['POST'])
def add_visits():
    print("You made it")
    session['count'] = int(session['count']) + int(session['increase_val'])
    print("button press")
    session['count'] -= 1
    return redirect('/')

@app.route('/destroy_session')
def destroy():
    session.clear()
    return redirect('/')


if __name__=="__main__":
    app.run(debug=True)