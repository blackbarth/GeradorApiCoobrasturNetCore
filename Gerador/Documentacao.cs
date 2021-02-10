
using System.IO;
using System.Text;

namespace Gerador
{
    public static class Documentacao
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();
            file.AppendLine($"    /api/{estrutura.Controller}/{estrutura.NomeEndPoint} ");
            file.AppendLine($"");
            file.AppendLine($"    STATUS ");
            file.AppendLine($"");
            file.AppendLine($"    Publicada  ​");
            file.AppendLine($"");
            file.AppendLine($" ");
            file.AppendLine($"");
            file.AppendLine($"    Utilizada nos fluxos: ");
            file.AppendLine($"");
            file.AppendLine($" ");
            file.AppendLine($" ");
            file.AppendLine($"");
            file.AppendLine($"    DESCRIÇÃO DA UTILIZAÇÃO DA API ");
            file.AppendLine($"");
            file.AppendLine($"    {estrutura.Finalidade}. ");
            file.AppendLine($"");
            file.AppendLine($" ");
            file.AppendLine($"");
            file.AppendLine($"    RESULTADO ");
            file.AppendLine($"");
            file.AppendLine($"    " + "{ ");
            file.AppendLine($"      \"response\": \"sim ou não\" ");
            file.AppendLine($"    " + "} ");

            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }

    }
}
