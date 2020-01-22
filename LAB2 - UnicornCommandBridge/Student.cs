﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Student : Användare, IStudent
    {
        public List<Betyg> betyg = new List<Betyg>();


        public Student(string användarId, string namn) : base(användarId, namn)
        {
            this.betyg = new List<Betyg>();
            this.kurser = new List<Kurs>();

        }
        public override string ToString()
        {
            return användarId + " " + namn;
        }

    }
}
