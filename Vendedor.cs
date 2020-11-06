namespace ExercicioDia0311_HerancaPessoa
{
   class Vendedor : Empregado
    {
        private double valorVendas;
        private double comissao;

 

        public double getValorVendas()
        {
            return valorVendas;
        }
        public void setValorVendas(double valorVendas)
        {
            this.valorVendas = valorVendas;
        }

 


        public double getComissao()
        {
            return comissao;
        }
        public void setComissao(double comissao)
        {
            this.comissao = comissao;
        }
        public void CalcularSalario()
        {
            setImposto((getSalarioBase() * 10) / 100);
            comissao=((this.valorVendas*5)/100);
            setSalarioLiquido((getSalarioBase() - getImposto())+comissao);

 

        }
    }
}