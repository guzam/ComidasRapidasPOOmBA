using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidasPOOmBA.Clases.Helper
{
    public class GestionArchivos
    {
        string cabeceraIngreso, pieIngreso;
        string ingreso;

        public GestionArchivos() { }

        public void escribir(string ruta, string ingreso, bool sobreEscribir)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta,sobreEscribir);

                sw.WriteLine(cabecera());
                sw.WriteLine(ingreso);
                sw.WriteLine(pie());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        public string cabecera()
        {
            return cabeceraIngreso = "Ingreso: " + DateTime.Now.ToString() ;
        }

        public string pie()
        {
            return pieIngreso = "------------------------------------------";
        }
    }
}
