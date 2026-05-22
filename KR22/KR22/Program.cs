using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace KR22
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static async Task ReadingFile(string path)
        {
            var storage = new Storage<Quest>();

            path = "quests.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("файл не найден!");
                return;
            }

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length != 3)
                {
                    continue;
                }
                var Quest = new Quest
                {
                    Name = parts[0],
                    Status = parts[1],
                    Reward = int.Parse(parts[2]),
                };
            }
        }
    }
}
