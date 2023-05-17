namespace exercicio_02;
class ContratoPessoaFisica:Contrato
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

    public string? Cpf{get;set;}
    public int Idade{get;set;}

    public override string MostraDados()
    {
        return base.MostraDados()+" CPF: "+this.Cpf+"; Idade: "+this.Idade;
    }
    /*public virtual string MostraDados(){
        return "Nome: " + this.Nome + "; Email: " + this.Email + "; Telefone: " + this.Telefone;
    }
    }*/
}
