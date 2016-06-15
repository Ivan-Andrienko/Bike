namespace WF_2
{
    partial class ucHardTeil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbNumberChassis = new System.Windows.Forms.Label();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Wheel = new System.Windows.Forms.Label();
            this.tbWheel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lbNumberChassis
            // 
            this.lbNumberChassis.AutoSize = true;
            this.lbNumberChassis.Location = new System.Drawing.Point(25, 102);
            this.lbNumberChassis.Name = "lbNumberChassis";
            this.lbNumberChassis.Size = new System.Drawing.Size(83, 13);
            this.lbNumberChassis.TabIndex = 1;
            this.lbNumberChassis.Text = "Number Chassis";
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(100, 59);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(74, 20);
            this.tbSpeedCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed Count";
            // 
            // Wheel
            // 
            this.Wheel.AutoSize = true;
            this.Wheel.Location = new System.Drawing.Point(25, 20);
            this.Wheel.Name = "Wheel";
            this.Wheel.Size = new System.Drawing.Size(38, 13);
            this.Wheel.TabIndex = 1;
            this.Wheel.Text = "Wheel";
            // 
            // tbWheel
            // 
            this.tbWheel.Location = new System.Drawing.Point(74, 17);
            this.tbWheel.Name = "tbWheel";
            this.tbWheel.Size = new System.Drawing.Size(100, 20);
            this.tbWheel.TabIndex = 2;
            // 
            // ucHardTeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbWheel);
            this.Controls.Add(this.Wheel);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumberChassis);
            this.Controls.Add(this.comboBox1);
            this.Name = "ucHardTeil";
            this.Size = new System.Drawing.Size(222, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbNumberChassis;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Wheel;
        private System.Windows.Forms.TextBox tbWheel;
    }
}
