namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta Bancária - ETECMCM");
        Conta conta = new Conta();
        conta.nomeCliente = "Nome do cliente";
        
        conta.limite = 500;
        
        conta.depositar(200);

        conta.sacar(50);


        //Método ConsultaSaldo:
        double saldo = conta.ConsultaSaldo();

        //Para vizualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);


        //Console.WriteLine("Olá, " + conta.nomeCliente + ", seu saldo é de: " + conta.saldo);
        //Console.WriteLine("Seu limite de saque é de: " + conta.limite);
        //Console.WriteLine("O número de sua conta é: " + conta.numeroConta);
    }
}
