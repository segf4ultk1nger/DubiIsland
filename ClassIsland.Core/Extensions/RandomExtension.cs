// RandomExtensions.cs

using System;
using System.Runtime.InteropServices;
// 核心依赖：需要 System.Runtime.InteropServices 引用 MemoryMarshal

namespace ClassIsland.Core.Extensions
{
    // 假设你的 Shuffle 逻辑是放在 Random 实例内部，因为 Next(int, int) 是实例方法。
    // 为了兼容，我们把它做成一个扩展方法，让它看起来像是 Random 的实例方法。
    public static class RandomExtensions
    {
        // ----------------------------------------------------
        // 1. Array 适配器 (你的第一个方法)
        // ----------------------------------------------------
        /// <summary>
        /// Performs an in-place shuffle of an array. (Polyfill for modern .NET)
        /// </summary>
        /// <param name="random">The Random instance used for shuffling.</param>
        public static void Shuffle<T>(this Random random, T[] values)
        {
            // ArgumentNullException.ThrowIfNull(values); // .NET 6 中没有，用传统方式替代
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // 你的核心代码：
            // 依赖 MemoryMarshal.GetArrayDataReference 暴露底层指针
            // 然后构造 Span<T> 视图
            random.Shuffle(MemoryMarshal.CreateSpan(ref MemoryMarshal.GetArrayDataReference(values), values.Length));
        }

        // ----------------------------------------------------
        // 2. Span 核心实现 (你的第二个方法，作为私有帮助方法)
        // ----------------------------------------------------
        /// <summary>
        /// Performs an in-place shuffle of a span. (Fisher-Yates)
        /// </summary>
        private static void Shuffle<T>(this Random random, Span<T> values)
        {
            int n = values.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // 注意：这里调用的是 Random.Next(i, n)，它是 .NET 6 中就有的重载
                int j = random.Next(i, n);

                if (j != i)
                {
                    // 高效交换 (Swap)
                    T temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                }
            }
        }
    }
}