using System.IO;
using System.Text;

namespace Gerador.Service
{
    public static class ServiceClasse
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();

            file.AppendLine(@"using AutoMapper;");
            file.AppendLine($"using {estrutura.Namespace}.DataAccess.Interfaces;");
            file.AppendLine($"using {estrutura.Namespace}.DataAccess.Models;");
            file.AppendLine($"using {estrutura.Namespace}.Models;");
            file.AppendLine($"using {estrutura.Namespace}.Service.Interface;");
            file.AppendLine(@"using System.Collections.Generic;");
            file.AppendLine(@"");
            file.AppendLine($"namespace {estrutura.Namespace}.Service");
            file.AppendLine(@"{");
            file.AppendLine($"    public class {estrutura.Controller}Service : I{estrutura.Controller}Service");
            file.AppendLine(@"    {");
            file.AppendLine($"        private I{estrutura.Controller}DataAccess _{estrutura.Controller.ToLower()}DataAccess;");
            file.AppendLine(@"        private IMapper _mapper;");
            file.AppendLine(@"");
            file.AppendLine($"        public {estrutura.Controller}Service(I{estrutura.Controller}DataAccess {estrutura.Controller.ToLower()}DataAccess, IMapper mapper)");
            file.AppendLine(@"        {");
            file.AppendLine($"            _{estrutura.Controller.ToLower()}DataAccess = {estrutura.Controller.ToLower()}DataAccess;");
            file.AppendLine(@"            _mapper = mapper;");
            file.AppendLine(@"        }");
            file.AppendLine(@"");
            if (estrutura.RetornoList)
            {
                file.AppendLine($"        public List<{estrutura.NomeEndPoint}Model> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()})");
            }
            else if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"        public {estrutura.NomeEndPoint}Model {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()})");
            }
            else
            {
                file.AppendLine($"        public void {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()})");
            }
            file.AppendLine(@"        {");
            if (estrutura.RetornoList)
            {
                file.AppendLine($"            return  _mapper.Map<List<{estrutura.NomeEndPoint}Model>>(_{estrutura.Controller.ToLower()}DataAccess.{estrutura.NomeEndPoint}(_mapper.Map<List<{estrutura.NomeEndPoint}RequestDto>>({estrutura.NomeEndPoint.ToLower()})));");

            }
            else if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"            return  _mapper.Map<{estrutura.NomeEndPoint}Model>(_{estrutura.Controller.ToLower()}DataAccess.{estrutura.NomeEndPoint}(_mapper.Map<{estrutura.NomeEndPoint}RequestDto>({estrutura.NomeEndPoint.ToLower()})));");
            }
            else
            {
                file.AppendLine($"            _{estrutura.Controller.ToLower()}DataAccess.{estrutura.NomeEndPoint}(_mapper.Map<{estrutura.NomeEndPoint}RequestDto>({estrutura.NomeEndPoint.ToLower()}));");
            }
            file.AppendLine(@"        }");

            file.AppendLine(@"");
            file.AppendLine(@"");
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
