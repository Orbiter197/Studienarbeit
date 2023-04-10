using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using Skizziere.Model.Shapes;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.IO;

namespace Skizziere.Model
{
    public static class Export
    {
        public static void SaveAsJson(List<BasicItem> objs)
        {
            string content = JsonConvert.SerializeObject(objs);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы Json (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, content);
        }
        public static List<BasicItem> LoadAsJson()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы Json (*.json)|*.json";
            if (openFileDialog.ShowDialog() == true)
                return JsonConvert.DeserializeObject<List<BasicItem>>
                    (File.ReadAllText(openFileDialog.FileName)) ?? new List<BasicItem>();
            return new List<BasicItem>();
        }
    }
}
