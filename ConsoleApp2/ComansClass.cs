using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
        public class Plant
        {
            public int Height { get; set; }
            public int Weight { get; set; }
            public int Width { get; set; }

           public Plant() : this(0,0,0)
           {

           }

            public Plant(int height, int weight) 
            {
                this.Height = height;
                this.Weight = weight;
                //Console.WriteLine($"Рост: {this.Height}, Вес: {this.Weight}");
            }

            public Plant(int height, int weight, int width)
            {
                this.Height = height;
                this.Weight = weight;
                this.Width = width;
                //Console.WriteLine($"Рост: {this.Height}, Вес: {this.Weight}, Ширина: {this.Width}");
            }

        public Plant(Plant plant) :this(plant.Height, plant.Weight)
        {
         
        }
    }


    public class ArrayOverload
    {
        private double[] array = new double[10];

        public double this[int index]
        {
            get { return array[index - 5]; }
            set { array[index - 5] = value; }
        }

        public double this[double index]
        {
            get { return array[Convert.ToInt32(index) - 5]; }
            set { array[Convert.ToInt32( index )- 5] = value; }
        }
    }


}
