# Basic
for x in range(151):
    print(x)

# Multiples of Five
for y in range(5,1001,5):
    print(y)

# Counting, the Dojo Way
for i in range(1,101,1):
    if i%10 == 0:
        print("Coding Dojo")
    elif i%5 == 0:
        print("Coding")
    else:
        print(i)

# Whoa. That Sucker's Huge
hugeSucker = 0
for j in range(1,500000,2):
    hugeSucker += j
print(hugeSucker)

# Countdown by Fours
for h in range(2018, 0, -4):
    print(h)

# Flexible Counter
lowNum = 3
highNum = 17
mult = 2
for g in range(lowNum, highNum, mult):
    print(g)
    