using System;
using System.IO;
using System.Xml.Serialization;

namespace VDRDataAnalyzer
{
    public class UsuariosRepositorioXML: IUsuariosRepositorio
    {
        public void Salvar(Usuarios usuario)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Usuarios));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.xml";
            FileStream file = File.Create(path);
            writer.Serialize(file, usuario);
            file.Close();
        }

        public Usuarios Recuperar()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Usuarios));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.xml";
            StreamReader file = new StreamReader(path);
            Usuarios usuario = (Usuarios)reader.Deserialize(file);
            file.Close();

            return usuario;
        }
    }
}
