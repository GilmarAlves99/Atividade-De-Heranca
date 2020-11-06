namespace ExercicioDia0311_HerancaPessoa
{
  class Empregado : Pessoa
    {
        private int codigoSetor;
        private double salarioBase;
        private double imposto;
        private double salarioLiquido;
 
        public int getCodigoSetor()
        {
            return codigoSetor;
        }
        public void setCodigoSetor(int codigoSetor)
        {
            this.codigoSetor = codigoSetor;
        }
 
        public double getSalarioBase()
        {
            return salarioBase;
        }
        public void setSalarioBase(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }
 
        public double getImposto()
        {
            return imposto;
        }
        public void setImposto(double imposto)
        {
            this.imposto = imposto;
        }
 
        public double getSalarioLiquido()
        {
            return salarioLiquido;
        }
        public void setSalarioLiquido(double salarioLiquido)
        {
            this.salarioLiquido = salarioLiquido;
        }
 
        public void calcularSalario(){
            imposto = ((getSalarioBase() * 10) / 100);
            salarioLiquido = (salarioBase - imposto);
            
        }
 
    }
}