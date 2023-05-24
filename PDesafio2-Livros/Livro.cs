using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PDesafio2_Livros
{
    public class Livro
    {
        public string titulo { get; private set; }
        public string autor { get; set; }
        public string isbn { get; private set; }
        public int anoPublicacao { get; set; }
        public string estiloLiterario { get; set; }
        public int numeroPaginas { get; set; }           
        public string paisPublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.isbn = isbn;
            this.titulo = titulo;
        }
    }

   
}
