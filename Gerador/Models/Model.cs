using System.IO;
using System.Text;

namespace Gerador.Models
{
    public static class Model
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine(@"using System.ComponentModel.DataAnnotations;");
            file.AppendLine(@"");
            file.AppendLine($"namespace {estrutura.Namespace}.Models");
            file.AppendLine(@"{");
            file.AppendLine($"    public class {estrutura.NomeEndPoint}Model");
            file.AppendLine(@"    {");
            if (estrutura.CamposSaida.Count > 0)
            {
                foreach (var item in estrutura.CamposSaida)
                {
                    if (!string.IsNullOrWhiteSpace(item.Nome))
                    {
                        file.AppendLine($"        public {item.Tipo} {item.Nome}" + " { get; set; }");
                        file.AppendLine($"");
                    }

                }
            }

            file.AppendLine(@"    }");
            file.AppendLine(@"}");
            file.AppendLine(@"");

            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }
    }
}
