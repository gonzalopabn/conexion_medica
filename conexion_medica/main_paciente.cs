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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace conexion_medica
{
    public partial class main_paciente : MaterialForm
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        double LongIni = 32.524109;
        double LatIni = -117.021852;
        
        public main_paciente()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        int a, b; 

        private void main_paciente_Load(object sender, EventArgs e)
        {
            a = 0;
            b = 4;
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);
            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.reportes where id_paciente='" + t_id.Text + "';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear(); 
            while (myR.Read() == true)
            {
                dataGridView1.Rows.Add(myR[0], myR[2], myR[3], myR[4], myR[5]);
            }
            myConn.Close();


            String query = string.Format("select * from MtcqKvJRNU.equipo LIMIT {0},{1};", a, b);
            MySqlCommand sc2 = new MySqlCommand(query, myConn);
            myConn.Open();
            myR = sc2.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView2.Rows.Clear();
            while (myR.Read() == true)
            {
                dataGridView2.Rows.Add(myR[1], myR[2], myR[6], myR[8]);

            }
            actualizar_datos();

            
            myConn.Close();
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LongIni, LatIni);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 16;
            gMapControl1.AutoScroll = true;
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
        private void actualizar_datos()
        {
            nom1.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            nom2.Text = dataGridView2.Rows[1].Cells[0].Value.ToString();
            nom3.Text = dataGridView2.Rows[2].Cells[0].Value.ToString();
            nom4.Text = dataGridView2.Rows[3].Cells[0].Value.ToString();
            esp1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            esp2.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
            esp3.Text = dataGridView2.Rows[2].Cells[1].Value.ToString();
            esp4.Text = dataGridView2.Rows[3].Cells[1].Value.ToString();
            ubi1.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            ubi2.Text = dataGridView2.Rows[1].Cells[2].Value.ToString();
            ubi3.Text = dataGridView2.Rows[2].Cells[2].Value.ToString();
            ubi4.Text = dataGridView2.Rows[3].Cells[2].Value.ToString();
            enc1.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
            enc2.Text = dataGridView2.Rows[1].Cells[3].Value.ToString();
            enc3.Text = dataGridView2.Rows[2].Cells[3].Value.ToString();
            enc4.Text = dataGridView2.Rows[3].Cells[3].Value.ToString();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            a = b + 1;
            b = b + 4;

            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);
            String query = string.Format("select * from MtcqKvJRNU.equipo LIMIT {0},{1};", a, b);

            MySqlCommand sc2 = new MySqlCommand(query, myConn);
            MySqlDataReader myR;
            myConn.Open();

            myR = sc2.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView2.Rows.Clear();
            while (myR.Read() == true)
            {
                dataGridView2.Rows.Add(myR[1], myR[2], myR[6], myR[8]);

            }
            actualizar_datos();

            myConn.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            inicio_sesion ini = new inicio_sesion();
            ini.abrir();
            this.Close();
        }
    }
}
