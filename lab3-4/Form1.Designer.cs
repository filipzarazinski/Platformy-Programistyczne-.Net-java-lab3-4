namespace lab3_4
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar4 = new System.Windows.Forms.MonthCalendar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(32, 60);
            this.monthCalendar3.MaxSelectionCount = 2;
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 0;
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.Location = new System.Drawing.Point(32, 378);
            this.monthCalendar4.MaxSelectionCount = 1;
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(452, 498);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1055, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.monthCalendar4);
            this.Controls.Add(this.monthCalendar3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
       
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.MonthCalendar monthCalendar4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

