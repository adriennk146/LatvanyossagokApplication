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
            TablazatLetrehoz();
           

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
            comm.CommandText=sql;
            var reader = comm.ExecuteReader();
            reader.Close();
        }
    }
}
