﻿namespace metodos_construtores;
class Produto
{
    public Produto(){
        this.Nome = "Nome";
        this.Preco = 10;
    }
    public Produto(string nome){
        this.Nome = nome;
    }
    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 - 10*desconto/100;
    }
    private string? Nome {get;set;}
    public double Preco {get;set;}

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preco: " + this.Preco);
    }
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraPreco(double preco){
        this.Preco = preco;
    }
}
