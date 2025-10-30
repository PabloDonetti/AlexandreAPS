using System;

namespace MinhaAplicacao.Domain.ValueObjects
{
    public class Identifier
    {
        public Guid Value { get; private set; }

        public Identifier(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException("Identifier cannot be empty.", nameof(value));
            }

            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Identifier other)
            {
                return Value.Equals(other.Value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}