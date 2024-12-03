using NetDependecyInjection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDependecyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weaponX = new Weapon(new XAmmo());
            Weapon weaponY = new Weapon(new YAmmo());

            weaponX.Fire();
            weaponY.Fire();

        }
    }
}
