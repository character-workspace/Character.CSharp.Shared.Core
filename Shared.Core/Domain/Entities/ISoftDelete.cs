﻿namespace Shared.Core.Domain.Entities;

public interface ISoftDelete
{
    public bool IsDeleted { get; set; }
}