using System.ComponentModel;

namespace leungware_v420
{
    partial class AutoClickerPlacebo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.AutoClickerTrue = new System.Windows.Forms.Button();
            this.AutoClickerFalse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AutoClickerTrue
            // 
            this.AutoClickerTrue.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AutoClickerTrue.Location = new System.Drawing.Point(13, 8);
            this.AutoClickerTrue.Name = "AutoClickerTrue";
            this.AutoClickerTrue.Size = new System.Drawing.Size(132, 72);
            this.AutoClickerTrue.TabIndex = 0;
            this.AutoClickerTrue.Text = "Autoclicker On";
            this.AutoClickerTrue.UseVisualStyleBackColor = true;
            this.AutoClickerTrue.Click += new System.EventHandler(this.AutoClickerOn);
            // 
            // AutoClickerFalse
            // 
            this.AutoClickerFalse.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AutoClickerFalse.Location = new System.Drawing.Point(152, 8);
            this.AutoClickerFalse.Name = "AutoClickerFalse";
            this.AutoClickerFalse.Size = new System.Drawing.Size(132, 72);
            this.AutoClickerFalse.TabIndex = 1;
            this.AutoClickerFalse.Text = "Autoclicker Off";
            this.AutoClickerFalse.UseVisualStyleBackColor = true;
            this.AutoClickerFalse.Click += new System.EventHandler(this.AutoClickOff);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 23);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(13, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 28);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Undetectable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.UndetectableChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(290, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autoclicker Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AutoClickerPlacebo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AutoClickerFalse);
            this.Controls.Add(this.AutoClickerTrue);
            this.Name = "AutoClickerPlacebo";
            this.Text = "Autoclicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AutoClickerFalse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button AutoClickerTrue;
        private System.Windows.Forms.Label label1;
    }
}