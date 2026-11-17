# 1. Define the services
class EmailService:
    def send_message(self):
        print("order confirmation Email sent")

class CashPaymentSe:
    def make_payment(self):
        print("cash payment received")

# 2. Define Program (Python just saves this blueprint for later)
class Program:
    def __init__(self, service, serv):
        self._service = service
        self._serv = serv

    def make_pay(self):
        self._serv.make_payment()

    def place_order(self):
        print("order has been placed successfully")
        self._service.send_message()

# 3. Execution starts here (Everything above is already loaded in memory)
print("testing dependency injection")
nserv = EmailService()
nserv2 = CashPaymentSe()

p = Program(nserv, nserv2)
p.place_order()
p.make_pay()
