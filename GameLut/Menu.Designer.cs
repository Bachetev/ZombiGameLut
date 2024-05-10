namespace GameLut
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLevels = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundMenu = new System.Windows.Forms.PictureBox();
            this.btnControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(500, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(263, 67);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "ВЫХОД";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLevels
            // 
            this.btnLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevels.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLevels.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLevels.Location = new System.Drawing.Point(500, 154);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(263, 63);
            this.btnLevels.TabIndex = 13;
            this.btnLevels.Text = "УРОВНИ";
            this.btnLevels.UseVisualStyleBackColor = false;
            this.btnLevels.Click += new System.EventHandler(this.btnLevels_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPlay.Location = new System.Drawing.Point(500, 73);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(263, 63);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "ИГРАТЬ";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "BakhmetLut Studio";
            // 
            // backgroundMenu
            // 
            this.backgroundMenu.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.backgroundMenu.Image = ((System.Drawing.Image)(resources.GetObject("backgroundMenu.Image")));
            this.backgroundMenu.Location = new System.Drawing.Point(-5, -39);
            this.backgroundMenu.Name = "backgroundMenu";
            this.backgroundMenu.Size = new System.Drawing.Size(783, 477);
            this.backgroundMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backgroundMenu.TabIndex = 10;
            this.backgroundMenu.TabStop = false;
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnControl.ForeColor = System.Drawing.Color.IndianRed;
            this.btnControl.Location = new System.Drawing.Point(500, 237);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(263, 67);
            this.btnControl.TabIndex = 16;
            this.btnControl.Text = "УПРАВЛЕНИЕ";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 403);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLevels);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroundMenu);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLevels;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backgroundMenu;
        private System.Windows.Forms.Button btnControl;
    }
}

