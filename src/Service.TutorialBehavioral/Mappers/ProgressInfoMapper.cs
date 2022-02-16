using Service.Core.Client.Constants;
using Service.TutorialBehavioral.Grpc.Models.State;
using Service.TutorialBehavioral.Models;

namespace Service.TutorialBehavioral.Mappers
{
	public static class ProgressInfoMapper
	{
		public static FinishStateGrpcResponse ToGrpcModel(this TaskTypeProgressInfo info, UserAchievement[] achievements)
		{
			return new FinishStateGrpcResponse
			{
				Case = info.Case,
				TrueFalse = info.TrueFalse,
				Test = info.Test,
				Achievements = achievements
			};
		}
	}
}