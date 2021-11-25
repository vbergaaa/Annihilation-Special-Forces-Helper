using System.Drawing;
using System.Windows.Forms;
using VEntityFramework;

namespace VUserInterface
{
	partial class PlayerModsControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.veryEasyTextBox = new VUserInterface.VTextBox();
            this.vLabel1 = new VUserInterface.CommonControls.VLabel();
            this.vLabel2 = new VUserInterface.CommonControls.VLabel();
            this.EasyTextBox = new VUserInterface.VTextBox();
            this.normalTextBox = new VUserInterface.VTextBox();
            this.hardTextBox = new VUserInterface.VTextBox();
            this.veryHardTextBox = new VUserInterface.VTextBox();
            this.insaneTextBox = new VUserInterface.VTextBox();
            this.brutalTextBox = new VUserInterface.VTextBox();
            this.nightmareTextBox = new VUserInterface.VTextBox();
            this.tormentTextBox = new VUserInterface.VTextBox();
            this.hellTextBox = new VUserInterface.VTextBox();
            this.titanicTextBox = new VUserInterface.VTextBox();
            this.mythicTextBox = new VUserInterface.VTextBox();
            this.divineTextBox = new VUserInterface.VTextBox();
            this.zeroVTextBox = new VUserInterface.VTextBox();
            this.zeroXTextBox = new VUserInterface.VTextBox();
			this.ImpossibleTextBox = new VUserInterface.VTextBox();
            this.pureBlackTextBox = new VUserInterface.VTextBox();
            this.AnnihilationTextBox = new VUserInterface.VTextBox();
			this.bindingSource = new VBindingSource();
            this.SuspendLayout();
			//
			// bindingSource
			//
			this.bindingSource.DataSource = typeof(VPlayerMods);
            // 
            // veryEasyTextBox
            // 
            this.veryEasyTextBox.Caption = "Very Easy";
			this.veryEasyTextBox.DataBindings.Add("Text", bindingSource, "VeryEasy");
            this.veryEasyTextBox.Location = new System.Drawing.Point(128, 60);
            this.veryEasyTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.veryEasyTextBox.Name = "veryEasyTextBox";
            this.veryEasyTextBox.Size = new System.Drawing.Size(76, 25);
            this.veryEasyTextBox.TabIndex = 0;
			// 
			// vLabel1
			// 
			this.vLabel1.Font = new Font("Microsoft Sans Serif", 14F);
            this.vLabel1.Location = new System.Drawing.Point(80, 3);
            this.vLabel1.MaximumSize = new System.Drawing.Size(500, 100);
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(150, 22);
            this.vLabel1.Suffix = null;
            this.vLabel1.TabIndex = 1;
			this.vLabel1.Text = "Modifiers";
			this.vLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vLabel1.UseNumberSuffixes = false;
			// 
			// vLabel2
			// 
			this.vLabel2.DataBindings.Add("Text", bindingSource, "Profile.ModScore"); // easier to bind here because all the refresh binding calls are set up
            this.vLabel2.Location = new System.Drawing.Point(125, 31);
            this.vLabel2.MaximumSize = new System.Drawing.Size(500, 100);
            this.vLabel2.Name = "vLabel2";
            this.vLabel2.Size = new System.Drawing.Size(150, 22);
            this.vLabel2.Suffix = null;
            this.vLabel2.TabIndex = 2;
			this.vLabel2.Caption = "Total Score";
            this.vLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vLabel2.UseNumberSuffixes = false;
            // 
            // EasyTextBox
            // 
            this.EasyTextBox.Caption = "Easy";
			this.EasyTextBox.DataBindings.Add("Text", bindingSource, "Easy");
            this.EasyTextBox.Location = new System.Drawing.Point(128, 85);
            this.EasyTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.EasyTextBox.Name = "EasyTextBox";
            this.EasyTextBox.Size = new System.Drawing.Size(76, 25);
            this.EasyTextBox.TabIndex = 3;
            // 
            // normalTextBox
            // 
            this.normalTextBox.Caption = "Normal";
			this.normalTextBox.DataBindings.Add("Text", bindingSource, "Normal");
			this.normalTextBox.Location = new System.Drawing.Point(128, 110);
            this.normalTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.normalTextBox.Name = "normalTextBox";
            this.normalTextBox.Size = new System.Drawing.Size(76, 25);
            this.normalTextBox.TabIndex = 4;
            // 
            // hardTextBox
            // 
            this.hardTextBox.Caption = "Hard";
			this.hardTextBox.DataBindings.Add("Text", bindingSource, "Hard");
			this.hardTextBox.Location = new System.Drawing.Point(128, 135);
            this.hardTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.hardTextBox.Name = "hardTextBox";
            this.hardTextBox.Size = new System.Drawing.Size(76, 25);
            this.hardTextBox.TabIndex = 5;
            // 
            // veryHardTextBox
            // 
            this.veryHardTextBox.Caption = "Very Hard";
			this.veryHardTextBox.DataBindings.Add("Text", bindingSource, "VeryHard");
			this.veryHardTextBox.Location = new System.Drawing.Point(128, 160);
            this.veryHardTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.veryHardTextBox.Name = "veryHardTextBox";
            this.veryHardTextBox.Size = new System.Drawing.Size(76, 25);
            this.veryHardTextBox.TabIndex = 6;
            // 
            // insaneTextBox
            // 
            this.insaneTextBox.Caption = "Insane";
			this.insaneTextBox.DataBindings.Add("Text", bindingSource, "Insane");
			this.insaneTextBox.Location = new System.Drawing.Point(128, 185);
            this.insaneTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.insaneTextBox.Name = "insaneTextBox";
            this.insaneTextBox.Size = new System.Drawing.Size(76, 25);
            this.insaneTextBox.TabIndex = 7;
            // 
            // brutalTextBox
            // 
            this.brutalTextBox.Caption = "Brutal";
			this.brutalTextBox.DataBindings.Add("Text", bindingSource, "Brutal");
			this.brutalTextBox.Location = new System.Drawing.Point(128, 210);
            this.brutalTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.brutalTextBox.Name = "brutalTextBox";
            this.brutalTextBox.Size = new System.Drawing.Size(76, 25);
            this.brutalTextBox.TabIndex = 8;
            // 
            // nightmareTextBox
            // 
            this.nightmareTextBox.Caption = "Nightmare";
			this.nightmareTextBox.DataBindings.Add("Text", bindingSource, "Nightmare");
			this.nightmareTextBox.Location = new System.Drawing.Point(128, 235);
            this.nightmareTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.nightmareTextBox.Name = "nightmareTextBox";
            this.nightmareTextBox.Size = new System.Drawing.Size(76, 25);
            this.nightmareTextBox.TabIndex = 9;
            // 
            // tormentTextBox
            // 
            this.tormentTextBox.Caption = "Torment";
			this.tormentTextBox.DataBindings.Add("Text", bindingSource, "Torment");
			this.tormentTextBox.Location = new System.Drawing.Point(128, 260);
            this.tormentTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.tormentTextBox.Name = "tormentTextBox";
            this.tormentTextBox.Size = new System.Drawing.Size(76, 25);
            this.tormentTextBox.TabIndex = 11;
            // 
            // hellTextBox
            // 
            this.hellTextBox.Caption = "Hell";
			this.hellTextBox.DataBindings.Add("Text", bindingSource, "Hell");
			this.hellTextBox.Location = new System.Drawing.Point(128, 285);
            this.hellTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.hellTextBox.Name = "hellTextBox";
            this.hellTextBox.Size = new System.Drawing.Size(76, 25);
            this.hellTextBox.TabIndex = 12;
            // 
            // titanicTextBox
            // 
            this.titanicTextBox.Caption = "Titanic";
			this.titanicTextBox.DataBindings.Add("Text", bindingSource, "Titanic");
			this.titanicTextBox.Location = new System.Drawing.Point(128, 310);
            this.titanicTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.titanicTextBox.Name = "titanicTextBox";
            this.titanicTextBox.Size = new System.Drawing.Size(76, 25);
            this.titanicTextBox.TabIndex = 13;
            // 
            // mythicTextBox
            // 
            this.mythicTextBox.Caption = "Mythic";
			this.mythicTextBox.DataBindings.Add("Text", bindingSource, "Mythic");
			this.mythicTextBox.Location = new System.Drawing.Point(128, 335);
            this.mythicTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.mythicTextBox.Name = "mythicTextBox";
            this.mythicTextBox.Size = new System.Drawing.Size(76, 25);
            this.mythicTextBox.TabIndex = 14;
            // 
            // divineTextBox
            // 
            this.divineTextBox.Caption = "Divine";
			this.divineTextBox.DataBindings.Add("Text", bindingSource, "Divine");
			this.divineTextBox.Location = new System.Drawing.Point(128, 360);
            this.divineTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.divineTextBox.Name = "divineTextBox";
            this.divineTextBox.Size = new System.Drawing.Size(76, 25);
            this.divineTextBox.TabIndex = 15;
			// 
			// ImpossilbeTextBox
			// 
			this.ImpossibleTextBox.Caption = "Impossible";
			this.ImpossibleTextBox.DataBindings.Add("Text", bindingSource, "Impossible");
			this.ImpossibleTextBox.Location = new System.Drawing.Point(128, 385);
			this.ImpossibleTextBox.MaximumSize = new System.Drawing.Size(500, 100);
			this.ImpossibleTextBox.Name = "ImpossibleTextBox";
			this.ImpossibleTextBox.Size = new System.Drawing.Size(76, 25);
			this.ImpossibleTextBox.TabIndex = 16;
			this.ImpossibleTextBox.Visible = true;
			// 
			// zeroVTextBox
			// 
			this.zeroVTextBox.Caption = "Zero V";
			this.zeroVTextBox.DataBindings.Add("Text", bindingSource, "ZeroV");
			this.zeroVTextBox.Location = new System.Drawing.Point(128, 410);
			this.zeroVTextBox.MaximumSize = new System.Drawing.Size(500, 100);
			this.zeroVTextBox.Name = "zeroVTextBox";
			this.zeroVTextBox.Size = new System.Drawing.Size(76, 25);
			this.zeroVTextBox.TabIndex = 16;
			this.zeroVTextBox.Visible = true;
			// 
			// zeroXTextBox
			// 
			this.zeroXTextBox.Caption = "ZeroX";
			this.zeroXTextBox.DataBindings.Add("Text", bindingSource, "ZeroX");
			this.zeroXTextBox.Location = new System.Drawing.Point(128, 435);
            this.zeroXTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.zeroXTextBox.Name = "zeroXTextBox";
            this.zeroXTextBox.Size = new System.Drawing.Size(76, 25);
            this.zeroXTextBox.TabIndex = 17;
            this.zeroXTextBox.Visible = false;
            // 
            // pureBlackTextBox
            // 
            this.pureBlackTextBox.Caption = "Pure Black";
			this.pureBlackTextBox.DataBindings.Add("Text", bindingSource, "PureBlack");
			this.pureBlackTextBox.Location = new System.Drawing.Point(128, 460);
            this.pureBlackTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.pureBlackTextBox.Name = "pureBlackTextBox";
            this.pureBlackTextBox.Size = new System.Drawing.Size(76, 25);
            this.pureBlackTextBox.TabIndex = 18;
            this.pureBlackTextBox.Visible = false;
            // 
            // AnnihilationTextBox
            // 
            this.AnnihilationTextBox.Caption = "Annihilation";
			this.AnnihilationTextBox.DataBindings.Add("Text", bindingSource, "Annihilation");
			this.AnnihilationTextBox.Location = new System.Drawing.Point(128, 485);
            this.AnnihilationTextBox.MaximumSize = new System.Drawing.Size(500, 100);
            this.AnnihilationTextBox.Name = "AnnihilationTextBox";
            this.AnnihilationTextBox.Size = new System.Drawing.Size(76, 25);
            this.AnnihilationTextBox.TabIndex = 19;
            this.AnnihilationTextBox.Visible = false;
            // 
            // PlayerModsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnnihilationTextBox);
            this.Controls.Add(this.pureBlackTextBox);
            this.Controls.Add(this.zeroXTextBox);
            this.Controls.Add(this.zeroVTextBox);
			this.Controls.Add(this.ImpossibleTextBox);
            this.Controls.Add(this.divineTextBox);
            this.Controls.Add(this.mythicTextBox);
            this.Controls.Add(this.titanicTextBox);
            this.Controls.Add(this.hellTextBox);
            this.Controls.Add(this.tormentTextBox);
            this.Controls.Add(this.nightmareTextBox);
            this.Controls.Add(this.brutalTextBox);
            this.Controls.Add(this.insaneTextBox);
            this.Controls.Add(this.veryHardTextBox);
            this.Controls.Add(this.hardTextBox);
            this.Controls.Add(this.normalTextBox);
            this.Controls.Add(this.EasyTextBox);
            this.Controls.Add(this.vLabel2);
            this.Controls.Add(this.vLabel1);
            this.Controls.Add(this.veryEasyTextBox);
            this.Name = "PlayerModsControl";
            this.Size = new System.Drawing.Size(300, 525);
            this.ResumeLayout(false);

		}

		#endregion

		private VTextBox veryEasyTextBox;
		private CommonControls.VLabel vLabel1;
		private CommonControls.VLabel vLabel2;
		private VTextBox EasyTextBox;
		private VTextBox normalTextBox;
		private VTextBox hardTextBox;
		private VTextBox veryHardTextBox;
		private VTextBox insaneTextBox;
		private VTextBox brutalTextBox;
		private VTextBox nightmareTextBox;
		private VTextBox tormentTextBox;
		private VTextBox hellTextBox;
		private VTextBox titanicTextBox;
		private VTextBox mythicTextBox;
		private VTextBox divineTextBox;
		private VTextBox ImpossibleTextBox;
		private VTextBox zeroVTextBox;
		private VTextBox zeroXTextBox;
		private VTextBox pureBlackTextBox;
		private VTextBox AnnihilationTextBox;
		private BindingSource bindingSource;
	}
}
