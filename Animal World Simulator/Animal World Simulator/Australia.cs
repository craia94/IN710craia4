﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_World_Simulator
{
    public class Australia : Continent
    {
        public Australia(ListBox displaybox, Random rGen, int nAnimalTypes, Graphics canvas)
            : base(displaybox, rGen, nAnimalTypes, canvas)
        {
            animalFactory = new AustraliaAnimalFactory();
        }
    }
}
