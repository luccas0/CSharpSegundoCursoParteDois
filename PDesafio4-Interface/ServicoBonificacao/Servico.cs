using PDesafio4_Interface.Bonificacao;
using PDesafio4_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesafio4_Interface.ServicoBonificacao
{
    public class Servico : IBonificacao
    {

        public string Nome { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
