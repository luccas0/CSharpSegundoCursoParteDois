using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Autenticavel
    {
       

        public override bool Autenticar(string senha, string login)
        {
            if(Senha == senha && Login == login)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

    }
}
