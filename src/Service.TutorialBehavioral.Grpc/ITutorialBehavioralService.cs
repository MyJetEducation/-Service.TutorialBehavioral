using System.ServiceModel;
using System.Threading.Tasks;
using Service.TutorialBehavioral.Grpc.Models;
using Service.TutorialBehavioral.Grpc.Models.State;

namespace Service.TutorialBehavioral.Grpc
{
	[ServiceContract]
	public interface ITutorialBehavioralService
	{
		[OperationContract]
		ValueTask<FinishStateGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request);

		#region Unit1

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TextAsync(BehavioralTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TestAsync(BehavioralTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1VideoAsync(BehavioralTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1CaseAsync(BehavioralTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1GameAsync(BehavioralTaskGameGrpcRequest request);

		#endregion

		#region Unit2

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TextAsync(BehavioralTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TestAsync(BehavioralTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2VideoAsync(BehavioralTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2CaseAsync(BehavioralTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2GameAsync(BehavioralTaskGameGrpcRequest request);

		#endregion

		#region Unit3

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TextAsync(BehavioralTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TestAsync(BehavioralTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3VideoAsync(BehavioralTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3CaseAsync(BehavioralTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3GameAsync(BehavioralTaskGameGrpcRequest request);

		#endregion

		#region Unit4

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TextAsync(BehavioralTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TestAsync(BehavioralTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4VideoAsync(BehavioralTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4CaseAsync(BehavioralTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4GameAsync(BehavioralTaskGameGrpcRequest request);

		#endregion

		#region Unit5

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TextAsync(BehavioralTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TestAsync(BehavioralTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5VideoAsync(BehavioralTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5CaseAsync(BehavioralTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TrueFalseAsync(BehavioralTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5GameAsync(BehavioralTaskGameGrpcRequest request);

		#endregion
	}
}