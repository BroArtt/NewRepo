using System;

namespace BrovkoChatApi.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

    }
}
