namespace Calculator.Tests
{
	public class Behavior
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Startup()
		{
			Matrix.Calculator.Reset();

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Current, Is.EqualTo(0));
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("0"));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});
		}

		[Test]
		public void Entry_NumericButtons()
		{
			Matrix.Calculator.Reset();

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Zero);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Four);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Five);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("12345"));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});
		}

		[Test]
		public void Result_NumericButtons()
		{
			Matrix.Calculator.Reset();

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Function, Is.EqualTo(Matrix.Calculator.Buttons.Plus));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Result));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("1"));
				Assert.That(Matrix.Calculator.Function, Is.Null);
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Function, Is.EqualTo(Matrix.Calculator.Buttons.Plus));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Result));
			});
		}

		[Test]
		public void Result_ArithmeticButtons()
		{
			Matrix.Calculator.Reset();

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Multiply);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("9"));
				Assert.That(Matrix.Calculator.Function, Is.EqualTo(Matrix.Calculator.Buttons.Multiply));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Result));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Divide);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Function, Is.EqualTo(Matrix.Calculator.Buttons.Divide));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Function, Is.EqualTo(Matrix.Calculator.Buttons.Divide));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Result));
			});
		}

		[Test]
		public void Entry_ArithmeticButtons()
		{
			Matrix.Calculator.Reset();

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Zero);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(3.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Three);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(3.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Minus);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Four);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("4"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(6.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Multiply);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("2"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(2.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Divide);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("2"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(4.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Entry));
			});
		}

		[Test]
		public void Entry_ResultButtons()
		{
			Matrix.Calculator.Reset();

			Matrix.Calculator.Press(Matrix.Calculator.Buttons.One);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Plus);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Two);
			Matrix.Calculator.Press(Matrix.Calculator.Buttons.Equals);

			Assert.Multiple(() =>
			{
				Assert.That(Matrix.Calculator.Display, Is.EqualTo("3"));
				Assert.That(Matrix.Calculator.Result, Is.EqualTo(3.0m));
				Assert.That(Matrix.Calculator.Mode, Is.EqualTo(Matrix.Calculator.Modes.Result));
			});
		}
	}
}