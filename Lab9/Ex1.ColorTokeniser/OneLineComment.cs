using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    internal sealed class OneLineComment
    {
        internal static bool Match(Position begin, Position end)
        {
            return end - begin >= 2 && Utility.Equal(begin, begin + 2, "//");
        }

        internal static Position Eat(Position begin, Position end)
        {
            return Utility.Find(begin, end, '\n');
        }

        internal static
        ICommentToken MakeToken(Position begin, Position end)
        {
            return new OneLineCommentToken(begin, end);
        }

        private sealed class OneLineCommentToken : Token, ICommentToken
        {
            internal OneLineCommentToken(Position begin, Position end)
              : base(begin, end)
            {
            }

            internal override void Accept(ITokenVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        private OneLineComment() { }
    }
}
