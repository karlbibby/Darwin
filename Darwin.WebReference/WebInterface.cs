using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Darwin.Enum;

namespace Darwin.WebReference
{
    public class WikipediaInterface
    {
        public static List<string> GetSearchResults(string searchterm)
        {
            //http://en.wikipedia.org/w/api.php?action=opensearch&search=Te
            List<string> output = new List<string>();
            // execute the request
            string search = "http://en.wikipedia.org/w/api.php?action=opensearch&search=" + searchterm;

            HttpWebRequest request = (HttpWebRequest)
    WebRequest.Create(search);
            request.UserAgent = "F@Soft Browser";

            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();
            string tempString = null;
            int count = 0;

            // used to build entire input
            StringBuilder sb = new StringBuilder();

            // used on each read operation
            byte[] buf = new byte[8192];

            do
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);

                // make sure we read some data
                if (count != 0)
                {
                    // translate from bytes to ASCII text
                    tempString = Encoding.ASCII.GetString(buf, 0, count);

                    // continue building the string
                    sb.Append(tempString);
                }
            }
            while (count > 0); // any more data to read?

            //["Isotoma viridis",[]]
            string[] s = tempString.Split('[');
            string[] t = s[2].Split(']');
            string[] u = t[0].Split(',');
            foreach (string item in u)
            {
                if (item.Length > 0)
                {
                    output.Add(item.Replace("\"", ""));
                }
            }
            return output;
        }
    }
    public class DarwinWeblink
    {
        public static string GetURL(LinkType type, string input)
        {
            string returnstr = "";
            switch (type)
            {
                case LinkType.Bird:
                    returnstr = "http://www.rspb.org.uk/wildlife/birdguide/name/"+input.ToLower()[0]+"/"+input.ToLower().Replace(" ","").Replace("-","")+"/index.aspx";
                    break;
                default:
                    break;
            }
            return returnstr;
        }
    }
}
