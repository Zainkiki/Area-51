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
            Console.WriteLine("Kontrol: A Request has been Received");
            if (sender == "Panel")
            {
                Console.WriteLine("Kontrol: Panel Requests the elevator");
            }
            else if (sender == "Scanner")
            {
                Console.WriteLine("Kontrol: Safety information has been Received from Scanner");
            }
        }

        public void KontrolSendsRequests()
        {
            Console.WriteLine("Kontrol: Request has been sent to Elevator");
            Elevator.ElevatorReceivesRequests();
            Console.WriteLine("Kontrol: Request has been sent to Etage_Panel");
            Etage_Panel.Etage_PanelReceivesRequests();
            bool killConfirmed = Turret.TurretOrderShoot();
            if (killConfirmed == true)
            {
                Console.WriteLine("Human has been killed");
            }
            else
            {
                Console.WriteLine("Human hasn't been killed gnag hes a cool guyy trust turst fr fr ");
            }
        }
        public void KontrolReceivesResponses(string sender)
        {
            Console.WriteLine("Kontrol: A Response has been Received");
            Console.WriteLine("Turret: Kill status");
        }
    }
}
