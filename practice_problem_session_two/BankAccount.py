class BankAccount:
  def __init__(self, account_number: str, account_name: str, balance: float = 0.0):
    self.account_number = account_number
    self.account_name = account_name
    self.balance = balance

  def deposit(self, amount: float):
    if amount > 0:
      self.balance += amount
      return self.message_for_action("Deposit", True)
    return self.message_for_action("Deposit", False)

  def withdraw(self, amount: float):
    if 0 < amount <= self.balance:
      self.balance -= amount
      return self.message_for_action("Withdraw", True)
    return self.message_for_action("Withdraw", False)

  def transfer(self, amount: float, destination_account: "BankAccount"):
    if self.withdraw(amount):
      destination_account.deposit(amount)
      return self.message_for_action("Transfer", True)
    return self.message_for_action("Transfer", False)

  def __str__(self):
    return f"Account({self.account_number}, {self.account_name}, Balance: {self.balance})"
  
  def message_for_action(self, action_name: str, success: bool):
    if success:
      return f"{action_name} is successful."
    else:
      return f"{action_name} is failed."