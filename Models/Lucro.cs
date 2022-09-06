namespace Stone0309.Models
{
    public class Lucro
    {
        public static void AppLucro(decimal valorCompra, decimal valorVenda)
        {
            decimal lucro = Math.Round((valorVenda * 100) / 100);
            Console.WriteLine($"Seu lucro será {lucro}");
        }   
    }
}
