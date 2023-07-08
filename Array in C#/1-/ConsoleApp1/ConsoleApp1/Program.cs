int[] ints= new int[3] {20,30,40};
//ints[0] = 15;
//ints[1] = 20;
//ints[2]=30;

Console.WriteLine(ints[2]);

//
int[,] ints1 = new int[2, 3];
ints1[0, 0] = 5;
ints1[0, 1] = 6;
ints1[0, 2] = 7;

ints1[1, 0] = 68;
ints1[1,1]=9;
ints1[1,2]=10;
//5 6 7
//68 9 10
Console.WriteLine(ints1[1,2]);

// 3d
string[,,] color = new string[2, 3, 2]
{
    {{"red","blue"},{"green","black"},{"cryn","red blur"} },
     {{"red1","blue1"},{"green2","black2"},{"cryn3","red blur3"} },
};
Console.WriteLine("color is  "+color[1,0,0]);

//jagged
int[][] students = new int[3][];
students[0] = new int[3];
students[1] = new int[2];
students[2] = new int[1];

students[0][0] = 22250;
students[0][1] = 2250;
students[0][2] = 2550;

students[1][0] = 2850;
students[1][1] = 25220;

students[2][0] = 2750;

Console.WriteLine("jagged :  "+ students[0][1]);