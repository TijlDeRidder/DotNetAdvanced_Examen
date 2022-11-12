namespace DotNetAdvanced_Examen
{
    partial class LiftDefectMDI
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
            this.l_Datum = new System.Windows.Forms.Label();
            this.dtp_defect_date = new System.Windows.Forms.DateTimePicker();
            this.l_uitleg = new System.Windows.Forms.Label();
            this.rtb_uitleg = new System.Windows.Forms.RichTextBox();
            this.b_melden = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Datum
            // 
            this.l_Datum.AutoSize = true;
            this.l_Datum.Location = new System.Drawing.Point(220, 18);
            this.l_Datum.Name = "l_Datum";
            this.l_Datum.Size = new System.Drawing.Size(46, 15);
            this.l_Datum.TabIndex = 1;
            this.l_Datum.Text = "Datum:";
            // 
            // dtp_defect_date
            // 
            this.dtp_defect_date.Location = new System.Drawing.Point(146, 46);
            this.dtp_defect_date.Name = "dtp_defect_date";
            this.dtp_defect_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_defect_date.TabIndex = 2;
            // 
            // l_uitleg
            // 
            this.l_uitleg.AutoSize = true;
            this.l_uitleg.Location = new System.Drawing.Point(200, 89);
            this.l_uitleg.Name = "l_uitleg";
            this.l_uitleg.Size = new System.Drawing.Size(99, 15);
            this.l_uitleg.TabIndex = 3;
            this.l_uitleg.Text = "Korte beshrijving:";
            // 
            // rtb_uitleg
            // 
            this.rtb_uitleg.Location = new System.Drawing.Point(90, 118);
            this.rtb_uitleg.Name = "rtb_uitleg";
            this.rtb_uitleg.Size = new System.Drawing.Size(312, 84);
            this.rtb_uitleg.TabIndex = 4;
            this.rtb_uitleg.Text = "";
            // 
            // b_melden
            // 
            this.b_melden.Location = new System.Drawing.Point(116, 227);
            this.b_melden.Name = "b_melden";
            this.b_melden.Size = new System.Drawing.Size(75, 23);
            this.b_melden.TabIndex = 5;
            this.b_melden.Text = "Melden";
            this.b_melden.UseVisualStyleBackColor = true;
            this.b_melden.Click += new System.EventHandler(this.b_melden_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(295, 227);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 6;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // LiftDefectMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_melden);
            this.Controls.Add(this.rtb_uitleg);
            this.Controls.Add(this.l_uitleg);
            this.Controls.Add(this.dtp_defect_date);
            this.Controls.Add(this.l_Datum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "LiftDefectMDI";
            this.Text = "LiftDefectMDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_Datum;
        private DateTimePicker dtp_defect_date;
        private Label l_uitleg;
        private RichTextBox rtb_uitleg;
        private Button b_melden;
        private Button b_cancel;
    }
}