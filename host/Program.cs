namespace host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(ChatService)))
            {
                host.Open();
                Console.WriteLine("Хост запущен");
                Console.ReadLine();
            }
        }
    }
}