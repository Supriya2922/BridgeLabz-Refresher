namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter diameter of the circle:");
        double diameter = Convert.ToDouble(Console.ReadLine());
        double radius = diameter / 2;
        double perimeter = 2 *Math.PI * radius;
        Console.WriteLine("Perimeter of circle :" + perimeter);
        double area=Math.PI*Math.Pow(radius, 2);
        Console.WriteLine("Area of cricle :"+area);
    }
}