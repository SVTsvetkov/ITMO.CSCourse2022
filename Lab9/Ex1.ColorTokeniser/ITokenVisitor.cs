using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    public interface ITokenVisitor
    {
        void Visit(ILineStartToken t);
        void Visit(ILineEndToken t);

        void Visit(ICommentToken t);
        void Visit(IDirectiveToken t);
        void Visit(IIdentifierToken t);
        void Visit(IKeywordToken t);
        void Visit(IWhiteSpaceToken t);

        void Visit(IOtherToken t);
    }
}
