using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Imobiliaria
{
    class Program
    {

        static void Main(string[] args)
        {

            menu();

        }

        public static void menu()
        {

            /* 
             * menu
             * Abre o menu de opções (cadastro/pesquisa/relatório/sair)
             */

            char opc;

            do
            {

                Console.Clear();

                Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                    "Menu\n\n" +
                    "\nA. cadastro" +
                    "\nB. pesquisa" +
                    "\nC. relatório" +
                    "\nD. encerrar");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {

                    case 'a':

                        cadastro();
                        break;

                    case 'b':

                        pesquisa();
                        break;

                    case 'c':

                        relatorio();
                        break;

                    case 'd':

                        break;

                    default:

                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 'd');

        }

        // Funções de Cadastro

        public static void cadastro()
        {
            /* 
             * cadastro
             * Abre o menu de cadastros (proprietário/cliente/corretor/imóvel/locação/venda/sair)
             */

            int codProp = 0, codCliente = 0, codCorretor = 0, codImovel = 0, codLoc = 0, codVenda = 0;
            char opc;

            do
            {

                Console.Clear();
                Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                    "Cadastro\n\n");
                Console.WriteLine("Digite uma opção para cadastrar:" +
                                "\n\nA. proprietário" +
                                "\nB. cliente" +
                                "\nC. corretor" +
                                "\nD. imóvel" +
                                "\nE. locação" +
                                "\nF. venda" +
                                "\nG. sair");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        cadProp(ref codProp);
                        break;

                    case 'b':

                        cadCliente(ref codCliente);
                        break;

                    case 'c':

                        cadCorretor(ref codCorretor);
                        break;

                    case 'd':

                        cadImovel(ref codImovel);
                        break;

                    case 'e':

                        cadLoc(ref codLoc);
                        break;

                    case 'f':

                        cadVenda(ref codVenda);
                        break;

                    case 'g':

                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;

                }

            } while (opc != 'g');

        }


        public static void cadProp(ref int codProp)
        {

            /* 
             * cadProp
             * Cadastra um novo propietário 
             * Entrada: ref int codProp
             * Saída: Código+Nome+Endereço+(DDD)-Telefone (informacoes/proprietario.txt)
             */

            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);
            StreamWriter escProp = new StreamWriter(arqProp);
            string nome, end, leLinha;
            string[] codPropAux;
            int tel, ddd;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar proprietário\n\n");

            do
            {

                leLinha = leProp.ReadLine();

                if (leLinha != null)
                {

                    codPropAux = leLinha.Split('+');
                    codProp = int.Parse(codPropAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escProp.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            Console.WriteLine("DDD:");
            ddd = int.Parse(Console.ReadLine());
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            codProp++;
            escProp.WriteLine($"{codProp}+{nome}+{end}+({ddd})-{tel}");
            Console.WriteLine("\nCadastro realizado com sucesso");

            escProp.Close();
            leProp.Close();

            Console.ReadKey();

        }

        public static void cadCliente(ref int codCliente)
        {

            /* cadCliente
             * Cadastra um novo cliente 
             * Entrada: ref int codCliente
             * Saída: Código+Nome+Endereço+(DDD)-Telefone+dia/mes/ano (informacoes/cliente.txt)
             */

            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);
            StreamWriter escCliente = new StreamWriter(arqCliente);
            string nome, end, leLinha;
            string[] codClienteAux;
            int tel, ddd, dia, mes, ano;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar cliente\n\n");

            do
            {

                leLinha = leCliente.ReadLine();

                if (leLinha != null)
                {

                    codClienteAux = leLinha.Split('+');
                    codCliente = int.Parse(codClienteAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escCliente.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            Console.WriteLine("DDD:");
            ddd = int.Parse(Console.ReadLine());
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de nascimento:");
            Console.WriteLine("Dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mês:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano:");
            ano = int.Parse(Console.ReadLine());
            codCliente++;
            escCliente.WriteLine($"{codCliente}+{nome}+{end}+({ddd})-{tel}+{dia}/{mes}/{ano}");
            Console.WriteLine("\nCadastro realizado com sucesso");

            escCliente.Close();
            leCliente.Close();

            Console.ReadKey();

        }

        public static void cadCorretor(ref int codCorretor)
        {

            /* cadCorretor
             * Cadastra um novo propietário 
             * Entrada: ref int codCorretor
             * Saída: Código+Nome+Endereço+(DDD)-Telefone+Salário (informacoes/corretor.txt) 
             */

            FileStream arqCorretor = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leCorretor = new StreamReader(arqCorretor);
            StreamWriter escCorretor = new StreamWriter(arqCorretor);
            string nome, end, leLinha;
            string[] codCorretorAux;
            int tel, ddd;
            double salario;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar corretor\n\n");

            do
            {

                leLinha = leCorretor.ReadLine();

                if (leLinha != null)
                {

                    codCorretorAux = leLinha.Split('+');
                    codCorretor = int.Parse(codCorretorAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escCorretor.WriteLine(leLinha);
            }

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Telefone:");
            Console.WriteLine("DDD:");
            ddd = int.Parse(Console.ReadLine());
            Console.WriteLine("Telefone:");
            tel = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário:");
            salario = double.Parse(Console.ReadLine());
            codCorretor++;
            escCorretor.WriteLine($"{codCorretor}+{nome}+{end}+({ddd})-{tel}+{salario}");
            Console.WriteLine("\nCadastro realizado com sucesso");

            escCorretor.Close();
            leCorretor.Close();

            Console.ReadKey();

        }

        public static void cadImovel(ref int codImovel)
        {

            /* cadImovel
             * Cadastra um novo imóvel 
             * Entrada: ref int codImovel
             * Saída: Código+Código proprietário+Endereço+Categoria+Tipo+Quantidade de quartos+Quantidade de vagas+Valor+Condomínio+Status+Observações (informacoes/imovelAux.txt e informacoes/imovel.txt) 
             */

            FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);
            StreamWriter escImovelAux = new StreamWriter(arqImovelAux);
            FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Open);
            StreamReader leImovel = new StreamReader(arqImovel);
            StreamWriter escImovel = new StreamWriter(arqImovel);
            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);
            string end, leLinha, cat, status = "", obs, tipo2 = "";
            string[] codImovelAux, codPropAux;
            int codProp, codPropAux2, codPropAux3 = 0, quartos, vagas, tipo1 = 1;
            double valor, cond;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar imóvel\n\n");

            do
            {

                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux = leLinha.Split('+');
                    codImovel = int.Parse(codImovelAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escImovelAux.WriteLine(leLinha);
            }

            do
            {

                leLinha = leImovel.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux = leLinha.Split('+');
                    codImovel = int.Parse(codImovelAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escImovel.WriteLine(leLinha);
            }

            do
            {
                Console.WriteLine("Tipo de imóvel:" +
                    "\n[1] VENDA" +
                    "\n[2] ALUGUEL");
                tipo1 = int.Parse(Console.ReadLine());
                if (tipo1 == 1)
                {
                    status = "a vender";
                    tipo2 = "venda";
                    tipo1 = 1;
                }
                else if (tipo1 == 2)
                {
                    status = "a alugar";
                    tipo2 = "locacao";
                    tipo1 = 1;
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                    tipo1 = 0;
                }
            } while (tipo1 != 1 && tipo1 != 0);

            Console.WriteLine("Código do proprietário:");
            codProp = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leProp.ReadLine();

                if (leLinha != null)
                {

                    codPropAux = leLinha.Split('+');
                    codPropAux2 = int.Parse(codPropAux[0]);

                    if (codPropAux2 == codProp)
                    {
                        codPropAux3 = 1;
                    }

                }

            } while (leLinha != null);
            if (codPropAux3 == 0)
            {
                Console.WriteLine("\nCódigo de proprietario inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovel.Close();
                escImovelAux.Close();
                leImovelAux.Close();
                leProp.Close();
                return;
            }

            Console.WriteLine("Endereço:");
            end = Console.ReadLine();
            Console.WriteLine("Categoria (apartamento, casa, cobertura, lote, etc):");
            cat = Console.ReadLine();
            Console.WriteLine("Quantidade de quartos:");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de vagas:");
            vagas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Condomínio:");
            cond = double.Parse(Console.ReadLine());
            Console.WriteLine("Observações:");
            obs = Console.ReadLine();
            codImovel++;
            escImovelAux.WriteLine($"{codImovel}+{codProp}+{end}+{cat}+{tipo2}+{quartos}+{vagas}+{valor}+{cond}+{status}+{obs}");
            escImovel.WriteLine($"{codImovel}+{codProp}+{end}+{cat}+{tipo2}+{quartos}+{vagas}+{valor}+{cond}+{status}+{obs}");
            Console.WriteLine("\nCadastro realizado com sucesso");

            escImovel.Close();
            escImovelAux.Close();
            leImovelAux.Close();
            leProp.Close();

            Console.ReadKey();

        }

        public static bool verificaProp(int codImovel)
        {

            // Essa função verifica se o proprietário de um imóvel já está cadastrado

            FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);
            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);

            string leLinha;
            string[] codImovelAux, codPropAux;
            int codImovelAux2, codPropAux2, codProp = 0;

            do
            {

                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux = leLinha.Split('+');
                    codImovelAux2 = int.Parse(codImovelAux[0]);

                    if (codImovelAux2 == codImovel)
                    {

                        codProp = int.Parse(codImovelAux[1]);

                        do
                        {

                            leLinha = leProp.ReadLine();

                            if (leLinha != null)
                            {

                                codPropAux = leLinha.Split('+');
                                codPropAux2 = int.Parse(codPropAux[0]);

                                if (codPropAux2 == codProp)
                                {
                                    leImovelAux.Close();
                                    leProp.Close();
                                    return true;
                                }

                            }

                        } while (leLinha != null);
                    }

                }

            } while (leLinha != null);

            leImovelAux.Close();
            leProp.Close();
            return false;
        }

        public static void cadLoc(ref int codLoc)
        {

            /* cadLoc
             * Cadastra uma nova locação
             * Entrada:
             * Saída:
             * Código locação+Código imóvel+Código cliente+Aluguel+Taxa administrativa+Valor do proprietário+Data de início da locação+Duração da locação (informacoes/locacoes.txt e informacoes/imovelAux.txt e informacoes/imovel.txt)
             */

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar locação\n\n");

            FileStream arqLoc = new FileStream("informacoes/locacoes.txt", FileMode.Open);
            StreamReader leLoc = new StreamReader(arqLoc);
            StreamWriter escLoc = new StreamWriter(arqLoc);
            FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);
            StreamWriter escImovelAux = new StreamWriter(arqImovelAux);
            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);

            string leLinha;
            string[] codLocAux, codClienteAux, codImovelAux;
            int codImovel, codImovelAux2, codImovelAux3 = 0, codClienteAux2, codClienteAux3 = 0, codCliente, duracao, dia = 0, mes = 0, ano = 0, locSucesso;
            double aluguel = 0, taxa, valorProp;

            do
            {

                leLinha = leLoc.ReadLine();

                if (leLinha != null)
                {

                    codLocAux = leLinha.Split('+');
                    codLoc = int.Parse(codLocAux[0]);

                }

            } while (leLinha != null);

            if (leLinha != null)
            {
                escLoc.WriteLine(leLinha);
            }

            Console.WriteLine("Código do cliente:");
            codCliente = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leCliente.ReadLine();

                if (leLinha != null)
                {

                    codClienteAux = leLinha.Split('+');
                    codClienteAux2 = int.Parse(codClienteAux[0]);

                    if (codClienteAux2 == codCliente)
                    {
                        codClienteAux3 = 1;
                    }

                }

            } while (leLinha != null);
            if (codClienteAux3 == 0)
            {
                Console.WriteLine("\nCódigo de cliente inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escLoc.Close();
                leLoc.Close();
                leCliente.Close();
                return;
            }

            Console.WriteLine("Código do imóvel:");
            codImovel = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux = leLinha.Split('+');
                    codImovelAux2 = int.Parse(codImovelAux[0]);

                    if (codImovelAux2 == codImovel)
                    {
                        codImovelAux3 = 1;
                        aluguel = int.Parse(codImovelAux[7]);
                    }

                }

            } while (leLinha != null);

            if (codImovelAux3 == 0)
            {
                Console.WriteLine("\nCódigo de imóvel inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escLoc.Close();
                leLoc.Close();
                leCliente.Close();
                return;
            }

            escImovelAux.Close();
            leImovelAux.Close();

            if (verificaProp(codImovel) == false)
            {
                Console.WriteLine("\nCódigo do proprietário inválido, o proprietário não existe" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escLoc.Close();
                leLoc.Close();
                leCliente.Close();
                return;
            }

            locSucesso = escreveImovelLoc1(codImovel);

            if (locSucesso == 0)
            {

                Console.WriteLine("\nImóvel não é do tipo locação ou já está alugado" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                return;
            }

            if (locSucesso == 1)
            {

                Console.WriteLine("Data de ínicio da locação:");
                Console.WriteLine("Dia:");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Mês:");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano:");
                ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Duração da locação, em meses:");
                duracao = int.Parse(Console.ReadLine());

                if (duracao <= 6)
                {
                    taxa = 0.15 * aluguel;
                }
                else if (duracao <= 12)
                {
                    taxa = 0.10 * aluguel;
                }
                else
                {
                    taxa = 0.05 * aluguel;
                }
                valorProp = aluguel - taxa;

                codLoc++;
                escLoc.WriteLine($"{codLoc}+{codImovel}+{codCliente}+{aluguel}+{taxa}+{valorProp}+{dia}/{mes}/{ano}+{duracao}");
                Console.WriteLine("\nCadastro realizado com sucesso");
            }


            escLoc.Close();
            leLoc.Close();
            leCliente.Close();

            Console.ReadKey();

        }

        public static int escreveImovelLoc1(int codImovel)

        // Essa função escreve "alugado" no arquivo imovel.txt

        {
            FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);

            FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Create);
            StreamWriter escImovel = new StreamWriter(arqImovel);

            string leLinha, tipo, status;
            string[] linhaImovel;
            int codImovelAux = 0, locSucesso = 0;

            do
            {
                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {
                    linhaImovel = leLinha.Split('+');
                    codImovelAux = int.Parse(linhaImovel[0]);
                    tipo = linhaImovel[4];
                    status = linhaImovel[9];

                    if (codImovelAux == codImovel)
                    {
                        if (tipo == "locacao" && status == "a alugar")
                        {
                            escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+alugado+{linhaImovel[10]}");
                            locSucesso = 1;
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                            locSucesso = 0;
                        }
                    }
                    else
                    {
                        escImovel.WriteLine(leLinha);
                    }
                }

            } while (leLinha != null);

            escImovel.Close();
            leImovelAux.Close();
            escreveImovelLoc2(codImovel);
            return locSucesso;
            // chama escreveImovelLoc2 para escrever em imovelAux.txt o que alteramos aqui
        }

        public static void escreveImovelLoc2(int codImovel)

        // Essa função escreve "alugado" no arquivo imovelAux.txt
        // Para os dois ficarem iguais (imovelAux.txt e imovel.txt)

        {
            FileStream arqImovelAux = new FileStream("informacoes/imovel.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);

            FileStream arqImovel = new FileStream("informacoes/imovelAux.txt", FileMode.Create);
            StreamWriter escImovel = new StreamWriter(arqImovel);

            string leLinha, tipo, status;
            string[] linhaImovel;
            int codImovelAux = 0;

            do
            {
                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {
                    linhaImovel = leLinha.Split('+');
                    codImovelAux = int.Parse(linhaImovel[0]);
                    tipo = linhaImovel[4];
                    status = linhaImovel[9];

                    if (codImovelAux == codImovel)
                    {
                        if (tipo == "locacao")
                        {
                            if (status == "a alugar")
                            {
                                escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+alugado+{linhaImovel[10]}");
                            }
                            else
                            {
                                escImovel.WriteLine(leLinha);
                            }
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                        }
                    }
                    else
                    {
                        escImovel.WriteLine(leLinha);
                    }
                }

            } while (leLinha != null);

            escImovel.Close();
            leImovelAux.Close();

        }

        public static void cadVenda(ref int codVenda)
        {

            /* cadVenda
             * Cadastra uma nova venda
             * Entrada:
             * Saída:
             */

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Cadastrar venda\n\n");

            string leLinha, leLinhaVenda;
            string[] codVendaAux, codClienteAux, codImovelAux1, codCorretorAux;
            int codImovel, codImovelAux2, codImovelAux3 = 0, codCliente, codClienteAux2, codClienteAux3 = 0, codCorretor, codCorretorAux2, codCorretorAux3 = 0, dia = 0, mes = 0, ano = 0, vendSucesso;
            double venda = 0, taxa = 0, valorProp = 0;

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            StreamWriter escVenda = new StreamWriter(arqVenda);
            FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
            StreamReader leImovelAux = new StreamReader(arqImovelAux);
            StreamWriter escImovelAux = new StreamWriter(arqImovelAux);
            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);
            FileStream arqCorretor = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leCorretor = new StreamReader(arqCorretor);

            do
            {
                // Conta os códigos das vendas até o último, para incrementar o código depois
                leLinhaVenda = leVenda.ReadLine();

                if (leLinhaVenda != null)
                {

                    codVendaAux = leLinhaVenda.Split('+');
                    codVenda = int.Parse(codVendaAux[0]);

                }

            } while (leLinhaVenda != null);

            if (leLinhaVenda != null)
            {
                escVenda.WriteLine(leLinhaVenda);
            }

            Console.WriteLine("Código do cliente:");
            codCliente = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leCliente.ReadLine();

                if (leLinha != null)
                {

                    codClienteAux = leLinha.Split('+');
                    codClienteAux2 = int.Parse(codClienteAux[0]);

                    if (codClienteAux2 == codCliente)
                    {
                        codClienteAux3 = 1;
                    }

                }

            } while (leLinha != null);
            if (codClienteAux3 == 0)
            {
                Console.WriteLine("\nCódigo de cliente inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escVenda.Close();
                leVenda.Close();
                leCliente.Close();
                leCorretor.Close();
                return;
            }

            Console.WriteLine("Código do imóvel:");
            codImovel = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leImovelAux.ReadLine();

                if (leLinha != null)
                {

                    codImovelAux1 = leLinha.Split('+');
                    codImovelAux2 = int.Parse(codImovelAux1[0]);

                    if (codImovelAux2 == codImovel)
                    {
                        venda = double.Parse(codImovelAux1[7]);
                        taxa = 0.15 * venda;
                        valorProp = 0.85 * venda;
                        codImovelAux3 = 1;
                    }

                }

            } while (leLinha != null);
            if (codImovelAux3 == 0)
            {
                Console.WriteLine("\nCódigo de imóvel inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escVenda.Close();
                leVenda.Close();
                leCliente.Close();
                leCorretor.Close();
                return;
            }

            escImovelAux.Close();
            leImovelAux.Close();

            vendSucesso = escreveImovelVenda1(codImovel);

            if (vendSucesso == 0)
            {
                Console.WriteLine("\nImóvel não é do tipo venda ou já está vendido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escVenda.Close();
                leVenda.Close();
                leCliente.Close();
                leCorretor.Close();
                return;
            }

            Console.WriteLine("Código do corretor:");
            codCorretor = int.Parse(Console.ReadLine());
            do
            {

                leLinha = leCorretor.ReadLine();

                if (leLinha != null)
                {

                    codCorretorAux = leLinha.Split('+');
                    codCorretorAux2 = int.Parse(codCorretorAux[0]);

                    if (codCorretorAux2 == codCorretor)
                    {
                        codCorretorAux3 = 1;
                    }

                }

            } while (leLinha != null);
            if (codCorretorAux3 == 0)
            {
                Console.WriteLine("\nCódigo de corretor inválido" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escVenda.Close();
                leVenda.Close();
                leCliente.Close();
                leCorretor.Close();
                return;
            }

            escImovelAux.Close();
            leImovelAux.Close();

            if (verificaProp(codImovel) == false)
            {
                Console.WriteLine("\nCódigo do proprietário inválido, o proprietário não existe" +
                    "\nCadastro não realizado com sucesso");
                Console.ReadKey();
                escImovelAux.Close();
                leImovelAux.Close();
                escVenda.Close();
                leVenda.Close();
                leCorretor.Close();
                leCliente.Close();
                return;
            }

            if (vendSucesso == 1)
            {
                Console.WriteLine("Data da venda:");
                Console.WriteLine("Dia:");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Mês:");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano:");
                ano = int.Parse(Console.ReadLine());

                escreveImovelVenda3(codImovel);

                codVenda++;
                escVenda.WriteLine($"{codVenda}+{codImovel}+{codCliente}+{codCorretor}+{venda}+{taxa}+{valorProp}+{dia}/{mes}/{ano}");
                Console.WriteLine("\nCadastro realizado com sucesso");

                escVenda.Close();
                leVenda.Close();
                leCorretor.Close();
                leCliente.Close();

                Console.ReadKey();

            }
        }

        public static int escreveImovelVenda1(int codImovel)

        // Essa função escreve "com proposta" no arquivo imovel.txt

        {
            {
                FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
                StreamReader leImovelAux = new StreamReader(arqImovelAux);

                FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Create);
                StreamWriter escImovel = new StreamWriter(arqImovel);

                string leLinha, tipo, status;
                string[] linhaImovel;
                int codImovelAux = 0, vendSucesso = 0;

                do
                {
                    leLinha = leImovelAux.ReadLine();

                    if (leLinha != null)
                    {
                        linhaImovel = leLinha.Split('+');
                        codImovelAux = int.Parse(linhaImovel[0]);
                        tipo = linhaImovel[4];
                        status = linhaImovel[9];

                        if (codImovelAux == codImovel)
                        {
                            if (tipo == "venda" && status == "a vender")
                            {
                                escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+com proposta+{linhaImovel[10]}");
                                vendSucesso = 1;
                            }
                            else
                            {
                                escImovel.WriteLine(leLinha);
                                vendSucesso = 0;
                            }
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                        }
                    }

                } while (leLinha != null);

                escImovel.Close();
                leImovelAux.Close();
                escreveImovelVenda2(codImovel);
                return vendSucesso;
            }
        }

        public static void escreveImovelVenda2(int codImovel)

        // Essa função escreve "com proposta" no arquivo imovelAux.txt
        // Para os dois ficarem iguais (imovelAux.txt e imovel.txt)

        {
            {
                FileStream arqImovelAux = new FileStream("informacoes/imovel.txt", FileMode.Open);
                StreamReader leImovelAux = new StreamReader(arqImovelAux);

                FileStream arqImovel = new FileStream("informacoes/imovelAux.txt", FileMode.Create);
                StreamWriter escImovel = new StreamWriter(arqImovel);

                string leLinha, tipo, status;
                string[] linhaImovel;
                int codImovelAux = 0;

                do
                {
                    leLinha = leImovelAux.ReadLine();

                    if (leLinha != null)
                    {
                        linhaImovel = leLinha.Split('+');
                        codImovelAux = int.Parse(linhaImovel[0]);
                        tipo = linhaImovel[4];
                        status = linhaImovel[9];

                        if (codImovelAux == codImovel)
                        {
                            if (tipo == "venda" && status == "a vender")
                            {
                                escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+com proposta+{linhaImovel[10]}");
                            }
                            else
                            {
                                escImovel.WriteLine(leLinha);
                            }
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                        }
                    }

                } while (leLinha != null);

                escImovel.Close();
                leImovelAux.Close();
                // escreveImovelVenda3(codImovel);
            }
        }
        public static void escreveImovelVenda3(int codImovel)

        // Essa função escreve "vendido" no arquivo imovel.txt

        {
            {
                FileStream arqImovelAux = new FileStream("informacoes/imovelAux.txt", FileMode.Open);
                StreamReader leImovelAux = new StreamReader(arqImovelAux);

                FileStream arqImovel = new FileStream("informacoes/imovel.txt", FileMode.Create);
                StreamWriter escImovel = new StreamWriter(arqImovel);

                string leLinha, tipo, status;
                string[] linhaImovel;
                int codImovelAux = 0;

                do
                {
                    leLinha = leImovelAux.ReadLine();

                    if (leLinha != null)
                    {
                        linhaImovel = leLinha.Split('+');
                        codImovelAux = int.Parse(linhaImovel[0]);
                        tipo = linhaImovel[4];
                        status = linhaImovel[9];

                        if (codImovelAux == codImovel)
                        {
                            if (tipo == "venda" && status == "com proposta")
                            {
                                escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+vendido+{linhaImovel[10]}");
                            }
                            else
                            {
                                escImovel.WriteLine(leLinha);
                            }
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                        }
                    }

                } while (leLinha != null);

                escImovel.Close();
                leImovelAux.Close();
                escreveImovelVenda4(codImovel);
            }
        }
        public static void escreveImovelVenda4(int codImovel)

        // Essa função escreve "vendido" no arquivo imovelAux.txt
        // Para os dois ficarem iguais (imovelAux.txt e imovel.txt)

        {

            {
                FileStream arqImovelAux = new FileStream("informacoes/imovel.txt", FileMode.Open);
                StreamReader leImovelAux = new StreamReader(arqImovelAux);

                FileStream arqImovel = new FileStream("informacoes/imovelAux.txt", FileMode.Create);
                StreamWriter escImovel = new StreamWriter(arqImovel);

                string leLinha, tipo, status;
                string[] linhaImovel;
                int codImovelAux = 0;

                do
                {
                    leLinha = leImovelAux.ReadLine();

                    if (leLinha != null)
                    {
                        linhaImovel = leLinha.Split('+');
                        codImovelAux = int.Parse(linhaImovel[0]);
                        tipo = linhaImovel[4];
                        status = linhaImovel[9];

                        if (codImovelAux == codImovel)
                        {
                            if (tipo == "venda" && status == "com proposta")
                            {
                                escImovel.WriteLine($"{linhaImovel[0]}+{linhaImovel[1]}+{linhaImovel[2]}+{linhaImovel[3]}+{linhaImovel[4]}+{linhaImovel[5]}+{linhaImovel[6]}+{linhaImovel[7]}+{linhaImovel[8]}+vendido+{linhaImovel[10]}");
                            }
                            else
                            {
                                escImovel.WriteLine(leLinha);
                            }
                        }
                        else
                        {
                            escImovel.WriteLine(leLinha);
                        }
                    }

                } while (leLinha != null);

                escImovel.Close();
                leImovelAux.Close();

            }

        }

        // Funções de Pesquisa

        public static void pesquisa()
        {

            /* 
             * pesquisa
             * Abre o menu de pesquisas (clientes/proprietários/corretores/sair)
             */

            char opc;
            string nome;

            do
            {

                Console.Clear();
                Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                    "Pesquisa\n\n");
                Console.WriteLine("Digite uma opção para pesquisa:" +
                                "\n\nA. informações de clientes" +
                                "\nB. informações de proprietários" +
                                "\nC. informações de corretores" +
                                "\nD. sair");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        Console.WriteLine("\nNome:");
                        nome = Console.ReadLine().ToUpper();
                        pesCliente(nome);
                        break;

                    case 'b':

                        Console.WriteLine("\nNome:");
                        nome = Console.ReadLine().ToUpper();
                        pesProp(nome);
                        break;

                    case 'c':

                        Console.WriteLine("\nNome:");
                        nome = Console.ReadLine().ToUpper();
                        pesCorretor(nome);
                        break;

                    case 'd':

                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;

                }

            } while (opc != 'd');

        }

        public static void pesProp(string nome)
        {

            /* 
             * pesProp
             * Pesquisa propietário 
             * Entrada: string nome
             * Saída:
             */

            FileStream arqProp = new FileStream("informacoes/proprietario.txt", FileMode.Open);
            StreamReader leProp = new StreamReader(arqProp);
            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Pesquisa proprietário\n");

            do
            {

                linha = leProp.ReadLine();
                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"\nCódigo: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}");
                        quant++;
                    }
                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }

            leProp.Close();

            Console.ReadKey();

        }

        public static void pesCliente(string nome)
        {

            /* 
             * pesCliente
             * Pesquisa cliente 
             * Entrada: string nome
             * Saída:
             */

            FileStream arqCliente = new FileStream("informacoes/cliente.txt", FileMode.Open);
            StreamReader leCliente = new StreamReader(arqCliente);
            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Pesquisa cliente\n");

            do
            {

                linha = leCliente.ReadLine();

                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"\nCódigo: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}" +
                            $"\nData de nascimento: {inf[4]}");
                        quant++;
                    }

                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }

            leCliente.Close();

            Console.ReadKey();

        }

        public static void pesCorretor(string nome)
        {

            /* 
             * pesCorretor
             * Pesquisa corretor 
             * Entrada: string nome
             * Saída:
             */

            FileStream arqCorretor = new FileStream("informacoes/corretor.txt", FileMode.Open);
            StreamReader leCorretor = new StreamReader(arqCorretor);

            string linha;
            string[] inf;
            int quant = 0;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Pesquisa corretor\n");

            do
            {

                linha = leCorretor.ReadLine();
                if (linha != null)
                {
                    inf = linha.Split('+');

                    if (inf[1].ToUpper() == nome)
                    {
                        Console.WriteLine($"\nCódigo: {inf[0]}" +
                            $"\nNome: {inf[1]}" +
                            $"\nEndereço: {inf[2]}" +
                            $"\nTelefone: {inf[3]}" +
                            $"\nSalário: R$ {inf[4]}");
                        quant++;
                    }
                }

            } while (linha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }

            leCorretor.Close();

            Console.ReadKey();

        }

        // Funções de Relatório

        public static void relatorio()
        {
            /* 
             * relatorio
             * Abre o menu de relatórios (vendas corretor/vendas data/locações data/sair)
             */

            char opc;
            int codCorretor, dia, mes, ano;

            do
            {

                Console.Clear();
                Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                    "Relatório\n\n");
                Console.WriteLine("Digite uma opção de relatório:" +
                                "\n\nA. vendas de um corretor" +
                                "\nB. vendas em uma data" +
                                "\nC. locações em um data" +
                                "\nD. sair");
                opc = char.Parse(Console.ReadLine().ToLower());

                switch (opc)
                {
                    case 'a':

                        Console.WriteLine("\nCódigo do corretor:");
                        codCorretor = int.Parse(Console.ReadLine());
                        relCorretor(codCorretor);
                        break;

                    case 'b':

                        Console.WriteLine("\nData:");
                        Console.WriteLine("Dia:");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Mes:");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ano:");
                        ano = int.Parse(Console.ReadLine());
                        relVenda(dia, mes, ano);
                        break;

                    case 'c':

                        Console.WriteLine("\nData:");
                        Console.WriteLine("Dia:");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Mes:");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ano:");
                        ano = int.Parse(Console.ReadLine());
                        relLoc(dia, mes, ano);
                        break;

                    case 'd':

                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        Console.ReadKey();
                        break;

                }

            } while (opc != 'd');

        }

        public static void relCorretor(int codCorretor)
        {

            /* relCorretor
             * Mostra todas as vendas de imóveis de um corretor
             * Entrada: int codCorretor
             * Saída:
             */

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            string leLinha;
            string[] linhaImovel;
            int codCorretorAux, quant = 0;

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Relatório das vendas\n");

            do
            {

                leLinha = leVenda.ReadLine();

                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    codCorretorAux = int.Parse(linhaImovel[3]);

                    if (codCorretorAux == codCorretor)
                    {

                        Console.WriteLine($"\nNúmero da venda:{linhaImovel[0]}\nCódigo do Imóvel: {linhaImovel[1]}\nCódigo do cliente: {linhaImovel[2]}\nCódigo do corretor: {linhaImovel[3]}" +
                            $"\nValor da venda: R$ {linhaImovel[4]}\nTaxa administrativa: R$ {linhaImovel[5]}\nValor do proprietário: R$ {linhaImovel[6]}\nData da venda: {linhaImovel[7]}");
                        quant++;
                    }
                }

            } while (leLinha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }


            leVenda.Close();

            Console.ReadKey();

        }

        public static void relVenda(int dia, int mes, int ano)
        {

            /* relVenda
             * Mostra todas as vendas de imóveis de uma determinada data
             * Entrada: int dia, int mes, int ano
             * Saída:
             */

            FileStream arqVenda = new FileStream("informacoes/vendas.txt", FileMode.Open);
            StreamReader leVenda = new StreamReader(arqVenda);
            string leLinha;
            string[] linhaImovel, linhaImovel2;
            int quant = 0;
            int[] data = new int[3];

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Relatório das vendas\n");

            do
            {

                leLinha = leVenda.ReadLine();

                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    linhaImovel2 = linhaImovel[7].Split('/');
                    data[0] = int.Parse(linhaImovel2[0]);
                    data[1] = int.Parse(linhaImovel2[1]);
                    data[2] = int.Parse(linhaImovel2[2]);

                    if (data[0] == dia && data[1] == mes && data[2] == ano)
                    {

                        Console.WriteLine($"\nNúmero da venda:{linhaImovel[0]}\nCódigo do Imóvel: {linhaImovel[1]}\nCódigo do cliente: {linhaImovel[2]}\nCódigo do corretor: {linhaImovel[3]}" +
                            $"\nValor da venda: R$ {linhaImovel[4]}\nTaxa administrativa: R$ {linhaImovel[5]}\nValor do proprietário: R$ {linhaImovel[6]}\nData da venda: {linhaImovel[7]}");
                        quant++;
                    }
                }

            } while (leLinha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }

            leVenda.Close();

            Console.ReadKey();

        }

        public static void relLoc(int dia, int mes, int ano)
        {

            /* cadVenda
             * Mostra todas as locações de imóveis de uma determinada data
             * Entrada: int dia, int mes, int ano
             * Saída:
             */

            FileStream arqLoc = new FileStream("informacoes/locacoes.txt", FileMode.Open);
            StreamReader leLoc = new StreamReader(arqLoc);
            string leLinha;
            string[] linhaImovel, linhaImovel2;
            int quant = 0;
            int[] data = new int[3];

            Console.Clear();

            Console.WriteLine("Imobiliária Seu Lobato\n\n\n" +
                "Relatório das locações\n");

            do
            {

                leLinha = leLoc.ReadLine();
                if (leLinha != null)
                {

                    linhaImovel = leLinha.Split('+');
                    linhaImovel2 = linhaImovel[6].Split('/');
                    data[0] = int.Parse(linhaImovel2[0]);
                    data[1] = int.Parse(linhaImovel2[1]);
                    data[2] = int.Parse(linhaImovel2[2]);

                    if (data[0] == dia && data[1] == mes && data[2] == ano)
                    {

                        Console.WriteLine($"\nNúmero da locação:{linhaImovel[0]}\nCódigo do imóvel: {linhaImovel[1]}\nCódigo do inquilino: {linhaImovel[2]}\nValor do aluguel: R$ {linhaImovel[3]}" +
                            $"\nTaxa administrativa: R$ {linhaImovel[4]}\nValor do proprietário: R$ {linhaImovel[5]}\nData de início da locação: {linhaImovel[6]}\nDuração da locação: {linhaImovel[7]} meses");
                        quant++;
                    }
                }

            } while (leLinha != null);

            if (quant == 0)
            {
                Console.WriteLine("\nNenhum cadastro encontrado");
            }

            leLoc.Close();

            Console.ReadKey();

        }

    }
}
