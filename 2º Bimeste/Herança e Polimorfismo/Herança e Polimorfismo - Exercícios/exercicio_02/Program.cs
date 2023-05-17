namespace exercicio_02;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica c1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica c2 = new ContratoPessoaJuridica();

        /*Console.WriteLine("Nome: " + c2.Nome());
        Console.WriteLine("Email: " + c2.Email());
        Console.WriteLine("Telefone: " + c2.Telefone());*/

        c1.Nome = "Fulano";
        c1.Email = "fulano@email.com";
        c1.Telefone = "912345678";
        c1.Cpf = "987654321";
        c1.Idade = 30;

        c2.Nome = "Fulano";
        c2.Email = "fulano@email.com";
        c2.Telefone = "912345678";
        c2.Cnpj = "12345";
        c2.Ie = "4432";
        c2.NomeEmpresa = "Empresa C#";


        Console.WriteLine("Contrato - Pessoa Física: ");
        Console.WriteLine(c1.MostraDados());
        Console.WriteLine();
        Console.WriteLine("Contrato - Pessoa Jurídica: ");
        Console.WriteLine(c2.MostraDados());
    }
}
