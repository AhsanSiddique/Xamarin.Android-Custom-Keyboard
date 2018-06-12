using Android.App;
using Android.Widget;
using Android.OS;
using Android.InputMethodServices;
using Android.Runtime;
using Android.Views;
using Java.Lang;

namespace CustomKeyboard
{
    [Service(Permission = "android.permission.BIND_INPUT_METHOD",
        Label = "CustomKeyboard")]
    [MetaData("android.view.im", Resource = "@xml/method")]
    [IntentFilter(new string[] { "android.view.InputMethod" })]
    public class MainActivity : InputMethodService, KeyboardView.IOnKeyboardActionListener
    {
        private KeyboardView kv;
        private Keyboard kb;
        private bool isCaps = false;

        public override View OnCreateInputView()
        {
            kv = (KeyboardView)LayoutInflater.Inflate(Resource.Layout.Keyboard, null);
            kb = new Keyboard(this, Resource.Xml.Qwerty);
            kv.Keyboard = kb;
            kv.OnKeyboardActionListener = this;
            return kv;
                
        }
        public void OnKey([GeneratedEnum] Android.Views.Keycode primaryCode, [GeneratedEnum] Android.Views.Keycode[] keyCodes)
        {
            
        }

        public void OnPress([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnRelease([GeneratedEnum] Android.Views.Keycode primaryCode)
        {
            
        }

        public void OnText(ICharSequence text)
        {
            
        }

        public void SwipeDown()
        {
            
        }

        public void SwipeLeft()
        {
            
        }

        public void SwipeRight()
        {
            
        }

        public void SwipeUp()
        {
            
        }
    }
}

