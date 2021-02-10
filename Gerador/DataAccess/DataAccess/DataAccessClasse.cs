using System.IO;
using System.Text;


namespace Gerador.DataAccess.DataAccess
{
    public static class DataAccessClasse
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();
            if (estrutura.RetornoList)
            {
                file.AppendLine($"        public IEnumerable<{estrutura.NomeEndPoint}Dto> {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto request)");

            }
            else if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"        public {estrutura.NomeEndPoint}Dto {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto request)");

            }
            else
            {
                file.AppendLine($"        public void {estrutura.NomeEndPoint}({estrutura.NomeEndPoint}RequestDto request)");

            }
            file.AppendLine(@"        {");
            file.AppendLine(@"            var param = new");
            file.AppendLine(@"            {");
            if (estrutura.CamposEntrada.Count > 0)
            {
                int cont = 0;
                int total = estrutura.CamposEntrada.Count;
                foreach (var item in estrutura.CamposEntrada)
                {
                    cont += 1;
                    if (cont < total)
                    {
                        file.AppendLine($"                {item.Nome} = request.{item.Nome},");
                    }
                    else
                    {
                        file.AppendLine($"                {item.Nome} = request.{item.Nome}");
                    }
                }
            }

            file.AppendLine(@"            };");

            if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"            return _sqlDataAccess.LoadData<{estrutura.NomeEndPoint}Dto, dynamic>(");
                file.AppendLine($"                storedProcedure: \"{estrutura.StoredProcedure}\",");
                file.AppendLine(@"                parameters: param,");
                file.AppendLine(@"                connectionStringName: ""cnn""");

                if (estrutura.RetornoList)
                {
                    file.AppendLine(@"            );");
                }
                else
                {
                    file.AppendLine(@"            ).FirstOrDefault();");
                }
            }
            else
            {
                file.AppendLine(@"            _sqlDataAccess.SaveData(");
                file.AppendLine($"                 storedProcedure: \"{estrutura.StoredProcedure}\",");
                file.AppendLine(@"                 parameters: param,");
                file.AppendLine(@"                 connectionStringName: ""cnn""");
                file.AppendLine(@"            );");
            }



            file.AppendLine(@"        }");


            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }
    }
}
