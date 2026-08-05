using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Kontrol
    {
        public Kontrol(Turret turret, Panel panel, Scanner scanner, Elevator elevator)
        {
            Turret = turret;
            Panel = panel;
            Scanner = scanner;
            Elevator = elevator;
        }


        public Turret Turret;
        public Panel Panel;
        public Scanner Scanner;
        public Elevator Elevator;
    }
}
