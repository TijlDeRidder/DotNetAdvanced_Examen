namespace DotNetAdvanced_Examen
{
    partial class LiftMeUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_metrostation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_liften = new System.Windows.Forms.ListBox();
            this.lb_liftnaam = new System.Windows.Forms.Label();
            this.tb_liftnaam = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.b_defect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_metrostation
            // 
            this.cb_metrostation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metrostation.FormattingEnabled = true;
            this.cb_metrostation.Location = new System.Drawing.Point(39, 76);
            this.cb_metrostation.Name = "cb_metrostation";
            this.cb_metrostation.Size = new System.Drawing.Size(121, 23);
            this.cb_metrostation.TabIndex = 0;
            this.cb_metrostation.SelectedIndexChanged += new System.EventHandler(this.cb_metrostation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metrostation:";
            // 
            // lb_liften
            // 
            this.lb_liften.FormattingEnabled = true;
            this.lb_liften.ItemHeight = 15;
            this.lb_liften.Location = new System.Drawing.Point(39, 119);
            this.lb_liften.Name = "lb_liften";
            this.lb_liften.Size = new System.Drawing.Size(120, 94);
            this.lb_liften.TabIndex = 2;
            this.lb_liften.SelectedIndexChanged += new System.EventHandler(this.lb_liften_SelectedIndexChanged);
            // 
            // lb_liftnaam
            // 
            this.lb_liftnaam.AutoSize = true;
            this.lb_liftnaam.Location = new System.Drawing.Point(232, 58);
            this.lb_liftnaam.Name = "lb_liftnaam";
            this.lb_liftnaam.Size = new System.Drawing.Size(59, 15);
            this.lb_liftnaam.TabIndex = 3;
            this.lb_liftnaam.Text = "Naam lift:";
            this.lb_liftnaam.Visible = false;
            // 
            // tb_liftnaam
            // 
            this.tb_liftnaam.Location = new System.Drawing.Point(232, 76);
            this.tb_liftnaam.Name = "tb_liftnaam";
            this.tb_liftnaam.ReadOnly = true;
            this.tb_liftnaam.Size = new System.Drawing.Size(100, 23);
            this.tb_liftnaam.TabIndex = 4;
            this.tb_liftnaam.Visible = false;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(232, 119);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(42, 15);
            this.lb_status.TabIndex = 5;
            this.lb_status.Text = "Status:";
            this.lb_status.Visible = false;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(232, 137);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(100, 23);
            this.tb_status.TabIndex = 6;
            this.tb_status.Visible = false;
            // 
            // b_defect
            // 
            this.b_defect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b_defect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b_defect.Location = new System.Drawing.Point(232, 179);
            this.b_defect.Name = "b_defect";
            this.b_defect.Size = new System.Drawing.Size(100, 23);
            this.b_defect.TabIndex = 7;
            this.b_defect.Text = "Defect Melden";
            this.b_defect.UseVisualStyleBackColor = false;
            this.b_defect.Visible = false;
            this.b_defect.Click += new System.EventHandler(this.b_defect_Click);
            // 
            // LiftMeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_defect);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_liftnaam);
            this.Controls.Add(this.lb_liftnaam);
            this.Controls.Add(this.lb_liften);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_metrostation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LiftMeUp";
            this.Text = "LiftMeUp";
            this.Load += new System.EventHandler(this.LiftMeUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_metrostation;
        private Label label1;
        private ListBox lb_liften;
        private Label lb_liftnaam;
        private TextBox tb_liftnaam;
        private Label lb_status;
        private TextBox tb_status;
        private Button b_defect;
    }
}