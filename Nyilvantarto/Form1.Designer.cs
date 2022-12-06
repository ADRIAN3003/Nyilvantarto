
namespace Nyilvantarto
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.gbTipus = new System.Windows.Forms.GroupBox();
            this.rbBe = new System.Windows.Forms.RadioButton();
            this.rbKi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOsszeg = new System.Windows.Forms.TextBox();
            this.btnTranzakcio = new System.Windows.Forms.Button();
            this.lbEgyenleg = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTipus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tranzakciók:";
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.ItemHeight = 20;
            this.lbAdatok.Location = new System.Drawing.Point(16, 32);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(494, 324);
            this.lbAdatok.TabIndex = 1;
            // 
            // gbTipus
            // 
            this.gbTipus.Controls.Add(this.rbKi);
            this.gbTipus.Controls.Add(this.rbBe);
            this.gbTipus.Location = new System.Drawing.Point(516, 9);
            this.gbTipus.Name = "gbTipus";
            this.gbTipus.Size = new System.Drawing.Size(173, 100);
            this.gbTipus.TabIndex = 2;
            this.gbTipus.TabStop = false;
            this.gbTipus.Text = "Új tranzakció típusa";
            // 
            // rbBe
            // 
            this.rbBe.AutoSize = true;
            this.rbBe.Location = new System.Drawing.Point(31, 28);
            this.rbBe.Name = "rbBe";
            this.rbBe.Size = new System.Drawing.Size(94, 24);
            this.rbBe.TabIndex = 0;
            this.rbBe.TabStop = true;
            this.rbBe.Text = "Befizetés";
            this.rbBe.UseVisualStyleBackColor = true;
            // 
            // rbKi
            // 
            this.rbKi.AutoSize = true;
            this.rbKi.Location = new System.Drawing.Point(31, 58);
            this.rbKi.Name = "rbKi";
            this.rbKi.Size = new System.Drawing.Size(87, 24);
            this.rbKi.TabIndex = 0;
            this.rbKi.TabStop = true;
            this.rbKi.Text = "Kifizetés";
            this.rbKi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(520, 150);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(169, 26);
            this.tbNev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Egyenleg:";
            // 
            // tbOsszeg
            // 
            this.tbOsszeg.Location = new System.Drawing.Point(520, 208);
            this.tbOsszeg.Name = "tbOsszeg";
            this.tbOsszeg.Size = new System.Drawing.Size(169, 26);
            this.tbOsszeg.TabIndex = 3;
            // 
            // btnTranzakcio
            // 
            this.btnTranzakcio.Location = new System.Drawing.Point(516, 240);
            this.btnTranzakcio.Name = "btnTranzakcio";
            this.btnTranzakcio.Size = new System.Drawing.Size(173, 31);
            this.btnTranzakcio.TabIndex = 4;
            this.btnTranzakcio.Text = "Tranzakció indítása";
            this.btnTranzakcio.UseVisualStyleBackColor = true;
            // 
            // lbEgyenleg
            // 
            this.lbEgyenleg.AutoSize = true;
            this.lbEgyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEgyenleg.Location = new System.Drawing.Point(514, 312);
            this.lbEgyenleg.Name = "lbEgyenleg";
            this.lbEgyenleg.Size = new System.Drawing.Size(120, 33);
            this.lbEgyenleg.TabIndex = 0;
            this.lbEgyenleg.Text = "8000 Ft";
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(12, 362);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(498, 31);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Állapot mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(12, 399);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(498, 31);
            this.btnBetoltes.TabIndex = 4;
            this.btnBetoltes.Text = "Állapot betöltése";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Összeg:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 439);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTranzakcio);
            this.Controls.Add(this.tbOsszeg);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.gbTipus);
            this.Controls.Add(this.lbEgyenleg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osztálypénz nyilvántartása";
            this.gbTipus.ResumeLayout(false);
            this.gbTipus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.GroupBox gbTipus;
        private System.Windows.Forms.RadioButton rbKi;
        private System.Windows.Forms.RadioButton rbBe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOsszeg;
        private System.Windows.Forms.Button btnTranzakcio;
        private System.Windows.Forms.Label lbEgyenleg;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.Label label5;
    }
}

