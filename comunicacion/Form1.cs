using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace comunicacion
{
    public partial class Form1 : Form
    {
        SerialPort puerto;
        SistemaSensores sensores;
        System.Windows.Forms.Timer loop;

        String datos;

        public Form1()
        {
           

            InitializeComponent();
            puerto = new SerialPort("COM5");
            puerto.BaudRate = 9600; //comunicacion del arduino
            puerto.Parity = Parity.None;
            puerto.StopBits = StopBits.One;
            puerto.DataBits = 8;

            loop = new System.Windows.Forms.Timer();
            loop.Interval = 500;
            loop.Tick += Loop_Tick;
            loop.Start();

            sensores = new SistemaSensores();
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            textapelli.Text = sensores.apellidos+"";
            textBoxtemp.Text = sensores.strTemp + ".c";
            textBoxnombre.Text = sensores.nombre + "";
            textBoxedad.Text = sensores.strEdad +"" ;
            textBoxdatos.Text = datos;

            aGaugeTemp.Value = (float)sensores.Temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar" && !puerto.IsOpen)
            {
                try
                {
                    puerto.Open();
                    puerto.DataReceived += Puerto_DataReceived;
                    btnConectar.Text = "Desconectar";
                }
                catch (Exception error)
                {
                    MessageBox.Show("No fue posible iniciar la conexion!");

                }

            }
            else if (btnConectar.Text == "Desconectar" && puerto.IsOpen)
            {
                puerto.Close();
                btnConectar.Text = "Conectar";
            }
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
          
            //recibimos lo que nos envia el arduino 
            datos = puerto.ReadLine();
            String[] subsStrings = datos.Split('/');
            if(subsStrings.Length == 5)
            {
                if (subsStrings[0] == "~")
                {
                    sensores.strTemp = subsStrings[1];
                    sensores.nombre= subsStrings[2];
                    sensores.apellidos = subsStrings[3];
                    sensores.strTemp = subsStrings[4];
                    sensores.ObtieneValores();
                }
            }
        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {

        }
    }
}
