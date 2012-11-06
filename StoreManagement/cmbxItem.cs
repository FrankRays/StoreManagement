using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    class cmbxItem : Object
    {
        private string text;
        public cmbxItem(string text)
        {
            this.text = text;
        }
        public override string ToString()
        {
            return text;
        }
    }
}
