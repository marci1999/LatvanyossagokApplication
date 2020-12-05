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
    public partial class Form1 : Form
    {

        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (true)
                {
                    conn.Close();
                }
            };

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = @"
CREATE TABLE IF NOT EXISTS varosok(
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    nev VARCHAR(1000) UNIQUE NOT NULL,
    lakossag INTEGER NOT NULL
)
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();

            string sql2 = @"
CREATE TABLE IF NOT EXISTS latvanyossagok(
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    nev VARCHAR(1000) UNIQUE NOT NULL,
    leiras VARCHAR(1000) NOT NULL,
    ar INTEGER  DEFAULT 0  NOT NULL,
    varos_id INTEGER,
    FOREIGN KEY (varos_id)
    REFERENCES varosok (id)
)
";
            var comm2 = this.conn.CreateCommand();
            comm2.CommandText = sql2;
            comm2.ExecuteNonQuery();
        }

        private void bVarostHozzaAd_Click(object sender, EventArgs e)
        {
            if (!tBVarosNev.Text.Equals("") && !nUADVarosLakosaga.Value.Equals(0))
            {
                string sql = @"
SELECT COUNT(nev) as varosKerese
FROM varosok 
WHERE nev LIKE @nev
";
                int nev;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                using (var sherch = comm.ExecuteReader())
                {
                    sherch.Read();
                    nev = sherch.GetInt32("varosKerese");
                }
                MessageBox.Show(nev + " ");

                if (!(nev >= 1))
                {
                    string sql2 = @"
INSERT INTO `varosok`(`nev`, `lakossag`)
VALUES (@nev, @lakosag)
";
                    var comm2 = this.conn.CreateCommand();
                    comm2.CommandText = sql2;
                    comm2.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                    comm2.Parameters.AddWithValue("@lakosag", nUADVarosLakosaga.Value);
                    comm2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("ez a város már ben van az adattábázisabn.");
                }
            }
            else if (tBVarosNev.Text.Equals("") && !nUADVarosLakosaga.Value.Equals(0))
            {
                MessageBox.Show("a város nevet ne adta meg");
            }
            else if (!tBVarosNev.Text.Equals("") && nUADVarosLakosaga.Value.Equals(0))
            {
                MessageBox.Show("a városnk biztos hogy nem 0 lakosa van");
            }
            else if (!tBVarosNev.Text.Equals("") && nUADVarosLakosaga.Value.Equals(0))
            {
                MessageBox.Show("a város nevet ne adta meg és biztos hogy nem 0 lakosa van");
            }
        }

        private void bLHozzaAd_Click(object sender, EventArgs e)
        {
            cBVaroshozKotes.SelectedIndex = 0;
            if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) &&  !(cBVaroshozKotes.SelectedIndex == 0))
            {
                string sql = @"
SELECT COUNT(nev) as latvanyossagKerese
FROM latvanyossagok 
WHERE nev LIKE @nev
";
                int nev;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                using (var sherch = comm.ExecuteReader())
                {
                    sherch.Read();
                    nev = sherch.GetInt32("latvanyossagKerese");
                }
                MessageBox.Show(nev + " ");

                if (!(nev >= 1))
                {
                    string sql2 = @"
INSERT INTO `varosok`(`nev`, `lakossag`)
VALUES (@nev, @lakosag)
";
                    var comm2 = this.conn.CreateCommand();
                    comm2.CommandText = sql2;
                    comm2.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                    comm2.Parameters.AddWithValue("@lakosag", nUADVarosLakosaga.Value);
                    comm2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("ez a város már ben van az adattábázisabn.");
                }
            }
            else if (tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet, leirását, árát ne adta meg és nem köttöte városhoz.");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság leirását, árát ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet, leirását és árát ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet, árát ne adta meg és nem köttöte városhoz.");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság árát ne adta meg és nem köttöte városhoz.");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság leirását és árát ne adta meg");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság leirását ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet és leirását ne adta meg");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet és árát ne adta meg");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság nevet ne adta meg");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság leirását ne adta meg");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && nUDLatvanyosagAr.Value.Equals(0) && !(cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoság biztos hogy 0 ft-be kerül");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && !nUDLatvanyosagAr.Value.Equals(0) && (cBVaroshozKotes.SelectedIndex == 0))
            {
                MessageBox.Show("a látványoságot nem köttöte városhoz.");
            }
        }
    }
}
