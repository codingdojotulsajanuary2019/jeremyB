class Animal:
    def __init__(self, name, age, health, happiness):
        self.name = name
        self.age = age
        self.health = health
        self.happiness = happiness

class Dog(Animal):
    def __init__(self, name, age, health, happiness, loyalty):
        super.__init__(name,age,health, happiness)
        self.loyalty = loyalty

class Penguin(Animal):
    def __init__(self, name, age, health, happiness, cuteness):
        super.__init__(name, age, health, happiness)
        self.cuteness = cuteness

class Skunk(Animal):
    def __init__(self, name, age, health, happiness, smelliness):
        super.__init__(name,age,health,happiness)
        self.smelliness = smelliness