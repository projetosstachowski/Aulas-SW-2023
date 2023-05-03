namespace exemplo_heranca;
class FuncionarioN3:Funcionario
{
    public override double Lucro(){
        return base.Lucro() * 0.03;
    }
}
