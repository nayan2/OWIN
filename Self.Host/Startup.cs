using Owin;

namespace Self.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("My First Owin Application");
            });
        }
    }
}