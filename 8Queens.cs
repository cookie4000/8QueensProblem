using System;

public class Queens {
    
    // No of Queens
    private int[] queens;
    private static string queenLogo = "\u2655";
    public int noOfSolutions =0;
    public Queens(int size){
        this.queens = new int[size];
    }

    // Attempt to place the number of queens starting from Row 0
    public void Arrange(){
        PlaceQueens(0, queens.Length);
    }

    private void PlaceQueens(int row, int size)
        {
            
            // for each column in the row 
            for (int c = 0; c < size; c++)
            {   
                // if the queen can be placed in this column
                if (CanPlaceQueen(row, c))
                {   
                    // set the column for the current row
                    queens[row] = c;

                    // if all the rows are done - print the result
                    if (row == size - 1)
                    {   
                        PrintResult(queens);
                    }
                    else
                    {   
                        // Go to the next Row
                        PlaceQueens(row + 1, size);
                    }
                }
            }
        }

     private bool CanPlaceQueen(int row, int col)
        {   
            // For each row
            for (int i = 0; i < row; i++)
            {   // if you have a queen in the same column OR a diagonal threat return false
                if (queens[i] == col || (i - row) == (queens[i] - col) || (i - row) == (col - queens[i]))
                {
                    return false;
                }
            }
            return true;
        }
    
  private void PrintResult(int[] result)
        {
            int n = result.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (result[i] == j)
                    {
                        Console.Write(queenLogo);
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            // Completed Solve
            noOfSolutions++;
            Console.WriteLine("Solution: " + noOfSolutions.ToString());
            Console.WriteLine();
        }

        static void Main(string[] args) {
           Queens queens = new Queens(8);
           queens.Arrange();
        }
}



