namespace VDRDataAnalyzer
{
    public class UsuariosServicos
    {
        IUsuariosRepositorio usuariosRepositorio;

        public UsuariosServicos(IUsuariosRepositorio _usuariosRepositorio)
        {
            usuariosRepositorio = _usuariosRepositorio;
        }

        public void Salvar(Usuarios usuario)
        {
            usuariosRepositorio.Salvar(usuario);
        }
        public Usuarios Recuperar()
        {
            return usuariosRepositorio.Recuperar();
        }
    }
}
