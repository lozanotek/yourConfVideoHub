namespace yourConf.VideoHub
{
    using Microsoft.AspNet.SignalR;

    public class VideoHub : Hub
    {
        public void Play(string videoId)
        {
            Clients.All.PlayVideo(videoId);
        }
    }
}