using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Objects;

namespace Darwin.DataAccess
{
    public static class ExtensionMethod
    {
        public static TResult NextId<TSource, TResult>(this ObjectSet<TSource> table, Expression<Func<TSource, TResult>> selector)
            where TSource : class
        {
            TResult lastId = table.Any() ? table.Max(selector) : default(TResult);

            if (lastId is int)
            {
                lastId = (TResult)(object)(((int)(object)lastId) + 1);
            }

            return lastId;
        }
    }
}
