using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    internal static class FileManager
    {
        public static void Add(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            if (!entity.IsValid())
            {
                throw new Exception("Entity is invalid");
            }

            var record = entity.Format();

            using (var writer = new StreamWriter(entity.FileName, append: true))
            {
                writer.WriteLine(record);
            }
        }

        public static List<Entity> Read(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File does not exist", path);
            }

            // Читаємо всі рядки з файлу
            var lines = File.ReadAllLines(path);

            if (lines.Length == 0)
            {
                MessageBox.Show("The file is empty.");
                return new List<Entity>();
            }

            var results = new List<Entity>();

            foreach (var line in lines)
            {
                var entity = new Car();
                try
                {
                    entity.Parse(line);
                    results.Add(entity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error parsing line: {line}. Error: {ex.Message}", "Parse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return results;
        }

    }
}
