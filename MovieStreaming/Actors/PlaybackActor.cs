namespace MovieStreaming.Actors
{
    using System;
    using Akka.Actor;
    using MovieStreaming.Messages;

    public class PlaybackActor : UntypedActor
    {
        public PlaybackActor() => Console.WriteLine("Creating PlaybackActor");

        protected override void OnReceive(object message)
        {
            if (message is PlayMovieMessage playMovieMessage)
            {
                Console.WriteLine($"Receive movie title {playMovieMessage.MovieTitle}");
                Console.WriteLine($"Receive user ID {playMovieMessage.UserId}");
            }
            else
            {
                Unhandled(message);
            }
        }
    }
}
