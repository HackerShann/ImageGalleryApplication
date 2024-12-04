using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imageGallery
{
    internal class ImageItem
    {
        public string FilePath { get; private set; }
        public string FileName { get; private set; }
        public DateTime DateUploaded { get; private set; }
        public List<string> Tags { get; private set; }

        public ImageItem(string filePath)
        {
            FilePath = filePath;
            FileName = System.IO.Path.GetFileName(filePath);
            DateUploaded = DateTime.Now;
            Tags = new List<string>();
        }

        public void AddTag(string tag)
        {
            if (!Tags.Contains(tag))
            {
                Tags.Add(tag);
            }
        }

    }
}
