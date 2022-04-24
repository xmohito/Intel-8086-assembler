
namespace emu8086
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moveButton = new System.Windows.Forms.Button();
            this.xchgButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axFromButton = new System.Windows.Forms.RadioButton();
            this.bxFromButton = new System.Windows.Forms.RadioButton();
            this.cxFromButton = new System.Windows.Forms.RadioButton();
            this.dxFromButton = new System.Windows.Forms.RadioButton();
            this.axToButton = new System.Windows.Forms.RadioButton();
            this.bxToButton = new System.Windows.Forms.RadioButton();
            this.cxToButton = new System.Windows.Forms.RadioButton();
            this.dxToButton = new System.Windows.Forms.RadioButton();
            this.textBoxAx = new System.Windows.Forms.TextBox();
            this.textBoxBx = new System.Windows.Forms.TextBox();
            this.textBoxCx = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.moveButton.Location = new System.Drawing.Point(196, 93);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(83, 37);
            this.moveButton.TabIndex = 0;
            this.moveButton.Text = "MOV";
            this.moveButton.UseVisualStyleBackColor = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // xchgButton
            // 
            this.xchgButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xchgButton.Location = new System.Drawing.Point(196, 147);
            this.xchgButton.Name = "xchgButton";
            this.xchgButton.Size = new System.Drawing.Size(85, 37);
            this.xchgButton.TabIndex = 1;
            this.xchgButton.Text = "XCHG";
            this.xchgButton.UseVisualStyleBackColor = false;
            this.xchgButton.Click += new System.EventHandler(this.xchgButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateButton.Location = new System.Drawing.Point(45, 204);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(105, 33);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FROM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(120, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TO:";
            // 
            // axFromButton
            // 
            this.axFromButton.AutoSize = true;
            this.axFromButton.Location = new System.Drawing.Point(19, 8);
            this.axFromButton.Name = "axFromButton";
            this.axFromButton.Size = new System.Drawing.Size(39, 17);
            this.axFromButton.TabIndex = 11;
            this.axFromButton.TabStop = true;
            this.axFromButton.Text = "AX";
            this.axFromButton.UseVisualStyleBackColor = true;
            // 
            // bxFromButton
            // 
            this.bxFromButton.AutoSize = true;
            this.bxFromButton.Location = new System.Drawing.Point(19, 31);
            this.bxFromButton.Name = "bxFromButton";
            this.bxFromButton.Size = new System.Drawing.Size(39, 17);
            this.bxFromButton.TabIndex = 12;
            this.bxFromButton.TabStop = true;
            this.bxFromButton.Text = "BX";
            this.bxFromButton.UseVisualStyleBackColor = true;
            // 
            // cxFromButton
            // 
            this.cxFromButton.AutoSize = true;
            this.cxFromButton.Location = new System.Drawing.Point(19, 54);
            this.cxFromButton.Name = "cxFromButton";
            this.cxFromButton.Size = new System.Drawing.Size(39, 17);
            this.cxFromButton.TabIndex = 13;
            this.cxFromButton.TabStop = true;
            this.cxFromButton.Text = "CX";
            this.cxFromButton.UseVisualStyleBackColor = true;
            // 
            // dxFromButton
            // 
            this.dxFromButton.AutoSize = true;
            this.dxFromButton.Location = new System.Drawing.Point(19, 77);
            this.dxFromButton.Name = "dxFromButton";
            this.dxFromButton.Size = new System.Drawing.Size(40, 17);
            this.dxFromButton.TabIndex = 14;
            this.dxFromButton.TabStop = true;
            this.dxFromButton.Text = "DX";
            this.dxFromButton.UseVisualStyleBackColor = true;
            // 
            // axToButton
            // 
            this.axToButton.AutoSize = true;
            this.axToButton.Location = new System.Drawing.Point(3, 8);
            this.axToButton.Name = "axToButton";
            this.axToButton.Size = new System.Drawing.Size(39, 17);
            this.axToButton.TabIndex = 15;
            this.axToButton.TabStop = true;
            this.axToButton.Text = "AX";
            this.axToButton.UseVisualStyleBackColor = true;
            // 
            // bxToButton
            // 
            this.bxToButton.AutoSize = true;
            this.bxToButton.Location = new System.Drawing.Point(3, 31);
            this.bxToButton.Name = "bxToButton";
            this.bxToButton.Size = new System.Drawing.Size(39, 17);
            this.bxToButton.TabIndex = 16;
            this.bxToButton.TabStop = true;
            this.bxToButton.Text = "BX";
            this.bxToButton.UseVisualStyleBackColor = true;
            // 
            // cxToButton
            // 
            this.cxToButton.AutoSize = true;
            this.cxToButton.Location = new System.Drawing.Point(3, 54);
            this.cxToButton.Name = "cxToButton";
            this.cxToButton.Size = new System.Drawing.Size(39, 17);
            this.cxToButton.TabIndex = 17;
            this.cxToButton.TabStop = true;
            this.cxToButton.Text = "CX";
            this.cxToButton.UseVisualStyleBackColor = true;
            // 
            // dxToButton
            // 
            this.dxToButton.AutoSize = true;
            this.dxToButton.Location = new System.Drawing.Point(2, 77);
            this.dxToButton.Name = "dxToButton";
            this.dxToButton.Size = new System.Drawing.Size(40, 17);
            this.dxToButton.TabIndex = 18;
            this.dxToButton.TabStop = true;
            this.dxToButton.Text = "DX";
            this.dxToButton.UseVisualStyleBackColor = true;
            // 
            // textBoxAx
            // 
            this.textBoxAx.Location = new System.Drawing.Point(45, 83);
            this.textBoxAx.Name = "textBoxAx";
            this.textBoxAx.Size = new System.Drawing.Size(100, 20);
            this.textBoxAx.TabIndex = 19;
            // 
            // textBoxBx
            // 
            this.textBoxBx.Location = new System.Drawing.Point(45, 110);
            this.textBoxBx.Name = "textBoxBx";
            this.textBoxBx.Size = new System.Drawing.Size(100, 20);
            this.textBoxBx.TabIndex = 20;
            // 
            // textBoxCx
            // 
            this.textBoxCx.Location = new System.Drawing.Point(45, 137);
            this.textBoxCx.Name = "textBoxCx";
            this.textBoxCx.Size = new System.Drawing.Size(100, 20);
            this.textBoxCx.TabIndex = 21;
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(45, 163);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(100, 20);
            this.textBoxDx.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axFromButton);
            this.panel1.Controls.Add(this.bxFromButton);
            this.panel1.Controls.Add(this.cxFromButton);
            this.panel1.Controls.Add(this.dxFromButton);
            this.panel1.Location = new System.Drawing.Point(34, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 98);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cxToButton);
            this.panel2.Controls.Add(this.axToButton);
            this.panel2.Controls.Add(this.bxToButton);
            this.panel2.Controls.Add(this.dxToButton);
            this.panel2.Location = new System.Drawing.Point(145, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 98);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::emu8086.Properties.Resources.Intel_Inside_Logo__2003_2006__svg;
            this.pictureBox1.InitialImage = global::emu8086.Properties.Resources.intel;
            this.pictureBox1.Location = new System.Drawing.Point(323, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(12, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(162, 18);
            this.Title.TabIndex = 27;
            this.Title.Text = "Intel 8086 simulation";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(430, 457);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.textBoxCx);
            this.Controls.Add(this.textBoxBx);
            this.Controls.Add(this.textBoxAx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.xchgButton);
            this.Controls.Add(this.moveButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Intel 8086";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button xchgButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton axFromButton;
        private System.Windows.Forms.RadioButton bxFromButton;
        private System.Windows.Forms.RadioButton cxFromButton;
        private System.Windows.Forms.RadioButton dxFromButton;
        private System.Windows.Forms.RadioButton axToButton;
        private System.Windows.Forms.RadioButton bxToButton;
        private System.Windows.Forms.RadioButton cxToButton;
        private System.Windows.Forms.RadioButton dxToButton;
        private System.Windows.Forms.TextBox textBoxAx;
        private System.Windows.Forms.TextBox textBoxBx;
        private System.Windows.Forms.TextBox textBoxCx;
        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
    }
}

