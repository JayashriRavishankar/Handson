using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface Subject

    {
       int GetState { get; set; }

        void ChangeState(int val);
        void Attach(IObserver o);

        void Detach(IObserver o);
    }
}
