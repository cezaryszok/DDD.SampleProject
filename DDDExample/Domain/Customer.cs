using DDDExample.Base.DDD;

namespace DDDExample.Domain
{
  public class Customer : IEntity
  {
    public int Id { get; private set; }
    public bool IsVip { get; private set; }
    public bool IsDebtor { get; private set; }
    public bool IsForeigner { get; private set; }

    public bool IsActive { get; private set; }
  }
}
