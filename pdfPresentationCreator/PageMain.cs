using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfPresentationCreator
{
    public class PageMain: Page
    {
        public string Title;
        public string Author;

        public PageMain(string name) : base(name)
        {

        }
    }
}
