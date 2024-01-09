using Microsoft.AspNetCore.WebUtilities;
using Microsoft.CodeAnalysis;
using System;
using System.Net;

namespace ExploreCalifornia.Services
{
    public class FormattingService
    {
        public String formatDate(DateTime date)
        {
            return date.ToString("D");
        }

        public String formatHTML(String data)
        {
            data = WebUtility.HtmlDecode(data).Replace("\"", "\'");
            return data;
        }
    }
}
