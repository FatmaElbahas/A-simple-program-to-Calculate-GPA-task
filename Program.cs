namespace ConsoleApp111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR GRADE:");
            double grade = Convert.ToDouble (Console.ReadLine());
            if (grade < 60) 
            {
                Console.WriteLine("F");
            }
            else if(grade >=60 && grade<70)
            {
                Console.WriteLine("D");

            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("C");

            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("B");
            }
            else 
            {
                Console.WriteLine("A");
            }
        }
        
    }
}