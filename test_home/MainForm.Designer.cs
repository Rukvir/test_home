
namespace test_home
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(70, 40);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(111, 22);
            this.textCity.TabIndex = 0;
            this.textCity.Text = "Введите город";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(251, 29);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(96, 47);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Узнать погоду";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWindSpeed);
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Location = new System.Drawing.Point(70, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(26, 114);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(115, 17);
            this.labelWindSpeed.TabIndex = 4;
            this.labelWindSpeed.Text = "Скорость ветра:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(26, 30);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(100, 17);
            this.labelTemperature.TabIndex = 2;
            this.labelTemperature.Text = "Температура:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(26, 71);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(78, 17);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.textCity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelDescription;
    }
}