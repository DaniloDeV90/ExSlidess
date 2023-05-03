using Classes;
namespace lista3

{
    public class Lista3
    {
        static void Main(string[] args)
        {

            int opcao;
            do
            {




                Console.WriteLine("Digite o número do exercicio você quer iniciar. --Ou digite -1 para sair");
                opcao = int.Parse(Console.ReadLine());

                lista3Classes lista3Classes = new lista3Classes();

                switch (opcao)
                {


                    case 1:

                        Console.WriteLine("A média é: " + lista3Classes.Cachorrinho());


                        break;


                    case 2:

                        Console.WriteLine(lista3Classes.Loja());


                        break;

                    case 3:

                        Console.WriteLine(lista3Classes.Carro2());


                        break;
                    case 4:

                        Console.WriteLine(lista3Classes.CarroMarca());


                        break;

                    case 5:

                        Console.WriteLine(lista3Classes.mediamaiormenor());


                        break;
                    case 6:
                        Console.WriteLine(lista3Classes.salario());

                        break;

                       
                    case 7:
                        Console.WriteLine(lista3Classes.tabelaCarror());

                        break;

                }
            } while (opcao != -1);
        }
    }

}

