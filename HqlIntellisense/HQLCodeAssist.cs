// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using NHibernate.Cfg;
using System;
using System.Collections.Generic;
namespace HqlIntellisense
{
    public class HQLCodeAssist : IHQLCodeAssist 
    {

        private IConfigurationDataProvider configuration;
	    private ConfigurationCompletion completion;
    	
	    private static char[] charSeparators ;	
	    static HQLCodeAssist()
        {
		    charSeparators = new char[]{',', '(', ')'};
		    Array.Sort(charSeparators);
	    }
    	
	    public HQLCodeAssist(IConfigurationDataProvider configuration) 
        {
		    this.configuration = configuration;
		    completion = new ConfigurationCompletion(configuration);
	    }

	    public void CodeComplete(string query, int position, IHQLCompletionRequestor collector) 
        {
    		
		    int prefixStart = FindNearestWhiteSpace(query, position);
		    string prefix = query.Substring( prefixStart, position-prefixStart );
    		
		    bool showEntityNames;
		    try 
            {
			    showEntityNames = new HQLAnalyzer().ShouldShowEntityNames( query, position );
    		
		        if(showEntityNames) 
                {
			        if(HasConfiguration()) 
                    {
				        completion.GetMatchingImports( prefix, position, collector );				
			        } else
                    {
				        collector.CompletionFailure("Configuration not available nor open");
			        }
		        } 
                else 
                {
			        List<EntityNameReference> visible = new HQLAnalyzer().GetVisibleEntityNames( query, position );
			        int dotIndex = prefix.LastIndexOf(".");
                    if (dotIndex == -1) 
                    {
                        // It's a simple path, not a dot separated one (find aliases that matches)
            	        foreach (EntityNameReference qt in visible)
                        {
					        string alias = qt.Alias;
                            if (alias.StartsWith(prefix))
                            {
                    		        var completionProposal = new HQLCompletionProposal(CompletionKind.AliasRef, position)
                    		                                 	{
                    		                                 		Completion = alias.Substring(prefix.Length),
                    		                                 		ReplaceStart = position,
                    		                                 		ReplaceEnd = position + 0,
                    		                                 		SimpleName = alias,
                    		                                 		ShortEntityName = qt.EntityName
                    		                                 	};
                            	if(HasConfiguration())
                                {
                                	string importedName;
									if(GetConfiguration().Imports.TryGetValue(qt.EntityName, out importedName))
                                	{
										completionProposal.EntityName =  importedName;
                                	}
                    		    }
                    		    collector.Accept( completionProposal );
                            }                                        
                        }
                    } 
                    else
                    {
            	        if(HasConfiguration())
                        {        			
            		        string path = CompletionHelper.getCanonicalPath(visible, prefix.Substring(0, dotIndex));
            		        string propertyPrefix = prefix.Substring(dotIndex + 1);
            		        completion.GetMatchingProperties( path, propertyPrefix, position, collector );
            	        }
                        else
                        {
            		        collector.CompletionFailure("Configuration not available nor open");
            	        }
                    }
                    completion.GetMatchingFunctions( prefix, position, collector );
                    completion.GetMatchingKeywords( prefix, position, collector );
		        }
		    } catch(SimpleLexerException sle)
            {
			    collector.CompletionFailure( "Syntax error: " + sle.Message );
		    }
	    }
    	
	    private bool HasConfiguration() 
        {
		    return configuration!=null;
	    }
    	
	    private IConfigurationDataProvider GetConfiguration()
        {
		    return configuration;
	    }

	    public static int FindNearestWhiteSpace( string doc, int start )
        {
    	    bool loop = true;
    	    int offset = 0;
    	    int tmpOffset = start - 1;
    	    while (loop && tmpOffset >= 0)
            {
    		    char c = doc[tmpOffset];
    		    if(IsWhitespace(c)) 
                {
    			    loop = false;
    		    } 
                else
                {
    			    tmpOffset--;
    		    }                        
    	    }            
    	    offset = tmpOffset + 1;

    	    return offset;
        }

	    private static bool IsWhitespace(char c)
        {
		    return Array.BinarySearch(charSeparators, c) >= 0  
				    || Char.IsWhiteSpace(c);
	    }

    }
}