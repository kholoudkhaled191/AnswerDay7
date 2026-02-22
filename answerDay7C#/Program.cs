using answerDay7C_.inheritance;
using System;

namespace answerDay7C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //Car carOne =new Car();
            //Car carThree= new Car(1);
            //Car carTwo = new Car(2, "bmw");
            //Car carFour = new Car(3, "bmw", 100000);

            #endregion

            #region
            //Calculator calc1 =new Calculator();
            //calc1.Sum(2, 5);
            //calc1.Sum(2, 5, 7);
            //calc1.Sum(2.5, 5.5);
            #endregion


            #region
            //Child child1 =new Child(5,2,7);
            #endregion


            #region
            //Child child1 = new Child(5, 2, 7);
            //Console.WriteLine(child1.Product());

            //Parent parent1= new Parent(5, 2);
            //Console.WriteLine(parent1.Product());
            #endregion


            #region
            Child child2 = new Child(5, 2, 7);
            Console.WriteLine(child2.ToString());

            Parent parent2 = new Parent(5, 2);
            Console.WriteLine(parent2.ToString());
            #endregion

            #region
            IShape rectangle = new Rectangle(5, 3);
            rectangle.Draw();
            Console.WriteLine(rectangle.Area);
            #endregion

            #region
            IShape CircleOne = new Circle(5);
            CircleOne.Draw();
            CircleOne.PrintDetails();

            #endregion


            #region
            IMovable movable = new Car();
            movable.move();

            #endregion


            #region
            File fileOne = new File();
            fileOne.Read();
            fileOne.Write();
            #endregion

            #region
            Shape newRectangle = new _ٌRectangle(6, 4);
            newRectangle.Draw();
            Console.WriteLine(newRectangle.CalculateArea());
            #endregion
        }
    }

       
    
}
