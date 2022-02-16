using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;
using Service.TutorialBehavioral.Grpc;

namespace Service.TutorialBehavioral.Client
{
	[UsedImplicitly]
	public class TutorialBehavioralClientFactory : MyGrpcClientFactory
	{
		public TutorialBehavioralClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
		{
		}

		public ITutorialBehavioralService GetTutorialBehavioralService() => CreateGrpcService<ITutorialBehavioralService>();
	}
}
