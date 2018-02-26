namespace Europaprojekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LänderCounter = new System.Windows.Forms.Label();
            this.Länder = new System.Windows.Forms.Label();
            this.HauptCounter = new System.Windows.Forms.Label();
            this.Haupt = new System.Windows.Forms.Label();
            this.LandFehlerCounter = new System.Windows.Forms.Label();
            this.HauptFalsch = new System.Windows.Forms.Label();
            this.LandFalsch = new System.Windows.Forms.Label();
            this.HauptFalschCounter = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.filePicker = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictConvertedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LänderCounter
            // 
            this.LänderCounter.AutoSize = true;
            this.LänderCounter.Location = new System.Drawing.Point(1270, 12);
            this.LänderCounter.Name = "LänderCounter";
            this.LänderCounter.Size = new System.Drawing.Size(79, 13);
            this.LänderCounter.TabIndex = 2;
            this.LänderCounter.Text = "Länder erraten:";
            // 
            // Länder
            // 
            this.Länder.AutoSize = true;
            this.Länder.Location = new System.Drawing.Point(1355, 12);
            this.Länder.Name = "Länder";
            this.Länder.Size = new System.Drawing.Size(13, 13);
            this.Länder.TabIndex = 3;
            this.Länder.Text = "0";
            // 
            // HauptCounter
            // 
            this.HauptCounter.AutoSize = true;
            this.HauptCounter.Location = new System.Drawing.Point(1245, 79);
            this.HauptCounter.Name = "HauptCounter";
            this.HauptCounter.Size = new System.Drawing.Size(104, 13);
            this.HauptCounter.TabIndex = 4;
            this.HauptCounter.Text = "Hauptstädte erraten:";
            // 
            // Haupt
            // 
            this.Haupt.AutoSize = true;
            this.Haupt.Location = new System.Drawing.Point(1355, 79);
            this.Haupt.Name = "Haupt";
            this.Haupt.Size = new System.Drawing.Size(13, 13);
            this.Haupt.TabIndex = 5;
            this.Haupt.Text = "0";
            // 
            // LandFehlerCounter
            // 
            this.LandFehlerCounter.AutoSize = true;
            this.LandFehlerCounter.Location = new System.Drawing.Point(1270, 50);
            this.LandFehlerCounter.Name = "LandFehlerCounter";
            this.LandFehlerCounter.Size = new System.Drawing.Size(77, 13);
            this.LandFehlerCounter.TabIndex = 6;
            this.LandFehlerCounter.Text = "Länder Falsch:";
            // 
            // HauptFalsch
            // 
            this.HauptFalsch.AutoSize = true;
            this.HauptFalsch.Location = new System.Drawing.Point(1355, 113);
            this.HauptFalsch.Name = "HauptFalsch";
            this.HauptFalsch.Size = new System.Drawing.Size(13, 13);
            this.HauptFalsch.TabIndex = 7;
            this.HauptFalsch.Text = "0";
            // 
            // LandFalsch
            // 
            this.LandFalsch.AutoSize = true;
            this.LandFalsch.Location = new System.Drawing.Point(1355, 50);
            this.LandFalsch.Name = "LandFalsch";
            this.LandFalsch.Size = new System.Drawing.Size(13, 13);
            this.LandFalsch.TabIndex = 8;
            this.LandFalsch.Text = "0";
            // 
            // HauptFalschCounter
            // 
            this.HauptFalschCounter.AutoSize = true;
            this.HauptFalschCounter.Location = new System.Drawing.Point(1245, 113);
            this.HauptFalschCounter.Name = "HauptFalschCounter";
            this.HauptFalschCounter.Size = new System.Drawing.Size(102, 13);
            this.HauptFalschCounter.TabIndex = 9;
            this.HauptFalschCounter.Text = "Hauptstädte Falsch:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1171, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 10;
            // 
            // filePicker
            // 
            this.filePicker.Filter = "SVG Files | *.svg";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1004, 79);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // pictConvertedImage
            // 
            this.pictConvertedImage.Location = new System.Drawing.Point(27, 50);
            this.pictConvertedImage.Name = "pictConvertedImage";
            this.pictConvertedImage.Size = new System.Drawing.Size(654, 396);
            this.pictConvertedImage.TabIndex = 13;
            this.pictConvertedImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 751);
            this.Controls.Add(this.pictConvertedImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HauptFalschCounter);
            this.Controls.Add(this.LandFalsch);
            this.Controls.Add(this.HauptFalsch);
            this.Controls.Add(this.LandFehlerCounter);
            this.Controls.Add(this.Haupt);
            this.Controls.Add(this.HauptCounter);
            this.Controls.Add(this.Länder);
            this.Controls.Add(this.LänderCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictConvertedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LänderCounter;
        private System.Windows.Forms.Label Länder;
        private System.Windows.Forms.Label HauptCounter;
        private System.Windows.Forms.Label Haupt;
        private System.Windows.Forms.Label LandFehlerCounter;
        private System.Windows.Forms.Label HauptFalsch;
        private System.Windows.Forms.Label LandFalsch;
        private System.Windows.Forms.Label HauptFalschCounter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.OpenFileDialog filePicker;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictConvertedImage;
    }
}

