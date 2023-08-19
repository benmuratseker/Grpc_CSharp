using Average;
using Blog;
using Calculator;
using Dummy;
using Great;
using Grpc.Core;
using Max;
using Prime;
using Sqrt;
using System.Security.AccessControl;

#region Greeting Service
//const string target = "127.0.0.1:50051";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith((task) =>
//{
//    if (task.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

////var client = new DummyService.DummyServiceClient(channel);
//var client  = new GreetingService.GreetingServiceClient(channel);

//var greeting = new Greeting()
//{
//    FirstName = "Murat",
//    LastName = "Seker"
//};

//var request = new GreetingRequest() { Greeting = greeting };

//var response = client.Greet(request);

//Console.WriteLine(response.Result);

//channel.ShutdownAsync().Wait();
#endregion

#region Calculator Service Unary
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new CalculatorService.CalculatorServiceClient(channel);

//var request = new SumRequest()
//{
//    A = 10,
//    B = 3
//};

//var response = client.Sum(request);

//Console.WriteLine(response.Resut);

//channel.ShutdownAsync().Wait();
#endregion

#region Many Times Greetimg Server Stream
//const string target = "127.0.0.1:50051";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//await channel.ConnectAsync().ContinueWith((task) =>
//{
//    if (task.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

////var client = new DummyService.DummyServiceClient(channel);
//var client = new GreetingService.GreetingServiceClient(channel);

//var greeting = new Greeting()
//{
//    FirstName = "Murat",
//    LastName = "Seker"
//};

//var request = new GreetManyRequest() { Greeting = greeting };

//var response = client.GreatManyTimes(request);

//while (await response.ResponseStream.MoveNext())
//{
//    Console.WriteLine(response.ResponseStream.Current.Result);
//    await Task.Delay(200);
//}

//channel.ShutdownAsync().Wait();
#endregion

#region Prime Number Server Stream
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new PrimeNumberService.PrimeNumberServiceClient(channel);

//var request = new PrimeNumberDecompositionRequest()
//{
//    Number = 120
//};

//var response = client.PrimeNumberDecomposition(request);

//while (await response.ResponseStream.MoveNext())
//{
//    Console.WriteLine(response.ResponseStream.Current.PrimeFactor);
//    await Task.Delay(300);
//}

//channel.ShutdownAsync().Wait();
#endregion

#region Long Greeting Client Stream
//const string target = "127.0.0.1:50051";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith((task) =>
//{
//    if (task.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

////var client = new DummyService.DummyServiceClient(channel);
//var client = new GreetingService.GreetingServiceClient(channel);

//var greeting = new Greeting()
//{
//    FirstName = "Murat",
//    LastName = "Seker"
//};

//var request = new LongGreetRequest() { Greeting = greeting };

//var stream = client.LongGreet();

//foreach (var i in Enumerable.Range(1,10))
//{
//    await stream.RequestStream.WriteAsync(request);
//}

//await stream.RequestStream.CompleteAsync();
//var response = await stream.ResponseAsync;

//Console.WriteLine(response.Result);

//channel.ShutdownAsync().Wait();
#endregion

#region Average Client Stream
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new AverageService.AverageServiceClient(channel);

//var stream = client.ComputeAverage();

//foreach (var number in Enumerable.Range(1,4))
//{
//    var request = new AverageRequst() { Number = number };

//    await stream.RequestStream.WriteAsync(request);
//}

//await stream.RequestStream.CompleteAsync();

//var response = await stream.ResponseAsync;

//Console.WriteLine(response.Result);

//channel.ShutdownAsync().Wait();
#endregion

#region Greet Everyone Bi-directional Stream
//const string target = "127.0.0.1:50051";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//await channel.ConnectAsync().ContinueWith((task) =>
//{
//    if (task.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new GreetingService.GreetingServiceClient(channel);

//var stream = client.GreetEveryOne();

//var responseReaderTask = Task.Run(async () =>
//{
//    while (await stream.ResponseStream.MoveNext())
//    {
//        await Console.Out.WriteLineAsync("Received : " + stream.ResponseStream.Current.Result);
//    }
//});

//Greeting[] greetings =
//{
//    new Greeting(){ FirstName = "Murat", LastName="Seker"},
//    new Greeting(){ FirstName = "Maria", LastName="Ortiz"},
//    new Greeting(){ FirstName = "Jula", LastName="Julka"},
//};

//foreach (var greeting in greetings)
//{
//    Console.WriteLine("Sending:"+ greeting.ToString());
//    await stream.RequestStream.WriteAsync(new GreetEveryoneRequest()
//    {
//        Greeting = greeting
//    });
//}

//await stream.RequestStream.CompleteAsync();
//await responseReaderTask;
//channel.ShutdownAsync().Wait();
#endregion

#region Find Max Number Bi-directional
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new FindMaxService.FindMaxServiceClient(channel);

//var stream = client.FindMaximum();

//var responseReaderTask = Task.Run(async () =>
//{
//    while (await stream.ResponseStream.MoveNext())
//        Console.WriteLine(stream.ResponseStream.Current.Max);
//});

//int[] numbers = { 1, 5, 3, 6, 2, 20 };

//foreach (var number in numbers)
//{
//    await stream.RequestStream.WriteAsync(new FindMaxRequest() { Number = number });
//}

//await stream.RequestStream.CompleteAsync();
//await responseReaderTask;

//channel.ShutdownAsync().Wait();
#endregion

#region Sqrt With Exception
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new SqrtService.SqrtServiceClient(channel);

//var number = -16;

//try
//{
//    var response = client.Sqrt(new SqrtRequest { Number = number });
//    Console.WriteLine(response.SquareRoot);
//}
//catch (RpcException e)
//{
//    Console.WriteLine($"There is an error while doing operation: {e.Status.Detail}");
//    throw;
//}

//channel.ShutdownAsync().Wait();
#endregion

#region DeadLines
//const string target = "127.0.0.1:50052";

//Channel channel = new Channel(target, ChannelCredentials.Insecure);

//channel.ConnectAsync().ContinueWith(t =>
//{
//    if (t.Status == TaskStatus.RanToCompletion)
//        Console.WriteLine("The client connected successfully");
//});

//var client = new GreetingService.GreetingServiceClient(channel);

//var name = "Helen";

//try
//{
//    var response = client.GreetWithDeadLine(new GreetDeadLineRequest { Name = name }, deadline: DateTime.UtcNow.AddMilliseconds(250));
//    Console.WriteLine(response.Result);
//}
//catch (RpcException e) when (e.StatusCode == StatusCode.DeadlineExceeded)
//{
//    Console.WriteLine($"There is an error while doing operation: {e.Status.Detail}");
//}

//channel.ShutdownAsync().Wait();
#endregion

#region MongoDb
Channel channel = new Channel("localhost", 50052, ChannelCredentials.Insecure);

await channel.ConnectAsync().ContinueWith((task) =>
{
    if(task.Status == TaskStatus.RanToCompletion)
        Console.WriteLine("The client connected successfully!..");
});

var client = new BlogService.BlogServiceClient(channel);
#region Create Blog
//var response = client.CreateBlog(new CreateBlogRequest
//{
//    Blog = new Blog.Blog()
//    {
//        AuthorId = "Murat",
//        Title = "Blog No3!",
//        Content = "Hello guys, this is the third blog!.."
//    }
//});

//Console.WriteLine($"The blog {response.Blog.Id} was created!");
#endregion

#region Read Blog
//try
//{
//    var response = client.ReadBlog(new ReadBlogRequest()
//    {
//        BlogId = "64da9ddb7c576c9ae8ac2526"
//    });

//    Console.WriteLine(response.Blog.ToString());
//}
//catch (RpcException e)
//{
//    Console.WriteLine(e.Status.Detail);
//}
#endregion

#region Update Blog
//try
//{
//    var blog = client.ReadBlog(new ReadBlogRequest()
//    {
//        BlogId = "64da9ddb7c576c9ae8ac2526"
//    });

//    blog.Blog.AuthorId = "Updated Author";
//    blog.Blog.Title = "New Title";
//    blog.Blog.Content = "New content!";

//    var response = client.UpdateBlog(new UpdateBlogRequest()
//    {
//        Blog = blog.Blog
//    });

//    Console.WriteLine(response.Blog.ToString());
//} 
//catch (RpcException e)
//{           
//    Console.WriteLine(e.Status.Detail);
//}
#endregion

#region Delete Blog
//try
//{
//    var blog = client.ReadBlog(new ReadBlogRequest()
//    {
//        BlogId = "64da9ddb7c576c9ae8ac2526"
//    });

//    var response = client.DeleteBlog(new DeleteBlogRequest() { BlogId = blog.Blog.Id });

//    Console.WriteLine($"The blog with the id {blog.Blog.Id} was deleted!");
//}
//catch (RpcException e)
//{
//    Console.WriteLine(e.Status.Detail);
//}
#endregion

#region List Blog
var response = client.ListBlog(new ListBlogRequest() { });

while (await response.ResponseStream.MoveNext())
{
    Console.WriteLine(response.ResponseStream.Current.Blog.ToString());
}
#endregion
channel.ShutdownAsync().Wait();
#endregion
Console.ReadKey();