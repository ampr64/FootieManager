using CsvHelper.Configuration;
using System;
using System.Linq.Expressions;

namespace Infrastructure.Files.Maps
{
    internal abstract class AbstractMap<T> : ClassMap<T>
    {
        internal protected AbstractMap(Action<MemberMap<T,)
        {

        }

        protected MemberMap<T, TMember> MapWithNameConvention<TMember>(Expression<Func<T, TMember>> expression, bool useExistingMap = true) =>
            Map(expression, useExistingMap).Name(nameof(TMember));
    }
}
