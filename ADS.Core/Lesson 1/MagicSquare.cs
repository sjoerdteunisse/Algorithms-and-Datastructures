using System;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace ADS.Core.Lesson_1
{
    /// <summary>
    ///• zet het getal 1 in het hokje met de coördinaten ((n+1)/2 , n)
    ///•je gaat naar het volgende hokje via de vector(1,1), dat wil zeggen: één naar rechts en één naar boven;
    ///•als je buiten de matrix komt ga je verder via de vector(0, -n) en/of(-n, 0), afhankelijk van het feit welke van de bewerkingen je weer in de matrix terug brengt;
    ///•als je dan in een leeg hokje komt zet je daarin het volgende getal;
    ///•als het hokje al gevuld is ga je eerst terug naar het laatst gevulde hokje en van daar via de vector(0, -1) verder.
    /// </summary>
    public class MagicSquare
    {

        public void Execute(int n)
        {
            if (n % 2 == 0)
                throw new SystemException("Only odd numbers work.");

            var squares = new int[n, n];

            var posX = n / 2; //
            var posY = n - 1; //-1 as array pos starts at 0

            //N*(N^2+1)/2
            //Put all values in the sqaure
            for (var num = 1; num <= n * n;)
            {
                //Check bounds.
                //If the calculated row position is -1 & calculated column position is n
                //the new position would be: (0, n-2).
                if (posX == -1 && posY == n)
                {
                    //Set Y
                    posY = n - 2; //new position: (0, n-2).
                    //reset X
                    posX = 0; // 
                }
                else
                {
                    //•	als je buiten de matrix komt ga je verder via de vector (0, -n) en/of (-n, 0),
                    //afhankelijk van het feit welke van de bewerkingen je weer in de matrix terug brengt;

                    //1st condition if next number  
                    //out of square's right side 
                    if (posY == n)
                        posY = 0; //(0, -n);

                    //1st condition if next number   
                    //of square's upper side 
                    if (posX < 0)
                        posX = n - 1; //(-n,0)
                }

                //If the magic square already contains a number at the calculated position,
                //calculated column position will be decremented by 2, and calculated row position (X) will be incremented by 1.

                //2nd condition 
                //Condition:
                //If the magic square already contains a number at the calculated position,
                //calculated column position will be decremented by 2, and calculated row position will be incremented by 1
                if (squares[posX, posY] != 0)
                {
                    posY -= 2;
                    posX++;
                    continue; // Returns to for loop and itterates next
                }
                else
                {//Set number
                    var value = num++;

                    Console.WriteLine($"setting value of {value} on cordinate X:{posX} Y:{posY}");
                    squares[posX, posY] = value;
                }

                // 1.The position of next number is calculated by decrementing row number of previous number by 1,
                // and incrementing the column number of previous number by
                //1st condition 
                posY++;
                posX--;
            }


            //Print square
            Console.WriteLine("\nThe Magic Square for "
                              + n + ":");
            Console.WriteLine("Sum of each row or column "
                              + n * (n * n + 1) / 2 + ":\n");

            for (var d = 0; d < n; d++)
            {

                for (var z = 0; z < n; z++)
                {
                    Console.Write(squares[d, z] + "\t");
                }

                Console.WriteLine("\n");
            }
        }



        public void ExecuteCorrect(int squareSize)
        {
            if (squareSize % 2 == 0)
                throw new SystemException("Only odd numbers work.");

            var squares = new int[squareSize, squareSize];
            Console.WriteLine($"Create a square of {squareSize } X {squareSize}");
            var posX = (squareSize + 1) / 2;
            Console.WriteLine($"Initial X position set to: {posX}");

            var posY = squareSize; //-1 as array pos starts at 0
            Console.WriteLine($"Initial Y position set to: {posY}");

            var iteration = 1; //start pos
            Console.WriteLine($"Start count at {iteration}");

            //Set N=1 on 1,1
            //Set initial square value on 1;1
            squares[squareSize - posY, posX - 1] = iteration;
            Console.WriteLine($"Set initial square value on X{squareSize - posY} - Y: {posX - 1} with value {iteration}");

            //Put all values in the sqaure
            for (var i = 0; i < squareSize * squareSize - 1; i++)
            {
                Console.WriteLine($"\niteration {i}");
                var oldPosX = posX;
                var oldPosY = posY;
                Console.WriteLine($"Set old position X{oldPosX} - Y: {oldPosY}");

                posX++;
                posY++;
                Console.WriteLine($"Set values X:{posX} - Y:{posY}");

                iteration++;
                Console.WriteLine($"increment value to:{iteration}");

                if (posY > squareSize)
                {
                    posY -= squareSize;
                    Console.WriteLine($"Reset Y :{posY}");
                }
                if (posX > squareSize)
                {
                    posX -= squareSize;
                    Console.WriteLine($"Reset X :{posX}");
                }

                //Check bounds.
                //If the calculated row position is -1 & calculated column position is n
                //the new position would be: (0, n-2).
                if (squares[squareSize - posY, posX - 1] == 0)
                { // not filled yet
                    Console.WriteLine($"Value not filled at X: {squareSize - posY}, Y: {posX - 1} with value:{iteration}");
                    squares[squareSize - posY, posX - 1] = iteration;
                }
                else
                {
                    //was filled; so set posY and X accordingly

                    //Go one down
                    posY = oldPosY - 1;
                    //X stays same
                    posX = oldPosX;

                    Console.WriteLine($"Value was filled at X: {squareSize - posY}, Y: {posX - 1} with value:{iteration}");
                    squares[squareSize - posY, posX - 1] = iteration;
                }
            }


            //Print square
            Console.WriteLine("\nThe Magic Square for "
                              + squareSize + ":");
            Console.WriteLine("Sum of each row or column "
                              + squareSize * (squareSize * squareSize + 1) / 2 + ":\n");

            for (var d = 0; d < squareSize; d++)
            {

                for (var z = 0; z < squareSize; z++)
                {
                    Console.Write(squares[d, z] + "\t");
                }

                Console.WriteLine("\n");
            }
        }





    



        public static void RunMagicSquare(int n)
        {
            // Create the grid variables
            int x = (n + 1) / 2;
            int y = n;
            int[,] matrix = new int[n, n];

            // Create a counter
            int count = 1;

            // Create variables for remembering the previous position
            int prevX = -1;
            int prevY = -1;

            // Loop for filling in the grid.
            for (int i = 0; i < n * n; i++)
            {
                // Boundary checks
                if (x > n) x -= n;
                if (y > n) y -= n;

                // Check if the current grid position is filled
                if (matrix[x - 1, y - 1] != 0)
                {
                    // TRUE: Retrieve the old coordinates
                    x = prevX;
                    y = prevY - 1;
                }

                // Fill the grid
                matrix[x - 1, y - 1] = count;

                // Up the counter, x and y position
                prevX = x; prevY = y;
                count++; x++; y++;

            }

            // Display the result
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[j, i - 1] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
