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
    public partial class main_doc : Form
    {
        public main_doc()
        {
            InitializeComponent();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo_paciente np = new nuevo_paciente();
            np.Show();
            this.Close(); 

            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion ini = new inicio_sesion();
            ini.abrir();
            this.Close();
        }

        private void main_doc_Load(object sender, EventArgs e)
        {
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.paciente;", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                dataGridView1.Rows.Add(myR[1], myR[2], myR[3]);
            }
            myConn.Close();

            MySqlCommand sc2 = new MySqlCommand("select * from MtcqKvJRNU.reportes;", myConn);
            MySqlDataReader myR2;
            myConn.Open();
            myR2 = sc2.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView2.Rows.Clear();
            while (myR2.Read() == true)
            {
                dataGridView2.Rows.Add(myR2[0], myR2[1], myR2[2], myR2[4], myR2[3]);
            }
            myConn.Close();

        }

        private void verDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos_doc dd = new datos_doc();
            dd.Show();
            this.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string num,num2;
        nuevo_paciente np = new nuevo_paciente();
        public void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            num = dr.Cells[2].Value.ToString();
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.paciente where curp='" + num + "';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                np.t0.Text = myR[0].ToString();
                np.t1.Text = myR[1].ToString();
                np.t2.Text = myR[2].ToString();
                np.t3.Text = myR[3].ToString();
                np.t4.Text = myR[4].ToString();
                np.t5.Text = myR[5].ToString();
                np.t6.Text = myR[6].ToString();
                np.t7.Text = myR[7].ToString();
                np.t8.Text = myR[8].ToString();
                np.t9.Text = myR[9].ToString();
                np.t10.Text = myR[10].ToString();
                np.t11.Text = myR[11].ToString();
                np.t12.Text = myR[12].ToString();
                np.t13.Text = myR[13].ToString();
                np.t_comen.Text = myR[14].ToString();
                np.t_contra.Text = myR[16].ToString(); 
            }
            myConn.Close();
            np.Show();
            this.Close();
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            num2 = dr.Cells[0].Value.ToString();
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.reportes where id_reporte='" + num2 + "';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                //DateTime dateTime = DateTime.Parse(myR[5].ToString());

                np.t14.Text = myR[0].ToString();
                np.t0.Text = myR[1].ToString();
                np.t15.Text = myR[2].ToString();
                np.t16.Text = myR[3].ToString();
                np.t18.Text = myR[4].ToString();
                //np.t17 = dateTime;
                
               
            }
            myConn.Close();
            np.Show();
            np.materialTabControl1.SelectTab(1);
            this.Close(); 
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void mostrar()
        {
            this.Show(); 
        }
    }
}
