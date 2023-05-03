using System.Collections;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using static Classes.lista3Classes;

namespace Classes
{
    public class lista3Classes
    {


        public class Cachorro
        {
            public string Raça { get; set; }
            public string Porte { get; set; }
            public string Late { get; set; }
            public void DataNasc(int data)
            {
                var dataa = DateTime.Now.Year;
                Console.WriteLine("A idade do cachorro é " + (dataa - data) + " Anos");

            }


        }



        public string Cachorrinho()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Raça = "Pitbull";
            cachorro.Porte = "Grande";
            cachorro.Late = "Sim";
            cachorro.DataNasc(2013);


            var lista = getPropertyValues(cachorro);

            var result = "";
            foreach (var item in lista)
            {
                result += (item.Key + ": " + item.Value.ToString() + "\n");
            }

            return result;
        }
        public static Dictionary<string, object> getPropertyValues(object o)
        {
            Dictionary<string, object> propertyValues = new Dictionary<string, object>();
            Type ObjectType = o.GetType();
            System.Reflection.PropertyInfo[] properties = ObjectType.GetProperties();
            foreach (System.Reflection.PropertyInfo property in properties)
            {
                propertyValues.Add(property.Name, property.GetValue(o, null));
            }
            return propertyValues;

        }


        public string Loja()
        {
            int[] arr = new int[15];
            var valueCompra = 0;
            var Avista = 0;
            var Prazo = 0;
            for (int i = 0; i < 15; i++)
            {
                string vp;


                Random randNum = new Random();
                var random = randNum.Next(600, 3000);
                Console.WriteLine("Valor da compra: " + random + "\nDigite V para Comprar A vista ou P para comprar a Prazo. Ou digite qualquer outra tecla para finalizar a compra");
                vp = Console.ReadLine();
                string VPU = vp.ToUpper();

                if (VPU == "V")
                {
                    Avista += random;
                }
                else if (VPU == "P")
                {
                    Prazo += random;
                }
                else
                {
                    Console.WriteLine("Valor incorreto");
                    break;
                }

            }
            Console.Clear();


            string result = ("Compras A vista " + Avista + " R$" + "\n" +
            "Compras A prazo " + Prazo + " R$" + "\n" +
            "Valor total das compras: " + (Avista + Prazo) + " R$");

            return result;
        }

        public class Carror
        {
            public string placa { get; set; }
            public string modelo { get; set; }
            public int anoDfabrica { get; set; }
            public string Marca { get; set; }

            public string Acelerar()
            {
                return "O carro está em movimento";
            }
            public string Freiar()
            {
                return ("O carro está parado");
            }
        }


        public string Carro2()
        {

            Carror objcarro = new Carror();
            objcarro.placa = "8323";
            objcarro.modelo = "FUSCA";
            objcarro.anoDfabrica = 1987;
            objcarro.Marca = "VOLKSWAGEN";



            var retorno = getPropertyValues(objcarro);

            foreach (var item in retorno)
            {
                Console.WriteLine(item.Value.ToString() + "\n");


            }
            Console.WriteLine(objcarro.Acelerar());

            Console.WriteLine("-------");

            Carror objcarro2 = new Carror();
            objcarro2.placa = "83ASD";
            objcarro2.modelo = "LA FERRARI";
            objcarro2.anoDfabrica = 2018;
            objcarro2.Marca = "FERRARI";



            var retorno2 = getPropertyValues(objcarro2);

            foreach (var item in retorno2)
            {
                Console.WriteLine(item.Value.ToString() + "\n");


            }
            Console.WriteLine(objcarro2.Freiar());
            Console.WriteLine("-------");

            Carror objcarro3 = new Carror();
            objcarro3.placa = "8QWE";
            objcarro3.modelo = "MUSTANG";
            objcarro3.anoDfabrica = 2005;
            objcarro3.Marca = "FORD";



            var retorno3 = getPropertyValues(objcarro3);


            foreach (var item in retorno3)
            {
                Console.WriteLine(item.Value.ToString() + "\n");


            }
            Console.WriteLine(objcarro3.Acelerar());


            return "Codigo executado!!";
        }


        public class Carro
        {
            public int indice { get; set; }
            public string marca { get; set; }
            public int valor { get; set; }
            public string cor { get; set; }

            public string modelo { get; set; }
            public int ano { get; set; }


        }


        public string CarroMarca()
        {




            List<Carro> carros = new List<Carro>();
            var i = 0;
            var parar = "";

            do
            {

                Carro carro = new Carro();
                carro.indice = i++;

                Console.WriteLine("Indice: " + carro.indice);
                Console.WriteLine("Digite a marca do carro: ");
                carro.marca = (Console.ReadLine());
                Console.WriteLine("Digite o valor do carro: ");
                carro.valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o modelo do carro: ");
                carro.modelo = Console.ReadLine();
                Console.WriteLine("Digite a cor do carro: ");
                carro.cor = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro");
                carro.ano = Convert.ToInt32(Console.ReadLine());
                carros.Add(carro);

                Console.WriteLine("Deseja parar? digite sim para finalizar ou qualquer outra tecla para continuar");
                parar = Console.ReadLine();
                parar = parar.ToUpper();
            } while (parar != "SIM");
            Console.Clear();



            carros.Sort((carro1, carro2) => carro2.valor.CompareTo(carro1.valor));
            Console.WriteLine("Carros ordenados pelo o maior valor para o menor valor");
            foreach (Carro carro in carros)
            {

                Console.WriteLine("Indice do veiculo: " + carro.indice +
                "\n Marca: " + carro.marca +
                "\n Valor: " + carro.valor + " R$" +
                "\n Modelo: " + carro.modelo +
                "\n Cor: " + carro.cor +
                "\n ano: " + carro.ano);

            }
            Console.ReadLine();
            return "codigo executando";
        }

        public string mediamaiormenor()
        {
            int[] arr = new int[6];
            int num = 0;
            do
            {
                int numero;
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                arr[num] = numero;

                num++;

            } while (num != 6);
            Console.WriteLine("-------");

            var Maior = arr[0];
            var Menor = arr[0];
            var result = 0;
            var tot = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Menor > arr[i])
                {
                    Menor = arr[i];
                }

                if (Maior < arr[i])
                {
                    Maior = arr[i];
                }


                tot += arr[i];


                result = tot / arr.Length;

            }
            Console.WriteLine("O maior número é: " + Maior);
            Console.WriteLine("O menor número é: " + Menor);
            Console.WriteLine("A média dos valores é: " + result);
            Console.ReadLine();

            return "codigo executado";
        }

        public string salario()
        {
            var MediaFilho = 0.0;
            var Mediasalario = 0.0;
            int[] arr = new int[200];

            var totpessoas1500 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var randNum = new Random();
                var random = randNum.Next(1300, 3000);
                var Nfilhos = randNum.Next(1, 5);

                if (random <= 1500)
                {
                    totpessoas1500++;
                }

                arr[i] = random;



                MediaFilho += Nfilhos;
                Mediasalario += random;

            }
            var Maiorsalario = arr[0];
            var Menorsalario = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (Maiorsalario < arr[i])
                {
                    Maiorsalario = arr[i];
                }


                if (Menorsalario > arr[i])
                {
                    Menorsalario = arr[i];
                }
            }



            decimal numero = ((totpessoas1500 * 200) / 100);


            Console.WriteLine("TOTAL DE SALÁRIOS COMPUTADOS: " + Mediasalario + " R$" +
            "\nTotal de pessoas computadas: " + arr.Length +
            " \nA média de salário é: " + Mediasalario / arr.Length + " R$" +
            "\nO número total de filhos: " + MediaFilho +
            "\nA Média de filhos por pessoa é: " + MediaFilho / arr.Length +
            "\nO maior salário é:  " + Maiorsalario + " R$" +
            "\nO menor salário é: " + Menorsalario + " R$" +
            "\nPessoas com salário menor ou igual a 1500: " + totpessoas1500 +
            "\nA porcentagem de pessoas com salários de até 1500 é: " + numero + "%");

            return "codigo executado";







        }

        public class tabelaCarro
        {
            public int indice { get; set; }
            public string marca { get; set; }
            public int valor { get; set; }
            public string cor { get; set; }

            public string modelo { get; set; }
            public int ano { get; set; }


        }



        public string tabelaCarror()
        {
            List<Carro> carros = new List<Carro>();
            var i = 0;


            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Digite 1 para cadastrar um veiculo \n" +
                " Digite 2 para excluir um veiculo \n" +
                " Digite 3 para mostrar os carros \n" +
                " Digite 4 para fechar a aplicação \n");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Carro carro = new Carro();
                    carro.indice = i++;

                    Console.WriteLine("Indice: " + carro.indice);
                    Console.WriteLine("Digite a marca do carro: ");
                    carro.marca = (Console.ReadLine());
                    Console.WriteLine("Digite o valor do carro: ");
                    carro.valor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o modelo do carro: ");
                    carro.modelo = Console.ReadLine();
                    Console.WriteLine("Digite a cor do carro: ");
                    carro.cor = Console.ReadLine();
                    Console.WriteLine("Digite o ano do carro");
                    carro.ano = Convert.ToInt32(Console.ReadLine());
                    carros.Add(carro);


                }
                var excluir = 0;
                if (opcao == 2)
                {

                    Console.Clear();
                    Console.WriteLine("Digite  o índice do carro que deseja excluir");
                    excluir = Convert.ToInt32(Console.ReadLine());

                    carros.RemoveAt(excluir);

                    Console.WriteLine("Carro " + excluir + " Excluido");
                    Console.ReadLine();
                }



                if (opcao == 3)
                {

                    Console.WriteLine();
                    carros.Sort((carro1, carro2) => carro1.valor.CompareTo(carro2.valor));
                    Console.WriteLine("Carros ordenados do menor valor para o maior valor");
                    Console.WriteLine();
                    foreach (Carro carro in carros)
                    {

                        Console.WriteLine("Indice do veiculo: " + carro.indice +
                        "\n Marca " + carro.marca +
                        "\n Valor: " + carro.valor + " R$" +
                        "\n Modelo: " + carro.modelo +
                        "\n Cor: " + carro.cor +
                        "\n ano: " + carro.ano);

                    }
                    Console.ReadLine();
                }


            } while (opcao != 4);
            return "codigo executado";
        }
    }


}

