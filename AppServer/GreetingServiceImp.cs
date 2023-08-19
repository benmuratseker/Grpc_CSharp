using Great;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Great.GreetingService;

namespace AppServer
{
    public class GreetingServiceImp : GreetingServiceBase
    {
        public override Task<GreetingResponse> Greet(GreetingRequest request, ServerCallContext context)
        {
            string result = $"hello {request.Greeting.FirstName}, {request.Greeting.LastName}";

            return Task.FromResult(new GreetingResponse() { Result = result }) ;
        }

        public override async Task GreatManyTimes(GreetManyRequest request, IServerStreamWriter<GreetManyResponse> responseStream, ServerCallContext context)
        {
            Console.WriteLine("The server received the request");
            Console.WriteLine(request.ToString());

            string result = $"Hello, {request.Greeting.FirstName} {request.Greeting.LastName}";

            foreach (var i in Enumerable.Range(1,10))
            {
                await responseStream.WriteAsync(new GreetManyResponse() { Result = result }) ;
            }
        }

        public override async Task<LongGreetResponse> LongGreet(IAsyncStreamReader<LongGreetRequest> requestStream, ServerCallContext context)
        {
            string result = "";

            while (await requestStream.MoveNext())
            {
                result += $"Hello {requestStream.Current.Greeting.FirstName} {requestStream.Current.Greeting.LastName} {Environment.NewLine}";
            }

            return new LongGreetResponse() { Result = result } ;
        }

        public override async Task GreetEveryOne(IAsyncStreamReader<GreetEveryoneRequest> requestStream, IServerStreamWriter<GreetEveryoneResponse> responseStream, ServerCallContext context)
        {
            while (await requestStream.MoveNext())
            {
                var result = $"Hello {requestStream.Current.Greeting.FirstName} {requestStream.Current.Greeting.LastName}";

                await Console.Out.WriteLineAsync("Received :" + result);
                await responseStream.WriteAsync (new GreetEveryoneResponse() {  Result = result }) ;
            }
        }

        public override async Task<GreetDeadLineResponse> GreetWithDeadLine(GreetDeadLineRequest request, ServerCallContext context)
        {
            await Task.Delay(300) ;

            return new GreetDeadLineResponse() { Result = $"Hello, {request.Name}" };
        }
    }
}
