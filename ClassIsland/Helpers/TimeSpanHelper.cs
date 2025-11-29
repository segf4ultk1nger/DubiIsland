using System;
using System.Runtime.CompilerServices; // 建议引入，但不是必须

namespace ClassIsland.Helpers;

public static class TimeSpanHelper
{
    public const double MaxTimeSpanSeconds = 2147483.0;

    public static TimeSpan FromSecondsSafe(double seconds)
    {
        // 关键修改点：
        // 在 .NET 6 中，用 !IsNaN(s) && !IsInfinity(s) 来替代 IsRealNumber(s)
        bool isReal = !double.IsNaN(seconds) && !double.IsInfinity(seconds);

        // 如果不是实数（NaN 或 Inf），则返回 TimeSpan.Zero
        // 否则，将其限制在 [0, MaxTimeSpanSeconds] 范围内，并转换为 TimeSpan
        return !isReal
            ? TimeSpan.Zero
            : TimeSpan.FromSeconds(Math.Max(0, Math.Min(MaxTimeSpanSeconds, seconds)));
    }
}