//using System.Runtime.Serialization;
//using System.Reflection.Emit;
//using Internal;
//using System.Collections.Concurrent;
//using System.Runtime.Serialization;
//using System.Reflection.Emit;
//using System.Linq.Expressions;
//using System.Diagnostics;
//using Internal;
using System;
//using System.ComponentModel;
using System.Data;
//using System.Collections.Generic;
using System.Datetime;
using ProjetoAgencia;

    namespace {Agencia}
    {
        static void Main(string[] args) {

            Console.WriteLine("::: Bem-vindo à Agência de Turismo :::");
            
            Console.WriteLine("Você escolheu com a melhor... Boa viagem!!!");
        }

        public class Vendas
        {
            Boolean compraEfetuada;
            Boolean pacotesDeViagem; //Sim ou não
            Boolean passagensAereas;
            int pacotesDeViagem; //Qtd
            int passagensAereas;
            string formaDePagamento;
            string clienteNome;
            string clienteCPF;
            string clienteNasc;
            float valorTotal;

            PrimeiroNome();

            AplicarDescontos();


            switch (formaDePagamento)
            {
                case aVista:
                Console.WriteLine("Pagamento à vista"+:+valorTotal);
                break;

                case Credito:
                Console.WriteLine("Pagamento com Crédito"+:+valorTotal);
                break;

                case Debito:
                Console.WriteLine("Pagamento com Débito"+:+valorTotal);
                break;

                default:
                Console.WriteLine("Existem apenas estas formas de pagamento");
                break;
            }

            if (5 < nomeCliente < 55)
            {
                    Console.WriteLine("Bom nome");
            } else {
                    Console.WriteLine("Nome inválido *Digite seu nome entre 5 a 55 caracteres");
            }
        }

            protected class PrimeiroNome(string clienteNome)
            {
                string primeiroNome;
                Console.WriteLine("Insira seu primeiro nome:");
                primeiroNome = Console.ReadLine();
                clienteNome = primeiroNome;
                return primeiroNome;
            }

            protected class AplicarDescontos(float valorTotal)
            {
                if (valorTotal < 500)
                {
                    Console.WriteLine("Sem descontos ao valor total da compra mas se o valor for maior do que R$500, será aplicado desconto");

                }

                if (500 > valorTotal < 5000)
                {
                    valorDoDesconto = (valorTotal * 0.05);
                    valorTotal = valorTotal - valorDoDesconto;
                    Console.WriteLine("Valor total atualizado, foi considerado o desconto de:"+ valorDoDesconto");
                } else (valorTotal > 5000) {
                    valorDoDesconto = (valorTotal * 0.10);
                    valorTotal = valorTotal - valorDoDesconto;
                    Console.WriteLine("Valor total atualizado, foi considerado o desconto de :"+ valorDoDesconto");
                }
            }

        public class Funcionarios {
            String Nome;
            String CPF;
            String Cargo;
            DateTime Nascimento;
        }

        public class PacotesDeViagem {
            Vendas();
            Datetime ida;
            Datetime volta;
            double preçoPacote;
            Serviços();

            if (preçoPacote < 0,00)
            {
                Console.WriteLine("Não é aceito valor negativo");
            }
        }

        public class PassagensAereas {
            Vendas();
            string empresaAerea;
            string classeAerea;
            string poltronaAviao;
            float preçoPassagem;
            datetime horarioEmbarque;
            datetime dataDaPassagem;
            Voo();
            Escala();
            Serviços();

            if (preçoPassagem < 0.00)
            {
                Console.WriteLine("Não é aceito valor negativo");
            }

            getResumo();
        }

        protected class getResumo (string clienteNome, string poltronaAviao, float preçoPassagem)
        {
            Vendas();
            PassagensAereas();
            return clienteNome;
            return poltronaAviao;
            return preçoPassagem;
        }

        public class Voo{
            int numeroVoo;
            datetime horarioVoo;
            string destino;
            string origem;
        }

        public class Escala{
            double duraçaoDeEscala;
            string local;
            datetime horarioChegada;
        }

        public class Serviços {
            Almoço();
            Jantar();
            CafeDaManha();
            PasseiosLocais();
        }

        public class Almoço {
            float preço;
        }

        public class Jantar {
            float preço;
        }

        public class CafeDaManha {
            float preço;
        }
            
        public class PasseiosLocais {
            float preço;
            string local;
            datetime horario;
        }
    }     
