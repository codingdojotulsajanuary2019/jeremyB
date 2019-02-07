from flask import Flask
app = Flask(__name__)

@app.route('/')
def hello_world():
    return "Hello World!"

@app.route('/dojo')
def success():
    return "Dojo!"

@app.route('/say/<person>')
def say(person):
    print(person)
    return "Hi " + person + "!"

@app.route('/repeat/<num>/<words>')
def repeat(num, words):
    repeater = int(num)
    print("num: "+num+"words: "+words)
    return words * repeater

# @app.route('/', defaults={'path': ''})
# @app.route('/<path:path>')
# def catch_all(path):
#     return "Sorry! No response. Try again."

@app.errorhandler(404)
def page_not_found(e):
    return "Sorry! No response. Try again."


if __name__ == "__main__":
    app.run(debug=True)
