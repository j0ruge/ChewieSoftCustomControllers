using System;
using System.IO;
using System.Text.Json;

namespace VDRDataAnalyzer
{
    public class UsuariosRepositorioJSON : IUsuariosRepositorio
    {
        public void Salvar(Usuarios usuario)
        {
            string json = JsonSerializer.Serialize(usuario);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.json";
            File.WriteAllText(path, json);
        }

        public Usuarios Recuperar()
        {
            string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.json");
            Usuarios usuario = JsonSerializer.Deserialize<Usuarios>(json);

            return usuario;
        }
    }
}
