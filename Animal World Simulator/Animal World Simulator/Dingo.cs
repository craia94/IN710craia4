﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    class Dingo : Animal
    {
        public Dingo()
        {
            name = "Dingo";
            family = "Carnivore";
            food = "Rodents";
            image = new Bitmap("dingo.jpg");
        }
    }
}
