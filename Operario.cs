namespace ExercicioDia0311_HerancaPessoa
{
    class Operario : Empregado
    {
        private double valorProducao;
        private double comissao;

 

        public double getValorProducao()
        {
            return valorProducao;
        }
        public void setValorProducao(double valorProducao)
        {
            this.valorProducao = valorProducao;
        }
        public double getComissao()
        {
            return comissao;
        }
        public void setComissao(int comissao)
        {
            this.comissao = comissao;
        }
        public void CalcularSalario() {
            
            setImposto(((getSalarioBase() * 10) / 100));
            comissao=((valorProducao*5)/100);
            setSalarioLiquido((getSalarioBase() - getImposto()+comissao));      
        }
    }
}