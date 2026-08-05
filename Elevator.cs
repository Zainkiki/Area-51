using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Elevator
    {
        public Kontrol Kontrol;
        public Etage_Panel ElevatorPanel;
        public Etage EtageSt;
        public Etage EtageB1;
        public Etage EtageB2;
        public Etage EtageB3;



        public Elevator(Kontrol kontrol)
        {
            Kontrol = kontrol;
            
        }
        public void AccessGranted()
        {
            Console.WriteLine("Access has been Granted Entery allwoed!");
        }
    }
}
