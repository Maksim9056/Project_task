using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// Класс процедур
    /// </summary>
    internal class GlobalClass
    {

      


        /// <summary>
        /// Отображает команды
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Первая команда 001 - Перегрузку метода SUM с сложением двух чисел int ");
            Console.WriteLine("Вторая команда  002 -  Перегрузку метода SUM с сложением трех чисел int");
            Console.WriteLine("Третья команда 003 - Перегрузку метода SUM с сложением трех чисел int");
            Console.WriteLine("Четвертая команда 004");
            Console.WriteLine("Пятая команда 005");

        }



        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="NumberSecond"></param>
        /// <returns></returns>
        public int SUM(int Number, int NumberSecond)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    Result = Number + NumberSecond;
                }
            }


            return Result;
        }
        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="NumberSecond"></param>
        /// <returns></returns>
        public int SUM(double Number, int NumberSecond)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    Result =Convert.ToInt32( Number) + NumberSecond;
                }
            }


            return Result;
        }

        /// <summary>
        /// Сложение трех цифр
        /// </summary>
        /// <param name="Number"  ></param>
        /// <param name="NumberSecond "></param>
        /// <param name="Numberthird "></param>
        /// <returns></returns>
        public int SUM(int Number, int NumberSecond, int Numberthird)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    if (Numberthird == null)
                    {

                    }
                    else
                    {
                        Result = Number + NumberSecond + Numberthird;


                    }
                }
            }
            return Result;
        }


        /// <summary>
        /// Сложение четырех чисел
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="NumberSecond"></param>
        /// <param name="Numberthird"></param>
        /// <param name="NumbertFourth"></param>
        /// <returns></returns>
        public int SUM(int Number, int NumberSecond, int Numberthird, int NumbertFourth)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    if (Numberthird == null)
                    {

                    }
                    else
                    {
                        if (NumbertFourth == null)
                        {

                        }
                        else
                        {
                            Result = Number + NumberSecond + Numberthird + NumbertFourth;

                        }
                    }
                }
            }
            return Result;
        }


        /// <summary>
        /// Сложение четырех чисел
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="NumberSecond"></param>
        /// <param name="Numberthird"></param>
        /// <param name="NumbertFourth"></param>
        /// <returns></returns>
        /// 
        public int SUM(int Number, double NumberSecond, double Numberthird, int NumbertFourth)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    if (Numberthird == null)
                    {

                    }
                    else
                    {
                        if (NumbertFourth == null)
                        {

                        }
                        else
                        {
                            Result = Number + Convert.ToInt32(NumberSecond) + Convert.ToInt32( Numberthird) + NumbertFourth;

                        }
                    }
                }
            }
            return Result;
        }


        ///// <summary>
        ///// Сложение двух чисел
        ///// </summary>
        ///// <param name="Number"></param>
        ///// <param name="NumberSecond"></param>
        ///// <returns></returns>
        //public int SUM(double Number, int NumberSecond)
        //{
        //    int Result = 0;
        //    if (Number == null)
        //    {

        //    }
        //    else
        //    {
        //        if (NumberSecond == null)
        //        {

        //        }
        //        else
        //        {
        //            Result =Convert.ToInt32(  Math.Round( Number) + Math.Round( NumberSecond));
        //        }
        //    }


        //    return Result;
        //}


        /// <summary>
        /// Сложение трех цифр
        /// </summary>
        /// <param name="Number"  ></param>
        /// <param name="NumberSecond "></param>
        /// <param name="Numberthird "></param>
        /// <returns></returns>
        public int SUM(int Number, double NumberSecond, int Numberthird)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    if (Numberthird == null)
                    {

                    }
                    else
                    {
                        Result = Number +Convert.ToInt32( Math.Round( NumberSecond ))+ Numberthird;


                    }
                }
            }
            return Result;
        }


        ///// <summary>
        ///// Сложение четырех чисел
        ///// </summary>
        ///// <param name="Number"></param>
        ///// <param name="NumberSecond"></param>
        ///// <param name="Numberthird"></param>
        ///// <param name="NumbertFourth"></param>
        ///// <returns></returns>
        //public int SUM(int Number, int NumberSecond, int Numberthird, int NumbertFourth)
        //{
        //    int Result = 0;
        //    if (Number == null)
        //    {

        //    }
        //    else
        //    {
        //        if (NumberSecond == null)
        //        {

        //        }
        //        else
        //        {
        //            if (Numberthird == null)
        //            {

        //            }
        //            else
        //            {
        //                if (NumbertFourth == null)
        //                {

        //                }
        //                else
        //                {
        //                    Result = Number + NumberSecond + Numberthird + NumbertFourth;

        //                }
        //            }
        //        }
        //    }
        //    return Result;
        //}


        /// <summary>
        /// Сложение четырех чисел
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="NumberSecond"></param>
        /// <param name="Numberthird"></param>
        /// <param name="NumbertFourth"></param>
        /// <returns></returns>
        /// 
        public int SUM(int Number, double NumberSecond, int Numberthird, int NumbertFourth)
        {
            int Result = 0;
            if (Number == null)
            {

            }
            else
            {
                if (NumberSecond == null)
                {

                }
                else
                {
                    if (Numberthird == null)
                    {

                    }
                    else
                    {
                        if (NumbertFourth == null)
                        {

                        }
                        else
                        {
                            Result = Number + Convert.ToInt32(NumberSecond) + Numberthird + NumbertFourth;

                        }
                    }
                }
            }
            return Result;
        }
    }
}
