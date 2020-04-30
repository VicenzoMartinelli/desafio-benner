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
            this.btnSearchProgramasByFood = new System.Windows.Forms.Button();
            this.btnSearchPrograms = new System.Windows.Forms.Button();
            this.btnNewProgram = new System.Windows.Forms.Button();
            this.btnStartWithProgram = new System.Windows.Forms.Button();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.DateTimePicker();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.chk = new System.Windows.Forms.CheckBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(15, 353);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 78);
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
            this.btnQuickStart.Location = new System.Drawing.Point(195, 353);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(160, 78);
            this.btnQuickStart.TabIndex = 3;
            this.btnQuickStart.Text = "Início rápido";
            this.btnQuickStart.UseVisualStyleBackColor = false;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.chk);
            this.panel1.Controls.Add(this.btnSearchProgramasByFood);
            this.panel1.Controls.Add(this.btnSearchPrograms);
            this.panel1.Controls.Add(this.btnNewProgram);
            this.panel1.Controls.Add(this.btnStartWithProgram);
            this.panel1.Controls.Add(this.txtFood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.txtPower);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnQuickStart);
            this.panel1.Location = new System.Drawing.Point(693, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 444);
            this.panel1.TabIndex = 4;
            // 
            // btnSearchProgramasByFood
            // 
            this.btnSearchProgramasByFood.BackColor = System.Drawing.Color.White;
            this.btnSearchProgramasByFood.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProgramasByFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnSearchProgramasByFood.Location = new System.Drawing.Point(195, 257);
            this.btnSearchProgramasByFood.Name = "btnSearchProgramasByFood";
            this.btnSearchProgramasByFood.Size = new System.Drawing.Size(160, 78);
            this.btnSearchProgramasByFood.TabIndex = 14;
            this.btnSearchProgramasByFood.Text = "Consultar programas do alimento";
            this.btnSearchProgramasByFood.UseVisualStyleBackColor = false;
            this.btnSearchProgramasByFood.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchPrograms
            // 
            this.btnSearchPrograms.BackColor = System.Drawing.Color.White;
            this.btnSearchPrograms.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnSearchPrograms.Location = new System.Drawing.Point(15, 257);
            this.btnSearchPrograms.Name = "btnSearchPrograms";
            this.btnSearchPrograms.Size = new System.Drawing.Size(160, 78);
            this.btnSearchPrograms.TabIndex = 13;
            this.btnSearchPrograms.Text = "Consultar programas disponíveis";
            this.btnSearchPrograms.UseVisualStyleBackColor = false;
            this.btnSearchPrograms.Click += new System.EventHandler(this.btnSearchPrograms_Click);
            // 
            // btnNewProgram
            // 
            this.btnNewProgram.BackColor = System.Drawing.Color.White;
            this.btnNewProgram.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnNewProgram.Location = new System.Drawing.Point(377, 257);
            this.btnNewProgram.Name = "btnNewProgram";
            this.btnNewProgram.Size = new System.Drawing.Size(160, 78);
            this.btnNewProgram.TabIndex = 12;
            this.btnNewProgram.Text = "Novo programa";
            this.btnNewProgram.UseVisualStyleBackColor = false;
            this.btnNewProgram.Click += new System.EventHandler(this.btnNewProgram_Click);
            // 
            // btnStartWithProgram
            // 
            this.btnStartWithProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnStartWithProgram.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartWithProgram.ForeColor = System.Drawing.Color.White;
            this.btnStartWithProgram.Location = new System.Drawing.Point(377, 353);
            this.btnStartWithProgram.Name = "btnStartWithProgram";
            this.btnStartWithProgram.Size = new System.Drawing.Size(160, 78);
            this.btnStartWithProgram.TabIndex = 11;
            this.btnStartWithProgram.Text = "Utilizar programa";
            this.btnStartWithProgram.UseVisualStyleBackColor = false;
            this.btnStartWithProgram.Click += new System.EventHandler(this.btnStartWithProgram_Click);
            // 
            // txtFood
            // 
            this.txtFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtFood.Location = new System.Drawing.Point(15, 163);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(522, 26);
            this.txtFood.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(13, 133);
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
            this.txtTime.Size = new System.Drawing.Size(522, 26);
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
            this.txtPower.Size = new System.Drawing.Size(522, 26);
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
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedback.Size = new System.Drawing.Size(675, 326);
            this.txtFeedback.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Location = new System.Drawing.Point(12, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 112);
            this.panel2.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(373, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(160, 78);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.btnPause.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(154, 18);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(160, 78);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.chk.Location = new System.Drawing.Point(16, 215);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(238, 21);
            this.chk.TabIndex = 15;
            this.chk.Text = "Mostrar feedback em arquivo";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.txtPath.Location = new System.Drawing.Point(260, 210);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 26);
            this.txtPath.TabIndex = 16;
            this.txtPath.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1253, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.panel1);
            this.Name = "FormHome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microwave Benner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnNewProgram;
        private System.Windows.Forms.Button btnStartWithProgram;
        private System.Windows.Forms.Button btnSearchProgramasByFood;
        private System.Windows.Forms.Button btnSearchPrograms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox chk;
    }
}
