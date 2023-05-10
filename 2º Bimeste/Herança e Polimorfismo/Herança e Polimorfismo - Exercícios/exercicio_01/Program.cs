namespace exercicio_01;
class Program
{
    static void Main(string[] args)
    {
        Homem h1 = new Homem();
        Cao c1 = new Cao();
        Gato g1 = new Gato();

        Console.WriteLine("O homem faz o seguinte" + h1.Fala());
        Console.WriteLine("O cão faz o seguinte" + c1.Fala());
        Console.WriteLine("O gato faz o seguinte" + g1.Fala());
    }
}
