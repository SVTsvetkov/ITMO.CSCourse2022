using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    public sealed class HTMLTokenVisitor  : ITokenVisitor //NullTokenVisitor
    {
        public void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.Write("{0,3}", line.Number());
            Console.Write("</span>");
        }

        public void Visit(ILineEndToken t)
        {
            Console.WriteLine();
        }
        public void Visit(IIdentifierToken token)
        {
            //Console.Write(token.ToString());
            SpannedFilteredWrite("identifier", token);
        }

        public void Visit(ICommentToken t)
        {
            //Console.Write("<span class=\"comment\">");
            //FilteredWrite(t);
            //Console.Write("</span>");
            SpannedFilteredWrite("comment", t);

        }

        public void Visit(IKeywordToken t)
        {
            //Console.Write("<span class=\"keyword\">");
            //FilteredWrite(t);
            //Console.Write("</span>");
            SpannedFilteredWrite("keyword", t);

        }
        public void Visit(IWhiteSpaceToken t)
        {
            Console.Write(t.ToString());
        }
        public void Visit(IOtherToken t)
        {
            FilteredWrite(t);
        }

        public void Visit(IDirectiveToken token)
        {
            SpannedFilteredWrite("directive", token);
        }


        private void FilteredWrite(IToken token)
        {
            string src = token.ToString();
            for (int i = 0; i != src.Length; i++)
            {
                string dst;
                switch (src[i])
                {
                    case '<':
                        dst = "&lt;"; break;
                    case '>':
                        dst = "&gt;"; break;
                    case '&':
                        dst = "&amp;"; break;
                    default:
                        dst = new string(src[i], 1); break;
                }
                Console.Write(dst);
            }
        }
        private void SpannedFilteredWrite(string spanName, IToken token)
        {
            Console.Write("<span class=\"{0}\">", spanName);
            FilteredWrite(token);
            Console.Write("</span>");
        }

    }

}
