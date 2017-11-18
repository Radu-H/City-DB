namespace Oras_User
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.user = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.log_out = new System.Windows.Forms.Button();
            this.log_in = new System.Windows.Forms.Button();
            this.user_nou = new System.Windows.Forms.Button();
            this.user_lb = new System.Windows.Forms.Label();
            this.passw_lb = new System.Windows.Forms.Label();
            this.exct_bt = new System.Windows.Forms.Button();
            this.nume = new System.Windows.Forms.TextBox();
            this.pren = new System.Windows.Forms.TextBox();
            this.nume_lb = new System.Windows.Forms.Label();
            this.pren_lb = new System.Windows.Forms.Label();
            this.vr_pers = new System.Windows.Forms.Button();
            this.nr_sex = new System.Windows.Forms.Button();
            this.nr_minor = new System.Windows.Forms.Button();
            this.pens = new System.Windows.Forms.Button();
            this.loc_str = new System.Windows.Forms.Button();
            this.vr_sex_oras = new System.Windows.Forms.Button();
            this.vr_sex_str = new System.Windows.Forms.Button();
            this.vr_sex_adresa = new System.Windows.Forms.Button();
            this.max_loc = new System.Windows.Forms.Button();
            this.zi_luna = new System.Windows.Forms.Button();
            this.nascuti = new System.Windows.Forms.Button();
            this.bk_bt = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.RichTextBox();
            this.nr = new System.Windows.Forms.TextBox();
            this.str_lb = new System.Windows.Forms.Label();
            this.nr_lb = new System.Windows.Forms.Label();
            this.sc_lb = new System.Windows.Forms.Label();
            this.ap_lb = new System.Windows.Forms.Label();
            this.scara = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.strada = new System.Windows.Forms.ComboBox();
            this.vr_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.adresa = new System.Windows.Forms.ComboBox();
            this.ad_lb = new System.Windows.Forms.Label();
            this.sex_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_lb = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.mail_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vr_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sex_ch)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(330, 31);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(111, 20);
            this.user.TabIndex = 0;
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(330, 57);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(111, 20);
            this.passw.TabIndex = 1;
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(447, 16);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(77, 28);
            this.log_out.TabIndex = 2;
            this.log_out.Text = "Log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Visible = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(447, 53);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(77, 24);
            this.log_in.TabIndex = 3;
            this.log_in.Text = "Log In";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            // 
            // user_nou
            // 
            this.user_nou.Location = new System.Drawing.Point(447, 83);
            this.user_nou.Name = "user_nou";
            this.user_nou.Size = new System.Drawing.Size(77, 26);
            this.user_nou.TabIndex = 4;
            this.user_nou.Text = "User nou";
            this.user_nou.UseVisualStyleBackColor = true;
            this.user_nou.Click += new System.EventHandler(this.user_nou_Click);
            // 
            // user_lb
            // 
            this.user_lb.AutoSize = true;
            this.user_lb.Location = new System.Drawing.Point(290, 34);
            this.user_lb.Name = "user_lb";
            this.user_lb.Size = new System.Drawing.Size(32, 13);
            this.user_lb.TabIndex = 5;
            this.user_lb.Text = "User:";
            // 
            // passw_lb
            // 
            this.passw_lb.AutoSize = true;
            this.passw_lb.Location = new System.Drawing.Point(282, 60);
            this.passw_lb.Name = "passw_lb";
            this.passw_lb.Size = new System.Drawing.Size(40, 13);
            this.passw_lb.TabIndex = 6;
            this.passw_lb.Text = "Parola:";
            // 
            // exct_bt
            // 
            this.exct_bt.Location = new System.Drawing.Point(452, 511);
            this.exct_bt.Name = "exct_bt";
            this.exct_bt.Size = new System.Drawing.Size(79, 34);
            this.exct_bt.TabIndex = 7;
            this.exct_bt.Text = "Ok";
            this.exct_bt.UseVisualStyleBackColor = true;
            this.exct_bt.Visible = false;
            this.exct_bt.Click += new System.EventHandler(this.exct_bt_Click);
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(330, 83);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(111, 20);
            this.nume.TabIndex = 8;
            this.nume.Visible = false;
            // 
            // pren
            // 
            this.pren.Location = new System.Drawing.Point(330, 109);
            this.pren.Name = "pren";
            this.pren.Size = new System.Drawing.Size(111, 20);
            this.pren.TabIndex = 9;
            this.pren.Visible = false;
            // 
            // nume_lb
            // 
            this.nume_lb.AutoSize = true;
            this.nume_lb.Location = new System.Drawing.Point(284, 86);
            this.nume_lb.Name = "nume_lb";
            this.nume_lb.Size = new System.Drawing.Size(38, 13);
            this.nume_lb.TabIndex = 10;
            this.nume_lb.Text = "Nume:";
            this.nume_lb.Visible = false;
            // 
            // pren_lb
            // 
            this.pren_lb.AutoSize = true;
            this.pren_lb.Location = new System.Drawing.Point(270, 112);
            this.pren_lb.Name = "pren_lb";
            this.pren_lb.Size = new System.Drawing.Size(52, 13);
            this.pren_lb.TabIndex = 11;
            this.pren_lb.Text = "Prenume:";
            this.pren_lb.Visible = false;
            // 
            // vr_pers
            // 
            this.vr_pers.Location = new System.Drawing.Point(19, 13);
            this.vr_pers.Name = "vr_pers";
            this.vr_pers.Size = new System.Drawing.Size(99, 38);
            this.vr_pers.TabIndex = 12;
            this.vr_pers.Text = "Cea mai invarsta persoana";
            this.vr_pers.UseVisualStyleBackColor = true;
            this.vr_pers.Visible = false;
            this.vr_pers.Click += new System.EventHandler(this.vr_pers_Click);
            // 
            // nr_sex
            // 
            this.nr_sex.Location = new System.Drawing.Point(19, 57);
            this.nr_sex.Name = "nr_sex";
            this.nr_sex.Size = new System.Drawing.Size(99, 37);
            this.nr_sex.TabIndex = 13;
            this.nr_sex.Text = "Nr. femei / Nr. barbati";
            this.nr_sex.UseVisualStyleBackColor = true;
            this.nr_sex.Visible = false;
            this.nr_sex.Click += new System.EventHandler(this.nr_sex_Click);
            // 
            // nr_minor
            // 
            this.nr_minor.Location = new System.Drawing.Point(19, 100);
            this.nr_minor.Name = "nr_minor";
            this.nr_minor.Size = new System.Drawing.Size(99, 30);
            this.nr_minor.TabIndex = 14;
            this.nr_minor.Text = "Nr. Minori";
            this.nr_minor.UseVisualStyleBackColor = true;
            this.nr_minor.Visible = false;
            this.nr_minor.Click += new System.EventHandler(this.nr_minor_Click);
            // 
            // pens
            // 
            this.pens.Location = new System.Drawing.Point(19, 136);
            this.pens.Name = "pens";
            this.pens.Size = new System.Drawing.Size(99, 33);
            this.pens.TabIndex = 15;
            this.pens.Text = "Pensionari";
            this.pens.UseVisualStyleBackColor = true;
            this.pens.Visible = false;
            this.pens.Click += new System.EventHandler(this.pens_Click);
            // 
            // loc_str
            // 
            this.loc_str.Location = new System.Drawing.Point(19, 175);
            this.loc_str.Name = "loc_str";
            this.loc_str.Size = new System.Drawing.Size(99, 28);
            this.loc_str.TabIndex = 16;
            this.loc_str.Text = "Locatari strada";
            this.loc_str.UseVisualStyleBackColor = true;
            this.loc_str.Visible = false;
            this.loc_str.Click += new System.EventHandler(this.loc_str_Click);
            // 
            // vr_sex_oras
            // 
            this.vr_sex_oras.Location = new System.Drawing.Point(19, 209);
            this.vr_sex_oras.Name = "vr_sex_oras";
            this.vr_sex_oras.Size = new System.Drawing.Size(99, 41);
            this.vr_sex_oras.TabIndex = 17;
            this.vr_sex_oras.Text = "Statistica varsta/sex oras";
            this.vr_sex_oras.UseVisualStyleBackColor = true;
            this.vr_sex_oras.Visible = false;
            this.vr_sex_oras.Click += new System.EventHandler(this.vr_sex_oras_Click);
            // 
            // vr_sex_str
            // 
            this.vr_sex_str.Location = new System.Drawing.Point(19, 256);
            this.vr_sex_str.Name = "vr_sex_str";
            this.vr_sex_str.Size = new System.Drawing.Size(99, 35);
            this.vr_sex_str.TabIndex = 18;
            this.vr_sex_str.Text = "Statistica varsta/sex strada";
            this.vr_sex_str.UseVisualStyleBackColor = true;
            this.vr_sex_str.Visible = false;
            this.vr_sex_str.Click += new System.EventHandler(this.vr_sex_str_Click);
            // 
            // vr_sex_adresa
            // 
            this.vr_sex_adresa.Location = new System.Drawing.Point(19, 297);
            this.vr_sex_adresa.Name = "vr_sex_adresa";
            this.vr_sex_adresa.Size = new System.Drawing.Size(99, 54);
            this.vr_sex_adresa.TabIndex = 19;
            this.vr_sex_adresa.Text = "Statistica varsta/sex adresa";
            this.vr_sex_adresa.UseVisualStyleBackColor = true;
            this.vr_sex_adresa.Visible = false;
            this.vr_sex_adresa.Click += new System.EventHandler(this.vr_sex_adresa_Click);
            // 
            // max_loc
            // 
            this.max_loc.Location = new System.Drawing.Point(19, 357);
            this.max_loc.Name = "max_loc";
            this.max_loc.Size = new System.Drawing.Size(99, 41);
            this.max_loc.TabIndex = 20;
            this.max_loc.Text = "Cei mai multi locatari";
            this.max_loc.UseVisualStyleBackColor = true;
            this.max_loc.Visible = false;
            this.max_loc.Click += new System.EventHandler(this.max_loc_Click);
            // 
            // zi_luna
            // 
            this.zi_luna.Location = new System.Drawing.Point(19, 404);
            this.zi_luna.Name = "zi_luna";
            this.zi_luna.Size = new System.Drawing.Size(99, 40);
            this.zi_luna.TabIndex = 21;
            this.zi_luna.Text = "Informatii nascuti zi/luna";
            this.zi_luna.UseVisualStyleBackColor = true;
            this.zi_luna.Visible = false;
            this.zi_luna.Click += new System.EventHandler(this.zi_luna_Click);
            // 
            // nascuti
            // 
            this.nascuti.Location = new System.Drawing.Point(19, 450);
            this.nascuti.Name = "nascuti";
            this.nascuti.Size = new System.Drawing.Size(99, 36);
            this.nascuti.TabIndex = 22;
            this.nascuti.Text = "Statistica zile nastere";
            this.nascuti.UseVisualStyleBackColor = true;
            this.nascuti.Visible = false;
            this.nascuti.Click += new System.EventHandler(this.nascuti_Click);
            // 
            // bk_bt
            // 
            this.bk_bt.Location = new System.Drawing.Point(12, 521);
            this.bk_bt.Name = "bk_bt";
            this.bk_bt.Size = new System.Drawing.Size(75, 24);
            this.bk_bt.TabIndex = 23;
            this.bk_bt.Text = "Inapoi";
            this.bk_bt.UseVisualStyleBackColor = true;
            this.bk_bt.Visible = false;
            this.bk_bt.Click += new System.EventHandler(this.bk_bt_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(241, 253);
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(263, 145);
            this.rez.TabIndex = 24;
            this.rez.Text = "";
            this.rez.Visible = false;
            // 
            // nr
            // 
            this.nr.Location = new System.Drawing.Point(302, 162);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(37, 20);
            this.nr.TabIndex = 26;
            this.nr.Visible = false;
            // 
            // str_lb
            // 
            this.str_lb.AutoSize = true;
            this.str_lb.Location = new System.Drawing.Point(281, 139);
            this.str_lb.Name = "str_lb";
            this.str_lb.Size = new System.Drawing.Size(41, 13);
            this.str_lb.TabIndex = 27;
            this.str_lb.Text = "Strada:";
            this.str_lb.Visible = false;
            // 
            // nr_lb
            // 
            this.nr_lb.AutoSize = true;
            this.nr_lb.Location = new System.Drawing.Point(270, 165);
            this.nr_lb.Name = "nr_lb";
            this.nr_lb.Size = new System.Drawing.Size(21, 13);
            this.nr_lb.TabIndex = 28;
            this.nr_lb.Text = "Nr.";
            this.nr_lb.Visible = false;
            // 
            // sc_lb
            // 
            this.sc_lb.AutoSize = true;
            this.sc_lb.Location = new System.Drawing.Point(343, 165);
            this.sc_lb.Name = "sc_lb";
            this.sc_lb.Size = new System.Drawing.Size(38, 13);
            this.sc_lb.TabIndex = 29;
            this.sc_lb.Text = "Scara:";
            this.sc_lb.Visible = false;
            // 
            // ap_lb
            // 
            this.ap_lb.AutoSize = true;
            this.ap_lb.Location = new System.Drawing.Point(428, 165);
            this.ap_lb.Name = "ap_lb";
            this.ap_lb.Size = new System.Drawing.Size(23, 13);
            this.ap_lb.TabIndex = 30;
            this.ap_lb.Text = "Ap.";
            this.ap_lb.Visible = false;
            // 
            // scara
            // 
            this.scara.Location = new System.Drawing.Point(385, 162);
            this.scara.Name = "scara";
            this.scara.Size = new System.Drawing.Size(37, 20);
            this.scara.TabIndex = 31;
            this.scara.Visible = false;
            // 
            // ap
            // 
            this.ap.Location = new System.Drawing.Point(452, 162);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(37, 20);
            this.ap.TabIndex = 32;
            this.ap.Visible = false;
            // 
            // strada
            // 
            this.strada.DisplayMember = "Adresa";
            this.strada.FormattingEnabled = true;
            this.strada.Location = new System.Drawing.Point(330, 135);
            this.strada.Name = "strada";
            this.strada.Size = new System.Drawing.Size(159, 21);
            this.strada.TabIndex = 33;
            this.strada.ValueMember = "ID";
            this.strada.Visible = false;
            this.strada.SelectionChangeCommitted += new System.EventHandler(this.strada_SelectedIndexChanged);
            // 
            // vr_ch
            // 
            chartArea1.Name = "ChartArea1";
            this.vr_ch.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.vr_ch.Legends.Add(legend1);
            this.vr_ch.Location = new System.Drawing.Point(12, 237);
            this.vr_ch.Name = "vr_ch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Locuitori";
            this.vr_ch.Series.Add(series1);
            this.vr_ch.Size = new System.Drawing.Size(519, 170);
            this.vr_ch.TabIndex = 34;
            this.vr_ch.Text = "Grupe Varsta";
            this.vr_ch.Visible = false;
            // 
            // adresa
            // 
            this.adresa.DisplayMember = "Adresa";
            this.adresa.FormattingEnabled = true;
            this.adresa.Location = new System.Drawing.Point(330, 188);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(159, 21);
            this.adresa.TabIndex = 35;
            this.adresa.ValueMember = "ID";
            this.adresa.Visible = false;
            // 
            // ad_lb
            // 
            this.ad_lb.AutoSize = true;
            this.ad_lb.Location = new System.Drawing.Point(279, 191);
            this.ad_lb.Name = "ad_lb";
            this.ad_lb.Size = new System.Drawing.Size(43, 13);
            this.ad_lb.TabIndex = 36;
            this.ad_lb.Text = "Adresa:";
            this.ad_lb.Visible = false;
            // 
            // sex_ch
            // 
            chartArea2.Name = "ChartArea1";
            this.sex_ch.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.sex_ch.Legends.Add(legend2);
            this.sex_ch.Location = new System.Drawing.Point(137, 34);
            this.sex_ch.Name = "sex_ch";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Locuitori";
            this.sex_ch.Series.Add(series2);
            this.sex_ch.Size = new System.Drawing.Size(295, 159);
            this.sex_ch.TabIndex = 37;
            this.sex_ch.Text = "chart1";
            this.sex_ch.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(68, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Visible = false;
            // 
            // data_lb
            // 
            this.data_lb.AutoSize = true;
            this.data_lb.Location = new System.Drawing.Point(285, 228);
            this.data_lb.Name = "data_lb";
            this.data_lb.Size = new System.Drawing.Size(33, 13);
            this.data_lb.TabIndex = 39;
            this.data_lb.Text = "Data:";
            this.data_lb.Visible = false;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(156, 100);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(92, 20);
            this.mail.TabIndex = 40;
            this.mail.Visible = false;
            // 
            // mail_lb
            // 
            this.mail_lb.AutoSize = true;
            this.mail_lb.Location = new System.Drawing.Point(182, 84);
            this.mail_lb.Name = "mail_lb";
            this.mail_lb.Size = new System.Drawing.Size(38, 13);
            this.mail_lb.TabIndex = 41;
            this.mail_lb.Text = "E-mail:";
            this.mail_lb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 557);
            this.Controls.Add(this.mail_lb);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.data_lb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ad_lb);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.strada);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.scara);
            this.Controls.Add(this.ap_lb);
            this.Controls.Add(this.sc_lb);
            this.Controls.Add(this.nr_lb);
            this.Controls.Add(this.str_lb);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.bk_bt);
            this.Controls.Add(this.nascuti);
            this.Controls.Add(this.zi_luna);
            this.Controls.Add(this.max_loc);
            this.Controls.Add(this.vr_sex_adresa);
            this.Controls.Add(this.vr_sex_str);
            this.Controls.Add(this.vr_sex_oras);
            this.Controls.Add(this.loc_str);
            this.Controls.Add(this.pens);
            this.Controls.Add(this.nr_minor);
            this.Controls.Add(this.nr_sex);
            this.Controls.Add(this.vr_pers);
            this.Controls.Add(this.pren_lb);
            this.Controls.Add(this.nume_lb);
            this.Controls.Add(this.pren);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.exct_bt);
            this.Controls.Add(this.passw_lb);
            this.Controls.Add(this.user_lb);
            this.Controls.Add(this.user_nou);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.vr_ch);
            this.Controls.Add(this.sex_ch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vr_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sex_ch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button user_nou;
        private System.Windows.Forms.Label user_lb;
        private System.Windows.Forms.Label passw_lb;
        private System.Windows.Forms.Button exct_bt;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox pren;
        private System.Windows.Forms.Label nume_lb;
        private System.Windows.Forms.Label pren_lb;
        private System.Windows.Forms.Button vr_pers;
        private System.Windows.Forms.Button nr_sex;
        private System.Windows.Forms.Button nr_minor;
        private System.Windows.Forms.Button pens;
        private System.Windows.Forms.Button loc_str;
        private System.Windows.Forms.Button vr_sex_oras;
        private System.Windows.Forms.Button vr_sex_str;
        private System.Windows.Forms.Button vr_sex_adresa;
        private System.Windows.Forms.Button max_loc;
        private System.Windows.Forms.Button zi_luna;
        private System.Windows.Forms.Button nascuti;
        private System.Windows.Forms.Button bk_bt;
        private System.Windows.Forms.RichTextBox rez;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Label str_lb;
        private System.Windows.Forms.Label nr_lb;
        private System.Windows.Forms.Label sc_lb;
        private System.Windows.Forms.Label ap_lb;
        private System.Windows.Forms.TextBox scara;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.ComboBox strada;
        private System.Windows.Forms.DataVisualization.Charting.Chart vr_ch;
        private System.Windows.Forms.ComboBox adresa;
        private System.Windows.Forms.Label ad_lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart sex_ch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label data_lb;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label mail_lb;
    }
}

