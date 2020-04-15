namespace Houseplant_Suggestions
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
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lnkHousePlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Location = new System.Drawing.Point(53, 60);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(399, 29);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a South-facing window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(53, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "How warm is your home?";
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(53, 172);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(432, 90);
            this.trkTemp.TabIndex = 2;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(492, 172);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(55, 25);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "50 F";
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(163, 255);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(242, 25);
            this.lblSuggestion.TabIndex = 5;
            this.lblSuggestion.Text = "Plant suggestion here";
            // 
            // lnkHousePlantInfo
            // 
            this.lnkHousePlantInfo.AutoSize = true;
            this.lnkHousePlantInfo.Location = new System.Drawing.Point(347, 344);
            this.lnkHousePlantInfo.Name = "lnkHousePlantInfo";
            this.lnkHousePlantInfo.Size = new System.Drawing.Size(200, 25);
            this.lnkHousePlantInfo.TabIndex = 6;
            this.lnkHousePlantInfo.TabStop = true;
            this.lnkHousePlantInfo.Text = "houseplant411.com";
            this.lnkHousePlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHousePlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(606, 378);
            this.Controls.Add(this.lnkHousePlantInfo);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkSouthFacing);
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.LinkLabel lnkHousePlantInfo;
    }
}

