// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using Antlr.Runtime;
using System;
namespace HqlIntellisense
{
    
    public class AntlrSimpleHQLLexer : ISimpleHQLLexer
    {
	    private HqlLexer lexer;
	    private IToken token;
	    public AntlrSimpleHQLLexer(string cs,int len)
        {
            var stream = new ANTLRStringStream(cs.Substring(0, len));
            lexer = new HqlLexer(stream);
	    }

	    public int GetTokenLength()
        {
		    if(token.Text==null)
            {
			    return 0;
		    }
		    return token.Text.Length;
	    }

	    public int GetTokenOffset() 
        {
            return token.CharPositionInLine;//-1;
	    }

	    public int NextTokenId() 
        {
		    try {
			    token = lexer.NextToken();
			    
		    }
		    catch (Exception e) {
			    throw new SimpleLexerException(e);
		    }
		    return token.Type;
	    }
    }
}