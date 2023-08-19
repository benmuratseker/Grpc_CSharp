using Grpc.Core;
using Prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prime.PrimeNumberService;

namespace AppServer
{
    public class PrimeNumberServiceImp : PrimeNumberServiceBase
    {
        public override async Task PrimeNumberDecomposition(PrimeNumberDecompositionRequest request, IServerStreamWriter<PrimeNumberDecompositionResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine("The server received the request:");
            int number = request.Number;
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    number /= divisor;
                    await responseStream.WriteAsync(new PrimeNumberDecompositionResponse() { PrimeFactor = divisor });
                }
                else
                    divisor++;
            }
        }
    }
}
