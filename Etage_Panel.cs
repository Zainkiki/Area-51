using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Etage_Panel
    {
        public Elevator Elevator;
        public Kontrol Kontrol;

        public Etage_Panel(Elevator elevator, Kontrol kontrol) 
        {
            Elevator = elevator;
            Kontrol = kontrol;
        }

        public void Etage_PanelReceivesRequests()
        {
        }
    }
}
