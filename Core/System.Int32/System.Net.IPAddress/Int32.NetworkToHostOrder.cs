﻿using System.Net;

public static partial class Extension
{
    /// <summary>
    ///     Converts an integer value from this byte order to host byte order.
    /// </summary>
    /// <param name="this">The number to convert, expressed in this byte order.</param>
    /// <returns>An integer value, expressed in host byte order.</returns>
    public static int NetworkToHostOrder(this int @this)
    {
        return IPAddress.NetworkToHostOrder(@this);
    }
}