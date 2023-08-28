# Blog Notes: Insertion Sort
## Trace
Sample Array: [8,4,23,42,16,15]


1) sorted = [8]

Insert ( [8], 4)

temp = 8

sorted [0] = 4

value = 8

i = 1

sorted.append(value)

2) sorted = [4,8]

Insert ( [4,8] , 23)

23 > sorted [i]

sorted.append(value)

3) sorted = [4,8, 23]

Insert ( [4,8, 23] , 42)

42 > sorted [i]

sorted.append(value)

4) sorted = [4,8, 23, 42]


Insert ( [4,8, 23, 42] , 16)

16 > 4   -> i+= 1

16 > 8   -> i+= 1

temp = 23

sorted [2 ] = 16

value = 23

sorted.append(value)

5) sorted = [4,8, 16, 23, 42]



Insert ( [4,8, 16, 23, 42] , 15)

15 > 4 -> i+= 1

15 > 8   -> i+= 1

temp = 16

sorted [2 ] = 15

value = 26

sorted.append(value)

6) sorted = [4,8, 16, 23, 42]




**Other Sample arrays**

1. Reverse-sorted: [20, 18, 12, 8, 5, -2]

1) Sorted Array: [20]
2) Sorted Array: [18, 20]
3) Sorted Array: [12, 18, 20]
4) Sorted Array: [8, 12, 18, 20]
5) Sorted Array: [5, 8, 12, 18, 20]
6) Sorted Array: [-2, 5, 8, 12, 18, 20]

2. Few uniques: [5, 12, 7, 5, 5, 7]

1) Sorted Array: [5]
2) Sorted Array: [5, 12]
3) Sorted Array: [5, 7, 12]
4) Sorted Array: [5, 5, 7, 12]

5) Sorted Array: [5, 5, 5, 7, 12]
6) Sorted Array: [5, 5, 5, 7, 7, 12]

3. Nearly-sorted: [2, 3, 5, 7, 13, 11]

1) Sorted Array: [2]
2) Sorted Array: [2, 3]
3) Sorted Array: [2, 3, 5]
4) [2, 3, 5, 7]
5) Sorted Array: [2, 3, 5, 7, 13]
6) Sorted Array: [2, 3, 5, 7, 11, 13]



## Efficency

In the best case scenario , time complexity will be O(n) if its already sorted
in worst case it will be O(n^2)

Space complexity will be O(1)
As it sort it in place using swapping, without requiring additional memory
