using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// Класс команд
    /// </summary>
    internal class Command
    {
        /// <summary>
        /// Первая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandThefirst(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типом int ");
                var Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число int ");

                var NumberTwo = Convert.ToInt32(Console.ReadLine());
                var result = @class.SUM(Number, NumberTwo);

                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch
            {

            }
        }

        /// <summary>
        /// Вторая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheSecond(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типом int ");

                var Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число int ");

                var NumberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третие число int ");

                var Numberthird = Convert.ToInt32(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo, Numberthird);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }




        /// <summary>
        /// Третья команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheFourth(GlobalClass @class)
        {
            try
            {

                Console.WriteLine("Введите первое число типом int ");

                var Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число int ");

                var NumberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите третие число int ");

                var Numberthird = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите четвертое число int ");


                var NumberFourth = Convert.ToInt32(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo, Numberthird, NumberFourth);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }



        /// <summary>
        /// Четвертая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedDouble(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типом double ");
                var Number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число int ");

                var NumberTwo = Convert.ToInt32(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

            }
        }

        /// <summary>
        /// Пятая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheFifth(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типом int ");

                var Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число double ");

                var NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третие число double ");

                var Numberthird = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите четвертое число int ");


                var NumberFourth = Convert.ToInt32(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo, Numberthird, NumberFourth);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Шестая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheSixth(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типа double ");

                var Number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число double ");

                var NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третие число double ");

                var Numberthird = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите четвертое число double ");


                var NumberFourth = Convert.ToDouble(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo, Numberthird, NumberFourth);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }




        /// <summary>
        /// Седьмая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedSeventh(GlobalClass @class)
        {
            try
            {
                Console.WriteLine("Введите первое число типом double ");
                var Number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число double ");

                var NumberTwo = Convert.ToDouble(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo);
                Console.WriteLine("Результат" + ":" + result.ToString());
            }
            catch(Exception ex) 
            {

                Console.WriteLine(ex.Message.ToString());
            }

        }


        /// <summary>
        /// Восьмая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedEighth(GlobalClass @class)
        {
            try
            {



                Console.WriteLine("Введите первое число типом double ");
                var Number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите второе число double ");

                var NumberTwo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третие число double ");

                var Numberthird = Convert.ToDouble(Console.ReadLine());

                var result = @class.SUM(Number, NumberTwo, Numberthird);
                Console.WriteLine("Результат" + ":" + result.ToString());
            } 
            catch (Exception ex) 
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }



        /// <summary>
        /// Девятая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedNinth(GlobalClass @class)
        {
            try
            {
                Plant plant = new Plant();
                Console.WriteLine("Plant 1: {0}, {1}, {2}", plant.Height, plant.Weight, plant.Width);

                Console.WriteLine("Введите Высоту ");
                var Высоту1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Введите Вес ");
                var Вес2 = Convert.ToInt32(Console.ReadLine());

                Plant plant22 = new Plant(Высоту1, Вес2);

                Console.WriteLine("Plant 1: {0}, {1}", plant22.Height, plant22.Weight);

                Console.WriteLine("Введите Высоту ");
                var Высоту = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Введите Вес ");
                var Вес = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Вес ");
                var Ширина = Convert.ToInt32(Console.ReadLine());

                Plant plant2 = new Plant(Высоту, Вес, Ширина);
                Console.WriteLine("Plant 1: {0}, {1}, {2}", plant2.Height, plant2.Weight, plant2.Width);


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }


        /// <summary>
        /// Десятая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedTenth(GlobalClass @class)
        {
            try
            {

                ArrayOverload arrayOverload = new ArrayOverload();

                // Перезаписываем значения в массиве с индексом от 5 до 10
                
                for (int i = 5; i <= 10; i++)
                {
                    if(i == 6)
                    {
                      Console.WriteLine( "Double "  , arrayOverload[6.99] = i * 1.5);

                    }
                    else
                    {
                        Console.WriteLine("Int ",  arrayOverload[i] = i * 1.5);

                    }



                }

                // Выводим значения массива с индексом от 5 до 10
                for (int i = 5; i <= 10; i++)
                {
                    Console.WriteLine("Значение с индексом {0}: {1}", i, arrayOverload[i]);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }








    }
}
