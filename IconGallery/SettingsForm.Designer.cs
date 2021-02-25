
namespace SirKato.XrmToolBox.IconGallery
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numImageSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbDefaultError = new System.Windows.Forms.PictureBox();
            this.pbCurrentError = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbDefaultToBig = new System.Windows.Forms.PictureBox();
            this.pbCurrentToBig = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImageSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentError)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultToBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentToBig)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numImageSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Size";
            // 
            // numImageSize
            // 
            this.numImageSize.Location = new System.Drawing.Point(30, 56);
            this.numImageSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numImageSize.Name = "numImageSize";
            this.numImageSize.Size = new System.Drawing.Size(574, 38);
            this.numImageSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 87);
            this.label2.TabIndex = 3;
            this.label2.Text = "Define the size of the displayed images in the gallery.\r\nImages are automatically" +
    " scaled up or down.\r\nDefault Value: 32\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbDefaultError);
            this.groupBox2.Controls.Add(this.pbCurrentError);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 246);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current:";
            // 
            // pbDefaultError
            // 
            this.pbDefaultError.Location = new System.Drawing.Point(210, 161);
            this.pbDefaultError.Name = "pbDefaultError";
            this.pbDefaultError.Size = new System.Drawing.Size(53, 53);
            this.pbDefaultError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefaultError.TabIndex = 5;
            this.pbDefaultError.TabStop = false;
            // 
            // pbCurrentError
            // 
            this.pbCurrentError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCurrentError.Location = new System.Drawing.Point(210, 37);
            this.pbCurrentError.Name = "pbCurrentError";
            this.pbCurrentError.Size = new System.Drawing.Size(53, 53);
            this.pbCurrentError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentError.TabIndex = 4;
            this.pbCurrentError.TabStop = false;
            this.pbCurrentError.Click += new System.EventHandler(this.pbCurrentError_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set a custom image that gets displayed if\r\nloading of a webresource image fails.\r" +
    "\nDefault Value:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pbDefaultToBig);
            this.groupBox3.Controls.Add(this.pbCurrentToBig);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File To Big Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current:";
            // 
            // pbDefaultToBig
            // 
            this.pbDefaultToBig.Location = new System.Drawing.Point(210, 161);
            this.pbDefaultToBig.Name = "pbDefaultToBig";
            this.pbDefaultToBig.Size = new System.Drawing.Size(53, 53);
            this.pbDefaultToBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefaultToBig.TabIndex = 5;
            this.pbDefaultToBig.TabStop = false;
            // 
            // pbCurrentToBig
            // 
            this.pbCurrentToBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCurrentToBig.Location = new System.Drawing.Point(210, 37);
            this.pbCurrentToBig.Name = "pbCurrentToBig";
            this.pbCurrentToBig.Size = new System.Drawing.Size(53, 53);
            this.pbCurrentToBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentToBig.TabIndex = 4;
            this.pbCurrentToBig.TabStop = false;
            this.pbCurrentToBig.Click += new System.EventHandler(this.pbCurrentToBig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 87);
            this.label5.TabIndex = 3;
            this.label5.Text = "Set a custom image that gets displayed if\r\nthe webresource image is to big\r\nDefau" +
    "lt Value:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 783);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 63);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 783);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 63);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 783);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 63);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 871);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImageSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentError)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultToBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentToBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numImageSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbDefaultError;
        private System.Windows.Forms.PictureBox pbCurrentError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbDefaultToBig;
        private System.Windows.Forms.PictureBox pbCurrentToBig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
    }
}