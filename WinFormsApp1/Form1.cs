using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static WinFormsApp1.PlayerView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private PlayerController _playerController;
        private EnemyController _enemyController;
        private BulletController _bulletController;
        private FieldController _fieldController;
        private bool isUp;
        private bool isDown;
        private bool isLeft;
        private bool isRight;
        public Form1()
        {
            InitializeComponent();
            _playerController = new PlayerController(this);
            _enemyController = new EnemyController(this);
            _bulletController = new BulletController();
            _fieldController = new FieldController();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            label2.Text = "SCORE: 0";

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            _playerController.MouseMove(sender, e);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                isUp = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                isRight = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                isDown = true;
            }
            else if (e.KeyCode == Keys.A)
            {
                isLeft = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                isUp = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                isRight = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                isDown = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                isLeft = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isUp)
            {
                _playerController.Location(0, -5);
            }
            if (isDown)
            {
                _playerController.Location(0, 5);
            }
            if (isLeft)
            {
                _playerController.Location(-5, 0);
            }
            if (isRight)
            {
                _playerController.Location(5, 0);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _fieldController.Paint(CreateGraphics(), ClientSize);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //_bulletController.MouseLocation(sender, e);
                _bulletController.PlayerLocation(_playerController.LocationPlayer);
                _bulletController.TargetMove(_playerController.LocationPlayer, e.Location, this);
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _bulletController.Move(this);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            int i = 0;
            if (!_enemyController.Shoot(_bulletController.PictureBullet, this))
                _enemyController.Move(this);
            else
            {
                _enemyController.Dead(_bulletController.PictureBullet, this);
                _bulletController.Dead(this);
                label2.Text = "SCORE: " + _enemyController.Pts;
            }
        }
    }
}








  