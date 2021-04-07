﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class CadastroTarefa : Form
    {
        public CadastroTarefa()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gtarefasDataSet);

        }

        private void CadastroTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gtarefasDataSet.responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.gtarefasDataSet.responsavel);

        }
    }
}
