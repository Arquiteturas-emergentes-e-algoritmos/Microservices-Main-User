﻿namespace User.Domain.Entities.Abstract;
public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}
