from flask import Flask, render_template, request, redirect
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    straw = request.form['strawberry']
    rasp = request.form['raspberry']
    appl = request.form['apple']
    fname = request.form['first_name']
    lname = request.form['last_name']
    stid = request.form['student_id']
    count = int(straw)+int(appl)+int(rasp)
    return render_template("checkout.html",strawTemp=straw, raspTemp=rasp,appTemp=appl,fnameTemp=fname, lnameTemp=lname,stidTemp=stid,countTemp=count)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)    