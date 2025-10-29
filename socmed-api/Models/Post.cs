using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace socmed_api.Models;

public partial class Post
{
    public long Id { get; set; }

    public long PostedByUserId { get; set; }

    public string PostBody { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public virtual User PostedByUser { get; set; } = null!;
}

public class PostCreateDto
{
    [Required]
    public long PostedByUserId { get; set; }

    [Required]
    public string PostBody { get; set; } = null!;
}