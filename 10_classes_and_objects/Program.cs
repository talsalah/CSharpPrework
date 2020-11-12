﻿using System;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //1    //2        //3    //4
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();
           
            //setting property values
            //1         //2         //3
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;

            Console.WriteLine(nickDonut.Filling);
        }
    }
}
