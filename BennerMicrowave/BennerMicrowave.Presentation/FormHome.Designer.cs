namespace BennerMicrowave.Presentation
{
    partial class FormHome
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuickStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(15, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(177, 85);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuickStart
            // 
            this.btnQuickStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnQuickStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickStart.ForeColor = System.Drawing.Color.White;
            this.btnQuickStart.Location = new System.Drawing.Point(15, 323);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(177, 85);
            this.btnQuickStart.TabIndex = 3;
            this.btnQuickStart.Text = "Início rápido";
            this.btnQuickStart.UseVisualStyleBackColor = false;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtPower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnQuickStart);
            this.panel1.Location = new System.Drawing.Point(578, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 426);
            this.panel1.TabIndex = 4;
            // 
            // txtFood
            // 
            this.txtFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtFood.Location = new System.Drawing.Point(15, 160);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(177, 26);
            this.txtFood.TabIndex = 10;
            this.txtFood.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alimento";
            // 
            // txtTime
            // 
            this.txtTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtTime.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.txtTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtTime.Location = new System.Drawing.Point(15, 85);
            this.txtTime.MinDate = new System.DateTime(1753, 1, 3, 0, 0, 0, 0);
            this.txtTime.Name = "txtTime";
            this.txtTime.ShowUpDown = true;
            this.txtTime.Size = new System.Drawing.Size(177, 26);
            this.txtTime.TabIndex = 8;
            this.txtTime.Value = new System.DateTime(2020, 4, 28, 0, 0, 1, 0);
            // 
            // txtPower
            // 
            this.txtPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtPower.Location = new System.Drawing.Point(15, 34);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(177, 26);
            this.txtPower.TabIndex = 6;
            this.txtPower.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Potência";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(12, 12);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ReadOnly = true;
            this.txtFeedback.Size = new System.Drawing.Size(560, 426);
            this.txtFeedback.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microwave Benner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuickStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.DateTimePicker txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFood;
    }
}
