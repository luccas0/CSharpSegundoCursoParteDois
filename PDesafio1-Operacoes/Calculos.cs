using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDesafio1_Operacoes
{
    public class Operacoes
    {
        public Soma soma { get; private set; }
        public Subtracao subtracao { get; private set; }
        public Multiplicacao multiplicacao { get; private set; }
        public Divisao divisao { get; private set; }

        public Operacoes()
        {
            this.soma = new Soma();
            this.subtracao = new Subtracao();
            this.multiplicacao = new Multiplicacao();
            this.divisao = new Divisao();
        }
    }

    

    

   
    

    }

    
