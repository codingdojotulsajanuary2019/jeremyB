import random
def randInt(min=0, max=100):
    if(min>max):
        return "minimum value exceeds maximum"
    else:
        num = random.random()
        num = (num * (max-min)) + min
        return round(num)
print(randInt())