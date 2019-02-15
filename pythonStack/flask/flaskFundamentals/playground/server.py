from flask import Flask, render_template
app = Flask(__name__)

@app.route('/play')
def index():
    return render_template("index.html")

@app.route('/play/<x>')
def index_num(x):
    return render_template("index.html", num = int(x))

@app.route('/play/<x>/<color_given>')
def index_num_color(x,color_given):
    return render_template("index.html",num = int(x), color = color_given)

if __name__=="__main__":
    app.run(debug=True)