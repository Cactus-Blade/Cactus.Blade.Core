﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an int?</returns>
    public static int? ToNullableInt32OrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (int?)null : Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return default(int);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an int?</returns>
    public static int? ToNullableInt32OrDefault(this object @this, int? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (int?)null : Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an int?</returns>
    public static int? ToNullableInt32OrDefault(this object @this, Func<int?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (int?)null : Convert.ToInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}