// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
namespace HqlIntellisense
{
    public interface IHQLCompletionRequestor
    {
        bool Accept(HQLCompletionProposal proposal);
        void CompletionFailure(string errorMessage);
    }
}
