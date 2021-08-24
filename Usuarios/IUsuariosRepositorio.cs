using System;
using System.Collections.Generic;
using System.Text;

namespace VDRDataAnalyzer
{
    public interface IUsuariosRepositorio
    {
        public void Salvar(Usuarios usuario);
        public Usuarios Recuperar();
    }
}
