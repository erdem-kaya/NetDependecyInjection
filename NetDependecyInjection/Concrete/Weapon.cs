using NetDependecyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDependecyInjection.Concrete
{
    public class Weapon
    {
        IAmmo usingAmmo;

        public Weapon(IAmmo ammo)
        {
            usingAmmo = ammo;
        }
        public void Fire()
        {
            usingAmmo.Fire();


        }
    }
}
