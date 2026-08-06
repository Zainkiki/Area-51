using System;
using System.Collections.Generic;
using System.Text;

namespace Area_51
{
    internal class Kontrol
    {
        public Kontrol(Turret turret, Panel panel, Scanner scanner, Elevator elevator, Etage_Panel etagePanel)
        {
            Turret = turret;
            Panel = panel;
            Scanner = scanner;
            Elevator = elevator;
            Etage_Panel = etagePanel;
        }


        public Turret Turret;
        public Panel Panel;
        public Scanner Scanner;
        public Elevator Elevator;
        public Etage_Panel Etage_Panel;

        public void KontrolReceivesRequests(string sender)
        {
            Console.WriteLine("Kontrol: Request has been Received from " + sender);
        }

        public void KontrolSendsRequests()
        {
            Elevator.ElevatorReceivesRequests();
            Console.WriteLine("Kontrol: Request has been sent to Elevator");
            Etage_Panel.Etage_PanelReceivesRequests();
            Console.WriteLine("Kontrol: Request has been sent to Etage_Panel");
        }
        public void KontrolReceivesResponses()
        {
            Elevator.AccessGranted();
        }
    }
}
