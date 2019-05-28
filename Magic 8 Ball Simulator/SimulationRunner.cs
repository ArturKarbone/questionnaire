namespace Magic_8_Ball_Simulator {
	public class SimulationRunner {
		static void Main(string[] args) {
			// watch me now, I'm injecting dependent classes
			Magic8BallSimulator simulator = new Magic8BallSimulator(
				new MessageService(),
				new ConsoleInputService(),
				new ConsoleOutputService()
			);
			simulator.Run();
		}
	}
}
