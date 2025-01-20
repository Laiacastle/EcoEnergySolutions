using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergySolutions
{
    public abstract class SistemaEnergia
    {
        protected DateTime Date {get;set;}
        protected string? Type { get; set; }
        
    }
}