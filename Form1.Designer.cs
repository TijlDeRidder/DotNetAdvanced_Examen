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
            // 
            // LiftMeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_liften);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_metrostation);
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
    }
}