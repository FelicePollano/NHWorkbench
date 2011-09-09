// $ANTLR 3.1.2 C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g 2010-02-26 15:37:39

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;
namespace  HqlIntellisense 
{
public partial class HqlLexer : Lexer {
    public const int EOF = -1;
    public const int T__130 = 130;
    public const int T__131 = 131;
    public const int AGGREGATE = 4;
    public const int ALIAS = 5;
    public const int ALL = 6;
    public const int AND = 7;
    public const int ANY = 8;
    public const int AS = 9;
    public const int ASCENDING = 10;
    public const int AVG = 11;
    public const int BAND = 12;
    public const int BETWEEN = 13;
    public const int BNOT = 14;
    public const int BOR = 15;
    public const int BOTH = 16;
    public const int BXOR = 17;
    public const int CASE = 18;
    public const int CASE2 = 19;
    public const int CLASS = 20;
    public const int CLOSE = 21;
    public const int CLOSE_BRACKET = 22;
    public const int COLON = 23;
    public const int COMMA = 24;
    public const int CONCAT = 25;
    public const int CONSTANT = 26;
    public const int CONSTRUCTOR = 27;
    public const int COUNT = 28;
    public const int DELETE = 29;
    public const int DESCENDING = 30;
    public const int DISTINCT = 31;
    public const int DIV = 32;
    public const int DOT = 33;
    public const int ELEMENTS = 34;
    public const int ELSE = 35;
    public const int EMPTY = 36;
    public const int END = 37;
    public const int EQ = 38;
    public const int ESCAPE = 39;
    public const int ESCqs = 40;
    public const int EXISTS = 41;
    public const int EXPONENT = 42;
    public const int EXPR_LIST = 43;
    public const int FALSE = 44;
    public const int FETCH = 45;
    public const int FILTER_ENTITY = 46;
    public const int FLOAT_SUFFIX = 47;
    public const int FROM = 48;
    public const int FULL = 49;
    public const int GE = 50;
    public const int GROUP = 51;
    public const int GT = 52;
    public const int HAVING = 53;
    public const int HEX_DIGIT = 54;
    public const int ID_LETTER = 55;
    public const int ID_START_LETTER = 56;
    public const int IDENT = 57;
    public const int IN = 58;
    public const int IN_LIST = 59;
    public const int INDEX_OP = 60;
    public const int INDICES = 61;
    public const int INNER = 62;
    public const int INSERT = 63;
    public const int INTO = 64;
    public const int IS = 65;
    public const int IS_NOT_NULL = 66;
    public const int IS_NULL = 67;
    public const int JAVA_CONSTANT = 68;
    public const int JOIN = 69;
    public const int LE = 70;
    public const int LEADING = 71;
    public const int LEFT = 72;
    public const int LIKE = 73;
    public const int LITERAL_by = 74;
    public const int LT = 75;
    public const int MAX = 76;
    public const int MEMBER = 77;
    public const int METHOD_CALL = 78;
    public const int MIN = 79;
    public const int MINUS = 80;
    public const int NE = 81;
    public const int NEW = 82;
    public const int NOT = 83;
    public const int NOT_BETWEEN = 84;
    public const int NOT_IN = 85;
    public const int NOT_LIKE = 86;
    public const int NULL = 87;
    public const int NUM_DOUBLE = 88;
    public const int NUM_FLOAT = 89;
    public const int NUM_INT = 90;
    public const int NUM_LONG = 91;
    public const int OBJECT = 92;
    public const int OF = 93;
    public const int ON = 94;
    public const int OPEN = 95;
    public const int OPEN_BRACKET = 96;
    public const int OR = 97;
    public const int ORDER = 98;
    public const int ORDER_ELEMENT = 99;
    public const int OUTER = 100;
    public const int PARAM = 101;
    public const int PLUS = 102;
    public const int PROPERTIES = 103;
    public const int QUERY = 104;
    public const int QUOTED_String = 105;
    public const int RANGE = 106;
    public const int RIGHT = 107;
    public const int ROW_STAR = 108;
    public const int SELECT = 109;
    public const int SELECT_FROM = 110;
    public const int SET = 111;
    public const int SOME = 112;
    public const int SQL_NE = 113;
    public const int STAR = 114;
    public const int SUM = 115;
    public const int THEN = 116;
    public const int TRAILING = 117;
    public const int TRUE = 118;
    public const int UNARY_MINUS = 119;
    public const int UNARY_PLUS = 120;
    public const int UNION = 121;
    public const int UPDATE = 122;
    public const int VECTOR_EXPR = 123;
    public const int VERSIONED = 124;
    public const int WEIRD_IDENT = 125;
    public const int WHEN = 126;
    public const int WHERE = 127;
    public const int WITH = 128;
    public const int WS = 129;

    // delegates
    // delegators

    public HqlLexer() 
    {
		InitializeCyclicDFAs();
    }
    public HqlLexer(ICharStream input)
		: this(input, null) {
    }
    public HqlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g";} 
    }

    // $ANTLR start "ALL"
    public void mALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:9:7: ( 'all' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:9:7: 'all'
            {
            	Match("all"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALL"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:10:7: ( 'and' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:10:7: 'and'
            {
            	Match("and"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "ANY"
    public void mANY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ANY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:11:7: ( 'any' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:11:7: 'any'
            {
            	Match("any"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ANY"

    // $ANTLR start "AS"
    public void mAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:12:6: ( 'as' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:12:6: 'as'
            {
            	Match("as"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AS"

    // $ANTLR start "ASCENDING"
    public void mASCENDING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASCENDING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:13:13: ( 'asc' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:13:13: 'asc'
            {
            	Match("asc"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASCENDING"

    // $ANTLR start "AVG"
    public void mAVG() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AVG;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:14:7: ( 'avg' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:14:7: 'avg'
            {
            	Match("avg"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AVG"

    // $ANTLR start "BETWEEN"
    public void mBETWEEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BETWEEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:15:11: ( 'between' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:15:11: 'between'
            {
            	Match("between"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BETWEEN"

    // $ANTLR start "BOTH"
    public void mBOTH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOTH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:16:8: ( 'both' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:16:8: 'both'
            {
            	Match("both"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BOTH"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:17:8: ( 'case' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:17:8: 'case'
            {
            	Match("case"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "CLASS"
    public void mCLASS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLASS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:18:9: ( 'class' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:18:9: 'class'
            {
            	Match("class"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLASS"

    // $ANTLR start "COUNT"
    public void mCOUNT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COUNT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:19:9: ( 'count' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:19:9: 'count'
            {
            	Match("count"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COUNT"

    // $ANTLR start "DELETE"
    public void mDELETE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DELETE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:20:10: ( 'delete' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:20:10: 'delete'
            {
            	Match("delete"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DELETE"

    // $ANTLR start "DESCENDING"
    public void mDESCENDING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DESCENDING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:21:14: ( 'desc' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:21:14: 'desc'
            {
            	Match("desc"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DESCENDING"

    // $ANTLR start "DISTINCT"
    public void mDISTINCT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DISTINCT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:22:12: ( 'distinct' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:22:12: 'distinct'
            {
            	Match("distinct"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DISTINCT"

    // $ANTLR start "ELEMENTS"
    public void mELEMENTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELEMENTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:23:12: ( 'elements' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:23:12: 'elements'
            {
            	Match("elements"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELEMENTS"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:24:8: ( 'else' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:24:8: 'else'
            {
            	Match("else"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "EMPTY"
    public void mEMPTY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EMPTY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:25:9: ( 'empty' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:25:9: 'empty'
            {
            	Match("empty"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EMPTY"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:26:7: ( 'end' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:26:7: 'end'
            {
            	Match("end"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "ESCAPE"
    public void mESCAPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ESCAPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:27:10: ( 'escape' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:27:10: 'escape'
            {
            	Match("escape"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESCAPE"

    // $ANTLR start "EXISTS"
    public void mEXISTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXISTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:28:10: ( 'exists' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:28:10: 'exists'
            {
            	Match("exists"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXISTS"

    // $ANTLR start "FALSE"
    public void mFALSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FALSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:29:9: ( 'false' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:29:9: 'false'
            {
            	Match("false"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FALSE"

    // $ANTLR start "FETCH"
    public void mFETCH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FETCH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:30:9: ( 'fetch' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:30:9: 'fetch'
            {
            	Match("fetch"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FETCH"

    // $ANTLR start "FROM"
    public void mFROM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FROM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:31:8: ( 'from' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:31:8: 'from'
            {
            	Match("from"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FROM"

    // $ANTLR start "FULL"
    public void mFULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:32:8: ( 'full' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:32:8: 'full'
            {
            	Match("full"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FULL"

    // $ANTLR start "GROUP"
    public void mGROUP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GROUP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:33:9: ( 'group' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:33:9: 'group'
            {
            	Match("group"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GROUP"

    // $ANTLR start "HAVING"
    public void mHAVING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = HAVING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:34:10: ( 'having' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:34:10: 'having'
            {
            	Match("having"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "HAVING"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:35:6: ( 'in' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:35:6: 'in'
            {
            	Match("in"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "INDICES"
    public void mINDICES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INDICES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:36:11: ( 'indices' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:36:11: 'indices'
            {
            	Match("indices"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INDICES"

    // $ANTLR start "INNER"
    public void mINNER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INNER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:37:9: ( 'inner' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:37:9: 'inner'
            {
            	Match("inner"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INNER"

    // $ANTLR start "INSERT"
    public void mINSERT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INSERT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:38:10: ( 'insert' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:38:10: 'insert'
            {
            	Match("insert"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INSERT"

    // $ANTLR start "INTO"
    public void mINTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INTO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:39:8: ( 'into' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:39:8: 'into'
            {
            	Match("into"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTO"

    // $ANTLR start "IS"
    public void mIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:40:6: ( 'is' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:40:6: 'is'
            {
            	Match("is"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IS"

    // $ANTLR start "JOIN"
    public void mJOIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = JOIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:41:8: ( 'join' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:41:8: 'join'
            {
            	Match("join"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "JOIN"

    // $ANTLR start "LEADING"
    public void mLEADING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEADING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:42:11: ( 'leading' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:42:11: 'leading'
            {
            	Match("leading"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEADING"

    // $ANTLR start "LEFT"
    public void mLEFT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:43:8: ( 'left' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:43:8: 'left'
            {
            	Match("left"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFT"

    // $ANTLR start "LIKE"
    public void mLIKE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LIKE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:44:8: ( 'like' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:44:8: 'like'
            {
            	Match("like"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LIKE"

    // $ANTLR start "LITERAL_by"
    public void mLITERAL_by() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LITERAL_by;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:45:14: ( 'by' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:45:14: 'by'
            {
            	Match("by"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LITERAL_by"

    // $ANTLR start "MAX"
    public void mMAX() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MAX;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:46:7: ( 'max' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:46:7: 'max'
            {
            	Match("max"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MAX"

    // $ANTLR start "MEMBER"
    public void mMEMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MEMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:47:10: ( 'member' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:47:10: 'member'
            {
            	Match("member"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MEMBER"

    // $ANTLR start "MIN"
    public void mMIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:48:7: ( 'min' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:48:7: 'min'
            {
            	Match("min"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MIN"

    // $ANTLR start "NEW"
    public void mNEW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:49:7: ( 'new' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:49:7: 'new'
            {
            	Match("new"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEW"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:50:7: ( 'not' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:50:7: 'not'
            {
            	Match("not"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "NULL"
    public void mNULL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NULL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:51:8: ( 'null' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:51:8: 'null'
            {
            	Match("null"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NULL"

    // $ANTLR start "OBJECT"
    public void mOBJECT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OBJECT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:52:10: ( 'object' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:52:10: 'object'
            {
            	Match("object"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OBJECT"

    // $ANTLR start "OF"
    public void mOF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:53:6: ( 'of' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:53:6: 'of'
            {
            	Match("of"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OF"

    // $ANTLR start "ON"
    public void mON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:54:6: ( 'on' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:54:6: 'on'
            {
            	Match("on"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ON"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:55:6: ( 'or' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:55:6: 'or'
            {
            	Match("or"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "ORDER"
    public void mORDER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ORDER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:56:9: ( 'order' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:56:9: 'order'
            {
            	Match("order"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ORDER"

    // $ANTLR start "OUTER"
    public void mOUTER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OUTER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:57:9: ( 'outer' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:57:9: 'outer'
            {
            	Match("outer"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OUTER"

    // $ANTLR start "PROPERTIES"
    public void mPROPERTIES() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROPERTIES;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:58:14: ( 'properties' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:58:14: 'properties'
            {
            	Match("properties"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROPERTIES"

    // $ANTLR start "RIGHT"
    public void mRIGHT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:59:9: ( 'right' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:59:9: 'right'
            {
            	Match("right"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHT"

    // $ANTLR start "SELECT"
    public void mSELECT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SELECT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:60:10: ( 'select' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:60:10: 'select'
            {
            	Match("select"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SELECT"

    // $ANTLR start "SET"
    public void mSET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:61:7: ( 'set' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:61:7: 'set'
            {
            	Match("set"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SET"

    // $ANTLR start "SOME"
    public void mSOME() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SOME;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:62:8: ( 'some' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:62:8: 'some'
            {
            	Match("some"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SOME"

    // $ANTLR start "SUM"
    public void mSUM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:63:7: ( 'sum' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:63:7: 'sum'
            {
            	Match("sum"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUM"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:64:8: ( 'then' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:64:8: 'then'
            {
            	Match("then"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "TRAILING"
    public void mTRAILING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRAILING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:65:12: ( 'trailing' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:65:12: 'trailing'
            {
            	Match("trailing"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRAILING"

    // $ANTLR start "TRUE"
    public void mTRUE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRUE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:66:8: ( 'true' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:66:8: 'true'
            {
            	Match("true"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRUE"

    // $ANTLR start "UNION"
    public void mUNION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:67:9: ( 'union' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:67:9: 'union'
            {
            	Match("union"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNION"

    // $ANTLR start "UPDATE"
    public void mUPDATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UPDATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:68:10: ( 'update' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:68:10: 'update'
            {
            	Match("update"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UPDATE"

    // $ANTLR start "VERSIONED"
    public void mVERSIONED() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VERSIONED;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:69:13: ( 'versioned' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:69:13: 'versioned'
            {
            	Match("versioned"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VERSIONED"

    // $ANTLR start "WHEN"
    public void mWHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:70:8: ( 'when' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:70:8: 'when'
            {
            	Match("when"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHEN"

    // $ANTLR start "WHERE"
    public void mWHERE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHERE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:71:9: ( 'where' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:71:9: 'where'
            {
            	Match("where"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHERE"

    // $ANTLR start "WITH"
    public void mWITH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WITH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:72:8: ( 'with' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:72:8: 'with'
            {
            	Match("with"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WITH"

    // $ANTLR start "T__130"
    public void mT__130() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__130;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:73:10: ( 'ascending' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:73:10: 'ascending'
            {
            	Match("ascending"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__130"

    // $ANTLR start "T__131"
    public void mT__131() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__131;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:74:10: ( 'descending' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:74:10: 'descending'
            {
            	Match("descending"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__131"

    // $ANTLR start "EQ"
    public void mEQ() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQ;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:672:5: ( '=' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:672:5: '='
            {
            	Match('='); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQ"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:673:5: ( '<' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:673:5: '<'
            {
            	Match('<'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    // $ANTLR start "GT"
    public void mGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:674:5: ( '>' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:674:5: '>'
            {
            	Match('>'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GT"

    // $ANTLR start "SQL_NE"
    public void mSQL_NE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SQL_NE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:675:9: ( '<>' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:675:9: '<>'
            {
            	Match("<>"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQL_NE"

    // $ANTLR start "NE"
    public void mNE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:676:5: ( '!=' | '^=' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == '!') )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == '^') )
            {
                alt1 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:676:5: '!='
                    {
                    	Match("!="); if (state.failed) return ;


                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:676:12: '^='
                    {
                    	Match("^="); if (state.failed) return ;


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NE"

    // $ANTLR start "LE"
    public void mLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:677:5: ( '<=' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:677:5: '<='
            {
            	Match("<="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LE"

    // $ANTLR start "GE"
    public void mGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:678:5: ( '>=' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:678:5: '>='
            {
            	Match(">="); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GE"

    // $ANTLR start "BOR"
    public void mBOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:680:8: ( '|' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:680:8: '|'
            {
            	Match('|'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BOR"

    // $ANTLR start "BXOR"
    public void mBXOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BXOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:681:8: ( '^' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:681:8: '^'
            {
            	Match('^'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BXOR"

    // $ANTLR start "BAND"
    public void mBAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BAND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:682:8: ( '&' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:682:8: '&'
            {
            	Match('&'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BAND"

    // $ANTLR start "BNOT"
    public void mBNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BNOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:683:8: ( '!' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:683:8: '!'
            {
            	Match('!'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BNOT"

    // $ANTLR start "COMMA"
    public void mCOMMA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMA;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:685:8: ( ',' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:685:8: ','
            {
            	Match(','); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMA"

    // $ANTLR start "OPEN"
    public void mOPEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:687:7: ( '(' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:687:7: '('
            {
            	Match('('); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPEN"

    // $ANTLR start "CLOSE"
    public void mCLOSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLOSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:688:8: ( ')' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:688:8: ')'
            {
            	Match(')'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLOSE"

    // $ANTLR start "OPEN_BRACKET"
    public void mOPEN_BRACKET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OPEN_BRACKET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:689:15: ( '[' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:689:15: '['
            {
            	Match('['); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OPEN_BRACKET"

    // $ANTLR start "CLOSE_BRACKET"
    public void mCLOSE_BRACKET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CLOSE_BRACKET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:690:16: ( ']' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:690:16: ']'
            {
            	Match(']'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CLOSE_BRACKET"

    // $ANTLR start "CONCAT"
    public void mCONCAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CONCAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:692:9: ( '||' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:692:9: '||'
            {
            	Match("||"); if (state.failed) return ;


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CONCAT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:693:7: ( '+' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:693:7: '+'
            {
            	Match('+'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:694:8: ( '-' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:694:8: '-'
            {
            	Match('-'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "STAR"
    public void mSTAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:695:7: ( '*' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:695:7: '*'
            {
            	Match('*'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STAR"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:696:6: ( '/' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:696:6: '/'
            {
            	Match('/'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "COLON"
    public void mCOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:697:8: ( ':' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:697:8: ':'
            {
            	Match(':'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLON"

    // $ANTLR start "PARAM"
    public void mPARAM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:698:8: ( '?' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:698:8: '?'
            {
            	Match('?'); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PARAM"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:701:4: ( ID_START_LETTER ( ID_LETTER )* )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:701:4: ID_START_LETTER ( ID_LETTER )*
            {
            	mID_START_LETTER(); if (state.failed) return ;
            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:701:20: ( ID_LETTER )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == '$' || (LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z') || (LA2_0 >= '\u0080' && LA2_0 <= '\uFFFE')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            			    {
            			    	if ( input.LA(1) == '$' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0080' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "ID_START_LETTER"
    public void mID_START_LETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:707:10: ( '_' | '$' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0080' .. '\\ufffe' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0080' && input.LA(1) <= '\uFFFE') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID_START_LETTER"

    // $ANTLR start "ID_LETTER"
    public void mID_LETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:716:10: ( ID_START_LETTER | '0' .. '9' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0080' && input.LA(1) <= '\uFFFE') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID_LETTER"

    // $ANTLR start "QUOTED_String"
    public void mQUOTED_String() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QUOTED_String;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:6: ( '\\'' (=> ESCqs |~ '\\'' )* '\\'' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:6: '\\'' (=> ESCqs |~ '\\'' )* '\\''
            {
            	Match('\''); if (state.failed) return ;
            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:11: (=> ESCqs |~ '\\'' )*
            	do 
            	{
            	    int alt3 = 3;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == '\'') )
            	    {
            	        int LA3_1 = input.LA(2);

            	        if ( (LA3_1 == '\'') && (synpred1_Hql()) )
            	        {
            	            alt3 = 1;
            	        }


            	    }
            	    else if ( ((LA3_0 >= '\u0000' && LA3_0 <= '&') || (LA3_0 >= '(' && LA3_0 <= '\uFFFF')) )
            	    {
            	        alt3 = 2;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:13: => ESCqs
            			    {

            			    	mESCqs(); if (state.failed) return ;

            			    }
            			    break;
            			case 2 :
            			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:31: ~ '\\''
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	Match('\''); if (state.failed) return ;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QUOTED_String"

    // $ANTLR start "ESCqs"
    public void mESCqs() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:727:3: ( '\\'' '\\'' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:727:3: '\\'' '\\''
            {
            	Match('\''); if (state.failed) return ;
            	Match('\''); if (state.failed) return ;

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESCqs"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:729:9: ( ( ' ' | '\\t' | '\\r' '\\n' | '\\n' | '\\r' ) )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:729:9: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' | '\\r' )
            {
            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:729:9: ( ' ' | '\\t' | '\\r' '\\n' | '\\n' | '\\r' )
            	int alt4 = 5;
            	switch ( input.LA(1) ) 
            	{
            	case ' ':
            		{
            	    alt4 = 1;
            	    }
            	    break;
            	case '\t':
            		{
            	    alt4 = 2;
            	    }
            	    break;
            	case '\r':
            		{
            	    int LA4_3 = input.LA(2);

            	    if ( (LA4_3 == '\n') )
            	    {
            	        alt4 = 3;
            	    }
            	    else 
            	    {
            	        alt4 = 5;}
            	    }
            	    break;
            	case '\n':
            		{
            	    alt4 = 4;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		    NoViableAltException nvae_d4s0 =
            		        new NoViableAltException("", 4, 0, input);

            		    throw nvae_d4s0;
            	}

            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:729:13: ' '
            	        {
            	        	Match(' '); if (state.failed) return ;

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:730:7: '\\t'
            	        {
            	        	Match('\t'); if (state.failed) return ;

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:731:7: '\\r' '\\n'
            	        {
            	        	Match('\r'); if (state.failed) return ;
            	        	Match('\n'); if (state.failed) return ;

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:732:7: '\\n'
            	        {
            	        	Match('\n'); if (state.failed) return ;

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:733:7: '\\r'
            	        {
            	        	Match('\r'); if (state.failed) return ;

            	        }
            	        break;

            	}

            	if ( (state.backtracking==0) )
            	{
            	  Skip();
            	}

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NUM_INT"
    public void mNUM_INT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUM_INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken f1 = null;
            IToken f2 = null;
            IToken f3 = null;
            IToken f4 = null;

            bool isDecimal=false; IToken t=null;
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:742:6: ( '.' ( ( '0' .. '9' )+ ( EXPONENT )? (f1= FLOAT_SUFFIX )? )? | ( '0' ( ( 'x' ) ( HEX_DIGIT )+ | ( '0' .. '7' )+ )? | ( '1' .. '9' ) ( '0' .. '9' )* ) ( ( 'l' ) |{...}? ( '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )? | EXPONENT (f3= FLOAT_SUFFIX )? |f4= FLOAT_SUFFIX ) )? )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == '.') )
            {
                alt20 = 1;
            }
            else if ( ((LA20_0 >= '0' && LA20_0 <= '9')) )
            {
                alt20 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:742:6: '.' ( ( '0' .. '9' )+ ( EXPONENT )? (f1= FLOAT_SUFFIX )? )?
                    {
                    	Match('.'); if (state.failed) return ;
                    	if ( (state.backtracking==0) )
                    	{
                    	  _type = DOT;
                    	}
                    	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:4: ( ( '0' .. '9' )+ ( EXPONENT )? (f1= FLOAT_SUFFIX )? )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:6: ( '0' .. '9' )+ ( EXPONENT )? (f1= FLOAT_SUFFIX )?
                    	        {
                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:6: ( '0' .. '9' )+
                    	        	int cnt5 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt5 = 2;
                    	        	    int LA5_0 = input.LA(1);

                    	        	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	        	    {
                    	        	        alt5 = 1;
                    	        	    }


                    	        	    switch (alt5) 
                    	        		{
                    	        			case 1 :
                    	        			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
                    	        			    {
                    	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
                    	        			    	{
                    	        			    	    input.Consume();
                    	        			    	state.failed = false;
                    	        			    	}
                    	        			    	else 
                    	        			    	{
                    	        			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        			    	    Recover(mse);
                    	        			    	    throw mse;}


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt5 >= 1 ) goto loop5;
                    	        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        		            EarlyExitException eee5 =
                    	        		                new EarlyExitException(5, input);
                    	        		            throw eee5;
                    	        	    }
                    	        	    cnt5++;
                    	        	} while (true);

                    	        	loop5:
                    	        		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:18: ( EXPONENT )?
                    	        	int alt6 = 2;
                    	        	int LA6_0 = input.LA(1);

                    	        	if ( (LA6_0 == 'e') )
                    	        	{
                    	        	    alt6 = 1;
                    	        	}
                    	        	switch (alt6) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:19: EXPONENT
                    	        	        {
                    	        	        	mEXPONENT(); if (state.failed) return ;

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:30: (f1= FLOAT_SUFFIX )?
                    	        	int alt7 = 2;
                    	        	int LA7_0 = input.LA(1);

                    	        	if ( (LA7_0 == 'd' || LA7_0 == 'f') )
                    	        	{
                    	        	    alt7 = 1;
                    	        	}
                    	        	switch (alt7) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:743:31: f1= FLOAT_SUFFIX
                    	        	        {
                    	        	        	int f1Start976 = CharIndex;
                    	        	        	mFLOAT_SUFFIX(); if (state.failed) return ;
                    	        	        	f1 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, f1Start976, CharIndex-1);
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{
                    	        	        	  t=f1;
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  					if (t != null && t.Text.ToUpperInvariant().IndexOf('F')>=0)
                    	        	  					{
                    	        	  						_type = NUM_FLOAT;
                    	        	  					}
                    	        	  					else
                    	        	  					{
                    	        	  						_type = NUM_DOUBLE; // assume double
                    	        	  					}
                    	        	  				
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:755:4: ( '0' ( ( 'x' ) ( HEX_DIGIT )+ | ( '0' .. '7' )+ )? | ( '1' .. '9' ) ( '0' .. '9' )* ) ( ( 'l' ) |{...}? ( '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )? | EXPONENT (f3= FLOAT_SUFFIX )? |f4= FLOAT_SUFFIX ) )?
                    {
                    	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:755:4: ( '0' ( ( 'x' ) ( HEX_DIGIT )+ | ( '0' .. '7' )+ )? | ( '1' .. '9' ) ( '0' .. '9' )* )
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == '0') )
                    	{
                    	    alt13 = 1;
                    	}
                    	else if ( ((LA13_0 >= '1' && LA13_0 <= '9')) )
                    	{
                    	    alt13 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	    NoViableAltException nvae_d13s0 =
                    	        new NoViableAltException("", 13, 0, input);

                    	    throw nvae_d13s0;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:755:6: '0' ( ( 'x' ) ( HEX_DIGIT )+ | ( '0' .. '7' )+ )?
                    	        {
                    	        	Match('0'); if (state.failed) return ;
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	  isDecimal = true;
                    	        	}
                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:756:4: ( ( 'x' ) ( HEX_DIGIT )+ | ( '0' .. '7' )+ )?
                    	        	int alt11 = 3;
                    	        	int LA11_0 = input.LA(1);

                    	        	if ( (LA11_0 == 'x') )
                    	        	{
                    	        	    alt11 = 1;
                    	        	}
                    	        	else if ( ((LA11_0 >= '0' && LA11_0 <= '7')) )
                    	        	{
                    	        	    alt11 = 2;
                    	        	}
                    	        	switch (alt11) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:756:6: ( 'x' ) ( HEX_DIGIT )+
                    	        	        {
                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:756:6: ( 'x' )
                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:756:7: 'x'
                    	        	        	{
                    	        	        		Match('x'); if (state.failed) return ;

                    	        	        	}

                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:757:5: ( HEX_DIGIT )+
                    	        	        	int cnt9 = 0;
                    	        	        	do 
                    	        	        	{
                    	        	        	    int alt9 = 2;
                    	        	        	    switch ( input.LA(1) ) 
                    	        	        	    {
                    	        	        	    case 'e':
                    	        	        	    	{
                    	        	        	        int LA9_2 = input.LA(2);

                    	        	        	        if ( ((LA9_2 >= '0' && LA9_2 <= '9')) )
                    	        	        	        {
                    	        	        	            int LA9_5 = input.LA(3);

                    	        	        	            if ( (!(((isDecimal)))) )
                    	        	        	            {
                    	        	        	                alt9 = 1;
                    	        	        	            }


                    	        	        	        }

                    	        	        	        else 
                    	        	        	        {
                    	        	        	            alt9 = 1;
                    	        	        	        }

                    	        	        	        }
                    	        	        	        break;
                    	        	        	    case 'd':
                    	        	        	    case 'f':
                    	        	        	    	{
                    	        	        	        int LA9_3 = input.LA(2);

                    	        	        	        if ( (!(((isDecimal)))) )
                    	        	        	        {
                    	        	        	            alt9 = 1;
                    	        	        	        }


                    	        	        	        }
                    	        	        	        break;
                    	        	        	    case '0':
                    	        	        	    case '1':
                    	        	        	    case '2':
                    	        	        	    case '3':
                    	        	        	    case '4':
                    	        	        	    case '5':
                    	        	        	    case '6':
                    	        	        	    case '7':
                    	        	        	    case '8':
                    	        	        	    case '9':
                    	        	        	    case 'a':
                    	        	        	    case 'b':
                    	        	        	    case 'c':
                    	        	        	    	{
                    	        	        	        alt9 = 1;
                    	        	        	        }
                    	        	        	        break;

                    	        	        	    }

                    	        	        	    switch (alt9) 
                    	        	        		{
                    	        	        			case 1 :
                    	        	        			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
                    	        	        			    {
                    	        	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
                    	        	        			    	{
                    	        	        			    	    input.Consume();
                    	        	        			    	state.failed = false;
                    	        	        			    	}
                    	        	        			    	else 
                    	        	        			    	{
                    	        	        			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	        			    	    Recover(mse);
                    	        	        			    	    throw mse;}


                    	        	        			    }
                    	        	        			    break;

                    	        	        			default:
                    	        	        			    if ( cnt9 >= 1 ) goto loop9;
                    	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	        		            EarlyExitException eee9 =
                    	        	        		                new EarlyExitException(9, input);
                    	        	        		            throw eee9;
                    	        	        	    }
                    	        	        	    cnt9++;
                    	        	        	} while (true);

                    	        	        	loop9:
                    	        	        		;	// Stops C# compiler whining that label 'loop9' has no statements


                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:766:6: ( '0' .. '7' )+
                    	        	        {
                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:766:6: ( '0' .. '7' )+
                    	        	        	int cnt10 = 0;
                    	        	        	do 
                    	        	        	{
                    	        	        	    int alt10 = 2;
                    	        	        	    int LA10_0 = input.LA(1);

                    	        	        	    if ( ((LA10_0 >= '0' && LA10_0 <= '7')) )
                    	        	        	    {
                    	        	        	        alt10 = 1;
                    	        	        	    }


                    	        	        	    switch (alt10) 
                    	        	        		{
                    	        	        			case 1 :
                    	        	        			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
                    	        	        			    {
                    	        	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '7') ) 
                    	        	        			    	{
                    	        	        			    	    input.Consume();
                    	        	        			    	state.failed = false;
                    	        	        			    	}
                    	        	        			    	else 
                    	        	        			    	{
                    	        	        			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	        			    	    Recover(mse);
                    	        	        			    	    throw mse;}


                    	        	        			    }
                    	        	        			    break;

                    	        	        			default:
                    	        	        			    if ( cnt10 >= 1 ) goto loop10;
                    	        	        			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	        		            EarlyExitException eee10 =
                    	        	        		                new EarlyExitException(10, input);
                    	        	        		            throw eee10;
                    	        	        	    }
                    	        	        	    cnt10++;
                    	        	        	} while (true);

                    	        	        	loop10:
                    	        	        		;	// Stops C# compiler whining that label 'loop10' has no statements


                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:768:5: ( '1' .. '9' ) ( '0' .. '9' )*
                    	        {
                    	        	if ( (input.LA(1) >= '1' && input.LA(1) <= '9') ) 
                    	        	{
                    	        	    input.Consume();
                    	        	state.failed = false;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}

                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:768:16: ( '0' .. '9' )*
                    	        	do 
                    	        	{
                    	        	    int alt12 = 2;
                    	        	    int LA12_0 = input.LA(1);

                    	        	    if ( ((LA12_0 >= '0' && LA12_0 <= '9')) )
                    	        	    {
                    	        	        alt12 = 1;
                    	        	    }


                    	        	    switch (alt12) 
                    	        		{
                    	        			case 1 :
                    	        			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
                    	        			    {
                    	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
                    	        			    	{
                    	        			    	    input.Consume();
                    	        			    	state.failed = false;
                    	        			    	}
                    	        			    	else 
                    	        			    	{
                    	        			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        			    	    Recover(mse);
                    	        			    	    throw mse;}


                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop12;
                    	        	    }
                    	        	} while (true);

                    	        	loop12:
                    	        		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	  isDecimal=true;
                    	        	}

                    	        }
                    	        break;

                    	}

                    	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:770:3: ( ( 'l' ) |{...}? ( '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )? | EXPONENT (f3= FLOAT_SUFFIX )? |f4= FLOAT_SUFFIX ) )?
                    	int alt19 = 3;
                    	int LA19_0 = input.LA(1);

                    	if ( (LA19_0 == 'l') )
                    	{
                    	    alt19 = 1;
                    	}
                    	else if ( (LA19_0 == '.' || (LA19_0 >= 'd' && LA19_0 <= 'f')) )
                    	{
                    	    alt19 = 2;
                    	}
                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:770:5: ( 'l' )
                    	        {
                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:770:5: ( 'l' )
                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:770:6: 'l'
                    	        	{
                    	        		Match('l'); if (state.failed) return ;

                    	        	}

                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   _type = NUM_LONG; 
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:773:5: {...}? ( '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )? | EXPONENT (f3= FLOAT_SUFFIX )? |f4= FLOAT_SUFFIX )
                    	        {
                    	        	if ( !((isDecimal)) ) 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	    throw new FailedPredicateException(input, "NUM_INT", "isDecimal");
                    	        	}
                    	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:4: ( '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )? | EXPONENT (f3= FLOAT_SUFFIX )? |f4= FLOAT_SUFFIX )
                    	        	int alt18 = 3;
                    	        	switch ( input.LA(1) ) 
                    	        	{
                    	        	case '.':
                    	        		{
                    	        	    alt18 = 1;
                    	        	    }
                    	        	    break;
                    	        	case 'e':
                    	        		{
                    	        	    alt18 = 2;
                    	        	    }
                    	        	    break;
                    	        	case 'd':
                    	        	case 'f':
                    	        		{
                    	        	    alt18 = 3;
                    	        	    }
                    	        	    break;
                    	        		default:
                    	        		    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        		    NoViableAltException nvae_d18s0 =
                    	        		        new NoViableAltException("", 18, 0, input);

                    	        		    throw nvae_d18s0;
                    	        	}

                    	        	switch (alt18) 
                    	        	{
                    	        	    case 1 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:8: '.' ( '0' .. '9' )* ( EXPONENT )? (f2= FLOAT_SUFFIX )?
                    	        	        {
                    	        	        	Match('.'); if (state.failed) return ;
                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:12: ( '0' .. '9' )*
                    	        	        	do 
                    	        	        	{
                    	        	        	    int alt14 = 2;
                    	        	        	    int LA14_0 = input.LA(1);

                    	        	        	    if ( ((LA14_0 >= '0' && LA14_0 <= '9')) )
                    	        	        	    {
                    	        	        	        alt14 = 1;
                    	        	        	    }


                    	        	        	    switch (alt14) 
                    	        	        		{
                    	        	        			case 1 :
                    	        	        			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
                    	        	        			    {
                    	        	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
                    	        	        			    	{
                    	        	        			    	    input.Consume();
                    	        	        			    	state.failed = false;
                    	        	        			    	}
                    	        	        			    	else 
                    	        	        			    	{
                    	        	        			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    	        	        			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	        			    	    Recover(mse);
                    	        	        			    	    throw mse;}


                    	        	        			    }
                    	        	        			    break;

                    	        	        			default:
                    	        	        			    goto loop14;
                    	        	        	    }
                    	        	        	} while (true);

                    	        	        	loop14:
                    	        	        		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:24: ( EXPONENT )?
                    	        	        	int alt15 = 2;
                    	        	        	int LA15_0 = input.LA(1);

                    	        	        	if ( (LA15_0 == 'e') )
                    	        	        	{
                    	        	        	    alt15 = 1;
                    	        	        	}
                    	        	        	switch (alt15) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:25: EXPONENT
                    	        	        	        {
                    	        	        	        	mEXPONENT(); if (state.failed) return ;

                    	        	        	        }
                    	        	        	        break;

                    	        	        	}

                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:36: (f2= FLOAT_SUFFIX )?
                    	        	        	int alt16 = 2;
                    	        	        	int LA16_0 = input.LA(1);

                    	        	        	if ( (LA16_0 == 'd' || LA16_0 == 'f') )
                    	        	        	{
                    	        	        	    alt16 = 1;
                    	        	        	}
                    	        	        	switch (alt16) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:774:37: f2= FLOAT_SUFFIX
                    	        	        	        {
                    	        	        	        	int f2Start1178 = CharIndex;
                    	        	        	        	mFLOAT_SUFFIX(); if (state.failed) return ;
                    	        	        	        	f2 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, f2Start1178, CharIndex-1);
                    	        	        	        	if ( (state.backtracking==0) )
                    	        	        	        	{
                    	        	        	        	  t=f2;
                    	        	        	        	}

                    	        	        	        }
                    	        	        	        break;

                    	        	        	}


                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:775:8: EXPONENT (f3= FLOAT_SUFFIX )?
                    	        	        {
                    	        	        	mEXPONENT(); if (state.failed) return ;
                    	        	        	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:775:17: (f3= FLOAT_SUFFIX )?
                    	        	        	int alt17 = 2;
                    	        	        	int LA17_0 = input.LA(1);

                    	        	        	if ( (LA17_0 == 'd' || LA17_0 == 'f') )
                    	        	        	{
                    	        	        	    alt17 = 1;
                    	        	        	}
                    	        	        	switch (alt17) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:775:18: f3= FLOAT_SUFFIX
                    	        	        	        {
                    	        	        	        	int f3Start1196 = CharIndex;
                    	        	        	        	mFLOAT_SUFFIX(); if (state.failed) return ;
                    	        	        	        	f3 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, f3Start1196, CharIndex-1);
                    	        	        	        	if ( (state.backtracking==0) )
                    	        	        	        	{
                    	        	        	        	  t=f3;
                    	        	        	        	}

                    	        	        	        }
                    	        	        	        break;

                    	        	        	}


                    	        	        }
                    	        	        break;
                    	        	    case 3 :
                    	        	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:776:8: f4= FLOAT_SUFFIX
                    	        	        {
                    	        	        	int f4Start1211 = CharIndex;
                    	        	        	mFLOAT_SUFFIX(); if (state.failed) return ;
                    	        	        	f4 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, f4Start1211, CharIndex-1);
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{
                    	        	        	  t=f4;
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  				if (t != null && t.Text.ToUpperInvariant().IndexOf('F') >= 0)
                    	        	  				{
                    	        	  					_type = NUM_FLOAT;
                    	        	  				}
                    	        	  				else
                    	        	  				{
                    	        	  					_type = NUM_DOUBLE; // assume double
                    	        	  				}
                    	        	  			
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUM_INT"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:795:4: ( ( '0' .. '9' | 'a' .. 'f' ) )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "EXPONENT"
    public void mEXPONENT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:4: ( ( 'e' ) ( '+' | '-' )? ( '0' .. '9' )+ )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:4: ( 'e' ) ( '+' | '-' )? ( '0' .. '9' )+
            {
            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:4: ( 'e' )
            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:5: 'e'
            	{
            		Match('e'); if (state.failed) return ;

            	}

            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:10: ( '+' | '-' )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == '+' || LA21_0 == '-') )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();
            	        	state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    Recover(mse);
            	        	    throw mse;}


            	        }
            	        break;

            	}

            	// C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:801:21: ( '0' .. '9' )+
            	int cnt22 = 0;
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= '0' && LA22_0 <= '9')) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
            			    	{
            			    	    input.Consume();
            			    	state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt22 >= 1 ) goto loop22;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            		            EarlyExitException eee22 =
            		                new EarlyExitException(22, input);
            		            throw eee22;
            	    }
            	    cnt22++;
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXPONENT"

    // $ANTLR start "FLOAT_SUFFIX"
    public void mFLOAT_SUFFIX() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:806:4: ( 'f' | 'd' )
            // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:
            {
            	if ( input.LA(1) == 'd' || input.LA(1) == 'f' ) 
            	{
            	    input.Consume();
            	state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLOAT_SUFFIX"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:10: ( ALL | AND | ANY | AS | ASCENDING | AVG | BETWEEN | BOTH | CASE | CLASS | COUNT | DELETE | DESCENDING | DISTINCT | ELEMENTS | ELSE | EMPTY | END | ESCAPE | EXISTS | FALSE | FETCH | FROM | FULL | GROUP | HAVING | IN | INDICES | INNER | INSERT | INTO | IS | JOIN | LEADING | LEFT | LIKE | LITERAL_by | MAX | MEMBER | MIN | NEW | NOT | NULL | OBJECT | OF | ON | OR | ORDER | OUTER | PROPERTIES | RIGHT | SELECT | SET | SOME | SUM | THEN | TRAILING | TRUE | UNION | UPDATE | VERSIONED | WHEN | WHERE | WITH | T__130 | T__131 | EQ | LT | GT | SQL_NE | NE | LE | GE | BOR | BXOR | BAND | BNOT | COMMA | OPEN | CLOSE | OPEN_BRACKET | CLOSE_BRACKET | CONCAT | PLUS | MINUS | STAR | DIV | COLON | PARAM | IDENT | QUOTED_String | WS | NUM_INT )
        int alt23 = 93;
        alt23 = dfa23.Predict(input);
        switch (alt23) 
        {
            case 1 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:10: ALL
                {
                	mALL(); if (state.failed) return ;

                }
                break;
            case 2 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:14: AND
                {
                	mAND(); if (state.failed) return ;

                }
                break;
            case 3 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:18: ANY
                {
                	mANY(); if (state.failed) return ;

                }
                break;
            case 4 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:22: AS
                {
                	mAS(); if (state.failed) return ;

                }
                break;
            case 5 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:25: ASCENDING
                {
                	mASCENDING(); if (state.failed) return ;

                }
                break;
            case 6 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:35: AVG
                {
                	mAVG(); if (state.failed) return ;

                }
                break;
            case 7 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:39: BETWEEN
                {
                	mBETWEEN(); if (state.failed) return ;

                }
                break;
            case 8 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:47: BOTH
                {
                	mBOTH(); if (state.failed) return ;

                }
                break;
            case 9 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:52: CASE
                {
                	mCASE(); if (state.failed) return ;

                }
                break;
            case 10 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:57: CLASS
                {
                	mCLASS(); if (state.failed) return ;

                }
                break;
            case 11 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:63: COUNT
                {
                	mCOUNT(); if (state.failed) return ;

                }
                break;
            case 12 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:69: DELETE
                {
                	mDELETE(); if (state.failed) return ;

                }
                break;
            case 13 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:76: DESCENDING
                {
                	mDESCENDING(); if (state.failed) return ;

                }
                break;
            case 14 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:87: DISTINCT
                {
                	mDISTINCT(); if (state.failed) return ;

                }
                break;
            case 15 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:96: ELEMENTS
                {
                	mELEMENTS(); if (state.failed) return ;

                }
                break;
            case 16 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:105: ELSE
                {
                	mELSE(); if (state.failed) return ;

                }
                break;
            case 17 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:110: EMPTY
                {
                	mEMPTY(); if (state.failed) return ;

                }
                break;
            case 18 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:116: END
                {
                	mEND(); if (state.failed) return ;

                }
                break;
            case 19 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:120: ESCAPE
                {
                	mESCAPE(); if (state.failed) return ;

                }
                break;
            case 20 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:127: EXISTS
                {
                	mEXISTS(); if (state.failed) return ;

                }
                break;
            case 21 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:134: FALSE
                {
                	mFALSE(); if (state.failed) return ;

                }
                break;
            case 22 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:140: FETCH
                {
                	mFETCH(); if (state.failed) return ;

                }
                break;
            case 23 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:146: FROM
                {
                	mFROM(); if (state.failed) return ;

                }
                break;
            case 24 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:151: FULL
                {
                	mFULL(); if (state.failed) return ;

                }
                break;
            case 25 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:156: GROUP
                {
                	mGROUP(); if (state.failed) return ;

                }
                break;
            case 26 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:162: HAVING
                {
                	mHAVING(); if (state.failed) return ;

                }
                break;
            case 27 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:169: IN
                {
                	mIN(); if (state.failed) return ;

                }
                break;
            case 28 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:172: INDICES
                {
                	mINDICES(); if (state.failed) return ;

                }
                break;
            case 29 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:180: INNER
                {
                	mINNER(); if (state.failed) return ;

                }
                break;
            case 30 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:186: INSERT
                {
                	mINSERT(); if (state.failed) return ;

                }
                break;
            case 31 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:193: INTO
                {
                	mINTO(); if (state.failed) return ;

                }
                break;
            case 32 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:198: IS
                {
                	mIS(); if (state.failed) return ;

                }
                break;
            case 33 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:201: JOIN
                {
                	mJOIN(); if (state.failed) return ;

                }
                break;
            case 34 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:206: LEADING
                {
                	mLEADING(); if (state.failed) return ;

                }
                break;
            case 35 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:214: LEFT
                {
                	mLEFT(); if (state.failed) return ;

                }
                break;
            case 36 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:219: LIKE
                {
                	mLIKE(); if (state.failed) return ;

                }
                break;
            case 37 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:224: LITERAL_by
                {
                	mLITERAL_by(); if (state.failed) return ;

                }
                break;
            case 38 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:235: MAX
                {
                	mMAX(); if (state.failed) return ;

                }
                break;
            case 39 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:239: MEMBER
                {
                	mMEMBER(); if (state.failed) return ;

                }
                break;
            case 40 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:246: MIN
                {
                	mMIN(); if (state.failed) return ;

                }
                break;
            case 41 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:250: NEW
                {
                	mNEW(); if (state.failed) return ;

                }
                break;
            case 42 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:254: NOT
                {
                	mNOT(); if (state.failed) return ;

                }
                break;
            case 43 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:258: NULL
                {
                	mNULL(); if (state.failed) return ;

                }
                break;
            case 44 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:263: OBJECT
                {
                	mOBJECT(); if (state.failed) return ;

                }
                break;
            case 45 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:270: OF
                {
                	mOF(); if (state.failed) return ;

                }
                break;
            case 46 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:273: ON
                {
                	mON(); if (state.failed) return ;

                }
                break;
            case 47 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:276: OR
                {
                	mOR(); if (state.failed) return ;

                }
                break;
            case 48 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:279: ORDER
                {
                	mORDER(); if (state.failed) return ;

                }
                break;
            case 49 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:285: OUTER
                {
                	mOUTER(); if (state.failed) return ;

                }
                break;
            case 50 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:291: PROPERTIES
                {
                	mPROPERTIES(); if (state.failed) return ;

                }
                break;
            case 51 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:302: RIGHT
                {
                	mRIGHT(); if (state.failed) return ;

                }
                break;
            case 52 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:308: SELECT
                {
                	mSELECT(); if (state.failed) return ;

                }
                break;
            case 53 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:315: SET
                {
                	mSET(); if (state.failed) return ;

                }
                break;
            case 54 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:319: SOME
                {
                	mSOME(); if (state.failed) return ;

                }
                break;
            case 55 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:324: SUM
                {
                	mSUM(); if (state.failed) return ;

                }
                break;
            case 56 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:328: THEN
                {
                	mTHEN(); if (state.failed) return ;

                }
                break;
            case 57 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:333: TRAILING
                {
                	mTRAILING(); if (state.failed) return ;

                }
                break;
            case 58 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:342: TRUE
                {
                	mTRUE(); if (state.failed) return ;

                }
                break;
            case 59 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:347: UNION
                {
                	mUNION(); if (state.failed) return ;

                }
                break;
            case 60 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:353: UPDATE
                {
                	mUPDATE(); if (state.failed) return ;

                }
                break;
            case 61 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:360: VERSIONED
                {
                	mVERSIONED(); if (state.failed) return ;

                }
                break;
            case 62 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:370: WHEN
                {
                	mWHEN(); if (state.failed) return ;

                }
                break;
            case 63 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:375: WHERE
                {
                	mWHERE(); if (state.failed) return ;

                }
                break;
            case 64 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:381: WITH
                {
                	mWITH(); if (state.failed) return ;

                }
                break;
            case 65 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:386: T__130
                {
                	mT__130(); if (state.failed) return ;

                }
                break;
            case 66 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:393: T__131
                {
                	mT__131(); if (state.failed) return ;

                }
                break;
            case 67 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:400: EQ
                {
                	mEQ(); if (state.failed) return ;

                }
                break;
            case 68 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:403: LT
                {
                	mLT(); if (state.failed) return ;

                }
                break;
            case 69 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:406: GT
                {
                	mGT(); if (state.failed) return ;

                }
                break;
            case 70 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:409: SQL_NE
                {
                	mSQL_NE(); if (state.failed) return ;

                }
                break;
            case 71 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:416: NE
                {
                	mNE(); if (state.failed) return ;

                }
                break;
            case 72 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:419: LE
                {
                	mLE(); if (state.failed) return ;

                }
                break;
            case 73 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:422: GE
                {
                	mGE(); if (state.failed) return ;

                }
                break;
            case 74 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:425: BOR
                {
                	mBOR(); if (state.failed) return ;

                }
                break;
            case 75 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:429: BXOR
                {
                	mBXOR(); if (state.failed) return ;

                }
                break;
            case 76 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:434: BAND
                {
                	mBAND(); if (state.failed) return ;

                }
                break;
            case 77 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:439: BNOT
                {
                	mBNOT(); if (state.failed) return ;

                }
                break;
            case 78 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:444: COMMA
                {
                	mCOMMA(); if (state.failed) return ;

                }
                break;
            case 79 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:450: OPEN
                {
                	mOPEN(); if (state.failed) return ;

                }
                break;
            case 80 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:455: CLOSE
                {
                	mCLOSE(); if (state.failed) return ;

                }
                break;
            case 81 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:461: OPEN_BRACKET
                {
                	mOPEN_BRACKET(); if (state.failed) return ;

                }
                break;
            case 82 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:474: CLOSE_BRACKET
                {
                	mCLOSE_BRACKET(); if (state.failed) return ;

                }
                break;
            case 83 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:488: CONCAT
                {
                	mCONCAT(); if (state.failed) return ;

                }
                break;
            case 84 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:495: PLUS
                {
                	mPLUS(); if (state.failed) return ;

                }
                break;
            case 85 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:500: MINUS
                {
                	mMINUS(); if (state.failed) return ;

                }
                break;
            case 86 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:506: STAR
                {
                	mSTAR(); if (state.failed) return ;

                }
                break;
            case 87 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:511: DIV
                {
                	mDIV(); if (state.failed) return ;

                }
                break;
            case 88 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:515: COLON
                {
                	mCOLON(); if (state.failed) return ;

                }
                break;
            case 89 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:521: PARAM
                {
                	mPARAM(); if (state.failed) return ;

                }
                break;
            case 90 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:527: IDENT
                {
                	mIDENT(); if (state.failed) return ;

                }
                break;
            case 91 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:533: QUOTED_String
                {
                	mQUOTED_String(); if (state.failed) return ;

                }
                break;
            case 92 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:547: WS
                {
                	mWS(); if (state.failed) return ;

                }
                break;
            case 93 :
                // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:1:550: NUM_INT
                {
                	mNUM_INT(); if (state.failed) return ;

                }
                break;

        }

    }

    // $ANTLR start "synpred1_Hql"
    public void synpred1_Hql_fragment() {
        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:13: ( ESCqs )
        // C:\\Documents and Settings\\FPollano\\My Documents\\Visual Studio 2008\\Projects\\HqlIntellisense\\HqlIntellisense\\Grammar\\Hql.g:720:14: ESCqs
        {
        	mESCqs(); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_Hql"

   	public bool synpred1_Hql() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Hql_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


    protected DFA23 dfa23;
	private void InitializeCyclicDFAs()
	{
	    this.dfa23 = new DFA23(this);
	}

    const string DFA23_eotS =
        "\x1\xFFFF\x15\x28\x1\xFFFF\x1\x61\x1\x63\x1\x65\x1\x66\x1\x68\x10"+
        "\xFFFF\x2\x28\x1\x6D\x3\x28\x1\x71\x10\x28\x1\x88\x1\x89\xA\x28"+
        "\x1\x95\x1\x96\x1\x98\xD\x28\xA\xFFFF\x1\xA8\x1\xA9\x1\xAA\x1\xAC"+
        "\x1\xFFFF\x1\xAD\x2\x28\x1\xFFFF\x9\x28\x1\xB9\xC\x28\x2\xFFFF\x4"+
        "\x28\x1\xCA\x1\x28\x1\xCC\x1\xCD\x1\xCE\x2\x28\x2\xFFFF\x1\x28\x1"+
        "\xFFFF\x4\x28\x1\xD6\x1\x28\x1\xD8\x8\x28\x3\xFFFF\x1\x28\x2\xFFFF"+
        "\x1\x28\x1\xE4\x1\xE5\x3\x28\x1\xEA\x2\x28\x1\xED\x1\x28\x1\xFFFF"+
        "\x4\x28\x1\xF3\x1\xF4\x5\x28\x1\xFA\x1\xFB\x1\x28\x1\xFD\x1\xFE"+
        "\x1\xFFFF\x1\x28\x3\xFFFF\x1\x100\x6\x28\x1\xFFFF\x1\x107\x1\xFFFF"+
        "\x1\x108\x1\x28\x1\x10A\x3\x28\x1\x10E\x1\x28\x1\x110\x2\x28\x2"+
        "\xFFFF\x1\x113\x1\x114\x2\x28\x1\xFFFF\x2\x28\x1\xFFFF\x1\x119\x2"+
        "\x28\x1\x11C\x1\x11D\x2\xFFFF\x1\x11E\x2\x28\x1\x121\x1\x28\x2\xFFFF"+
        "\x1\x28\x2\xFFFF\x1\x28\x1\xFFFF\x1\x28\x1\x126\x1\x127\x1\x28\x1"+
        "\x129\x1\x28\x2\xFFFF\x1\x28\x1\xFFFF\x1\x12C\x2\x28\x1\xFFFF\x1"+
        "\x12F\x1\xFFFF\x2\x28\x2\xFFFF\x1\x132\x3\x28\x1\xFFFF\x1\x136\x1"+
        "\x137\x3\xFFFF\x1\x138\x1\x28\x1\xFFFF\x1\x13A\x1\x28\x1\x13C\x1"+
        "\x13D\x2\xFFFF\x1\x28\x1\xFFFF\x1\x13F\x1\x28\x1\xFFFF\x1\x141\x1"+
        "\x28\x1\xFFFF\x1\x28\x1\x144\x1\xFFFF\x3\x28\x3\xFFFF\x1\x148\x1"+
        "\xFFFF\x1\x149\x2\xFFFF\x1\x28\x1\xFFFF\x1\x28\x1\xFFFF\x2\x28\x1"+
        "\xFFFF\x1\x28\x1\x14F\x1\x150\x2\xFFFF\x1\x28\x1\x152\x1\x28\x1"+
        "\x154\x1\x28\x2\xFFFF\x1\x28\x1\xFFFF\x1\x157\x1\xFFFF\x1\x158\x1"+
        "\x159\x3\xFFFF";
    const string DFA23_eofS =
        "\x15A\xFFFF";
    const string DFA23_minS =
        "\x1\x9\x1\x6C\x1\x65\x1\x61\x1\x65\x1\x6C\x1\x61\x1\x72\x1\x61\x1"+
        "\x6E\x1\x6F\x1\x65\x1\x61\x1\x65\x1\x62\x1\x72\x1\x69\x1\x65\x1"+
        "\x68\x1\x6E\x1\x65\x1\x68\x1\xFFFF\x4\x3D\x1\x7C\x10\xFFFF\x1\x6C"+
        "\x1\x64\x1\x24\x1\x67\x2\x74\x1\x24\x1\x73\x1\x61\x1\x75\x1\x6C"+
        "\x1\x73\x1\x65\x1\x70\x1\x64\x1\x63\x1\x69\x1\x6C\x1\x74\x1\x6F"+
        "\x1\x6C\x1\x6F\x1\x76\x2\x24\x1\x69\x1\x61\x1\x6B\x1\x78\x1\x6D"+
        "\x1\x6E\x1\x77\x1\x74\x1\x6C\x1\x6A\x3\x24\x1\x74\x1\x6F\x1\x67"+
        "\x1\x6C\x2\x6D\x1\x65\x1\x61\x1\x69\x1\x64\x1\x72\x1\x65\x1\x74"+
        "\xA\xFFFF\x4\x24\x1\xFFFF\x1\x24\x1\x77\x1\x68\x1\xFFFF\x1\x65\x1"+
        "\x73\x1\x6E\x1\x65\x1\x63\x1\x74\x1\x6D\x1\x65\x1\x74\x1\x24\x1"+
        "\x61\x2\x73\x1\x63\x1\x6D\x1\x6C\x1\x75\x2\x69\x2\x65\x1\x6F\x2"+
        "\xFFFF\x1\x6E\x1\x64\x1\x74\x1\x65\x1\x24\x1\x62\x3\x24\x1\x6C\x1"+
        "\x65\x2\xFFFF\x1\x65\x1\xFFFF\x1\x65\x1\x70\x1\x68\x1\x65\x1\x24"+
        "\x1\x65\x1\x24\x1\x6E\x1\x69\x1\x65\x1\x6F\x1\x61\x1\x73\x1\x6E"+
        "\x1\x68\x3\xFFFF\x1\x6E\x2\xFFFF\x1\x65\x2\x24\x1\x73\x2\x74\x1"+
        "\x24\x1\x69\x1\x65\x1\x24\x1\x79\x1\xFFFF\x1\x70\x1\x74\x1\x65\x1"+
        "\x68\x2\x24\x1\x70\x1\x6E\x1\x63\x2\x72\x2\x24\x1\x69\x2\x24\x1"+
        "\xFFFF\x1\x65\x3\xFFFF\x1\x24\x1\x63\x2\x72\x1\x65\x1\x74\x1\x63"+
        "\x1\xFFFF\x1\x24\x1\xFFFF\x1\x24\x1\x6C\x1\x24\x1\x6E\x1\x74\x1"+
        "\x69\x1\x24\x1\x65\x1\x24\x1\x64\x1\x65\x2\xFFFF\x2\x24\x1\x65\x1"+
        "\x6E\x1\xFFFF\x2\x6E\x1\xFFFF\x1\x24\x1\x65\x1\x73\x2\x24\x2\xFFFF"+
        "\x1\x24\x1\x67\x1\x65\x1\x24\x1\x74\x2\xFFFF\x1\x6E\x2\xFFFF\x1"+
        "\x72\x1\xFFFF\x1\x74\x2\x24\x1\x72\x1\x24\x1\x74\x2\xFFFF\x1\x69"+
        "\x1\xFFFF\x1\x24\x1\x65\x1\x6F\x1\xFFFF\x1\x24\x1\xFFFF\x1\x69\x1"+
        "\x6E\x2\xFFFF\x1\x24\x1\x64\x1\x63\x1\x74\x1\xFFFF\x2\x24\x3\xFFFF"+
        "\x1\x24\x1\x73\x1\xFFFF\x1\x24\x1\x67\x2\x24\x2\xFFFF\x1\x74\x1"+
        "\xFFFF\x1\x24\x1\x6E\x1\xFFFF\x1\x24\x1\x6E\x1\xFFFF\x1\x6E\x1\x24"+
        "\x1\xFFFF\x1\x69\x1\x74\x1\x73\x3\xFFFF\x1\x24\x1\xFFFF\x1\x24\x2"+
        "\xFFFF\x1\x69\x1\xFFFF\x1\x67\x1\xFFFF\x1\x65\x1\x67\x1\xFFFF\x1"+
        "\x6E\x2\x24\x2\xFFFF\x1\x65\x1\x24\x1\x64\x1\x24\x1\x67\x2\xFFFF"+
        "\x1\x73\x1\xFFFF\x1\x24\x1\xFFFF\x2\x24\x3\xFFFF";
    const string DFA23_maxS =
        "\x1\xFFFE\x1\x76\x1\x79\x1\x6F\x1\x69\x1\x78\x1\x75\x1\x72\x1\x61"+
        "\x1\x73\x1\x6F\x2\x69\x2\x75\x1\x72\x1\x69\x1\x75\x1\x72\x1\x70"+
        "\x1\x65\x1\x69\x1\xFFFF\x1\x3E\x3\x3D\x1\x7C\x10\xFFFF\x1\x6C\x1"+
        "\x79\x1\xFFFE\x1\x67\x2\x74\x1\xFFFE\x1\x73\x1\x61\x1\x75\x3\x73"+
        "\x1\x70\x1\x64\x1\x63\x1\x69\x1\x6C\x1\x74\x1\x6F\x1\x6C\x1\x6F"+
        "\x1\x76\x2\xFFFE\x1\x69\x1\x66\x1\x6B\x1\x78\x1\x6D\x1\x6E\x1\x77"+
        "\x1\x74\x1\x6C\x1\x6A\x3\xFFFE\x1\x74\x1\x6F\x1\x67\x1\x74\x2\x6D"+
        "\x1\x65\x1\x75\x1\x69\x1\x64\x1\x72\x1\x65\x1\x74\xA\xFFFF\x4\xFFFE"+
        "\x1\xFFFF\x1\xFFFE\x1\x77\x1\x68\x1\xFFFF\x1\x65\x1\x73\x1\x6E\x1"+
        "\x65\x1\x63\x1\x74\x1\x6D\x1\x65\x1\x74\x1\xFFFE\x1\x61\x2\x73\x1"+
        "\x63\x1\x6D\x1\x6C\x1\x75\x2\x69\x2\x65\x1\x6F\x2\xFFFF\x1\x6E\x1"+
        "\x64\x1\x74\x1\x65\x1\xFFFE\x1\x62\x3\xFFFE\x1\x6C\x1\x65\x2\xFFFF"+
        "\x1\x65\x1\xFFFF\x1\x65\x1\x70\x1\x68\x1\x65\x1\xFFFE\x1\x65\x1"+
        "\xFFFE\x1\x6E\x1\x69\x1\x65\x1\x6F\x1\x61\x1\x73\x1\x72\x1\x68\x3"+
        "\xFFFF\x1\x6E\x2\xFFFF\x1\x65\x2\xFFFE\x1\x73\x2\x74\x1\xFFFE\x1"+
        "\x69\x1\x65\x1\xFFFE\x1\x79\x1\xFFFF\x1\x70\x1\x74\x1\x65\x1\x68"+
        "\x2\xFFFE\x1\x70\x1\x6E\x1\x63\x2\x72\x2\xFFFE\x1\x69\x2\xFFFE\x1"+
        "\xFFFF\x1\x65\x3\xFFFF\x1\xFFFE\x1\x63\x2\x72\x1\x65\x1\x74\x1\x63"+
        "\x1\xFFFF\x1\xFFFE\x1\xFFFF\x1\xFFFE\x1\x6C\x1\xFFFE\x1\x6E\x1\x74"+
        "\x1\x69\x1\xFFFE\x1\x65\x1\xFFFE\x1\x64\x1\x65\x2\xFFFF\x2\xFFFE"+
        "\x1\x65\x1\x6E\x1\xFFFF\x2\x6E\x1\xFFFF\x1\xFFFE\x1\x65\x1\x73\x2"+
        "\xFFFE\x2\xFFFF\x1\xFFFE\x1\x67\x1\x65\x1\xFFFE\x1\x74\x2\xFFFF"+
        "\x1\x6E\x2\xFFFF\x1\x72\x1\xFFFF\x1\x74\x2\xFFFE\x1\x72\x1\xFFFE"+
        "\x1\x74\x2\xFFFF\x1\x69\x1\xFFFF\x1\xFFFE\x1\x65\x1\x6F\x1\xFFFF"+
        "\x1\xFFFE\x1\xFFFF\x1\x69\x1\x6E\x2\xFFFF\x1\xFFFE\x1\x64\x1\x63"+
        "\x1\x74\x1\xFFFF\x2\xFFFE\x3\xFFFF\x1\xFFFE\x1\x73\x1\xFFFF\x1\xFFFE"+
        "\x1\x67\x2\xFFFE\x2\xFFFF\x1\x74\x1\xFFFF\x1\xFFFE\x1\x6E\x1\xFFFF"+
        "\x1\xFFFE\x1\x6E\x1\xFFFF\x1\x6E\x1\xFFFE\x1\xFFFF\x1\x69\x1\x74"+
        "\x1\x73\x3\xFFFF\x1\xFFFE\x1\xFFFF\x1\xFFFE\x2\xFFFF\x1\x69\x1\xFFFF"+
        "\x1\x67\x1\xFFFF\x1\x65\x1\x67\x1\xFFFF\x1\x6E\x2\xFFFE\x2\xFFFF"+
        "\x1\x65\x1\xFFFE\x1\x64\x1\xFFFE\x1\x67\x2\xFFFF\x1\x73\x1\xFFFF"+
        "\x1\xFFFE\x1\xFFFF\x2\xFFFE\x3\xFFFF";
    const string DFA23_acceptS =
        "\x16\xFFFF\x1\x43\x5\xFFFF\x1\x4C\x1\x4E\x1\x4F\x1\x50\x1\x51\x1"+
        "\x52\x1\x54\x1\x55\x1\x56\x1\x57\x1\x58\x1\x59\x1\x5A\x1\x5B\x1"+
        "\x5C\x1\x5D\x33\xFFFF\x1\x46\x1\x48\x1\x44\x1\x49\x1\x45\x1\x47"+
        "\x1\x4D\x1\x4B\x1\x53\x1\x4A\x4\xFFFF\x1\x4\x3\xFFFF\x1\x25\x16"+
        "\xFFFF\x1\x1B\x1\x20\xB\xFFFF\x1\x2D\x1\x2E\x1\xFFFF\x1\x2F\xF\xFFFF"+
        "\x1\x1\x1\x2\x1\x3\x1\xFFFF\x1\x5\x1\x6\xB\xFFFF\x1\x12\x10\xFFFF"+
        "\x1\x26\x1\xFFFF\x1\x28\x1\x29\x1\x2A\x7\xFFFF\x1\x35\x1\xFFFF\x1"+
        "\x37\xB\xFFFF\x1\x8\x1\x9\x4\xFFFF\x1\xD\x2\xFFFF\x1\x10\x5\xFFFF"+
        "\x1\x17\x1\x18\x5\xFFFF\x1\x1F\x1\x21\x1\xFFFF\x1\x23\x1\x24\x1"+
        "\xFFFF\x1\x2B\x6\xFFFF\x1\x36\x1\x38\x1\xFFFF\x1\x3A\x3\xFFFF\x1"+
        "\x3E\x1\xFFFF\x1\x40\x2\xFFFF\x1\xA\x1\xB\x4\xFFFF\x1\x11\x2\xFFFF"+
        "\x1\x15\x1\x16\x1\x19\x2\xFFFF\x1\x1D\x4\xFFFF\x1\x30\x1\x31\x1"+
        "\xFFFF\x1\x33\x2\xFFFF\x1\x3B\x2\xFFFF\x1\x3F\x2\xFFFF\x1\xC\x3"+
        "\xFFFF\x1\x13\x1\x14\x1\x1A\x1\xFFFF\x1\x1E\x1\xFFFF\x1\x27\x1\x2C"+
        "\x1\xFFFF\x1\x34\x1\xFFFF\x1\x3C\x2\xFFFF\x1\x7\x3\xFFFF\x1\x1C"+
        "\x1\x22\x5\xFFFF\x1\xE\x1\xF\x1\xFFFF\x1\x39\x1\xFFFF\x1\x41\x2"+
        "\xFFFF\x1\x3D\x1\x42\x1\x32";
    const string DFA23_specialS =
        "\x15A\xFFFF}>";
    static readonly string[] DFA23_transitionS = {
            "\x2\x2A\x2\xFFFF\x1\x2A\x12\xFFFF\x1\x2A\x1\x19\x2\xFFFF\x1"+
            "\x28\x1\xFFFF\x1\x1C\x1\x29\x1\x1E\x1\x1F\x1\x24\x1\x22\x1\x1D"+
            "\x1\x23\x1\x2B\x1\x25\xA\x2B\x1\x26\x1\xFFFF\x1\x17\x1\x16\x1"+
            "\x18\x1\x27\x1\xFFFF\x1A\x28\x1\x20\x1\xFFFF\x1\x21\x1\x1A\x1"+
            "\x28\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8"+
            "\x1\x9\x1\xA\x1\x28\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x28\x1"+
            "\x10\x1\x11\x1\x12\x1\x13\x1\x14\x1\x15\x3\x28\x1\xFFFF\x1\x1B"+
            "\x3\xFFFF\xFF7F\x28",
            "\x1\x2C\x1\xFFFF\x1\x2D\x4\xFFFF\x1\x2E\x2\xFFFF\x1\x2F",
            "\x1\x30\x9\xFFFF\x1\x31\x9\xFFFF\x1\x32",
            "\x1\x33\xA\xFFFF\x1\x34\x2\xFFFF\x1\x35",
            "\x1\x36\x3\xFFFF\x1\x37",
            "\x1\x38\x1\x39\x1\x3A\x4\xFFFF\x1\x3B\x4\xFFFF\x1\x3C",
            "\x1\x3D\x3\xFFFF\x1\x3E\xC\xFFFF\x1\x3F\x2\xFFFF\x1\x40",
            "\x1\x41",
            "\x1\x42",
            "\x1\x43\x4\xFFFF\x1\x44",
            "\x1\x45",
            "\x1\x46\x3\xFFFF\x1\x47",
            "\x1\x48\x3\xFFFF\x1\x49\x3\xFFFF\x1\x4A",
            "\x1\x4B\x9\xFFFF\x1\x4C\x5\xFFFF\x1\x4D",
            "\x1\x4E\x3\xFFFF\x1\x4F\x7\xFFFF\x1\x50\x3\xFFFF\x1\x51\x2\xFFFF"+
            "\x1\x52",
            "\x1\x53",
            "\x1\x54",
            "\x1\x55\x9\xFFFF\x1\x56\x5\xFFFF\x1\x57",
            "\x1\x58\x9\xFFFF\x1\x59",
            "\x1\x5A\x1\xFFFF\x1\x5B",
            "\x1\x5C",
            "\x1\x5D\x1\x5E",
            "",
            "\x1\x60\x1\x5F",
            "\x1\x62",
            "\x1\x64",
            "\x1\x64",
            "\x1\x67",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x69",
            "\x1\x6A\x14\xFFFF\x1\x6B",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x2\x28\x1\x6C\x17\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x6E",
            "\x1\x6F",
            "\x1\x70",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x72",
            "\x1\x73",
            "\x1\x74",
            "\x1\x75\x6\xFFFF\x1\x76",
            "\x1\x77",
            "\x1\x78\xD\xFFFF\x1\x79",
            "\x1\x7A",
            "\x1\x7B",
            "\x1\x7C",
            "\x1\x7D",
            "\x1\x7E",
            "\x1\x7F",
            "\x1\x80",
            "\x1\x81",
            "\x1\x82",
            "\x1\x83",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x3\x28\x1\x84\x9\x28\x1\x85\x4\x28\x1\x86\x1\x87\x6\x28"+
            "\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x8A",
            "\x1\x8B\x4\xFFFF\x1\x8C",
            "\x1\x8D",
            "\x1\x8E",
            "\x1\x8F",
            "\x1\x90",
            "\x1\x91",
            "\x1\x92",
            "\x1\x93",
            "\x1\x94",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x3\x28\x1\x97\x16\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x99",
            "\x1\x9A",
            "\x1\x9B",
            "\x1\x9C\x7\xFFFF\x1\x9D",
            "\x1\x9E",
            "\x1\x9F",
            "\x1\xA0",
            "\x1\xA1\x13\xFFFF\x1\xA2",
            "\x1\xA3",
            "\x1\xA4",
            "\x1\xA5",
            "\x1\xA6",
            "\x1\xA7",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x4\x28\x1\xAB\x15\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xAE",
            "\x1\xAF",
            "",
            "\x1\xB0",
            "\x1\xB1",
            "\x1\xB2",
            "\x1\xB3",
            "\x1\xB4",
            "\x1\xB5",
            "\x1\xB6",
            "\x1\xB7",
            "\x1\xB8",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xBA",
            "\x1\xBB",
            "\x1\xBC",
            "\x1\xBD",
            "\x1\xBE",
            "\x1\xBF",
            "\x1\xC0",
            "\x1\xC1",
            "\x1\xC2",
            "\x1\xC3",
            "\x1\xC4",
            "\x1\xC5",
            "",
            "",
            "\x1\xC6",
            "\x1\xC7",
            "\x1\xC8",
            "\x1\xC9",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xCB",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xCF",
            "\x1\xD0",
            "",
            "",
            "\x1\xD1",
            "",
            "\x1\xD2",
            "\x1\xD3",
            "\x1\xD4",
            "\x1\xD5",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xD7",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xD9",
            "\x1\xDA",
            "\x1\xDB",
            "\x1\xDC",
            "\x1\xDD",
            "\x1\xDE",
            "\x1\xDF\x3\xFFFF\x1\xE0",
            "\x1\xE1",
            "",
            "",
            "",
            "\x1\xE2",
            "",
            "",
            "\x1\xE3",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xE6",
            "\x1\xE7",
            "\x1\xE8",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x4\x28\x1\xE9\x15\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xEB",
            "\x1\xEC",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xEE",
            "",
            "\x1\xEF",
            "\x1\xF0",
            "\x1\xF1",
            "\x1\xF2",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xF5",
            "\x1\xF6",
            "\x1\xF7",
            "\x1\xF8",
            "\x1\xF9",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\xFC",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\xFF",
            "",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x101",
            "\x1\x102",
            "\x1\x103",
            "\x1\x104",
            "\x1\x105",
            "\x1\x106",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x109",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x10B",
            "\x1\x10C",
            "\x1\x10D",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x10F",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x111",
            "\x1\x112",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x115",
            "\x1\x116",
            "",
            "\x1\x117",
            "\x1\x118",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x11A",
            "\x1\x11B",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x11F",
            "\x1\x120",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x122",
            "",
            "",
            "\x1\x123",
            "",
            "",
            "\x1\x124",
            "",
            "\x1\x125",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x128",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x12A",
            "",
            "",
            "\x1\x12B",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x12D",
            "\x1\x12E",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x130",
            "\x1\x131",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x133",
            "\x1\x134",
            "\x1\x135",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x139",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x13B",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            "\x1\x13E",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x140",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x142",
            "",
            "\x1\x143",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x145",
            "\x1\x146",
            "\x1\x147",
            "",
            "",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            "\x1\x14A",
            "",
            "\x1\x14B",
            "",
            "\x1\x14C",
            "\x1\x14D",
            "",
            "\x1\x14E",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            "\x1\x151",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x153",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x155",
            "",
            "",
            "\x1\x156",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "\x1\x28\xB\xFFFF\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1"+
            "\xFFFF\x1A\x28\x5\xFFFF\xFF7F\x28",
            "",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "1:0: Tokens : ( ALL | AND | ANY | AS | ASCENDING | AVG | BETWEEN | BOTH | CASE | CLASS | COUNT | DELETE | DESCENDING | DISTINCT | ELEMENTS | ELSE | EMPTY | END | ESCAPE | EXISTS | FALSE | FETCH | FROM | FULL | GROUP | HAVING | IN | INDICES | INNER | INSERT | INTO | IS | JOIN | LEADING | LEFT | LIKE | LITERAL_by | MAX | MEMBER | MIN | NEW | NOT | NULL | OBJECT | OF | ON | OR | ORDER | OUTER | PROPERTIES | RIGHT | SELECT | SET | SOME | SUM | THEN | TRAILING | TRUE | UNION | UPDATE | VERSIONED | WHEN | WHERE | WITH | T__130 | T__131 | EQ | LT | GT | SQL_NE | NE | LE | GE | BOR | BXOR | BAND | BNOT | COMMA | OPEN | CLOSE | OPEN_BRACKET | CLOSE_BRACKET | CONCAT | PLUS | MINUS | STAR | DIV | COLON | PARAM | IDENT | QUOTED_String | WS | NUM_INT );"; }
        }

    }

 
    
}
}