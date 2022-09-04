using System.Collections.Generic;

namespace BrovkoChatApi.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public List<User> Users { get; set; }

    }
}
