using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class latvanyossagokApp : Form
    {
        MySqlConnection conn;
        public latvanyossagokApp()
        {
            InitializeComponent();
            try
            {
                conn = new MySqlConnection("Server = localhost; Database =latvanyossagokdb; Uid = root; Pwd =;");
                conn.Open();
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("Hiba az adatbázis elérése során: " + msqle);
                this.Close();
            }
            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }

            };
            TablazatLetrehoz();
            VarosAdatokBetolt();

        }

        void TablazatLetrehoz()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS varosok(
                id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                nev VARCHAR(100) UNIQUE NOT NULL,
                lakossag int NOT NULL);
                
                CREATE TABLE IF NOT EXISTS latvanyossagok(
                id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
                nev VARCHAR(100) NOT NULL,
                leiras VARCHAR(1000) NOT NULL,
                ar int DEFAULT 0 NOT NULL,
                varos_id int NOT NULL);
                ALTER TABLE latvanyossagok
                ADD FOREIGN KEY (varos_id) REFERENCES varosok(id);";

            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader());
        }

        void VarosAdatokBetolt()
        {
            string sql = @"SELECT nev,lakossag 
                            FROM varosok";

            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                varosokLstBx.Items.Clear();
                varosokCOB.Items.Clear();
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");
                    Varos v1 = new Varos(nev, lakossag);
                    varosokLstBx.Items.Add(v1.ToString());
                    varosokCOB.Items.Add(v1.Nev);
                }
                reader.Close();
            }

        }

        private void ujVarosBtn_Click(object sender, EventArgs e)
        {
            string varos;
            int lakossag;
            bool mehet = true;
            foreach(string s in varosokLstBx.Items)
            {
                if (varosTB.Text.Equals(s))
                {
                    mehet = false;
                    MessageBox.Show("Van már ilyen nevű város!");
                }
            }
            if (varosTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg város nevet!");
            }
            if (lakossagNUD.Value == 0)
            {
                MessageBox.Show("Nem adta meg a város lakosságát!");
                mehet = false;
            }
            if (mehet)
            {
                varos = varosTB.Text;
                lakossag = Convert.ToInt32(lakossagNUD.Value);
                Varos v1 = new Varos(varos, lakossag);
                varosHozzaadAdatbazishoz(varos, lakossag);
                varosTB.Text = "";
                lakossagNUD.Value = 0;
            }
        }

        private void varosHozzaadAdatbazishoz(string varos, int lakossag)
        {
            string sql = @"INSERT INTO varosok (nev,lakossag) VALUES ('" + varos + "'," + lakossag + ");";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var mentes = comm.ExecuteReader());
                VarosAdatokBetolt();
        }

        private void latvanyossagMentesBtn_Click(object sender, EventArgs e)
        {
            string nev;
            string leiras;
            int ar;
            string varos;
            bool mehet = true;
            if(latvanyossagNevTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg nevet!");
            }
            if (leirasTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg leírást!");
            }
            if(arNUD == null)
            {
                mehet = false;
                MessageBox.Show("Nem adott meg árat!");
            }
            if (varosokCOB.SelectedItem == null)
            {
                mehet = false;
                MessageBox.Show("Nem választott várost!");
            }
            if (mehet)
            {
                nev = latvanyossagNevTB.Text;
                leiras = leirasTB.Text;
                ar = Convert.ToInt32(arNUD.Value);
                varos = varosokCOB.SelectedItem.ToString();
                int varos_id = GetID(varos);
                Latvanyossag l1 = new Latvanyossag(nev, leiras, ar, varos_id);
                latvanyossagHozzaadAdatbazishoz(nev, leiras, ar, varos_id);
                latvanyossagNevTB.Text = "";
                leirasTB.Text = "";
                arNUD.Value = 0;
                varosokCOB.SelectedItem = default;
            }
        }

        private int GetID(string nev)
        {
            string sql = @"SELECT id FROM varosok WHERE nev LIKE '" + nev + "';";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            int varos_id;
            using (var reader = comm.ExecuteReader())
            {
                reader.Read();
                varos_id = reader.GetInt32("id");
            }
            return varos_id;
        }


        private void latvanyossagHozzaadAdatbazishoz(string nev, string leiras, int ar, int varos_id)
        {
            string sql = @"INSERT INTO latvanyossagok (nev,leiras, ar,varos_id) VALUES ('" + nev + "','" + leiras + "',"+ar+",'"+varos_id+"');";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var mentes = comm.ExecuteReader()) ;
            string value = varosokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev1 = adatok[0];
            if (GetID(nev1) == varos_id)
            {
                Latvanyossag l1 = new Latvanyossag(nev, leiras, ar, varos_id);
                latvanyossagokLstBx.Items.Add(l1.ToString());
            }
            
        }

        private void varosokLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            torlesBtn.Visible = true;
            modositasBtn.Visible = true;
            latvanyossagokKiiratas();


        }

        private void torlesBtn_Click(object sender, EventArgs e)
        {
            string value = varosokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev = adatok[0];
            string sql = @"DELETE FROM varosok WHERE nev LIKE '" + nev + "';";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader()) ;
            VarosAdatokBetolt();
            torlesBtn.Visible = false;
        }

        private void modositasBtn_Click(object sender, EventArgs e)
        {
            ujVarosBtn.Visible = false;
            mMentesBtn.Visible = true;
            string value = varosokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev = adatok[0];
            string sql = @"SELECT nev, lakossag
                            FROM varosok
                            WHERE nev LIKE '" + nev + "';";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                reader.Read();
                varosTB.Text = reader.GetString("nev");
                lakossagNUD.Value = reader.GetInt32("lakossag");
            }
        }

        private void mMentesBtn_Click(object sender, EventArgs e)
        {
            string value = varosokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev = adatok[0];
            string varos;
            int lakossag;
            bool mehet = true;
            if (varosTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg város nevet!");
            }
            if (lakossagNUD.Value == 0)
            {
                MessageBox.Show("Nem adta meg a város lakosságát!");
                mehet = false;
            }
            if (mehet)
            {
                varos = varosTB.Text;
                lakossag = Convert.ToInt32(lakossagNUD.Value);
                string sql = @"UPDATE varosok SET nev ='" + varos + "', lakossag ='" + lakossag + "' WHERE nev LIKE '" + nev + "';";
                var comm = conn.CreateCommand();
                comm.CommandText = sql;
                using (var reader = comm.ExecuteReader()) ;
                VarosAdatokBetolt();
                varosTB.Text = "";
                lakossagNUD.Value = 0;
                mMentesBtn.Visible = false;
                ujVarosBtn.Visible = true;
            }
        }

        private void latvanyossagokKiiratas()
        {
            latvanyossagokLstBx.Items.Clear();
            string value = varosokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev = adatok[0];
            string sql = @"SELECT nev, leiras, ar, varos_id FROM latvanyossagok WHERE varos_id =" + GetID(nev) + ";";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var mentes = comm.ExecuteReader())
            {
                while (mentes.Read())
                {
                    Latvanyossag l1 = new Latvanyossag(mentes.GetString("nev"), mentes.GetString("leiras"), mentes.GetInt32("ar"), mentes.GetInt32("varos_id"));
                    latvanyossagokLstBx.Items.Add(l1.ToString());
                }
            }
        }

        private void latvanyossagokLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            latvanyossagTorlesBtn.Visible = true;
            latvanyossagModositasBtn.Visible = true;
        }

        private void latvanyossagTorlesBtn_Click(object sender, EventArgs e)
        {
            string value = latvanyossagokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev;
            if(adatok.Length==4)
            {
                nev = adatok[0];
            }
            else
            {
                nev = adatok[0];
                for(int i = 1; i < adatok.Length - 4; i++)
                {
                    nev += " " + adatok[i];
                }
            }
            string sql = @"DELETE FROM latvanyossagok WHERE nev LIKE '" + nev + "';";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader()) ;
            latvanyossagokKiiratas();
            latvanyossagTorlesBtn.Visible = false;
            latvanyossagModositasBtn.Visible = false;
        }

        private void latvanyossagModositasBtn_Click(object sender, EventArgs e)
        {
            latvanyossagMentesBtn.Visible = false;
            latvanyossagokmMentesBtn.Visible = true;
            string value = latvanyossagokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev;
            if (adatok.Length == 4)
            {
                nev = adatok[0];
            }
            else
            {
                nev = adatok[0];
                for (int i = 1; i < adatok.Length - 4; i++)
                {
                    nev += " " + adatok[i];
                }
            }
            string sql = @"SELECT nev, leiras, ar, varos_id
                            FROM latvanyossagok
                            WHERE nev LIKE '" + nev + "';";
            var comm = conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                reader.Read();
                latvanyossagNevTB.Text = reader.GetString("nev");
                leirasTB.Text = reader.GetString("leiras");
                arNUD.Value = reader.GetInt32("ar");
                
            }
        }

        private void latvanyossagokmMentesBtn_Click(object sender, EventArgs e)
        {
            string value = latvanyossagokLstBx.SelectedItem.ToString();
            string[] adatok = value.Split(' ');
            string nev;
            if (adatok.Length == 4)
            {
                nev = adatok[0];
            }
            else
            {
                nev = adatok[0];
                for (int i = 1; i < adatok.Length - 4; i++)
                {
                    nev += " " + adatok[i];
                }
            }
            string nev1;
            string leiras;
            int ar;
            string varos;
            bool mehet = true;
            if (latvanyossagNevTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg nevet!");
            }
            if (leirasTB.Text == "")
            {
                mehet = false;
                MessageBox.Show("Nem adott meg leírást!");
            }
            if (arNUD == null)
            {
                mehet = false;
                MessageBox.Show("Nem adott meg árat!");
            }
            if (varosokCOB.SelectedItem == null)
            {
                mehet = false;
                MessageBox.Show("Nem választott várost!");
            }
            if (mehet)
            {
                nev1 = latvanyossagNevTB.Text;
                leiras = leirasTB.Text;
                ar = Convert.ToInt32(arNUD.Value);
                varos = varosokCOB.SelectedItem.ToString();
                int varos_id = GetID(varos);
                string sql = @"UPDATE latvanyossagok SET nev ='" +nev1 + "', leiras ='" + leiras + "', ar = "+ar+", varos_id ='"+varos_id+"' " +
                    "WHERE nev LIKE '" + nev + "';";
                var comm = conn.CreateCommand();
                comm.CommandText = sql;
                using (var reader = comm.ExecuteReader()) ;
                latvanyossagokKiiratas();
                latvanyossagNevTB.Text = "";
                leirasTB.Text = "";
                arNUD.Value = 0;
                varosokCOB.SelectedItem = default;
                latvanyossagokmMentesBtn.Visible = false;
                latvanyossagMentesBtn.Visible = true;
            }
        }
    }
}
