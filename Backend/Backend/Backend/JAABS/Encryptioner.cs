using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS
{
    internal class Encryptioner
    {
        //Standard Caesar Encryption

        public static string EncryptKey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                key = key.Remove(i, 1).Insert(i, Convert.ToString(Convert.ToChar((key[i] + 25) % 256)));
            }
            return key;
        }
        public static string DecryptKey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                key = key.Remove(i, 1).Insert(i, Convert.ToString(Convert.ToChar((key[i] - 25 + 256) % 256)));
            }
            return key;
        }

        public static string EncryptPin(string pin)
        {
            for (int i = 0; i < pin.Length; i++)
            {
                pin = pin.Remove(i, 1).Insert(i, Convert.ToString(Convert.ToChar((pin[i] + 52) % 256)));
            }
            return pin;
        }
    }
}
