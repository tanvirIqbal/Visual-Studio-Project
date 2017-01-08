using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class PhotoFilters
    {
        public void ApplyBrighness(Photo photo)
        {
            Console.WriteLine("Apply Brightness.");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast.");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize Photo.");
        }
    }
}
