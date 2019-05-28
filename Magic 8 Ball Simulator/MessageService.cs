using System;
using System.Collections.Generic;

namespace Magic_8_Ball_Simulator {
	public class MessageService {

		public MessageService() {
			SetupMessages();
		}

		private List<String> messages = new List<string>();

		private void SetupMessages() {
			messages = new List<string>() { 
				"Signs point to yes.", 
				"Yes.",
				"Reply hazy, try again.", 
				"Without a doubt.", 
				"My sources say no.", 
				"As I see it, yes.", 
				"You may rely on it.", 
				"Concentrate and ask again.", 
				"Outlook not so good.", 
				"It is decidedly so.", 
				"Better not tell you now.", 
				"Very doubtful.", 
				"Yes - definitely.", 
				"It is certain.", 
				"Cannot predict now.", 
				"Most likely.", 
				"Ask again later.", 
				"My reply is no.", 
				"Outlook good.", 
				"Don't count on it."
			};
		}

		public string GetMessage() {
			Random random = new Random();
			int index = random.Next(0, messages.Count - 1);

			return messages[index];
		}
	}
}
