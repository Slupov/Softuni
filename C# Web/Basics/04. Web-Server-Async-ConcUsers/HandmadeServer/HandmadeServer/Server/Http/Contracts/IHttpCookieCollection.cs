﻿using System.Collections.Generic;

namespace HandmadeServer.Server.Http.Contracts
{
    public interface IHttpCookieCollection : IEnumerable<HttpCookie>
    {
        void Add(HttpCookie cookie);

        void Add(string key, string value);
        
        bool ContainsKey(string key);

        HttpCookie Get(string key);
    }
}
