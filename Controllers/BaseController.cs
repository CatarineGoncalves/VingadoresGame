using Vingadores.Models;

namespace Vingadores.Controllers {
    public class BaseController 
    {
        BaseModel basemodel = new BaseModel();

        public string MostraInfo () 
        {
            return  $"Info do Personagem: vida {basemodel.Vida}";
        }

        public string Pular () 
        {
            return "Personagem Pulando";
        }

    }
}