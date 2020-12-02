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
            this.ujVarosBtn = new System.Windows.Forms.Button();
            this.lakossagLbl = new System.Windows.Forms.Label();
            this.varosNevLbl = new System.Windows.Forms.Label();
            this.lakossagNUD = new System.Windows.Forms.NumericUpDown();
            this.varosTB = new System.Windows.Forms.TextBox();
            this.latvanyossagGB = new System.Windows.Forms.GroupBox();
            this.varosCBLbl = new System.Windows.Forms.Label();
            this.varosokCOB = new System.Windows.Forms.ComboBox();
            this.leirasTB = new System.Windows.Forms.TextBox();
            this.leirasLbl = new System.Windows.Forms.Label();
            this.latvanyossagMentesBtn = new System.Windows.Forms.Button();
            this.arLbl = new System.Windows.Forms.Label();
            this.latvanyossagNevLbl = new System.Windows.Forms.Label();
            this.arNUD = new System.Windows.Forms.NumericUpDown();
            this.latvanyossagNevTB = new System.Windows.Forms.TextBox();
            this.varosokLstBx = new System.Windows.Forms.ListBox();
            this.torlesBtn = new System.Windows.Forms.Button();
            this.modositasBtn = new System.Windows.Forms.Button();
            this.mMentesBtn = new System.Windows.Forms.Button();
            this.latvanyossagokLstBx = new System.Windows.Forms.ListBox();
            this.ujvarosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagNUD)).BeginInit();
            this.latvanyossagGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ujvarosGB
            // 
            this.ujvarosGB.Controls.Add(this.mMentesBtn);
            this.ujvarosGB.Controls.Add(this.ujVarosBtn);
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
            // ujVarosBtn
            // 
            this.ujVarosBtn.Location = new System.Drawing.Point(82, 127);
            this.ujVarosBtn.Name = "ujVarosBtn";
            this.ujVarosBtn.Size = new System.Drawing.Size(100, 28);
            this.ujVarosBtn.TabIndex = 4;
            this.ujVarosBtn.Text = "Mentés";
            this.ujVarosBtn.UseVisualStyleBackColor = true;
            this.ujVarosBtn.Click += new System.EventHandler(this.ujVarosBtn_Click);
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
            // varosNevLbl
            // 
            this.varosNevLbl.AutoSize = true;
            this.varosNevLbl.Location = new System.Drawing.Point(16, 37);
            this.varosNevLbl.Name = "varosNevLbl";
            this.varosNevLbl.Size = new System.Drawing.Size(64, 13);
            this.varosNevLbl.TabIndex = 2;
            this.varosNevLbl.Text = "Város neve:";
            // 
            // lakossagNUD
            // 
            this.lakossagNUD.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lakossagNUD.Location = new System.Drawing.Point(119, 75);
            this.lakossagNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lakossagNUD.Name = "lakossagNUD";
            this.lakossagNUD.Size = new System.Drawing.Size(146, 20);
            this.lakossagNUD.TabIndex = 1;
            // 
            // varosTB
            // 
            this.varosTB.Location = new System.Drawing.Point(82, 37);
            this.varosTB.Name = "varosTB";
            this.varosTB.Size = new System.Drawing.Size(184, 20);
            this.varosTB.TabIndex = 0;
            // 
            // latvanyossagGB
            // 
            this.latvanyossagGB.Controls.Add(this.varosCBLbl);
            this.latvanyossagGB.Controls.Add(this.varosokCOB);
            this.latvanyossagGB.Controls.Add(this.leirasTB);
            this.latvanyossagGB.Controls.Add(this.leirasLbl);
            this.latvanyossagGB.Controls.Add(this.latvanyossagMentesBtn);
            this.latvanyossagGB.Controls.Add(this.arLbl);
            this.latvanyossagGB.Controls.Add(this.latvanyossagNevLbl);
            this.latvanyossagGB.Controls.Add(this.arNUD);
            this.latvanyossagGB.Controls.Add(this.latvanyossagNevTB);
            this.latvanyossagGB.Location = new System.Drawing.Point(14, 192);
            this.latvanyossagGB.Name = "latvanyossagGB";
            this.latvanyossagGB.Size = new System.Drawing.Size(280, 254);
            this.latvanyossagGB.TabIndex = 5;
            this.latvanyossagGB.TabStop = false;
            this.latvanyossagGB.Text = "Új látványosság:";
            // 
            // varosCBLbl
            // 
            this.varosCBLbl.AutoSize = true;
            this.varosCBLbl.Location = new System.Drawing.Point(16, 172);
            this.varosCBLbl.Name = "varosCBLbl";
            this.varosCBLbl.Size = new System.Drawing.Size(37, 13);
            this.varosCBLbl.TabIndex = 8;
            this.varosCBLbl.Text = "Város:";
            // 
            // varosokCOB
            // 
            this.varosokCOB.FormattingEnabled = true;
            this.varosokCOB.Location = new System.Drawing.Point(83, 169);
            this.varosokCOB.Name = "varosokCOB";
            this.varosokCOB.Size = new System.Drawing.Size(183, 21);
            this.varosokCOB.TabIndex = 7;
            // 
            // leirasTB
            // 
            this.leirasTB.Location = new System.Drawing.Point(82, 74);
            this.leirasTB.Multiline = true;
            this.leirasTB.Name = "leirasTB";
            this.leirasTB.Size = new System.Drawing.Size(184, 49);
            this.leirasTB.TabIndex = 6;
            // 
            // leirasLbl
            // 
            this.leirasLbl.AutoSize = true;
            this.leirasLbl.Location = new System.Drawing.Point(17, 77);
            this.leirasLbl.Name = "leirasLbl";
            this.leirasLbl.Size = new System.Drawing.Size(40, 13);
            this.leirasLbl.TabIndex = 5;
            this.leirasLbl.Text = "Leírás:";
            // 
            // latvanyossagMentesBtn
            // 
            this.latvanyossagMentesBtn.Location = new System.Drawing.Point(73, 209);
            this.latvanyossagMentesBtn.Name = "latvanyossagMentesBtn";
            this.latvanyossagMentesBtn.Size = new System.Drawing.Size(100, 28);
            this.latvanyossagMentesBtn.TabIndex = 4;
            this.latvanyossagMentesBtn.Text = "Mentés";
            this.latvanyossagMentesBtn.UseVisualStyleBackColor = true;
            this.latvanyossagMentesBtn.Click += new System.EventHandler(this.latvanyossagMentesBtn_Click);
            // 
            // arLbl
            // 
            this.arLbl.AutoSize = true;
            this.arLbl.Location = new System.Drawing.Point(16, 134);
            this.arLbl.Name = "arLbl";
            this.arLbl.Size = new System.Drawing.Size(38, 13);
            this.arLbl.TabIndex = 3;
            this.arLbl.Text = "Ár (Ft):";
            // 
            // latvanyossagNevLbl
            // 
            this.latvanyossagNevLbl.AutoSize = true;
            this.latvanyossagNevLbl.Location = new System.Drawing.Point(16, 37);
            this.latvanyossagNevLbl.Name = "latvanyossagNevLbl";
            this.latvanyossagNevLbl.Size = new System.Drawing.Size(30, 13);
            this.latvanyossagNevLbl.TabIndex = 2;
            this.latvanyossagNevLbl.Text = "Név:";
            // 
            // arNUD
            // 
            this.arNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.arNUD.Location = new System.Drawing.Point(120, 132);
            this.arNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.arNUD.Name = "arNUD";
            this.arNUD.Size = new System.Drawing.Size(146, 20);
            this.arNUD.TabIndex = 1;
            // 
            // latvanyossagNevTB
            // 
            this.latvanyossagNevTB.Location = new System.Drawing.Point(82, 37);
            this.latvanyossagNevTB.Name = "latvanyossagNevTB";
            this.latvanyossagNevTB.Size = new System.Drawing.Size(184, 20);
            this.latvanyossagNevTB.TabIndex = 0;
            // 
            // varosokLstBx
            // 
            this.varosokLstBx.FormattingEnabled = true;
            this.varosokLstBx.Location = new System.Drawing.Point(314, 20);
            this.varosokLstBx.Name = "varosokLstBx";
            this.varosokLstBx.Size = new System.Drawing.Size(234, 160);
            this.varosokLstBx.TabIndex = 6;
            this.varosokLstBx.SelectedIndexChanged += new System.EventHandler(this.varosokLstBx_SelectedIndexChanged);
            // 
            // torlesBtn
            // 
            this.torlesBtn.Location = new System.Drawing.Point(554, 152);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(100, 28);
            this.torlesBtn.TabIndex = 5;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Visible = false;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // modositasBtn
            // 
            this.modositasBtn.Location = new System.Drawing.Point(554, 118);
            this.modositasBtn.Name = "modositasBtn";
            this.modositasBtn.Size = new System.Drawing.Size(100, 28);
            this.modositasBtn.TabIndex = 7;
            this.modositasBtn.Text = "Módosítás";
            this.modositasBtn.UseVisualStyleBackColor = true;
            this.modositasBtn.Visible = false;
            this.modositasBtn.Click += new System.EventHandler(this.modositasBtn_Click);
            // 
            // mMentesBtn
            // 
            this.mMentesBtn.Location = new System.Drawing.Point(73, 127);
            this.mMentesBtn.Name = "mMentesBtn";
            this.mMentesBtn.Size = new System.Drawing.Size(136, 28);
            this.mMentesBtn.TabIndex = 5;
            this.mMentesBtn.Text = "Módosítások mentése";
            this.mMentesBtn.UseVisualStyleBackColor = true;
            this.mMentesBtn.Visible = false;
            this.mMentesBtn.Click += new System.EventHandler(this.mMentesBtn_Click);
            // 
            // latvanyossagokLstBx
            // 
            this.latvanyossagokLstBx.FormattingEnabled = true;
            this.latvanyossagokLstBx.Location = new System.Drawing.Point(314, 201);
            this.latvanyossagokLstBx.Name = "latvanyossagokLstBx";
            this.latvanyossagokLstBx.Size = new System.Drawing.Size(234, 160);
            this.latvanyossagokLstBx.TabIndex = 8;
            // 
            // latvanyossagokApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.latvanyossagokLstBx);
            this.Controls.Add(this.modositasBtn);
            this.Controls.Add(this.torlesBtn);
            this.Controls.Add(this.varosokLstBx);
            this.Controls.Add(this.latvanyossagGB);
            this.Controls.Add(this.ujvarosGB);
            this.Name = "latvanyossagokApp";
            this.Text = "Látványosságok Applikáció";
            this.ujvarosGB.ResumeLayout(false);
            this.ujvarosGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakossagNUD)).EndInit();
            this.latvanyossagGB.ResumeLayout(false);
            this.latvanyossagGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ujvarosGB;
        private System.Windows.Forms.Button ujVarosBtn;
        private System.Windows.Forms.Label lakossagLbl;
        private System.Windows.Forms.Label varosNevLbl;
        private System.Windows.Forms.NumericUpDown lakossagNUD;
        private System.Windows.Forms.TextBox varosTB;
        private System.Windows.Forms.GroupBox latvanyossagGB;
        private System.Windows.Forms.Button latvanyossagMentesBtn;
        private System.Windows.Forms.Label arLbl;
        private System.Windows.Forms.Label latvanyossagNevLbl;
        private System.Windows.Forms.NumericUpDown arNUD;
        private System.Windows.Forms.TextBox latvanyossagNevTB;
        private System.Windows.Forms.TextBox leirasTB;
        private System.Windows.Forms.Label leirasLbl;
        private System.Windows.Forms.Label varosCBLbl;
        private System.Windows.Forms.ComboBox varosokCOB;
        private System.Windows.Forms.ListBox varosokLstBx;
        private System.Windows.Forms.Button torlesBtn;
        private System.Windows.Forms.Button modositasBtn;
        private System.Windows.Forms.Button mMentesBtn;
        private System.Windows.Forms.ListBox latvanyossagokLstBx;
    }
}

