namespace Calculator.Matrix
{
	public static class Calculator
	{
		public static string Display = string.Empty;
		public static decimal Result = 0;
		public static decimal Current = 0;
		public static Modes Mode = Modes.Entry;
		public static bool Power = false;
		public static Buttons? Function = null;

		public static void Reset()
		{
			Power = true;
			Current = 0;
			Display = Current.ToString("G0");
			Mode = Modes.Entry;
			Function = null;
		}

		public static void Press(Buttons button)
		{
			if (!Power)
				return;

			switch (button)
			{
				case Buttons.Zero:
				case Buttons.One:
				case Buttons.Two:
				case Buttons.Three:
				case Buttons.Four:
				case Buttons.Five:
				case Buttons.Six:
				case Buttons.Seven:
				case Buttons.Eight:
				case Buttons.Nine:
					PressNumeric(button);
					break;

				case Buttons.Plus:
				case Buttons.Minus:
				case Buttons.Multiply:
				case Buttons.Divide:
					PressArithmetic(button);
					break;

				case Buttons.Equals:
					PressResult(button);
					break;
			}
		}

		private static void PressResult(Buttons button)
		{
			if (Function == null)
				return;

			ExecuteFunction();

			Mode = Modes.Result;
		}

		private static void PressArithmetic(Buttons button)
		{
			if (Function != null)
				ExecuteFunction();
			else
				Result = Current;

			Function = button;

			Current = 0;
		}

		private static void ExecuteFunction()
		{
			if (Function == null)
				return;

			switch (Function.Value)
			{
				case Buttons.Plus:
					Result += Current;
					break;
				case Buttons.Minus:
					Result -= Current;
					break;
				case Buttons.Multiply:
					Result *= Current;
					break;
				case Buttons.Divide:
					Result /= Current;
					break;
			}

			Display = Result.ToString("G0");
		}

		private static void PressNumeric(Buttons button)
		{
			switch (Mode)
			{
				case Modes.Entry:
					Current *= 10.0m;
					Current += (decimal)button;
					Display = Current.ToString("G0");
					break;

				case Modes.Result:
					Result = 0;
					Current = (decimal)button;
					Display = Current.ToString("G0");
					Mode = Modes.Entry;
					break;
			}
		}

		public enum Buttons
		{
			Zero,
			One,
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Equals,
			Plus,
			Minus,
			Multiply,
			Divide
		}

		public enum Modes
		{
			Entry,
			Result
		}
	}
}