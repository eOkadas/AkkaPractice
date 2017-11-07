namespace MovieStreaming
{
    using System;
    using Akka.Actor;

    class Program
    {
        private static ActorSystem MovieStreaminActorSystem;

        static void Main(string[] args)
        {
            MovieStreaminActorSystem = ActorSystem.Create("MovieStreaminActorSystem");

            Console.ReadLine();

            MovieStreaminActorSystem.Terminate();
        }
    }
}
