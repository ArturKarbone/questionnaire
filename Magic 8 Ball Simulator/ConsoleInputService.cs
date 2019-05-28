using System;

namespace Magic_8_Ball_Simulator {
	public class ConsoleInputService {
		private string input = "input-initializer";

		public string GetInput() {
			input = Console.ReadLine();
			return input;
		}

		public bool ExitWasRequested() {
			return String.IsNullOrEmpty(input);
		}
	}
}
