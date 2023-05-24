namespace exercicio_03;
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

    public override double calcularPrestacao(double ValorContrato, int Prazo)
    {
        if(Idade <= 30){
            return base.calcularPrestacao(20, 2) + 1;
            } else if(Idade <= 40){
                return base.calcularPrestacao(20, 2) + 2;
            } else if(Idade <= 50){
                return base.calcularPrestacao(20, 2) + 3;
            } else if(Idade > 50){
                return base.calcularPrestacao(20, 2) + 4;
            }
    }

    /*public virtual string MostraDados(){
        return "Nome: " + this.Nome + "; Email: " + this.Email + "; Telefone: " + this.Telefone;
    }
    }*/
}
