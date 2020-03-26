using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogs_K300
{
    public static class LangExtensions
    {
        public static string Language(this HttpCookieCollection cookie)
        {
            return cookie["k300"]?.Value;
        }
    }
}