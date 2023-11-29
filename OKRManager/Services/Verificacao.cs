


namespace OkrManager.Services
{
    public class Verificacao
    {
        public string VerificarNulidade(string entrada)
        {
            while(string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("O campo não pode ser nulo!");
                Console.WriteLine("Inisira um dado não nulo");
                entrada = Console.ReadLine();
            }
            return entrada;
        }
        public int VerificarNumero(string entrada)
        {
            int numero;
            while(!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Por favor, digite apenas números");
                entrada = Console.ReadLine();
            }
            return numero;
        }

        public decimal VerificarDecimal(string entrada)
        {
            decimal numero;
            while (!decimal.TryParse(entrada, out numero))
            {
                Console.WriteLine("Por favor, digite apenas números decimais");
                entrada = Console.ReadLine();
            }
            return numero;
        }


    }
}