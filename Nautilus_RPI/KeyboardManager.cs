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

        public static string keyActivation()
        {

            NautilusKey keyboard = new NautilusKey();
            keyboard.ShowDialog();

            return textString;
        }
    }
}
