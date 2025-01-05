using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

namespace PhotoDownloaderConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введіть URL фото:");
            string url = Console.ReadLine();

            Console.WriteLine("Введіть шлях та ім'я файлу для збереження:");
            string savePath = Console.ReadLine();

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(savePath))
            {
                Console.WriteLine("URL або шлях не може бути порожнім.");
                return;
            }

            try
            {
                await DownloadPhotoAsync(url, savePath);
                Console.WriteLine("Фото успішно завантажено!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }

        static async Task DownloadPhotoAsync(string url, string savePath)
        {
            using (HttpClient client = new HttpClient())
            {
                byte[] imageBytes = await client.GetByteArrayAsync(url);

                string directory = Path.GetDirectoryName(savePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                await File.WriteAllBytesAsync(savePath, imageBytes);
            }
        }
    }
}
