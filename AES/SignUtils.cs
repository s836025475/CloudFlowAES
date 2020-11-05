using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public class SignUtils
    {
        public static string Sign(string[] data)
        {
            Arrays.sort(data);
            return DigestUtils.sha1Hex(Join(data));
        }

        public static string Join(object param)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < param.length; i++)
            {
                sb.append(param[i]);
            }
            return sb.toString();
        }
    }
}
