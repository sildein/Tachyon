/*
 * Shared.cs
 * This file is a part of Nimbus. Copyright (c) 2017-present Jesse Jones.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nimbus
{
    public static class Shared
    {
        // User-configurable variables
        public static string Title;
        public static string Prefix;
        public static string Port;
        public static UserDatabase Users;
        public static AdminSettings Admin;


        // Get MIME types
        public static string GetContentType(string FilePath)
        {
            string Extension =
                System.IO.Path.GetExtension(FilePath).ToLowerInvariant();
            if (MIMETypes.ContainsKey(Extension))
                return MIMETypes[Extension];
            else
                return "application/octet-stream";
        }


        // Get SHA512 hash of string
        public static string GetHash(string Thing)
        {
            StringBuilder HashString = new StringBuilder();
            byte[] Hash =
                SHA512.Create().ComputeHash(Encoding.ASCII.GetBytes(Thing));

            foreach (byte b in Hash) HashString.Append(b.ToString("x2"));

            return HashString.ToString();
        }


        // Get random string
        public static string GetRandomHash()
        {
            byte[] RandomBytes = new byte[16384];
            new Random().NextBytes(RandomBytes);
            return Shared.GetHash(Encoding.ASCII.GetString(RandomBytes));
        }


        public static Dictionary<string, string> MIMETypes =
            new Dictionary<string, string>() {
            {"asf", "video/x-ms-asf"},
            {"asx", "video/x-ms-asf"},
            {"avi", "video/x-msvideo"},
            {"bin", "application/octet-stream"},
            {"cco", "application/x-cocoa"},
            {"crt", "application/x-x509-ca-cert"},
            {"css", "text/css"},
            {"deb", "application/octet-stream"},
            {"der", "application/x-x509-ca-cert"},
            {"dll", "application/octet-stream"},
            {"dmg", "application/octet-stream"},
            {"ear", "application/java-archive"},
            {"eot", "application/octet-stream"},
            {"exe", "application/octet-stream"},
            {"flv", "video/x-flv"},
            {"gif", "image/gif"},
            {"hqx", "application/mac-binhex40"},
            {"htc", "text/x-component"},
            {"htm", "text/html"},
            {"html", "text/html"},
            {"ico", "image/x-icon"},
            {"img", "application/octet-stream"},
            {"iso", "application/octet-stream"},
            {"jar", "application/java-archive"},
            {"jardiff", "application/x-java-archive-diff"},
            {"jng", "image/x-jng"},
            {"jnlp", "application/x-java-jnlp-file"},
            {"jpeg", "image/jpeg"},
            {"jpg", "image/jpeg"},
            {"js", "application/x-javascript"},
            {"mml", "text/mathml"},
            {"mng", "video/x-mng"},
            {"mov", "video/quicktime"},
            {"mp3", "audio/mpeg"},
            {"mpeg", "video/mpeg"},
            {"mpg", "video/mpeg"},
            {"msi", "application/octet-stream"},
            {"msm", "application/octet-stream"},
            {"msp", "application/octet-stream"},
            {"pdb", "application/x-pilot"},
            {"pdf", "application/pdf"},
            {"pem", "application/x-x509-ca-cert"},
            {"pl", "application/x-perl"},
            {"pm", "application/x-perl"},
            {"png", "image/png"},
            {"prc", "application/x-pilot"},
            {"ra", "audio/x-realaudio"},
            {"rar", "application/x-rar-compressed"},
            {"rpm", "application/x-redhat-package-manager"},
            {"rss", "text/xml"},
            {"run", "application/x-makeself"},
            {"sea", "application/x-sea"},
            {"shtml", "text/html"},
            {"sit", "application/x-stuffit"},
            {"swf", "application/x-shockwave-flash"},
            {"tcl", "application/x-tcl"},
            {"tk", "application/x-tcl"},
            {"txt", "text/plain"},
            {"war", "application/java-archive"},
            {"wbmp", "image/vnd.wap.wbmp"},
            {"wmv", "video/x-ms-wmv"},
            {"xml", "text/xml"},
            {"xpi", "application/x-xpinstall"},
            {"zip", "application/zip"},
        };
    }
}
