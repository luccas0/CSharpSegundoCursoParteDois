using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha ou login incorretos!");
                return false;
            }
        }

        



    }
}
