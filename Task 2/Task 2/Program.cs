using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    internal class Program
    {
        public static string PointsCondition(string circle, string points) // must change input types!
        {
            string[] stringCircle = circle.Split();//string array of circles coordinates
            string[] stringPoints = points.Split();//string array of points coordinates

            double[] doubleCircle = new double[stringCircle.Length];
            double[] doublePoints = new double[stringPoints.Length];

            for (int i = 0; i < stringCircle.Length; i++) doubleCircle[i] = double.Parse(stringCircle[i]); //int array of circles coordinates
            for (int i = 0; i < stringPoints.Length; i++) doublePoints[i] = double.Parse(stringPoints[i]);//int array of points coordinates

            double circleX = doubleCircle[0];
            double circleY = doubleCircle[1];
            double radiusCircle = doubleCircle[2];

            int x = (doublePoints.Length / 2);

            int chet = 0;
            double[] myPointsArrX = new double[x];
            for (int i = 0; i < x; i++)
            {
                myPointsArrX[i] = doublePoints[chet]; //even poins coordinates array
                chet += 2;
            }

            int nechet = 1;
            double[] myPointsArrY = new double[x]; //odd poins coordinates array
            for (int i = 0; i < x; i++)
            {
                myPointsArrY[i] = doublePoints[nechet];
                nechet += 2;
            }

            /*string arrayX = ""; //Convert to string X
            for (int i = 0; i < x; i++) arrayX += myPointsArrX[i];

            string arrayY = ""; //Convert to string Y
            for (int i = 0; i < x; i++) arrayY += myPointsArrY[i];
            */


            string result = "";
            string res = "";
            double d = 0;
            for (int i = 0; i < x; i++)
            {

                d = Math.Sqrt(Math.Pow((myPointsArrX[i] - circleX), 2) + (Math.Pow((myPointsArrY[i] - circleY), 2)));
                if (d < radiusCircle) res = "1"; //in a circle
                else if (d > radiusCircle) res = "2"; //outside of circle 
                else res = "0"; //on the circle
                result += res;
            }
            return result;

        }

        static void Main(string[] args)
        {
            //string y = PointsCondition("3 3 5", "1 8 9 6 6 6"); the answer is 221
            Console.WriteLine("Введите x, y, r круга через пробелы + Enter");
            string c = Console.ReadLine();
            Console.WriteLine("Введите х, у точек через пробелы + Enter");
            string b = Console.ReadLine();
            
            string y = PointsCondition(c, b);
            Console.WriteLine(y);
        }
    }
}
