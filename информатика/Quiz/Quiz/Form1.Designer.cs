namespace Quiz
{
    partial class Form1
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rdBtnA = new System.Windows.Forms.RadioButton();
            this.rdBtnB = new System.Windows.Forms.RadioButton();
            this.rdBtnC = new System.Windows.Forms.RadioButton();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(41, 46);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(704, 22);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Въпроса ще бъде тук";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Довиждане";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(661, 288);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 45);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Начало";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(41, 288);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 45);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rdBtnA
            // 
            this.rdBtnA.AutoSize = true;
            this.rdBtnA.Location = new System.Drawing.Point(41, 103);
            this.rdBtnA.Name = "rdBtnA";
            this.rdBtnA.Size = new System.Drawing.Size(38, 21);
            this.rdBtnA.TabIndex = 4;
            this.rdBtnA.TabStop = true;
            this.rdBtnA.Text = "A";
            this.rdBtnA.UseVisualStyleBackColor = true;
            // 
            // rdBtnB
            // 
            this.rdBtnB.AutoSize = true;
            this.rdBtnB.Location = new System.Drawing.Point(41, 153);
            this.rdBtnB.Name = "rdBtnB";
            this.rdBtnB.Size = new System.Drawing.Size(38, 21);
            this.rdBtnB.TabIndex = 5;
            this.rdBtnB.TabStop = true;
            this.rdBtnB.Text = "B";
            this.rdBtnB.UseVisualStyleBackColor = true;
            // 
            // rdBtnC
            // 
            this.rdBtnC.AutoSize = true;
            this.rdBtnC.Location = new System.Drawing.Point(41, 204);
            this.rdBtnC.Name = "rdBtnC";
            this.rdBtnC.Size = new System.Drawing.Size(38, 21);
            this.rdBtnC.TabIndex = 6;
            this.rdBtnC.TabStop = true;
            this.rdBtnC.Text = "C";
            this.rdBtnC.UseVisualStyleBackColor = true;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(352, 400);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(77, 17);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "Резултат: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.rdBtnC);
            this.Controls.Add(this.rdBtnB);
            this.Controls.Add(this.rdBtnA);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtQuestion);
            this.Name = "Form1";
            this.Text = "Въпросник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.RadioButton rdBtnA;
        private System.Windows.Forms.RadioButton rdBtnB;
        private System.Windows.Forms.RadioButton rdBtnC;
        private System.Windows.Forms.Label lblRes;
    }
}

