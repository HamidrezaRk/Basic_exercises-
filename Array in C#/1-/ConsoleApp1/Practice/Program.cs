//C# Array Exercise
Console.WriteLine("C# Array Exercise");

//Practice -1

//int[] Number = new int[9];
//for (int i = 0;i<9;i++)
//{
//    Console.WriteLine("Enter Your Number {0}: ",i);
//    Number[i] = int.Parse(Console.ReadLine());
//}

//for (int b =0; b< Number.Length;b++)
//{
//    Console.WriteLine("Element {0} : {1}",b, Number[b]);
//};

//Practice -2

//int[] numbertow= new int[3];
//for(int i = 0; i< numbertow.Length; i++)
//{
//    Console.WriteLine("Enter Number :");
//    numbertow[i]=int.Parse(Console.ReadLine());
//}
//for(int b =0;b<numbertow.Length;b++)
//{
//    Array.Sort(numbertow);
//    Console.WriteLine("Sorted Araay {0}", numbertow[b]);
//}

//Practice -3
int[,] Array2D = new int[3,3];
for (int i = 0;i<3;i++)
{
	for (int d = 0; d < 3; d++)
	{
		Console.WriteLine("Add Value in Array :");
		Array2D[i,d]=int.Parse(Console.ReadLine());
	}
}

Console.Write("\nThe matrix is : \n");

for (int i = 0; i < 3; i++)
{

    //Console.Write("\n");

    for (int d = 0; d < 3; d++)
       

    {
        Console.WriteLine("{0}\t ", Array2D[i, d]);
       // Console.Write("\n\n");
    }

}
   
