﻿using System;
using System.Collections.Generic;

namespace lamlai.Models;

public partial class Notification
{
    public int NotificationId { get; set; }

    public int UserId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime CreatedAt { get; set; }

    public int RelatedId { get; set; }

    public string RelatedType { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual User User { get; set; } = null!;
}
