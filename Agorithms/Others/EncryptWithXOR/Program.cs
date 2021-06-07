using System;
using System.Text;

namespace EncryptWithXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalText = "Hello World!";
            string encryptionKey = "Sofia2021";

            byte[] encryptedText = EncryptWithXOR.EncryptOrDecrypt(originalText, encryptionKey);
            byte[] decryptedText = EncryptWithXOR.EncryptOrDecrypt(encryptedText, encryptionKey);

            Console.WriteLine($"Value in plain text = {originalText}");
            Console.WriteLine($"Encrypted text = { Encoding.UTF8.GetString(encryptedText) }");
            Console.WriteLine($"Decrypted text = { Encoding.UTF8.GetString(decryptedText) }");
            Console.WriteLine($"Does decrypted value equal to the plain text's value? { Encoding.UTF8.GetString(decryptedText) == originalText}");
        }
    }
}
