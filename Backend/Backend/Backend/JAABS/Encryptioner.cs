using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.JAABS
{
    internal class Encryptioner
    {
        //Standard Caesar Encryption

        public string EncryptKey(string key)
        {
            for (int i = 0; i < key.Length; i++)
            {
                key = key.Remove(i, 1).Insert(i, Convert.ToString(Convert.ToChar((key[i] + 25) % 255)));
            }
            return key;
        }
    }
}
