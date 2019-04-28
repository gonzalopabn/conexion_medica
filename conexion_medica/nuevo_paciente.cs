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
    public partial class nuevo_paciente : MaterialForm
    {
        public nuevo_paciente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void label20_Click(object sender, EventArgs e)
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

        private void guardarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("INSERT INTO MtcqKvJRNU.paciente(" +
                    "id_paciente,nom,apellido,curp,edad,sexo,peso,altura,domicilio,telefono,correo,contacto_emergencia,tel_emergencia,doctor_cabecera,comentarios,contrasena) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')",
                    t0.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text, t9.Text, t10.Text, t11.Text, t12.Text, t13.Text, t_comen.Text, t_contra.Text);
                myConn.Open();
                MySqlCommand sc = new MySqlCommand();
                sc.Connection = myConn;
                sc.CommandText = query;
                sc.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Informacion guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("UPDATE MtcqKvJRNU.paciente SET nom='{0}',apellido='{1}',curp='{2}',edad='{3}',sexo='{4}',peso='{5}',altura='{6}',domicilio='{7}',telefono='{8}',correo='{9}',contacto_emergencia='{10}',tel_emergencia='{11}',doctor_cabecera='{12}',comentarios='{13}',contrasena='{14}' WHERE id_paciente='{15}'",
                    t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text, t9.Text, t10.Text, t11.Text, t12.Text, t13.Text, t_comen.Text, t_contra.Text, t0.Text);
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

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("DELETE FROM MtcqKvJRNU.paciente WHERE id_paciente='" + t0.Text + "'");
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

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("INSERT INTO MtcqKvJRNU.reporte(" +
                    "id_reporte,id_paciente,nombre,tipo,descripcion,fecha) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    t14.Text, t0.Text, t15.Text, t16.Text, t18.Text, t17.Text);
                myConn.Open();
                MySqlCommand sc = new MySqlCommand();
                sc.Connection = myConn;
                sc.CommandText = query;
                sc.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Informacion guardada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("UPDATE MtcqKvJRNU.reporte SET nombre='{0}',tipo='{1}',descripcion='{2}',fecha='{3}' WHERE id_reporte='{4}'",
                    t15.Text, t16.Text, t18.Text, t17.Text, t14.Text);
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

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);
                String query = string.Format("DELETE FROM MtcqKvJRNU.reporte WHERE id_reporte='" + t14.Text + "'");
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
            md.mostrar();
            this.Close();
        }
    }
}
