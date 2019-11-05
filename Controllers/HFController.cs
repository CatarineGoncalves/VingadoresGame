
using System;
using Vingadores.Models;

namespace Vingadores.Controllers {
    public class HFController : BaseController {

        HFModel hfmodel = new HFModel();

        public string Voar () {
            return "Homem de Ferro está Voando";
        }

        public string Atirar () {
            return "Homem de Ferro está atirando";
        }

        public ConsoleColor MudarCor()
        {
            return ConsoleColor.Red;
        }
    }
}