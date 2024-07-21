namespace HamsterCombatAuto
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
                        components = new System.ComponentModel.Container();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                        pictureBox1 = new PictureBox();
                        updateButton = new Button();
                        saveAuthButton = new Button();
                        buyButton = new Button();
                        label1 = new Label();
                        label2 = new Label();
                        label3 = new Label();
                        label4 = new Label();
                        label5 = new Label();
                        label8 = new Label();
                        pictureBox2 = new PictureBox();
                        label9 = new Label();
                        label10 = new Label();
                        pictureBox3 = new PictureBox();
                        label11 = new Label();
                        label12 = new Label();
                        pictureBox4 = new PictureBox();
                        label6 = new Label();
                        label7 = new Label();
                        label13 = new Label();
                        comboBox1 = new ComboBox();
                        checkBox1 = new CheckBox();
                        autoUpgradeTimer = new System.Windows.Forms.Timer(components);
                        label14 = new Label();
                        errorLabel = new Label();
                        textBox2 = new TextBox();
                        takeMoneyTimer = new System.Windows.Forms.Timer(components);
                        label15 = new Label();
                        updateMoneyTimer = new System.Windows.Forms.Timer(components);
                        label16 = new Label();
                        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
                        SuspendLayout();
                        // 
                        // pictureBox1
                        // 
                        pictureBox1.ImageLocation = "https://avatar.spworlds.ru/face/55/rafael1209.png";
                        pictureBox1.Location = new Point(12, 88);
                        pictureBox1.Name = "pictureBox1";
                        pictureBox1.Size = new Size(145, 152);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.TabIndex = 0;
                        pictureBox1.TabStop = false;
                        // 
                        // updateButton
                        // 
                        updateButton.Location = new Point(42, 380);
                        updateButton.Name = "updateButton";
                        updateButton.Size = new Size(256, 23);
                        updateButton.TabIndex = 2;
                        updateButton.Text = "Refresh";
                        updateButton.UseVisualStyleBackColor = true;
                        updateButton.Click += updateButton_Click_1;
                        // 
                        // saveAuthButton
                        // 
                        saveAuthButton.Location = new Point(270, 12);
                        saveAuthButton.Name = "saveAuthButton";
                        saveAuthButton.Size = new Size(58, 23);
                        saveAuthButton.TabIndex = 4;
                        saveAuthButton.Text = "Manage";
                        saveAuthButton.UseVisualStyleBackColor = true;
                        saveAuthButton.Click += saveAuthButton_Click;
                        // 
                        // buyButton
                        // 
                        buyButton.Location = new Point(42, 409);
                        buyButton.Name = "buyButton";
                        buyButton.Size = new Size(256, 23);
                        buyButton.TabIndex = 5;
                        buyButton.Text = "Buy";
                        buyButton.UseVisualStyleBackColor = true;
                        buyButton.Click += buyButton_Click;
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label1.ForeColor = Color.White;
                        label1.Location = new Point(164, 114);
                        label1.Name = "label1";
                        label1.Size = new Size(37, 15);
                        label1.TabIndex = 6;
                        label1.Text = "CEO";
                        // 
                        // label2
                        // 
                        label2.AutoSize = true;
                        label2.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label2.ForeColor = Color.White;
                        label2.Location = new Point(164, 187);
                        label2.Name = "label2";
                        label2.Size = new Size(89, 15);
                        label2.TabIndex = 7;
                        label2.Text = "Profit per hour";
                        // 
                        // label3
                        // 
                        label3.AutoSize = true;
                        label3.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label3.ForeColor = Color.White;
                        label3.Location = new Point(164, 202);
                        label3.Name = "label3";
                        label3.Size = new Size(48, 15);
                        label3.TabIndex = 8;
                        label3.Text = "$3.04K";
                        // 
                        // label4
                        // 
                        label4.AutoSize = true;
                        label4.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label4.ForeColor = Color.White;
                        label4.Location = new Point(164, 129);
                        label4.Name = "label4";
                        label4.Size = new Size(38, 15);
                        label4.TabIndex = 9;
                        label4.Text = "lvl 17";
                        // 
                        // label5
                        // 
                        label5.AutoSize = true;
                        label5.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label5.ForeColor = Color.White;
                        label5.Location = new Point(52, 265);
                        label5.Name = "label5";
                        label5.Size = new Size(84, 15);
                        label5.TabIndex = 14;
                        label5.Text = "Price $3.05M";
                        // 
                        // label8
                        // 
                        label8.AutoSize = true;
                        label8.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label8.ForeColor = Color.White;
                        label8.Location = new Point(52, 250);
                        label8.Name = "label8";
                        label8.Size = new Size(37, 15);
                        label8.TabIndex = 11;
                        label8.Text = "CEO";
                        // 
                        // pictureBox2
                        // 
                        pictureBox2.ImageLocation = "https://avatar.spworlds.ru/face/55/rafael1209.png";
                        pictureBox2.Location = new Point(12, 246);
                        pictureBox2.Name = "pictureBox2";
                        pictureBox2.Size = new Size(34, 37);
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox2.TabIndex = 10;
                        pictureBox2.TabStop = false;
                        // 
                        // label9
                        // 
                        label9.AutoSize = true;
                        label9.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label9.ForeColor = Color.White;
                        label9.Location = new Point(52, 308);
                        label9.Name = "label9";
                        label9.Size = new Size(38, 15);
                        label9.TabIndex = 17;
                        label9.Text = "lvl 17";
                        // 
                        // label10
                        // 
                        label10.AutoSize = true;
                        label10.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label10.ForeColor = Color.White;
                        label10.Location = new Point(52, 293);
                        label10.Name = "label10";
                        label10.Size = new Size(37, 15);
                        label10.TabIndex = 16;
                        label10.Text = "CEO";
                        // 
                        // pictureBox3
                        // 
                        pictureBox3.ImageLocation = "https://avatar.spworlds.ru/face/55/rafael1209.png";
                        pictureBox3.Location = new Point(12, 289);
                        pictureBox3.Name = "pictureBox3";
                        pictureBox3.Size = new Size(34, 37);
                        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox3.TabIndex = 15;
                        pictureBox3.TabStop = false;
                        // 
                        // label11
                        // 
                        label11.AutoSize = true;
                        label11.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label11.ForeColor = Color.White;
                        label11.Location = new Point(52, 351);
                        label11.Name = "label11";
                        label11.Size = new Size(38, 15);
                        label11.TabIndex = 20;
                        label11.Text = "lvl 17";
                        // 
                        // label12
                        // 
                        label12.AutoSize = true;
                        label12.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label12.ForeColor = Color.White;
                        label12.Location = new Point(52, 336);
                        label12.Name = "label12";
                        label12.Size = new Size(37, 15);
                        label12.TabIndex = 19;
                        label12.Text = "CEO";
                        // 
                        // pictureBox4
                        // 
                        pictureBox4.ImageLocation = "https://avatar.spworlds.ru/face/55/rafael1209.png";
                        pictureBox4.Location = new Point(12, 332);
                        pictureBox4.Name = "pictureBox4";
                        pictureBox4.Size = new Size(34, 37);
                        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox4.TabIndex = 18;
                        pictureBox4.TabStop = false;
                        // 
                        // label6
                        // 
                        label6.AutoSize = true;
                        label6.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label6.ForeColor = Color.White;
                        label6.Location = new Point(12, 229);
                        label6.Name = "label6";
                        label6.Size = new Size(42, 15);
                        label6.TabIndex = 21;
                        label6.Text = "Next:";
                        // 
                        // label7
                        // 
                        label7.AutoSize = true;
                        label7.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label7.ForeColor = Color.White;
                        label7.Location = new Point(164, 166);
                        label7.Name = "label7";
                        label7.Size = new Size(48, 15);
                        label7.TabIndex = 23;
                        label7.Text = "$3.04K";
                        // 
                        // label13
                        // 
                        label13.AutoSize = true;
                        label13.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label13.ForeColor = Color.White;
                        label13.Location = new Point(164, 151);
                        label13.Name = "label13";
                        label13.Size = new Size(37, 15);
                        label13.TabIndex = 22;
                        label13.Text = "Price";
                        // 
                        // comboBox1
                        // 
                        comboBox1.FormattingEnabled = true;
                        comboBox1.Location = new Point(12, 12);
                        comboBox1.Name = "comboBox1";
                        comboBox1.Size = new Size(250, 23);
                        comboBox1.TabIndex = 24;
                        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                        // 
                        // checkBox1
                        // 
                        checkBox1.AutoSize = true;
                        checkBox1.ForeColor = Color.White;
                        checkBox1.Location = new Point(12, 41);
                        checkBox1.Name = "checkBox1";
                        checkBox1.Size = new Size(100, 19);
                        checkBox1.TabIndex = 27;
                        checkBox1.Text = "Auto Upgrade";
                        checkBox1.UseVisualStyleBackColor = true;
                        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
                        // 
                        // autoUpgradeTimer
                        // 
                        autoUpgradeTimer.Interval = 10000;
                        autoUpgradeTimer.Tick += autoUpgradeTimer_Tick;
                        // 
                        // label14
                        // 
                        label14.AutoSize = true;
                        label14.Font = new Font("Helvetica", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
                        label14.ForeColor = Color.White;
                        label14.Location = new Point(10, 71);
                        label14.Name = "label14";
                        label14.RightToLeft = RightToLeft.No;
                        label14.Size = new Size(179, 15);
                        label14.TabIndex = 28;
                        label14.Text = "Balance: $400.33M (+12.45M)";
                        // 
                        // errorLabel
                        // 
                        errorLabel.ForeColor = Color.White;
                        errorLabel.Location = new Point(12, 432);
                        errorLabel.Name = "errorLabel";
                        errorLabel.Size = new Size(316, 85);
                        errorLabel.TabIndex = 29;
                        errorLabel.Text = "Error:";
                        // 
                        // textBox2
                        // 
                        textBox2.Location = new Point(114, 39);
                        textBox2.Name = "textBox2";
                        textBox2.Size = new Size(31, 23);
                        textBox2.TabIndex = 30;
                        textBox2.Text = "1000";
                        // 
                        // takeMoneyTimer
                        // 
                        takeMoneyTimer.Enabled = true;
                        takeMoneyTimer.Interval = 300000;
                        takeMoneyTimer.Tick += takeMoneyTimer_Tick;
                        // 
                        // label15
                        // 
                        label15.AutoSize = true;
                        label15.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label15.ForeColor = Color.White;
                        label15.Location = new Point(151, 42);
                        label15.Name = "label15";
                        label15.Size = new Size(168, 15);
                        label15.TabIndex = 31;
                        label15.Text = "Price/Added Profit Per Hour";
                        // 
                        // updateMoneyTimer
                        // 
                        updateMoneyTimer.Enabled = true;
                        updateMoneyTimer.Interval = 1000;
                        updateMoneyTimer.Tick += updateMoneyTimer_Tick;
                        // 
                        // label16
                        // 
                        label16.AutoSize = true;
                        label16.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
                        label16.ForeColor = Color.White;
                        label16.Location = new Point(114, 229);
                        label16.Name = "label16";
                        label16.Size = new Size(43, 15);
                        label16.TabIndex = 32;
                        label16.Text = "v5.0.0";
                        // 
                        // Form1
                        // 
                        AutoScaleDimensions = new SizeF(7F, 15F);
                        AutoScaleMode = AutoScaleMode.Font;
                        BackColor = Color.FromArgb(39, 42, 47);
                        ClientSize = new Size(340, 450);
                        Controls.Add(label16);
                        Controls.Add(label15);
                        Controls.Add(textBox2);
                        Controls.Add(errorLabel);
                        Controls.Add(label14);
                        Controls.Add(checkBox1);
                        Controls.Add(comboBox1);
                        Controls.Add(label7);
                        Controls.Add(label13);
                        Controls.Add(label6);
                        Controls.Add(label11);
                        Controls.Add(label12);
                        Controls.Add(pictureBox4);
                        Controls.Add(label9);
                        Controls.Add(label10);
                        Controls.Add(pictureBox3);
                        Controls.Add(label5);
                        Controls.Add(label8);
                        Controls.Add(pictureBox2);
                        Controls.Add(label4);
                        Controls.Add(label3);
                        Controls.Add(label2);
                        Controls.Add(label1);
                        Controls.Add(buyButton);
                        Controls.Add(saveAuthButton);
                        Controls.Add(updateButton);
                        Controls.Add(pictureBox1);
                        ForeColor = Color.FromArgb(39, 42, 47);
                        Icon = (Icon)resources.GetObject("$this.Icon");
                        MaximumSize = new Size(356, 550);
                        MinimumSize = new Size(356, 489);
                        Name = "Form1";
                        StartPosition = FormStartPosition.CenterScreen;
                        Text = "Hamster Upgrade By Rafael";
                        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
                        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
                        ResumeLayout(false);
                        PerformLayout();
                }

                #endregion

                private PictureBox pictureBox1;
                private Button updateButton;
                private Button saveAuthButton;
                private Button buyButton;
                private Label label1;
                private Label label2;
                private Label label3;
                private Label label4;
                private Label label5;
                private Label label8;
                private PictureBox pictureBox2;
                private Label label9;
                private Label label10;
                private PictureBox pictureBox3;
                private Label label11;
                private Label label12;
                private PictureBox pictureBox4;
                private Label label6;
                private Label label7;
                private Label label13;
                private ComboBox comboBox1;
                private CheckBox checkBox1;
                private System.Windows.Forms.Timer autoUpgradeTimer;
                private Label label14;
                private Label errorLabel;
                private TextBox textBox2;
                private System.Windows.Forms.Timer takeMoneyTimer;
                private Label label15;
                private System.Windows.Forms.Timer updateMoneyTimer;
                private Label label16;
        }
}
