using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Panel
    {
        public Kontrol Kontrol;

        public Panel(Kontrol kontrol)
        {
            Kontrol = kontrol;

        }
        
        public void SendARequest()
        {
            Kontrol.ReceiveRequests("Panel");
        }
    }
}
