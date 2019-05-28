namespace Magic_8_Ball_Simulator {
	public class Magic8BallSimulatorEvenWorse {

		private MessageService _messageService;
		private ConsoleInputService _inputService;
		private ConsoleOutputService _outputService;

		public Magic8BallSimulatorEvenWorse() {
			_messageService = new MessageService();
			_inputService = new ConsoleInputService();
			_outputService = new ConsoleOutputService();
		}

		public void Run() {
			_outputService.PrintWelcome();
			string message = string.Empty;

			while (!_inputService.ExitWasRequested()) {
				_outputService.PrintInputPrompt();
				_inputService.GetInput();
				_messageService.GetMessage();
				message = _messageService.GetMessage();
				_outputService.PrintMessage(message);
			}

			_outputService.PrintExit();
		}
	}
}
