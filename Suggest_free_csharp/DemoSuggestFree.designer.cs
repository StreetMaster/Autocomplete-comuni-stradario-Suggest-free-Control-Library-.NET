namespace Suggest_free_csharp
{
    partial class DemoSuggestFree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoSuggestFree));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreetMasterKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtFrazione = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtSuggestComune = new SuggestControl.SuggestTown();
            this.cbSoloComuni = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "StreetMaster key";
            // 
            // txtStreetMasterKey
            // 
            this.txtStreetMasterKey.Location = new System.Drawing.Point(271, 28);
            this.txtStreetMasterKey.Name = "txtStreetMasterKey";
            this.txtStreetMasterKey.Size = new System.Drawing.Size(122, 20);
            this.txtStreetMasterKey.TabIndex = 11;
            this.txtStreetMasterKey.TextChanged += new System.EventHandler(this.txtStreetMasterKey_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ATTENZIONE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Prima dell\'utilizzo inserire la chiave del servizio Suggest.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(282, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Per richiederla visita www.streetmaster.it";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtFrazione
            // 
            this.txtFrazione.Enabled = false;
            this.txtFrazione.Location = new System.Drawing.Point(15, 165);
            this.txtFrazione.Name = "txtFrazione";
            this.txtFrazione.ReadOnly = true;
            this.txtFrazione.Size = new System.Drawing.Size(319, 20);
            this.txtFrazione.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Frazione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Provincia";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(418, 109);
            this.txtCap.Name = "txtCap";
            this.txtCap.ReadOnly = true;
            this.txtCap.Size = new System.Drawing.Size(60, 20);
            this.txtCap.TabIndex = 26;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Location = new System.Drawing.Point(350, 109);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(34, 20);
            this.txtProvincia.TabIndex = 25;
            // 
            // txtSuggestComune
            // 
            this.txtSuggestComune.DisableAutocomplete = false;
            this.txtSuggestComune.Location = new System.Drawing.Point(16, 109);
            this.txtSuggestComune.Name = "txtSuggestComune";
            this.txtSuggestComune.Size = new System.Drawing.Size(319, 20);
            this.txtSuggestComune.StreetMasterKey = "Inserire la chiave StreetMaster";
            this.txtSuggestComune.TabIndex = 24;
            this.txtSuggestComune.TypeSuggest = SuggestControl.Data.DataUtil.TypeSuggestEnum.Free;
            this.txtSuggestComune.TownSelect += new System.EventHandler<SuggestControl.SelectTownEventArgs>(this.txtSuggestComune_TownSelect);
            this.txtSuggestComune.TextChanged += new System.EventHandler(this.txtSuggestComune_TextChanged);
            // 
            // cbSoloComuni
            // 
            this.cbSoloComuni.AutoSize = true;
            this.cbSoloComuni.Checked = true;
            this.cbSoloComuni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSoloComuni.Location = new System.Drawing.Point(16, 131);
            this.cbSoloComuni.Name = "cbSoloComuni";
            this.cbSoloComuni.Size = new System.Drawing.Size(84, 17);
            this.cbSoloComuni.TabIndex = 23;
            this.cbSoloComuni.Text = "Solo comuni";
            this.cbSoloComuni.UseVisualStyleBackColor = true;
            this.cbSoloComuni.CheckedChanged += new System.EventHandler(this.cbSoloComuni_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Comune";
            // 
            // DemoSuggestFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 426);
            this.Controls.Add(this.txtFrazione);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtSuggestComune);
            this.Controls.Add(this.cbSoloComuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStreetMasterKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DemoSuggestFree";
            this.Text = "DemoSuggest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreetMasterKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtFrazione;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.TextBox txtProvincia;
        private SuggestControl.SuggestTown txtSuggestComune;
        private System.Windows.Forms.CheckBox cbSoloComuni;
        private System.Windows.Forms.Label label1;
    }
}