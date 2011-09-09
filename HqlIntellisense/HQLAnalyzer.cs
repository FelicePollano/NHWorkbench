// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com

using System.Collections.Generic;
using System;
using System.Text;
namespace HqlIntellisense
{

    public class HQLAnalyzer
    {

	    /** Defines the HQL keywords. Based on hql.g antlr grammer in 2005 ;) */
        private static string[] hqlKeywords = { "between", "class", "delete",
			    "desc", "distinct", "elements", "escape", "exists", "false",
			    "fetch", "from", "full", "group", "having", "in", "indices",
			    "inner", "insert", "into", "is", "join", "left", "like", "new",
			    "not", "null", "or", "order", "outer", "properties", "right",
			    "select", "set", "some", "true", "union", "update", "versioned",
			    "where", "and", "or", "as","on", "with",

   		    // -- SQL tokens --
   		    // These aren't part of HQL, but recognized by the lexer. Could be
		    // usefull for having SQL in the editor..but for now we keep them out
    	    // "case", "end", "else", "then", "when", 
        	 

    	    // -- EJBQL tokens --
    	    "both", "empty", "leading", "member", "object", "of", "trailing", 
        };
        

        /**
	     * built-in function names. Various normal builtin functions in SQL/HQL.
	     * Maybe sShould try and do this dynamically based on dialect or
	     * sqlfunctionregistry
	     */
        private static string[] builtInFunctions = {
			    // standard sql92 functions
			    "substring", "locate", "trim", "length", "bit_length", "coalesce",
			    "nullif", "abs", "mod", "sqrt",
			    "upper",
			    "lower",
			    "cast",
			    "extract",

			    // time functions mapped to ansi extract
			    "second", "minute", "hour", "day",
			    "month",
			    "year",

			    "str",

			    // misc functions - based on oracle dialect
			    "sign", "acos", "asin", "atan", "cos", "cosh", "exp", "ln", "sin",
			    "sinh", "stddev", "sqrt", "tan", "tanh", "variance",

			    "round", "trunc", "ceil", "floor",

			    "chr", "initcap", "lower", "ltrim", "rtrim", "soundex", "upper",
			    "ascii", "length", "to_char", "to_date",

			    "current_date", "current_time", "current_timestamp", "lastday",
			    "sysday", "systimestamp", "uid", "user",

			    "rowid", "rownum",

			    "concat", "instr", "instrb", "lpad", "replace", "rpad", "substr",
			    "substrb", "translate",

			    "substring", "locate", "bit_length", "coalesce",

			    "atan2", "log", "mod", "nvl", "nvl2", "power",

			    "add_months", "months_between", "next_day",

			    "max", "min", };
        
        static HQLAnalyzer()
        {
    	    // to allow binary search
    	    System.Array.Sort(builtInFunctions);
    	    System.Array.Sort(hqlKeywords);
        }

        protected ISimpleHQLLexer GetLexer(string chars, int end)
        {
    	    return new AntlrSimpleHQLLexer(chars,end);
        }
        
        protected ISimpleHQLLexer GetLexer(string chars)
        {
    	    return new AntlrSimpleHQLLexer(chars,chars.Length);
        }
        
        /**
         * Returns true if the position is at a location where an entityname makes sense.
         * e.g. "from Pr| where x" 
         * @param query
         * @param cursorPosition
         * @return
         */
        
        public bool ShouldShowEntityNames(string query, int cursorPosition)
        {
    	    ISimpleHQLLexer lexer = GetLexer( query, cursorPosition );
            int tokenId = -1;
            bool show = false;
            while ((tokenId = lexer.NextTokenId()) != HqlLexer.EOF)
            {
                if ((tokenId == HqlLexer.FROM ||
                        tokenId == HqlLexer.DELETE ||
                        tokenId == HqlLexer.UPDATE) &&
                        (lexer.GetTokenOffset() + lexer.GetTokenLength()) < cursorPosition) 
                {
                    show = true;
                } 
                else if (tokenId != HqlLexer.DOT && tokenId != HqlLexer.AS && tokenId != HqlLexer.COMMA && tokenId != HqlLexer.IDENT && tokenId != HqlLexer.WS) 
                {
                    show = false;                
                } 
            }
            return show;    	
        }
        
        public List<SubQuery> GetVisibleSubQueries(string chars, int position) 
        {
    	    SubQueryList sqList = GetSubQueries(chars, position);
            return GetVisibleSubQueries(sqList, position);
        }

        public List<SubQuery> GetVisibleSubQueries(SubQueryList sqList, int position)
        {
            List<SubQuery> visible = new List<SubQuery>();
            foreach (var sq in sqList.subQueries)
            {
                if (sqList.caretDepth >= sq.depth && (sq.startOffset <= position || sq.endOffset >= position))
                {
                    visible.Add(sq);
                }
            }
            return visible;
        }

        public List<EntityNameReference> GetVisibleEntityNames(string chars, int position) 
        {
            List<SubQuery> sqs = GetVisibleSubQueries(chars, position);
            return GetVisibleEntityNames(sqs, position);
        }
        public List<EntityNameReference> GetVisibleEntityNames(List<SubQuery> sqs, int position)
        {
            List<EntityNameReference> entityReferences = new List<EntityNameReference>();
            foreach (SubQuery sq in sqs)
            {
                entityReferences.AddRange(sq.GetEntityNames());
            }
            return entityReferences;
        }
        public SubQueryList GetSubQueries(string query, int position) 
        {
    	    ISimpleHQLLexer syntax = GetLexer( query );
    	    int numericId = -1;
            List<SubQuery> subQueries = new List<SubQuery>();
            int depth = 0;
            int caretDepth = 0;
            IDictionary<int,SubQuery> level2SubQuery = new Dictionary<int,SubQuery>();
            SubQuery current = null;
            while ((numericId = syntax.NextTokenId()) != HqlLexer.EOF)
            {
                bool tokenAdded = false;
                if (numericId == HqlLexer.OPEN) 
                {
                    depth++;
                    if (position > syntax.GetTokenOffset()) 
                    {
                        caretDepth = depth;
                    }
                    if (!level2SubQuery.ContainsKey(depth))
                    {
                        current = new SubQuery();
                        current.depth = depth;
                        current.startOffset = syntax.GetTokenOffset();
                        level2SubQuery[depth] = current;
                    }
                } 
                else if (numericId == HqlLexer.CLOSE) 
                {
                    SubQuery currentDepthQuery = null;
                    level2SubQuery.TryGetValue(depth,out currentDepthQuery);
                    // We check if we have a query on the current depth.
                    // If yes, we'll have to close it
                    if (currentDepthQuery != null && currentDepthQuery.depth == depth)
                    {
                        currentDepthQuery.endOffset = syntax.GetTokenOffset();
                        currentDepthQuery.tokenIds.Add(numericId);
                        currentDepthQuery.tokenText.Add(query.Substring(syntax.GetTokenOffset(), syntax.GetTokenLength()));
                        subQueries.Add(currentDepthQuery);
                        level2SubQuery.Remove(depth);
                        tokenAdded = true;
                    }
                    depth--;
                    if (position > syntax.GetTokenOffset()) {
                        caretDepth = depth;
                    }
                }
                switch (numericId)
                {
                    case HqlLexer.FROM:
                    case HqlLexer.UPDATE:
                    case HqlLexer.DELETE:
                    case HqlLexer.SELECT:
                        if (!level2SubQuery.ContainsKey(depth)) 
                        {
                            current = new SubQuery();
                            current.depth = depth;
                            current.startOffset = syntax.GetTokenOffset();
                            level2SubQuery[depth]= current;
                        }
                        current.tokenIds.Add(numericId);
                        current.tokenText.Add(query.Substring(syntax.GetTokenOffset(), syntax.GetTokenLength()));
                        break;
                    default:
                        if (!tokenAdded && level2SubQuery.ContainsKey(depth)) 
                        {
                            SubQuery sq = (SubQuery) level2SubQuery[depth];
                            int i = depth;
                            while (sq == null && i >= 0) 
                            {
                                sq = (SubQuery) level2SubQuery[i--];
                            }
                            if (sq != null) 
                            {
                                sq.tokenIds.Add(numericId);
                                sq.tokenText.Add(query.Substring(syntax.GetTokenOffset(), syntax.GetTokenLength()));
                            }
                        }
                        break;
                }
            }
            foreach (var sq in level2SubQuery.Values)
            {
			    sq.endOffset = syntax.GetTokenOffset() + syntax.GetTokenLength();
                subQueries.Add(sq);
            }
            subQueries.Sort();
            
            SubQueryList sql = new SubQueryList();
            sql.caretDepth = caretDepth;
            sql.subQueries = subQueries;
            return sql;
        }

        
        /** Returns reference name found from position and backwards in the array.
         **/
        public static string GetEntityNamePrefix(char[] chars, int position)
        {
            StringBuilder buff = new StringBuilder();
            for (int i = position - 1; i >= 0; i--) {
                char c = chars[i];
                //if (c == '.' || Character.isJavaIdentifierPart(c))
                if (c == '.' || char.IsLetterOrDigit(c))
                {
                    buff.Insert(0, c);
                } else 
                {
                    break;
                }
            }
            return buff.ToString();
        }

        public class SubQuery:IComparable 
        {

            public int CompareTo(Object s)
            {
                return startOffset - ((SubQuery)s).startOffset;
            }
            
            internal List<int> tokenIds = new List<int>();

            internal List<string> tokenText = new List<string>();

            internal int startOffset;

            internal int endOffset;
            
            internal int depth;

            public int GetTokenCount() 
            {
                return tokenIds.Count;
            }

            public int GetToken(int i) 
            {
                return tokenIds[i];
            }

            public string GetTokenText(int i) 
            {
                return  tokenText[i];
            }

            public List<EntityNameReference> GetEntityNames() 
            {
                bool afterFrom = false;
                bool afterJoin = false;
                StringBuilder tableNames = new StringBuilder();
                StringBuilder joins = new StringBuilder();
                int i = 0;
                bool cont = true;
                int lastToken = HqlLexer.EOF;
                foreach (int type in tokenIds)
                {
				    if (!cont) 
                    {
                        break;
                    }
                    if (!afterFrom &&
                            (type == HqlLexer.FROM ||
                            type == HqlLexer.UPDATE ||
                            type == HqlLexer.DELETE)) {
                        afterFrom = true;
                    } else if (afterJoin) {
                        switch (type) {
                            case HqlLexer.ORDER:
                            case HqlLexer.WHERE:
                            case HqlLexer.GROUP:
                            case HqlLexer.HAVING:
                                cont = false;
                                break;
                            case HqlLexer.INNER:
                            case HqlLexer.OUTER:
                            case HqlLexer.LEFT:
                            case HqlLexer.RIGHT:
                            case HqlLexer.JOIN:
                                joins.Append(",");
                                break;
                            case HqlLexer.COMMA: 
                        	    joins.Append(","); //TODO: we should detect this and create the list directly instead of relying on the tokenizer
                        	    break;
                            case HqlLexer.DOT:
                        	    joins.Append("."); 
                        	    break;
                            case HqlLexer.IDENT:
                        	    if(lastToken!=HqlLexer.DOT) {
                        		    joins.Append(" ");
                        	    } 
                                joins.Append(tokenText[i]);
                                break;
                        }
                    } else if (afterFrom) {
                        switch (type) {
                            case HqlLexer.ORDER:
                            case HqlLexer.WHERE:
                            case HqlLexer.GROUP:
                            case HqlLexer.HAVING:
                            case HqlLexer.SET:
                                cont = false;
                                break;
                            case HqlLexer.COMMA: 
                        	    tableNames.Append(","); //TODO: we should detect this and create the list directly instead of relying on the tokenizer
                        	    break;
                            case HqlLexer.DOT:
                        	    tableNames.Append("."); 
                        	    break;
                            case HqlLexer.IDENT:
                        	    if(lastToken!=HqlLexer.DOT) {
                        		    tableNames.Append(" ");
                        	    } 
                                tableNames.Append(tokenText[i]);
                                break;
                            case HqlLexer.JOIN:
                        	    tableNames.Append(",");
                                afterJoin = true;
                                break;
                            default:
                        	    break;
                        }
                    }
                    i++;
                    lastToken = type;
                }
                List<EntityNameReference> tables = new List<EntityNameReference>();
                addEntityReferences(tables, tableNames);
                addEntityReferences(tables, joins);
                return tables;
            }

            private void addEntityReferences(List<EntityNameReference> tables, StringBuilder tableNames)
            {
                string[] tableTokens = tableNames.ToString().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
                foreach(string table in tableTokens) 
                {
                    
                    if (table.IndexOf(' ') == -1 && table.Length > 0) 
                    {
                        tables.Add(new EntityNameReference(table, table));
                    } 
                    else 
                    {
                        string[] aliasTokens = table.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                        if (aliasTokens.Length >= 2)
                        {
                            if (!string.IsNullOrEmpty(aliasTokens[0]) && !string.IsNullOrEmpty(aliasTokens[1]))
                            {
                                tables.Add(new EntityNameReference(aliasTokens[0], aliasTokens[1]));
                            }
                        }
                    }
                }
            }
        }

        public class SubQueryList 
        {
            public int caretDepth;
            public List<SubQuery> subQueries;
        }

        
        internal static string[] GetHQLKeywords() {
            return hqlKeywords;
        }
        
        internal static string[] GetHQLFunctionNames() {
            return builtInFunctions;
        }
        
    }
}