using System.IO;
using System.Text;

namespace Gerador.Interfaces
{
    public static class IService
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine($"using {estrutura.Namespace}.Models;");
            file.AppendLine(@"using System.Collections.Generic;");
            file.AppendLine(@"");
            file.AppendLine($"namespace {estrutura.Namespace}.Interface");
            file.AppendLine(@"{");
            file.AppendLine($"    public  interface I{estrutura.Controller}Service");
            file.AppendLine(@"    {");

            if (estrutura.RetornoList)
            {
                file.AppendLine($"        public List<{estrutura.NomeEndPoint}Model> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()});");

            }
            else if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"        public {estrutura.NomeEndPoint}Model {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()});");
            }
            else
            {
                file.AppendLine($"        public void {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()});");
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
