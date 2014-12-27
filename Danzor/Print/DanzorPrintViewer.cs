using System.Collections.Generic;

namespace Danzor.Print
{
    public class DanzorPrintViewer
    {
        public List<DanzorPage> Pages { get; set; }

        public DanzorPrintViewer(string path)
        {
            var manager = new DanzorPrintManager(path);

            this.Pages = manager.GeneratePages();
        }
    }
}
