using System;

namespace Tour.Interface.Lesson1 {
    interface IControl { void Paint(); }
    interface IDataBound { void Bind(); }
    public class EditBox: IControl, IDataBound
    {
        void IControl.Paint() { }
        void IDataBound.Bind() { }
    }
    public class Main {
        public void Run() {
            EditBox editBox = new EditBox();
//            editBox.Paint();            // Error, no such method.  error CS1061
            IControl control = editBox;
            control.Paint();            // Ok
        }
    }
}

