using Res.Common.Entities;

namespace Res.Domain.Entities;

public partial class BranchStore : BaseRemovableAuditablePaginationEntity
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? RFC { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? SecondaryPhone { get; set; }

    public int GeographicalZoneId { get; set; }

    public bool? IsCentralBranchStore { get; set; }

    public virtual ICollection<Address> Address { get; } = new List<Address>();

    public virtual ICollection<BoxCash> BoxCash { get; } = new List<BoxCash>();

    public virtual ICollection<BranchStoreEmployee> BranchStoreEmployee { get; } = new List<BranchStoreEmployee>();

    public virtual ICollection<Cart> Cart { get; } = new List<Cart>();

    public virtual ICollection<Customer> Customer { get; } = new List<Customer>();

    public virtual ICollection<Employee> Employee { get; } = new List<Employee>();

    public virtual ICollection<GeographicalZone> GeographicalZone { get; } = new List<GeographicalZone>();

    public virtual ICollection<ManagerZoneBranchStore> ManagerZoneBranchStore { get; } = new List<ManagerZoneBranchStore>();

    public virtual ICollection<Menu> Menu { get; } = new List<Menu>();

    public virtual ICollection<Order> Order { get; } = new List<Order>();

    public virtual ICollection<Payment> Payment { get; } = new List<Payment>();

    public virtual ICollection<PayBox> PayBox { get; } = new List<PayBox>();

    public virtual ICollection<Reservation> Reservation { get; } = new List<Reservation>();

    public virtual ICollection<Ticket> Ticket { get; } = new List<Ticket>();

    public virtual ICollection<UserAccount> UserAccount { get; } = new List<UserAccount>();
}