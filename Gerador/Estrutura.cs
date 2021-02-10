using System.Collections.Generic;
using System.Text;

namespace Gerador
{
    public class Estrutura
    {
        public string Controller { get; set; }
        public string Namespace { get; set; }
        public string Descricao { get; set; }
        public string Finalidade { get; set; }
        public string LocalSalvar { get; set; }
        public string NomeArquivoGerar { get; set; }
        public string StoredProcedure { get; set; }
        public string TipoMetodo { get; set; }
        public string NomeEndPoint { get; set; }
        public string Retorno { get; set; }
        public bool RetornoList { get; set; }
        public StringBuilder file { get; set; }
        public List<Campo> CamposEntrada { get; set; }
        public List<Campo> CamposSaida { get; set; }

    }
}
