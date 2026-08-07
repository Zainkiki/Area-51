using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Turret
    {
        public Kontrol Kontrol;

        public Turret(Kontrol kontrol)
        {
            Kontrol = kontrol;
        }

        public bool TurretOrderShoot()
        {
            Console.WriteLine("Turret: The order has been received");
            return true;
        }
    }
}
