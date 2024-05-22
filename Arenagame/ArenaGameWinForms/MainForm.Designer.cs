namespace ArenaGameWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bNewGame = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ListBoxKnight = new ListBox();
            ListBoxRogue = new ListBox();
            bSecondGame = new Button();
            ListBoxAngel = new ListBox();
            ListBoxThief = new ListBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // bNewGame
            // 
            bNewGame.BackColor = Color.Lavender;
            bNewGame.FlatAppearance.BorderSize = 2;
            bNewGame.FlatStyle = FlatStyle.Flat;
            bNewGame.Location = new Point(291, 12);
            bNewGame.Name = "bNewGame";
            bNewGame.Size = new Size(176, 37);
            bNewGame.TabIndex = 0;
            bNewGame.Text = "New Game";
            bNewGame.UseVisualStyleBackColor = false;
            bNewGame.Click += bNewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(530, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ListBoxKnight
            // 
            ListBoxKnight.FormattingEnabled = true;
            ListBoxKnight.Location = new Point(29, 245);
            ListBoxKnight.Name = "ListBoxKnight";
            ListBoxKnight.Size = new Size(313, 324);
            ListBoxKnight.TabIndex = 3;
            // 
            // ListBoxRogue
            // 
            ListBoxRogue.FormattingEnabled = true;
            ListBoxRogue.Location = new Point(447, 245);
            ListBoxRogue.Name = "ListBoxRogue";
            ListBoxRogue.Size = new Size(313, 324);
            ListBoxRogue.TabIndex = 4;
            // 
            // bSecondGame
            // 
            bSecondGame.BackColor = Color.Lavender;
            bSecondGame.FlatAppearance.BorderSize = 2;
            bSecondGame.FlatStyle = FlatStyle.Flat;
            bSecondGame.Location = new Point(1081, 12);
            bSecondGame.Name = "bSecondGame";
            bSecondGame.Size = new Size(176, 37);
            bSecondGame.TabIndex = 5;
            bSecondGame.Text = "New Game";
            bSecondGame.UseVisualStyleBackColor = false;
            bSecondGame.Click += bSecondGame_Click;
            // 
            // ListBoxAngel
            // 
            ListBoxAngel.FormattingEnabled = true;
            ListBoxAngel.Location = new Point(817, 245);
            ListBoxAngel.Name = "ListBoxAngel";
            ListBoxAngel.Size = new Size(313, 324);
            ListBoxAngel.TabIndex = 6;
            // 
            // ListBoxThief
            // 
            ListBoxThief.FormattingEnabled = true;
            ListBoxThief.Location = new Point(1210, 245);
            ListBoxThief.Name = "ListBoxThief";
            ListBoxThief.Size = new Size(313, 324);
            ListBoxThief.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(894, 92);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1330, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 601);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(ListBoxThief);
            Controls.Add(ListBoxAngel);
            Controls.Add(bSecondGame);
            Controls.Add(ListBoxRogue);
            Controls.Add(ListBoxKnight);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bNewGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox ListBoxKnight;
        private ListBox ListBoxRogue;
        private Button bSecondGame;
        private ListBox ListBoxAngel;
        private ListBox ListBoxThief;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
