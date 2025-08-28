using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Core.Interface.Shared
{
    /// <summary>
    /// 解決題目實作
    /// </summary>
    public interface ISolution
    {
        void Solve();
    }

    /// <summary>
    /// 解決題目實作
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface ISolution<TInput, TResult>
    {
        TResult Solve(TInput input);
    }

    /// <summary>
    /// 解決題目實作
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    public interface ISolution<TInput>
    {
        void Solve(TInput input);
    }
}