namespace yourConf.VideoHub {
    using Owin;

    public class Startup {
        public void Configuration(IAppBuilder app) {
            // Specify that UserId should be pull from the IIdentity.Name
            app.MapSignalR();
        }
    }
}