using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Image
    {
        public int height; // pixels
        public int width;
        string source;      // file name
        string quality;
        string gallery = "I AM Gallery";

        public Image(int height, int width, string source, string quality)
        {
            this.height = height;
            this.width = width;
            this.source = source;
            this.quality = quality;

            Console.WriteLine("Image Height: " + height + " Image Width: " + width);
            Console.WriteLine(("File Name: " + source + " Image Quality: " + quality));
            Console.WriteLine("Gallery: " + gallery);
        }
    }

    public class ImageExamples
    {
        public Image img1 = new Image(5, 10, "small.gif", "low");
        public Image img2 = new Image(10, 53, "med.gif", "medium");

        public ImageExamples()
        {
            Console.ReadLine();
        }
    }
}
