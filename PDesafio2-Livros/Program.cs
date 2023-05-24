using PDesafio2_Livros;

Livro livro = new Livro("978-65-89999-01-3", "O alquimista");

livro.autor = "Paulo Coelho";
livro.anoPublicacao = 1988;
livro.estiloLiterario = "Estilo narrativo";
livro.numeroPaginas = 208;
livro.paisPublicacao = "Brasil";

Console.WriteLine("Titulo: " + livro.titulo);
Console.WriteLine("ISBN: " + livro.isbn);
Console.WriteLine("Autor: " + livro.autor);
Console.WriteLine("Publicação: " + livro.anoPublicacao);
Console.WriteLine("Estilo literário: " + livro.estiloLiterario);
Console.WriteLine("Número de páginas: " + livro.numeroPaginas);
Console.WriteLine("País da publicação: " + livro.paisPublicacao);

Console.WriteLine("\nAperte a tecla enter para sair do sistema.");
Console.ReadKey();