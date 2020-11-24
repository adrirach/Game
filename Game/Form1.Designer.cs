namespace Game
{
    partial class Form1
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
            this.Playgame = new System.Windows.Forms.Button();
            this.GameStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playgame
            // 
            this.Playgame.BackColor = System.Drawing.Color.Black;
            this.Playgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Playgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Playgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playgame.ForeColor = System.Drawing.Color.White;
            this.Playgame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Playgame.Location = new System.Drawing.Point(335, 102);
            this.Playgame.Name = "Playgame";
            this.Playgame.Size = new System.Drawing.Size(168, 72);
            this.Playgame.TabIndex = 0;
            this.Playgame.Text = "Play Game";
            this.Playgame.UseVisualStyleBackColor = false;
            this.Playgame.Click += new System.EventHandler(this.PlayButton_Click);
            this.Playgame.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Remove);
            // 
            // GameStart
            // 
            this.GameStart.AutoSize = true;
            this.GameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStart.ForeColor = System.Drawing.Color.White;
            this.GameStart.Location = new System.Drawing.Point(139, 304);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(354, 37);
            this.GameStart.TabIndex = 1;
            this.GameStart.Text = "The Game Starts In ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(596, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(609, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.Playgame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playgame;
        private System.Windows.Forms.Label GameStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

