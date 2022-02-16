using System;
using System.Threading.Tasks;
using ProtoBuf.Grpc.Client;
using Service.TutorialBehavioral.Client;
using Service.TutorialBehavioral.Grpc;

namespace TestApp
{
	public class Program
	{
		private static async Task Main(string[] args)
		{
			GrpcClientFactory.AllowUnencryptedHttp2 = true;

			Console.Write("Press enter to start");
			Console.ReadLine();

			var factory = new TutorialBehavioralClientFactory("http://localhost:5001");
			ITutorialBehavioralService client = factory.GetTutorialBehavioralService();

			//var resp = await  client.SayHelloAsync(new HelloGrpcRequest(){Name = "Alex"});
			//Console.WriteLine(resp?.Message);

			Console.WriteLine("End");
			Console.ReadLine();
		}
	}
}