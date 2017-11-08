namespace MovieStreaming
{
    using System;
    using Akka.Actor;
    using MovieStreaming.Actors;
    using MovieStreaming.Messages;

    class Program
    {
        private static ActorSystem _movieStreaminActorSystem;

        static void Main()
        {
            _movieStreaminActorSystem = ActorSystem.Create("MovieStreaminActorSystem");
            Console.WriteLine("Actor system created");

            var playbackActorProps = Props.Create<PlaybackActor>();
            var playbackActorRef = _movieStreaminActorSystem.ActorOf(playbackActorProps, "PlaybackActor");
            
            playbackActorRef.Tell(new PlayMovieMessage("Akka.NET: The Movie", 42));
            playbackActorRef.Tell(new PlayMovieMessage("Partial Recall", 99));
            playbackActorRef.Tell(new PlayMovieMessage("Boolean Lies", 77));
            playbackActorRef.Tell(new PlayMovieMessage("Codenan the Destroyer", 1));

            playbackActorRef.Tell(PoisonPill.Instance);

            Console.ReadKey();
            
            _movieStreaminActorSystem.Terminate();

            _movieStreaminActorSystem.WhenTerminated.Wait();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
