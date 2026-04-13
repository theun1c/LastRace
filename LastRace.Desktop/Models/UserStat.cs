using System;
using System.Collections.Generic;

namespace LastRace.Desktop.Models;

public partial class UserStat
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int LoginCount { get; set; }

    public decimal Balance { get; set; }

    public decimal Rating { get; set; }

    public int Points { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
