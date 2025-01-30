from CreditCard import CreditCard

if __name__ == "__main__":
    my_credit_card = CreditCard("1234-5678-9012-3456", "Saimon")
    my_credit_card.withdraw_cash(10000)
    my_credit_card.withdraw_cash(20000)
    my_credit_card.withdraw_cash(30000)
    my_credit_card.pay_bill(10000)
    my_credit_card.pay_bill(20000)
    my_credit_card.pay_bill(30000)