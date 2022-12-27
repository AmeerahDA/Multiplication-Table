using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array2D = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(" ");
            Console.Write("[");
            for (int j = 1; j <= 10; j++)
            {
                array2D[i-1,j-1]=i*j;
               // Console.Write(" "+array2D[i-1,j-1]+", ");
               if(array2D[i-1,j-1]<10){
                 Console.Write(" "+array2D[i-1,j-1]+", ");
               }else if((array2D[i-1,j-1]>=10)){
                 Console.Write(" "+array2D[i-1,j-1]+",");
               }else if(array2D[i-1,j-1]>=90){
                 Console.Write(" "+array2D[i-1,j-1]+",");
               }
                 

            }
            Console.Write("]");
        }


    }
}