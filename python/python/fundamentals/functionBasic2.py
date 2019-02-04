def countdown(x):
    count = []
    for i in range(x, -1, -1):
        count.append(i)        
    print(count)


def printReturn(x):
    print(x[0])
    return x[1]

def firstPlusLength(x):
    y = x[0] + len(x)
    return y

def valuesGreatSec(x):
    newList = []
    if(len(x)<2):
        return False
    else:
        for i in range(0,len(x)):
            if(x[1]<x[i]):
                newList.append(x[i])
        return newList

def lengthValue(x,y):
    newList = []
    for i in range(0,x):
        newList.append(y)
    return newList