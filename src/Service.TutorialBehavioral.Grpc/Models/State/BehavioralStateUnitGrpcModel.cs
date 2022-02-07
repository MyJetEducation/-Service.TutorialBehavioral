using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models.State
{
	[DataContract]
	public class BehavioralStateUnitGrpcModel
	{
		[DataMember(Order = 1)]
		public int Unit { get; set; }

		[DataMember(Order = 2)]
		public int TestScore { get; set; }

		[DataMember(Order = 3)]
		public BehavioralStateTaskGrpcModel[] Tasks { get; set; }
	}
}