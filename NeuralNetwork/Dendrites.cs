﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks
{
    public class Dendrites : DendriteBase
    {
        public Neurons Previous { get; set; }


        public Dendrites(Neurons previous)
        {
            Previous = previous;
        }

        public override double Compute()
        {
            return Previous.Output * weight;
        }

        
    }
}
