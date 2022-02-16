﻿using System.Threading.Tasks;
using Service.Education;
using Service.Education.Structure;
using Service.TutorialBehavioral.Grpc.Models;
using Service.TutorialBehavioral.Grpc.Models.State;
using Service.TutorialBehavioral.Helper;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialBehavioral.Services
{
	public partial class TutorialBehavioralService
	{
		private static readonly EducationStructureUnit Unit1 = TutorialHelper.EducationStructureTutorial.Units[1];

		public async ValueTask<TestScoreGrpcResponse> Unit1TextAsync(BehavioralTaskTextGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit1TestAsync(BehavioralTaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 1)
				+ CheckAnswer(20, answers, 2, 1, 2, 3)
				+ CheckAnswer(20, answers, 3, 1)
				+ CheckAnswer(20, answers, 4, 1, 2)
				+ CheckAnswer(20, answers, 5, 1, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit1VideoAsync(BehavioralTaskVideoGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit1CaseAsync(BehavioralTaskCaseGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 1));

		public async ValueTask<TestScoreGrpcResponse> Unit1TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, false)
				+ CheckAnswer(20, answers, 2, false)
				+ CheckAnswer(20, answers, 3, true)
				+ CheckAnswer(20, answers, 4, true)
				+ CheckAnswer(20, answers, 5, true);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit1GameAsync(BehavioralTaskGameGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit1, Unit1.Tasks[6], request.IsRetry, request.Duration);
	}
}