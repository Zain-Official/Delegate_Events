using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Events
{
    class fEvent
    {
        public event onEventHandler FiveEvent;
        public void GotFive()
        {
            FiveEvent(this,EventArgs.Empty);
        }
    }
}
