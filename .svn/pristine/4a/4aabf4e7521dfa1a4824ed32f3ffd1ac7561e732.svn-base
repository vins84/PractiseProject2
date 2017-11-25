using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class NonBlankStringList : Collection<string>
    {
        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Elements of NonBlankStrin must not be Null or WhiteSpace");
            }
            base.InsertItem(index, item);   
        }

        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("Elements of NonBlankStrin must not be Null or WhiteSpace");
            }
            base.SetItem(index, item);
        }
    }
}
