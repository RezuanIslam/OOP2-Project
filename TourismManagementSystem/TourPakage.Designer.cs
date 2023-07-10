namespace TourismManagementSystem
{
    partial class TourPakage
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
            this.TextPakageList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TMS_Pakage_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPakageList
            // 
            this.TextPakageList.AutoSize = true;
            this.TextPakageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPakageList.Location = new System.Drawing.Point(125, 645);
            this.TextPakageList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPakageList.Name = "TextPakageList";
            this.TextPakageList.Size = new System.Drawing.Size(167, 31);
            this.TextPakageList.TabIndex = 0;
            this.TextPakageList.Text = "Pakage List";
            this.TextPakageList.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TourismManagementSystem.Properties.Resources.resized_image_Promo__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 250);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TMS_Pakage_List
            // 
            this.TMS_Pakage_List.BackColor = System.Drawing.Color.Transparent;
            this.TMS_Pakage_List.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TMS_Pakage_List.Font = new System.Drawing.Font("Colonna MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_Pakage_List.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TMS_Pakage_List.Location = new System.Drawing.Point(334, 0);
            this.TMS_Pakage_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TMS_Pakage_List.Name = "TMS_Pakage_List";
            this.TMS_Pakage_List.Size = new System.Drawing.Size(367, 55);
            this.TMS_Pakage_List.TabIndex = 3;
            this.TMS_Pakage_List.Text = "TMS - Pakage List";
            this.TMS_Pakage_List.BackColorChanged += new System.EventHandler(this.TourPakage_Load);
            this.TMS_Pakage_List.Click += new System.EventHandler(this.TMS_Pakage_List_Click_1);
            // 
            // TourPakage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.TMS_Pakage_List);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextPakageList);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TourPakage";
            this.Text = "TourPakage";
            this.Load += new System.EventHandler(this.TourPakage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPakageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TMS_Pakage_List;
    }
}