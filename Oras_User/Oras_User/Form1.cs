using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

// Strazi (nume varchar(30) not null, tip varchar(30) not null, id_strada varchar(30) not null)
// Adresa (id_strada varchar(30) not null, nr varchar(4) not null, sc varchar(4) not null, ap varchar(4) not null, id_adresa varchar(30) not null)
// Locuinta (nume varchar(30) not null, prenume varchar(30) not null, datan date not null, sex varchar(1) default 'M', id_adresa varchar(30) not null, id_locatar varchar(30))
// admin (userul varchar(30) not null, parola varchar(255) not null)
// utilizatori (nume varchar(30) not null, prenume varchar(30) not null, username varchar(30) not null, passw varchar(255) not null, id_user varchar(30) not null)

namespace Oras_User
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        int logat = 0, mod;
        string id_activ="";

        public Form1()
        {
            
            serv_connect();
            InitializeComponent();
            vr_ch.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        struct adrese
        {
            public string id, adresa;
        };

        struct loc
        {
            public string id;
            public int nr;
        };

        void sendMail(string nume, string pren, string mail,string user, string passw)
        {
            string from = "developingsoftware01@gmail.com";
            string pass = "C#ForTheWin";
            string mess = "Cerere noua de confirmare de la : "+ nume+ " "+pren+"\nE-mail: "+mail+"\nUser: "+user+"\nParola: "+passw;

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pass);

            MailMessage sendmail = new MailMessage();
            sendmail.IsBodyHtml = false;
            sendmail.From = new MailAddress("developingsoftware01@gmail.com", "Program");
            sendmail.To.Add(new MailAddress("handolescu.radu1@gmail.com"));
            sendmail.Subject = "Cerere de confirmare";
            sendmail.Body = mess;

            //client.Send(sendmail);
        }

        void sendMail(string nume, string pren, string mail, string user, string passw,string to, string mess,string subj, string filename)
        {
            string from = "developingsoftware01@gmail.com";
            string pass = "C#ForTheWin";
           // string mess = "Cerere noua de confirmare de la : " + nume + " " + pren + "\nE-mail: " + mail + "\nUser: " + user + "\nParola: " + passw;

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, pass);

            MailMessage sendmail = new MailMessage();
            sendmail.IsBodyHtml = false;
            sendmail.From = new MailAddress("developingsoftware01@gmail.com", "Program");
            sendmail.To.Add(new MailAddress(to));
            sendmail.Subject = subj;
            if (filename.Length > 0)
                sendmail.Attachments.Add(new Attachment(filename));
            sendmail.Body = mess;
            

            //client.Send(sendmail);
        }

        void serv_connect()
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Visual Studio 2015 Projects\\Oras_Admin\\Oras_Admin\\Oras.mdf\";Integrated Security=True";
            con = new SqlConnection(conString);
            try
            {
                con.Open();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        string crypto(string parola)
        {
            using (MD5 x = MD5.Create())
            {
                byte[] data = x.ComputeHash(Encoding.UTF8.GetBytes(parola));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        string rand_user()
        {
            Random z = new Random();
            int ok;
            string y = "";
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                do
                {
                    ok = 1;
                    for (int i = 0; i < 6; i++)
                        y += z.Next(0, 9).ToString();
                    cmd.CommandText = "select * from utilizatori where id_strada='" + y + "'";
                    SqlDataReader x = cmd.ExecuteReader();

                    if (x.HasRows == true)
                        ok = 0;
                } while (ok == 0);

            }
            catch (SqlException)
            {

            }
            finally
            {
                con.Close();
            }

            return y;
        }

        void update_strada()
        {
            
            List<Object> items = new List<object>();

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Strazi";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                {
                    while (x.Read())
                        items.Add(new { Adresa = x["tip"].ToString() + " " + x["nume"].ToString(), ID = x["id_strada"].ToString() });
                    strada.DataSource = items;
                    strada.Text = "";
                }

                else MessageBox.Show("Nu exista strazi inregistrate!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void update_adresa(string id_str)
        {
                List<Object> items_ad = new List<object>();

                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Adresa where id_strada='"+id_str+"'";
                    SqlDataReader x = cmd.ExecuteReader();
                    if (x.HasRows == true)
                    {
                        while (x.Read())
                            items_ad.Add(new { Adresa ="Nr."+ x["nr"].ToString() + ", Scara " + x["sc"].ToString()+", Ap."+x["ap"].ToString(), ID = x["id_adresa"].ToString() });
                        adresa.DataSource = items_ad;
                        adresa.Text = "";
                    }

                    else MessageBox.Show("Nu exista adrese inregistrate!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
           
        }

        void log_in_reusit()
        {
            user_lb.Visible = user.Visible = passw_lb.Visible = passw.Visible = log_in.Visible=user_nou.Visible = false;
            vr_pers.Visible = nr_sex.Visible = nr_minor.Visible = pens.Visible = loc_str.Visible = vr_sex_oras.Visible = vr_sex_str.Visible = vr_sex_adresa.Visible = max_loc.Visible = zi_luna.Visible = nascuti.Visible = true;
            user.Text = passw.Text = "";
            logat = 1;
        }

        string isEmpty(string s, string mes)
        {

            string error = "";

            if (s == "")
                error = mes + "\n";
            return error;

        }

        bool verif(string sir, string parola)
        {
            string hash2 = crypto(sir);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hash2, parola))
                return true;
            else
                return false;
        }

        private void user_nou_Click(object sender, EventArgs e)
        {
            nume.Visible = nume_lb.Visible = pren.Visible = pren_lb.Visible = exct_bt.Visible=mail.Visible=mail_lb.Visible = true;
            mod = 1;
            log_in.Visible = user_nou.Visible = false;
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            if (vr_pers.Visible == true) hidemenu();
            resetcitire();
            log_in.Visible =user_nou.Visible= true;
            user_lb.Visible = user.Visible = passw.Visible = passw_lb.Visible = true;
            exct_bt.Visible = bk_bt.Visible = log_out.Visible = false;
            logat = 0;
            id_activ = "";
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            string error = "";
            error += isEmpty(user.Text, "Introduceti userul.");
            error += isEmpty(passw.Text, "Introduceti parola.");

            if (error.Length == 0)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from utilizatori";
                    SqlDataReader x = cmd.ExecuteReader();
                    if (x.HasRows == true)
                    {
                        while(x.Read())

                        if (x["username"].ToString() == user.Text && verif(passw.Text, x["passw"].ToString())&&x["activ"].ToString()=="1")
                        {
                            id_activ = x["id_user"].ToString();
                            log_in_reusit();
                            log_out.Visible = true;
                        }
                       
                        if(logat==0)
                        {
                            MessageBox.Show("Userul sau parola gresita!");
                            user.Text = passw.Text = "";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
                MessageBox.Show(error);
        }

        void hidemenu()
        {
            if (logat == 1)
            {
                vr_pers.Visible = nr_sex.Visible = nr_minor.Visible = pens.Visible = loc_str.Visible = vr_sex_oras.Visible = vr_sex_str.Visible = vr_sex_adresa.Visible = max_loc.Visible = zi_luna.Visible = nascuti.Visible = !(vr_pers.Visible);
                bk_bt.Visible = exct_bt.Visible = !(bk_bt.Visible);
            }
        }

        void resetcitire()
        {
            nume.Text = pren.Text = passw.Text = user.Text =rez.Text= "";
            nume.Visible = nume_lb.Visible = pren.Visible = pren_lb.Visible = user.Visible = user_lb.Visible = passw.Visible = passw_lb.Visible =rez.Visible= false;
            strada.Text = nr.Text = scara.Text = ap.Text = "";
            mail.Visible = mail_lb.Visible = false;
            mail.Text = "";
            strada.Visible = str_lb.Visible = nr.Visible = nr_lb.Visible = scara.Visible = sc_lb.Visible = ap.Visible = ap_lb.Visible = false;
            vr_ch.Visible =sex_ch.Visible= false;
            vr_ch.Series["Locuitori"].Points.Clear();
            sex_ch.Series["Locuitori"].Points.Clear();
            data_lb.Visible = dateTimePicker1.Visible = false;
            dateTimePicker1.ResetText();
        }

        private void bk_bt_Click(object sender, EventArgs e)
        {
            hidemenu();
            resetcitire();
        }

        private void vr_pers_Click(object sender, EventArgs e)
        {
            rez.Visible = true;

            string vrmax = "";
           
                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Locuinta order by datan asc";
                    SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)

                    do
                    {
                        x.Read();
                        DateTime dat = Convert.ToDateTime(x["datan"]);
                        //DateTime.TryParse(x["datan"], out dat);
                        var zile = (DateTime.Today - dat).Days / 365;
                        //rez.Text = ((int)((DateTime.Today - dat).Days)/365).ToString();
                        rez.Text += x["nume"].ToString() + " " + x["prenume"].ToString() + " : " + zile + " ani\n";
                    } while (vrmax == x["datan"].ToString());
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            mod = 2;
            hidemenu();
        }

        private void nr_sex_Click(object sender, EventArgs e)
        {
            rez.Visible = true;

           int nrb=0, nrf=0;

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta order by datan asc";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        if (x["sex"].ToString().ToUpper() == "M")
                            nrb++;
                        else
                            nrf++;

                rez.Text = nrb + " barbati\n" + nrf + " femei";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            mod = 2;
            hidemenu();
        }

        private void nr_minor_Click(object sender, EventArgs e)
        {
            rez.Visible = true;

            int nrm = 0;

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta order by datan asc";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                    {
                        DateTime dat = Convert.ToDateTime(x["datan"]);
                        var zile = (DateTime.Today - dat).Days / 365;
                        if (zile < 18)
                            nrm++;
                    }

                rez.Text = nrm + " minori";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            mod = 2;
            hidemenu();
        }

        private void pens_Click(object sender, EventArgs e)
        {
            rez.Visible = true;

            int nrp = 0;

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta order by datan asc";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                    {
                        DateTime dat = Convert.ToDateTime(x["datan"]);
                        var zile = (DateTime.Today - dat).Days / 365;
                        if ((zile >= 65 && x["sex"].ToString().ToUpper() == "M") || (zile >= 62 && x["sex"].ToString().ToUpper() == "F"))
                        {
                            nrp++;
                            rez.Text += x["nume"].ToString() + " " + x["prenume"].ToString() + " : " + zile + " ani\n";
                        }
                    }

                rez.Text = nrp + " pensionari : \n\n"+rez.Text;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            mod = 2;
            hidemenu();
        }

        private void loc_str_Click(object sender, EventArgs e)
        {
            hidemenu();
            str_lb.Visible = strada.Visible = true;
            rez.Visible = true;
            update_strada();
            mod = 3;
        }

        private void vr_sex_oras_Click(object sender, EventArgs e)
        {
            hidemenu();

            int[] grvr = new int[10];
            int m = 0, f = 0, t = 0;
            string[] ser = { "0-9", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99" };

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                    {
                        t++;
                        DateTime dat = Convert.ToDateTime(x["datan"]);
                        var zile = (DateTime.Today - dat).Days / 365;
                        grvr[zile / 10]++;
                        if (x["sex"].ToString().ToUpper() == "M")
                            m++;
                        else
                            f++;
                    }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            for (int i = 0; i < 10; i++)
            {
                //Series series = this.vr_ch.Series.Add(ser[i]);
                vr_ch.Series["Locuitori"].Points.AddXY(ser[i], grvr[i]);
                //series.Points.Add(grvr[i]);
            }

            vr_ch.Visible =sex_ch.Visible= true;
            sex_ch.Series["Locuitori"].Points.AddXY("Barbati - "+m, m);
            sex_ch.Series["Locuitori"].Points.AddXY("Femei - " + f, f);
            graphtopdf("D:\\save.pdf");
            mod = 2;
        }

        private void vr_sex_str_Click(object sender, EventArgs e)
        {
            hidemenu();
            strada.Visible = str_lb.Visible = true;

            update_strada();

            mod = 4;
        }

        private void vr_sex_adresa_Click(object sender, EventArgs e)
        {
            hidemenu();
            strada.Visible = str_lb.Visible = adresa.Visible = ad_lb.Visible = true;
            update_strada();

            mod = 5;
        }

        private void strada_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_adresa(strada.SelectedValue.ToString());
        }

        

        private void max_loc_Click(object sender, EventArgs e)
        {
            hidemenu();
            rez.Visible = true;
            loc l;

            List<loc> ids = new List<loc>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta order by id_adresa asc";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        if (ids.Count == 0)
                            ids.Add(new loc { id = x["id_adresa"].ToString(), nr = 1 });
                        else
                            if (x["id_adresa"].ToString() != ids[ids.Count - 1].id)
                            ids.Add(new loc { id = x["id_adresa"].ToString(), nr = 1 });
                        else
                        {
                            l = ids[ids.Count - 1];
                            l.nr++;
                            ids[ids.Count - 1]=l;
                        }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            

            List<loc> idstr = new List<loc>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Adresa order by id_strada asc";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        foreach (loc aux in ids)
                        {
                            if (idstr.Count == 0)
                            {
                                if (aux.id == x["id_adresa"].ToString())
                                    idstr.Add(new loc { id = x["id_strada"].ToString(), nr = aux.nr });
                            }
                            else
                            if (x["id_strada"].ToString() != idstr[idstr.Count - 1].id)
                                idstr.Add(new loc { id = x["id_strada"].ToString(), nr = aux.nr });
                            else
                            {
                                l = idstr[idstr.Count - 1];
                                l.nr += aux.nr;
                                idstr[idstr.Count - 1] = l;
                            }
                        }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                ids.Clear();
            }

            int max = 0;
            foreach (loc aux in idstr)
                if (aux.nr > max)
                    max = aux.nr;
            foreach(loc aux in idstr)
                if(aux.nr==max)
                    ids.Add(new loc { id = aux.id, nr = aux.nr });
            //foreach (loc a in idstr)
               // MessageBox.Show(a.id + " " + a.nr);
            idstr.Clear();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Strazi";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        foreach (loc a in ids)
                            if (a.id == x["id_strada"].ToString())
                                rez.Text = x["tip"].ToString() + " " + x["nume"].ToString() + " : " + a.nr + " locatari\n";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                //foreach (loc a in ids)
                //    MessageBox.Show(a.id + " " + a.nr);
                ids.Clear();
            }
            mod = 2;
        }

        private void zi_luna_Click(object sender, EventArgs e)
        {
            hidemenu();
            data_lb.Visible = dateTimePicker1.Visible = true;
            rez.Visible = true;
            mod = 6;
        }

        private void nascuti_Click(object sender, EventArgs e)
        {
            hidemenu();

            int[] lun = new int[12];
            int t = 0;
            string[] ser = { "Ian", "Feb", "Mar", "Apr", "Mai", "Iun", "Iul", "Aug", "Sep", "Oct","Noi","Dec" };

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                    {
                        t++;
                        DateTime dat = Convert.ToDateTime(x["datan"]);
                        lun[dat.Month-1]++;
                    }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            for (int i = 0; i < 10; i++)
                vr_ch.Series["Locuitori"].Points.AddXY(ser[i], lun[i]);

            vr_ch.Visible = true;
            mod = 2;
        }

        private void exct_bt_Click(object sender, EventArgs e)
        {
            string error = "";

            switch(mod)
            {
                case 1:
                    {
                        error += isEmpty(nume.Text, "Introduceti numele.");
                        error += isEmpty(pren.Text, "Introduceti prenumele.");
                        error += isEmpty(user.Text, "Introduceti userul.");
                        error += isEmpty(passw.Text,"Introduceti parola.");
                        error += isEmpty(mail.Text, "Introduceti e-mailul.");
                        if (error.Length == 0)
                        {
                            
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from utilizatori";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read() && error.Length == 0)
                                        if (x["username"].ToString() == user.Text)
                                        {
                                            MessageBox.Show("User deja folosit.");
                                            error += "User deja folosit.\n";
                                        }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                            if (error.Length == 0)
                            {
                                string k = rand_user();
                                try
                                {
                                    con.Open();
                                    cmd = new SqlCommand();
                                    cmd.Connection = con;
                                    cmd.CommandType = CommandType.Text;

                                    cmd.CommandText = "insert into utilizatori (nume, prenume, username, passw, mail, id_user) values ('" + nume.Text + "', '" + pren.Text + "', '" + user.Text + "', '" + crypto(passw.Text) + "', '" + mail.Text + "', '" + k + "')";
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    con.Close();
                                }

                                sendMail(nume.Text, pren.Text, mail.Text, user.Text, passw.Text);
                                nume.Visible = nume_lb.Visible = pren.Visible = pren_lb.Visible = exct_bt.Visible = mail.Visible = mail_lb.Visible = false;
                                log_in.Visible = user_nou.Visible = true;
                                user.Text = passw.Text = mail.Text = "";
                                MessageBox.Show("Cerere inregistrata. Veti fi contactat la activare.");
                            }
                            else
                            {
                                MessageBox.Show(error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }

                        break;
                    }
                case 2:
                    {
                        hidemenu();
                        resetcitire();
                        break;
                    }
                case 3:
                    {
                        if (strada.SelectedIndex < 0)
                            error += "Selectati strada pe care doriti sa o vizualizati.";
                        // MessageBox.Show(strada.Text + "       " + strada.SelectedValue);
                        if (error.Length == 0)
                        {
                            List<adrese> ids = new List<adrese>();
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from Adresa where id_strada='" + strada.SelectedValue + "' order by id_adresa asc";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read())
                                        if (ids.Count == 0)
                                            ids.Add(new adrese { id = x["id_adresa"].ToString(), adresa = "Nr." + x["nr"].ToString() + ", Scara " + x["sc"].ToString() + ", Ap." + x["ap"].ToString() });
                                        else
                                            if (x["id_adresa"].ToString() != ids[ids.Count - 1].id)
                                            ids.Add(new adrese { id = x["id_adresa"].ToString(), adresa = "Nr." + x["nr"].ToString() + ", Scara " + x["sc"].ToString() + ", Ap." + x["ap"].ToString() });
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }

                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from Locuinta";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read())
                                        foreach (adrese ad in ids)
                                            if (ad.id == x["id_adresa"].ToString())
                                                rez.Text += x["nume"].ToString() + " " + x["prenume"].ToString() + " : " + strada.Text + " , " + ad.adresa + '\n';
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                            ids.Clear();

                            mod = 2;
                        }
                        else
                            MessageBox.Show(error);
                        break;
                    }
                case 4:
                    {
                        int[] grvr = new int[10];
                        int m = 0, f = 0, t = 0;
                        string[] ser = { "0-9", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99" };

                        if (strada.SelectedIndex < 0)
                            error += "Selectati strada pe care doriti sa o vizualizati.";
                        if (error.Length == 0)
                        {
                            
                                List<adrese> ids = new List<adrese>();
                                try
                                {
                                    con.Open();
                                    cmd = new SqlCommand();
                                    cmd.Connection = con;
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "select * from Adresa where id_strada='" + strada.SelectedValue + "' order by id_adresa asc";
                                    SqlDataReader xi = cmd.ExecuteReader();
                                    if (xi.HasRows == true)
                                        while (xi.Read())
                                            if (ids.Count == 0)
                                                ids.Add(new adrese { id = xi["id_adresa"].ToString(), adresa = "Nr." + xi["nr"].ToString() + ", Scara " + xi["sc"].ToString() + ", Ap." + xi["ap"].ToString() });
                                            else
                                                if (xi["id_adresa"].ToString() != ids[ids.Count - 1].id)
                                                ids.Add(new adrese { id = xi["id_adresa"].ToString(), adresa = "Nr." + xi["nr"].ToString() + ", Scara " + xi["sc"].ToString() + ", Ap." + xi["ap"].ToString() });
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                finally
                                {
                                    con.Close();
                                }
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from Locuinta";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read())
                                    {
                                        foreach (adrese ad in ids)
                                            if (ad.id == x["id_adresa"].ToString())
                                            {
                                                t++;
                                                DateTime dat = Convert.ToDateTime(x["datan"]);
                                                var zile = (DateTime.Today - dat).Days / 365;
                                                grvr[zile / 10]++;
                                                if (x["sex"].ToString().ToUpper() == "M")
                                                    m++;
                                                else
                                                    f++;
                                            }
                                    }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }

                            for (int i = 0; i < 10; i++)
                                vr_ch.Series["Locuitori"].Points.AddXY(ser[i], grvr[i]);

                            vr_ch.Visible = sex_ch.Visible = true;
                            sex_ch.Series["Locuitori"].Points.AddXY("Barbati - " + m, m);
                            sex_ch.Series["Locuitori"].Points.AddXY("Femei - " + f, f);
                            strada.Visible = str_lb.Visible = false;
                            graphtopdf("D:\\save.pdf");
                            mod = 2;
                        }
                        else
                            MessageBox.Show(error);
                        break;
                    }
                case 5:
                    {
                        int[] grvr = new int[10];
                        int m = 0, f = 0, t = 0;
                        string[] ser = { "0-9", "10-19", "20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99" };
                        if (strada.SelectedIndex < 0)
                            error += "Selectati strada pe care doriti sa o vizualizati.";
                        if (adresa.SelectedIndex < 0)
                            error += "Selectati adresa pe care doriti sa o vizualizati";

                        if(error.Length==0)
                        {
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from Locuinta where id_adresa='"+adresa.SelectedValue+"'";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read())
                                    {
                                        t++;
                                        DateTime dat = Convert.ToDateTime(x["datan"]);
                                        var zile = (DateTime.Today - dat).Days / 365;
                                        grvr[zile / 10]++;
                                        if (x["sex"].ToString().ToUpper() == "M")
                                            m++;
                                        else
                                            f++;

                                    }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }

                            for (int i = 0; i < 10; i++)
                                vr_ch.Series["Locuitori"].Points.AddXY(ser[i], grvr[i]);

                            vr_ch.Visible = sex_ch.Visible = true;
                            sex_ch.Series["Locuitori"].Points.AddXY("Barbati - " + m, m);
                            sex_ch.Series["Locuitori"].Points.AddXY("Femei - " + f, f);
                            graphtopdf("D:\\save.pdf");
                            mod = 2;
                            strada.Visible = str_lb.Visible = false;
                            adresa.Visible = ad_lb.Visible = false;
                        }
                        else
                            MessageBox.Show(error);
                    
                        break;
                    }
                case 6:
                    {
                        error += isEmpty(dateTimePicker1.Text, "Alegeti o luna si zi.");
                        if (error.Length == 0)
                        {
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                int a = dateTimePicker1.Text.IndexOf("-");
                                string s = dateTimePicker1.Text;
                                //MessageBox.Show(a + "\n" + s);
                                cmd.CommandText = "select * from Locuinta where month(datan)=" + int.Parse(dateTimePicker1.Text.Substring(0, a)) + " and day(datan)=" + int.Parse(s.Substring(a+1));
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                    while (x.Read())
                                        rez.Text += x["nume"].ToString() + " " + x["prenume"].ToString() + " : " + x["sex"].ToString() + " , " + x["datan"].ToString().Substring(0, x["datan"].ToString().IndexOf(" ")) + "\n";
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                            mod = 2;
                        }
                        else
                            MessageBox.Show(error);
                        break;
                    }
            }
        }

        void graphtopdf(string nametosave)
        {
            PdfDocument doc = new PdfDocument();

            PdfPage pg2=null;

            addimg("D:\\t1.jpg", 1, doc,ref pg2);
            addimg("D:\\t2.jpg", 2, doc,ref pg2);

            doc.Save(nametosave);

            MessageBox.Show("PDF created.");
        }

        void addimg (string imgname, int k, PdfDocument doc, ref PdfPage pg)
        {
            if(pg== null) pg = doc.AddPage();
            XGraphics gr = XGraphics.FromPdfPage(pg);

            if (k == 1)
                vr_ch.SaveImage(imgname, ImageFormat.Jpeg);
            else
                sex_ch.SaveImage(imgname, ImageFormat.Jpeg);

            XImage img = XImage.FromFile(imgname);

            if (k == 1)
                gr.DrawImage(img, 23, 23);
            else
                gr.DrawImage(img, 23, 423);
            img.Dispose();
            gr.Dispose();
            File.Delete(imgname);
        }
    }
}

