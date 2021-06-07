using System.Collections.Generic;

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
    }
}
