namespace program_yukleniyor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcbresim = new System.Windows.Forms.PictureBox();
            this.pbdurum = new System.Windows.Forms.ProgressBar();
            this.lbldurum = new System.Windows.Forms.Label();
            this.btndevam = new System.Windows.Forms.Button();
            this.tmryukleyici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbresim)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbresim
            // 
            this.pcbresim.Location = new System.Drawing.Point(172, 47);
            this.pcbresim.Name = "pcbresim";
            this.pcbresim.Size = new System.Drawing.Size(493, 90);
            this.pcbresim.TabIndex = 0;
            this.pcbresim.TabStop = false;
            // 
            // pbdurum
            // 
            this.pbdurum.Location = new System.Drawing.Point(172, 155);
            this.pbdurum.Name = "pbdurum";
            this.pbdurum.Size = new System.Drawing.Size(493, 33);
            this.pbdurum.TabIndex = 1;
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(168, 212);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(153, 20);
            this.lbldurum.TabIndex = 2;
            this.lbldurum.Text = "birazdan baslayacak";
            // 
            // btndevam
            // 
            this.btndevam.Location = new System.Drawing.Point(559, 298);
            this.btndevam.Name = "btndevam";
            this.btndevam.Size = new System.Drawing.Size(106, 52);
            this.btndevam.TabIndex = 3;
            this.btndevam.Text = "devam-->";
            this.btndevam.UseVisualStyleBackColor = true;
            this.btndevam.Click += new System.EventHandler(this.btndevam_Click);
            // 
            // tmryukleyici
            // 
            this.tmryukleyici.Interval = 1000;
            this.tmryukleyici.Tick += new System.EventHandler(this.tmryukleyici_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndevam);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.pbdurum);
            this.Controls.Add(this.pcbresim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbresim;
        private System.Windows.Forms.ProgressBar pbdurum;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Button btndevam;
        private System.Windows.Forms.Timer tmryukleyici;
    }
}

