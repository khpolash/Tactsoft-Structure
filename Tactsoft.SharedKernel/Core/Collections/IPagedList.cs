﻿namespace Tactsoft.SharedKernel.Core.Collections;

public interface IPagedList<T>
{
    IList<T> Items { get; set; }

    int Total { get; set; }
}
