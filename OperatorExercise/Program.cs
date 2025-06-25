namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            var add = a + b;
            var subtract = a - b;
            var multiply = a * b;
            var divide = a / b;
            var modulus = a % b;
            
            var quotient = a / b;
            var remainder = a % b;
            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            
            Console.WriteLine ("What is the radius of the circle");
            var radius = double.Parse(Console.ReadLine()); 
            Console.WriteLine( "The area is "+ AreaOfCircle (radius));
            

        }
        
        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
