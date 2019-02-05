arr = [3,5,1,2,0,8,6]

def selectSort(arr):
    for i in range(len(arr)):
        small = arr[i]
        smallIndx = i
        for j in range(i,len(arr)):
            if(arr[j] < small):
                small = arr[j]
                smallIndx = j
        arr[i],arr[smallIndx] = arr[smallIndx],arr[i]
    return arr

print(selectSort(arr))