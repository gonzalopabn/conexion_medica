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
using MaterialSkin;
using MaterialSkin.Controls;

namespace conexion_medica
{
    public partial class datos_prov : MaterialForm
    {
        public datos_prov()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("INSERT INTO MtcqKvJRNU.provedores(id_prov,nombre,responsable,cedula_responsable,direccion,ciudad,estado,rfc,tel,correo,especialidad,contrasena)" +
                    "VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}', '{6}', '{7}','{8}','{9}','{10}','{11}')",
                    t0.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t4.Text, t8.Text, t10.Text, t11.Text);
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

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("UPDATE MtcqKvJRNU.provedores SET id_prov='{0}',nombre='{1}',responsable='{2}',cedula_responsable='{3}',direccion='{4}',ciudad='{5}',estado='{6}',tel='{8}',correo='{9}',especialidad='{10}',contrasena='{11}' WHERE rfc='{7}'",
                    t0.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t4.Text, t8.Text, t10.Text, t11.Text);
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

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("DELETE FROM MtcqKvJRNU.provedores WHERE rfc='{0}'",
                    t7.Text);
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

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            main_provedor mp = new main_provedor();
            mp.Show();
            this.Close();
        }
    }
}
