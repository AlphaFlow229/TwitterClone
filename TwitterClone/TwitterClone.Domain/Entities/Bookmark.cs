namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _tweetId;
        private DateTime _bookMarkAt;


        public Guid UserId
        {
            get { return _id; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }


        public DateTime BookMarkAt
        {
            get { return _bookMarkAt; }
        }


    }
}
