namespace Zayvki
{
    partial class ChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceForm));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(109, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Клиенты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clients_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "Заявки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Applications_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 39);
            this.button5.TabIndex = 2;
            this.button5.Text = "Пользователи";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.Users_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Неисправности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Malfunctions_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.Load += new System.EventHandler(this.ChoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}