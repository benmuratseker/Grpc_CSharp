using Average;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Average.AverageService;

namespace AppServer
{
    public class AverageServiceImp : AverageServiceBase
    {
        public override async Task<AverageResponse> ComputeAverage(IAsyncStreamReader<AverageRequst> requestStream, ServerCallContext context)
        {
            int total = 0;
            double result = 0.0;

            while (await requestStream.MoveNext())
            {
                result += requestStream.Current.Number;
                total++;
            }

            return new AverageResponse() { Result = result / total };
        }
    }
}
