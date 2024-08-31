using System.ComponentModel;

namespace ASPMProductionStation.Models
{
    class GlobalKeyboardHookEventArgs : HandledEventArgs
    {

        public GlobalKeyboardHookEventArgs(
            GlobalKeyboardHook.LowLevelKeyboardInputEvent keyboardData,
            GlobalKeyboardHook.KeyboardState keyboardState)
        {
            KeyboardData = keyboardData;
            KeyboardState = keyboardState;
        }

        #region Properties
        public GlobalKeyboardHook.LowLevelKeyboardInputEvent KeyboardData { get; private set; }
        public GlobalKeyboardHook.KeyboardState KeyboardState { get; private set; }
        #endregion
    }
}