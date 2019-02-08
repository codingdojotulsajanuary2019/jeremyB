from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = "potato salad"


@app.route('/')
def index():
    if 'count' in session:
        session['count'] += 1
    else:
        session['count']=1
    increase_value = request.form['increase']
    return render_template("index.html")

@app.route('/destroy_session')
def destroy():
    session.pop('count', None)
    return redirect('/')



if __name__=="__main__":
    app.run(debug=True)