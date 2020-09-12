using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace PHP_SRePS_Backend
{
    public class SaleService : SaleDef.SaleDefBase
    {
        private readonly ILogger<SaleService> _logger;
        public SaleService(ILogger<SaleService> logger)
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

        public override Task GetSale(SaleGet request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            // do stuff
            return base.GetSale(request, responseStream, context);
        }

        public override Task GetAllSales(SaleGet request, IServerStreamWriter<SaleInfo> responseStream, ServerCallContext context)
        {
            // do stuff
            return base.GetAllSales(request, responseStream, context);
        }
    }
}
