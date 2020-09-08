using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Core;
//Note this might need to be deleted as a gRPC server project may 
//Need to be created
//TODO


namespace PHP_SRePs_Backend

{
    class Program
    {
        const int Port = 4121;
        static void  Main(string[] args)
        {
            Console.WriteLine("Hello World lets do this :D!");
            Server server = new Server
            {
                Services = { HelloService.BindService(new HelloTask()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();
            server.ShutdownAsync().Wait();
        }
 
    }
}
