using AppServer;
using Average;
using Blog;
using Calculator;
using Great;
using Grpc.Core;
using Grpc.Reflection;
using Grpc.Reflection.V1Alpha;
using Max;
using Prime;
using Sqrt;

#region Greeting Service
//const int Port = 50051;

//Server server = null;

//try
//{
//    server = new Server
//    {
//        Services = { GreetingService.BindService(new GreetingServiceImp()) },
//        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//    };

//    server.Start();
//    Console.WriteLine("The server is listening on the port :" + Port);
//    Console.ReadKey();
//}
//catch (IOException ex)
//{
//    Console.WriteLine("The server failed to start:" + ex.Message);
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region Calculator Service Unary
//const int Port = 50052;

//Server server = null;

//try
//{
//	server = new Server()
//	{
//		Services = { CalculatorService.BindService(new CalculatorServiceImp()) },
//		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//	};

//	server.Start();
//    Console.WriteLine($"The server listening on the port:{Port}");
//	Console.ReadKey();
//}
//catch (Exception e)
//{
//    Console.WriteLine($"The server failed to start:{e.Message}");
//	throw;
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region Greet Many Times Server Streaming
//const int Port = 50051;

//Server server = null;

//try
//{
//    server = new Server
//    {
//        Services = { GreetingService.BindService(new GreetingServiceImp()) },
//        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//    };

//    server.Start();
//    Console.WriteLine("The server is listening on the port :" + Port);
//    Console.ReadKey();
//}
//catch (IOException ex)
//{
//    Console.WriteLine("The server failed to start:" + ex.Message);
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region Prime Number Server Streaming
//const int Port = 50052;

//Server server = null;

//try
//{
//	server = new Server()
//	{
//		Services = { PrimeNumberService.BindService(new PrimeNumberServiceImp()) },
//		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//	};

//	server.Start();
//	Console.WriteLine($"The server listening on the port:{Port}");
//	Console.ReadKey();
//}
//catch (Exception e)
//{
//	Console.WriteLine($"The server failed to start:{e.Message}");
//	throw;
//}
//finally
//{
//	if (server != null)
//		server.ShutdownAsync().Wait();
//}
#endregion

#region Long Greet Client Streaming
//const int Port = 50051;

//Server server = null;

//try
//{
//    server = new Server
//    {
//        Services = { GreetingService.BindService(new GreetingServiceImp()) },
//        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//    };

//    server.Start();
//    Console.WriteLine("The server is listening on the port :" + Port);
//    Console.ReadKey();
//}
//catch (IOException ex)
//{
//    Console.WriteLine("The server failed to start:" + ex.Message);
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region Average Server
//const int Port = 50052;

//Server server = null;

//try
//{
//	server = new Server()
//	{
//		Services = { AverageService.BindService(new AverageServiceImp()) },
//		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//	};

//	server.Start();
//	Console.WriteLine($"The server listening on the port:{Port}");
//	Console.ReadKey();
//}
//catch (Exception e)
//{
//	Console.WriteLine($"The server failed to start:{e.Message}");
//	throw;
//}
//finally
//{
//	if (server != null)
//		server.ShutdownAsync().Wait();
//}
#endregion

#region Greet Eveyone Di-directional
//const int Port = 50051;

//Server server = null;

//try
//{
//    server = new Server
//    {
//        Services = { GreetingService.BindService(new GreetingServiceImp()) },
//        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//    };

//    server.Start();
//    Console.WriteLine("The server is listening on the port :" + Port);
//    Console.ReadKey();
//}
//catch (IOException ex)
//{
//    Console.WriteLine("The server failed to start:" + ex.Message);
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region Find Max Number Bi-directional
//const int Port = 50052;

//Server server = null;

//try
//{
//	server = new Server()
//	{
//		Services = { FindMaxService.BindService(new FindMaxServiceImp()) },
//		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//	};

//	server.Start();
//	Console.WriteLine($"The server listening on the port:{Port}");
//	Console.ReadKey();
//}
//catch (Exception e)
//{
//	Console.WriteLine($"The server failed to start:{e.Message}");
//	throw;
//}
//finally
//{
//	if (server != null)
//		server.ShutdownAsync().Wait();
//}
#endregion

#region Sqrt Unary with Exception
//const int Port = 50052;

//Server server = null;

//try
//{
//	server = new Server()
//	{
//		Services = { SqrtService.BindService(new SqrtServiceImp()) },
//		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//	};

//	server.Start();
//	Console.WriteLine($"The server listening on the port:{Port}");
//	Console.ReadKey();
//}
//catch (Exception e)
//{
//	Console.WriteLine($"The server failed to start:{e.Message}");
//	throw;
//}
//finally
//{
//	if (server != null)
//		server.ShutdownAsync().Wait();
//}
#endregion

#region DeadLines
//const int Port = 50052;

//Server server = null;

//try
//{
//    server = new Server()
//    {
//        Services = { GreetingService.BindService(new GreetingServiceImp()) },
//        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
//    };

//    server.Start();
//    Console.WriteLine($"The server listening on the port:{Port}");
//    Console.ReadKey();
//}
//catch (RpcException e)
//{
//    Console.WriteLine($"The server failed to start:{e.Status.Detail}");
//}
//finally
//{
//    if (server != null)
//        server.ShutdownAsync().Wait();
//}
#endregion

#region MongoDB
const int Port = 50052;

Server server = null;

try
{
	var reflectionServiceImp = new ReflectionServiceImpl(BlogService.Descriptor, ServerReflection.Descriptor);

	server = new Server()
	{
		Services = { 
			BlogService.BindService(new BlogServiceImp()),
			ServerReflection.BindService(reflectionServiceImp)	
		},
		Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
	};

	server.Start();
    Console.WriteLine($"The server is listening on the port:{Port}");
	Console.ReadKey();
}
catch (IOException e)
{
    Console.WriteLine($"The server failed to start:{e.Message}");
    throw;
}
finally
{
	if(server != null )
		server.ShutdownAsync().Wait();
}
#endregion