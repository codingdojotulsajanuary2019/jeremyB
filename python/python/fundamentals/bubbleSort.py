arr = [1,5,3,2,0,8,6]

def bubbleSort(arr):
    for j in range(len(arr)-1):
        for i in range(len(arr)-1-j):
            # print("Checking ", arr[i], " & ",arr[i+1])
            if(arr[i]>arr[i+1]):
                arr[i],arr[i+1] = arr[i+1],arr[i]
                # print("Swapped")
            else:
                # print("didn't swap")
    print(arr)

bubbleSort(arr)