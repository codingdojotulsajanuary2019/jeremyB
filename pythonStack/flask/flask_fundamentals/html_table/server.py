from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")

class ItemTable(Table):
    first_name = Col('First Name')
    last_name = Col('Last Name')
    full_name = Col('Full Name')

class User(object):
    def __init__(self, first_name, last_name, full_name):
        self.first_name = first_name
        self.last_name = last_name
        self.full_name = full_name

users = [
   {'first_name' : 'Michael', 'last_name' : 'Choi'},
   {'first_name' : 'John', 'last_name' : 'Supsupin'},
   {'first_name' : 'Mark', 'last_name' : 'Guillen'},
   {'first_name' : 'KB', 'last_name' : 'Tonel'}
]
table = ItemTable(users)

if __name__=="__main__":
    app.run(debug=True)