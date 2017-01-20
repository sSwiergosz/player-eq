﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerEq
{

    public class CharacterClass
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public int Strength { get; set; }

        public int Defence { get; set; }

        public int Magic { get; set; }

        public double Capacity { get; set; }

        public CharacterClass() { }

        public CharacterClass(int id, string description, int strength, int defence, int magic, double capacity)
        {
            this.ID = id;
            this.Description = description;
            this.Strength = strength;
            this.Defence = defence;
            this.Magic = magic;
            this.Capacity = capacity;
        }
    }

}