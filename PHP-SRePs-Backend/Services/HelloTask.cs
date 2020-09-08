using System;
using System.Collections.Generic;
using System.Text;
using Grpc.Core;
using System.Threading;
using System.Threading.Tasks;


namespace PHP_SRePs_Backend
{
    class HelloTask : HelloService.HelloServiceBase
    {
        public override Task<HelloReply> Hello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Name = "Hello" + request.Name });
        }
    }
}
