using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VDRDataAnalyzer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = textBoxUsuario.Text;
            usuario.Empresa = textBoxEmpresa.Text;

            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioXML());
            _UsuariosServicos.Salvar(usuario);

        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioXML());
            Usuarios usuario = _UsuariosServicos.Recuperar();
            textBoxUsuario.Text = usuario.NomeUsuario;
            textBoxEmpresa.Text = usuario.Empresa;
        }

        private void buttonSalvarJSON_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = textBoxUsuario.Text;
            usuario.Empresa = textBoxEmpresa.Text;

            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            _UsuariosServicos.Salvar(usuario);

        }

        private void buttonRecuperarJSON_Click(object sender, EventArgs e)
        {
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            Usuarios usuario = _UsuariosServicos.Recuperar();
            textBoxUsuario.Text = usuario.NomeUsuario;
            textBoxEmpresa.Text = usuario.Empresa;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxEmpresa.Text = "";

        }

        private void buttonSalvarCripto_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = textBoxUsuario.Text;
            usuario.Empresa = textBoxEmpresa.Text;

            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioCripto());
            _UsuariosServicos.Salvar(usuario);

        }

        private void buttonRecuperarCripto_Click(object sender, EventArgs e)
        {
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioCripto());
            Usuarios usuario = _UsuariosServicos.Recuperar();
            textBoxUsuario.Text = usuario.NomeUsuario;
            textBoxEmpresa.Text = usuario.Empresa;

        }
    }
}
