namespace BlazorApp1.Services
{
    public class encryptionService
    {
        public string Encrypt( string input )
        {
            string outputText = "";

            foreach( char letter in input )
            {
                char encryptedLetter;

                if( char.IsLetter( letter ) )
                {
                    if( letter > 'w' )
                    {
                        encryptedLetter = (char)(letter - 23);
                    }
                    else
                    {
                        encryptedLetter = (char)(letter + 3);
                    }
                }
                else
                {
                    encryptedLetter = letter;
                }

                outputText += encryptedLetter;
            }
            return outputText;
        }

        public string Decrypt( string output )
        {
            string inputText = "";

            foreach( char letter in output )
            {
                char encryptedLetter;
                if( char.IsLetter( letter ) )
                {
                    if( letter < 'd' )
                    {
                        encryptedLetter = (char)(letter + 23);
                    }
                    else
                    {
                        encryptedLetter = (char)(letter - 3);
                    }
                }
                else
                {
                    encryptedLetter = letter;
                }
                inputText += encryptedLetter;
            }
            return inputText;
        }

    }
}
