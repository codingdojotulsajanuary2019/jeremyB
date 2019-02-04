def biggSize(x):
    for i in range(len(x)):
        if(x[i]>0):
            x[i] = "big"
    return x

def countPositives(x):
    count = 0
    for i in range(len(x)):
        if(x[i]>0):
            count += 1
    x[(len(x)-1)] = count
    return x

def sumTotal(x):
    total = 0
    for i in range(len(x)):
        total += x[i]
    return total

def average(x):
    total = 0
    for i in range(len(x)):
        total += x[i]
    avg = total/len(x)
    return avg

def length(x):
    count = 0
    for i in range(len(x)):
        count += 1
    return count

def minimum(x):
    if(len(x)==0):
        return False
    else:
        minVal = x[0]
        for i in range(1,len(x)):
            if(x[i]<minVal):
                minVal = x[i]
    return minVal

def maximum(x):
    if(len(x)==0):
        return False
    else:
        maxVal = x[0]
        for i in range(1,len(x)):
            if(x[i]>maxVal):
                maxVal = x[i]
    return maxVal

def ultimateAnalysis(x):
    analysis = {}
    total = x[0]
    avg = x[0]
    minVal = x[0]
    maxVal = x[0]
    length = len(x)
    for i in range(1,len(x)):
        if(x[i]>maxVal):
            maxVal = x[i]
        if(x[i]<minVal):
            minVal = x[i]
        total += x[i]
    avg = total/length
    analysis["sumTotal"] = total
    analysis["average"] = avg
    analysis["minimum"] = minVal
    analysis["maximum"] = maxVal
    analysis["length"] = length
    return analysis

def ultAnal(x):
    analysis = {}
    total = sumTotal(x)
    avg = average(x)
    minVal = minimum(x)
    maxVal = maximum(x)
    length = len(x)
    analysis["sumTotal"] = total
    analysis["average"] = avg
    analysis["minimum"] = minVal
    analysis["maximum"] = maxVal
    analysis["length"] = length
    return analysis

def reverseList(x):
    temp = 0
    for i in range(int(len(x)/2)):
        temp = x[i]
        x[i] = x[(len(x)-i-1)]
        x[(len(x)-i-1)] = temp
    return x