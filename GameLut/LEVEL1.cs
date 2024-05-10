using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLut
{
    public partial class LEVEL1 : Form
    {
        List<PictureBox> zombiesList = new List<PictureBox>();
        private const int MIN_DISTANCE = 100;
        private const int MIN_DISTANCE_BETWEEN_ZOMBIES = 100;
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 3;
        Random randNum = new Random();
        int score;
        int coin = 0;
        private Timer coinSpawnTimer;
        static int totalCoins = 0;
        int totalKills = 0;
        int totalAmmo = 10;
        int zombieKills = 0;
        bool isPaused = false;

        public LEVEL1()
        {
            InitializeComponent();
            RestartGame();
            Portal.BackColor = Color.Transparent;
            player.BackColor = Color.Transparent;
        }

        private bool IsPortalVisible()
        {
            return coin >= 5 && zombieKills >= 15;
        }
        private bool IntersectsWithEdges(PictureBox player, PictureBox zombie)
        {
            return (player.Left <= zombie.Right && player.Right >= zombie.Left &&
                    player.Top <= zombie.Bottom && player.Bottom >= zombie.Top);
        }
        private void MineTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth <= 1 && !gameOver)
            {
                totalKills = score;
                totalAmmo = ammo;

                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();

                DialogResult result = MessageBox.Show("Вы проиграли! Хотите перезапустить уровень?", "Поражение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RestartGame();
                    score = 0;
                    ammo = 10;
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
            }

            txtAmmo.Text = "Патроны: " + ammo;
            txtScore.Text = "Убийства: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 65)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (IntersectsWithEdges(player, (PictureBox)x))
                        {
                            playerHealth -= 1;
                        }

                        if (x.Left > player.Left)
                        {
                            x.Left += zombieSpeed;
                        }
                        else if (x.Left < player.Left)
                        {
                            x.Left -= zombieSpeed;
                        }
                        if (x.Top > player.Top)
                        {
                            x.Top += zombieSpeed;
                        }
                        else if (x.Top < player.Top)
                        {
                            x.Top -= zombieSpeed;
                        }
                    }
                    else
                    {
                        foreach (Control y in this.Controls)
                        {
                            if (y is PictureBox && (string)y.Tag == "zombie" && y != x)
                            {
                                if (x.Bounds.IntersectsWith(y.Bounds))
                                {
                                    if (x.Left < y.Left)
                                    {
                                        x.Left -= zombieSpeed;
                                    }
                                    else
                                    {
                                        x.Left += zombieSpeed;
                                    }
                                    if (x.Top < y.Top)
                                    {
                                        x.Top -= zombieSpeed;
                                    }
                                    else
                                    {
                                        x.Top += zombieSpeed;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        coin += 1;
                        totalCoins += 1;
                        txtCoin.Text = "Монеты: " + totalCoins;

                        if (coin == 15)
                        {
                            coinSpawnTimer.Start();
                        }
                    }
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            zombieKills++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }

            if (IsPortalVisible())
            {
                Portal.Visible = true;

                if (player.Bounds.IntersectsWith(Portal.Bounds))
                {
                    GameTimer.Stop();
                    DialogResult result = MessageBox.Show("Вы прошли уровень! Хотите перейти на следующий уровень?", "Победа", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        LEVEL2 level2 = new LEVEL2();
                        level2.Show();
                        this.Hide();
                    }
                    else
                    {
                        GameTimer.Start();
                    }
                }
            }
            else
            {
                Portal.Visible = false;
            }
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                ShowPauseMenu();
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);


                if (ammo < 2)
                {
                    DropAmmo();
                }

            }
        }

        private void coinSpawnTimer_Tick(object sender, EventArgs e)
        {
            if (coin >= 3)
            {

                for (int i = 0; i < 2; i++)
                {
                    MakeCoins();
                }
            }
        }

        private int CountUnCollectedCoins()
        {
            int unCollectedCoins = 0;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    unCollectedCoins++;
                }
            }

            return unCollectedCoins;
        }

        private void MakeCoins()
        {

            if (CountUnCollectedCoins() >= 10)
            {
                return;
            }

            PictureBox coin = new PictureBox();
            coin.Tag = "coin";
            coin.Image = Properties.Resources.coin;

            bool tooClose;

            do
            {
                coin.Left = randNum.Next(0, this.ClientSize.Width - coin.Width);
                coin.Top = randNum.Next(65, this.ClientSize.Height - coin.Height);

                tooClose = false;


                foreach (Control existingCoin in this.Controls)
                {
                    if (existingCoin is PictureBox && (string)existingCoin.Tag == "coin")
                    {
                        if (Math.Abs(existingCoin.Left - coin.Left) < 50 && Math.Abs(existingCoin.Top - coin.Top) < 50)
                        {
                            tooClose = true;
                            break;
                        }
                    }
                }
            } while (tooClose);

            coin.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(coin);
            coin.BringToFront();
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            bool tooCloseToPlayer;
            bool tooCloseToZombie;

            do
            {
                tooCloseToPlayer = false;
                tooCloseToZombie = false;

                zombie.Left = randNum.Next(0, 1000);
                zombie.Top = randNum.Next(0, 700);

                if (Math.Abs(zombie.Left - player.Left) < MIN_DISTANCE &&
                    Math.Abs(zombie.Top - player.Top) < MIN_DISTANCE)
                {
                    tooCloseToPlayer = true;
                }
                foreach (PictureBox existingZombie in zombiesList)
                {
                    if (Math.Abs(zombie.Left - existingZombie.Left) < MIN_DISTANCE_BETWEEN_ZOMBIES &&
                        Math.Abs(zombie.Top - existingZombie.Top) < MIN_DISTANCE_BETWEEN_ZOMBIES)
                    {
                        tooCloseToZombie = true;
                        break;
                    }
                }

            } while (tooCloseToPlayer || tooCloseToZombie);

            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            zombie.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }

        private void ShowPauseMenu()
        {
            GameTimer.Stop();
            DialogResult result = MessageBox.Show("Игра на паузе, выйти в главное меню?", "Пауза", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                RestartGame();
            }
            else
            {

                GameTimer.Start();
            }
        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach (PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "coin")
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }

            zombiesList.Clear();

            for (int i = 0; i < 4; i++)
            {
                MakeZombies();
            }

            for (int i = 0; i < 5; i++)
            {
                MakeCoins();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;
            coin = 0;

            GameTimer.Start();

            coin = 0;
            txtCoin.Text = "Монеты: " + totalCoins;
            score = totalKills;
            ammo = totalAmmo;
            zombieKills = 0;
        }
    }
}

