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
    public partial class nuevo_equipo : Form
    {
        public nuevo_equipo()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("INSERT INTO MtcqKvJRNU.equipo(id_equipo,nombre,especialidad,descripcion,num_serie,modelo,responsable,nom_lugar,direccion,ciudad,estado) " +
                    "VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}', '{6}', '{7}','{8}','{9}','{10}')",
                    t0.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t4.Text, t8.Text, t10.Text);
                myConn.Open();
                MySqlCommand sc = new MySqlCommand(query, myConn);
                sc.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Informacion guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void t8_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("UPDATE MtcqKvJRNU.equipo SET nombre='{1}',especialidad='{2}',descripcion='{3}',num_serie='{4}',modelo='{5}',responsable='{6}',nom_lugar='{7}',direccion='{8}',ciudad='{9}',estado='{10}' WHERE id_equipo='{0}'",
                    lab.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t4.Text, t8.Text, t10.Text);
                myConn.Open();
                MySqlCommand sc = new MySqlCommand(query, myConn);
                sc.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Informacion actualizada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("DELETE FROM MtcqKvJRNU.equipo WHERE id_equipo='{0}'",
                    lab.Text);
                myConn.Open();
                MySqlCommand sc = new MySqlCommand(query, myConn);
                sc.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Informacion eliminada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_provedor mp = new main_provedor();
            mp.Show();
            this.Close();
        }
    }
}
