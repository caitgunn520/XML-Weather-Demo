namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weatherCondCurrent = new System.Windows.Forms.Label();
            this.weatherSymbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cityOutput.Location = new System.Drawing.Point(43, 93);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(165, 22);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maxOutput.Location = new System.Drawing.Point(95, 188);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(113, 13);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maxLabel.Location = new System.Drawing.Point(34, 188);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minOutput.Location = new System.Drawing.Point(95, 160);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(113, 13);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minLabel.Location = new System.Drawing.Point(37, 160);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentOutput.Location = new System.Drawing.Point(113, 160);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempLabel.Location = new System.Drawing.Point(18, 115);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(213, 26);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.todayLabel.Location = new System.Drawing.Point(21, 15);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(82, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forecastLabel.Location = new System.Drawing.Point(141, 15);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(82, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "2 Day";
            this.forecastLabel.Click += new System.EventHandler(this.ForecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherCondCurrent
            // 
            this.weatherCondCurrent.AutoSize = true;
            this.weatherCondCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherCondCurrent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weatherCondCurrent.Location = new System.Drawing.Point(78, 63);
            this.weatherCondCurrent.Name = "weatherCondCurrent";
            this.weatherCondCurrent.Size = new System.Drawing.Size(94, 20);
            this.weatherCondCurrent.TabIndex = 43;
            this.weatherCondCurrent.Text = "lorem ipsum";
            this.weatherCondCurrent.Click += new System.EventHandler(this.WeatherCondCurrent_Click);
            // 
            // weatherSymbol
            // 
            this.weatherSymbol.Image = global::XMLWeather.Properties.Resources.cloudIcon;
            this.weatherSymbol.Location = new System.Drawing.Point(46, 221);
            this.weatherSymbol.Name = "weatherSymbol";
            this.weatherSymbol.Size = new System.Drawing.Size(162, 151);
            this.weatherSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherSymbol.TabIndex = 44;
            this.weatherSymbol.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.weatherSymbol);
            this.Controls.Add(this.weatherCondCurrent);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.weatherSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weatherCondCurrent;
        private System.Windows.Forms.PictureBox weatherSymbol;
    }
}
