namespace MovieStreaming
{
    using System;
    using Akka.Actor;
    using MovieStreaming.Actors;
    using MovieStreaming.Messages;

    class Program
    {
        private static ActorSystem MovieStreaminActorSystem;

        static void Main(string[] args)
        {
            MovieStreaminActorSystem = ActorSystem.Create("MovieStreaminActorSystem");
            Console.WriteLine("Actor system created");

            var playbackActorProps = Props.Create<PlaybackActor>();

            var playbackActorRef = MovieStreaminActorSystem.ActorOf(playbackActorProps, "PlaybackActor");

            var message = new PlayMovieMessage("Akka.NET: The Movie", 42);
            playbackActorRef.Tell(message);

            Console.ReadLine();

            MovieStreaminActorSystem.Terminate();
        }
    }
}
