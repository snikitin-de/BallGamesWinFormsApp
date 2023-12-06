namespace BilliardBallsWinFormsApp
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
            leftBallCountLabel = new Label();
            rightBallCountLabel = new Label();
            topBallCountLabel = new Label();
            bottomBallCountLabel = new Label();
            renderPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).BeginInit();
            SuspendLayout();
            // 
            // leftBallCountLabel
            // 
            leftBallCountLabel.Anchor = AnchorStyles.Left;
            leftBallCountLabel.AutoSize = true;
            leftBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            leftBallCountLabel.Location = new Point(24, 216);
            leftBallCountLabel.Margin = new Padding(15);
            leftBallCountLabel.Name = "leftBallCountLabel";
            leftBallCountLabel.Size = new Size(18, 19);
            leftBallCountLabel.TabIndex = 0;
            leftBallCountLabel.Text = "0";
            // 
            // rightBallCountLabel
            // 
            rightBallCountLabel.Anchor = AnchorStyles.Right;
            rightBallCountLabel.AutoSize = true;
            rightBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rightBallCountLabel.Location = new Point(758, 216);
            rightBallCountLabel.Margin = new Padding(15);
            rightBallCountLabel.Name = "rightBallCountLabel";
            rightBallCountLabel.Size = new Size(18, 19);
            rightBallCountLabel.TabIndex = 1;
            rightBallCountLabel.Text = "0";
            // 
            // topBallCountLabel
            // 
            topBallCountLabel.Anchor = AnchorStyles.Top;
            topBallCountLabel.AutoSize = true;
            topBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            topBallCountLabel.Location = new Point(391, 24);
            topBallCountLabel.Margin = new Padding(15);
            topBallCountLabel.Name = "topBallCountLabel";
            topBallCountLabel.Size = new Size(18, 19);
            topBallCountLabel.TabIndex = 2;
            topBallCountLabel.Text = "0";
            // 
            // bottomBallCountLabel
            // 
            bottomBallCountLabel.Anchor = AnchorStyles.Bottom;
            bottomBallCountLabel.AutoSize = true;
            bottomBallCountLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bottomBallCountLabel.Location = new Point(391, 407);
            bottomBallCountLabel.Margin = new Padding(15);
            bottomBallCountLabel.Name = "bottomBallCountLabel";
            bottomBallCountLabel.Size = new Size(18, 19);
            bottomBallCountLabel.TabIndex = 3;
            bottomBallCountLabel.Text = "0";
            // 
            // renderPictureBox
            // 
            renderPictureBox.Dock = DockStyle.Fill;
            renderPictureBox.Location = new Point(0, 0);
            renderPictureBox.Name = "renderPictureBox";
            renderPictureBox.Size = new Size(800, 450);
            renderPictureBox.TabIndex = 4;
            renderPictureBox.TabStop = false;
            renderPictureBox.Paint += renderPictureBox_Paint;
            renderPictureBox.Resize += renderPictureBox_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bottomBallCountLabel);
            Controls.Add(topBallCountLabel);
            Controls.Add(rightBallCountLabel);
            Controls.Add(leftBallCountLabel);
            Controls.Add(renderPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бильярдные шарики";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)renderPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftBallCountLabel;
        private Label rightBallCountLabel;
        private Label topBallCountLabel;
        private Label bottomBallCountLabel;
        private PictureBox renderPictureBox;
    }
}