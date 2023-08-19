using Grpc.Core;
using Sqrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sqrt.SqrtService;

namespace AppServer
{
    public class SqrtServiceImp : SqrtServiceBase
    {
        public override async Task<SqrtResponse> Sqrt(SqrtRequest request, ServerCallContext context)
        {
            int number = request.Number;

            if (number > 0)
                return new SqrtResponse() { SquareRoot = Math.Sqrt(number) };
            else
                throw new RpcException(new Status(StatusCode.InvalidArgument, "number < 0"));
        }
    }
}
