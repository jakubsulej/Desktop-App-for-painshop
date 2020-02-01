using System;

namespace Test_działania_aplikacji
{
    partial class RobienieLaku
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSipiolQuantity = new System.Windows.Forms.Button();
            this.buttonPermutexQuantity = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz rodzaj laku";
            // 
            // buttonSipiolQuantity
            // 
            this.buttonSipiolQuantity.Location = new System.Drawing.Point(37, 98);
            this.buttonSipiolQuantity.Name = "buttonSipiolQuantity";
            this.buttonSipiolQuantity.Size = new System.Drawing.Size(106, 85);
            this.buttonSipiolQuantity.TabIndex = 5;
            this.buttonSipiolQuantity.Text = "Sipiol";
            this.buttonSipiolQuantity.UseVisualStyleBackColor = true;
            // 
            // buttonPermutexQuantity
            // 
            this.buttonPermutexQuantity.Location = new System.Drawing.Point(149, 98);
            this.buttonPermutexQuantity.Name = "buttonPermutexQuantity";
            this.buttonPermutexQuantity.Size = new System.Drawing.Size(106, 85);
            this.buttonPermutexQuantity.TabIndex = 6;
            this.buttonPermutexQuantity.Text = "Permutex";
            this.buttonPermutexQuantity.UseVisualStyleBackColor = true;
            this.buttonPermutexQuantity.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 85);
            this.button3.TabIndex = 7;
            this.button3.Text = "Resilon";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 85);
            this.button4.TabIndex = 8;
            this.button4.Text = "Resilon Plus Matt";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(485, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 85);
            this.button5.TabIndex = 9;
            this.button5.Text = "Canada";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(597, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 85);
            this.button6.TabIndex = 10;
            this.button6.Text = "Metakustik";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // RobienieLaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonPermutexQuantity);
            this.Controls.Add(this.buttonSipiolQuantity);
            this.Controls.Add(this.label2);
            this.Name = "RobienieLaku";
            this.Size = new System.Drawing.Size(752, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSipiolQuantity;
        private System.Windows.Forms.Button buttonPermutexQuantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
