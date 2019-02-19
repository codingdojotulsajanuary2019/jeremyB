from flask import Flask, render_template, request, redirect
from mysqlconnection import connectToMySQL

app = Flask(__name__)

@app.route("/")
def index():
    print("*"*50, "\nIN INDEX METHOD\n", "*"*50)
    mysql = connectToMySQL("lead_gen_business")
    customer_leads = mysql.query_db("SELECT CONCAT(clients.first_name, ' ', clients.last_name) AS full_name, COUNT(leads_id) AS total_leads FROM leads JOIN sites ON leads.site_id = sites.site_id JOIN clients ON sites.client_id = clients.client_id GROUP BY full_name ORDER BY total_leads DESC;") 
    print(customer_leads)
    return render_template("index.html", leads = customer_leads)

if __name__ == "__main__":
    app.run(debug=True)