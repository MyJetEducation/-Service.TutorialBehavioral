using System.Linq;
using Service.Core.Client.Constants;
using Service.Core.Client.Education;
using Service.TutorialBehavioral.Grpc.Models;

namespace Service.TutorialBehavioral.Services
{
	public static class AnswerHelper
	{
		public static readonly EducationStructureTutorial Tutorial = EducationStructure.Tutorials[EducationTutorial.BehavioralFinance];

		public static int CheckAnswer(int progressPrc, BehavioralTaskTestAnswerGrpcModel[] answers, int questionNumber, params int[] answerNumbers)
		{
			BehavioralTaskTestAnswerGrpcModel answer = answers.FirstOrDefault(model => model.Number == questionNumber);

			return CountProgress(answer != null && answerNumbers.Intersect(answer.Value).Count() == answerNumbers.Length, progressPrc);
		}

		public static int CheckAnswer(int progressPrc, BehavioralTaskTrueFalseAnswerGrpcModel[] answers, int questionNumber, bool answerValue)
		{
			BehavioralTaskTrueFalseAnswerGrpcModel answer = answers.FirstOrDefault(model => model.Number == questionNumber);

			return CountProgress(answer != null && answer.Value == answerValue, progressPrc);
		}

		public static int CountProgress(bool taskPassed, int progress = AnswerProgress.MaxAnswerProgress) => taskPassed ? progress : AnswerProgress.MinAnswerProgress;
	}
}