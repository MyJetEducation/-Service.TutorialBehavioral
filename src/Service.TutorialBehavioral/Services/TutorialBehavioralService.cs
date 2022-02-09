using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialBehavioral.Grpc;
using Service.TutorialBehavioral.Grpc.Models;
using Service.TutorialBehavioral.Grpc.Models.State;
using Service.TutorialBehavioral.Mappers;
using Service.UserProgress.Grpc;
using Service.UserProgress.Grpc.Models;
using Service.UserReward.Grpc;
using Service.UserReward.Grpc.Models;

namespace Service.TutorialBehavioral.Services
{
	public partial class TutorialBehavioralService : ITutorialBehavioralService
	{
		private static readonly EducationStructureTutorial Tutorial = EducationStructure.Tutorials[EducationTutorial.BehavioralFinance];

		private readonly ITaskProgressService _taskProgressService;
		private readonly IUserRewardService _userRewardService;
		private readonly IUserProgressService _userProgressService;

		public TutorialBehavioralService(ITaskProgressService taskProgressService, IUserRewardService userRewardService, IUserProgressService userProgressService)
		{
			_taskProgressService = taskProgressService;
			_userRewardService = userRewardService;
			_userProgressService = userProgressService;
		}

		public async ValueTask<BehavioralStateGrpcResponse> GetDashboardStateAsync(BehavioralSelectTaskUnitGrpcRequest request)
		{
			var units = new List<BehavioralStateUnitGrpcModel>();
			Guid? userId = request.UserId;

			foreach ((_, EducationStructureUnit unit) in Tutorial.Units)
			{
				(BehavioralStateUnitGrpcModel stateUnitModel, _, _) = await _taskProgressService.GetUnitProgressAsync(userId, unit.Unit);

				if (stateUnitModel != null)
					units.Add(stateUnitModel);
			}

			UserAchievementsGrpcResponse achievements = await _userRewardService.GetUserAchievementsAsync(new GetUserAchievementsGrpcRequest {UserId = userId});
			UnitedProgressGrpcResponse progress = await _userProgressService.GetUnitedProgressAsync(new GetProgressGrpcRequset {UserId = userId});

			return new BehavioralStateGrpcResponse
			{
				Available = true,
				Units = units,
				TotalProgress = new TotalProgressStateGrpcModel
				{
					Habit = progress.Habit.ToGrpcModel(),
					Skill = progress.Skill.ToGrpcModel(),
					Achievements = achievements.Items
				}
			};
		}

		public async ValueTask<FinishUnitGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request)
		{
			Guid? userId = request.UserId;

			(BehavioralStateUnitGrpcModel stateUnitModel, int trueFalseProgress, int caseProgress) = await _taskProgressService.GetUnitProgressAsync(userId, request.Unit);

			var result = new FinishUnitGrpcResponse
			{
				Unit = stateUnitModel,
				TrueFalseProgress = trueFalseProgress,
				CaseProgress = caseProgress
			};

			UserAchievementsGrpcResponse newAchievements = await _userRewardService.GetUserNewUnitAchievementsAsync(new GetUserAchievementsGrpcRequest {UserId = userId});
			if (newAchievements != null)
				result.NewAchievements = newAchievements.Items;

			return result;
		}
	}
}