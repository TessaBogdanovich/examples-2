int[,] pic = new int[,];
void PrintImage(int [,] image)

{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
           if (image[i, j] == 0) System.Console.Write($" "); 
           else System.Console.Write($"+");
        }
    System.Console.WriteLine();
    }
}

PrintImage(pic);
