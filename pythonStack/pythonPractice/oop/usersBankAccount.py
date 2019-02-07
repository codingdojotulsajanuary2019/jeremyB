class BankAccount:
    def __init__(self,balance,interest_rate, accNum):
        self.balance = balance
        self.interest_rate = interest_rate
        self.accNum = accNum
    
    def deposit(self, amount):
        self.balance += amount
        return self
    
    def withdrawal(self, amount):
        self.balance -= amount
        return self
    
    def display_account_info(self):
        print("Balance: ", self.balance)

    def yield_interest(self):
        if(self.balance > 0):
            self.balance = self.balance + self.balance*self.interest_rate
            return self

class User:
    def __init__(self, username, email_address):
        self.name = username
        self.email = email_address
        self.account = BankAccount(accNum = 1,balance=0, interest_rate=.02)
    
    def make_deposit(self, amount):
        self.account.deposit(amount)
    
    def make_withdrawal(self, amount):
        self.account.withdrawal(amount)
    
    def display_user_balance(self):
        print("User: ",self.name, " Balance: $",self.account.balance)

    def transfer_money(self, other_user, amount):
        self.account.balance -= amount
        other_user.account.balance += amount

jeremy = User("Jeremy Benedik", "jeremy@python.com", )
jeremy.make_deposit(10)
jeremy.make_deposit(70)
jeremy.make_withdrawal(70)
jeremy.display_user_balance()