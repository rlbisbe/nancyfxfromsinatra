using System;
using Nancy;
using System.Collections;
using System.Collections.Generic;

namespace NancyFxSinatra
{
	public class RockPaperScissors : NancyModule
	{

		public RockPaperScissors ()
		{
			Dictionary<string,string> beats = new Dictionary<string, string> ();
			beats.Add ("rock", "scissors");
			beats.Add ("paper", "rock");
			beats.Add ("scissors", "paper");

			Get ["/throw/{type}"] = parameters => {
				string type = parameters.type;
				if (!beats.ContainsKey (type)) {
					return HttpStatusCode.Forbidden;
				}

				string player_throw = type;
					
				Random r = new Random (DateTime.Now.Millisecond);
				List<string> keys = new List<string>(beats.Keys);
				string computer_throw = keys[r.Next (keys.Count)];

				if (player_throw == computer_throw) {
					return "Tied with the computer. Try again!";
				}

				if (computer_throw == beats [player_throw]) {
					return string.Format ("Nice, {0} beats {1}", player_throw, computer_throw);
				}

				return string.Format ("Sorry, {0} beats {1}", computer_throw, player_throw);
			};

		}
	}
}

