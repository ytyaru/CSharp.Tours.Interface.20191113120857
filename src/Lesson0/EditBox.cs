using System;

namespace Tour.Interface.Lesson0 {
    interface IControl { void Paint(); }
    interface IDataBound { void Bind(); }
    public class EditBox: IControl, IDataBound
    {
        public void Paint() { }
        public void Bind() { }
    }
    public class Main {
        public void Run() { Run0(); Run1(); }
        private void Run0() {
            // 暗黙キャスト
            EditBox editBox = new EditBox();
            IControl control = editBox;
            IDataBound dataBound = editBox;
        }
        private void Run1() {
            // 明示キャスト
            object obj = new EditBox();
            IControl control = (IControl)obj;
            IDataBound dataBound = (IDataBound)obj;
        }
    }
}

