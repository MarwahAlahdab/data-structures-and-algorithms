# Implementation: Hash Tables
Implement a Hashtable Class with the following methods:

set, get, has, keys, hash

## Whiteboard Process
![](./whiteboared.jpeg)

Note: code and test cases provided in the repo

## Approach & Efficiency

The Hashtable uses a basic hashing algorithm to map keys to array indices. The algorithm:

1. Converts each character in the key to its ASCII value and sums them up.
2. Multiplies the sum by a prime number (599 in this implementation).
3. Takes the modulo of the result by the size of the array to get the array index.

### Set Method
The `Set` method stores key-value pairs in the Hashtable. It calculates the hash of the key, determines the index in the array, and adds the key-value pair to a linked list at that index. If a collision occurs, it handles it by adding the new pair to the linked list.

### Get Method
The `Get` method retrieves the value associated with a key. It calculates the hash of the key, finds the index in the array, and searches the linked list at that index for the key. If found, it returns the value; otherwise, it returns null.

### Has Method
The `Has` method checks if a key exists in the Hashtable. It calculates the hash of the key, finds the index in the array, and searches the linked list at that index for the key. If found, it returns true; otherwise, it returns false.

### Key Method
The `Key` method returns a list of all unique keys in the Hashtable. It traverses the entire Hashtable, collects unique keys, and returns them in a list.



## Solution

### How to Use

1. Create an instance of the `HashMap` class, specifying the desired size.
2. Use the `Set` method to add key-value pairs.
3. Use the `Get` method to retrieve values by key.
4. Use the `Has` method to check for key existence.
5. Use the `Key` method to retrieve a list of unique keys.


6. Use the `RepeatedWord` method to find the first word to occur more than once in a string




```csharp
var hashMap = new HashMap(10);
hashMap.Set("key1", "value1");
hashMap.Set("key2", "value2");

string value = hashMap.Get("key1"); // Returns "value1"
bool exists = hashMap.Has("key2");   // Returns true
List<string> keys = hashMap.Key();   // Returns ["key1", "key2"]
