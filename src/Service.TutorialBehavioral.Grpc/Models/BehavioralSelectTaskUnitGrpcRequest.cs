using System;
using System.Runtime.Serialization;

namespace Service.TutorialBehavioral.Grpc.Models
{
	[DataContract]
	public class BehavioralSelectTaskUnitGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }
	}
}