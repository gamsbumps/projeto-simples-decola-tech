using DIO.Curtas;
using DIO.Curtas.Classes;

namespace DIO.Curtas.Classes
{
    class Program
    {
        static CurtasRepositorio repositorio = new CurtasRepositorio();

        static void Main(string[] args)
        {
            string op = "";
            while (op.ToUpper() != "X")
            {
                op = ObterOpcaoUsuario();
                switch (op)
                {
                    case "1":
                        ListarCurtas();
                        break;
                    case "2":
                        InserirCurta();
                        break;
                    case "3":
                        AtualizarCurta();
                        break;
                    case "4":
                        ExcluirCurta();
                        break;
                    case "5":
                        VisualizarCurta();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Até logo!");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida!");
                }
            }

        }
        private static void ListarCurtas()
        {
            Console.WriteLine("Listar curtas");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum curta cadastrado.");
                return;
            }
            foreach (var curta in lista)
            {
                var excluido = curta.retornaExcluido();
                Console.WriteLine("ID {0}: - {1} - Ano {2} {3}", curta.retornaId(), curta.retornaTitulo(), curta.retornaAno(), (excluido ? "Excluido" : ""));
            }
        }
        private static void InserirCurta()
        {
            Console.WriteLine("Inserir novo curta");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Curta: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Curta: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse do Curta: ");
            string entradaSinopse = Console.ReadLine();

            Console.WriteLine("Digite o nome do(a) diretor(a): ");
            string entradaDirecao = Console.ReadLine();

            Console.WriteLine("Digite o País de origem: ");
            string entradaPais = Console.ReadLine();

            Curtas novoCurta = new Curtas(id: repositorio.ProximoId(),
                                           genero: (Genero)entradaGenero,
                                           titulo: entradaTitulo,
                                           ano: entradaAno,
                                           sinopse: entradaSinopse,
                                           direcao: entradaDirecao,
                                           pais: entradaPais);

            repositorio.Insere(novoCurta);
        }
        private static void AtualizarCurta()
        {
            Console.WriteLine("Digite o id do curta: ");
            int indiceCurta = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o gênero de acordo com as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título do Curta: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano do curta: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Sinopse do curta: ");
            string entradaSinopse = Console.ReadLine();

            Console.WriteLine("Digite o nome do(a) diretor(a): ");
            string entradaDirecao = Console.ReadLine();

            Console.WriteLine("Digite o País de origem: ");
            string entradaPais = Console.ReadLine();

            Curtas atualizaCurta = new Curtas(id: indiceCurta,
                                              genero: (Genero)entradaGenero,
                                              titulo: entradaTitulo,
                                              ano: entradaAno,
                                              sinopse: entradaSinopse,
                                              direcao: entradaDirecao,
                                              pais: entradaPais);

            repositorio.Atualiza(indiceCurta, atualizaCurta);

        }
        private static void ExcluirCurta()
        {
            Console.WriteLine("Digite o id do curta: ");
            int indiceCurta = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceCurta);
        }
        private static void VisualizarCurta()
        {
            Console.WriteLine("Digite o id do curta: ");
            int indiceCurta = int.Parse(Console.ReadLine());

            var curta = repositorio.RetornaPorId(indiceCurta);

            Console.WriteLine(curta);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries ao seu dispor!");
            Console.WriteLine("Informe a opcao desejada:");

            Console.WriteLine("1 - Listar curtas");
            Console.WriteLine("2 - Inserir novo curta");
            Console.WriteLine("3 - Atualizar curta");
            Console.WriteLine("4 - Excluir curta");
            Console.WriteLine("5 - Visualizar curta");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string op = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return op;
        }
    }
}

