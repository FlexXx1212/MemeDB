using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MemeDB.Models
{
    public class Meme
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string[] Tags { get; set; }
        public ImageSource Thumbnail { get; set; }

        public Meme(string name, string path, string[] tags, ImageSource thumbnail)
        {
            Name = name;
            Path = path;
            Tags = tags;
            Thumbnail = thumbnail;
        }
    }
}
