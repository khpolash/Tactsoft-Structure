﻿using Microsoft.EntityFrameworkCore;

namespace Tactsoft.SharedKernel.Core.Helpers;

public class PaginatedList<T>(IEnumerable<T> items, int count, int pageIndex, int pageSize) : List<T>(items)
{
    public int PageIndex { get; } = pageIndex;

    public int TotalPages { get; } = (int)Math.Ceiling(count / (double)pageSize);

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;

    public static PaginatedList<T> CreateFromLinqQueryable(IQueryable<T> source, int pageIndex, int pageSize)
    {
        var count = source.Count();
        var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        return new PaginatedList<T>(items, count, pageIndex, pageSize);
    }

    public static async Task<PaginatedList<T>> CreateFromEfQueryableAsync(
        IQueryable<T> source,
        int pageIndex,
        int pageSize)
    {
        var count = await source.CountAsync();
        var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        return new PaginatedList<T>(items, count, pageIndex, pageSize);
    }
}
