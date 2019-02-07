from products import Product

class Store:
    def __init__(self,name):
        self.name = name
        self.products = []

    def addProduct(self, new_product):
        self.products.append(new_product)
        return self

    def sellProduct(self, old_product):
        self.products.remove(old_product)
        return self
    
    def inflation(self, percent_increase):
        percent_increase = percent_increase/100
        for i in self.products:
            i.price = i.price * percent_increase + i.price
            print(i.price)

    
    def set_clearance(self,category_given,percent_discount):
        percent_discount = percent_discount/100
        for items in self.products:
            if items.category == category_given:
                items.price = items.price - items.price*percent_discount


myStore = Store("Jeremy's Place")
myPotato = Product("Potato",1,"produce")
myBanana = Product("Banana",4,"produce")
mySoap = Product("Soap",7,"soap")
myShrimp = Product("Shrimp",8,"seafood")

def print_products():
    for product_list in myStore.products:
        print(product_list.name,product_list.price,product_list.category)



myStore.addProduct(myPotato)
myStore.addProduct(myBanana)
myStore.addProduct(mySoap)
myStore.addProduct(myShrimp)
myStore.sellProduct(mySoap)

print_products()
Product.print_info(mySoap)

myStore.inflation(20)
print_products()

myStore.set_clearance("produce", 10)
print_products()