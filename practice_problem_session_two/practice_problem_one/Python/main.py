from BankAccount import BankAccount

if __name__ == "__main__":
  # Create accounts
  my_bank_account = BankAccount("1623-5678-0987", "Saimon")
  sabbir_bank_account = BankAccount("2345-1243-7890", "Sabbir")

  # Perform transactions
  print("Depositing 12000 into Saimon's account:", my_bank_account.deposit(12000))
  print("Withdrawing 7500 from Saimon's account:", my_bank_account.withdraw(7500))
  print("Depositing 5000 into Saimon's account:", my_bank_account.deposit(5000))
  print("Withdrawing 20000 from Saimon's account:", my_bank_account.withdraw(20000))

  print("Depositing 5000 into Sabbir's account:", sabbir_bank_account.deposit(5000))

  # Transfer funds
  print("Transferring 3500 from Saimon to Sabbir:", my_bank_account.transfer(3500, sabbir_bank_account))
  print("Transferring 25000 from Saimon to Sabbir:", my_bank_account.transfer(25000, sabbir_bank_account))

  # Display final balances
  print(f"\nFinal Account Balances:")
  print(my_bank_account)
  print(sabbir_bank_account)
