using System.IO;

namespace CursoCSharp.Api {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string? home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    internal class PrimeiroArquivo {
        public static void Executar() {
            // \t -> tab
            var s = "\teste\testes\a.txt";
            Console.WriteLine(s);
            // @ antes dá string ele a interpreta de maneira literal
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                // Cria um novo arquivo
                using(StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
                // Acrescenta um novo texto no arquivo existente
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("");
                    sw.WriteLine("É possível");
                    sw.WriteLine("adicionar");
                    sw.WriteLine("mais texto!");
                }
            }
        }
    }
}
