using bytebank_ADM.Funcionarios;
using PDesafio4_Interface.ServicoBonificacao;

Servico marcos = new Servico();
marcos.Nome = "Marcos Meidas";
marcos.Salario = 2000;
Console.WriteLine("Nome: " + marcos.Nome);
Console.WriteLine("Salário: " + marcos.Salario);
Console.WriteLine("Salário alterado pela bonificação: " + marcos.GetBonificacao());

Console.WriteLine("\nAperte a tecla enter para sair do sistema.");
Console.ReadKey();

