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
    public partial class inicio_sesion : Form
    {
        public inicio_sesion()
        {
            InitializeComponent();
        }

        public void abrir()
        {
            this.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
                MySqlConnection myConn = new MySqlConnection(myC);

                MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.paciente where id_paciente='" + t_usuario.Text + "' and contrasena='" + t_contra.Text + "' ;", myConn);
                MySqlDataReader myR;
                myConn.Open();
                myR = sc.ExecuteReader();
                int count = 0;
                while (myR.Read())
                {
                    count = count + 1;
                }
                myConn.Close();
                if (count == 1)
                {
                    MessageBox.Show("Bienvenido");
                    main_paciente mp = new main_paciente();
                    mp.Show();
                    count = 0;
                    t_usuario.Clear();
                    t_contra.Clear();                  
                    this.Hide();
                }
                else if(count == 0)
                {
                    MySqlCommand sc1 = new MySqlCommand("select * from MtcqKvJRNU.doctor where id_doctor='" + t_usuario.Text + "' and contrasena='" + t_contra.Text + "' ;", myConn);
                    myConn.Open();
                    myR = sc1.ExecuteReader();
                    while (myR.Read())
                    {
                        count = count + 1;
                    }
                    myConn.Close();
                    if (count == 1)
                    {
                        MessageBox.Show("Bienvenido");
                        main_doc md = new main_doc();
                        md.Show();
                        count = 0;
                        t_usuario.Clear();
                        t_contra.Clear();
                        this.Hide();
                    }
                    else if (count == 0)
                    {
                        MySqlCommand sc2 = new MySqlCommand("select * from MtcqKvJRNU.provedores where id_prov='" + t_usuario.Text + "' and contrasena='" + t_contra.Text + "' ;", myConn);
                        myConn.Open();
                        myR = sc2.ExecuteReader();
                        while (myR.Read())
                        {
                            count = count + 1;
                        }
                        myConn.Close();
                        if (count == 1)
                        {
                            MessageBox.Show("Bienvenido");
                            main_provedor mpo = new main_provedor();
                            mpo.Show();
                            count = 0;
                            t_usuario.Clear();
                            t_contra.Clear();
                            this.Hide();
                        }
                        else if (count == 0)
                        {
                            MessageBox.Show("Intente nuevamente, los datos no coinciden");
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
