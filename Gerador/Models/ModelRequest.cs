using System.IO;
using System.Text;

namespace Gerador.Models
{
    public static class ModelRequest
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine(@"using System.ComponentModel.DataAnnotations;");
            file.AppendLine(@"");
            file.AppendLine($"namespace {estrutura.Namespace}.Models");
            file.AppendLine(@"{");
            file.AppendLine($"    public class {estrutura.NomeEndPoint}RequestModel");
            file.AppendLine(@"    {");
            if (estrutura.CamposEntrada.Count > 0)
            {
                foreach (var item in estrutura.CamposEntrada)
                {
                    if (!string.IsNullOrWhiteSpace(item.Nome))
                    {
                        file.AppendLine(@"        /// <summary>");
                        file.AppendLine($"        /// {item.Observacao}.");
                        file.AppendLine(@"        /// </summary> ");
                        file.AppendLine($"        /// <example>{item.Exemplo}</example>");
                        file.AppendLine(@"        [Required(ErrorMessage = ""Preenchimento obrigatório"")]");
                        file.AppendLine($"        public string {item.Nome}" + " { get; set; }");
                        file.AppendLine($"");
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
