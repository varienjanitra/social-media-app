using System;
using System.Collections.Generic;

namespace socmed_api.Models;

public partial class Post
{
    public long Id { get; set; }

    public long PostedByUserId { get; set; }

    public string PostBody { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public virtual User PostedByUser { get; set; } = null!;
}
