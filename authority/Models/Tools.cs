using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;


public class Tools
{
    static public string BytesToString(byte[] array)
    {
        var sb = new StringBuilder();
        foreach (var b in array)
        {
            sb.AppendFormat("{0:x2}", b);
        }
        return sb.ToString();
    }
}

public static class ByteArrayExtend
{

}

public static class StringExtend
{
    static public string SHA256(this string str)
    {
        var s = System.Security.Cryptography.SHA256.Create() ;
        var buffer = UTF8Encoding.UTF8.GetBytes(str);
        var bytes = s.ComputeHash(buffer);
        return Tools.BytesToString(bytes);
    }
}