from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/<x>')
def index_row(x):
    return render_template("index.html",rows=int(x))

@app.route('/<x>/<y>')
def index_col(x,y):
    return render_template("index.html",rows=int(x),cols=int(y))

@app.route('/<x>/<y>/<color1_given>')
def index_color1(x,y,color1_given):
    return render_template("index.html",rows=int(x),cols=int(y),color1=color1_given)

@app.route('/<x>/<y>/<color1_given>/<color2_given>')
def index_color2(x,y,color1_given,color2_given):
    return render_template("index.html",rows=int(x),cols=int(y),color1=color1_given,color2=color2_given)
        
    
if __name__=="__main__":
    app.run(debug=True)