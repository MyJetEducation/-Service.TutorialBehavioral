using System;
using System.Threading.Tasks;
using Service.Core.Client.Education;
using Service.EducationProgress.Grpc.Models;
using Service.TutorialBehavioral.Grpc.Models.State;

namespace Service.TutorialBehavioral.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(Guid? userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<(BehavioralStateUnitGrpcModel stateUnitModel, int TrueFalseProgress, int CaseProgress)> GetUnitProgressAsync(Guid? userId, int unit);

		ValueTask<TaskEducationProgressGrpcModel> GetTaskProgressAsync(Guid? userId, int unit, int task);
	}
}