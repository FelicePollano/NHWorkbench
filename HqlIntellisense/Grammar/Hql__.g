lexer grammar Hql;
options {
  language=CSharp2;

}

@namespace { HqlIntellisense }

ALL : 'all' ;
AND : 'and' ;
ANY : 'any' ;
AS : 'as' ;
ASCENDING : 'asc' ;
AVG : 'avg' ;
BETWEEN : 'between' ;
BOTH : 'both' ;
CASE : 'case' ;
CLASS : 'class' ;
COUNT : 'count' ;
DELETE : 'delete' ;
DESCENDING : 'desc' ;
DISTINCT : 'distinct' ;
ELEMENTS : 'elements' ;
ELSE : 'else' ;
EMPTY : 'empty' ;
END : 'end' ;
ESCAPE : 'escape' ;
EXISTS : 'exists' ;
FALSE : 'false' ;
FETCH : 'fetch' ;
FROM : 'from' ;
FULL : 'full' ;
GROUP : 'group' ;
HAVING : 'having' ;
IN : 'in' ;
INDICES : 'indices' ;
INNER : 'inner' ;
INSERT : 'insert' ;
INTO : 'into' ;
IS : 'is' ;
JOIN : 'join' ;
LEADING : 'leading' ;
LEFT : 'left' ;
LIKE : 'like' ;
LITERAL_by : 'by' ;
MAX : 'max' ;
MEMBER : 'member' ;
MIN : 'min' ;
NEW : 'new' ;
NOT : 'not' ;
NULL : 'null' ;
OBJECT : 'object' ;
OF : 'of' ;
ON : 'on' ;
OR : 'or' ;
ORDER : 'order' ;
OUTER : 'outer' ;
PROPERTIES : 'properties' ;
RIGHT : 'right' ;
SELECT : 'select' ;
SET : 'set' ;
SOME : 'some' ;
SUM : 'sum' ;
THEN : 'then' ;
TRAILING : 'trailing' ;
TRUE : 'true' ;
UNION : 'union' ;
UPDATE : 'update' ;
VERSIONED : 'versioned' ;
WHEN : 'when' ;
WHERE : 'where' ;
WITH : 'with' ;
T__130 : 'ascending' ;
T__131 : 'descending' ;

// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 672
EQ: '=';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 673
LT: '<';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 674
GT: '>';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 675
SQL_NE: '<>';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 676
NE: '!=' | '^=';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 677
LE: '<=';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 678
GE: '>=';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 680
BOR	:	 '|';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 681
BXOR	:	'^';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 682
BAND	:	'&';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 683
BNOT	:	'!';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 685
COMMA: ',';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 687
OPEN: '(';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 688
CLOSE: ')';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 689
OPEN_BRACKET: '[';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 690
CLOSE_BRACKET: ']';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 692
CONCAT: '||';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 693
PLUS: '+';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 694
MINUS: '-';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 695
STAR: '*';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 696
DIV: '/';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 697
COLON: ':';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 698
PARAM: '?';// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 700
IDENT 
	: ID_START_LETTER ( ID_LETTER )*
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 705
fragment
ID_START_LETTER
    :    '_'
    |    '$'
    |    'a'..'z'
    |    'A'..'Z'
    |    '\u0080'..'\ufffe'       // HHH-558 : Allow unicode chars in identifiers
    ;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 714
fragment
ID_LETTER
    :    ID_START_LETTER
    |    '0'..'9'
    ;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 719
QUOTED_String
	  : '\'' ( (ESCqs)=> ESCqs | ~'\'' )* '\''
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 724
fragment
ESCqs
	:
		'\'' '\''
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 729
WS  :   (   ' '
		|   '\t'
		|   '\r' '\n'
		|   '\n'
		|   '\r'
		)
		{Skip();} //ignore this token
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 740
NUM_INT
	@init {bool isDecimal=false; IToken t=null;}
	:   '.' {_type = DOT;}
			(	('0'..'9')+ (EXPONENT)? (f1=FLOAT_SUFFIX {t=f1;})?
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
			)?
	|	(	'0' {isDecimal = true;} // special case for just '0'
			(	('x')
				(											// hex
					// the 'e'|'E' and float suffix stuff look
					// like hex digits, hence the (...)+ doesn't
					// know when to stop: ambig.  ANTLR resolves
					// it correctly by matching immediately.  It
					// is therefore ok to hush warning.
					// TODO options { warnWhenFollowAmbig=false; }
				:	HEX_DIGIT
				)+
			|	('0'..'7')+									// octal
			)?
		|	('1'..'9') ('0'..'9')*  {isDecimal=true;}		// non-zero decimal
		)
		(	('l') { _type = NUM_LONG; }

		// only check to see if it's a float if looks like decimal so far
		|	{isDecimal}?
			(   '.' ('0'..'9')* (EXPONENT)? (f2=FLOAT_SUFFIX {t=f2;})?
			|   EXPONENT (f3=FLOAT_SUFFIX {t=f3;})?
			|   f4=FLOAT_SUFFIX {t=f4;}
			)
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
		)?
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 793
fragment
HEX_DIGIT
	:	('0'..'9'|'a'..'f')
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 799
fragment
EXPONENT
	:	('e') ('+'|'-')? ('0'..'9')+
	;// $ANTLR src "C:\Documents and Settings\FPollano\My Documents\Visual Studio 2008\Projects\HqlIntellisense\HqlIntellisense\Grammar\Hql.g" 804
fragment
FLOAT_SUFFIX
	:	'f'|'d'
	;