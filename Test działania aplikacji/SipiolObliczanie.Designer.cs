namespace Test_działania_aplikacji
{
    partial class SipiolObliczanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberKg = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.numberG = new System.Windows.Forms.NumericUpDown();
            this.labelBasicCoatQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantityOfComponentB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.timerCoat = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.timerCoatFinishTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipiol1";
            // 
            // numberKg
            // 
            this.numberKg.Location = new System.Drawing.Point(55, 113);
            this.numberKg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberKg.Name = "numberKg";
            this.numberKg.Size = new System.Drawing.Size(120, 20);
            this.numberKg.TabIndex = 1;
            this.numberKg.ValueChanged += new System.EventHandler(this.numberKg_ValueChanged);
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.AutoCompleteCustomSource.AddRange(new string[] {
            "kg",
            "g"});
            this.comboBoxUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Items.AddRange(new object[] {
            "kg",
            "g"});
            this.comboBoxUnits.Location = new System.Drawing.Point(181, 112);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(45, 21);
            this.comboBoxUnits.TabIndex = 3;
            this.comboBoxUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnits_SelectedIndexChanged);
            // 
            // numberG
            // 
            this.numberG.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberG.Location = new System.Drawing.Point(55, 113);
            this.numberG.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberG.Name = "numberG";
            this.numberG.Size = new System.Drawing.Size(120, 20);
            this.numberG.TabIndex = 6;
            this.numberG.ValueChanged += new System.EventHandler(this.numberG_ValueChanged);
            // 
            // labelBasicCoatQuantity
            // 
            this.labelBasicCoatQuantity.AutoSize = true;
            this.labelBasicCoatQuantity.Location = new System.Drawing.Point(93, 163);
            this.labelBasicCoatQuantity.Name = "labelBasicCoatQuantity";
            this.labelBasicCoatQuantity.Size = new System.Drawing.Size(31, 13);
            this.labelBasicCoatQuantity.TabIndex = 7;
            this.labelBasicCoatQuantity.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "1. Wlej";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "gram lakieru do metalowego wiadra.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2. Dodaj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "gram składnika Sipiol VW do lakieru w wiadrze.";
            // 
            // labelQuantityOfComponentB
            // 
            this.labelQuantityOfComponentB.AutoSize = true;
            this.labelQuantityOfComponentB.Location = new System.Drawing.Point(102, 194);
            this.labelQuantityOfComponentB.Name = "labelQuantityOfComponentB";
            this.labelQuantityOfComponentB.Size = new System.Drawing.Size(25, 13);
            this.labelQuantityOfComponentB.TabIndex = 7;
            this.labelQuantityOfComponentB.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3. Zaczekaj jeszcze";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "aby lakier się prawidłowo rozmieszał.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "4. Lakier jest gotowy do użycia.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(448, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Gotowe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(448, 193);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Gotowe";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(448, 225);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(63, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Gotowe";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(448, 255);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(63, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Gotowe";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckStateChanged);
            // 
            // timerCoat
            // 
            this.timerCoat.Interval = 1000;
            this.timerCoat.Tick += new System.EventHandler(this.timerLaku_Tick);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(157, 226);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 13);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "00 min";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(199, 226);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(27, 13);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "00 s";
            // 
            // timerCoatFinishTime
            // 
            this.timerCoatFinishTime.Enabled = true;
            this.timerCoatFinishTime.Tick += new System.EventHandler(this.timerGodzinaLaku_Tick);
            // 
            // SipiolObliczanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQuantityOfComponentB);
            this.Controls.Add(this.labelBasicCoatQuantity);
            this.Controls.Add(this.comboBoxUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberG);
            this.Controls.Add(this.numberKg);
            this.Name = "SipiolObliczanie";
            this.Size = new System.Drawing.Size(758, 539);
            this.Load += new System.EventHandler(this.SipiolObliczanie1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberKg;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.NumericUpDown numberG;
        private System.Windows.Forms.Label labelBasicCoatQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantityOfComponentB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Timer timerCoat;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Timer timerCoatFinishTime;
    }
}
