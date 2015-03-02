grammar QLMain;

/* Form Structure */

 form           : 'form' formSection
;formSection    : '{' formObject* '}' 
;formObject     : question
                | conditional
; question       : 'question' id type keyValuePairs
; conditional   : 'enable when' expression formSection
;

/* Types */ 
 type              : BOOL    #BoolType
                   | STRING  #StringType
                   | INT     #IntType
;value             : bool    #BoolValue
                   | string  #StringValue
                   | int     #IntValue
;bool              : TRUE    #TrueBool
                   | FALSE   #FalseBool

/* Literal Types*/
;string         : STRINGLITERAL
;int            : INTLITERAL
;id             : ALPHANUMERIC
;

/* KeyValPairs */   
 keyValuePairs  : '{' kvp+= keyValuePair (',' kvp+= keyValuePair)* '}'
;keyValuePair   : key '=' expression #KvpExpression
                | key '=' arithmetic #KvpArithmetic
                | key '=' value      #KvpLiteral
;key            : ALPHANUMERIC
;

/* Expression & arithmetic */
 expression     : '(' expression ')'                         #PriorityExpression
                | bool                                       #BoolExpression
                | id                                         #IdExpression
                |'!' expression                              #Negate
                | expression op= AND expression              #And
                | expression op= OR  expression              #Or
                | arithmetic op=( NEQ | EQ ) arithmetic      #Equality
                | comparison                                 #ComparisonExpression

;comparison     : '(' comparison ')'                                 #PriorityComparison
                | arithmetic op=( GT | LT | GET | LET ) arithmetic   #RelationalComparison

;arithmetic     : '(' arithmetic ')'                      #PriorityArithmetic
                | arithmetic op=( MUL | DIV ) arithmetic  #DivMul
                | arithmetic op=( SUB | ADD ) arithmetic  #SubAdd
                | int                                     #IntArithmetic
                | id                                      #IdArithmetic
                ;

/*Token Names*/
GT   : '>';
LT   : '<';
EQ   : '==';
NEQ  : '!=';
GET  : '>=';
LET  : '<=';
AND  : '&&';
OR   : '||';
NOT  : '!';

MUL  : '*';
DIV  : '/';
SUB  : '-';
ADD  : '+';

TRUE  : 'True';
FALSE : 'False';

BOOL   : 'bool';
STRING : 'string'; 
DATE   : 'date';
INT    : 'int';

/*Lexer rules*/
INTLITERAL     : '-'?[0-9]+;

YEAR  : [0-9]+;
MONTH : [0-9][0-9];
DAY   : [0-9][0-9];

ALPHANUMERIC : [a-zA-Z0-9]+;
STRINGLITERAL : '"' .*? '"';

/* White Space & Comments */
 WS             : (' ' | '\r' | '\n') -> channel(HIDDEN)
;BLOCK_COMMENT  : '/*' .*? '*/'       -> channel(HIDDEN)
;LINE_COMMENT   : '--' ~[\r\n]*       -> channel(HIDDEN)
;