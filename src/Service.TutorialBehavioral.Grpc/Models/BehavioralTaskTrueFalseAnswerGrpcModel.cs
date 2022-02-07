using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models
{
	[DataContract]
	public class BehavioralTaskTrueFalseAnswerGrpcModel
	{
		[DataMember(Order = 1)]
		public int Number { get; set; }

		[DataMember(Order = 2)]
		public bool Value { get; set; }
	}
}