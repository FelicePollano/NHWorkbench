// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
namespace HqlIntellisense
{
    public interface ISimpleHQLLexer
    {
        int GetTokenLength();
        int GetTokenOffset();
        int NextTokenId();
    }
}
