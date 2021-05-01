using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClassLibrary.Helpers
{
    public class SessionHelper<T>
    {
        public Controller Controller { get; set; }
        public SessionHelper(Controller controller)  => this.Controller = controller;
        public ISession Session { get; set; }
        public SessionHelper(ISession session) => Session = session;
        public T this[string key]{
            get{
                var value = Controller == null ? Session.GetString(key) : Controller.HttpContext.Session.GetString(key);
                return value == null ? default : JsonConvert.DeserializeObject<T>(value); 
            }
            set{
                Controller.HttpContext.Session.SetString(key, JsonConvert.SerializeObject(value));
            }
        }
    }
}