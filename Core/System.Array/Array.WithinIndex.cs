﻿public static partial class Extension
{
    /// <summary>
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool WithinIndex(this System.Array @this, int index)
    {
        return index >= 0 && index < @this.Length;
    }

    /// <summary>
    ///     An Array extension method that check if the array is lower then the specified index.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="index">Zero-based index of the.</param>
    /// <param name="dimension">(Optional) the dimension.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    // ReSharper disable once MethodOverloadWithOptionalParameter
    public static bool WithinIndex(this System.Array @this, int index, int dimension = 0)
    {
        return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
    }
}

