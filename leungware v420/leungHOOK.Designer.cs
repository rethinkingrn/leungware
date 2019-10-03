namespace leungware_v420
{
    partial class LeungHook
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlaceboExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).BeginInit();
            this.SuspendLayout();
            this.trackBar1.Location = new System.Drawing.Point(3, 44);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(148, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jitter Range";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(
                new object[] {"Enabled", "Fake Lag", "Anti Aim", "Desync", "Ping Spoof"});
            this.checkedListBox1.Location = new System.Drawing.Point(231, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 76);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged +=
                new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.trackBar2.Location = new System.Drawing.Point(3, 103);
            this.trackBar2.Maximum = 14;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(148, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fake Lag";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
                {"broke legs", "sliding", "experimental", "beta", "alpha", "pre alpha"});
            this.comboBox1.Location = new System.Drawing.Point(230, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 7;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(225, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desync Type";
            this.PlaceboExecute.Location = new System.Drawing.Point(231, 472);
            this.PlaceboExecute.Name = "PlaceboExecute";
            this.PlaceboExecute.Size = new System.Drawing.Size(138, 42);
            this.PlaceboExecute.TabIndex = 9;
            this.PlaceboExecute.Text = "Execute";
            this.PlaceboExecute.UseVisualStyleBackColor = true;
            this.PlaceboExecute.Click += new System.EventHandler(this.PlaceboGo);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 519);
            this.Controls.Add(this.PlaceboExecute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "LeungHook";
            this.Text = "Form2";
//            this.Load += new System.EventHandler(this.LeungHook_Load);
            ((System.ComponentModel.ISupportInitialize) (this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PlaceboExecute;
    }
}