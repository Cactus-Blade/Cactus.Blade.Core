﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An Int64 extension method that days the given this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan.</returns>
    public static TimeSpan Days(this long @this)
    {
        return TimeSpan.FromDays(@this);
    }
}