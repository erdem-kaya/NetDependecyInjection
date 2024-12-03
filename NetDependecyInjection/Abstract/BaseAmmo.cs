using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDependecyInjection.Abstract
{
    public abstract class BaseAmmo : IAmmo
    {
        protected double power;
        public void Fire()
        {
            Console.WriteLine("power" + power + "\tFired.");
        }
    }

}
