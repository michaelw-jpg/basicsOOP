namespace basicsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle newCircle = new Circle(5);
            Circle newCircle2 = new Circle(6);

            Console.WriteLine("Arean är : ");
            Console.WriteLine($"{newCircle.GetArea():F3}");
            Console.WriteLine($"{newCircle2.GetArea():F3}\n");

            Console.WriteLine("Omkretsen är : ");
            Console.WriteLine($"{newCircle.GetOmkrets():F3}");
            Console.WriteLine($"{newCircle2.GetOmkrets():F3}\n");

            Console.WriteLine("Volymen om den är en sfär är: ");
            Console.WriteLine($"{newCircle.GetAreaSphere():F3}");
            Console.WriteLine($"{newCircle2.GetAreaSphere():F3}\n");
            
            //F3 means round off to 3 decimals
        }
    }


    // circle class with methods for calculating area/circumference and volume
    public class Circle
    {
        int _radie;
        
        public Circle(int radie)
        {
            _radie = radie;
        }

        //method för calculating sphere Math.PI = the number PI , Math.Pow means power of aka (_radie ^ 3)
        //Apparently using Math.POW might be alot slower in some cases then manually writing (_radie*_radie*_radie) according to stackoverflow i have not tested this myself but good note if true
        // Source :https://stackoverflow.com/a/44354660
        public double GetAreaSphere()
        {
            double area = 4 * Math.PI * Math.Pow(_radie,3) / 3;
            return area;
        }
        public double GetOmkrets()
        {
            double omkrets = (2 * _radie) * Math.PI;

            return omkrets;
        }
        public double GetArea()
        {
            double pi = Math.PI;

            double area = _radie * _radie * pi; 
            
            return area;
        }


    }


}
