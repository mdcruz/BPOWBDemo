using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBViewsLibrary.Base
{
    public class WinElementBase
    {
        protected Window _window;

        public WinElementBase(Window window)
        {
            _window = window;
        }

        public Button Button(SearchCriteria criteria)
        {
            return _window.Get<Button>(criteria);
        }

        public TextBox TextBox(SearchCriteria criteria)
        {
            return _window.Get<TextBox>(criteria);
        }

        public Tab Tab(SearchCriteria criteria)
        {
            return _window.Get<Tab>(criteria);
        }
    }
}
