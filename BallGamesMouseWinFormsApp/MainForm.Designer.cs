namespace CatchMeByMouseWinFormsApp
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
            createBallsButton = new Button();
            ballsCountHitLabel = new Label();
            gameRulesLabel = new Label();
            renderPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).BeginInit();
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.BackColor = SystemColors.ButtonShadow;
            createBallsButton.FlatAppearance.BorderSize = 0;
            createBallsButton.FlatStyle = FlatStyle.Flat;
            createBallsButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createBallsButton.ForeColor = Color.White;
            createBallsButton.Location = new Point(12, 34);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(122, 39);
            createBallsButton.TabIndex = 1;
            createBallsButton.Text = "Создать";
            createBallsButton.UseVisualStyleBackColor = false;
            createBallsButton.Click += createBallsButton_Click;
            // 
            // ballsCountHitLabel
            // 
            ballsCountHitLabel.AutoSize = true;
            ballsCountHitLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ballsCountHitLabel.ForeColor = Color.Black;
            ballsCountHitLabel.Location = new Point(155, 44);
            ballsCountHitLabel.Name = "ballsCountHitLabel";
            ballsCountHitLabel.Size = new Size(281, 19);
            ballsCountHitLabel.TabIndex = 2;
            ballsCountHitLabel.Text = "Количество пойманых мячиков: 0";
            // 
            // gameRulesLabel
            // 
            gameRulesLabel.Anchor = AnchorStyles.Top;
            gameRulesLabel.AutoSize = true;
            gameRulesLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gameRulesLabel.ForeColor = Color.Black;
            gameRulesLabel.Location = new Point(155, 9);
            gameRulesLabel.Name = "gameRulesLabel";
            gameRulesLabel.Size = new Size(491, 19);
            gameRulesLabel.TabIndex = 3;
            gameRulesLabel.Text = "Создавай мячики и лови их с помощью левой кнопки мыши";
            // 
            // renderPictureBox
            // 
            renderPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            renderPictureBox.Location = new Point(0, 110);
            renderPictureBox.Name = "renderPictureBox";
            renderPictureBox.Size = new Size(800, 340);
            renderPictureBox.TabIndex = 4;
            renderPictureBox.TabStop = false;
            renderPictureBox.Paint += renderPictureBox_Paint;
            renderPictureBox.MouseDown += renderPictureBox_MouseDown;
            renderPictureBox.Resize += renderPictureBox_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gameRulesLabel);
            Controls.Add(ballsCountHitLabel);
            Controls.Add(createBallsButton);
            Controls.Add(renderPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мячики с мышью";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBallsButton;
        private Label ballsCountHitLabel;
        private Label gameRulesLabel;
        private PictureBox renderPictureBox;
    }
}