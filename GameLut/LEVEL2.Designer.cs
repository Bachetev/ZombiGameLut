namespace GameLut
{
    partial class LEVEL2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEVEL2));
            this.player = new System.Windows.Forms.PictureBox();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtCoin = new System.Windows.Forms.Label();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.coinSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.Portal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portal)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(494, 274);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtAmmo.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtAmmo.Location = new System.Drawing.Point(12, 33);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(214, 24);
            this.txtAmmo.TabIndex = 13;
            this.txtAmmo.Text = "Патроны: 0";
            // 
            // txtCoin
            // 
            this.txtCoin.AutoSize = true;
            this.txtCoin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCoin.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtCoin.Location = new System.Drawing.Point(415, 33);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(190, 24);
            this.txtCoin.TabIndex = 12;
            this.txtCoin.Text = "Монеты: 0";
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblLevel1.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLevel1.Location = new System.Drawing.Point(385, 0);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(246, 29);
            this.lblLevel1.TabIndex = 11;
            this.lblLevel1.Text = "УРОВЕНЬ 2";
            this.lblLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(801, 33);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(171, 24);
            this.healthBar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(770, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Здоровье";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtScore.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtScore.Location = new System.Drawing.Point(12, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(238, 24);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Убийства: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MineTimerEvent);
            // 
            // coinSpawnTimer
            // 
            this.coinSpawnTimer.Enabled = true;
            this.coinSpawnTimer.Interval = 10000;
            this.coinSpawnTimer.Tick += new System.EventHandler(this.coinSpawnTimer_Tick);
            // 
            // Portal
            // 
            this.Portal.Image = ((System.Drawing.Image)(resources.GetObject("Portal.Image")));
            this.Portal.Location = new System.Drawing.Point(836, 199);
            this.Portal.Name = "Portal";
            this.Portal.Size = new System.Drawing.Size(136, 228);
            this.Portal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Portal.TabIndex = 14;
            this.Portal.TabStop = false;
            // 
            // LEVEL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Portal);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.txtCoin);
            this.Controls.Add(this.lblLevel1);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LEVEL2";
            this.Text = "LEVEL2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtCoin;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer coinSpawnTimer;
        private System.Windows.Forms.PictureBox Portal;
    }
}