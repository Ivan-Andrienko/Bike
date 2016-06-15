namespace WF_2
{
    partial class ucHard
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
            this.tbWheel = new System.Windows.Forms.TextBox();
            this.lbWheel = new System.Windows.Forms.Label();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.lbLight = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbWheel
            // 
            this.tbWheel.Location = new System.Drawing.Point(73, 28);
            this.tbWheel.Name = "tbWheel";
            this.tbWheel.Size = new System.Drawing.Size(100, 20);
            this.tbWheel.TabIndex = 0;
            // 
            // lbWheel
            // 
            this.lbWheel.AutoSize = true;
            this.lbWheel.Location = new System.Drawing.Point(19, 28);
            this.lbWheel.Name = "lbWheel";
            this.lbWheel.Size = new System.Drawing.Size(38, 13);
            this.lbWheel.TabIndex = 1;
            this.lbWheel.Text = "Wheel";
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(94, 62);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(79, 20);
            this.tbSpeedCount.TabIndex = 0;
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Location = new System.Drawing.Point(19, 65);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(69, 13);
            this.lbSpeedCount.TabIndex = 1;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // lbLight
            // 
            this.lbLight.AutoSize = true;
            this.lbLight.Location = new System.Drawing.Point(19, 99);
            this.lbLight.Name = "lbLight";
            this.lbLight.Size = new System.Drawing.Size(30, 13);
            this.lbLight.TabIndex = 1;
            this.lbLight.Text = "Light";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // ucHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbLight);
            this.Controls.Add(this.lbSpeedCount);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.lbWheel);
            this.Controls.Add(this.tbWheel);
            this.Name = "ucHard";
            this.Size = new System.Drawing.Size(222, 169);
            this.Load += new System.EventHandler(this.ucHard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWheel;
        private System.Windows.Forms.Label lbWheel;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.Label lbLight;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
