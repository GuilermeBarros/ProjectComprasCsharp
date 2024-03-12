using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------ Programa de Compras -----------");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de dinheiro que tem: ");
            float dinheiro = float.Parse(Console.ReadLine());

            Console.WriteLine("------------ Listra de Produtos ------------");
            Console.WriteLine("1 Monitor - 899 Reais");
            Console.WriteLine("2 Placa de Video - 1500 Reais");
            Console.WriteLine("3 Teclado - 500 Reais");
            Console.WriteLine("4 Mouse - 250 Reais");
            Console.WriteLine("5 Procesador - 1000 Reais");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Qaul produto deseja comprar?");

            int produtos = Convert.ToInt32(Console.ReadLine());
            string resposta;

            switch (produtos)
            {
                case 1:
                    Console.WriteLine("Monitor - 899 Reais");
                    Console.WriteLine("Deseja comprar este item? (Sim ou Não)");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim")
                    {
                        if (dinheiro >= 899)
                        {
                            Console.WriteLine("Compra finalizada!");
                            double saldoAtual = dinheiro - 899;
                            Console.WriteLine($"Seu saldo agora é: {saldoAtual} reais {nome}");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada!");
                            Console.WriteLine("Saldo insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Compra cancealada!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Placa de Video - 1500 Reais");
                    Console.WriteLine("Deseja comprar este item? (Sim ou Não)");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim")
                    {
                        if (dinheiro >= 1500)
                        {
                            Console.WriteLine("Compra finalizada!");
                            double saldoAtual = dinheiro - 1500;
                            Console.WriteLine($"Seu saldo agora é: {saldoAtual} reais {nome}");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada!");
                            Console.WriteLine("Saldo insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Compra cancealada!");
                    }
                    break;

                case 3:
                    Console.WriteLine("Teclado - 500 Reais");
                    Console.WriteLine("Deseja comprar este item? (Sim ou Não)");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim")
                    {
                        if (dinheiro >= 500)
                        {
                            Console.WriteLine("Compra finalizada!");
                            double saldoAtual = dinheiro - 500;
                            Console.WriteLine($"Seu saldo agora é: {saldoAtual} reais {nome}");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada!");
                            Console.WriteLine("Saldo insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Compra cancealada!");
                    }

                    break;

                case 4:
                    Console.WriteLine("Mouse - 250 Reais");
                    Console.WriteLine("Deseja comprar este item? (Sim ou Não)");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim")
                    {
                        if (dinheiro >= 250)
                        {
                            Console.WriteLine("Compra finalizada!");
                            double saldoAtual = dinheiro - 250;
                            Console.WriteLine($"Seu saldo agora é: {saldoAtual} reais {nome}");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada!");
                            Console.WriteLine("Saldo insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Compra cancealada!");
                    }
                    break;

                case 5:
                    Console.WriteLine("Procesador - 1000 Reais");
                    Console.WriteLine("Deseja comprar este item? (Sim ou Não)");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim")
                    {
                        if (dinheiro >= 1000)
                        {
                            Console.WriteLine("Compra finalizada!");
                            double saldoAtual = dinheiro - 1000;
                            Console.WriteLine($"Seu saldo agora é: {saldoAtual} reais {nome}");
                        }
                        else
                        {
                            Console.WriteLine("Compra cancelada!");
                            Console.WriteLine("Saldo insuficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Compra cancealada!");
                    }
                    break;
            }      
            Console.ReadLine();
        }
    }
}