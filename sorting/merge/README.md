# Blog Notes: Merge Sort

Merge Sort is a fast sorting algorithm, that follows the **devide and conqure** approach
to sort an array.
It divides its input into two halves until it reaches arrays of size 1 or less than one.
Then compare and merges each 2 halfs together, until we have the full array sorted.

I made this whiteboard to show how this algorithm will work on this sample array, step by step:

![whiteboard](./Merge%20sort.jpeg)


**Time complexity:**

The time complexity of the Merge Sort algorithm is O(n log n) in the worst, average, and best cases.

**Space complexity:**

The space complexity of the Merge Sort algorithm is O(n) because it requires additional space to store the two halves of the array during the splitting phase and a temporary array to merge the sorted halves back together.

This use of additional space makes it less memory-efficient than some other sorting algorithms like Quick Sort, which has a space complexity of O(log n).


