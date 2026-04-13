using System;
using System.Collections.Generic;

namespace LastRace.Desktop.Models;

public partial class User
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual UserStat? UserStat { get; set; }
}
