using System;
using System.Web;

namespace WebApp.Web.Infrastructure
{
    public class CacheService : ICacheService
    {
        public CacheService()
        {
        }

        public T GetCache<T>(string cacheId, Func<T> getItemCallback) where T : class
        {
            var item = HttpContext.Current.Cache.Get(cacheId) as T;
            if (item == null)
            {
                item = getItemCallback();
                HttpContext.Current.Cache.Insert(cacheId, item);
            }

            return item;
        }

        public T GetCache<T>(string cacheId) where T : class
        {
            var item = HttpContext.Current.Cache.Get(cacheId) as T;
            return item;
        }

        public T GetSession<T>(string sessionId, Func<T> getItemCallback) where T : class
        {
            var item = HttpContext.Current.Session[sessionId] as T;
            if (item == null)
            {
                item = getItemCallback();
                HttpContext.Current.Session[sessionId] = item;
            }

            return item;
        }

        public void RemoveSession(string sessionId)
        {
            HttpContext.Current.Session.Remove(sessionId);
        }

        public void RemoveCache(string cacheId)
        {
            HttpRuntime.Cache.Remove(cacheId);
        }
    }    
}