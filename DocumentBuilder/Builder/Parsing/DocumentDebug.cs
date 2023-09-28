using DocumentBuilder.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilder.Builder
{
    internal static class DocumentDebug
    {
        public static void PrintComponents(Document document)
        {
            foreach(Page page in document.pages)
            {
                Debug.Logs.LogDebugMessage($"Page (Height = {page.height}) (Width = {page.width}");



            }
        }
    }
}
