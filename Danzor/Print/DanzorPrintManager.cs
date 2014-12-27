using System;
using System.Collections.Generic;
using System.Linq;

namespace Danzor.Print
{
    internal class DanzorPrintManager
    {
        public static int MAX_ITEM_PER_PAGE = 20;
        public static int MIN_ITEM_PER_PAGE = 15;

        private dynamic nfe;
        private dynamic protNFe;

        public DanzorPrintManager(string path)
        {
            this.nfe = DanzorSerializer.DeserializerNFe(path);
            this.protNFe = DanzorSerializer.DeserializerProtNFe(path);
        }

        public List<DanzorPage> GeneratePages()
        {
            return ApportionPages().ToList();
        }

        private IEnumerable<DanzorPage> ApportionPages()
        {
            var pageSize = PageSize();
            for (int i = 1; i <= PageSize(); i++)
                yield return new DanzorPage(this.nfe, this.protNFe, i, pageSize);
        }

        private int PageSize()
        {
            var totalItems = (double)this.nfe.infNFe.det.Count;

            if (totalItems <= MIN_ITEM_PER_PAGE)
                return 1;
            else if (totalItems <= MAX_ITEM_PER_PAGE)
                return 2;
            else
            {
                var pages = Convert.ToInt32(Math.Ceiling(totalItems / MAX_ITEM_PER_PAGE));
                return pages < 1 ? 1 : pages;
            }
        }
    }
}
