using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    internal sealed class Other
    {
        internal static
        IOtherToken MakeToken(Position begin, Position end)
        {
            return new OtherToken(begin, end);
        }

        private sealed class OtherToken : Token, IOtherToken
        {
            internal OtherToken(Position begin, Position end)
              : base(begin, end)
            {
            }

            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        private Other() { }
    }
}
