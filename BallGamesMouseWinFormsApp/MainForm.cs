using Common;
using Timer = System.Windows.Forms.Timer;

namespace CatchMeByMouseWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveRandomPointBall> moveRandomPointBalls = new List<MoveRandomPointBall>();
        private int ballsCount = 20;
        private int ballsCountHit = 0;
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
            createBallsButton.BackColor = GameColors.ButtonStartBackground;
            gameRulesLabel.ForeColor = GameColors.FontColor;
            ballsCountHitLabel.ForeColor = GameColors.FontColor;
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            ballsCountHitLabel.Text = "Количество пойманых мячиков: 0";
            ballsCountHit = 0;

            moveRandomPointBalls = new List<MoveRandomPointBall>();
            var borderX = renderPictureBox.Width;
            var borderY = renderPictureBox.Height;

            for (var i = 0; i < ballsCount; i++)
            {
                var ball = new MoveRandomPointBall(borderX, borderY);
                moveRandomPointBalls.Add(ball);
                ball.Start();
            }
        }

        private void renderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ball in moveRandomPointBalls)
            {
                ball.Draw(e.Graphics);
            }
        }

        private void renderPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < moveRandomPointBalls.Count; i++)
            {
                if (moveRandomPointBalls[i].IsMouseCaught(e.X, e.Y))
                {
                    moveRandomPointBalls[i].Stop();
                    ballsCountHit++;
                    ballsCountHitLabel.Text = $"Количество пойманых мячиков: {ballsCountHit}";
                }
            }
        }

        private void renderPictureBox_Resize(object sender, EventArgs e)
        {
            var borderX = renderPictureBox.Width;
            var borderY = renderPictureBox.Height;

            foreach (var ball in moveRandomPointBalls)
            {
                ball.UpdateBorders(borderX, borderY);
            }
        }
    }
}