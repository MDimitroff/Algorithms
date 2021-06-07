using System.Collections.Generic;
using System.Text;

namespace EncryptWithXOR
{
    public class EncryptWithXOR
    {
        public static byte[] EncryptOrDecrypt(string text, string key)
        {
            List<byte> result = new List<byte>();

            for (int i = 0; i < text.Length; i++)
            {
                int asciiCodeText = text[i];
                int keyPosition = i % key.Length;
                int asciiCodeKey = key[keyPosition];

                // Perform XOR operation on the two characters
                byte combinedCode = (byte) (asciiCodeText ^ asciiCodeKey);
                result.Add(combinedCode);
            }

            return result.ToArray();
        }

        public static byte[] EncryptOrDecrypt(byte[] inputText, string key)
        {
            string text = Encoding.UTF8.GetString(inputText);

            return EncryptOrDecrypt(text, key);
        }
    }
}
