using System;
using System.Collections.Generic;

namespace socmed_api.Models;

public partial class User
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
