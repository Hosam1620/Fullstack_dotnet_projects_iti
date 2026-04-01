using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem
{
    public abstract class LibraryItem
    {
        public int ID { get; set; }
        public string Title { get; set; }

        protected LibraryItem(int id, string title)
        {
            ID = id;
            Title = title;
        }

        public abstract void DisplayInfo();
    }
}
