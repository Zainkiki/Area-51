using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Elevator
    {
        public Kontrol Kontrol;
        public Etage_Panel ElevatorPanel;

        public Elevator(Kontrol kontrol)
        {
            Kontrol = kontrol;
            
        }
    }
}
