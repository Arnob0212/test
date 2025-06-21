What is Big O Notation?
Big O notation helps to measure how fast or slow an algorithm works based on input size. It tells us the time it might take for large inputs.

For example:
- O(n) means the time increases linearly with input.
- O(log n) means the time increases slowly even if input grows fast.

Best, Average, and Worst Case
- **Best Case:** The element is found at the first position.
- **Average Case:** The element is somewhere in the middle.
- **Worst Case:** The element is not found or is at the last position.

---

Time Complexity

| Algorithm     | Best Case | Average Case | Worst Case |
|---------------|-----------|---------------|-------------|
| Linear Search | O(1)      | O(n)          | O(n)        |
| Binary Search | O(1)      | O(log n)      | O(log n)    |

Which is Better?
Binary search is faster than linear search **but needs sorted data**. If the data is not sorted, linear search is better.

For a large platform, **binary search is more suitable** if products are stored in a sorted way.

---
