﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajlONlineServices.Parameters
{
   public class KategorijaParameters : QueryStringParameters
    {
        public KategorijaParameters()
        {
            OrderBy = "NazivKategorije";
        }
    }
}
