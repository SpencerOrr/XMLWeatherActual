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
            this.minOutput = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.tommorowLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(2, 86);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(113, 38);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(238, 467);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(151, 16);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "Max Temp";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(238, 438);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(151, 16);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "Min Temp";
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.Black;
            this.currentTempOutput.Location = new System.Drawing.Point(-11, 405);
            this.currentTempOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(188, 120);
            this.currentTempOutput.TabIndex = 28;
            this.currentTempOutput.Text = "Temp RN";
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.Black;
            this.dateOutput.Location = new System.Drawing.Point(4, 63);
            this.dateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(155, 23);
            this.dateOutput.TabIndex = 40;
            this.dateOutput.Text = "Date";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(219, 29);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.conditionOutput.Location = new System.Drawing.Point(181, 63);
            this.conditionOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(148, 16);
            this.conditionOutput.TabIndex = 44;
            this.conditionOutput.Text = "Condition";
            // 
            // cityTextbox
            // 
            this.cityTextbox.BackColor = System.Drawing.Color.White;
            this.cityTextbox.Location = new System.Drawing.Point(0, 0);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(333, 22);
            this.cityTextbox.TabIndex = 45;
            // 
            // tommorowLabel
            // 
            this.tommorowLabel.AutoSize = true;
            this.tommorowLabel.BackColor = System.Drawing.Color.Transparent;
            this.tommorowLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tommorowLabel.Location = new System.Drawing.Point(99, 29);
            this.tommorowLabel.Name = "tommorowLabel";
            this.tommorowLabel.Size = new System.Drawing.Size(91, 23);
            this.tommorowLabel.TabIndex = 50;
            this.tommorowLabel.Text = "Tomorrow ";
            // 
            // countryLabel
            // 
            this.countryLabel.BackColor = System.Drawing.Color.Transparent;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(4, 124);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(94, 28);
            this.countryLabel.TabIndex = 51;
            this.countryLabel.Text = "Canada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.Search_Spyglass;
            this.pictureBox1.Location = new System.Drawing.Point(293, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "Today";
            // 
            // weatherBox
            // 
            this.weatherBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherBox.Location = new System.Drawing.Point(18, 155);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(288, 247);
            this.weatherBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox.TabIndex = 52;
            this.weatherBox.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.tommorowLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentTempOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tommorowLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox weatherBox;
    }
}
