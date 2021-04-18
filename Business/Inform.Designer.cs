
namespace Business
{
    partial class Inform
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListOfOrg = new System.Windows.Forms.Button();
            this.buttonLastResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHowLong = new System.Windows.Forms.Button();
            this.buttonMarathon2016 = new System.Windows.Forms.Button();
            this.buttonBMRCalc = new System.Windows.Forms.Button();
            this.buttonBMICalc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 54);
            this.panel1.TabIndex = 27;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClose.Location = new System.Drawing.Point(20, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 27);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "MARATHON SKILLS 2016";
            // 
            // buttonListOfOrg
            // 
            this.buttonListOfOrg.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListOfOrg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonListOfOrg.Location = new System.Drawing.Point(413, 214);
            this.buttonListOfOrg.Name = "buttonListOfOrg";
            this.buttonListOfOrg.Size = new System.Drawing.Size(157, 54);
            this.buttonListOfOrg.TabIndex = 32;
            this.buttonListOfOrg.Text = "Список благотворительных организаций";
            this.buttonListOfOrg.UseVisualStyleBackColor = true;
            this.buttonListOfOrg.Click += new System.EventHandler(this.buttonListOfOrg_Click);
            // 
            // buttonLastResult
            // 
            this.buttonLastResult.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLastResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLastResult.Location = new System.Drawing.Point(222, 214);
            this.buttonLastResult.Name = "buttonLastResult";
            this.buttonLastResult.Size = new System.Drawing.Size(157, 54);
            this.buttonLastResult.TabIndex = 31;
            this.buttonLastResult.Text = "Предыдущие результаты";
            this.buttonLastResult.UseVisualStyleBackColor = true;
            this.buttonLastResult.Click += new System.EventHandler(this.buttonLastResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(328, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Подробная информация";
            // 
            // buttonHowLong
            // 
            this.buttonHowLong.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHowLong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHowLong.Location = new System.Drawing.Point(413, 129);
            this.buttonHowLong.Name = "buttonHowLong";
            this.buttonHowLong.Size = new System.Drawing.Size(157, 54);
            this.buttonHowLong.TabIndex = 29;
            this.buttonHowLong.Text = "Насколько долгий марафон";
            this.buttonHowLong.UseVisualStyleBackColor = true;
            this.buttonHowLong.Click += new System.EventHandler(this.buttonHowLong_Click);
            // 
            // buttonMarathon2016
            // 
            this.buttonMarathon2016.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMarathon2016.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMarathon2016.Location = new System.Drawing.Point(222, 129);
            this.buttonMarathon2016.Name = "buttonMarathon2016";
            this.buttonMarathon2016.Size = new System.Drawing.Size(157, 54);
            this.buttonMarathon2016.TabIndex = 28;
            this.buttonMarathon2016.Text = "Marathon Skills 2016";
            this.buttonMarathon2016.UseVisualStyleBackColor = true;
            this.buttonMarathon2016.Click += new System.EventHandler(this.buttonMarathon2016_Click);
            // 
            // buttonBMRCalc
            // 
            this.buttonBMRCalc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMRCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBMRCalc.Location = new System.Drawing.Point(413, 288);
            this.buttonBMRCalc.Name = "buttonBMRCalc";
            this.buttonBMRCalc.Size = new System.Drawing.Size(157, 54);
            this.buttonBMRCalc.TabIndex = 34;
            this.buttonBMRCalc.Text = "BMR калькулятор";
            this.buttonBMRCalc.UseVisualStyleBackColor = true;
            this.buttonBMRCalc.Click += new System.EventHandler(this.buttonBMRCalc_Click);
            // 
            // buttonBMICalc
            // 
            this.buttonBMICalc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMICalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBMICalc.Location = new System.Drawing.Point(222, 288);
            this.buttonBMICalc.Name = "buttonBMICalc";
            this.buttonBMICalc.Size = new System.Drawing.Size(157, 54);
            this.buttonBMICalc.TabIndex = 33;
            this.buttonBMICalc.Text = "BMI калькулятор";
            this.buttonBMICalc.UseVisualStyleBackColor = true;
            this.buttonBMICalc.Click += new System.EventHandler(this.buttonBMICalc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 42);
            this.panel2.TabIndex = 35;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(360, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // Inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBMRCalc);
            this.Controls.Add(this.buttonBMICalc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonListOfOrg);
            this.Controls.Add(this.buttonLastResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonHowLong);
            this.Controls.Add(this.buttonMarathon2016);
            this.Name = "Inform";
            this.Text = "Inform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListOfOrg;
        private System.Windows.Forms.Button buttonLastResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHowLong;
        private System.Windows.Forms.Button buttonMarathon2016;
        private System.Windows.Forms.Button buttonBMRCalc;
        private System.Windows.Forms.Button buttonBMICalc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}