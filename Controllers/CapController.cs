using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class CapController : BaseController
    {
        CapModel capmodel = new CapModel();

        public string EscudoAtack()
        {
            return "Capitão America lançando o Escudo";
        }

        public string EscudoDefense()
        {
            return "Capitão America defendeu-se com o Escudo";
        }

        public ConsoleColor MudarCor()
        {
            return ConsoleColor.Blue;
        }
    }
}