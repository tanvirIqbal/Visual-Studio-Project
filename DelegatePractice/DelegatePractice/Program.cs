using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrighness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RedEyeRemover;
            processor.Process("Photo.jpg", filterHandler);
        }

        static void RedEyeRemover(Photo photo)
        {
            Console.WriteLine("Apply RedEyeRemover");
        }
    }
}
