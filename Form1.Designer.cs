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
            this.tp_toevoegen = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_isWorking_ja = new System.Windows.Forms.RadioButton();
            this.rb_isWorking_nee = new System.Windows.Forms.RadioButton();
            this.cb_metrostation_toevoegen = new System.Windows.Forms.ComboBox();
            this.l_lift_toevoegen_station = new System.Windows.Forms.Label();
            this.l_lift_toevoegen_naam = new System.Windows.Forms.Label();
            this.b_lift_toevoegen = new System.Windows.Forms.Button();
            this.l_lift_toevoegen = new System.Windows.Forms.Label();
            this.tb_lift_toevoegen_naam = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_hasElevator_ja = new System.Windows.Forms.RadioButton();
            this.rb_hasElevator_nee = new System.Windows.Forms.RadioButton();
            this.gb_accesibel = new System.Windows.Forms.GroupBox();
            this.rb_isAccesible_ja = new System.Windows.Forms.RadioButton();
            this.rb_isAccesible_nee = new System.Windows.Forms.RadioButton();
            this.l_station_toevoegen_naam = new System.Windows.Forms.Label();
            this.b_station_toevoegen = new System.Windows.Forms.Button();
            this.l_station_toevoegen = new System.Windows.Forms.Label();
            this.tb_station_toevoegen_naam = new System.Windows.Forms.TextBox();
            this.tabcontrol_app.SuspendLayout();
            this.tp_lifts.SuspendLayout();
            this.tp_meldingen.SuspendLayout();
            this.tp_toevoegen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_accesibel.SuspendLayout();
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
            this.tabcontrol_app.Controls.Add(this.tp_toevoegen);
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
            // tp_toevoegen
            // 
            this.tp_toevoegen.Controls.Add(this.panel2);
            this.tp_toevoegen.Controls.Add(this.panel1);
            this.tp_toevoegen.Location = new System.Drawing.Point(4, 24);
            this.tp_toevoegen.Name = "tp_toevoegen";
            this.tp_toevoegen.Size = new System.Drawing.Size(793, 424);
            this.tp_toevoegen.TabIndex = 2;
            this.tp_toevoegen.Text = "Toevoegen";
            this.tp_toevoegen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.cb_metrostation_toevoegen);
            this.panel2.Controls.Add(this.l_lift_toevoegen_station);
            this.panel2.Controls.Add(this.l_lift_toevoegen_naam);
            this.panel2.Controls.Add(this.b_lift_toevoegen);
            this.panel2.Controls.Add(this.l_lift_toevoegen);
            this.panel2.Controls.Add(this.tb_lift_toevoegen_naam);
            this.panel2.Location = new System.Drawing.Point(402, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 261);
            this.panel2.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_isWorking_ja);
            this.groupBox3.Controls.Add(this.rb_isWorking_nee);
            this.groupBox3.Location = new System.Drawing.Point(26, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 42);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Werkt de lift:";
            // 
            // rb_isWorking_ja
            // 
            this.rb_isWorking_ja.AutoSize = true;
            this.rb_isWorking_ja.Location = new System.Drawing.Point(10, 17);
            this.rb_isWorking_ja.Name = "rb_isWorking_ja";
            this.rb_isWorking_ja.Size = new System.Drawing.Size(35, 19);
            this.rb_isWorking_ja.TabIndex = 12;
            this.rb_isWorking_ja.TabStop = true;
            this.rb_isWorking_ja.Text = "Ja";
            this.rb_isWorking_ja.UseVisualStyleBackColor = true;
            // 
            // rb_isWorking_nee
            // 
            this.rb_isWorking_nee.AutoSize = true;
            this.rb_isWorking_nee.Location = new System.Drawing.Point(64, 17);
            this.rb_isWorking_nee.Name = "rb_isWorking_nee";
            this.rb_isWorking_nee.Size = new System.Drawing.Size(46, 19);
            this.rb_isWorking_nee.TabIndex = 12;
            this.rb_isWorking_nee.TabStop = true;
            this.rb_isWorking_nee.Text = "Nee";
            this.rb_isWorking_nee.UseVisualStyleBackColor = true;
            // 
            // cb_metrostation_toevoegen
            // 
            this.cb_metrostation_toevoegen.FormattingEnabled = true;
            this.cb_metrostation_toevoegen.Location = new System.Drawing.Point(41, 116);
            this.cb_metrostation_toevoegen.Name = "cb_metrostation_toevoegen";
            this.cb_metrostation_toevoegen.Size = new System.Drawing.Size(121, 23);
            this.cb_metrostation_toevoegen.TabIndex = 11;
            // 
            // l_lift_toevoegen_station
            // 
            this.l_lift_toevoegen_station.AutoSize = true;
            this.l_lift_toevoegen_station.Location = new System.Drawing.Point(75, 98);
            this.l_lift_toevoegen_station.Name = "l_lift_toevoegen_station";
            this.l_lift_toevoegen_station.Size = new System.Drawing.Size(47, 15);
            this.l_lift_toevoegen_station.TabIndex = 10;
            this.l_lift_toevoegen_station.Text = "Station:";
            // 
            // l_lift_toevoegen_naam
            // 
            this.l_lift_toevoegen_naam.AutoSize = true;
            this.l_lift_toevoegen_naam.Location = new System.Drawing.Point(80, 43);
            this.l_lift_toevoegen_naam.Name = "l_lift_toevoegen_naam";
            this.l_lift_toevoegen_naam.Size = new System.Drawing.Size(42, 15);
            this.l_lift_toevoegen_naam.TabIndex = 1;
            this.l_lift_toevoegen_naam.Text = "Naam:";
            // 
            // b_lift_toevoegen
            // 
            this.b_lift_toevoegen.Location = new System.Drawing.Point(51, 229);
            this.b_lift_toevoegen.Name = "b_lift_toevoegen";
            this.b_lift_toevoegen.Size = new System.Drawing.Size(100, 23);
            this.b_lift_toevoegen.TabIndex = 9;
            this.b_lift_toevoegen.Text = "Voeg Toe";
            this.b_lift_toevoegen.UseVisualStyleBackColor = true;
            this.b_lift_toevoegen.Click += new System.EventHandler(this.b_lift_toevoegen_Click);
            // 
            // l_lift_toevoegen
            // 
            this.l_lift_toevoegen.AutoSize = true;
            this.l_lift_toevoegen.Location = new System.Drawing.Point(51, 17);
            this.l_lift_toevoegen.Name = "l_lift_toevoegen";
            this.l_lift_toevoegen.Size = new System.Drawing.Size(87, 15);
            this.l_lift_toevoegen.TabIndex = 0;
            this.l_lift_toevoegen.Text = "Lift Toevoegen:";
            // 
            // tb_lift_toevoegen_naam
            // 
            this.tb_lift_toevoegen_naam.Location = new System.Drawing.Point(51, 61);
            this.tb_lift_toevoegen_naam.Name = "tb_lift_toevoegen_naam";
            this.tb_lift_toevoegen_naam.Size = new System.Drawing.Size(100, 23);
            this.tb_lift_toevoegen_naam.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.gb_accesibel);
            this.panel1.Controls.Add(this.l_station_toevoegen_naam);
            this.panel1.Controls.Add(this.b_station_toevoegen);
            this.panel1.Controls.Add(this.l_station_toevoegen);
            this.panel1.Controls.Add(this.tb_station_toevoegen_naam);
            this.panel1.Location = new System.Drawing.Point(81, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 261);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_hasElevator_ja);
            this.groupBox2.Controls.Add(this.rb_hasElevator_nee);
            this.groupBox2.Location = new System.Drawing.Point(21, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 42);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lift aanwezig:";
            // 
            // rb_hasElevator_ja
            // 
            this.rb_hasElevator_ja.AutoSize = true;
            this.rb_hasElevator_ja.Location = new System.Drawing.Point(10, 17);
            this.rb_hasElevator_ja.Name = "rb_hasElevator_ja";
            this.rb_hasElevator_ja.Size = new System.Drawing.Size(35, 19);
            this.rb_hasElevator_ja.TabIndex = 12;
            this.rb_hasElevator_ja.TabStop = true;
            this.rb_hasElevator_ja.Text = "Ja";
            this.rb_hasElevator_ja.UseVisualStyleBackColor = true;
            // 
            // rb_hasElevator_nee
            // 
            this.rb_hasElevator_nee.AutoSize = true;
            this.rb_hasElevator_nee.Location = new System.Drawing.Point(64, 17);
            this.rb_hasElevator_nee.Name = "rb_hasElevator_nee";
            this.rb_hasElevator_nee.Size = new System.Drawing.Size(46, 19);
            this.rb_hasElevator_nee.TabIndex = 12;
            this.rb_hasElevator_nee.TabStop = true;
            this.rb_hasElevator_nee.Text = "Nee";
            this.rb_hasElevator_nee.UseVisualStyleBackColor = true;
            // 
            // gb_accesibel
            // 
            this.gb_accesibel.Controls.Add(this.rb_isAccesible_ja);
            this.gb_accesibel.Controls.Add(this.rb_isAccesible_nee);
            this.gb_accesibel.Location = new System.Drawing.Point(21, 98);
            this.gb_accesibel.Name = "gb_accesibel";
            this.gb_accesibel.Size = new System.Drawing.Size(159, 42);
            this.gb_accesibel.TabIndex = 12;
            this.gb_accesibel.TabStop = false;
            this.gb_accesibel.Text = "Toegankelijk:";
            // 
            // rb_isAccesible_ja
            // 
            this.rb_isAccesible_ja.AutoSize = true;
            this.rb_isAccesible_ja.Location = new System.Drawing.Point(10, 17);
            this.rb_isAccesible_ja.Name = "rb_isAccesible_ja";
            this.rb_isAccesible_ja.Size = new System.Drawing.Size(35, 19);
            this.rb_isAccesible_ja.TabIndex = 12;
            this.rb_isAccesible_ja.TabStop = true;
            this.rb_isAccesible_ja.Text = "Ja";
            this.rb_isAccesible_ja.UseVisualStyleBackColor = true;
            // 
            // rb_isAccesible_nee
            // 
            this.rb_isAccesible_nee.AutoSize = true;
            this.rb_isAccesible_nee.Location = new System.Drawing.Point(64, 17);
            this.rb_isAccesible_nee.Name = "rb_isAccesible_nee";
            this.rb_isAccesible_nee.Size = new System.Drawing.Size(46, 19);
            this.rb_isAccesible_nee.TabIndex = 12;
            this.rb_isAccesible_nee.TabStop = true;
            this.rb_isAccesible_nee.Text = "Nee";
            this.rb_isAccesible_nee.UseVisualStyleBackColor = true;
            // 
            // l_station_toevoegen_naam
            // 
            this.l_station_toevoegen_naam.AutoSize = true;
            this.l_station_toevoegen_naam.Location = new System.Drawing.Point(80, 43);
            this.l_station_toevoegen_naam.Name = "l_station_toevoegen_naam";
            this.l_station_toevoegen_naam.Size = new System.Drawing.Size(42, 15);
            this.l_station_toevoegen_naam.TabIndex = 1;
            this.l_station_toevoegen_naam.Text = "Naam:";
            // 
            // b_station_toevoegen
            // 
            this.b_station_toevoegen.Location = new System.Drawing.Point(51, 229);
            this.b_station_toevoegen.Name = "b_station_toevoegen";
            this.b_station_toevoegen.Size = new System.Drawing.Size(100, 23);
            this.b_station_toevoegen.TabIndex = 9;
            this.b_station_toevoegen.Text = "Voeg Toe";
            this.b_station_toevoegen.UseVisualStyleBackColor = true;
            this.b_station_toevoegen.Click += new System.EventHandler(this.b_station_toevoegen_Click);
            // 
            // l_station_toevoegen
            // 
            this.l_station_toevoegen.AutoSize = true;
            this.l_station_toevoegen.Location = new System.Drawing.Point(51, 17);
            this.l_station_toevoegen.Name = "l_station_toevoegen";
            this.l_station_toevoegen.Size = new System.Drawing.Size(107, 15);
            this.l_station_toevoegen.TabIndex = 0;
            this.l_station_toevoegen.Text = "Station Toevoegen:";
            // 
            // tb_station_toevoegen_naam
            // 
            this.tb_station_toevoegen_naam.Location = new System.Drawing.Point(51, 61);
            this.tb_station_toevoegen_naam.Name = "tb_station_toevoegen_naam";
            this.tb_station_toevoegen_naam.Size = new System.Drawing.Size(100, 23);
            this.tb_station_toevoegen_naam.TabIndex = 2;
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
            this.tp_toevoegen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_accesibel.ResumeLayout(false);
            this.gb_accesibel.PerformLayout();
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
        private TabPage tp_toevoegen;
        private Panel panel2;
        private ComboBox cb_metrostation_toevoegen;
        private Label l_lift_toevoegen_station;
        private Label l_lift_toevoegen_naam;
        private Button b_lift_toevoegen;
        private Label l_lift_toevoegen;
        private TextBox tb_lift_toevoegen_naam;
        private Panel panel1;
        private Label l_station_toevoegen_naam;
        private Button b_station_toevoegen;
        private Label l_station_toevoegen;
        private TextBox tb_station_toevoegen_naam;
        private RadioButton rb_isAccesible_ja;
        private RadioButton rb_isAccesible_nee;
        private GroupBox groupBox2;
        private RadioButton rb_hasElevator_ja;
        private RadioButton rb_hasElevator_nee;
        private GroupBox gb_accesibel;
        private GroupBox groupBox3;
        private RadioButton rb_isWorking_ja;
        private RadioButton rb_isWorking_nee;
    }
}