using Service.TutorialBehavioral.Grpc.Models.State;

namespace Service.TutorialBehavioral.Models
{
	public class UnitInfoModel
	{
		public BehavioralStateUnitGrpcModel BehavioralStateUnit { get; set; }

		public int TrueFalseProgress { get; set; }

		public int CaseProgress { get; set; }
	}
}