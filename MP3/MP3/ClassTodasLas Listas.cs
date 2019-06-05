using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MP3
{
    class ClassTodasLas_Listas
    {
        static ClassTodasLas_Listas()
        {
            ClassLista AlquilerJson = new ClassLista();
            //Asginarle valores al libro

            //Convertir el objeto en una cadena JSON
            string salida = JsonConvert.SerializeObject(AlquilerJson);
            //guardar el archivo de texto, con extension json            
            FileStream stream = new FileStream("Listas.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(salida);
            writer.Close();

            MessageBox.Show("Ingresado Exitosamente!!");

        }

        private static List<ClassLista> todasListas;

        public static List<ClassLista> TodasListas { get => todasListas; set => todasListas = value; }

        public static List<ClassLista> GetListas()
        {
            return TodasListas;
        }
    }
}
