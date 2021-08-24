using System;
using System.IO;
using System.Text.Json;

namespace VDRDataAnalyzer
{
    public class UsuariosRepositorioCripto : IUsuariosRepositorio
    {
        public void Salvar(Usuarios usuario)
        {
            string json = JsonSerializer.Serialize(usuario);
            
            Cripto c = new Cripto();
            json = c.Criptografar(json);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.cfg";
            File.WriteAllText(path, json);
        }

        public Usuarios Recuperar()
        {
            Usuarios usuario;

            try
            {
                string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Usuario.cfg");

                Cripto c = new Cripto();
                json = c.Descriptografar(json);

                usuario = JsonSerializer.Deserialize<Usuarios>(json);
            }
            catch (Exception)
            {
                usuario = new Usuarios();
                usuario.Empresa = "";
                usuario.NomeUsuario = "";
            }
            return usuario;
        }
    }
}
