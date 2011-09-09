// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
namespace HqlIntellisense
{


public class SimpleLexerException :Exception 
{

	public SimpleLexerException()
    {
		
	}

	public SimpleLexerException(string message, Exception cause)
        :base( message, cause )
    {
		
	}

	public SimpleLexerException(string message) 
        :base(message)
    {
		
	}

	public SimpleLexerException(Exception cause)
        :base("",cause)
    {
		
	}

}
}
