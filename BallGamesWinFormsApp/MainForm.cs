using Timer = System.Windows.Forms.Timer;
using Common;

namespace CatchMeWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveRandomBall> moveRandomBalls = new List<MoveRandomBall>();
        private int ballsCount = 20;
        private int renderInterval = 1;
        private int borderX;
        private int borderY;

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
            stopBallsButton.BackColor = GameColors.ButtonStopBackground;
            gameRulesLabel.ForeColor = GameColors.FontColor;

            borderX = renderPictureBox.ClientSize.Width;
            borderY = renderPictureBox.ClientSize.Height;
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            moveRandomBalls = new List<MoveRandomBall>();

            for (var i = 0; i < ballsCount; i++)
            {
                var ball = new MoveRandomBall(borderX, borderY);
                moveRandomBalls.Add(ball);
                ball.Start();
            }
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {
            var caughtBallsCount = 0;

            foreach (var moveRandomBall in moveRandomBalls)
            {
                moveRandomBall.Stop();

                if (moveRandomBall.IsInsideBorders())
                {
                    caughtBallsCount++;
                }
            }

            ShowResult(caughtBallsCount);
        }

        private void renderPictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ball in moveRandomBalls)
            {
                ball.Draw(e.Graphics);
            }
        }

        private void ShowResult(int caughtBallsCount)
        {
            MessageBox.Show($"Поймано мячиков: {caughtBallsCount}", "Мячики");
        }
    }
}