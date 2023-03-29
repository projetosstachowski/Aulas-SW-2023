namespace metodos_construtores;
class Program
{
    static void Main(string[] args)
    {
        //Produto p1 = new Produto();
        //Produto p1 = new Produto("Nome do produto");
        Produto p1 = new Produto ("ABC",10);

        p1.MostraDados();
    }
}
