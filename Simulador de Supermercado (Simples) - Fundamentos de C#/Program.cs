namespace Simulador_de_Supermercado__Simples____Fundamentos_de_C_
{
    using System;

    class Program
    {
        static void Main()
        {
            int opcao_cartao = 0, opcao_produto = -1, i = 0;
            float cartao1 = 400.00f, cartao2 = 60.00f, cartao3 = 35.00f, cartao4 = 180.00f;
            float valor_final = 0.0f, valor_compra = 0.0f;
            float[] produto = { 0, 7.50f, 22.50f, 5.00f, 10.00f, 4.50f, 12.00f, 10.00f, 4.00f, 15.00f, 14.50f };

            Console.WriteLine("Olá, seja bem-vindo ao mercado!");
            Console.WriteLine("Para introduzir sua compra, selecione um cartão dentre as opções disponibilizadas:");

            while (opcao_cartao < 1 || opcao_cartao > 4)
            {
                Console.WriteLine("\nCartões:");
                Console.WriteLine("Opção 1.");
                Console.WriteLine("Opção 2.");
                Console.WriteLine("Opção 3.");
                Console.WriteLine("Opção 4.");
                opcao_cartao = Convert.ToInt32(Console.ReadLine());

                if (opcao_cartao < 1 || opcao_cartao > 4)
                {
                    Console.WriteLine("Opção inválida. Por favor, selecione novamente.");
                }
            }

            Console.WriteLine("\nVocê escolheu o cartão de número " + opcao_cartao);

            Console.WriteLine("\nMenu de produtos.");
            while (opcao_produto != 0 || i < 5)
            {
                if (opcao_produto == 0 && i < 5)
                {
                    Console.WriteLine("\nPara finalizar a compra, o número mínimo de produtos deve ser 5. Selecione novamente até atingir a quantidade necessária.");
                }

                Console.WriteLine("Selecione o que deseja comprar (Mínimo 5, máximo 10):");
                Console.WriteLine("1 - Refrigerante: R$ 7.50");
                Console.WriteLine("2 - Saco de arroz: R$ 22.50");
                Console.WriteLine("3 - Saco de açúcar: R$ 5.00");
                Console.WriteLine("4 - Caixa de chocolate: R$ 10.00");
                Console.WriteLine("5 - Bananas: R$ 4.50");
                Console.WriteLine("6 - Ovos: R$ 12.00");
                Console.WriteLine("7 - Frango: R$ 10.00");
                Console.WriteLine("8 - Óleo de soja: R$ 4.00");
                Console.WriteLine("9 - Farinha de trigo: R$ 15.00");
                Console.WriteLine("10 - Carne moída: R$ 14.50");
                Console.WriteLine("0 - Digite 0 para finalizar a compra.");
                opcao_produto = Convert.ToInt32(Console.ReadLine());

                if (opcao_produto >= 1 && opcao_produto <= 10)
                {
                    valor_compra += produto[opcao_produto];
                    i++;
                }
                else if (opcao_produto != 0)
                {
                    Console.WriteLine("Opção inválida. Por favor, selecione novamente.");
                }

                if (i == 10)
                {
                    break;
                }
            }

            Console.WriteLine("\nCompra finalizada.");
            Console.WriteLine("Valor da compra: R$ " + valor_compra);

            if (opcao_cartao == 1)
            {
                valor_final = cartao1 - valor_compra;
                Console.WriteLine("Saldo do cartão antes da compra: R$ " + cartao1);
                if (valor_final < 0)
                {
                    Console.WriteLine("Cartão estourado.");
                }
                else
                {
                    Console.WriteLine("Saldo do cartão após a compra: R$ " + valor_final);
                }
            }
            else if (opcao_cartao == 2)
            {
                valor_final = cartao2 - valor_compra;
                Console.WriteLine("Saldo do cartão antes da compra: R$ " + cartao2);
                if (valor_final < 0)
                {
                    Console.WriteLine("Cartão estourado.");
                }
                else
                {
                    Console.WriteLine("Saldo do cartão após a compra: R$ " + valor_final);
                }
            }
            else if (opcao_cartao == 3)
            {
                valor_final = cartao3 - valor_compra;
                Console.WriteLine("Saldo do cartão antes da compra: R$ " + cartao3);
                if (valor_final < 0)
                {
                    Console.WriteLine("Cartão estourado.");
                }
                else
                {
                    Console.WriteLine("Saldo do cartão após a compra: R$ " + valor_final);
                }
            }
            else if (opcao_cartao == 4)
            {
                valor_final = cartao4 - valor_compra;
                Console.WriteLine("Saldo do cartão: R$ " + cartao4);
                if (valor_final < 0)
                {
                    Console.WriteLine("Cartão estourado.");
                }
                else
                {
                    Console.WriteLine("Saldo atual do cartão: R$ " + valor_final);
                }
            }
        }
    }

}
