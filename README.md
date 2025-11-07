# 🔍 Binary Search vs Linear Search (C#)

This project compares the **execution time** of two classic search algorithms:
- **Binary Search**
- **Linear Search**

The program demonstrates how **algorithmic efficiency** affects execution time when searching for a value in a large dataset.

---

## 📘 Description

The program creates an array of **100 million integers** (`0` to `99,999,999`) and searches for the number `99,999,999` using:

1. **Binary Search**  
   Efficient search that divides the array in half each step.  
   Works only on **sorted** arrays.  
   Time complexity: **O(log n)**

2. **Linear Search**  
   Sequential search that checks one element at a time.  
   Works on any type of array.  
   Time complexity: **O(n)**

The code measures and prints the **execution time in milliseconds** for both searches.

---

## 🧠 Key Concepts

- **`DateTime.Now`** is used to measure start and end times of each search.
**`TimeSpan`** calculates the duration between those two moments.
- **Underscores (`_`)** in numbers improve readability (e.g., `100_000_000` = 100 million).
The array is filled sequentially, ensuring it's sorted for binary search.

---
## 🧪 Example Output
Num 99999999 encontrado en el índice 99999999 (binary search).  
Temps d'execució: 0.05 ms  
Num 99999999 encontrado en el índice 99999999 (búsqueda lineal).  
Temps d'execució: 300.24 ms  
