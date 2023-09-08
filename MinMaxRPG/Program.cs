namespace MinMaxRPG
{
    internal class Program
    {
        public static int RolarDado(int dado)
        {
            Random rnd = new Random();
            int rolagem = rnd.Next(1, dado + 1);
            return rolagem;
        }
        public static void Main(string[] args)
        {
            int[] rolagens = new int[10000];
            int dado;
            int soma = 0;
            int RolagemPlus = 0;
            int blablabla = 0;

            Console.Write("Digite qual dado que você quer rolar: ");
            dado = int.Parse(Console.ReadLine());

            for (int i = 0; i < rolagens.Length; i++)
            {
                int rolagem = RolarDado(dado);

                if (rolagem < 9)
                {
                    int rolagemExtra = RolarDado(10);
                    rolagem += rolagemExtra;
                    if (rolagem >= 9)
                    {
                        blablabla++;
                    }
                    RolagemPlus++;
                }

                rolagens[i] = rolagem;
            }

            for (int i = 0; i < rolagens.Length; i++)
            {
                soma += rolagens[i];
            }

            double media = soma / rolagens.Length;

            Console.WriteLine("A media de rolamentos de um dado de " + dado + "lados é: " + media);
            Console.WriteLine("Numero de vezes que não precisamos de rolagem plus: " + (rolagens.Length - RolagemPlus));
            Console.WriteLine("Numero de rolagensplus: " + RolagemPlus);
            Console.WriteLine("Numero de 9 ou mais com o d10: " + blablabla);
            Console.Write("Aperte qualquer tecla para sair do programa ");
            Console.ReadLine();
        }
    }
}