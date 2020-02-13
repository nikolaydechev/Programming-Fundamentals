using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var filesNamesAndSize = new Dictionary<string, Dictionary<string, long>>();
            var Dirs = new List<string>();
            for (int i = 0; i < number; i++)
            {
                var files = Console.ReadLine();
                var filesSplit = files.Split(new[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var root = filesSplit[0];
                var fileName = filesSplit[filesSplit.Count - 2];

                //string[] fileNameExt = fileName.Split('.');
                //var fileExtension = fileNameExt[1];

                var fileSize = long.Parse(filesSplit[filesSplit.Count - 1]);
                if (!filesNamesAndSize.ContainsKey(root))
                {
                    filesNamesAndSize[root] = new Dictionary<string, long>();
                    filesNamesAndSize[root].Add(fileName, fileSize);
                }
                else if (filesNamesAndSize[root].ContainsKey(fileName))
                {
                    filesNamesAndSize[root][fileName] = fileSize;
                }
                else
                {
                    filesNamesAndSize[root].Add(fileName, fileSize);
                }
            }

            var extensionRoot = Console.ReadLine();
            string[] roots = extensionRoot.Split(' ');
            string pattern = @"." + roots[0];
            var regex = new Regex(pattern);
            bool Corresponded = false;

            foreach (var file in filesNamesAndSize)
            {
                foreach (var item in file.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string ext = Path.GetExtension(item.Key);

                    if (regex.IsMatch(ext) && file.Key.Equals(roots[2]))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        Corresponded = true;
                    }
                }
            }
            if (Corresponded == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
