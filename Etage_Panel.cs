using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Etage_Panel
    {
        public Elevator Elevator;

        public Etage_Panel(Elevator elevator) 
        {
            Elevator = elevator;
        }

        public void Etage_PanelReceivesRequests()
        {
            Console.WriteLine("Etage_Panel: safety information has been Received");
        }
    }
}
