﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesComercio
{
    public class PersonaException :Exception
    {
        public PersonaException(string mensaje, Exception exception):base(mensaje, exception)
        {

        }
    }
}
