using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{
    [Serializable]
    public class QuestionClass
    {
        public Image Img { get; set; }
        public char Answer { get; set; }

        public QuestionClass(Image i, char c)
        {
            Img = i;
            Answer = c;
        }
    }
}
