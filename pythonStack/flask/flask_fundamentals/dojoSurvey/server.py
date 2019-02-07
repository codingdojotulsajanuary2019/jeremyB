from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/result', methods=['POST'])
def info_list():
        print("Got Post Info")


if __name__=="__main__":
    app.run(debug=True)