﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases
{
    public class Guarnicion : Comida
    {
        bool sal;
        public bool Sal
        {
            get => sal;
            set => sal = value;
        }
    }
}