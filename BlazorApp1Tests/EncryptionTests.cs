using BlazorApp1.Services;

namespace EncryptionTests
{
    [TestClass]
    public class EncryptionServiceTests
    {
        [TestMethod]
        public void Encrypt_Method_Returns_Correct_Result()
        {
            // Arrange
            encryptionService service = new encryptionService();

            // Act
            string result = service.Encrypt( "abc" );

            // Assert
            Assert.AreEqual( "def", result );
        }

        [TestMethod]
        public void Decrypt_Method_Returns_Correct_Result()
        {
            // Arrange
            encryptionService service = new encryptionService();

            // Act
            string result = service.Decrypt( "def" );

            // Assert
            Assert.AreEqual( "abc", result );
        }

        [TestMethod]
        public void Encrypt_WrapsAroundAlphabet()
        {
            // Arrange
            encryptionService service = new encryptionService();

            // Act
            string result = service.Encrypt( "xyz" );

            // Assert
            Assert.AreEqual( "abc", result );
        }

        [TestMethod]
        public void Decrypt_WrapsBackwards()
        {
            // Arrange
            encryptionService service = new encryptionService();

            // Act
            string result = service.Decrypt( "abc" );

            // Assert
            Assert.AreEqual( "xyz", result );
        }
    }
}