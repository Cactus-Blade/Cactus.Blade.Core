﻿public static partial class Extension
{
    /// <summary>
    ///     Indicates whether the character at the specified position in a specified string is categorized as a
    ///     punctuation mark.
    /// </summary>
    /// <param name="this">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>true if the character at position  in  is a punctuation mark; otherwise, false.</returns>
    public static bool IsPunctuation(this string @this, int index)
    {
        return char.IsPunctuation(@this, index);
    }
}