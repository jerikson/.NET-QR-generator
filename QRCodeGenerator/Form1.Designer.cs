namespace QRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox_UserInput = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lbl_EnterText = new System.Windows.Forms.Label();
            this.picBox_QrCode = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QrCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_UserInput
            // 
            this.txtBox_UserInput.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserInput.Location = new System.Drawing.Point(12, 68);
            this.txtBox_UserInput.MaxLength = 25;
            this.txtBox_UserInput.Name = "txtBox_UserInput";
            this.txtBox_UserInput.Size = new System.Drawing.Size(284, 23);
            this.txtBox_UserInput.TabIndex = 0;
            this.txtBox_UserInput.TextChanged += new System.EventHandler(this.txtBox_UserInput_TextChanged);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(302, 68);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // lbl_EnterText
            // 
            this.lbl_EnterText.AutoSize = true;
            this.lbl_EnterText.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.lbl_EnterText.Location = new System.Drawing.Point(53, 33);
            this.lbl_EnterText.Name = "lbl_EnterText";
            this.lbl_EnterText.Size = new System.Drawing.Size(220, 27);
            this.lbl_EnterText.TabIndex = 0;
            this.lbl_EnterText.Text = "Enter QR Text";
            // 
            // picBox_QrCode
            // 
            this.picBox_QrCode.Location = new System.Drawing.Point(90, 19);
            this.picBox_QrCode.Name = "picBox_QrCode";
            this.picBox_QrCode.Size = new System.Drawing.Size(180, 180);
            this.picBox_QrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_QrCode.TabIndex = 2;
            this.picBox_QrCode.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox_QrCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 216);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_EnterText);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txtBox_UserInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QrCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_UserInput;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label lbl_EnterText;
        private System.Windows.Forms.PictureBox picBox_QrCode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

