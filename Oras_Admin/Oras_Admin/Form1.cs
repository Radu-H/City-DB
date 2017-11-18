using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Oras_Admin
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        int logat = 0,mod;

        public Form1()
        {
            serv_connect();
            InitializeComponent();
        }

        void sendMail(string mail,string subj, string mes)
        {
            string from = "developingsoftware01@gmail.com";
            string pass = "C#ForTheWin";
            //string mess = "Cerere noua de confirmare de la : " + nume + " " + pren + "\nE-mail: " + mail + "\nUser: " + user + "\nParola: " + passw;

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
            sendmail.To.Add(new MailAddress(mail));
            sendmail.Subject = subj;
            sendmail.Body = mes;

            client.Send(sendmail);
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

                //cmd.CommandText = " create table Strazi (nume varchar(30) not null, tip varchar(30) not null, id_strada varchar(30) not null);";
                //cmd.CommandText+= " create table Adresa (id_strada varchar(30) not null, nr varchar(4) not null, sc varchar(4) not null, ap varchar(4) not null, id_adresa varchar(30) not null);";
                //cmd.CommandText+= " create table Locuinta (nume varchar(30) not null, prenume varchar(30) not null, datan date not null, sex varchar(1) default 'M', id_adresa varchar(30) not null, id_locatar varchar(30));";
                //cmd.CommandText += " create table admin (userul varchar(30) not null, parola varchar(255) not null);";
                //cmd.CommandText += "insert into admin (userul, parola) values ('sefu','"+crypto("1234")+"');";
                //cmd.CommandText += " create table utilizatori (nume varchar(30) not null, prenume varchar(30) not null, username varchar(30) not null, passw varchar(255) not null, id_user varchar(30) not null)";
                //cmd.ExecuteNonQuery();
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

        void log_in_reusit()
        {
            user_lb.Visible = user.Visible = passw_lb.Visible = passw.Visible = log_in.Visible = false;
            ad_bt.Visible = edit.Visible = sterge_bt.Visible=actv_user.Visible=mes_user.Visible = true;
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

        private void lob_in_bt_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "select * from admin";
                    SqlDataReader x = cmd.ExecuteReader();
                    if (x.HasRows == true)
                    {
                        x.Read();

                        if (x["userul"].ToString() == user.Text && verif(passw.Text, x["parola"].ToString()))
                        {
                            log_in_reusit();
                            log_out.Visible = true;
                        }
                        else
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

        private void log_out_Click(object sender, EventArgs e)
        {
            if (ad_bt.Visible == true) hidemenu();
            resetcitire();
            log_in.Visible = true;
            user_lb.Visible = user.Visible = passw.Visible = passw_lb.Visible = true;
            exct_bt.Visible = bk_bt.Visible = log_out.Visible = da_bt.Visible = nu_bt.Visible = false;
            logat = 0;
        }

        private void hidemenu()
        {
            if (logat == 1)
            {
                ad_bt.Visible = edit.Visible = sterge_bt.Visible =actv_user.Visible=mes_user.Visible= !(ad_bt.Visible);
                bk_bt.Visible = exct_bt.Visible = !(bk_bt.Visible);
            }
        }

        void resetcitire()
        {
            user_drop.Visible =dest.Visible=dest_lb.Visible=mes_lb.Visible=mes.Visible=sub.Visible=sub_lb.Visible= false;
            user_drop.Text =sub.Text=mes.Text=dest.Text= "";
            nume.Text = pren.Text = user.Text = passw.Text = dateTimePicker1.Text =sex.Text=nr.Text=scara.Text=ap.Text=tip_strada.Text=strada.Text=adresa.Text=pers.Text= "";
            nume_lb.Visible = nume.Visible = pren.Visible = pren_lb.Visible = user.Visible = user_lb.Visible = passw.Visible = passw_lb.Visible=pers_lb.Visible=pers.Visible = false;
            dateTimePicker1.Visible = dn_lb.Visible = sex.Visible = sex_lb.Visible = nr.Visible = nr_lb.Visible = scara.Visible = sc_lb.Visible = ap.Visible = ap_lb.Visible = tip_lb.Visible = tip_strada.Visible = strada.Visible = strada_lb.Visible = adresa.Visible = adresa_lb.Visible= false;
        }

        private void bk_bt_Click(object sender, EventArgs e)
        {
            hidemenu();
            resetcitire();
            da_bt.Visible = nu_bt.Visible = false;
        }

        private void ad_bt_Click(object sender, EventArgs e)
        {
            hidemenu();
            nume_lb.Visible = nume.Visible = pren.Visible = pren_lb.Visible = dateTimePicker1.Visible=dn_lb.Visible=sex.Visible=sex_lb.Visible=nr.Visible=nr_lb.Visible=scara.Visible=sc_lb.Visible=ap.Visible=ap_lb.Visible=tip_lb.Visible=tip_strada.Visible=strada.Visible=strada_lb.Visible=adresa.Visible=adresa_lb.Visible = true;
            mod = 1;
            update_adresa();
            update_strada();
        }

        void update_adresa()
        {
           adresa.Items.Clear();
            adresa.Text = "";

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Adresa";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        adresa.Items.Add(x["nr"].ToString() + " " + x["sc"].ToString() + " " + x["ap"].ToString() );

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

        void update_strada()
        {
            strada.Items.Clear();
            strada.Text = "";

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
                        strada.Items.Add(x["tip"].ToString() + " " + x["nume"].ToString());

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

        void update_user()
        {
            List<Object> items = new List<object>();

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from utilizatori where activ='0'";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                {
                    while (x.Read())
                        items.Add(new { Date = x["nume"].ToString() + " " + x["prenume"].ToString()+" || User : "+x["username"].ToString(), ID = x["id_user"].ToString() });
                    user_drop.DataSource = items;
                    user_drop.Text = "";
                }

                else MessageBox.Show("Nu exista useri inactivi!");
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

        void update_dest()
        {
            List<Object> items = new List<object>();

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from utilizatori where activ='1'";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                {
                    while (x.Read())
                        items.Add(new { Date = x["nume"].ToString() + " " + x["prenume"].ToString() + " || User : " + x["username"].ToString(), ID = x["id_user"].ToString() });
                    dest.DataSource = items;
                    dest.Text = "";
                }

                else MessageBox.Show("Nu exista useri activi!");
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

        string rand_strada()
        {
            Random z = new Random();
            int ok;// y = 0;
            string q = "";
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                do
                {
                    ok = 1;
                    for(int i=0;i<6;i++)
                           q += z.Next(0, 9).ToString();
                    cmd.CommandText = "select * from Strazi where id_strada='" + q+"'";
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

            return q;
        }

        void filtru_adresa(string id)
        {
            adresa.Items.Clear();
            adresa.Text = "";

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Adresa where id_strada='"+id+"'";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        adresa.Items.Add(x["nr"].ToString() + " " + x["sc"].ToString() + " " + x["ap"].ToString());
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

        string rand_adresa()
        {
            Random z = new Random();
            int ok;//, y = 0;
            string q = "";
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                do
                {
                    ok = 1;
                    //y = (int)(z.NextDouble() * 1000000);
                    for (int i = 0; i < 6; i++)
                        q += z.Next(0, 9).ToString();
                    cmd.CommandText = "select * from Adresa where id_adresa=" + q+"'";
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

            return q;
        }

        string rand_loc()
        {
            Random z = new Random();
            int ok;//, y = 0;
            string q = "";
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                do
                {
                    ok = 1;
                    //y = (int)(z.NextDouble() * 1000000);
                    for (int i = 0; i < 6; i++)
                        q += z.Next(0, 9).ToString();
                    cmd.CommandText = "select * from Locuinta where id_locatar=" +q+"'";
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

            return q;
        }

        string get_id(int x, string y, string id_in)
        {
            string id = "";

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                //MessageBox.Show(y.Length.ToString());
                //MessageBox.Show(y.IndexOf(" ").ToString() + " " + (y.IndexOf(" ") + 1).ToString());
                if (x == 0)
                    cmd.CommandText = "select * from Strazi where tip='"+y.Substring(0,y.IndexOf(" "))+"' and nume='"+ y.Substring(y.IndexOf(" ") + 1)+"'";
                if (x == 1)
                    cmd.CommandText = "select * from Adresa where id_strada='" + id_in + "' and nr='" + y.Substring(0, y.IndexOf(" ")) + "' and sc='" + y.Substring(y.IndexOf(" ") + 1, y.LastIndexOf(" ") - y.IndexOf(" ") - 1) + "' and ap='" + y.Substring(y.LastIndexOf(" ") + 1) + "'";
                if (x == 2)
                    cmd.CommandText = "select * from Locuinta where ";
               // MessageBox.Show(cmd.CommandText);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows == true)
                {
                    r.Read();
                    switch (x)
                    {
                        case 0: id = r["id_strada"].ToString(); break;
                        case 1: id = r["id_adresa"].ToString(); break;
                        case 2: id = r["id_locatar"].ToString(); break;
                    }
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

            return id;
        }

        bool exista(int x, string y, string id_in)
        {
            bool k = false;
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                if (x == 0)
                    cmd.CommandText = "select * from Strazi where lower(tip)='" + y.Substring(0, y.IndexOf(" ")).ToLower() + "' and lower(nume)='" + y.Substring(y.IndexOf(" ") + 1).ToLower() + "'";
                if (x == 1)
                    cmd.CommandText = "select * from Adresa where id_strada='" + id_in + "' and lower(nr)='" + y.Substring(0, y.IndexOf(" ")).ToLower() + "' and lower(sc)='" + y.Substring(y.IndexOf(" ") + 1, y.LastIndexOf(" ") - y.IndexOf(" ") - 1).ToLower() + "' and lower(ap)='" + y.Substring(y.LastIndexOf(" ") + 1).ToLower() + "'";
                if (x == 2)
                    cmd.CommandText = "select * from Locuinta where ";
                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows == true)
                    k= true;
                else
                    k= false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return k;
        }

        private void adresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = adresa.Text;
            nr.Text = ad.Substring(0, ad.IndexOf(" "));
            scara.Text = ad.Substring(ad.IndexOf(" ") + 1, ad.LastIndexOf(" ") - ad.IndexOf(" ") - 1);
            ap.Text = ad.Substring(ad.LastIndexOf(" ") + 1);
            adresa.Text = ad;
            string id= get_id(0, strada.Text, "");
            id = get_id(1, adresa.Text, id);
            //try
            //{
            //    con.Open();
            //    cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "select * from Adresa where id_strada='" + id + "' and nr='" + adresa.Text.Substring(0, adresa.Text.IndexOf(" ")) + "' and sc='" + adresa.Text.Substring(adresa.Text.IndexOf(" ") + 1, adresa.Text.LastIndexOf(" ") - adresa.Text.IndexOf(" ") - 1) + "' and ap='" + adresa.Text.Substring(adresa.Text.LastIndexOf(" ") + 1) + "'";
            //    SqlDataReader r = cmd.ExecuteReader();
            //    id = "";
            //    if (r.HasRows == true)
            //    {
            //        r.Read();

            //       id=r["id_adresa"].ToString();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
            update_pers(id);
        }

        void update_pers(string id)
        {
            pers.Items.Clear();
            pers.Text = "";

            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Locuinta where id_adresa='" + id + "'";
                SqlDataReader x = cmd.ExecuteReader();
                if (x.HasRows == true)
                    while (x.Read())
                        pers.Items.Add(x["nume"].ToString() + " " + x["prenume"].ToString() + " " + x["sex"].ToString()+" "+x["datan"].ToString().Substring(0,10)+" "+x["id_locatar"].ToString());
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

        private void edit_Click(object sender, EventArgs e)
        {
            hidemenu();
            pers.Visible = pers_lb.Visible = true;
            nume_lb.Visible = nume.Visible = pren.Visible = pren_lb.Visible = dateTimePicker1.Visible = dn_lb.Visible = sex.Visible = sex_lb.Visible =strada.Visible = strada_lb.Visible = adresa.Visible = adresa_lb.Visible = true;
            mod = 2;
            update_adresa();
            update_strada();

        }

        private void strada_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Strazi where tip='" + strada.Text.Substring(0, strada.Text.IndexOf(" ")) + "' and nume='" + strada.Text.Substring(strada.Text.IndexOf(" ") + 1) + "'";

                //MessageBox.Show(cmd.CommandText);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows == true)
                {
                    r.Read();

                    id=r["id_strada"].ToString();

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
            filtru_adresa(id);
        }

        private void sterge_bt_Click(object sender, EventArgs e)
        {
            hidemenu();
            strada.Visible = strada_lb.Visible = adresa.Visible = adresa_lb.Visible =pers.Visible=pers_lb.Visible= true;
            update_adresa();
            update_strada();
            mod = 4;
        }

        private void nr_TextChanged(object sender, EventArgs e)
        {
            adresa.Text = nr.Text + " " + scara.Text + " " + ap.Text;
           // adresa.Text.Trim();
        }

        private void actv_user_Click(object sender, EventArgs e)
        {
            hidemenu();
            user_drop.Visible =user_lb.Visible= true;
            update_user();
            mod = 5;
        }

        private void mes_user_Click(object sender, EventArgs e)
        {
            hidemenu();
            dest.Visible = dest_lb.Visible = sub.Visible = sub_lb.Visible = mes.Visible = mes_lb.Visible = true;
            update_dest();
            mod = 6;
        }

        private void exct_bt_Click(object sender, EventArgs e)
        {
            string error = "";
            switch (mod)
            {
                case 1:
                    {
                        error += isEmpty(nume.Text, "Introduceti numele.");
                        error += isEmpty(pren.Text, "Introduceti prenumele.");
                        error += isEmpty(sex.Text, "Alegeti sexul persoanei.");
                        if (!strada.Items.Contains(strada.Text))
                        {
                            if (strada.Text == "")
                                error += "Introduceti o strada\n";
                            else
                            {
                                if (!exista(0, strada.Text, ""))
                                {
                                    string k = rand_strada();
                                    try
                                    {
                                        con.Open();
                                        cmd = new SqlCommand();
                                        cmd.Connection = con;
                                        cmd.CommandType = CommandType.Text;

                                        cmd.CommandText = "insert into Strazi (tip, nume, id_strada) values ('" + strada.Text.Substring(0, strada.Text.IndexOf(" ")) + "', '" + strada.Text.Substring(strada.Text.IndexOf(" ") + 1) + "', '" + k + "')";
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
                                }
                            }
                        }
                        string id_str = get_id(0, strada.Text, "");
                        if (adresa.SelectedIndex < 0)
                            if (nr.Text == "" && scara.Text == "" && ap.Text == "")
                                error += "Introduceti o adresa.\n";
                            else
                            {
                                if (!exista(1, adresa.Text, id_str))
                                {
                                    string k = rand_adresa();
                                    try
                                    {
                                        con.Open();
                                        cmd = new SqlCommand();
                                        cmd.Connection = con;
                                        cmd.CommandType = CommandType.Text;
                                        cmd.CommandText = "insert into Adresa (nr, sc, ap, id_adresa, id_strada) values ('" + nr.Text + "', '" + scara.Text + "', '" + ap.Text + "', '" + k + "', '" + id_str + "')";
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
                                }
                                adresa.Text = nr.Text + " " + scara.Text + " " + ap.Text;
                            }
                        if (error.Length == 0)
                        {
                            string k = rand_loc();
                            string id1 = get_id(1, adresa.Text,id_str);
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "insert into Locuinta (nume, prenume, datan, sex, id_locatar, id_adresa) values ('" + nume.Text + "', '" + pren.Text + "', '" + dateTimePicker1.Text + "', '" + sex.Text + "', '" + k + "', '"+id1+"')";

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record updated successfully!");
                                hidemenu();
                                resetcitire();
                            }
                            catch (Exception ex)
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
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "select * from Locuinta where id_locatar='" + pers.Text.Substring(pers.Text.LastIndexOf(" ") + 1, 6) + "'";
                            SqlDataReader r = cmd.ExecuteReader();
                            if (r.HasRows == true)
                            {
                                r.Read();

                                nume.Text = r["nume"].ToString();
                                pren.Text = r["prenume"].ToString();
                                sex.Text = r["sex"].ToString();
                                dateTimePicker1.Text = r["datan"].ToString();

                                mod = 3;

                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                            break;
                    }
                case 3:
                    {
                        try
                        {
                            con.Open();
                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Locuinta set nume='" + nume.Text + "', prenume='" + pren.Text + "', sex='" + sex.Text + "', datan='" + dateTimePicker1.Text + "' where id_locatar='" + pers.Text.Substring(pers.Text.LastIndexOf(" ") + 1, 6) + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record updated successfully!");
                            hidemenu();
                            resetcitire();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                        break;
                    }
                case 4:
                    {
                        error += isEmpty(pers.Text, "Selectati locatarul de sters!");
                        if (error.Length == 0)
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "delete from Locuinta where id_locatar='" + pers.Text.Substring(pers.Text.LastIndexOf(" ") + 1, 6) + "'";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Locatar eliminat de pe lista!");
                                hidemenu();
                                resetcitire();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        else
                            MessageBox.Show(error);
                        break;
                    }
                case 5:
                    {
                        if (user_drop.SelectedIndex < 0)
                            error += "Alegeti un user pentru activare.\n";
                        if(error.Length==0)
                        {
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "update utilizatori set activ='1' where id_user='" + user_drop.SelectedValue + "'";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record updated successfully!");
                            }
                            catch (Exception ex)
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
                                cmd.CommandText = "select * from utilizatori where id_user='" + user_drop.SelectedValue + "'";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                {
                                    x.Read();

                                    sendMail(x["mail"].ToString(), "Activare cont", "Buna ziua,\n\nContul dvs. a fost activat cu succes, va puteti loga in aplicatie cu datele alese la crearea contului.\nUser:"+x["username"].ToString()+"\n\nVa multumesc!");

                                }
                                hidemenu();
                                resetcitire();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }
                        break;
                    }
                case 6:
                    {
                        if (dest.SelectedIndex < 0)
                            error += "Alegeti un user pentru a-i trimite un mesaj.\n";
                        error += isEmpty(sub.Text, "Introduceti un titlu.");
                        error += isEmpty(mes.Text, "Introduceti un mesaj.");
                        if(error.Length==0)
                        {
                            try
                            {
                                con.Open();
                                cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "select * from utilizatori where id_user='" + dest.SelectedValue + "'";
                                SqlDataReader x = cmd.ExecuteReader();
                                if (x.HasRows == true)
                                {
                                    x.Read();

                                    sendMail( x["mail"].ToString(), sub.Text, mes.Text);
                                    MessageBox.Show("Mesaj trimis cu succes.");
                                }
                                hidemenu();
                                resetcitire();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                        break;
                    }
            }
        }
    }
}
