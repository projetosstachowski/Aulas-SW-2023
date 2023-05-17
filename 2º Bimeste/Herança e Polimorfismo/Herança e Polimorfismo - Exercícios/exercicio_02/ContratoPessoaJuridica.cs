namespace exercicio_02;
class ContratoPessoaJuridica:Contrato
{
      /*public override string Nome()
    {
        return base.Nome() + "Fulano";
    }

    public override string Email()
    {
        return base.Email() + "fulano@email.com";
    }

    public override string Telefone()
    {
        return base.Telefone() + "912345678";
    }*/

    public string? Cnpj{get;set;}
    public string? Ie{get;set;}
    public string? NomeEmpresa{get;set;}

    public override string MostraDados()
    {
        return base.MostraDados() + "CNPJ: " + this.Cnpj + "; IE: " + this.Ie + "; Nome da empresa: " + this.NomeEmpresa;
    }

    /*public void MostraDadosJur(){
        Console.WriteLine(Cnpj);
        Console.WriteLine(Ie);
        Console.WriteLine(NomeEmpresa);
    }*/
}
