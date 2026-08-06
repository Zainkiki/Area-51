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
            Turret = new Turret(Kontrol);
            Scanner = new Scanner(Kontrol);
            Elevator = new Elevator(Kontrol);
            Panel = new Panel(Kontrol);
            Etage_Panel = new Etage_Panel(Elevator, Kontrol);
            Kontrol = new Kontrol(Turret, Panel, Scanner, Elevator, Etage_Panel);
        }

    }
}
