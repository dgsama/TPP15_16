
using System.Security.Cryptography;
using System.Text;


namespace LabExam20161
{
    //Exercise 5

    public class MD5Hash
    {
        public virtual string MD5(string password)
        {
            var textBytes = Encoding.Default.GetBytes(password);
            var cryptHandler = new MD5CryptoServiceProvider();
            var hash = cryptHandler.ComputeHash(textBytes);
            var ret = "";
            foreach (var a in hash)
            {
                ret += a.ToString("x2");
            }
            return ret;
        }
    }
}
