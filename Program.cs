using System;
using System.Collections.Generic;
using System.Text;
using Area_51;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            Etage etage = new Etage();
            etage.Panel.SendARequest();
            etage.Scanner.Sendsafetyinformation();
            etage.Turret.TurretReceivesRequests();
            etage.Kontrol.KontrolSendsRequests();
            etage.Etage_Panel.Etage_PanelReceivesRequests();
            etage.Turret.TurretSendsKillStatus();
        }

    }
}