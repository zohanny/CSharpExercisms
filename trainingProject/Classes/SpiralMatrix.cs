using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject.Classes
{
    public class SpiralMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            int[,] matrix = new int[size,size];

            return FillMatrix(PrepareMatrix(matrix, size), size);
  
        }

        private static int[,] PrepareMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] =  0;
                }
            }
            return matrix;
        }

        private static int[,] FillMatrix(int[,] matrix, int size)
        {
            int lin = 0, col = -1;
            bool horiz = true;
            bool rev = false;
            int distanceEdge = 0;

            for (int i = 0; i < size*size ; i++)
            {
                // Top Right Corner
                if (col == size - 1 - distanceEdge)
                {
                    horiz = false;
                    rev = false;
                    
                    // Bottom Right Corner
                    if (lin == size - 1 - distanceEdge)
                    {
                        rev = true;
                        horiz = true;
                    }
                }

                // Bottom Left corner
                if (col == distanceEdge && rev && horiz)
                {
                    horiz = false;
                    rev = true;
                }
                    // Top Left Corner
                if (lin == distanceEdge+1 && !horiz && rev)
                {
                    rev = false;
                    horiz = true;
                    distanceEdge++;
                }
                

                // right
                if (horiz & !rev)
                    col++;
             

                //  Down
                if (!horiz & !rev)
                    lin++;
              

                // Left
                if (horiz & rev)
                    col--;
              
                
                // Up
                if (!horiz & rev)
                    lin--;
              

                matrix[lin, col] = i+1;
            }
            return matrix;
        }
    }
}
