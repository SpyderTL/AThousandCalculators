using System.Drawing.Drawing2D;

namespace Calculator.WinForms
{
	internal class CalculatorProgram
	{
		internal static CalculatorForm Form = new();

		internal static void Run()
		{
			ApplicationConfiguration.Initialize();

			Form.EqualsButton.Click += EqualsButton_Click;
			Form.ZeroButton.Click += ZeroButton_Click;
			Form.OneButton.Click += OneButton_Click;
			Form.TwoButton.Click += TwoButton_Click;
			Form.ThreeButton.Click += ThreeButton_Click;
			Form.FourButton.Click += FourButton_Click;
			Form.FiveButton.Click += FiveButton_Click;
			Form.SixButton.Click += SixButton_Click;
			Form.SevenButton.Click += SevenButton_Click;
			Form.EightButton.Click += EightButton_Click;
			Form.NineButton.Click += NineButton_Click;
			Form.PlusButton.Click += PlusButton_Click;

			Matrix.Calculator.Reset();

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;

			Application.Run(Form);
		}

		private static void EqualsButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void PlusButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void NineButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Nine);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void EightButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Eight);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void SevenButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Seven);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void SixButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Six);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void FiveButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Five);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void FourButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Four);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void ThreeButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void TwoButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void OneButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}

		private static void ZeroButton_Click(object? sender, EventArgs e)
		{
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Zero);

			Form.DisplayTextBox.Text = Matrix.Calculator.Display;
		}
	}
}