using System;
using Vingadores.Controllers;

namespace Vingadores {
    class Program {
        static void Main (string[] args) {

            string personagem;

            System.Console.WriteLine ("Digite: \n 1 - Homem de Ferro \n 2 - Capitão América ");
            personagem = Console.ReadLine ();

            HFController hfController = new HFController ();
            CapController capController = new CapController ();

            if (personagem == "1") {
                Console.ForegroundColor = hfController.MudarCor ();
                System.Console.WriteLine ("Você Escolheu o Homem de Ferro");

                System.Console.WriteLine (hfController.MostraInfo ());
                System.Console.WriteLine (hfController.Atirar ());
                System.Console.WriteLine (hfController.Pular ());
                System.Console.WriteLine (hfController.Voar ());

            } else if (personagem == "2") {
                Console.ForegroundColor = capController.MudarCor ();
                System.Console.WriteLine ("Você escolheu o Capitão America");
                System.Console.WriteLine (capController.EscudoAtack ());
                System.Console.WriteLine (capController.Pular ());
                System.Console.WriteLine (capController.EscudoDefense ());
                System.Console.WriteLine (capController.MostraInfo ());
            } else {

                System.Console.WriteLine ("Personagem inválido! :( ");
            }

        

        }
    }
}