using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using ProyectoExcepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                StreamWriter streamReader = new StreamWriter(archivo);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(streamReader, datos);
                streamReader.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                StreamReader streamReader = new StreamReader(archivo);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
