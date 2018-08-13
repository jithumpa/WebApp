using System;

namespace WebApp.Web.Infrastructure
{
    public interface ICacheService
    {
        T GetCache<T>(string cacheId, Func<T> getItemCallback) where T : class;

        T GetSession<T>(string sessionId, Func<T> getItemCallback) where T : class;

        T GetCache<T>(string cacheId) where T : class;

        void RemoveSession(string sessionId);

        void RemoveCache(string cacheId);
    }
}