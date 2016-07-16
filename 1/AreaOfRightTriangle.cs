using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    public class AreaOfRightTriangle
    {
        /// <summary>
        ///  Вычисляет площадь правильного треугольника,
        ///  используя катет A, катет B и гипотенузу C
        /// </summary>
        /// <param name="legA">Катет А</param>
        /// <param name="legB">Катет B</param>
        /// <param name="hypC">Гипотенуза C</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="IsRightTriangle"></exception>
        public static double CalcArea(double legA, double legB, double hypC)
        {
            // Сокрытие магического числа
            const double ZERO = 0.0;

            // Идея проверки общая для любого треугольника и может быть вынесена 
            // в более абстрактный класс "Треугольник"
            var isHasValLessThanZero = (legA <= ZERO) || (legB <= ZERO) || (hypC <= ZERO);                       
            if (isHasValLessThanZero)
                // Впоследствии могжет быть заменено на исключение библиотеки
                throw new ArgumentOutOfRangeException("Значение сторон треугольника должны быть строго >= 0"); 

            // Для того, чтобы не вычислять по формуле Герона
            // (избавиться от квадратного корня, который вносит погрешность вычисления)
            var isRightTriangle = IsRightTriangle(legA, legB, hypC);
            if (isRightTriangle == false)
                // Впоследствии может быть заменено на исключение библиотеки
                throw new NotSupportedException("Треугольник не является прямоугольным");

            // Используется то, что высота прямоугольного треугольника
            // совпадает с одним из катетов, а второй катет с основанием.
            return 0.5 * legA * legB;
        }

        // В библиотеке данный метод, можно сделать методом класса 
        // "Правильный треугольник", который и будет проверять выполнение формулы Пифагора.        
        public static bool IsRightTriangle(double legA, double legB, double hypC)
        {
            var sqrLegA = Math.Pow(legA, 2);
            var sqrLegB = Math.Pow(legB, 2);
            var sqrHypC = Math.Pow(hypC, 2);

            // Из теоремы Пифагора a^2 + b^2 - c^2 = 0
            var diffSides = Math.Abs(sqrLegA + sqrLegB - sqrHypC);

            // Math.Truncate убирает возможную погрешность для вещественых чисел
            bool isRightTriangle = Math.Truncate(diffSides) == 0;

            return isRightTriangle;
        }
    }
}
