using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Etage
    {
        public Panel Panel;
        public Scanner Scanner;
        public Turret Turret;
        public Kontrol Kontrol;
        public Elevator Elevator;
        public Etage_Panel Etage_Panel;
        public Etage()
        {
            Panel = new Panel(Kontrol);
            Turret = new Turret(Kontrol);
            Scanner = new Scanner(Kontrol);
            Kontrol = new Kontrol(Turret, Panel, Scanner, Elevator);
        }

    }
}
