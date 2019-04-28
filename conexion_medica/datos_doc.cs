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
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace conexion_medica
{
    public partial class datos_doc : MaterialForm
    {
        public datos_doc()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE);
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

        private void datos_doc_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("INSERT INTO MtcqKvJRNU.doctor(id_doctor,nom,apellido,cedula,hospital,direccion,ciudad,estado,tel,correo,especialidad,contrasena) " +
                    "VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}', '{6}', '{7}','{8}','{9}','{10}','{11}')",
                    t11.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text, t9.Text, t10.Text, t12.Text);
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
                String query = string.Format("UPDATE MtcqKvJRNU.doctor SET nom='" + t1.Text + "',apellido='" + t2.Text + "',cedula='" + t3.Text + "',hospital='" + t4.Text + "',direccion='" + t5.Text + "',ciudad='" + t6.Text + "',estado='" + t7.Text + "',tel='" + t8.Text + "',correo='" + t9.Text + "',especialidad='" + t10.Text + "',contrasena='" + t12.Text + "' WHERE id_doctor='" + t11.Text + "'");
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
                String query = string.Format("DELETE FROM MtcqKvJRNU.doctor WHERE id_doctor='" + t11.Text + "'");
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
            main_doc md = new main_doc();
            md.Show();
            this.Close();
        }
    }
}
