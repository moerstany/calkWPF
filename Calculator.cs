﻿using System;
using System.Windows;

namespace CalkinWPF
{


    /// <summary>
    /// Статический класс для вычесления арифметических действий
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Подсчёт суммы двух чисел
        /// </summary>
        /// <param name="x">Первое число</param>
        /// <param name="y">Второе число</param>
        /// <returns>Сумма чисел</returns>
        public static double Add(double x, double y) => x + y;

        /// <summary>
        /// Подсчёт разницы двух чисел
        /// </summary>
        /// <param name="x">Первое число</param>
        /// <param name="y">Второе число</param>
        /// <returns>Разница чисел</returns>
        public static double Sub(double x, double y) => x - y;

        /// <summary>
        /// Подсчёт произведения двух чисел
        /// </summary>
        /// <param name="x">Первое число</param>
        /// <param name="y">Второе число</param>
        /// <returns>Произведение чисел</returns>
        public static double Mult(double x, double y) => x * y;

        /// <summary>
        /// Подсчёт возведения в степень 
        /// </summary>
        /// <param name="x">Число</param>
        /// <param name="y">степень</param>
        /// <returns>Возведение в степень</returns>
        public static double Pow1(double x, double y) => Math.Pow(x, y);

        /// <summary>
        /// Подсчёт извлечение квадратного корня
        /// </summary>
        /// <param name="x">Число</param>
        /// <returns>Извлечение квадратного корня</returns>
        public static double Sqrt1(double x) => Math.Sqrt(x);

        /// <summary>
        /// Подсчёт деления двух чисел
        /// </summary>
        /// <param name="x">Первое число</param>
        /// <param name="y">Второе число</param>
        /// <returns>Результат деления</returns>
        /// <exception cref="DivideByZeroException">Если второе число равно 0</exception>
        public static double Div(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Делить на ноль нельзя!");
            }

            return x / y;
        }


    }
}


    