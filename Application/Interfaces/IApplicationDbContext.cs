﻿namespace Application.Interfaces;
public interface IApplicationDbContext
{
    DbSet<Product> Products { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}