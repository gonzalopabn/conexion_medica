﻿using System;
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
            main_paciente mp = new main_paciente();
            main_doc md = new main_doc();
            main_provedor mpo = new main_provedor();

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
                    mp.t1.Text = myR[1].ToString();
                    mp.t2.Text = myR[1].ToString();
                    mp.t3.Text = myR[1].ToString();
                    mp.t4.Text = myR[1].ToString();
                    mp.t5.Text = myR[1].ToString();
                    mp.t6.Text = myR[1].ToString();
                    mp.t7.Text = myR[1].ToString();
                    mp.t8.Text = myR[1].ToString();
                    mp.t9.Text = myR[1].ToString();
                    mp.t10.Text = myR[1].ToString();
                    mp.t11.Text = myR[1].ToString();
                    mp.t12.Text = myR[1].ToString();
                    mp.t13.Text = myR[1].ToString();
                    mp.t14.Text = myR[1].ToString();
                }
                myConn.Close();
                if (count == 1)
                {
                    MessageBox.Show("Bienvenido");                    
                    mp.Show();
                    count = 0;
                    mp.t_id.Text = t_usuario.ToString(); 
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
