using System;
using System.IO;

namespace Gerador
{
    public static class CriarDiretorio
    {
        public static void Criar(string path)
        {

            try
            {
                Diretorio($"{path}");
            }
            catch (Exception e)
            {
                Console.WriteLine("O Processo Falhou: {0}", e.ToString());
            }
            finally { }
        }


        private static void Diretorio(string dir)
        {

            if (Directory.Exists(dir))
            {
                return;
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(dir);
            }
        }
    }
}
