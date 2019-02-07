class User:
    def __init__(self, username, email_address):
        self.name = username
        self.email = email_address
        self.account_balance = 0
    
    def make_deposit(self, amount):
        self.account_balance += amount
    
    def make_withdrawal(self, amount):
        self.account_balance -= amount
    
    def display_user_balance(self):
        print("User: ",self.name, " Balance: $",self.account_balance)

    def transfer_money(self, other_user, amount):
        self.account_balance -= amount
        other_user.account_balance += amount

jeremy = User("Jeremy Benedik", "jeremy@python.com")
abbey = User("Abbey Gonzales", "abbey@python.com")
otis = User("Otis von Fleabag", "otis@python.com")

jeremy.make_deposit(30)
jeremy.make_deposit(60)
jeremy.make_withdrawal(20)
jeremy.display_user_balance()

abbey.make_deposit(100)
abbey.make_deposit(50)
abbey.make_withdrawal(10)
abbey.make_withdrawal(60)
abbey.display_user_balance()

otis.make_deposit(100)
otis.make_withdrawal(50)
otis.make_withdrawal(10)
otis.make_withdrawal(60)
otis.display_user_balance()

jeremy.transfer_money(otis,30)
jeremy.display_user_balance()
otis.display_user_balance()