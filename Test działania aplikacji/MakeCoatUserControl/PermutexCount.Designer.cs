namespace PaintshopAppUI
{
    partial class PermutexCount
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
            this.components = new System.ComponentModel.Container();
            this.timerCoatFinishTime = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.timerCoat = new System.Windows.Forms.Timer(this.components);
            this.lblSec = new System.Windows.Forms.Label();
            this.checkBox5Permutex = new System.Windows.Forms.CheckBox();
            this.checkBox3Permutex = new System.Windows.Forms.CheckBox();
            this.checkBox2Permutex = new System.Windows.Forms.CheckBox();
            this.checkBox1Permutex = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantityOfThickener = new System.Windows.Forms.Label();
            this.labelBasicCoatQuantity = new System.Windows.Forms.Label();
            this.comboBoxUnitsPermutex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberGPermutex = new System.Windows.Forms.NumericUpDown();
            this.numberKg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.labelComponentB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelComponentC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox4Permutex = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberGPermutex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCoatFinishTime
            // 
            this.timerCoatFinishTime.Enabled = true;
            this.timerCoatFinishTime.Tick += new System.EventHandler(this.timerCoatFinishTime_Tick);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(157, 221);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 13);
            this.lblMin.TabIndex = 30;
            this.lblMin.Text = "00 min";
            // 
            // timerCoat
            // 
            this.timerCoat.Interval = 1000;
            this.timerCoat.Tick += new System.EventHandler(this.timerCoat_Tick);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(199, 221);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(27, 13);
            this.lblSec.TabIndex = 31;
            this.lblSec.Text = "00 s";
            // 
            // checkBox5Permutex
            // 
            this.checkBox5Permutex.AutoSize = true;
            this.checkBox5Permutex.Location = new System.Drawing.Point(448, 286);
            this.checkBox5Permutex.Name = "checkBox5Permutex";
            this.checkBox5Permutex.Size = new System.Drawing.Size(63, 17);
            this.checkBox5Permutex.TabIndex = 29;
            this.checkBox5Permutex.Text = "Gotowe";
            this.checkBox5Permutex.UseVisualStyleBackColor = true;
            this.checkBox5Permutex.CheckedChanged += new System.EventHandler(this.checkBox5Permutex_CheckedChanged);
            // 
            // checkBox3Permutex
            // 
            this.checkBox3Permutex.AutoSize = true;
            this.checkBox3Permutex.Location = new System.Drawing.Point(448, 220);
            this.checkBox3Permutex.Name = "checkBox3Permutex";
            this.checkBox3Permutex.Size = new System.Drawing.Size(63, 17);
            this.checkBox3Permutex.TabIndex = 28;
            this.checkBox3Permutex.Text = "Gotowe";
            this.checkBox3Permutex.UseVisualStyleBackColor = true;
            this.checkBox3Permutex.CheckedChanged += new System.EventHandler(this.checkBox3Permutex_CheckedChanged);
            // 
            // checkBox2Permutex
            // 
            this.checkBox2Permutex.AutoSize = true;
            this.checkBox2Permutex.Location = new System.Drawing.Point(448, 188);
            this.checkBox2Permutex.Name = "checkBox2Permutex";
            this.checkBox2Permutex.Size = new System.Drawing.Size(63, 17);
            this.checkBox2Permutex.TabIndex = 27;
            this.checkBox2Permutex.Text = "Gotowe";
            this.checkBox2Permutex.UseVisualStyleBackColor = true;
            this.checkBox2Permutex.CheckStateChanged += new System.EventHandler(this.checkBox2Permutex_CheckStateChanged);
            // 
            // checkBox1Permutex
            // 
            this.checkBox1Permutex.AutoSize = true;
            this.checkBox1Permutex.Location = new System.Drawing.Point(448, 157);
            this.checkBox1Permutex.Name = "checkBox1Permutex";
            this.checkBox1Permutex.Size = new System.Drawing.Size(63, 17);
            this.checkBox1Permutex.TabIndex = 26;
            this.checkBox1Permutex.Text = "Gotowe";
            this.checkBox1Permutex.UseVisualStyleBackColor = true;
            this.checkBox1Permutex.CheckedChanged += new System.EventHandler(this.checkBox1Permutex_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "aby lakier się prawidłowo rozmieszał.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "gram zagęszczacza Rhedovis do lakieru w wiadrze.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "gram lakieru do metalowego wiadra.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "5. Lakier jest gotowy do użycia.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "3. Zaczekaj jeszcze";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "2. Dodaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "1. Wlej";
            // 
            // labelQuantityOfThickener
            // 
            this.labelQuantityOfThickener.AutoSize = true;
            this.labelQuantityOfThickener.Location = new System.Drawing.Point(102, 189);
            this.labelQuantityOfThickener.Name = "labelQuantityOfThickener";
            this.labelQuantityOfThickener.Size = new System.Drawing.Size(25, 13);
            this.labelQuantityOfThickener.TabIndex = 18;
            this.labelQuantityOfThickener.Text = "000";
            // 
            // labelBasicCoatQuantity
            // 
            this.labelBasicCoatQuantity.AutoSize = true;
            this.labelBasicCoatQuantity.Location = new System.Drawing.Point(93, 158);
            this.labelBasicCoatQuantity.Name = "labelBasicCoatQuantity";
            this.labelBasicCoatQuantity.Size = new System.Drawing.Size(31, 13);
            this.labelBasicCoatQuantity.TabIndex = 17;
            this.labelBasicCoatQuantity.Text = "0000";
            // 
            // comboBoxUnitsPermutex
            // 
            this.comboBoxUnitsPermutex.AutoCompleteCustomSource.AddRange(new string[] {
            "kg",
            "g"});
            this.comboBoxUnitsPermutex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxUnitsPermutex.FormattingEnabled = true;
            this.comboBoxUnitsPermutex.Items.AddRange(new object[] {
            "kg",
            "g"});
            this.comboBoxUnitsPermutex.Location = new System.Drawing.Point(181, 107);
            this.comboBoxUnitsPermutex.Name = "comboBoxUnitsPermutex";
            this.comboBoxUnitsPermutex.Size = new System.Drawing.Size(45, 21);
            this.comboBoxUnitsPermutex.TabIndex = 15;
            this.comboBoxUnitsPermutex.SelectedValueChanged += new System.EventHandler(this.comboBoxUnitsPermutex_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(317, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Permutex";
            // 
            // numberGPermutex
            // 
            this.numberGPermutex.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberGPermutex.Location = new System.Drawing.Point(55, 108);
            this.numberGPermutex.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberGPermutex.Name = "numberGPermutex";
            this.numberGPermutex.Size = new System.Drawing.Size(120, 20);
            this.numberGPermutex.TabIndex = 16;
            this.numberGPermutex.ValueChanged += new System.EventHandler(this.numberGPermutex_ValueChanged);
            // 
            // numberKg
            // 
            this.numberKg.Location = new System.Drawing.Point(55, 108);
            this.numberKg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberKg.Name = "numberKg";
            this.numberKg.Size = new System.Drawing.Size(120, 20);
            this.numberKg.TabIndex = 14;
            this.numberKg.ValueChanged += new System.EventHandler(this.numberKg_ValueChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "4. Dodaj równocześnie";
            // 
            // labelComponentB
            // 
            this.labelComponentB.AutoSize = true;
            this.labelComponentB.Location = new System.Drawing.Point(173, 255);
            this.labelComponentB.Name = "labelComponentB";
            this.labelComponentB.Size = new System.Drawing.Size(25, 13);
            this.labelComponentB.TabIndex = 30;
            this.labelComponentB.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "gram Permutex WV oraz";
            // 
            // labelComponentC
            // 
            this.labelComponentC.AutoSize = true;
            this.labelComponentC.Location = new System.Drawing.Point(334, 255);
            this.labelComponentC.Name = "labelComponentC";
            this.labelComponentC.Size = new System.Drawing.Size(25, 13);
            this.labelComponentC.TabIndex = 30;
            this.labelComponentC.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "gram wody.";
            // 
            // checkBox4Permutex
            // 
            this.checkBox4Permutex.AutoSize = true;
            this.checkBox4Permutex.Location = new System.Drawing.Point(448, 255);
            this.checkBox4Permutex.Name = "checkBox4Permutex";
            this.checkBox4Permutex.Size = new System.Drawing.Size(63, 17);
            this.checkBox4Permutex.TabIndex = 28;
            this.checkBox4Permutex.Text = "Gotowe";
            this.checkBox4Permutex.UseVisualStyleBackColor = true;
            this.checkBox4Permutex.CheckedChanged += new System.EventHandler(this.checkBox4Permutex_CheckedChanged);
            // 
            // PermutexCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelComponentC);
            this.Controls.Add(this.labelComponentB);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.checkBox5Permutex);
            this.Controls.Add(this.checkBox4Permutex);
            this.Controls.Add(this.checkBox3Permutex);
            this.Controls.Add(this.checkBox2Permutex);
            this.Controls.Add(this.checkBox1Permutex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQuantityOfThickener);
            this.Controls.Add(this.labelBasicCoatQuantity);
            this.Controls.Add(this.comboBoxUnitsPermutex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberKg);
            this.Controls.Add(this.numberGPermutex);
            this.Name = "PermutexCount";
            this.Size = new System.Drawing.Size(758, 468);
            this.Load += new System.EventHandler(this.PermutexCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberGPermutex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCoatFinishTime;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Timer timerCoat;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.CheckBox checkBox5Permutex;
        private System.Windows.Forms.CheckBox checkBox3Permutex;
        private System.Windows.Forms.CheckBox checkBox2Permutex;
        private System.Windows.Forms.CheckBox checkBox1Permutex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantityOfThickener;
        private System.Windows.Forms.Label labelBasicCoatQuantity;
        private System.Windows.Forms.ComboBox comboBoxUnitsPermutex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberGPermutex;
        private System.Windows.Forms.NumericUpDown numberKg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelComponentB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelComponentC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox4Permutex;
    }
}
