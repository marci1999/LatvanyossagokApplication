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
        List<Latvanyossag> latvanosagLista;
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
            latvanosagLista = new List<Latvanyossag>();
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
    varos_id INTEGER NOT NULL,
    FOREIGN KEY (varos_id)
    REFERENCES varosok (id)
)
";
            var comm2 = this.conn.CreateCommand();
            comm2.CommandText = sql2;
            comm2.ExecuteNonQuery();

            string sql3 = @"
SELECT id, nev, lakossag
FROM varosok
";
            var comm3 = this.conn.CreateCommand();
            comm3.CommandText = sql3;
            using (var reader = comm3.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakosag = reader.GetInt32("lakossag");

                    cBVaroshozKotes.Items.Add(id);
                    cBVaroshozKotesModosit.Items.Add(id);


                    var varos = new Varos(id, nev, lakosag);
                    lBVarosLista.Items.Add(varos);

                }
            }
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
                int nevEgyezes;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                using (var sherch = comm.ExecuteReader())
                {
                    sherch.Read();
                    nevEgyezes = sherch.GetInt32("varosKerese");
                }

                if (!(nevEgyezes >= 1))
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
                string sql3 = @"
SELECT id, nev, lakossag
FROM varosok
WHERE nev`= @nev,
";
                var comm3 = this.conn.CreateCommand();
                comm3.CommandText = sql3;
                comm3.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                using (var reader = comm3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        int lakosag = reader.GetInt32("lakossag");

                        var varos = new Varos(id, nev, lakosag);
                        lBVarosLista.Items.Add(varos);
                    }
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
            if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") &&  !(cBVaroshozKotes.SelectedIndex == 0))
            {
                string sql = @"
SELECT COUNT(nev) as latvanyossagKerese
FROM latvanyossagok 
WHERE nev LIKE @nev
";
                int nevEgyezes;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@nev", tBVarosNev.Text);
                using (var sherch = comm.ExecuteReader())
                {
                    sherch.Read();
                    nevEgyezes = sherch.GetInt32("latvanyossagKerese");
                }

                if (!(nevEgyezes >= 1))
                {
                    string sql2 = @"
INSERT INTO `latvanyossagok`(`nev`, `leiras`, `ar`, `varos_id`)
VALUES (@nev, @leiras, @ar, @varos_id)
";
                    var comm2 = this.conn.CreateCommand();
                    comm2.CommandText = sql2;
                    comm2.Parameters.AddWithValue("@nev", tBLatvanyosagNev.Text);
                    comm2.Parameters.AddWithValue("@leiras", tBLatvanyosagLeiras.Text);
                    comm2.Parameters.AddWithValue("@ar", nUDLatvanyosagAr.Value);
                    comm2.Parameters.AddWithValue("@varos_id", cBVaroshozKotes.SelectedItem);
                    comm2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("ez a város már ben van az adattábázisabn.");
                }
                string sql3 = @"
SELECT id, nev, leiras, ar, varos_id
FROM latvanyossagok
WHERE nev`= @nev,
";
                var comm3 = this.conn.CreateCommand();
                comm3.CommandText = sql3;
                comm3.Parameters.AddWithValue("@nev", tBLatvanyosagNev.Text);
                using (var reader = comm3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string leiras = reader.GetString("leiras");
                        int ar = reader.GetInt32("ar"); 
                        int varosId = reader.GetInt32("varos_id");
                        var latvanyosag = new Latvanyossag(id, nev, leiras,ar,varosId);
                        latvanosagLista.Add(latvanyosag);
                    }
                }
            }
            else if (tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("")  && (cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság nevet, leirását,  ne adta meg és nem köttöte városhoz.");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && (cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság leirását ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && !(cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság nevet és leirását ne adta meg");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && (cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság nevet ne adta meg és nem köttöte városhoz.");
            }
            else if (tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && !(cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság nevet ne adta meg");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && tBLatvanyosagLeiras.Text.Equals("") && !(cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoság leirását ne adta meg");
            }
            else if (!tBLatvanyosagNev.Text.Equals("") && !tBLatvanyosagLeiras.Text.Equals("") && (cBVaroshozKotes.SelectedIndex == -1))
            {
                MessageBox.Show("a látványoságot nem köttöte városhoz.");
            }
        }

        private void bTorol_Click(object sender, EventArgs e)
        {
            if (lBVarosLista.SelectedIndex > -1)
            {
                string sql3 = @"
SELECT id
FROM varosok
WHERE nev LIKE @nev
";
                int id = 0;
                var comm3 = this.conn.CreateCommand();
                comm3.CommandText = sql3;
                Varos varos = (Varos)lBVarosLista.SelectedItem;
                comm3.Parameters.AddWithValue("@nev", varos.getNev());
                using (var reader = comm3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("id");
                    }
                }
                string sql = @"
SELECT COUNT(varos_id) as latvanyossagKerese
FROM latvanyossagok 
WHERE varos_id LIKE @id
";
                int keresetVaros;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", id);
                using (var sherch = comm.ExecuteReader())
                {
                    sherch.Read();
                    keresetVaros = sherch.GetInt32("latvanyossagKerese");
                }
                if (!(keresetVaros >= 1))
                {
                    string sql2 = @"
DELETE FROM `varosok` 
WHERE id = @id
";
                    var comm2 = this.conn.CreateCommand();
                    comm2.CommandText = sql2;
                    comm2.Parameters.AddWithValue("@id", id);
                    comm2.ExecuteNonQuery();
                    int adotElem = lBVarosLista.SelectedIndex;
                    lBVarosLista.Items.RemoveAt(adotElem);
                }
                else
                {
                    MessageBox.Show("a városhoz tartozik látványoság.");
                }
            }
            else
            {
                MessageBox.Show("nem választotad ki mit akarsz törölni.");
            }

            lBVarosLista.SelectedIndex = -1;
            gBVarosModosit.Visible = false;
            bVarosTorol.Visible = false;
        }

        private void bLatvanyosagTorol_Click(object sender, EventArgs e)
        {
            if (lBLatvanyosagLista.SelectedIndex > -1)
            {
                string sql3 = @"
SELECT id
FROM latvanyossagok
WHERE nev LIKE @nev
";
                int id = 0;
                var comm3 = this.conn.CreateCommand();
                comm3.CommandText = sql3;
                Latvanyossag latvanyosag = (Latvanyossag)lBVarosLista.SelectedItem;
                comm3.Parameters.AddWithValue("@nev", latvanyosag.getNev());
                using (var reader = comm3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32("id");
                    }
                }
                if (!(id >= 0))
                {
                    string sql2 = @"
DELETE FROM `latvanyossagok` 
WHERE id = @id
";
                    var comm2 = this.conn.CreateCommand();
                    comm2.CommandText = sql2;
                    comm2.Parameters.AddWithValue("@id", id);
                    comm2.ExecuteNonQuery();
                    int adotElem = lBVarosLista.SelectedIndex;
                    lBVarosLista.Items.RemoveAt(adotElem);
                }
            }
            else
            {
                MessageBox.Show("nem választotad ki mit akarsz törölni.");
            }

            lBVarosLista.SelectedIndex = -1;
            gBLatvanyosagModositas.Visible = true;
            bLatvanyosagTorol.Visible = true;
        }

        private void bVarosModosit_Click(object sender, EventArgs e)
        {

            if (lBVarosLista.SelectedIndex > -1)
            {
                string sql = @"
UPDATE `varosok` 
SET `nev`= @nev,
`lakossag`= @lakossag
WHERE id`= @id,
";
                Varos varos = (Varos)lBVarosLista.SelectedItem;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", varos.getId());
                comm.Parameters.AddWithValue("@nev", tBVarosNevModosit.Text);
                comm.Parameters.AddWithValue("@lakossag", nUADVarosLakosagaModosit);
                comm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("nem választotad ki mit akarsz modositani.");
            }
            lBVarosLista.SelectedIndex = -1;
            gBVarosModosit.Visible = false;
            bVarosTorol.Visible = false;
        }

        private void bLModosit_Click(object sender, EventArgs e)
        {
            if (lBVarosLista.SelectedIndex > -1)
            {
                string sql = @"
UPDATE `latvanyossagok` 
SET nev`= @id,
`leiras`= @leiras,
`ar`=  @ar,
`varos_id`= @varosId
WHERE id`= @id,
";
                Latvanyossag lavanyosag = (Latvanyossag)lBLatvanyosagLista.SelectedItem;
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@id", lavanyosag.getId());
                comm.Parameters.AddWithValue("@nev", tBVarosNevModosit.Text);
                comm.Parameters.AddWithValue("@leiras", tBLatvanyosagLeirasModosit);
                comm.Parameters.AddWithValue("@ar", nUDLatvanyosagArModosit);
                comm.Parameters.AddWithValue("@varosId", cBVaroshozKotesModosit.SelectedItem);
                comm.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("nem választotad ki mit akarsz modositani.");
            }
            lBVarosLista.SelectedIndex = -1;
            gBLatvanyosagModositas.Visible = true;
            bLatvanyosagTorol.Visible = true;
        }

        private void lBVarosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBVarosLista.SelectedIndex > -1)
            {
                lBLatvanyosagLista.Items.Clear();
                gBVarosModosit.Visible = true;
                bVarosTorol.Visible = true;
                Varos varos = (Varos)lBVarosLista.SelectedItem;
                string sql = @"
SELECT id, nev, leiras, ar, varos_id 
FROM latvanyossagok
WHERE varos_id = @varos_id
";
                var comm = this.conn.CreateCommand();
                comm.CommandText = sql;
                comm.Parameters.AddWithValue("@varos_id", varos.getId());
                using (var reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string leiras = reader.GetString("leiras");
                        int ar = reader.GetInt32("ar");
                        int varosId = reader.GetInt32("varos_id");

                        Latvanyossag latvanyosag = new Latvanyossag(id, nev, leiras, ar, varosId);
                        lBLatvanyosagLista.Items.Add(latvanyosag);
                    }
                }
            }
        }

        private void lBLatvanyosagLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            gBLatvanyosagModositas.Visible = true;
            bLatvanyosagTorol.Visible = true;
        }
    }
}
