namespace HamsterCombatAuto
{
        partial class UserManagerForm
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
                        button1 = new Button();
                        textBox1 = new TextBox();
                        saveAuthButton = new Button();
                        authTextBox = new TextBox();
                        listBox1 = new ListBox();
                        label1 = new Label();
                        label2 = new Label();
                        SuspendLayout();
                        // 
                        // button1
                        // 
                        button1.Location = new Point(270, 58);
                        button1.Name = "button1";
                        button1.Size = new Size(58, 94);
                        button1.TabIndex = 31;
                        button1.Text = "Delete";
                        button1.UseVisualStyleBackColor = true;
                        button1.Click += button1_Click;
                        // 
                        // textBox1
                        // 
                        textBox1.Location = new Point(12, 29);
                        textBox1.Name = "textBox1";
                        textBox1.Size = new Size(82, 23);
                        textBox1.TabIndex = 30;
                        // 
                        // saveAuthButton
                        // 
                        saveAuthButton.Location = new Point(270, 29);
                        saveAuthButton.Name = "saveAuthButton";
                        saveAuthButton.Size = new Size(58, 23);
                        saveAuthButton.TabIndex = 28;
                        saveAuthButton.Text = "Add";
                        saveAuthButton.UseVisualStyleBackColor = true;
                        saveAuthButton.Click += saveAuthButton_Click;
                        // 
                        // authTextBox
                        // 
                        authTextBox.Location = new Point(100, 29);
                        authTextBox.Name = "authTextBox";
                        authTextBox.Size = new Size(162, 23);
                        authTextBox.TabIndex = 27;
                        authTextBox.UseSystemPasswordChar = true;
                        // 
                        // listBox1
                        // 
                        listBox1.FormattingEnabled = true;
                        listBox1.ItemHeight = 15;
                        listBox1.Location = new Point(12, 58);
                        listBox1.Name = "listBox1";
                        listBox1.Size = new Size(250, 94);
                        listBox1.TabIndex = 35;
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.ForeColor = Color.White;
                        label1.Location = new Point(12, 11);
                        label1.Name = "label1";
                        label1.Size = new Size(39, 15);
                        label1.TabIndex = 36;
                        label1.Text = "Name";
                        // 
                        // label2
                        // 
                        label2.AutoSize = true;
                        label2.ForeColor = Color.Transparent;
                        label2.Location = new Point(100, 11);
                        label2.Name = "label2";
                        label2.Size = new Size(74, 15);
                        label2.TabIndex = 37;
                        label2.Text = "Bearer Token";
                        // 
                        // UserManagerForm
                        // 
                        AutoScaleDimensions = new SizeF(7F, 15F);
                        AutoScaleMode = AutoScaleMode.Font;
                        BackColor = Color.FromArgb(39, 42, 47);
                        ClientSize = new Size(340, 168);
                        Controls.Add(label2);
                        Controls.Add(label1);
                        Controls.Add(listBox1);
                        Controls.Add(button1);
                        Controls.Add(textBox1);
                        Controls.Add(saveAuthButton);
                        Controls.Add(authTextBox);
                        MaximumSize = new Size(356, 207);
                        MinimumSize = new Size(356, 207);
                        Name = "UserManagerForm";
                        StartPosition = FormStartPosition.CenterScreen;
                        Text = "Manage Users";
                        ResumeLayout(false);
                        PerformLayout();
                }

                #endregion

                private Button button1;
                private TextBox textBox1;
                private Button saveAuthButton;
                private TextBox authTextBox;
                private ListBox listBox1;
                private Label label1;
                private Label label2;
        }
}