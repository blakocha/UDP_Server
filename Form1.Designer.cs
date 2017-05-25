namespace UDP_Server
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
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.Wiadomosc = new System.Windows.Forms.ListBox();
            this.button_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(292, 13);
            this.PortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(332, 20);
            this.PortNumber.TabIndex = 0;
            // 
            // Wiadomosc
            // 
            this.Wiadomosc.FormattingEnabled = true;
            this.Wiadomosc.Location = new System.Drawing.Point(293, 54);
            this.Wiadomosc.Name = "Wiadomosc";
            this.Wiadomosc.Size = new System.Drawing.Size(330, 160);
            this.Wiadomosc.TabIndex = 1;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(398, 266);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(142, 88);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 496);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.Wiadomosc);
            this.Controls.Add(this.PortNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.ListBox Wiadomosc;
        private System.Windows.Forms.Button button_Start;
    }
}

