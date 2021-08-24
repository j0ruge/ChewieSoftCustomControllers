using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDRDataAnalyzer;

namespace CustomController
{
    public partial class EntryPointForm : Form
    {
        public EntryPointForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.FormSettings_Load);
        }

        private void btnCallMaterialForm_Click(object sender, EventArgs e)
        {
            var materialForm = new TMaterialForm();
            materialForm.ShowDialog();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = ifUserName.Text;
            usuario.Empresa = companyName.Text;

            //UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioCripto());
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            _UsuariosServicos.Salvar(usuario);
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            Usuarios usuario = _UsuariosServicos.Recuperar();
            ifUserName.Text = usuario.NomeUsuario;
            userName.Text = usuario.NomeUsuario;
            companyName.Text = usuario.Empresa;

        }


    }
}
