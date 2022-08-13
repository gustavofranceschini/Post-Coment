using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_PostComent.Entities
{
    class Coment
    {
        public string Text { get; set; }

        public Coment()
        {
        }

        public Coment(string text)
        {
            Text = text;
        }
    }
}
