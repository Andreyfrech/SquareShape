using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareShape
{
  public  class Triangle : IShape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }


        public string TypeN { get; set; }

        //Определяем и устанавливаем стороны треугольника
        public Triangle(string typeName, double A, double B, double C)
        {
            if (IsExists(A, B, C))
            {
                sideA = A;
                sideB = B;
                sideC = C;
                TypeN = typeName;
            }
        }
        
        //Проверяем, существует ли треугольник с такими сторонами
        private bool IsExists(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
            {
                throw new Exception("Такого треугольника не существует, одна или несколько сторон меньше нуля");
            }

            if (A > (B + C) || B > (A + C) || C > (A + B))
            {
                throw new Exception("Такого треугольника не существует, одна или несколько сторон больше суммы двух других сторон");

            }

            return true;
        }

        //Рассчитываем площадь треугольника
        public  double Square()
        {
            double p = (sideA + sideB + sideC) / 2;
            double square = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return square;
        }

        //Проверяем, является ли треугольник прямоугольным
        public bool IsStraightTriangle()
        {
            bool IsStraight = (sideA == Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2))) 
                           || (sideB == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2)))
                           || (sideC == Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));

            return IsStraight;
        }

      
    }
}
