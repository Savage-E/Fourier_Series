namespace WindowsFormsApp1
{
    partial class MainForm
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
            this._radioBtnX = new System.Windows.Forms.RadioButton();
            this._radioBtnX2 = new System.Windows.Forms.RadioButton();
            this._radioBtnSgn = new System.Windows.Forms.RadioButton();
            this._textBoxN = new System.Windows.Forms.TextBox();
            this._lblInputN = new System.Windows.Forms.Label();
            this._BtnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _radioBtnX
            // 
            this._radioBtnX.AutoSize = true;
            this._radioBtnX.Location = new System.Drawing.Point(547, 12);
            this._radioBtnX.Name = "_radioBtnX";
            this._radioBtnX.Size = new System.Drawing.Size(50, 17);
            this._radioBtnX.TabIndex = 0;
            this._radioBtnX.TabStop = true;
            this._radioBtnX.Text = "f(x)=x";
            this._radioBtnX.UseVisualStyleBackColor = true;
            // 
            // _radioBtnX2
            // 
            this._radioBtnX2.AutoSize = true;
            this._radioBtnX2.Location = new System.Drawing.Point(547, 35);
            this._radioBtnX2.Name = "_radioBtnX2";
            this._radioBtnX2.Size = new System.Drawing.Size(62, 17);
            this._radioBtnX2.TabIndex = 1;
            this._radioBtnX2.TabStop = true;
            this._radioBtnX2.Text = "f(x)=x^2";
            this._radioBtnX2.UseVisualStyleBackColor = true;
            // 
            // _radioBtnSgn
            // 
            this._radioBtnSgn.AutoSize = true;
            this._radioBtnSgn.Location = new System.Drawing.Point(547, 58);
            this._radioBtnSgn.Name = "_radioBtnSgn";
            this._radioBtnSgn.Size = new System.Drawing.Size(73, 17);
            this._radioBtnSgn.TabIndex = 2;
            this._radioBtnSgn.TabStop = true;
            this._radioBtnSgn.Text = "f(x)=sgn(x)";
            this._radioBtnSgn.UseVisualStyleBackColor = true;
            // 
            // _textBoxN
            // 
            this._textBoxN.Location = new System.Drawing.Point(547, 94);
            this._textBoxN.Name = "_textBoxN";
            this._textBoxN.Size = new System.Drawing.Size(89, 20);
            this._textBoxN.TabIndex = 3;
            this._textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._textBoxN_KeyPress);
            // 
            // _lblInputN
            // 
            this._lblInputN.AutoSize = true;
            this._lblInputN.Location = new System.Drawing.Point(544, 78);
            this._lblInputN.Name = "_lblInputN";
            this._lblInputN.Size = new System.Drawing.Size(92, 13);
            this._lblInputN.TabIndex = 4;
            this._lblInputN.Text = "Введите число N";
            // 
            // _BtnRun
            // 
            this._BtnRun.Location = new System.Drawing.Point(547, 120);
            this._BtnRun.Name = "_BtnRun";
            this._BtnRun.Size = new System.Drawing.Size(75, 23);
            this._BtnRun.TabIndex = 5;
            this._BtnRun.Text = "Выполнить";
            this._BtnRun.UseVisualStyleBackColor = true;
            this._BtnRun.Click += new System.EventHandler(this._BtnRun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 462);
            this.Controls.Add(this._BtnRun);
            this.Controls.Add(this._lblInputN);
            this.Controls.Add(this._textBoxN);
            this.Controls.Add(this._radioBtnSgn);
            this.Controls.Add(this._radioBtnX2);
            this.Controls.Add(this._radioBtnX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Ряды Фурье";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton _radioBtnX;
        private System.Windows.Forms.RadioButton _radioBtnX2;
        private System.Windows.Forms.RadioButton _radioBtnSgn;
        private System.Windows.Forms.TextBox _textBoxN;
        private System.Windows.Forms.Label _lblInputN;
        private System.Windows.Forms.Button _BtnRun;
    }
}

