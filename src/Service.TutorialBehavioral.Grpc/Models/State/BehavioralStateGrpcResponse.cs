using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models.State
{
	[DataContract]
	public class BehavioralStateGrpcResponse
	{
		[DataMember(Order = 1)]
		public bool Available { get; set; }

		[DataMember(Order = 2)]
		public IList<BehavioralStateUnitGrpcModel> Units { get; set; }

		[DataMember(Order = 3)]
		public TotalProgressStateGrpcModel TotalProgress { get; set; }
	}
}