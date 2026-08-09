using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _followerId;
        private Guid _followeeId;
        private DateTime _followedAt;

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FolloweeId
        {
            get { return _followeeId; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }
    }
}
