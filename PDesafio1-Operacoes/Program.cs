using PDesafio1_Operacoes;


Operacoes operacoes = new Operacoes();


Console.WriteLine("Resultado da soma: " + operacoes.soma.Calcular(2, 2));
Console.WriteLine("Resultado da subtração: " + operacoes.subtracao.Calcular(2, 2));
Console.WriteLine("Resultado da multiplicação: " + operacoes.multiplicacao.Calcular(5, 2));
Console.WriteLine("Resultado da divisão: " + operacoes.divisao.Calcular(10, 2));

Console.WriteLine("\nAperte a tecla enter para sair do sistema.");
Console.ReadKey();


