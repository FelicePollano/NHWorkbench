// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System;
namespace HqlIntellisense
{

	/**
	 * Interface for code assist on HQL strings.
	 * 
	 * @author Max Rydahl Andersen
	 *
	 */
	public interface IHQLCodeAssist 
	{

		/**
		 * 
		 * @param query the query string (full or partial)
		 * @param position the cursor position inside the query string  
		 * @param requestor requestor on which the codeassist will call methods with information about proposals.
		 */
		void CodeComplete(string query, int position, IHQLCompletionRequestor requestor);	

	}
}
