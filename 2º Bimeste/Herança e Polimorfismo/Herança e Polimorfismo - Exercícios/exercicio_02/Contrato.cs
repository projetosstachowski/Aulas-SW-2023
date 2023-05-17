namespace exercicio_02;
class Contrato
{
    public string? Nome{get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}
    /*public virtual string Nome(){
        return "Nome: ";
    }

        public virtual string Email(){
        return "Email: ";
    }

        public virtual string Telefone(){
        return "Telefone: ";
    }*/

    /*public void MostraDados(){
        Console.WriteLine("Nome: " + );
        Console.WriteLine("Email: " + this.Email);
        Console.WriteLine("Telefone: " + this.Telefone);
    }*/

    public virtual string MostraDados(){
        return "Nome: "+this.Nome+"; Email: "+this.Email+"; Telefone: "+this.Telefone;
    }
}
