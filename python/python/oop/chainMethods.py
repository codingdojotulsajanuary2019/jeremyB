class User:
    def __init__(self, username, email_address):
        self.name = username
        self.email = email_address
        self.account_balance = 0
    
    def make_deposit(self, amount):
        self.account_balance += amount
        return self
    
    def make_withdrawal(self, amount):
        self.account_balance -= amount
        return self
    
    def display_user_balance(self):
        print("User: ",self.name, " Balance: $",self.account_balance)

    def transfer_money(self, other_user, amount):
        self.account_balance -= amount
        other_user.account_balance += amount
        return self

jeremy = User( "Jeremy Benedik", "jeremy@python.com")
abbey = User("Abbey Gonzales", "abbey@python.com")
otis = User("Otis von Fleabag", "otis@python.com")

jeremy.make_deposit(30).make_deposit(60).make_withdrawal(20).display_user_balance()

abbey.make_deposit(100).make_deposit(50).make_withdrawal(10).make_withdrawal(60).display_user_balance()

otis.make_deposit(100).make_withdrawal(50).make_withdrawal(10).make_withdrawal(60).display_user_balance()

jeremy.transfer_money(otis,30).display_user_balance()
otis.display_user_balance()