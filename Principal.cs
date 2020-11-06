using System;

namespace ExercicioDia0311_HerancaPessoa
{

    class Principal
    {
        static void Main(string[] args)
        {
            Fornecedor for1 = new Fornecedor();
            Empregado emp1 = new Empregado();
            Administrador adm1 = new Administrador();
            Operario ope1 = new Operario();
            Vendedor ven1 = new Vendedor();

            int opcao, operacao;

            Console.WriteLine("Escolha uma Opção:");
            Console.WriteLine("\n1- Fornecedor \n2- Empregado \n3- Administrador \n4- Operario \n5- Vendedor \n0- Sair");
            opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {// inicio while

                if (opcao == 1)
                {
                    Console.WriteLine(" \n ACESSANDO FORNECEDOR \n ");
                    Console.WriteLine("Escolha uma Opção:");
                    Console.WriteLine("\n1- Cadastrar \n2- Obter Saldo \n0- Sair");
                    operacao = int.Parse(Console.ReadLine());
                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("\n CADASTRO FORNECEDOR \n");
                            Console.Write("Digite o nome:");
                            for1.setNome(Console.ReadLine());
                            Console.Write("Digite o email:");
                            for1.setEmail(Console.ReadLine());
                            Console.Write("Digite o telefone:");
                            for1.setTelefone(Console.ReadLine());
                            Console.Write("Digite o Valor do Crédito R$ ");
                            for1.setValorCredito(double.Parse(Console.ReadLine()));
                            Console.Write("Digite o Valor da Dívida R$ ");
                            for1.setValorDivida(double.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.WriteLine("Saldo atual R$ " + for1.obterSaldo());
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Escolha uma Opção:");
                    Console.WriteLine("\n1- Cadastrar \n2-  Calcular Salário \n0- Sair");
                    operacao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 2:
                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine(" \n ACESSANDO EMPREGADO \n ");
                                    Console.Write("Digite o nome:");
                                    emp1.setNome(Console.ReadLine());
                                    Console.Write("Digite o email:");
                                    emp1.setEmail(Console.ReadLine());
                                    Console.Write("Digite o telefone:");
                                    emp1.setTelefone(Console.ReadLine());
                                    Console.Write("Digite o Código Setor:");
                                    emp1.setCodigoSetor((int.Parse(Console.ReadLine())));
                                    Console.Write("Digite o Salário Base:");
                                    emp1.setSalarioBase((double.Parse(Console.ReadLine())));
                                    break;
                                case 2:
                                    emp1.calcularSalario();
                                    Console.WriteLine(" Salário do Calculado R$ " + emp1.getSalarioLiquido());
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine(" \n ACESSANDO ADMINISTRADOR \n ");

                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine("\n CADASTRO ADMINISTRADOR \n");
                                    Console.Write("Digite o nome:");
                                    adm1.setNome(Console.ReadLine());
                                    Console.Write("Digite o email:");
                                    adm1.setEmail(Console.ReadLine());
                                    Console.Write("Digite o telefone:");
                                    adm1.setTelefone(Console.ReadLine());
                                    Console.Write("Digite o valor da ajuda de Custo R$ :");
                                    adm1.setAjudaDeCusto((double.Parse(Console.ReadLine())));
                                    Console.Write("Digite o Salário Base:");
                                    adm1.setSalarioBase((double.Parse(Console.ReadLine())));
                                    break;
                                case 2:
                                    adm1.calcularSalario();
                                    Console.WriteLine(" Salário do Calculado R$ " + adm1.getSalarioLiquido());
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine(" \n ACESSANDO OPERARIO \n ");
                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine("\n CADASTRO OPERARIO \n");
                                    Console.Write("Digite o nome:");
                                    ope1.setNome(Console.ReadLine());
                                    Console.Write("Digite o email:");
                                    ope1.setEmail(Console.ReadLine());
                                    Console.Write("Digite o telefone:");
                                    ope1.setTelefone(Console.ReadLine());
                                    Console.Write("Digite o Salário Base:");
                                    ope1.setSalarioBase((double.Parse(Console.ReadLine())));
                                    Console.Write("Digite o Valor da Produção:");
                                    ope1.setValorProducao((double.Parse(Console.ReadLine())));
                                    break;
                                case 2:
                                    ope1.calcularSalario();
                                    Console.WriteLine(" Salário do Calculado R$ " + ope1.getSalarioLiquido());
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            break;
                        case 5:

                            Console.WriteLine(" \n ACESSANDO VENDEDOR \n ");

                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine("\n CADASTRO VENDEDOR \n");



                                    Console.Write("Digite o nome:");
                                    ven1.setNome(Console.ReadLine());
                                    Console.Write("Digite o email:");
                                    ven1.setEmail(Console.ReadLine());
                                    Console.Write("Digite o telefone:");
                                    ven1.setTelefone(Console.ReadLine());
                                    Console.Write("Digite o valor das Vendas R$ :");
                                    ven1.setValorVendas((double.Parse(Console.ReadLine())));
                                    Console.Write("Digite o Salário Base:");
                                    ven1.setSalarioBase((double.Parse(Console.ReadLine())));
                                    break;
                                case 2:
                                    ven1.calcularSalario();
                                    Console.WriteLine(" Salário do Calculado R$ " + ven1.getSalarioLiquido());
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            break;
                    }

                }
                Console.WriteLine("Digite escolha uma Opção:");
                Console.WriteLine("\n1- Fornecedor \n2- Empregado \n3- Administrador \n4- Operario \n5- Vendedor \n0- Sair");
                opcao = int.Parse(Console.ReadLine());

            }// fim while

        }
    }
}