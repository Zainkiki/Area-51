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

        public void TurretReceivesRequests()
        {
            Console.WriteLine("Turret: The order has been received");
        }

        public void TurretSendsKillStatus()
        {
            Kontrol.KontrolReceivesResponses("Turret");
        }
    }
}
