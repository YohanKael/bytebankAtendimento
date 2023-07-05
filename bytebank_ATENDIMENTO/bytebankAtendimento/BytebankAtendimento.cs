using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebankAtendimento
{
    internal class BytebankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
        new ContaCorrente(95){Saldo = 100, Titular = new Cliente{Cpf="11111", Nome = "Henrique"}},
        new ContaCorrente(95){Saldo = 200, Titular = new Cliente{Cpf="22222", Nome = "Pedro"}},
        new ContaCorrente(94){Saldo = 60, Titular = new Cliente{Cpf="33333", Nome = "Marisa"}}
};

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("=============================");
                    Console.WriteLine("====       Atendimento    ===");
                    Console.WriteLine("==== 1 - Cadastrar Conta  ===");
                    Console.WriteLine("==== 2 - Listar Contas    ===");
                    Console.WriteLine("==== 3 - Remover Conta    ===");
                    Console.WriteLine("==== 4 - Ordenar Contas   ===");
                    Console.WriteLine("==== 5 - Pesquisar Conta  ===");
                    Console.WriteLine("==== 6 - Sair do Sistema ====");
                    Console.WriteLine("=============================");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("digite a opção desejada");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {

                        throw new ByteBankException($"{excecao.Message}");
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarConta();
                            break;
                        case '3':
                            RemoverContas();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada");
                            break;
                    }

                }

            }
            catch (ByteBankException excecao)
            {

                Console.WriteLine($"{excecao.Message}"); ;
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Aperte qualquer tecla para fechar a aplicação");
            Console.ReadKey();
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("==== Cadastro De Contas =====");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            Console.WriteLine("==== Informe Os Dados Da Conta ===");

            Console.WriteLine("Número da agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());
            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da conta [NOVA]: {conta.Conta}");


            Console.WriteLine("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe a profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("... Conta cadastrada com sucesso! ");
            Console.ReadKey();
        }

        private void ListarConta()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("==== Cadastro De Contas =====");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("...Não há contas cadastradas...");
                Console.WriteLine();
                return;
            }

            foreach (ContaCorrente item in _listaDeContas)
            {
                //Console.WriteLine("=== Dados Da Conta ===");
                //Console.WriteLine(" Numero Da Conta :" + item.Conta);
                //Console.WriteLine(" Saldo Da Conta :" + item.Saldo);
                //Console.WriteLine(" Titular Da Conta :" + item.Titular.Nome);
                //Console.WriteLine(" Cpf Do Titular :" + item.Titular.Cpf);
                //Console.WriteLine(" Profissão Do Titular :" + item.Titular.Profissao);
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void RemoverContas()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("====    REMOVER CONTAS   ====");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            Console.WriteLine("Informe o número da conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;
            foreach (ContaCorrente item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("Conta Removida Da Lista!");
                Console.WriteLine("\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            }
            else
            {
                Console.WriteLine("Conta para remoção não encontrada!");
                Console.WriteLine("\n");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            }
            Console.ReadKey();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenada");
            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("====    PESQUISAR CONTAS   ====");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            Console.WriteLine("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ou (3) Nº Agência: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Informe o CPF da conta: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCpfTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe o Nº da Agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                        ExibirListaDeContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada!");
                    break;
            }
        }

        private  void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("A Consulta não retornou dados ");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private  List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
                         from conta in _listaDeContas
                         where conta.Numero_agencia == numeroAgencia
                         select conta).ToList();
            return consulta;

        }


        private  ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for(int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();

            //return (from conta in _listaDeContas
            //        where conta.Conta.Equals(numeroConta)
            //       select conta).FirstOrDefault();
        }


        private ContaCorrente ConsultaPorCpfTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            //return conta;
            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }
    }
}
