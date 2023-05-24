using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
System();
void System()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor marcos = new Diretor();
    marcos.Nome = "Marcos Oliveira";
    marcos.Login = "marcos@gmail.com";
    marcos.Senha = "123";

    GerenteDeContas julia = new GerenteDeContas();
    julia.Nome = "Julia Silva";
    julia.Login = "julia@outlook.com";
    julia.Senha = "321";

    sistema.Logar(marcos, "123", "marcos@gmail.com");
    sistema.Logar(julia, "123", "julia11@outlook.com");

    Console.WriteLine("\nAperte a tecla enter para sair do sistema.");
    Console.ReadKey();

}