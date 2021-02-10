using Gerador.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gerador.DataAccess.DataAccess;
using Gerador.DataAccess.Interfaces;
using Gerador.DataAccess.Models;
using Gerador.Interfaces;
using Gerador.Models;
using Gerador.Service;
using Gerador.Profiles;

namespace Gerador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Estrutura estrutura = new Estrutura();
            string diretorio = txtSalvarEm.Text.Trim();
            List<Campo> CamposEntrada = new List<Campo>();
            List<Campo> CamposSaida = new List<Campo>();

            //Criaçao de diretorios
            string PastaController = diretorio + $"\\Controllers";
            string PastaInterfaces = diretorio + $"\\Interfaces";
            string PastaModels = diretorio + $"\\Models";
            string PastaProfiles = diretorio + $"\\Profiles";
            string PastaServices = diretorio + $"\\Service";
            string PastaDataAccessDataAccess = diretorio + $"\\DataAccess\\DataAccess";
            string PastaDataAccessInterfaces = diretorio + $"\\DataAccess\\Interfaces";
            string PastaDataAccessModels = diretorio + $"\\DataAccess\\Models";

            CriarDiretorio.Criar(diretorio);
            CriarDiretorio.Criar(PastaController);
            CriarDiretorio.Criar(PastaInterfaces);
            CriarDiretorio.Criar(PastaModels);
            CriarDiretorio.Criar(PastaProfiles);
            CriarDiretorio.Criar(PastaServices);
            CriarDiretorio.Criar(PastaDataAccessDataAccess);
            CriarDiretorio.Criar(PastaDataAccessInterfaces);
            CriarDiretorio.Criar(PastaDataAccessModels);

            estrutura.TipoMetodo = cbTipoMetodo.Text.Trim();
            estrutura.NomeEndPoint = txtNomeEndPoint.Text.Trim();
            estrutura.StoredProcedure = txtStoredProcedure.Text.Trim();
            estrutura.Namespace = txtNamespace.Text.Trim();
            estrutura.RetornoList = cbRetornaList.Checked;
            estrutura.Controller = cbController.Text.Trim();
            estrutura.Descricao = txtDescricao.Text.Trim();
            estrutura.Finalidade = txtFinalidade.Text.Trim();
            estrutura.Retorno = txtRetorno.Text.Trim();


            foreach (DataGridViewRow linha in gridEntrada.Rows)
            {
                if (!string.IsNullOrWhiteSpace((string)linha.Cells["Nome"].Value))
                    CamposEntrada.Add(new Campo { Tipo = (string)linha.Cells["Tipo"].Value, Nome = (string)linha.Cells["Nome"].Value, Exemplo = (string)linha.Cells["Exemplo"].Value, Observacao = (string)linha.Cells["Observacao"].Value });
            }

            foreach (DataGridViewRow linha in gridSaida.Rows)
            {
                if (!string.IsNullOrWhiteSpace((string)linha.Cells["NomeSaida"].Value))
                    CamposSaida.Add(new Campo { Tipo = (string)linha.Cells["TipoSaida"].Value, Nome = (string)linha.Cells["NomeSaida"].Value });
            }

            estrutura.CamposEntrada = CamposEntrada;
            estrutura.CamposSaida = CamposSaida;


            estrutura.NomeArquivoGerar = $"{cbController.Text.Trim()}Controller";
            estrutura.LocalSalvar = PastaController;
            Controller.Criar(estrutura);

            estrutura.NomeArquivoGerar = $"{cbController.Text.Trim()}DataAccess";
            estrutura.LocalSalvar = PastaDataAccessDataAccess;
            DataAccessClasse.Criar(estrutura);

            estrutura.NomeArquivoGerar = $"I{cbController.Text.Trim()}Service";
            estrutura.LocalSalvar = PastaDataAccessInterfaces;
            InterfacesClasse.Criar(estrutura);



            if (CamposSaida.Count > 0)
            {
                estrutura.NomeArquivoGerar = $"{txtNomeEndPoint.Text.Trim()}Dto";
                estrutura.LocalSalvar = PastaDataAccessModels;
                DTo.Criar(estrutura);
            }


            estrutura.NomeArquivoGerar = $"{txtNomeEndPoint.Text.Trim()}DtoRequest";
            estrutura.LocalSalvar = PastaDataAccessModels;
            DtoRequest.Criar(estrutura);

            estrutura.NomeArquivoGerar = $"I{cbController.Text.Trim()}Service";
            estrutura.LocalSalvar = PastaInterfaces;
            IService.Criar(estrutura);

            if (CamposSaida.Count > 0)
            {
                estrutura.NomeArquivoGerar = $"{txtNomeEndPoint.Text.Trim()}Model";
                estrutura.LocalSalvar = PastaModels;
                Model.Criar(estrutura);
            }


            estrutura.NomeArquivoGerar = $"{txtNomeEndPoint.Text.Trim()}ModelRequest";
            estrutura.LocalSalvar = PastaModels;
            ModelRequest.Criar(estrutura);


            estrutura.NomeArquivoGerar = $"{cbController.Text.Trim()}Profile";
            estrutura.LocalSalvar = PastaProfiles;
            Profile.Criar(estrutura);

            estrutura.NomeArquivoGerar = $"{cbController.Text.Trim()}Service";
            estrutura.LocalSalvar = PastaServices;
            ServiceClasse.Criar(estrutura);


            estrutura.NomeArquivoGerar = $"{cbController.Text.Trim() + txtNomeEndPoint.Text.Trim()}Documentacao";
            estrutura.LocalSalvar = diretorio;
            Documentacao.Criar(estrutura);


        }

        private void btnSalvarEm_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSalvarEm.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
