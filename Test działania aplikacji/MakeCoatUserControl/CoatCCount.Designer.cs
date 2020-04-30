namespace PaintshopAppUI
{
    partial class ResilonCount
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
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBasicCoatQuantity = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.labelResilon = new System.Windows.Forms.Label();
            this.numberKg = new System.Windows.Forms.NumericUpDown();
            this.numberG = new System.Windows.Forms.NumericUpDown();
            this.timerCoat = new System.Windows.Forms.Timer(this.components);
            this.timerCoatFinishTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(144, 189);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(27, 13);
            this.lblSec.TabIndex = 31;
            this.lblSec.Text = "00 s";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(102, 189);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 13);
            this.lblMin.TabIndex = 30;
            this.lblMin.Text = "00 min";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(447, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Ready";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(447, 188);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Ready";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(447, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Ready";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "to mix coat properly.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "gram of coat to metal bucket.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "4. Coat is ready to use.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "3. Wait";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "1. Pour";
            // 
            // labelBasicCoatQuantity
            // 
            this.labelBasicCoatQuantity.AutoSize = true;
            this.labelBasicCoatQuantity.Location = new System.Drawing.Point(102, 157);
            this.labelBasicCoatQuantity.Name = "labelBasicCoatQuantity";
            this.labelBasicCoatQuantity.Size = new System.Drawing.Size(31, 13);
            this.labelBasicCoatQuantity.TabIndex = 17;
            this.labelBasicCoatQuantity.Text = "0000";
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
            this.comboBoxUnits.Location = new System.Drawing.Point(180, 106);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(45, 21);
            this.comboBoxUnits.TabIndex = 15;
            this.comboBoxUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnits_SelectedIndexChanged);
            // 
            // labelResilon
            // 
            this.labelResilon.AutoSize = true;
            this.labelResilon.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.labelResilon.Location = new System.Drawing.Point(319, 53);
            this.labelResilon.Name = "labelResilon";
            this.labelResilon.Size = new System.Drawing.Size(59, 23);
            this.labelResilon.TabIndex = 13;
            this.labelResilon.Text = "Coat 3";
            // 
            // numberKg
            // 
            this.numberKg.Location = new System.Drawing.Point(54, 107);
            this.numberKg.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberKg.Name = "numberKg";
            this.numberKg.Size = new System.Drawing.Size(120, 20);
            this.numberKg.TabIndex = 14;
            this.numberKg.ValueChanged += new System.EventHandler(this.numberKg_ValueChanged);
            // 
            // numberG
            // 
            this.numberG.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberG.Location = new System.Drawing.Point(54, 107);
            this.numberG.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberG.Name = "numberG";
            this.numberG.Size = new System.Drawing.Size(120, 20);
            this.numberG.TabIndex = 16;
            this.numberG.ValueChanged += new System.EventHandler(this.numberG_ValueChanged);
            // 
            // timerCoat
            // 
            this.timerCoat.Interval = 1000;
            this.timerCoat.Tick += new System.EventHandler(this.timerCoat_Tick);
            // 
            // timerCoatFinishTime
            // 
            this.timerCoatFinishTime.Enabled = true;
            this.timerCoatFinishTime.Tick += new System.EventHandler(this.timerCoatFinishTime_Tick);
            // 
            // ResilonCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBasicCoatQuantity);
            this.Controls.Add(this.comboBoxUnits);
            this.Controls.Add(this.labelResilon);
            this.Controls.Add(this.numberG);
            this.Controls.Add(this.numberKg);
            this.Name = "ResilonCount";
            this.Size = new System.Drawing.Size(758, 468);
            this.Load += new System.EventHandler(this.ResilonCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBasicCoatQuantity;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label labelResilon;
        private System.Windows.Forms.NumericUpDown numberKg;
        private System.Windows.Forms.NumericUpDown numberG;
        private System.Windows.Forms.Timer timerCoat;
        private System.Windows.Forms.Timer timerCoatFinishTime;
    }
}
