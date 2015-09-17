using Nancy;

namespace Tanks.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => "Hello World!";
        } 
    }
}