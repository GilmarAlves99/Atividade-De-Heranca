namespace ExercicioDia0311_HerancaPessoa
{
    class Administrador : Empregado
    {
        private double ajudaDeCusto;
        
        public double getAjudaDeCusto()
        {
            return ajudaDeCusto;
        }
        public void setAjudaDeCusto(double ajudaDeCusto)
        {
            this.ajudaDeCusto = ajudaDeCusto;
        }

        public void CalcularSalario()
        {
            setImposto((getSalarioBase() * 10) / 100);
           setSalarioLiquido((getSalarioBase() - getImposto()) + ajudaDeCusto);

 

        }
    }
}