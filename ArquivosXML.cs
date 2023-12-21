using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAutomacao
{
    public static class ArquivosXML
    {
        public static void SalvarXML()
        {
            // Caminho para pasta de Downloads 
            string sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            
            // Caminho para pasta de Destino
            string targetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "eSocial XML");
            
            // Extensão do arquivo que você está procurando
            string fileExtension = "zip";

            try
            {
                string[] files = Directory.GetFiles(sourcePath, $"*.{fileExtension}");

                if (files.Length > 0)
                {
                    Console.WriteLine($"Existem arquivos com a extensão .{fileExtension} em Downloads:");

                    // Verifica se já existe pasta de destino, se não existir cria uma

                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }

                    // Percorre todos arquivos com extenção .zip
                    // e verifica se eles tem algum arquivo .xml que se encaixa no padrão determinado

                    foreach (var currentFile in files)
                    {
                        Console.WriteLine(currentFile);
                        using (ZipArchive archive = ZipFile.OpenRead(currentFile))
                        {

                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.Name != "" && entry.Name.EndsWith(".xml") && entry.Name.StartsWith("ID"))
                                {
                                    string targetFullPath = Path.Combine(targetPath, entry.Name);

                                    // Verifique se o arquivo de destino já existe
                                    if (!File.Exists(targetFullPath))
                                    {
                                        // Extrair o arquivo
                                        entry.ExtractToFile(targetFullPath);
                                        Console.WriteLine($"Arquivo extraído: {targetFullPath}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Arquivo já existe: {targetFullPath}");
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Nenhum arquivo com a extensão .{fileExtension} encontrado em Downloads");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
