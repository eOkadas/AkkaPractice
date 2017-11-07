namespace MovieStreaming.Messages
{
    public class PlayMovieMessage
    {
        public string MovieTitle { get; set; }

        public int UserId { get; set; }

        public PlayMovieMessage(string movieTitle, int userId)
        {
            MovieTitle = movieTitle;
            UserId = userId;
        }
    }
}
