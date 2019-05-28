using System;

namespace Magic_8_Ball_Simulator {
	public class ConsoleOutputService {
		public void PrintMessage(string message) {
			Console.WriteLine(message);
		}

		public void PrintWelcome() {
			Console.WriteLine("Welcome to the Magic 8 Ball simulator");
		}

		public void PrintInputPrompt() {
			Console.Write("Ask a Question, or press [Enter] to exit >> ");
		}

		public void PrintExit() {
			Console.WriteLine("Goodbye");
		}
	}
}
