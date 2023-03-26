using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comunicacion
{
     public class SistemaSensores
    {
        public double Temp { get; set; }
        public string apellidos { get; set; }
        public double edad { get; set; }
        public string nombre { get; set; }

        public string strTemp { get; set; }
        public string strEdad { get; set; }

        //hay qeu dar los usaurios
        public void ObtieneValores()
        {
            try
            {
                this.Temp = Convert.ToDouble(strTemp);
                this.edad = Convert.ToDouble(strEdad);
            }catch
            {
                System.Windows.Forms.MessageBox.Show("no se pudo convertir un string de las variables ");

            }
        }
    }
}
