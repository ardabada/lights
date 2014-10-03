namespace lights
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.capsLockLbl = new System.Windows.Forms.Label();
            this.scrollLockLbl = new System.Windows.Forms.Label();
            this.numLockLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // capsLockLbl
            // 
            this.capsLockLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capsLockLbl.Location = new System.Drawing.Point(12, 9);
            this.capsLockLbl.Name = "capsLockLbl";
            this.capsLockLbl.Size = new System.Drawing.Size(136, 113);
            this.capsLockLbl.TabIndex = 0;
            this.capsLockLbl.Text = "CAPS LOCK";
            this.capsLockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scrollLockLbl
            // 
            this.scrollLockLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollLockLbl.Location = new System.Drawing.Point(154, 9);
            this.scrollLockLbl.Name = "scrollLockLbl";
            this.scrollLockLbl.Size = new System.Drawing.Size(136, 113);
            this.scrollLockLbl.TabIndex = 1;
            this.scrollLockLbl.Text = "SCROLL LOCK";
            this.scrollLockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLockLbl
            // 
            this.numLockLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLockLbl.Location = new System.Drawing.Point(294, 9);
            this.numLockLbl.Name = "numLockLbl";
            this.numLockLbl.Size = new System.Drawing.Size(136, 113);
            this.numLockLbl.TabIndex = 2;
            this.numLockLbl.Text = "NUM LOCK";
            this.numLockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 140);
            this.Controls.Add(this.numLockLbl);
            this.Controls.Add(this.scrollLockLbl);
            this.Controls.Add(this.capsLockLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label capsLockLbl;
        private System.Windows.Forms.Label scrollLockLbl;
        private System.Windows.Forms.Label numLockLbl;
    }
}

