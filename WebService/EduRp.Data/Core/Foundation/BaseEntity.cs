
namespace EduRp.Data.Core.Foundation
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int? UserId { get; set; }
        public int? TokenId { get; set; }
    }
}
