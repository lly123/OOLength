﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    class Decimeter
    {
        private int number;

        public Decimeter(int number)
        {
            this.number = number;
        }

        public static Decimeter operator+(Decimeter dm1, Decimeter dm2)
        {
            return new Decimeter(dm1.number + dm2.number);
        }

        public static Decimeter operator+(Decimeter dm, Meter m)
        {
            return new Decimeter(11);
        }

        public override bool Equals(object obj)
        {
            var decimeter = obj as Decimeter;
            return decimeter.number == number;
        }

        public override int GetHashCode()
        {
            return number;
        }
    }
}