using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace PHP_SRePS_Backend
{
    public class SaleService : Sale.SaleBase
    {
        private readonly ILogger<GreeterService> _logger;
        public SaleService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<ErrorCodeReply> AddSale(AddSaleRequest request, ServerCallContext context)
        {
            
            return Task.FromResult(new ErrorCodeReply
            {
                ErrorCode = false
            }) ;
        }
    }
}
