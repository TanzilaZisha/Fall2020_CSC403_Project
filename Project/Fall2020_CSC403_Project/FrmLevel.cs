using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Media;
using System.Timers;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
        System.Timers.Timer timer;
        int h, m, s;
        SoundPlayer simplesound;
        public string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\", "") + "\\sound\\music.wav";

        public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

            Game.player = player;
            simplesound = new SoundPlayer(path);
            simplesound.Play();

            timeBegin = DateTime.Now;
            timer = new System.Timers.Timer(60.666);
            timer.Interval = 1000;//1s
            timer.Elapsed += onTimeEvent;
            timer.Start();
        }
        public void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                lblInGameTime.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      //TimeSpan span = DateTime.Now - timeBegin;
      //string time = span.ToString(@"hh\:mm\:ss");
      //lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket) && enemyPoisonPacket.Health > 0) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto) && enemyCheeto.Health > 0) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid) && bossKoolaid.Health > 0) {
        Fight(bossKoolaid);
      }


      if (enemyPoisonPacket.Health <= 0){
                picEnemyPoisonPacket.Visible = false;
       }
      if (enemyCheeto.Health <= 0) {
                picEnemyCheeto.Visible = false;
       }
      if (bossKoolaid.Health <= 0) {
                picBossKoolAid.Visible = false;
       }
      if(player.Health <= 0) {
                picPlayer.Visible = false;
       }

       else  // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

                case Keys.Escape:
                    {
                        /*this.Hide();*/
                        ExitScreen exitScreen = new ExitScreen();
                        exitScreen.Show();
                    }
                    break;

                default:
          player.ResetMoveSpeed();
          break;
      }
    }

        private void FrmLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            simplesound.Stop();
            timer.Stop();
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            simplesound.Stop();
            timer.Stop();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            simplesound.Play();
            timer.Start();
        }

        private void lblInGameTime_Click(object sender, EventArgs e) {

    }


        private void picPlayer_click(object sender, EventArgs e)
        {
            player.GoUp();
            
        }

    }
}
