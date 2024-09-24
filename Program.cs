using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using static Menu_de_vendas.Program;

namespace Menu_de_vendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            List<Produtos> listaProdutos = new List<Produtos>();
            Produtos produto1 = new Produtos();
            produto1.Nome = "Cartela 20 ovos";
            produto1.Preco = 10.99;
            Produtos produto2 = new Produtos();
            produto2.Nome = "Cerveja Puro Malte 355ml";
            produto2.Preco = 4.99;
            Produtos produto3 = new Produtos();
            produto3.Nome = "Cebola (KG)";
            produto3.Preco = 3.29;
            Produtos produto4 = new Produtos();
            produto4.Nome = "Acém (KG)";
            produto4.Preco = 25.90;
            Produtos produto5 = new Produtos();
            produto5.Nome = "Queijo Mussrela (KG)";
            produto5.Preco = 42.90;
            Produtos produto6 = new Produtos();
            produto6.Nome = "Óleo de soja 1l";
            produto6.Preco = 6.38;
            Produtos produto7 = new Produtos();
            produto7.Nome = "Arroz 5kg";
            produto7.Preco = 25.96;
            Produtos produto8 = new Produtos();
            produto8.Nome = "Cerveja Duplo Malte 300ml";
            produto8.Preco = 2.69;
            Produtos produto9 = new Produtos();
            produto9.Nome = "Água Mineral 20l";
            produto9.Preco = 6.50;
            Produtos produto10 = new Produtos();
            produto10.Nome = "Molho de Tomate";
            produto10.Preco = 2.98;

            



            do {
                Console.Clear();
                Console.WriteLine("----------Escolha uma opção abaixo---------");
                Console.WriteLine("1. Adicionar produto ao carrinho");
                Console.WriteLine("2. Exibir carrinho");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Sair");
                escolha = int.Parse(Console.ReadLine());

               if (escolha == 1) 
               { 
                    Console.Clear();
                    Console.WriteLine("Lista de produtos");
                    Console.WriteLine("\n1. Cartela com 20 ovos - R$10,95");
                    Console.WriteLine("2. Cerveja Puro Malte 355ml - R$4,99");
                    Console.WriteLine("3. Cebola - 3,29/kg");
                    Console.WriteLine("4. Acém - R$25,90/kg");
                    Console.WriteLine("5. Queijo Mussarela Fatiado - R$42,90/kg");
                    Console.WriteLine("6. Óleo de Soja tipo 1 900ml - R$6,38");
                    Console.WriteLine("7. Arroz 5kg - R$25,96");
                    Console.WriteLine("8. Cerveja Duplo Malte 300ml - R$2,69");
                    Console.WriteLine("9. Água Mineral 20l - R$6,50");
                    Console.WriteLine("10. Molho de Tomate - R$2,98");
                    Console.WriteLine("\nPara adicionar o produto ao carrinho, digite o seu número correspondente:");
                    int produto = int.Parse(Console.ReadLine());
                    
                    switch (produto)
                    {
                        case 1:
                            listaProdutos.Add(produto1);
                            break;
                        case 2:
                            listaProdutos.Add(produto2);
                            break;
                        case 3:
                            listaProdutos.Add(produto3);
                            break;
                        case 4:
                            listaProdutos.Add(produto4);
                            break;
                        case 5:
                            listaProdutos.Add(produto5);
                            break;
                        case 6:
                            listaProdutos.Add(produto6);
                            break;
                        case 7:
                            listaProdutos.Add(produto7);
                            break;
                        case 8:
                            listaProdutos.Add(produto8);
                            break;
                        case 9:
                            listaProdutos.Add(produto9);
                            break;
                        case 10:
                            listaProdutos.Add(produto10);
                            break;
                    }
               }
               if (escolha == 2)
                {
                    Console.Clear();
                    foreach (Produtos produto in listaProdutos)
                    {
                        Console.WriteLine(produto.Nome);
                        Console.WriteLine("R$" + produto.Preco);
                    }
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
               
               if(escolha == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Itens no carrinho: ");
                    foreach (Produtos produto in listaProdutos)
                    {
                        Console.WriteLine(produto.Nome);
                        Console.WriteLine("R$" + produto.Preco);
                    }

                    double total = listaProdutos.Sum(produto => produto.Preco);



                }

            } while (escolha != 4) ;
           
        }
        public class Produtos()
        {
            public double Preco { get; set; }
            public string Nome { get; set; }
        }
    }
}
