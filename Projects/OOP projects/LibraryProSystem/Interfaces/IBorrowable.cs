using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProSystem.Interfaces
{
    public interface IBorrowable
    {
        bool CheckAvailability();
        void Borrow();
        void Return();
    }

}
