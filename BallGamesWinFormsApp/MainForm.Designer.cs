namespace CatchMeWinFormsApp
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
            stopBallsButton = new Button();
            gameRulesLabel = new Label();
            renderPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).BeginInit();
            SuspendLayout();
            // 
            // createBallsButton
            // 
            createBallsButton.BackColor = SystemColors.ButtonShadow;
            createBallsButton.FlatStyle = FlatStyle.Flat;
            createBallsButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createBallsButton.ForeColor = Color.White;
            createBallsButton.Location = new Point(12, 60);
            createBallsButton.Name = "createBallsButton";
            createBallsButton.Size = new Size(122, 39);
            createBallsButton.TabIndex = 0;
            createBallsButton.Text = "Создать";
            createBallsButton.UseVisualStyleBackColor = false;
            createBallsButton.Click += createBallsButton_Click;
            // 
            // stopBallsButton
            // 
            stopBallsButton.BackColor = SystemColors.ButtonShadow;
            stopBallsButton.FlatStyle = FlatStyle.Flat;
            stopBallsButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stopBallsButton.ForeColor = Color.White;
            stopBallsButton.Location = new Point(140, 60);
            stopBallsButton.Name = "stopBallsButton";
            stopBallsButton.Size = new Size(122, 39);
            stopBallsButton.TabIndex = 1;
            stopBallsButton.Text = "Остановить";
            stopBallsButton.UseVisualStyleBackColor = false;
            stopBallsButton.Click += stopBallsButton_Click;
            // 
            // gameRulesLabel
            // 
            gameRulesLabel.Anchor = AnchorStyles.Top;
            gameRulesLabel.AutoSize = true;
            gameRulesLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gameRulesLabel.ForeColor = Color.Black;
            gameRulesLabel.Location = new Point(150, 22);
            gameRulesLabel.Name = "gameRulesLabel";
            gameRulesLabel.Size = new Size(501, 19);
            gameRulesLabel.TabIndex = 4;
            gameRulesLabel.Text = "Создавай мячики и лови их с помощью кнопки \"Остановить\"";
            // 
            // renderPictureBox
            // 
            renderPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            renderPictureBox.Location = new Point(0, 125);
            renderPictureBox.Name = "renderPictureBox";
            renderPictureBox.Size = new Size(800, 326);
            renderPictureBox.TabIndex = 5;
            renderPictureBox.TabStop = false;
            renderPictureBox.Paint += renderPictureBox_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(gameRulesLabel);
            Controls.Add(stopBallsButton);
            Controls.Add(createBallsButton);
            Controls.Add(renderPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мячики";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBallsButton;
        private Button stopBallsButton;
        private Label gameRulesLabel;
        private PictureBox renderPictureBox;
    }
}