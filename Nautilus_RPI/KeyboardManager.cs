using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus_RPI
{
    public class KeyboardManager
    {
        public static string textString;
        static string _textField;
        public static string keyActivation()
        {

            NautilusKey keyboard = new NautilusKey();
            keyboard.ShowDialog();

            return textString;
        }

        public static string textField
        {
            get
            {
                return _textField;
            }
            set
            {
                _textField = value;
            }
        }

    }
}
