namespace ExercicioDia0311_HerancaPessoa
{
   class Fornecedor : Pessoa
    {
        private double valorCredito;
        private double valorDivida;

 

        public double getValorCredito() {
             return valorCredito;
        }
        public void setValorCredito(double valorCredito) {
            this.valorCredito = valorCredito;
        }
        public double getValorDivida()
        {
            return valorDivida;
        }
        public void setValorDivida(double valorDivida)
        {
            this.valorDivida = valorDivida;
        }
        public double obterSaldo() {
            double saldo;
            saldo = (this.getValorCredito() - getValorDivida());
            return saldo;
        }
    }
}