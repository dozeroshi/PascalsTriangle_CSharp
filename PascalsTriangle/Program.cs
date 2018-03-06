using System;

namespace PascalsTriangle
{
    class PascalsTriangle
    {
        //jaggedArray to hold the pascal values
        private int[][] jagged = new int[10][];

        /// <summary>
        /// The main method
        /// </summary>
        /// <remarks>
        /// To use from Visual Studio, press CTRL + F5 on Windows to run the console
        /// without immediately closing
        /// </remarks>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //our pascals triangle object
            PascalsTriangle PasTri = new PascalsTriangle();

            //fills the jagged array with the values in the relative indexes
            FillJaggedArray(PasTri.jagged);

            //iterate the jagged array and print the triangle
            PrintJaggedArray(PasTri.jagged);

        }//end Main()


        /// <summary>
        /// The FillJaggedArray method
        /// </summary>
        /// <remarks>
        /// This method instantiates the jagged arrays second-dimension array and
        /// then enters the appropriate values to reproduce Pascals Triangle
        /// </remarks>
        /// <param name="jagged"></param>
        public static void FillJaggedArray(int[][] jagged)
        {
            for(int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[i+1];
                //we should comfortably hardcode the _first_ value in Pascals Triangle
                jagged[i][0] = 1;

                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                        jagged[i][i] = 1;
                        continue;
                    }

                    jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
                }
            }
        }//end FillJaggedArray()


        /// <summary>
        /// The PrintJaggedArray method
        /// </summary>
        /// <remarks>
        /// This method accepts a filled jaggedArray representing Pascals Triangle
        /// and prints the values to the console
        /// </remarks>
        /// <param name="jagged"></param>
        public static void PrintJaggedArray(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write(" {0} ", jagged[i][j]);
                }
                Console.WriteLine();
            }
        }//end PrintJaggedArray()
    }
}
