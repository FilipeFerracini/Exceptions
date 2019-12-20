using System;

namespace ExFixacao.Entities.Exception
{
    class DomainException:ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
