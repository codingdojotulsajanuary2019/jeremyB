from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/result', methods=['POST'])
def info_list():
    name_from_form = request.form['name']
    color_from_form = request.form['favColor']
    animal_from_form = request.form['favAnimal']
    word_from_form = request.form.getlist('word')
    comment_from_form = request.form['comments']
    return render_template("result.html",name_on_template=name_from_form,color_on_template=color_from_form,animal_on_template=animal_from_form,word_on_template=word_from_form,comment_on_template=comment_from_form)

if __name__=="__main__":
    app.run(debug=True)