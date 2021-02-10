using System.IO;
using System.Text;

namespace Gerador
{
    public abstract class Base
    {
        public static StringBuilder file;
        public static Estrutura _estrutura { get; set; }
        public Base(Estrutura estrutura)
        {
            _estrutura = estrutura;
        }


        public static void Criar()
        {
            string filePath = _estrutura.LocalSalvar + $"\\{_estrutura.NomeArquivoGerar}.cs";

            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(_estrutura.file.ToString());
            }
        }
    }
}
