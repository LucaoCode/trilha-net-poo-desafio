using DesafioPOO.Models;

namespace DesafioPOO
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instalando aplicativo no Nokia");
            Smartphone n = new Nokia("27992048112","Nokia 7","B1234",8);
            n.InstalarAplicativo("google play");

            Console.WriteLine("Instalando aplicativo no Iphone");
            Smartphone i = new Iphone("2733379520","Iphone 1","B1237",4);
            i.InstalarAplicativo("Zap Zap");
        }
    }
}
