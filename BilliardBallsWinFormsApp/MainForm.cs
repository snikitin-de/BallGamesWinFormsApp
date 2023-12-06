using Common;
using Timer = System.Windows.Forms.Timer;

namespace BilliardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<BilliardBall> billiardBalls = new List<BilliardBall>();
        private int ballsCount = 20;
        private int renderInterval = 1;

        public MainForm()
        {
            InitializeComponent();

            var renderTimer = new Timer();
            renderTimer.Interval = renderInterval;
            renderTimer.Enabled = true;
            renderTimer.Tick += (s, o) => { renderPictureBox.Refresh(); };
        }

        // Включение двойной буферизации для всех элементов управления
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;
                return createParams;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            renderPictureBox.BackColor = GameColors.GameBackground;
            leftBallCountLabel.BackColor = GameColors.GameBackground;
            rightBallCountLabel.BackColor = GameColors.GameBackground;
            topBallCountLabel.BackColor = GameColors.GameBackground;
            bottomBallCountLabel.BackColor = GameColors.GameBackground;
            leftBallCountLabel.ForeColor = GameColors.FontColor;
            rightBallCountLabel.ForeColor = GameColors.FontColor;
            topBallCountLabel.ForeColor = GameColors.FontColor;
            bottomBallCountLabel.ForeColor = GameColors.FontColor;

            var borderX = renderPictureBox.Width;
            var borderY = renderPictureBox.Height;

            for (var i = 0; i < ballsCount; i++)
            {
                var ball = new BilliardBall(borderX, borderY);
                billiardBalls.Add(ball);
                ball.OnHitted += Ball_OnHitted;
                ball.Start();
            }
        }

        private void Ball_OnHitted(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftBallCountLabel.Text = (Convert.ToInt32(leftBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightBallCountLabel.Text = (Convert.ToInt32(rightBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topBallCountLabel.Text = (Convert.ToInt32(topBallCountLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomBallCountLabel.Text = (Convert.ToInt32(bottomBallCountLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void renderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ball in billiardBalls)
            {
                ball.Draw(e.Graphics);
            }
        }

        private void renderPictureBox_Resize(object sender, EventArgs e)
        {
            var borderX = renderPictureBox.Width;
            var borderY = renderPictureBox.Height;

            foreach (var ball in billiardBalls)
            {
                ball.UpdateBorders(borderX, borderY);
            }
        }
    }
}