using System.IO;
using System.Text;


namespace Gerador.Profiles
{
    public static class Profile
    {
        public static void Criar(Estrutura estrutura)
        {
            StringBuilder file = new StringBuilder();


            if (estrutura.CamposSaida.Count > 0)
            {
                file.AppendLine($"            CreateMap<{estrutura.NomeEndPoint}Model, {estrutura.NomeEndPoint}Dto>()");
                foreach (var item in estrutura.CamposSaida)
                {
                    file.AppendLine($"                 .ForMember(dest => dest.{item.Nome}, opt => opt.MapFrom(src => src.{item.Nome}))");
                }
                file.AppendLine(@"                 .ReverseMap();");
                file.AppendLine(@"         ");
            }


            if (estrutura.CamposEntrada.Count > 0)
            {
                file.AppendLine($"            CreateMap<{estrutura.NomeEndPoint}RequestModel, {estrutura.NomeEndPoint}RequestDto>()");

                foreach (var item in estrutura.CamposEntrada)
                {
                    file.AppendLine($"                 .ForMember(dest => dest.{item.Nome}, opt => opt.MapFrom(src => src.{item.Nome}))");
                }
                file.AppendLine(@"                 .ReverseMap();");
            }




            string filePath = estrutura.LocalSalvar + $"\\{estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(file.ToString());
            }

        }
    }
}
