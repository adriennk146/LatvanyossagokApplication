namespace LatvanyossagokApplication
{
    partial class latvanyossagokApp
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
            this.ujvarosGB = new System.Windows.Forms.GroupBox();
            this.varosTB = new System.Windows.Forms.TextBox();
            this.lakossagNUD = new System.Windows.Forms.NumericUpDown();
            this.varosNevLbl = new System.Windows.Forms.Label();
            this.lakossagLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ujvarosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ujvarosGB
            // 
            this.ujvarosGB.Controls.Add(this.button1);
            this.ujvarosGB.Controls.Add(this.lakossagLbl);
            this.ujvarosGB.Controls.Add(this.varosNevLbl);
            this.ujvarosGB.Controls.Add(this.lakossagNUD);
            this.ujvarosGB.Controls.Add(this.varosTB);
            this.ujvarosGB.Location = new System.Drawing.Point(14, 14);
            this.ujvarosGB.Name = "ujvarosGB";
            this.ujvarosGB.Size = new System.Drawing.Size(280, 172);
            this.ujvarosGB.TabIndex = 0;
            this.ujvarosGB.TabStop = false;
            this.ujvarosGB.Text = "Új város:";
            // 
            // varosTB
            // 
            this.varosTB.Location = new System.Drawing.Point(82, 37);
            this.varosTB.Name = "varosTB";
            this.varosTB.Size = new System.Drawing.Size(184, 20);
            this.varosTB.TabIndex = 0;
            // 
            // lakossagNUD
            // 
            this.lakossagNUD.Location = new System.Drawing.Point(119, 75);
            this.lakossagNUD.Name = "lakossagNUD";
            this.lakossagNUD.Size = new System.Drawing.Size(146, 20);
            this.lakossagNUD.TabIndex = 1;
            // 
            // varosNevLbl
            // 
            this.varosNevLbl.AutoSize = true;
            this.varosNevLbl.Location = new System.Drawing.Point(16, 37);
            this.varosNevLbl.Name = "varosNevLbl";
            this.varosNevLbl.Size = new System.Drawing.Size(64, 13);
            this.varosNevLbl.TabIndex = 2;
            this.varosNevLbl.Text = "Város neve:";
            // 
            // lakossagLbl
            // 
            this.lakossagLbl.AutoSize = true;
            this.lakossagLbl.Location = new System.Drawing.Point(16, 82);
            this.lakossagLbl.Name = "lakossagLbl";
            this.lakossagLbl.Size = new System.Drawing.Size(84, 13);
            this.lakossagLbl.TabIndex = 3;
            this.lakossagLbl.Text = "Lakosok száma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // latvanyossagokApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ujvarosGB);
            this.Name = "latvanyossagokApp";
            this.Text = "Látványosságok Applikáció";
            this.ujvarosGB.ResumeLayout(false);
            this.ujvarosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ujvarosGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lakossagLbl;
        private System.Windows.Forms.Label varosNevLbl;
        private System.Windows.Forms.NumericUpDown lakossagNUD;
        private System.Windows.Forms.TextBox varosTB;
    }
}

