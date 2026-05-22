using BlazorApp1.Services;

namespace EncryptionTests
{
    [TestClass]
    public class EncryptionServiceTests
    {
        [TestMethod]
        public void Caesar_Encrypt_Returns_Correct_Result()
        {
            encryptionService service = new encryptionService();

            string result = service.Encrypt( "abc" );

            Assert.AreEqual( "def", result );
        }

        [TestMethod]
        public void Caesar_Decrypt_Returns_Correct_Result()
        {
            encryptionService service = new encryptionService();

            string result = service.Decrypt( "def" );

            Assert.AreEqual( "abc", result );
        }

        [TestMethod]
        public void Caesar_Encrypt_Wraps_Around_Alphabet()
        {
            encryptionService service = new encryptionService();

            string result = service.Encrypt( "xyz" );

            Assert.AreEqual( "abc", result );
        }

        [TestMethod]
        public void Caesar_Decrypt_Wraps_Backwards()
        {
            encryptionService service = new encryptionService();

            string result = service.Decrypt( "abc" );

            Assert.AreEqual( "xyz", result );
        }

        [TestMethod]
        public void Vigenere_Encrypt_Returns_Correct_Result()
        {
            encryptionService service = new encryptionService();

            string result = service.VigenèreEncrypt( "hello" );

            Assert.AreEqual( "ksroc", result );
        }

        [TestMethod]
        public void Vigenere_Decrypt_Returns_Correct_Result()
        {
            encryptionService service = new encryptionService();

            string result = service.VigenèreDecrypt( "ksroc" );

            Assert.AreEqual( "hello", result );
        }
    }
}