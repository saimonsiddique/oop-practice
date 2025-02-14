from BankAccountExtended import BankAccountExtended
from BankAccount import BankAccount


# if __name__ == "__main__":
#   # Create accounts
#   my_bank_account = BankAccount("1623-5678-0987", "Saimon")
#   sabbir_bank_account = BankAccount("2345-1243-7890", "Sabbir")

#   # Perform transactions
#   print("Depositing 12000 into Saimon's account:", my_bank_account.deposit(12000))
#   print("Withdrawing 7500 from Saimon's account:", my_bank_account.withdraw(7500))
#   print("Depositing 5000 into Saimon's account:", my_bank_account.deposit(5000))
#   print("Withdrawing 20000 from Saimon's account:", my_bank_account.withdraw(20000))

#   print("Depositing 5000 into Sabbir's account:", sabbir_bank_account.deposit(5000))

#   # Transfer funds
#   print("Transferring 3500 from Saimon to Sabbir:", my_bank_account.transfer(3500, sabbir_bank_account))
#   print("Transferring 25000 from Saimon to Sabbir:", my_bank_account.transfer(25000, sabbir_bank_account))

#   # Display final balances
#   print(f"\nFinal Account Balances:")
#   print(my_bank_account)
#   print(sabbir_bank_account)

if __name__ == "__main__":
  # Create a list of bank accounts
  bank_account_extended = BankAccountExtended()
  bank_account_extended.add_account(BankAccount("1623-5678-0987", "Saimon", 12000))
  bank_account_extended.add_account(BankAccount("2345-1243-7890", "Sabbir", 5000))

  # Perform transactions
  print("Depositing 7500 into Saimon's account:", bank_account_extended.accounts[0].deposit(7500))
  print("Withdrawing 20000 from Saimon's account:", bank_account_extended.accounts[0].withdraw(20000))
  print("Depositing 5000 into Sabbir's account:", bank_account_extended.accounts[1].deposit(5000))
  print("Withdrawing 2000 from Sabbir's account:", bank_account_extended.accounts[1].withdraw(2000))

  # Transfer funds
  print("Transferring 3500 from Saimon to Sabbir:", bank_account_extended.accounts[0].transfer(3500, bank_account_extended.accounts[1]))


  # Display total balance
  print(f"\nTotal Balance: {bank_account_extended.total_balance()}")

