using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareShape
{
  public  class Circle : IShape
    {

        public double Radius{ get; set; }

        //Устанавливаем радиус круга
        public Circle(string typeName, double R)
        {
            if (IsExists(R))
            {
                Radius = R;
                TypeN = typeName;
            }
        }


        public string TypeN { get; set; }

        //Рассчитываем площадь круга
        public double Square()
        {
            double square = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
            return square; 
        }
        
        //Проверяем. что радиус не отрицательный
        private bool IsExists(double R)
        {
            if(R < 0)
            {
                throw new Exception("Не существует круга с радиусом меньше 0");

            }

            return true;
        }
    }
}
