Console.WriteLine("**Null Conditional oprator**");

//-1
//Car Car = null

//if (Car != null) 
//{
//    Console.WriteLine(Car.Name_Car);
//}

//-2
//Car Car = new Car();
//Car.Name_Car = "Benz";
////check nullable [?]
//Console.WriteLine(Car?.Name_Car);

//-3
//check or IsNullOrWhiteSpace

Car Car = null;
if(string.IsNullOrWhiteSpace(Car?.Name_Car))
{
    Console.WriteLine("is null");
}
else
{
    Console.WriteLine(Car.Name_Car);
}



public class Car
{
    public string Name_Car { get; set; }
    public string Model_Car { get; set; }
}

