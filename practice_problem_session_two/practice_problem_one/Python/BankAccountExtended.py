from BankAccount import BankAccount

class BankAccountExtended:
  def __init__(self):
    super().__init__()
    self.accounts = []

  def add_account(self, account: BankAccount):
    self.accounts.append(account)

  def total_balance(self):
    return sum(account.balance for account in self.accounts)