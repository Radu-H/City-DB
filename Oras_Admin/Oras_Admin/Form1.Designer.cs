namespace Oras_Admin
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
            this.user = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.user_lb = new System.Windows.Forms.Label();
            this.passw_lb = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.Button();
            this.ad_bt = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.sterge_bt = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.exct_bt = new System.Windows.Forms.Button();
            this.bk_bt = new System.Windows.Forms.Button();
            this.da_bt = new System.Windows.Forms.Button();
            this.nu_bt = new System.Windows.Forms.Button();
            this.nume = new System.Windows.Forms.TextBox();
            this.pren = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nume_lb = new System.Windows.Forms.Label();
            this.pren_lb = new System.Windows.Forms.Label();
            this.dn_lb = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.sex_lb = new System.Windows.Forms.Label();
            this.nr = new System.Windows.Forms.TextBox();
            this.scara = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.tip_strada = new System.Windows.Forms.TextBox();
            this.nr_lb = new System.Windows.Forms.Label();
            this.sc_lb = new System.Windows.Forms.Label();
            this.ap_lb = new System.Windows.Forms.Label();
            this.tip_lb = new System.Windows.Forms.Label();
            this.strada_lb = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.ComboBox();
            this.adresa_lb = new System.Windows.Forms.Label();
            this.strada = new System.Windows.Forms.ComboBox();
            this.pers = new System.Windows.Forms.ComboBox();
            this.pers_lb = new System.Windows.Forms.Label();
            this.actv_user = new System.Windows.Forms.Button();
            this.mes_user = new System.Windows.Forms.Button();
            this.user_drop = new System.Windows.Forms.ComboBox();
            this.sub = new System.Windows.Forms.TextBox();
            this.mes = new System.Windows.Forms.RichTextBox();
            this.sub_lb = new System.Windows.Forms.Label();
            this.mes_lb = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.ComboBox();
            this.dest_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(415, 47);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(113, 20);
            this.user.TabIndex = 0;
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(415, 73);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(113, 20);
            this.passw.TabIndex = 1;
            // 
            // user_lb
            // 
            this.user_lb.AutoSize = true;
            this.user_lb.Location = new System.Drawing.Point(316, 51);
            this.user_lb.Name = "user_lb";
            this.user_lb.Size = new System.Drawing.Size(35, 13);
            this.user_lb.TabIndex = 2;
            this.user_lb.Text = "User :";
            // 
            // passw_lb
            // 
            this.passw_lb.AutoSize = true;
            this.passw_lb.Location = new System.Drawing.Point(316, 76);
            this.passw_lb.Name = "passw_lb";
            this.passw_lb.Size = new System.Drawing.Size(43, 13);
            this.passw_lb.TabIndex = 3;
            this.passw_lb.Text = "Parola :";
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(545, 51);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(56, 26);
            this.log_in.TabIndex = 4;
            this.log_in.Text = "Log In";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.lob_in_bt_Click);
            // 
            // ad_bt
            // 
            this.ad_bt.Location = new System.Drawing.Point(12, 13);
            this.ad_bt.Name = "ad_bt";
            this.ad_bt.Size = new System.Drawing.Size(97, 60);
            this.ad_bt.TabIndex = 5;
            this.ad_bt.Text = "Adaugare";
            this.ad_bt.UseVisualStyleBackColor = true;
            this.ad_bt.Visible = false;
            this.ad_bt.Click += new System.EventHandler(this.ad_bt_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(12, 76);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(97, 56);
            this.edit.TabIndex = 6;
            this.edit.Text = "Editare";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // sterge_bt
            // 
            this.sterge_bt.Location = new System.Drawing.Point(12, 135);
            this.sterge_bt.Name = "sterge_bt";
            this.sterge_bt.Size = new System.Drawing.Size(97, 56);
            this.sterge_bt.TabIndex = 7;
            this.sterge_bt.Text = "Sterge";
            this.sterge_bt.UseVisualStyleBackColor = true;
            this.sterge_bt.Visible = false;
            this.sterge_bt.Click += new System.EventHandler(this.sterge_bt_Click);
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(563, 12);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(66, 31);
            this.log_out.TabIndex = 8;
            this.log_out.Text = "Log Out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Visible = false;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // exct_bt
            // 
            this.exct_bt.Location = new System.Drawing.Point(541, 539);
            this.exct_bt.Name = "exct_bt";
            this.exct_bt.Size = new System.Drawing.Size(87, 35);
            this.exct_bt.TabIndex = 9;
            this.exct_bt.Text = "Executa";
            this.exct_bt.UseVisualStyleBackColor = true;
            this.exct_bt.Visible = false;
            this.exct_bt.Click += new System.EventHandler(this.exct_bt_Click);
            // 
            // bk_bt
            // 
            this.bk_bt.Location = new System.Drawing.Point(12, 536);
            this.bk_bt.Name = "bk_bt";
            this.bk_bt.Size = new System.Drawing.Size(87, 35);
            this.bk_bt.TabIndex = 10;
            this.bk_bt.Text = "Back";
            this.bk_bt.UseVisualStyleBackColor = true;
            this.bk_bt.Visible = false;
            this.bk_bt.Click += new System.EventHandler(this.bk_bt_Click);
            // 
            // da_bt
            // 
            this.da_bt.Location = new System.Drawing.Point(574, 507);
            this.da_bt.Name = "da_bt";
            this.da_bt.Size = new System.Drawing.Size(54, 26);
            this.da_bt.TabIndex = 11;
            this.da_bt.Text = "Da";
            this.da_bt.UseVisualStyleBackColor = true;
            this.da_bt.Visible = false;
            // 
            // nu_bt
            // 
            this.nu_bt.Location = new System.Drawing.Point(514, 507);
            this.nu_bt.Name = "nu_bt";
            this.nu_bt.Size = new System.Drawing.Size(54, 26);
            this.nu_bt.TabIndex = 12;
            this.nu_bt.Text = "Nu";
            this.nu_bt.UseVisualStyleBackColor = true;
            this.nu_bt.Visible = false;
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(395, 123);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(122, 20);
            this.nume.TabIndex = 13;
            this.nume.Visible = false;
            // 
            // pren
            // 
            this.pren.Location = new System.Drawing.Point(395, 149);
            this.pren.Name = "pren";
            this.pren.Size = new System.Drawing.Size(122, 20);
            this.pren.TabIndex = 14;
            this.pren.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Visible = false;
            // 
            // nume_lb
            // 
            this.nume_lb.AutoSize = true;
            this.nume_lb.Location = new System.Drawing.Point(318, 126);
            this.nume_lb.Name = "nume_lb";
            this.nume_lb.Size = new System.Drawing.Size(41, 13);
            this.nume_lb.TabIndex = 16;
            this.nume_lb.Text = "Nume :";
            this.nume_lb.Visible = false;
            // 
            // pren_lb
            // 
            this.pren_lb.AutoSize = true;
            this.pren_lb.Location = new System.Drawing.Point(318, 156);
            this.pren_lb.Name = "pren_lb";
            this.pren_lb.Size = new System.Drawing.Size(55, 13);
            this.pren_lb.TabIndex = 17;
            this.pren_lb.Text = "Prenume :";
            this.pren_lb.Visible = false;
            // 
            // dn_lb
            // 
            this.dn_lb.AutoSize = true;
            this.dn_lb.Location = new System.Drawing.Point(321, 181);
            this.dn_lb.Name = "dn_lb";
            this.dn_lb.Size = new System.Drawing.Size(72, 13);
            this.dn_lb.TabIndex = 18;
            this.dn_lb.Text = "Data nasterii :";
            this.dn_lb.Visible = false;
            // 
            // sex
            // 
            this.sex.DisplayMember = "0";
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sex.Location = new System.Drawing.Point(395, 201);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(75, 21);
            this.sex.TabIndex = 19;
            this.sex.Visible = false;
            // 
            // sex_lb
            // 
            this.sex_lb.AutoSize = true;
            this.sex_lb.Location = new System.Drawing.Point(334, 206);
            this.sex_lb.Name = "sex_lb";
            this.sex_lb.Size = new System.Drawing.Size(31, 13);
            this.sex_lb.TabIndex = 20;
            this.sex_lb.Text = "Sex :";
            this.sex_lb.Visible = false;
            // 
            // nr
            // 
            this.nr.Location = new System.Drawing.Point(315, 228);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(42, 20);
            this.nr.TabIndex = 21;
            this.nr.Visible = false;
            this.nr.TextChanged += new System.EventHandler(this.nr_TextChanged);
            // 
            // scara
            // 
            this.scara.Location = new System.Drawing.Point(404, 228);
            this.scara.Name = "scara";
            this.scara.Size = new System.Drawing.Size(44, 20);
            this.scara.TabIndex = 22;
            this.scara.Visible = false;
            this.scara.TextChanged += new System.EventHandler(this.nr_TextChanged);
            // 
            // ap
            // 
            this.ap.Location = new System.Drawing.Point(483, 228);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(45, 20);
            this.ap.TabIndex = 23;
            this.ap.Visible = false;
            this.ap.TextChanged += new System.EventHandler(this.nr_TextChanged);
            // 
            // tip_strada
            // 
            this.tip_strada.Enabled = false;
            this.tip_strada.Location = new System.Drawing.Point(395, 254);
            this.tip_strada.Name = "tip_strada";
            this.tip_strada.Size = new System.Drawing.Size(53, 20);
            this.tip_strada.TabIndex = 25;
            this.tip_strada.Visible = false;
            // 
            // nr_lb
            // 
            this.nr_lb.AutoSize = true;
            this.nr_lb.Location = new System.Drawing.Point(287, 231);
            this.nr_lb.Name = "nr_lb";
            this.nr_lb.Size = new System.Drawing.Size(21, 13);
            this.nr_lb.TabIndex = 26;
            this.nr_lb.Text = "Nr:";
            this.nr_lb.Visible = false;
            // 
            // sc_lb
            // 
            this.sc_lb.AutoSize = true;
            this.sc_lb.Location = new System.Drawing.Point(363, 231);
            this.sc_lb.Name = "sc_lb";
            this.sc_lb.Size = new System.Drawing.Size(38, 13);
            this.sc_lb.TabIndex = 27;
            this.sc_lb.Text = "Scara:";
            this.sc_lb.Visible = false;
            // 
            // ap_lb
            // 
            this.ap_lb.AutoSize = true;
            this.ap_lb.Location = new System.Drawing.Point(454, 231);
            this.ap_lb.Name = "ap_lb";
            this.ap_lb.Size = new System.Drawing.Size(23, 13);
            this.ap_lb.TabIndex = 28;
            this.ap_lb.Text = "Ap:";
            this.ap_lb.Visible = false;
            // 
            // tip_lb
            // 
            this.tip_lb.AutoSize = true;
            this.tip_lb.Enabled = false;
            this.tip_lb.Location = new System.Drawing.Point(335, 257);
            this.tip_lb.Name = "tip_lb";
            this.tip_lb.Size = new System.Drawing.Size(57, 13);
            this.tip_lb.TabIndex = 29;
            this.tip_lb.Text = "Tip strada:";
            this.tip_lb.Visible = false;
            // 
            // strada_lb
            // 
            this.strada_lb.AutoSize = true;
            this.strada_lb.Location = new System.Drawing.Point(348, 283);
            this.strada_lb.Name = "strada_lb";
            this.strada_lb.Size = new System.Drawing.Size(41, 13);
            this.strada_lb.TabIndex = 30;
            this.strada_lb.Text = "Strada:";
            this.strada_lb.Visible = false;
            // 
            // adresa
            // 
            this.adresa.FormattingEnabled = true;
            this.adresa.Location = new System.Drawing.Point(395, 307);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(146, 21);
            this.adresa.TabIndex = 31;
            this.adresa.Visible = false;
            this.adresa.SelectedIndexChanged += new System.EventHandler(this.adresa_SelectedIndexChanged);
            // 
            // adresa_lb
            // 
            this.adresa_lb.AutoSize = true;
            this.adresa_lb.Location = new System.Drawing.Point(345, 310);
            this.adresa_lb.Name = "adresa_lb";
            this.adresa_lb.Size = new System.Drawing.Size(43, 13);
            this.adresa_lb.TabIndex = 32;
            this.adresa_lb.Text = "Adresa:";
            this.adresa_lb.Visible = false;
            // 
            // strada
            // 
            this.strada.FormattingEnabled = true;
            this.strada.Location = new System.Drawing.Point(395, 280);
            this.strada.Name = "strada";
            this.strada.Size = new System.Drawing.Size(146, 21);
            this.strada.TabIndex = 33;
            this.strada.Visible = false;
            this.strada.SelectedIndexChanged += new System.EventHandler(this.strada_SelectedIndexChanged);
            // 
            // pers
            // 
            this.pers.FormattingEnabled = true;
            this.pers.Location = new System.Drawing.Point(395, 334);
            this.pers.Name = "pers";
            this.pers.Size = new System.Drawing.Size(146, 21);
            this.pers.TabIndex = 34;
            this.pers.Visible = false;
            // 
            // pers_lb
            // 
            this.pers_lb.AutoSize = true;
            this.pers_lb.Location = new System.Drawing.Point(337, 337);
            this.pers_lb.Name = "pers_lb";
            this.pers_lb.Size = new System.Drawing.Size(52, 13);
            this.pers_lb.TabIndex = 35;
            this.pers_lb.Text = "Persoana";
            this.pers_lb.Visible = false;
            // 
            // actv_user
            // 
            this.actv_user.Location = new System.Drawing.Point(12, 197);
            this.actv_user.Name = "actv_user";
            this.actv_user.Size = new System.Drawing.Size(97, 56);
            this.actv_user.TabIndex = 36;
            this.actv_user.Text = "Activeaza User";
            this.actv_user.UseVisualStyleBackColor = true;
            this.actv_user.Visible = false;
            this.actv_user.Click += new System.EventHandler(this.actv_user_Click);
            // 
            // mes_user
            // 
            this.mes_user.Location = new System.Drawing.Point(12, 259);
            this.mes_user.Name = "mes_user";
            this.mes_user.Size = new System.Drawing.Size(97, 56);
            this.mes_user.TabIndex = 37;
            this.mes_user.Text = "Trimite mesaj la user";
            this.mes_user.UseVisualStyleBackColor = true;
            this.mes_user.Visible = false;
            this.mes_user.Click += new System.EventHandler(this.mes_user_Click);
            // 
            // user_drop
            // 
            this.user_drop.DisplayMember = "Date";
            this.user_drop.FormattingEnabled = true;
            this.user_drop.Location = new System.Drawing.Point(351, 46);
            this.user_drop.Name = "user_drop";
            this.user_drop.Size = new System.Drawing.Size(146, 21);
            this.user_drop.TabIndex = 38;
            this.user_drop.ValueMember = "ID";
            this.user_drop.Visible = false;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(206, 340);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(118, 20);
            this.sub.TabIndex = 39;
            this.sub.Visible = false;
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(206, 377);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(312, 101);
            this.mes.TabIndex = 40;
            this.mes.Text = "";
            this.mes.Visible = false;
            // 
            // sub_lb
            // 
            this.sub_lb.AutoSize = true;
            this.sub_lb.Location = new System.Drawing.Point(169, 343);
            this.sub_lb.Name = "sub_lb";
            this.sub_lb.Size = new System.Drawing.Size(27, 13);
            this.sub_lb.TabIndex = 41;
            this.sub_lb.Text = "Titlu";
            this.sub_lb.Visible = false;
            // 
            // mes_lb
            // 
            this.mes_lb.AutoSize = true;
            this.mes_lb.Location = new System.Drawing.Point(161, 380);
            this.mes_lb.Name = "mes_lb";
            this.mes_lb.Size = new System.Drawing.Size(35, 13);
            this.mes_lb.TabIndex = 42;
            this.mes_lb.Text = "Mesaj";
            this.mes_lb.Visible = false;
            // 
            // dest
            // 
            this.dest.DisplayMember = "Date";
            this.dest.FormattingEnabled = true;
            this.dest.Location = new System.Drawing.Point(206, 302);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(119, 21);
            this.dest.TabIndex = 43;
            this.dest.ValueMember = "ID";
            this.dest.Visible = false;
            // 
            // dest_lb
            // 
            this.dest_lb.AutoSize = true;
            this.dest_lb.Location = new System.Drawing.Point(145, 305);
            this.dest_lb.Name = "dest_lb";
            this.dest_lb.Size = new System.Drawing.Size(55, 13);
            this.dest_lb.TabIndex = 44;
            this.dest_lb.Text = "Destinatar";
            this.dest_lb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 583);
            this.Controls.Add(this.dest_lb);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.mes_lb);
            this.Controls.Add(this.sub_lb);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.user_drop);
            this.Controls.Add(this.mes_user);
            this.Controls.Add(this.actv_user);
            this.Controls.Add(this.pers_lb);
            this.Controls.Add(this.pers);
            this.Controls.Add(this.strada);
            this.Controls.Add(this.adresa_lb);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.strada_lb);
            this.Controls.Add(this.tip_lb);
            this.Controls.Add(this.ap_lb);
            this.Controls.Add(this.sc_lb);
            this.Controls.Add(this.nr_lb);
            this.Controls.Add(this.tip_strada);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.scara);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.sex_lb);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.dn_lb);
            this.Controls.Add(this.pren_lb);
            this.Controls.Add(this.nume_lb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pren);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.nu_bt);
            this.Controls.Add(this.da_bt);
            this.Controls.Add(this.bk_bt);
            this.Controls.Add(this.exct_bt);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.sterge_bt);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.ad_bt);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.passw_lb);
            this.Controls.Add(this.user_lb);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Label user_lb;
        private System.Windows.Forms.Label passw_lb;
        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Button ad_bt;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button sterge_bt;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Button exct_bt;
        private System.Windows.Forms.Button bk_bt;
        private System.Windows.Forms.Button da_bt;
        private System.Windows.Forms.Button nu_bt;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox pren;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label nume_lb;
        private System.Windows.Forms.Label pren_lb;
        private System.Windows.Forms.Label dn_lb;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label sex_lb;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.TextBox scara;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.TextBox tip_strada;
        private System.Windows.Forms.Label nr_lb;
        private System.Windows.Forms.Label sc_lb;
        private System.Windows.Forms.Label ap_lb;
        private System.Windows.Forms.Label tip_lb;
        private System.Windows.Forms.Label strada_lb;
        private System.Windows.Forms.ComboBox adresa;
        private System.Windows.Forms.Label adresa_lb;
        private System.Windows.Forms.ComboBox strada;
        private System.Windows.Forms.ComboBox pers;
        private System.Windows.Forms.Label pers_lb;
        private System.Windows.Forms.Button actv_user;
        private System.Windows.Forms.Button mes_user;
        private System.Windows.Forms.ComboBox user_drop;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.RichTextBox mes;
        private System.Windows.Forms.Label sub_lb;
        private System.Windows.Forms.Label mes_lb;
        private System.Windows.Forms.ComboBox dest;
        private System.Windows.Forms.Label dest_lb;
    }
}

