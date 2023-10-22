using Res.Common.Entities;

namespace Res.Domain.Entities;

public partial class ActiveUserAccountEmployee : BaseQueryable
{
    public string UserName { get; set; } = null!;

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string CellPhone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int JobId { get; set; }

    public string JobName { get; set; } = null!;

    public string Name => $"{this.FirstName} {this.MiddleName} {this.LastName}".Trim();
}