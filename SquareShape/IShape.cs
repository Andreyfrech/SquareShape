using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareShape
{
    interface IShape
    {
        //Получение типа фигуры
        public string TypeN { get; set; }

        //площадь фигуры
        public abstract double Square();
    }
}
