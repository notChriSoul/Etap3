﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dane
{
   public class Circle : INotifyPropertyChanged {
        public double X { get; set; }
        public double Y { get; set; }
        public int Size { get; set; }
        public int Radius { get; set; }
        public double DirectionX { get; set; }
        public double DirectionY { get; set; }

        public double Speed { get; set; }

        public double Mass { get; set; }

        public int Id { get; set; }

        public Circle(int x, int y, int size, int radius, double speed, double mass, int id) {
            X = x;
            Y = y;
            Size = size;
            Radius = radius;
            Speed = speed;
            Mass = mass;
            Id = id;

            DirectionX = 0;
            DirectionY = 0;


            while (DirectionX == 0 && DirectionY == 0) {
                Random random = new Random();
                DirectionX = random.NextDouble() * 2.0 - 1.0;
                DirectionY = random.NextDouble() * 2.0 - 1.0;
            }

            Console.WriteLine("dir X: " + DirectionX + "dir Y: " + DirectionY + "Speed: " + speed);

            DirectionX *= speed/mass; 
            DirectionY *= speed/mass;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        static void Main(string[] args) {

        }
    }


}
