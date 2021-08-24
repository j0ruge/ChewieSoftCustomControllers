﻿using System;
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

        private void cTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = userName.Texts;
            usuario.Empresa = companyName.Texts;

            //UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioCripto());
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            _UsuariosServicos.Salvar(usuario);
            this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            UsuariosServicos _UsuariosServicos = new UsuariosServicos(new UsuariosRepositorioJSON());
            Usuarios usuario = _UsuariosServicos.Recuperar();
            userName.Text = usuario.NomeUsuario;
            companyName.Text = usuario.Empresa;

        }


    }
}