namespace WeatherDashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CityTextBox = new TextBox();
            SearchButton = new Button();
            TemperatureLabel = new Label();
            WeatherLabel = new Label();
            HumidityLabel = new Label();
            WindSpeedLabel = new Label();
            SuspendLayout();
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(100, 12);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(297, 27);
            CityTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(432, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Font = new Font("Segoe UI", 14F);
            TemperatureLabel.Location = new Point(24, 107);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(149, 32);
            TemperatureLabel.TabIndex = 2;
            TemperatureLabel.Text = "Temperature";
            // 
            // WeatherLabel
            // 
            WeatherLabel.AutoSize = true;
            WeatherLabel.Font = new Font("Segoe UI", 14F);
            WeatherLabel.Location = new Point(24, 191);
            WeatherLabel.Name = "WeatherLabel";
            WeatherLabel.Size = new Size(215, 32);
            WeatherLabel.TabIndex = 3;
            WeatherLabel.Text = "Weather Condition";
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Font = new Font("Segoe UI", 15F);
            HumidityLabel.Location = new Point(24, 271);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(116, 35);
            HumidityLabel.TabIndex = 4;
            HumidityLabel.Text = "Humidity";
            // 
            // WindSpeedLabel
            // 
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Font = new Font("Segoe UI", 14F);
            WindSpeedLabel.Location = new Point(24, 343);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(144, 32);
            WindSpeedLabel.TabIndex = 5;
            WindSpeedLabel.Text = "Wind Speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(WindSpeedLabel);
            Controls.Add(HumidityLabel);
            Controls.Add(WeatherLabel);
            Controls.Add(TemperatureLabel);
            Controls.Add(SearchButton);
            Controls.Add(CityTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CityTextBox;
        private Button SearchButton;
        private Label TemperatureLabel;
        private Label WeatherLabel;
        private Label HumidityLabel;
        private Label WindSpeedLabel;
    }
}
