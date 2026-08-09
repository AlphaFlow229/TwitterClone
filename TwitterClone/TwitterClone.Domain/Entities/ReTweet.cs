namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        public Guid _userId;
        public Guid _tweetId;
        public DateTime _reTweetedAt;


        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime ReTweetedAt
        {
            get { return _reTweetedAt; }
        }
    }
}
