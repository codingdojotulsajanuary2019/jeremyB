arr = [3,5,1,2,0,8,6]

def insertSort(arr):
    for i in range(1,len(arr)):
        testVar = arr[i]
        # print("i: ",i)
        for j in range(i,-1,-1):
            # print("j: ",j)
            # print("testVar: ",testVar)
            # print("arr[j]:", arr[j])
            if j>=0 and testVar<arr[j]:
                # print("comparing testVar:", testVar, "and arr[j]:",arr[j])
                arr[j],arr[j+1] = arr[j+1],arr[j]
        #     print("J loop: ",arr)
        # print("I loop:", arr)
    return arr

print(insertSort(arr))