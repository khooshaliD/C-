using System;
class Area
{
  public static void Main(string[]args)
  {
    double area, radius;
    const double pi= 3.14;
      Console.WriteLine("Enter the radius");
    radius= Convert.ToDouble(Console.ReadLine());
    area= pi*radius*radius;
    Console.WriteLine(" Area of the circle= {0}", area);
  }
}