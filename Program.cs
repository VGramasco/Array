namespace exercicios
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            int variavel;


        int[] numero = new int[10];
            for (i = 0; i < 10; i++)
            {

                Console.WriteLine("Insira um número");
                variavel = Int32.Parse(Console.ReadLine());
                numero[i] = variavel;

                Console.WriteLine("Posição: " + i + "\n" + "Número: " + numero[i]);

            }
        }
    }



}