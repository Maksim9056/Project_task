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
            Console.WriteLine("Введите первое число типом int ");
            var Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число int ");

            var NumberTwo =Convert.ToInt32( Console.ReadLine());
            var result = @class.SUM(Number, NumberTwo);

            Console.WriteLine("Результат" + ":" + result.ToString());

        }

        /// <summary>
        /// Вторая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheSecond(GlobalClass @class)
        {
            Console.WriteLine("Введите первое число типом int ");

            var Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число int ");

            var NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третие число int ");

            var Numberthird = Convert.ToInt32(Console.ReadLine());

            var result  =    @class.SUM(Number, NumberTwo, Numberthird);
            Console.WriteLine ("Результат"+":"  +result.ToString());
        }




        /// <summary>
        /// Третья команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheFourth(GlobalClass @class)
        {
            Console.WriteLine("Введите первое число типом int ");

            var Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число int ");

            var NumberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третие число int ");

            var Numberthird = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число int ");


            var NumberFourth = Convert.ToInt32(Console.ReadLine());

            var result = @class.SUM(Number, NumberTwo, Numberthird,NumberFourth);
            Console.WriteLine("Результат" + ":" + result.ToString());

        }



        /// <summary>
        /// Четвертая  команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandthedDouble(GlobalClass @class)
        {
            Console.WriteLine("Введите первое число типом int ");
            var Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число int ");

            var NumberTwo = Convert.ToInt32(Console.ReadLine());
            var result = @class.SUM(Number, NumberTwo);
            Console.WriteLine("Результат" + ":" + result.ToString());

        }

        /// <summary>
        /// Пятая команда
        /// </summary>
        /// <param name="class"></param>
        internal void CommandTheFifth(GlobalClass @class)
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

    }
}
