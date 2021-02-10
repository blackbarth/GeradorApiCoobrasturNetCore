using System.IO;
using System.Text;

namespace Gerador.DataAccess.Models
{
    public static class DTo
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine($"namespace {estrutura.Namespace}.DataAccess.Models");
            file.AppendLine(@"{");
            file.AppendLine($"    public class {estrutura.NomeEndPoint}Dto");
            file.AppendLine(@"    {");
            if (estrutura.CamposSaida.Count > 0)
            {
                foreach (var item in estrutura.CamposSaida)
                {
                    if (!string.IsNullOrWhiteSpace(item.Nome))
                    {
                        file.AppendLine($"        public {item.Tipo} {item.Nome}" + " { get; set; }");
                    }

                }
            }

            file.AppendLine(@"    }");
            file.AppendLine(@"}");

            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }
    }
}
