using System;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
            //Definerar en metod eller funktion som är tillgänglig för alla(public) som har koppling till 
        {

            //skapa objekt av class typ box
            Box box = new Box();            Box box2 = new Box();

            Console.WriteLine("Ange längd för box1 ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange bredd för box1 ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange höjd för box1  ");
            double n3 = double.Parse(Console.ReadLine());


            //ställa in värden i objektproportioner 2
            box.längd = n1;
            box.bredd = n2;
            box.höjd = n3;
            double volym = box.getVolym();
            double Area = box.getArea();

            Console.WriteLine("Ange längd för box2  ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange bredd för box2  ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange höjd för box2 ");
            n3 = double.Parse(Console.ReadLine());


            //ställa in värden i objektproportioner 2
            box2.längd = n1;
            box2.bredd = n2;
            box2.höjd = n3;



            //Få värden från objekt
            Console.WriteLine($"Box 1 Dimension är: {box.längd}, {box.bredd}, {box.höjd},");
            Console.WriteLine($"Box 1 Volym är: {volym}");
            Console.WriteLine($"Box 1 Area är: {Area}");

            //Få värden från objekt 2
            Console.WriteLine($"Box2 Dimension är: {box2.längd}, {box2.bredd}, {box2.höjd},");
            Console.WriteLine($"Box2 Volym är: {box2.getVolym()}");
            Console.WriteLine($"Box2 Area är: {box2.getArea()}");
        }


    }
 }
