using System;

namespace Cet301;

class program
{   //sort,peak,transpose
    static void Main(String[] strings)
    {   
        //created a 2D array with random method between 0,99
        int[,]  array = new int[2,99];
        Random rnd = new Random();
        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 99; column++)
            {
                array[row, column] = rnd.Next(0, 99);
            }
        }
        
        
        
        
        
        //find the peak value between first and second row
        int i = 0;
        int max = 0;
        while (i < 2)
        {
            int max2 = 0;
            
            for (int j = 0; j < 99; j++)
            {
                if (array[i, j] > max2)
                {
                    max2 = array[i, j];
                }
            }

            if (max2 > max)
            {
                max = max2;
            }
            i++;
        }
        
        
        
        
        // sort 2D array from min to max
        int a = 0;
        while (a < 2)
        {
            for (int b = 0; b < 99; b++)
            {
                for (int c = b + 1; c < 99; c++)
                {
                    if (array[a, c] < array[a, b])
                    {
                        int temp = array[a, c];
                        array[a,c] = array[a,b];
                        array[a, b] = temp;
                    }
                }
            }

            a++;
        }
        
        
        
        // write the array to screen | you can use anywhere wherever you want
        int z = 0;
        while (z < 2)
        {
            for (int y = 0; y < 99; y++)
            {
                Console.Write(array[z,y]+" ");

            }
            Console.WriteLine();
            z++;
        }
        
        // transpose the array
        int zz = 0;
        while (zz < 99)
        {
            for (int y = 0; y < 2; y++)
            {
                Console.Write(array[y,zz]+" ");

            }
            Console.WriteLine();
            zz++;
        }
        
    }
}

