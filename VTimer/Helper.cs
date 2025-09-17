using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTimer
{
    internal class Helper
    {
        const int iDefaultFormWidth = 380;
        const int iDefaultFormHeight = 300;

        public static void SetFormBounds(Form form,
                              int defaultFormWidth = 0,
                              int defaultFormHeight = 0)
        {
            _ = defaultFormWidth > 0 ? defaultFormWidth : iDefaultFormWidth;
            _ = defaultFormHeight > 0 ? defaultFormHeight : iDefaultFormHeight;

            form.Size = new Size(iDefaultFormWidth, iDefaultFormHeight);            
        }

        public Helper() { }

    }
}
