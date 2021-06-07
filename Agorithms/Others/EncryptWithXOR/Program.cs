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
            byte[] encryptedText, decryptedText = null;
            string encryptedTexAsString, decryptedTexAsString = null;

            encryptedText = EncryptWithXOR.EncryptOrDecrypt(originalText, encryptionKey);
            encryptedTexAsString = Encoding.UTF8.GetString(encryptedText);

            decryptedText = EncryptWithXOR.EncryptOrDecrypt(encryptedTexAsString, encryptionKey);
            decryptedTexAsString = Encoding.UTF8.GetString(decryptedText);

            Console.WriteLine($"Value in plain text = {originalText}");
            Console.WriteLine($"Encrypted text = {encryptedTexAsString}");
            Console.WriteLine($"Decrypted text = {decryptedTexAsString}");
            Console.WriteLine($"Does decrypted value equal to the plain text's value? {decryptedTexAsString == originalText}");
        }
    }
}
