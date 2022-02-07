using Autofac;
using Service.TutorialBehavioral.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialBehavioral.Client
{
    public static class AutofacHelper
    {
        public static void RegisterTutorialBehavioralClient(this ContainerBuilder builder, string grpcServiceUrl)
        {
            var factory = new TutorialBehavioralClientFactory(grpcServiceUrl);

            builder.RegisterInstance(factory.GetTutorialBehavioralService()).As<ITutorialBehavioralService>().SingleInstance();
        }
    }
}
