using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace conexion_medica
{
    public partial class main_provedor : Form
    {
        public main_provedor()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion ini = new inicio_sesion();
            ini.abrir();
            this.Close(); 
        }

        private void main_provedor_Load(object sender, EventArgs e)
        {
            inicio_sesion inn = new inicio_sesion(); 
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);
            
            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.equipo where nom_lugar = '"+inicio_sesion.id+"';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                dataGridView1.Rows.Add(myR[1], myR[2], myR[4], myR[3]);
            }
            myConn.Close();

            
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo_equipo ne = new nuevo_equipo();
            ne.Show();
            this.Hide(); 
        }

        private void verDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos_prov dp = new datos_prov();
            dp.Show();
            this.Hide(); 
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nuevo_equipo ne = new nuevo_equipo();

            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            num = dr.Cells[2].Value.ToString();
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.equipo where num_serie = '" + num + "';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                ne.t0.Text = myR[0].ToString();
                ne.t1.Text = myR[1].ToString();
                ne.t2.Text = myR[2].ToString();
                ne.t3.Text = myR[3].ToString();
                ne.t4.Text = myR[4].ToString();
                ne.t5.Text = myR[5].ToString();
                ne.t6.Text = myR[6].ToString();
                ne.t7.Text = myR[7].ToString();
                ne.t8.Text = myR[8].ToString();
                ne.t9.Text = myR[9].ToString();
                ne.t10.Text = myR[10].ToString();
            }
            myConn.Close();
            ne.Show();

            this.Close();
        }
        string num; 
        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
