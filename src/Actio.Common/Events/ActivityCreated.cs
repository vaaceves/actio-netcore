namespace Actio.Common.Events
{
    public interface ActivityCreated : IAuthenticatedEvent
    {
         public Guid Id { get; }

        public Guid UserId { get; }

        public string Category { get; }

        public string Name { get; }

        public string Description { get; }

        public DateTime CreatedAt { get; }

        protected ActivityCreated ()
        {
        }

        public ActivityCreated (Guid id, Guid userid, string category)
        {
            Id = id;
            UserId = userid;
            Category = category;
        }
    }
}