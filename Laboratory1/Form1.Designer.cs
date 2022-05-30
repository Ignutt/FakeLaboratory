
namespace Laboratory1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LaunchButton = new System.Windows.Forms.Button();
            this.UpdateTableButton = new System.Windows.Forms.Button();
            this.CleanUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(215, 177);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Run";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // UpdateTableButton
            // 
            this.UpdateTableButton.Location = new System.Drawing.Point(306, 177);
            this.UpdateTableButton.Name = "UpdateTableButton";
            this.UpdateTableButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateTableButton.TabIndex = 1;
            this.UpdateTableButton.Text = "Update";
            this.UpdateTableButton.UseVisualStyleBackColor = true;
            this.UpdateTableButton.Click += new System.EventHandler(this.UpdateTableButton_Click);
            // 
            // CleanUpButton
            // 
            this.CleanUpButton.Location = new System.Drawing.Point(402, 177);
            this.CleanUpButton.Name = "CleanUpButton";
            this.CleanUpButton.Size = new System.Drawing.Size(75, 23);
            this.CleanUpButton.TabIndex = 2;
            this.CleanUpButton.Text = "CleanUp";
            this.CleanUpButton.UseVisualStyleBackColor = true;
            this.CleanUpButton.Click += new System.EventHandler(this.CleanUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CleanUpButton);
            this.Controls.Add(this.UpdateTableButton);
            this.Controls.Add(this.LaunchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button UpdateTableButton;
        private System.Windows.Forms.Button CleanUpButton;
    }
}

