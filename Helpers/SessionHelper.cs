using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FitComrade.Entities;

namespace FitComrade.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
        public static void GetSession(this ISession session)
        {

            if(session.IsAvailable == true)
            {
                
                if(myUser.SessionID == null)
                {
                    myUser.SessionID = session.Id;
                }
                
            }
            
        }
        public static Profile myUser = new Profile();
        
        
        






    }
}
