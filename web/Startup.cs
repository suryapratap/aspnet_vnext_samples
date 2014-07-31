namespace WebApplication1
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
 
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}
