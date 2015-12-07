using System.Text;
using System.Security.Cryptography;

namespace ReaperAdminTools
{
    class Encryption
    {
        public string GetSha1Hash( string stringToHash )
        {
            var sha384Object = new SHA384CryptoServiceProvider();
            var bytesToHash = Encoding.ASCII.GetBytes( stringToHash );
            bytesToHash = sha384Object.ComputeHash( bytesToHash );
            
            var resultString = "";
            
            foreach( var b in bytesToHash)
            {
                resultString += b.ToString( "x2" );
            }

            return resultString;
        }
       
    }
}
