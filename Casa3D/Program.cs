﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tele3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Game game = new Game(800, 600, "LearnOpenTK");
            game.Run(60.0);
        }
    }
}
