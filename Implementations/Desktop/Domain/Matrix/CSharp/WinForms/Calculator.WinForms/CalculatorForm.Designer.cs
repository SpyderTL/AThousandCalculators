namespace Calculator.WinForms
{
	partial class CalculatorForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			DisplayTextBox = new TextBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			EqualsButton = new Button();
			DecimalButton = new Button();
			ZeroButton = new Button();
			NegateButton = new Button();
			PlusButton = new Button();
			ThreeButton = new Button();
			TwoButton = new Button();
			OneButton = new Button();
			MinusButton = new Button();
			SixButton = new Button();
			FiveButton = new Button();
			FourButton = new Button();
			MultiplyButton = new Button();
			NineButton = new Button();
			EightButton = new Button();
			SevenButton = new Button();
			DivideButton = new Button();
			SquareRootButton = new Button();
			SquareButton = new Button();
			InverseButton = new Button();
			DeleteButton = new Button();
			ClearButton = new Button();
			ClearEntryButton = new Button();
			PercentButton = new Button();
			panel1.SuspendLayout();
			groupBox2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Black;
			panel1.BorderStyle = BorderStyle.Fixed3D;
			panel1.Controls.Add(DisplayTextBox);
			panel1.Location = new Point(12, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(438, 64);
			panel1.TabIndex = 1;
			// 
			// DisplayTextBox
			// 
			DisplayTextBox.BackColor = Color.DarkGray;
			DisplayTextBox.Dock = DockStyle.Fill;
			DisplayTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			DisplayTextBox.ForeColor = Color.Black;
			DisplayTextBox.Location = new Point(0, 0);
			DisplayTextBox.Name = "DisplayTextBox";
			DisplayTextBox.Size = new Size(434, 61);
			DisplayTextBox.TabIndex = 1;
			DisplayTextBox.TextAlign = HorizontalAlignment.Right;
			DisplayTextBox.WordWrap = false;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Location = new Point(12, 82);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(438, 78);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(tableLayoutPanel1);
			groupBox2.Location = new Point(12, 166);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(438, 415);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Controls.Add(EqualsButton, 3, 5);
			tableLayoutPanel1.Controls.Add(DecimalButton, 2, 5);
			tableLayoutPanel1.Controls.Add(ZeroButton, 1, 5);
			tableLayoutPanel1.Controls.Add(NegateButton, 0, 5);
			tableLayoutPanel1.Controls.Add(PlusButton, 3, 4);
			tableLayoutPanel1.Controls.Add(ThreeButton, 2, 4);
			tableLayoutPanel1.Controls.Add(TwoButton, 1, 4);
			tableLayoutPanel1.Controls.Add(OneButton, 0, 4);
			tableLayoutPanel1.Controls.Add(MinusButton, 3, 3);
			tableLayoutPanel1.Controls.Add(SixButton, 2, 3);
			tableLayoutPanel1.Controls.Add(FiveButton, 1, 3);
			tableLayoutPanel1.Controls.Add(FourButton, 0, 3);
			tableLayoutPanel1.Controls.Add(MultiplyButton, 3, 2);
			tableLayoutPanel1.Controls.Add(NineButton, 2, 2);
			tableLayoutPanel1.Controls.Add(EightButton, 1, 2);
			tableLayoutPanel1.Controls.Add(SevenButton, 0, 2);
			tableLayoutPanel1.Controls.Add(DivideButton, 3, 1);
			tableLayoutPanel1.Controls.Add(SquareRootButton, 2, 1);
			tableLayoutPanel1.Controls.Add(SquareButton, 1, 1);
			tableLayoutPanel1.Controls.Add(InverseButton, 0, 1);
			tableLayoutPanel1.Controls.Add(DeleteButton, 3, 0);
			tableLayoutPanel1.Controls.Add(ClearButton, 2, 0);
			tableLayoutPanel1.Controls.Add(ClearEntryButton, 1, 0);
			tableLayoutPanel1.Controls.Add(PercentButton, 0, 0);
			tableLayoutPanel1.Location = new Point(3, 23);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.658474F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.658474F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.658474F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6630535F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6630554F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.698473F));
			tableLayoutPanel1.Size = new Size(429, 386);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// EqualsButton
			// 
			EqualsButton.Dock = DockStyle.Fill;
			EqualsButton.Location = new Point(324, 323);
			EqualsButton.Name = "EqualsButton";
			EqualsButton.Size = new Size(102, 60);
			EqualsButton.TabIndex = 23;
			EqualsButton.Text = "=";
			EqualsButton.UseVisualStyleBackColor = true;
			// 
			// DecimalButton
			// 
			DecimalButton.AccessibleDescription = "";
			DecimalButton.Dock = DockStyle.Fill;
			DecimalButton.Location = new Point(217, 323);
			DecimalButton.Name = "DecimalButton";
			DecimalButton.Size = new Size(101, 60);
			DecimalButton.TabIndex = 22;
			DecimalButton.Text = ".";
			DecimalButton.UseVisualStyleBackColor = true;
			// 
			// ZeroButton
			// 
			ZeroButton.Dock = DockStyle.Fill;
			ZeroButton.Location = new Point(110, 323);
			ZeroButton.Name = "ZeroButton";
			ZeroButton.Size = new Size(101, 60);
			ZeroButton.TabIndex = 21;
			ZeroButton.Text = "0";
			ZeroButton.UseVisualStyleBackColor = true;
			// 
			// NegateButton
			// 
			NegateButton.Dock = DockStyle.Fill;
			NegateButton.Location = new Point(3, 323);
			NegateButton.Name = "NegateButton";
			NegateButton.Size = new Size(101, 60);
			NegateButton.TabIndex = 20;
			NegateButton.Text = "+/-";
			NegateButton.UseVisualStyleBackColor = true;
			// 
			// PlusButton
			// 
			PlusButton.Dock = DockStyle.Fill;
			PlusButton.Location = new Point(324, 259);
			PlusButton.Name = "PlusButton";
			PlusButton.Size = new Size(102, 58);
			PlusButton.TabIndex = 19;
			PlusButton.Text = "+";
			PlusButton.UseVisualStyleBackColor = true;
			// 
			// ThreeButton
			// 
			ThreeButton.Dock = DockStyle.Fill;
			ThreeButton.Location = new Point(217, 259);
			ThreeButton.Name = "ThreeButton";
			ThreeButton.Size = new Size(101, 58);
			ThreeButton.TabIndex = 18;
			ThreeButton.Text = "3";
			ThreeButton.UseVisualStyleBackColor = true;
			// 
			// TwoButton
			// 
			TwoButton.Dock = DockStyle.Fill;
			TwoButton.Location = new Point(110, 259);
			TwoButton.Name = "TwoButton";
			TwoButton.Size = new Size(101, 58);
			TwoButton.TabIndex = 17;
			TwoButton.Text = "2";
			TwoButton.UseVisualStyleBackColor = true;
			// 
			// OneButton
			// 
			OneButton.Dock = DockStyle.Fill;
			OneButton.Location = new Point(3, 259);
			OneButton.Name = "OneButton";
			OneButton.Size = new Size(101, 58);
			OneButton.TabIndex = 16;
			OneButton.Text = "1";
			OneButton.UseVisualStyleBackColor = true;
			// 
			// MinusButton
			// 
			MinusButton.Dock = DockStyle.Fill;
			MinusButton.Location = new Point(324, 195);
			MinusButton.Name = "MinusButton";
			MinusButton.Size = new Size(102, 58);
			MinusButton.TabIndex = 15;
			MinusButton.Text = "-";
			MinusButton.UseVisualStyleBackColor = true;
			// 
			// SixButton
			// 
			SixButton.Dock = DockStyle.Fill;
			SixButton.Location = new Point(217, 195);
			SixButton.Name = "SixButton";
			SixButton.Size = new Size(101, 58);
			SixButton.TabIndex = 14;
			SixButton.Text = "6";
			SixButton.UseVisualStyleBackColor = true;
			// 
			// FiveButton
			// 
			FiveButton.Dock = DockStyle.Fill;
			FiveButton.Location = new Point(110, 195);
			FiveButton.Name = "FiveButton";
			FiveButton.Size = new Size(101, 58);
			FiveButton.TabIndex = 13;
			FiveButton.Text = "5";
			FiveButton.UseVisualStyleBackColor = true;
			// 
			// FourButton
			// 
			FourButton.Dock = DockStyle.Fill;
			FourButton.Location = new Point(3, 195);
			FourButton.Name = "FourButton";
			FourButton.Size = new Size(101, 58);
			FourButton.TabIndex = 12;
			FourButton.Text = "4";
			FourButton.UseVisualStyleBackColor = true;
			// 
			// MultiplyButton
			// 
			MultiplyButton.Dock = DockStyle.Fill;
			MultiplyButton.Location = new Point(324, 131);
			MultiplyButton.Name = "MultiplyButton";
			MultiplyButton.Size = new Size(102, 58);
			MultiplyButton.TabIndex = 11;
			MultiplyButton.Text = "X";
			MultiplyButton.UseVisualStyleBackColor = true;
			// 
			// NineButton
			// 
			NineButton.Dock = DockStyle.Fill;
			NineButton.Location = new Point(217, 131);
			NineButton.Name = "NineButton";
			NineButton.Size = new Size(101, 58);
			NineButton.TabIndex = 10;
			NineButton.Text = "9";
			NineButton.UseVisualStyleBackColor = true;
			// 
			// EightButton
			// 
			EightButton.Dock = DockStyle.Fill;
			EightButton.Location = new Point(110, 131);
			EightButton.Name = "EightButton";
			EightButton.Size = new Size(101, 58);
			EightButton.TabIndex = 9;
			EightButton.Text = "8";
			EightButton.UseVisualStyleBackColor = true;
			// 
			// SevenButton
			// 
			SevenButton.Dock = DockStyle.Fill;
			SevenButton.Location = new Point(3, 131);
			SevenButton.Name = "SevenButton";
			SevenButton.Size = new Size(101, 58);
			SevenButton.TabIndex = 8;
			SevenButton.Text = "7";
			SevenButton.UseVisualStyleBackColor = true;
			// 
			// DivideButton
			// 
			DivideButton.Dock = DockStyle.Fill;
			DivideButton.Location = new Point(324, 67);
			DivideButton.Name = "DivideButton";
			DivideButton.Size = new Size(102, 58);
			DivideButton.TabIndex = 7;
			DivideButton.Text = "/";
			DivideButton.UseVisualStyleBackColor = true;
			// 
			// SquareRootButton
			// 
			SquareRootButton.Dock = DockStyle.Fill;
			SquareRootButton.Location = new Point(217, 67);
			SquareRootButton.Name = "SquareRootButton";
			SquareRootButton.Size = new Size(101, 58);
			SquareRootButton.TabIndex = 6;
			SquareRootButton.Text = "SqRt(x)";
			SquareRootButton.UseVisualStyleBackColor = true;
			// 
			// SquareButton
			// 
			SquareButton.Dock = DockStyle.Fill;
			SquareButton.Location = new Point(110, 67);
			SquareButton.Name = "SquareButton";
			SquareButton.Size = new Size(101, 58);
			SquareButton.TabIndex = 5;
			SquareButton.Text = "x^2";
			SquareButton.UseVisualStyleBackColor = true;
			// 
			// InverseButton
			// 
			InverseButton.Dock = DockStyle.Fill;
			InverseButton.Location = new Point(3, 67);
			InverseButton.Name = "InverseButton";
			InverseButton.Size = new Size(101, 58);
			InverseButton.TabIndex = 4;
			InverseButton.Text = "1/x";
			InverseButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			DeleteButton.Dock = DockStyle.Fill;
			DeleteButton.Location = new Point(324, 3);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(102, 58);
			DeleteButton.TabIndex = 3;
			DeleteButton.Text = "Delete";
			DeleteButton.UseVisualStyleBackColor = true;
			// 
			// ClearButton
			// 
			ClearButton.Dock = DockStyle.Fill;
			ClearButton.Location = new Point(217, 3);
			ClearButton.Name = "ClearButton";
			ClearButton.Size = new Size(101, 58);
			ClearButton.TabIndex = 2;
			ClearButton.Text = "C";
			ClearButton.UseVisualStyleBackColor = true;
			// 
			// ClearEntryButton
			// 
			ClearEntryButton.Dock = DockStyle.Fill;
			ClearEntryButton.Location = new Point(110, 3);
			ClearEntryButton.Name = "ClearEntryButton";
			ClearEntryButton.Size = new Size(101, 58);
			ClearEntryButton.TabIndex = 1;
			ClearEntryButton.Text = "CE";
			ClearEntryButton.UseVisualStyleBackColor = true;
			// 
			// PercentButton
			// 
			PercentButton.Dock = DockStyle.Fill;
			PercentButton.Location = new Point(3, 3);
			PercentButton.Name = "PercentButton";
			PercentButton.Size = new Size(101, 58);
			PercentButton.TabIndex = 0;
			PercentButton.Text = "%";
			PercentButton.UseVisualStyleBackColor = true;
			// 
			// CalculatorForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(462, 593);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			Name = "CalculatorForm";
			Text = "Calculator";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox2.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		public TextBox DisplayTextBox;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private TableLayoutPanel tableLayoutPanel1;
		public Button PercentButton;
		public Button EqualsButton;
		public Button DecimalButton;
		public Button ZeroButton;
		public Button NegateButton;
		public Button PlusButton;
		public Button ThreeButton;
		public Button TwoButton;
		public Button OneButton;
		public Button MinusButton;
		public Button SixButton;
		public Button FiveButton;
		public Button FourButton;
		public Button MultiplyButton;
		public Button NineButton;
		public Button EightButton;
		public Button SevenButton;
		public Button DivideButton;
		public Button SquareRootButton;
		public Button SquareButton;
		public Button InverseButton;
		public Button DeleteButton;
		public Button ClearButton;
		public Button ClearEntryButton;
	}
}