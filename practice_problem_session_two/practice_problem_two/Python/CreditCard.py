from datetime import datetime

class CreditCard:
    MAX_LIMIT = 500000
    DAILY_WITHDRAWAL_LIMIT = 100000
    PER_TRANSACTION_LIMIT = 20000

    def __init__(self, card_number: str, card_holder: str):
        self.card_number = card_number
        self.card_holder = card_holder
        self.balance = 0
        self.daily_withdrawn = 0
        self.last_withdrawal_date = None  # Track last withdrawal date

    def reset_daily_withdrawal(self):
        today = datetime.today().date()
        if self.last_withdrawal_date != today:
            self.daily_withdrawn = 0
            self.last_withdrawal_date = today
            print("Daily withdrawal limit reset.")

    def withdraw_cash(self, amount):
        self.reset_daily_withdrawal()
        if amount > self.PER_TRANSACTION_LIMIT:
            raise ValueError(f"Cannot withdraw more than {self.PER_TRANSACTION_LIMIT} per transaction.")
        if self.daily_withdrawn + amount > self.DAILY_WITHDRAWAL_LIMIT:
            raise ValueError(f"Cannot withdraw more than {self.DAILY_WITHDRAWAL_LIMIT} in a day.")
        if self.balance + amount > self.MAX_LIMIT:
            raise ValueError(f"Cannot exceed the maximum limit of {self.MAX_LIMIT}.")
        
        self.balance += amount
        self.daily_withdrawn += amount
        self.last_withdrawal_date = datetime.today().date()
        print(f"Withdrew {amount}. Current balance: {self.balance}")

    def pay_bill(self, amount):
        if self.balance + amount > self.MAX_LIMIT:
            raise ValueError(f"Cannot exceed the maximum limit of {self.MAX_LIMIT}.")
        
        self.balance += amount
        print(f"Paid bill of {amount}. Current balance: {self.balance}")

