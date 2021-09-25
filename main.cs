using System;

class Program {
  public static void Main (string[] args) {
    

    Console.WriteLine("How many cars are in the race?");
    int amount=Convert.ToInt32 (Console.ReadLine());

    int[] cars = new int[amount];
  
  foreach (int i in cars)

  {
    Console.WriteLine("Enter the distance covered by car " + i);
    double distance=Convert.ToDouble (Console.ReadLine());

    Console.WriteLine("Enter the time taken by car " + i);
    double time=Convert.ToDouble (Console.ReadLine());

    double speed= distance/time;

    Console.WriteLine("The speed of this car is " + speed + " miles per hour");
  }
}
}