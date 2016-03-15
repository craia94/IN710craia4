﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class AustraliaAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Koala();
                    break;
                case 1:
                    newAnimal = new Crocodile();
                    break;
                case 2:
                    newAnimal = new Dingo();
                    break;
                case 3:
                    newAnimal = new Spider();
                    break;
            }
            return newAnimal;
        }
    }
}
