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


        public string VigenèreEncrypt( string input )
        {
            string output = "";
            string key = "DOG";

            int keyIndex = 0;

            foreach( char letter in input )
            {
                if( char.IsLetter( letter ) )
                {
                    int shift = char.ToUpper( key[ keyIndex ] ) - 'A';

                    char encryptedLetter =
                        (char)(((letter - 'a' + shift) % 26) + 'a');

                    output += encryptedLetter;

                    keyIndex++;

                    if( keyIndex >= key.Length )
                    {
                        keyIndex = 0;
                    }
                }
                else
                {
                    output += letter;
                }
            }

            return output;
        }

        public string VigenèreDecrypt( string output )
        {
            string input = "";
            string key = "DOG";

            int keyIndex = 0;

            foreach( char letter in output )
            {
                if( char.IsLetter( letter ) )
                {
                    int shift = char.ToUpper( key[ keyIndex ] ) - 'A';

                    char decryptedLetter =
                        (char)(((letter - 'a' - shift + 26) % 26) + 'a');

                    input += decryptedLetter;

                    keyIndex++;

                    if( keyIndex >= key.Length )
                    {
                        keyIndex = 0;
                    }
                }
                else
                {
                    input += letter;
                }
            }

            return input;
        }

    }
}
