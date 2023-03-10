namespace WFYolov5Net
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_detect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_object = new System.Windows.Forms.Label();
            this.lbl_pOk = new System.Windows.Forms.Label();
            this.lbl_pInvert = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.lbl_totalObj = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(436, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(666, 471);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(15, 342);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(193, 45);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load Image";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detect.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detect.Location = new System.Drawing.Point(15, 395);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(193, 44);
            this.btn_detect.TabIndex = 3;
            this.btn_detect.Text = "Detect";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process Time: 0 ms";
            // 
            // lbl_count
            // 
            this.lbl_count.Location = new System.Drawing.Point(0, 0);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(100, 19);
            this.lbl_count.TabIndex = 1;
            // 
            // lbl_object
            // 
            this.lbl_object.Location = new System.Drawing.Point(0, 0);
            this.lbl_object.Name = "lbl_object";
            this.lbl_object.Size = new System.Drawing.Size(100, 19);
            this.lbl_object.TabIndex = 0;
            // 
            // lbl_pOk
            // 
            this.lbl_pOk.AutoSize = true;
            this.lbl_pOk.Location = new System.Drawing.Point(72, 20);
            this.lbl_pOk.Name = "lbl_pOk";
            this.lbl_pOk.Size = new System.Drawing.Size(47, 11);
            this.lbl_pOk.TabIndex = 5;
            this.lbl_pOk.Text = "p_ok: 0";
            // 
            // lbl_pInvert
            // 
            this.lbl_pInvert.AutoSize = true;
            this.lbl_pInvert.Location = new System.Drawing.Point(48, 38);
            this.lbl_pInvert.Name = "lbl_pInvert";
            this.lbl_pInvert.Size = new System.Drawing.Size(71, 11);
            this.lbl_pInvert.TabIndex = 6;
            this.lbl_pInvert.Text = "p_invert: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_alert);
            this.groupBox1.Controls.Add(this.lbl_totalObj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_pOk);
            this.groupBox1.Controls.Add(this.lbl_pInvert);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(214, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETECTION DETAILS";
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(33, 107);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(40, 12);
            this.lbl_alert.TabIndex = 8;
            this.lbl_alert.Text = "     ";
            // 
            // lbl_totalObj
            // 
            this.lbl_totalObj.AutoSize = true;
            this.lbl_totalObj.Location = new System.Drawing.Point(6, 57);
            this.lbl_totalObj.Name = "lbl_totalObj";
            this.lbl_totalObj.Size = new System.Drawing.Size(113, 11);
            this.lbl_totalObj.TabIndex = 7;
            this.lbl_totalObj.Text = "Total Object(s): 0";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(15, 446);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(193, 44);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 514);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_object);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YOLOv5MLNet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_object;
        private System.Windows.Forms.Label lbl_pOk;
        private System.Windows.Forms.Label lbl_pInvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_totalObj;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

