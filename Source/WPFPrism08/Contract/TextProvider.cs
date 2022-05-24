using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contract;

namespace Contract
{
    public class TextProvider : ITextProvider
    {
        private int i = 0;

        public string GetText()
        {
            i++;
            return string.Format("From TextProvider [{0}]", i);
        }
    }
}
