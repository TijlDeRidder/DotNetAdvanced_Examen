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
            this.tabcontrol_app = new System.Windows.Forms.TabControl();
            this.tp_lifts = new System.Windows.Forms.TabPage();
            this.tp_meldingen = new System.Windows.Forms.TabPage();
            this.b_fixed = new System.Windows.Forms.Button();
            this.b_vorige = new System.Windows.Forms.Button();
            this.b_volgende = new System.Windows.Forms.Button();
            this.rtb_showUitleg = new System.Windows.Forms.RichTextBox();
            this.tb_showLift = new System.Windows.Forms.TextBox();
            this.tb_showStation = new System.Windows.Forms.TextBox();
            this.tb_showDatum = new System.Windows.Forms.TextBox();
            this.l_station = new System.Windows.Forms.Label();
            this.l_lift = new System.Windows.Forms.Label();
            this.l_uitleg = new System.Windows.Forms.Label();
            this.l_Datum = new System.Windows.Forms.Label();
            this.tabcontrol_app.SuspendLayout();
            this.tp_lifts.SuspendLayout();
            this.tp_meldingen.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_metrostation
            // 
            this.cb_metrostation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metrostation.FormattingEnabled = true;
            this.cb_metrostation.Location = new System.Drawing.Point(27, 65);
            this.cb_metrostation.Name = "cb_metrostation";
            this.cb_metrostation.Size = new System.Drawing.Size(121, 23);
            this.cb_metrostation.TabIndex = 0;
            this.cb_metrostation.SelectedIndexChanged += new System.EventHandler(this.cb_metrostation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metrostation:";
            // 
            // lb_liften
            // 
            this.lb_liften.FormattingEnabled = true;
            this.lb_liften.ItemHeight = 15;
            this.lb_liften.Location = new System.Drawing.Point(27, 108);
            this.lb_liften.Name = "lb_liften";
            this.lb_liften.Size = new System.Drawing.Size(120, 94);
            this.lb_liften.TabIndex = 2;
            this.lb_liften.SelectedIndexChanged += new System.EventHandler(this.lb_liften_SelectedIndexChanged);
            // 
            // lb_liftnaam
            // 
            this.lb_liftnaam.AutoSize = true;
            this.lb_liftnaam.Location = new System.Drawing.Point(220, 47);
            this.lb_liftnaam.Name = "lb_liftnaam";
            this.lb_liftnaam.Size = new System.Drawing.Size(59, 15);
            this.lb_liftnaam.TabIndex = 3;
            this.lb_liftnaam.Text = "Naam lift:";
            this.lb_liftnaam.Visible = false;
            // 
            // tb_liftnaam
            // 
            this.tb_liftnaam.Location = new System.Drawing.Point(220, 65);
            this.tb_liftnaam.Name = "tb_liftnaam";
            this.tb_liftnaam.ReadOnly = true;
            this.tb_liftnaam.Size = new System.Drawing.Size(100, 23);
            this.tb_liftnaam.TabIndex = 4;
            this.tb_liftnaam.Visible = false;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(220, 108);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(42, 15);
            this.lb_status.TabIndex = 5;
            this.lb_status.Text = "Status:";
            this.lb_status.Visible = false;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(220, 126);
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
            this.b_defect.Location = new System.Drawing.Point(220, 168);
            this.b_defect.Name = "b_defect";
            this.b_defect.Size = new System.Drawing.Size(100, 23);
            this.b_defect.TabIndex = 7;
            this.b_defect.Text = "Defect Melden";
            this.b_defect.UseVisualStyleBackColor = false;
            this.b_defect.Visible = false;
            this.b_defect.Click += new System.EventHandler(this.b_defect_Click);
            // 
            // tabcontrol_app
            // 
            this.tabcontrol_app.Controls.Add(this.tp_lifts);
            this.tabcontrol_app.Controls.Add(this.tp_meldingen);
            this.tabcontrol_app.Location = new System.Drawing.Point(1, 1);
            this.tabcontrol_app.Name = "tabcontrol_app";
            this.tabcontrol_app.SelectedIndex = 0;
            this.tabcontrol_app.Size = new System.Drawing.Size(801, 452);
            this.tabcontrol_app.TabIndex = 9;
            // 
            // tp_lifts
            // 
            this.tp_lifts.Controls.Add(this.lb_liften);
            this.tp_lifts.Controls.Add(this.b_defect);
            this.tp_lifts.Controls.Add(this.cb_metrostation);
            this.tp_lifts.Controls.Add(this.tb_status);
            this.tp_lifts.Controls.Add(this.label1);
            this.tp_lifts.Controls.Add(this.lb_status);
            this.tp_lifts.Controls.Add(this.lb_liftnaam);
            this.tp_lifts.Controls.Add(this.tb_liftnaam);
            this.tp_lifts.Location = new System.Drawing.Point(4, 24);
            this.tp_lifts.Name = "tp_lifts";
            this.tp_lifts.Padding = new System.Windows.Forms.Padding(3);
            this.tp_lifts.Size = new System.Drawing.Size(793, 424);
            this.tp_lifts.TabIndex = 0;
            this.tp_lifts.Text = "Lifts";
            this.tp_lifts.UseVisualStyleBackColor = true;
            // 
            // tp_meldingen
            // 
            this.tp_meldingen.Controls.Add(this.b_fixed);
            this.tp_meldingen.Controls.Add(this.b_vorige);
            this.tp_meldingen.Controls.Add(this.b_volgende);
            this.tp_meldingen.Controls.Add(this.rtb_showUitleg);
            this.tp_meldingen.Controls.Add(this.tb_showLift);
            this.tp_meldingen.Controls.Add(this.tb_showStation);
            this.tp_meldingen.Controls.Add(this.tb_showDatum);
            this.tp_meldingen.Controls.Add(this.l_station);
            this.tp_meldingen.Controls.Add(this.l_lift);
            this.tp_meldingen.Controls.Add(this.l_uitleg);
            this.tp_meldingen.Controls.Add(this.l_Datum);
            this.tp_meldingen.Location = new System.Drawing.Point(4, 24);
            this.tp_meldingen.Name = "tp_meldingen";
            this.tp_meldingen.Padding = new System.Windows.Forms.Padding(3);
            this.tp_meldingen.Size = new System.Drawing.Size(793, 424);
            this.tp_meldingen.TabIndex = 1;
            this.tp_meldingen.Text = "Meldingen";
            this.tp_meldingen.UseVisualStyleBackColor = true;
            // 
            // b_fixed
            // 
            this.b_fixed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.b_fixed.Location = new System.Drawing.Point(110, 330);
            this.b_fixed.Name = "b_fixed";
            this.b_fixed.Size = new System.Drawing.Size(75, 23);
            this.b_fixed.TabIndex = 10;
            this.b_fixed.Text = "Fixed";
            this.b_fixed.UseVisualStyleBackColor = false;
            this.b_fixed.Click += new System.EventHandler(this.b_fixed_Click);
            // 
            // b_vorige
            // 
            this.b_vorige.Location = new System.Drawing.Point(57, 330);
            this.b_vorige.Name = "b_vorige";
            this.b_vorige.Size = new System.Drawing.Size(43, 23);
            this.b_vorige.TabIndex = 9;
            this.b_vorige.Text = "<";
            this.b_vorige.UseVisualStyleBackColor = true;
            this.b_vorige.Click += new System.EventHandler(this.b_vorige_Click);
            // 
            // b_volgende
            // 
            this.b_volgende.Location = new System.Drawing.Point(195, 330);
            this.b_volgende.Name = "b_volgende";
            this.b_volgende.Size = new System.Drawing.Size(43, 23);
            this.b_volgende.TabIndex = 8;
            this.b_volgende.Text = ">";
            this.b_volgende.UseVisualStyleBackColor = true;
            this.b_volgende.Click += new System.EventHandler(this.b_volgende_Click);
            // 
            // rtb_showUitleg
            // 
            this.rtb_showUitleg.Location = new System.Drawing.Point(59, 194);
            this.rtb_showUitleg.Name = "rtb_showUitleg";
            this.rtb_showUitleg.ReadOnly = true;
            this.rtb_showUitleg.Size = new System.Drawing.Size(179, 130);
            this.rtb_showUitleg.TabIndex = 7;
            this.rtb_showUitleg.Text = "";
            // 
            // tb_showLift
            // 
            this.tb_showLift.Location = new System.Drawing.Point(59, 150);
            this.tb_showLift.Name = "tb_showLift";
            this.tb_showLift.ReadOnly = true;
            this.tb_showLift.Size = new System.Drawing.Size(179, 23);
            this.tb_showLift.TabIndex = 6;
            // 
            // tb_showStation
            // 
            this.tb_showStation.Location = new System.Drawing.Point(59, 106);
            this.tb_showStation.Name = "tb_showStation";
            this.tb_showStation.ReadOnly = true;
            this.tb_showStation.Size = new System.Drawing.Size(179, 23);
            this.tb_showStation.TabIndex = 5;
            // 
            // tb_showDatum
            // 
            this.tb_showDatum.Location = new System.Drawing.Point(59, 62);
            this.tb_showDatum.Name = "tb_showDatum";
            this.tb_showDatum.ReadOnly = true;
            this.tb_showDatum.Size = new System.Drawing.Size(179, 23);
            this.tb_showDatum.TabIndex = 4;
            // 
            // l_station
            // 
            this.l_station.AutoSize = true;
            this.l_station.Location = new System.Drawing.Point(59, 88);
            this.l_station.Name = "l_station";
            this.l_station.Size = new System.Drawing.Size(47, 15);
            this.l_station.TabIndex = 3;
            this.l_station.Text = "Station:";
            // 
            // l_lift
            // 
            this.l_lift.AutoSize = true;
            this.l_lift.Location = new System.Drawing.Point(59, 132);
            this.l_lift.Name = "l_lift";
            this.l_lift.Size = new System.Drawing.Size(27, 15);
            this.l_lift.TabIndex = 2;
            this.l_lift.Text = "Lift:";
            // 
            // l_uitleg
            // 
            this.l_uitleg.AutoSize = true;
            this.l_uitleg.Location = new System.Drawing.Point(59, 176);
            this.l_uitleg.Name = "l_uitleg";
            this.l_uitleg.Size = new System.Drawing.Size(41, 15);
            this.l_uitleg.TabIndex = 1;
            this.l_uitleg.Text = "Uitleg:";
            // 
            // l_Datum
            // 
            this.l_Datum.AutoSize = true;
            this.l_Datum.Location = new System.Drawing.Point(59, 44);
            this.l_Datum.Name = "l_Datum";
            this.l_Datum.Size = new System.Drawing.Size(46, 15);
            this.l_Datum.TabIndex = 0;
            this.l_Datum.Text = "Datum:";
            // 
            // LiftMeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcontrol_app);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LiftMeUp";
            this.Text = "LiftMeUp";
            this.Load += new System.EventHandler(this.LiftMeUp_Load);
            this.tabcontrol_app.ResumeLayout(false);
            this.tp_lifts.ResumeLayout(false);
            this.tp_lifts.PerformLayout();
            this.tp_meldingen.ResumeLayout(false);
            this.tp_meldingen.PerformLayout();
            this.ResumeLayout(false);

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
        private TabControl tabcontrol_app;
        private TabPage tp_lifts;
        private TabPage tp_meldingen;
        private Button b_vorige;
        private Button b_volgende;
        private RichTextBox rtb_showUitleg;
        private TextBox tb_showLift;
        private TextBox tb_showStation;
        private TextBox tb_showDatum;
        private Label l_station;
        private Label l_lift;
        private Label l_uitleg;
        private Label l_Datum;
        private Button b_fixed;
    }
}