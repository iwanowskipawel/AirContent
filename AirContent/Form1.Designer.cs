namespace WindowsFormsApplication1
{
    partial class mainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.airText = new System.Windows.Forms.TextBox();
            this.phaseText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.airPhaseText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.airPhaseAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "air";
            // 
            // airText
            // 
            this.airText.Location = new System.Drawing.Point(78, 40);
            this.airText.Multiline = true;
            this.airText.Name = "airText";
            this.airText.Size = new System.Drawing.Size(355, 101);
            this.airText.TabIndex = 2;
            // 
            // phaseText
            // 
            this.phaseText.Location = new System.Drawing.Point(78, 147);
            this.phaseText.Multiline = true;
            this.phaseText.Name = "phaseText";
            this.phaseText.Size = new System.Drawing.Size(355, 100);
            this.phaseText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "phase";
            // 
            // airPhaseText
            // 
            this.airPhaseText.Location = new System.Drawing.Point(78, 253);
            this.airPhaseText.Multiline = true;
            this.airPhaseText.Name = "airPhaseText";
            this.airPhaseText.Size = new System.Drawing.Size(355, 99);
            this.airPhaseText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "air/phase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "air/phase for all";
            // 
            // airPhaseAll
            // 
            this.airPhaseAll.Location = new System.Drawing.Point(110, 366);
            this.airPhaseAll.Name = "airPhaseAll";
            this.airPhaseAll.Size = new System.Drawing.Size(100, 20);
            this.airPhaseAll.TabIndex = 8;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 396);
            this.Controls.Add(this.airPhaseAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.airPhaseText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phaseText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.airText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "mainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox airText;
        private System.Windows.Forms.TextBox phaseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox airPhaseText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox airPhaseAll;
    }
}

