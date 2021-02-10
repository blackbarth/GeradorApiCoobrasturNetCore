using System.IO;
using System.Text;

namespace Gerador.Controllers
{
    public static class Controller
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();


            file.AppendLine(@"        /// <summary>");
            file.AppendLine($"        /// {estrutura.Descricao}.");
            file.AppendLine(@"        /// </summary>");
            file.AppendLine(@"        /// <remarks>");
            file.AppendLine($"        /// {estrutura.Finalidade}<br/>");
            file.AppendLine($"        /// <b>Stored Procedure: </b> {estrutura.StoredProcedure}");
            file.AppendLine(@"        /// </remarks>");
            if (estrutura.CamposEntrada.Count > 0)
            {
                foreach (var item in estrutura.CamposEntrada)
                {
                    file.AppendLine($"        /// <param name=\"{item.Nome}\">{item.Exemplo}</param>");
                }
            }

            file.AppendLine(@"        /// <returns>Retorna os planos cancelados.</returns>");
            file.AppendLine(@"        /// <response code=""200"">Retorna se existe.</response>");
            file.AppendLine(@"        /// <response code=""401"">Usuário não autenticado.</response>");
            file.AppendLine(@"        /// <response code=""403"">Usuário sem permissão.</response>");
            file.AppendLine(@"        /// <response code=""422"">Parâmetros inválidos</response>");
            file.AppendLine(@"        [Authorize]");
            file.AppendLine($"        [{estrutura.TipoMetodo}(\"{estrutura.NomeEndPoint}\")]");

            if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"        public ActionResult<{estrutura.NomeEndPoint}Model> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()})");
            }
            else
            {
                file.AppendLine($"        public ActionResult<object> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestModel {estrutura.NomeEndPoint.ToLower()})");
            }
            file.AppendLine(@"        {");
            file.AppendLine(@"            try");
            file.AppendLine(@"            {");
            file.AppendLine(@"");
            file.AppendLine(@"                Error error = new Error();");
            file.AppendLine(@"                long numerico = 0;");
            file.AppendLine(@"");
            if (estrutura.CamposEntrada.Count > 0)
            {
                foreach (var item in estrutura.CamposEntrada)
                {
                    file.AppendLine($"                if (string.IsNullOrEmpty({estrutura.NomeEndPoint.ToLower()}.{item.Nome}))");
                    file.AppendLine(@"                {");
                    file.AppendLine($"                    error.parameter = \"{item.Nome}\";");
                    file.AppendLine(@"                    error.message = ""Dados inválidos."";");
                    file.AppendLine(@"                    return UnprocessableEntity(error);");
                    file.AppendLine(@"                }");
                }
            }
            if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"                var {estrutura.Controller.ToLower()}Service = _{estrutura.Controller.ToLower()}Service.{estrutura.NomeEndPoint}({estrutura.NomeEndPoint.ToLower()});");
                file.AppendLine(@"");
                file.AppendLine($"                return (ActionResult)Ok({estrutura.Controller.ToLower()}Service);");
            }
            else
            {
                file.AppendLine($"                _{estrutura.Controller.ToLower()}Service.{estrutura.NomeEndPoint}({estrutura.NomeEndPoint.ToLower()});");
                file.AppendLine(@"");
                file.AppendLine(@"                var retorno = new");
                file.AppendLine(@"                {");
                file.AppendLine(@"                    retorno = ""Antecipação efetuada com sucesso.""");
                file.AppendLine(@"                };");
                file.AppendLine(@"                return (ActionResult)Ok(retorno);");

            }
            file.AppendLine(@"");

            file.AppendLine(@"            }");
            file.AppendLine(@"            catch (Exception ex)");
            file.AppendLine(@"            {");
            file.AppendLine(@"                return BadRequest(ex.Message);");
            file.AppendLine(@"            }");
            file.AppendLine(@"        }");


            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }
    }
}
