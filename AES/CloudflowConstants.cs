using System;
using System.Collections.Generic;
using System.Text;

namespace AES
{
    public class CloudflowConstants
    {
        private OkHttpClient client = new OkHttpClient();

        private CloudflowConfiguration configuration;
        private string AccessToken;
        private string RefreshToken;
        private long ExpiredUntil;

        private String fileAccessToken;
    }
}
