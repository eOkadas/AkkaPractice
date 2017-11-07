namespace MovieStreaming.Actors
{
    using System;
    using System.Runtime.CompilerServices;
    using Akka.Actor;
    using MovieStreaming.Messages;

    public class PlaybackActor : ReceiveActor
    {
        public PlaybackActor()
        {
            Console.WriteLine("Creating PlaybackActor");
            
            Receive<PlayMovieMessage>(message => HandlePlayMovieMessage(message), userIdPredicate);

            void HandlePlayMovieMessage(PlayMovieMessage message)
            {
                Console.WriteLine($"Receive movie title {message.MovieTitle}");
                Console.WriteLine($"Receive user ID {message.UserId}");
            }

            bool userIdPredicate(PlayMovieMessage message) => message.UserId == 42;
        }
    }
}
