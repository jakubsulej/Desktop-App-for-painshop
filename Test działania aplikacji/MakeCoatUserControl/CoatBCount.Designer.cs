namespace PaintshopAppUI
{
    partial class CoatBCount
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
            this.checkBox5CoatB = new System.Windows.Forms.CheckBox();
            this.checkBox3CoatB = new System.Windows.Forms.CheckBox();
            this.checkBox2CoatB = new System.Windows.Forms.CheckBox();
            this.checkBox1CoatB = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantityOfThickener = new System.Windows.Forms.Label();
            this.labelBasicCoatQuantity = new System.Windows.Forms.Label();
            this.comboBoxUnitsCoatB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberGCoatB = new System.Windows.Forms.NumericUpDown();
            this.numberKg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.labelComponentB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelComponentC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox4CoatB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberGCoatB)).BeginInit();
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
            this.lblMin.Location = new System.Drawing.Point(104, 220);
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
            this.lblSec.Location = new System.Drawing.Point(146, 220);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(27, 13);
            this.lblSec.TabIndex = 31;
            this.lblSec.Text = "00 s";
            // 
            // checkBox5CoatB
            // 
            this.checkBox5CoatB.AutoSize = true;
            this.checkBox5CoatB.Location = new System.Drawing.Point(448, 286);
            this.checkBox5CoatB.Name = "checkBox5CoatB";
            this.checkBox5CoatB.Size = new System.Drawing.Size(57, 17);
            this.checkBox5CoatB.TabIndex = 29;
            this.checkBox5CoatB.Text = "Ready";
            this.checkBox5CoatB.UseVisualStyleBackColor = true;
            this.checkBox5CoatB.CheckedChanged += new System.EventHandler(this.checkBox5CoatB_CheckedChanged);
            // 
            // checkBox3CoatB
            // 
            this.checkBox3CoatB.AutoSize = true;
            this.checkBox3CoatB.Location = new System.Drawing.Point(448, 220);
            this.checkBox3CoatB.Name = "checkBox3CoatB";
            this.checkBox3CoatB.Size = new System.Drawing.Size(57, 17);
            this.checkBox3CoatB.TabIndex = 28;
            this.checkBox3CoatB.Text = "Ready";
            this.checkBox3CoatB.UseVisualStyleBackColor = true;
            this.checkBox3CoatB.CheckedChanged += new System.EventHandler(this.checkBox3CoatB_CheckedChanged);
            // 
            // checkBox2CoatB
            // 
            this.checkBox2CoatB.AutoSize = true;
            this.checkBox2CoatB.Location = new System.Drawing.Point(448, 188);
            this.checkBox2CoatB.Name = "checkBox2CoatB";
            this.checkBox2CoatB.Size = new System.Drawing.Size(57, 17);
            this.checkBox2CoatB.TabIndex = 27;
            this.checkBox2CoatB.Text = "Ready";
            this.checkBox2CoatB.UseVisualStyleBackColor = true;
            this.checkBox2CoatB.CheckStateChanged += new System.EventHandler(this.checkBox2CoatB_CheckStateChanged);
            // 
            // checkBox1CoatB
            // 
            this.checkBox1CoatB.AutoSize = true;
            this.checkBox1CoatB.Location = new System.Drawing.Point(448, 157);
            this.checkBox1CoatB.Name = "checkBox1CoatB";
            this.checkBox1CoatB.Size = new System.Drawing.Size(57, 17);
            this.checkBox1CoatB.TabIndex = 26;
            this.checkBox1CoatB.Text = "Ready";
            this.checkBox1CoatB.UseVisualStyleBackColor = true;
            this.checkBox1CoatB.CheckedChanged += new System.EventHandler(this.checkBox1CoatB_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "to fully mix coat and thickener in bucket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "gram of thickener to coat in bucket.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "gram of coat to metal bucket.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "5. Coat is ready to user.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "3. Wait";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "2. Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "1. Pour";
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
            this.labelBasicCoatQuantity.Location = new System.Drawing.Point(96, 158);
            this.labelBasicCoatQuantity.Name = "labelBasicCoatQuantity";
            this.labelBasicCoatQuantity.Size = new System.Drawing.Size(31, 13);
            this.labelBasicCoatQuantity.TabIndex = 17;
            this.labelBasicCoatQuantity.Text = "0000";
            // 
            // comboBoxUnitsCoatB
            // 
            this.comboBoxUnitsCoatB.AutoCompleteCustomSource.AddRange(new string[] {
            "kg",
            "g"});
            this.comboBoxUnitsCoatB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxUnitsCoatB.FormattingEnabled = true;
            this.comboBoxUnitsCoatB.Items.AddRange(new object[] {
            "kg",
            "g"});
            this.comboBoxUnitsCoatB.Location = new System.Drawing.Point(181, 107);
            this.comboBoxUnitsCoatB.Name = "comboBoxUnitsCoatB";
            this.comboBoxUnitsCoatB.Size = new System.Drawing.Size(45, 21);
            this.comboBoxUnitsCoatB.TabIndex = 15;
            this.comboBoxUnitsCoatB.SelectedValueChanged += new System.EventHandler(this.comboBoxUnitsCoatB_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(317, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coat 2";
            // 
            // numberGCoatB
            // 
            this.numberGCoatB.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberGCoatB.Location = new System.Drawing.Point(55, 108);
            this.numberGCoatB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberGCoatB.Name = "numberGCoatB";
            this.numberGCoatB.Size = new System.Drawing.Size(120, 20);
            this.numberGCoatB.TabIndex = 16;
            this.numberGCoatB.ValueChanged += new System.EventHandler(this.numberGCoatB_ValueChanged);
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
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "4. Add together";
            // 
            // labelComponentB
            // 
            this.labelComponentB.AutoSize = true;
            this.labelComponentB.Location = new System.Drawing.Point(142, 255);
            this.labelComponentB.Name = "labelComponentB";
            this.labelComponentB.Size = new System.Drawing.Size(25, 13);
            this.labelComponentB.TabIndex = 30;
            this.labelComponentB.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "gram of coat x and";
            // 
            // labelComponentC
            // 
            this.labelComponentC.AutoSize = true;
            this.labelComponentC.Location = new System.Drawing.Point(280, 255);
            this.labelComponentC.Name = "labelComponentC";
            this.labelComponentC.Size = new System.Drawing.Size(25, 13);
            this.labelComponentC.TabIndex = 30;
            this.labelComponentC.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "gram of water.";
            // 
            // checkBox4CoatB
            // 
            this.checkBox4CoatB.AutoSize = true;
            this.checkBox4CoatB.Location = new System.Drawing.Point(448, 255);
            this.checkBox4CoatB.Name = "checkBox4CoatB";
            this.checkBox4CoatB.Size = new System.Drawing.Size(57, 17);
            this.checkBox4CoatB.TabIndex = 28;
            this.checkBox4CoatB.Text = "Ready";
            this.checkBox4CoatB.UseVisualStyleBackColor = true;
            this.checkBox4CoatB.CheckedChanged += new System.EventHandler(this.checkBox4CoatB_CheckedChanged);
            // 
            // CoatBCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelComponentC);
            this.Controls.Add(this.labelComponentB);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.checkBox5CoatB);
            this.Controls.Add(this.checkBox4CoatB);
            this.Controls.Add(this.checkBox3CoatB);
            this.Controls.Add(this.checkBox2CoatB);
            this.Controls.Add(this.checkBox1CoatB);
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
            this.Controls.Add(this.comboBoxUnitsCoatB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberKg);
            this.Controls.Add(this.numberGCoatB);
            this.Name = "CoatBCount";
            this.Size = new System.Drawing.Size(758, 468);
            this.Load += new System.EventHandler(this.CoatBCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberGCoatB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCoatFinishTime;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Timer timerCoat;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.CheckBox checkBox5CoatB;
        private System.Windows.Forms.CheckBox checkBox3CoatB;
        private System.Windows.Forms.CheckBox checkBox2CoatB;
        private System.Windows.Forms.CheckBox checkBox1CoatB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantityOfThickener;
        private System.Windows.Forms.Label labelBasicCoatQuantity;
        private System.Windows.Forms.ComboBox comboBoxUnitsCoatB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberGCoatB;
        private System.Windows.Forms.NumericUpDown numberKg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelComponentB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelComponentC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox4CoatB;
    }
}
