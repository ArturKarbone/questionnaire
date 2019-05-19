using System;

namespace DotNetSimpleDITalk.Pass1 {
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
