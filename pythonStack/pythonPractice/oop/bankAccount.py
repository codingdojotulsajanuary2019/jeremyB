class BankAccount:
    def __init__(self,balance,interest_rate):
        self.balance = balance
        self.interest_rate = interest_rate
    
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

accnt1 = BankAccount(10,.02)
accnt2 = BankAccount(30,.07)

accnt1.deposit(10).deposit(30).deposit(60).withdrawal(70).yield_interest().display_account_info()
accnt2.deposit(60).deposit(40).withdrawal(10).withdrawal(30).withdrawal(40).withdrawal(10).yield_interest().display_account_info()