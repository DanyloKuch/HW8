using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    // Принцип порушено: Принцип заміщення Лісков (Liskov Substitution Principle).
    // Проблема: Клас Square наслідується від класу Rectangle, але має іншу поведінку для властивостей Width і Height.
    // Квадрат повинен бути окремим класом, оскільки він має іншу логіку, ніж прямокутник (однакові сторони для квадрата).

    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }

    // Квадрат не наслідується від прямокутника, а є окремим класом
    class Square
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }

    


}
