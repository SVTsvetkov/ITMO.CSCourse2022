using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    internal abstract class Token : IToken
    {
        /// <param name="begin">begin</param>
        /// <param name="end">end</param>
        /// <remarks>
        /// It would be useful to check if
        /// (<paramref name="begin">begin</paramref> ==
        /// <paramref name="end">end</paramref>)
        /// and throw an exception if so.
        /// </remarks>

        protected Token(Position begin, Position end)
        {
            this.begin = begin;
            this.end = end;
        }

        public override string ToString()
        {
            return Position.MakeString(begin, end);
        }

        /// <remarks>
        /// Note that Accept is added to the internal
        /// implementation hierarchy and not to the 
        /// public interface hierarchy. That is, Accept
        /// is method of Token but not of IToken.
        /// </remarks>

        internal abstract void Accept(ITokenVisitor visitor);

        private readonly Position begin, end;
    }
}
