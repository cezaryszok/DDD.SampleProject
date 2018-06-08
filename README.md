# DDD.SampleProject

1.	System can issue an invoice based on created order.
2.	To be able to issue an invoice, order must be accepted before.
3.	Invoice is optional, it is being issued only on customer demand.
4.	Order can be created only for active customer
5.	Order contains products and customer data.
6.	If customer has already ordered product for the amount of 1000 PLN, they will be given with 5% rebate. This is valid for all products.
7.	If customer is marked as a VIP, they will be given a total rebate of 100%. This is valid for all products.
8.	The two rebates do not combine.
9.	Before an order is accepted, all products must be checked if they are available in store. If not, then the order cannot be accepted.
10.	Order cannot be accepted if customer is a debtor.
11.	 System cannot accept more than 50 orders per day .
12.	 Invoice line includes tax amount for product.
13.	Tax is 10% for every product, except alcohol. Tax for alcohol is set to 15%
14.	If customer is foreigner – the all products are taxed to 10% (including alcohol)
