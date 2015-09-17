using Nancy;

namespace Tanks.Web.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => "Hello World!";
        } 
    }
}