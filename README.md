What is the problem
Imagine a standard 8 x 8 chess board

![image](https://user-images.githubusercontent.com/14345698/203093722-feba6f92-ef4b-4d28-a4db-a61e9eac9b93.png)


The idea is to find a way of placing 8 queens onto the board without them being in a position where they could take each other.  (For those that don’t know chess the queen can move any number of squares in any direction). 
Initially this seems simple – the first couple of queens you might place will not cause any issues  - but as you add more it becomes complex. Consider the following;
![image](https://user-images.githubusercontent.com/14345698/203093772-8604f1b5-3edf-4e85-9535-0bf79812486b.png)
At this point all the queens are safe from attaching each other, however no square in column H is free from attack;
![image](https://user-images.githubusercontent.com/14345698/203093840-4992c051-a225-46b7-8245-371909a7a976.png)

This code uses backtracking to establish all possible combinations of queens that can exist on a N sized board without them attacking each other. For an 8*8 chess board there are 92 possible combinations.
