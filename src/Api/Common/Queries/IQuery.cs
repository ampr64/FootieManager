﻿using MediatR;

namespace Api.Common.Queries
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
        
    }
}
