using System.IO;
using System.Text;

namespace Gerador.DataAccess.Interfaces
{
    public static class InterfacesClasse
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine($"using {estrutura.Namespace}.DataAccess.Models;");
            file.AppendLine(@"using System.Collections.Generic;");
            file.AppendLine(@"");
            file.AppendLine($"namespace {estrutura.Namespace}.DataAccess.Interfaces");
            file.AppendLine(@"{");
            file.AppendLine($"    public interface I{estrutura.Controller}DataAccess");
            file.AppendLine(@"    {");
            if (estrutura.RetornoList)
            {
                file.AppendLine($"        public IEnumerable<{estrutura.NomeEndPoint}Dto> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto {estrutura.NomeEndPoint.ToLower()});");

            }
            else if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"        public {estrutura.NomeEndPoint}Dto {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto {estrutura.NomeEndPoint.ToLower()});");

            }
            else
            {
                file.AppendLine($"        public void {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto {estrutura.NomeEndPoint.ToLower()});");

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
