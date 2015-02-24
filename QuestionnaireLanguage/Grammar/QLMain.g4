grammar QLMain;

/* Form Structure */

 form           : 'form' formSection
;formSection    : '{' formObject* '}' 
;formObject     : question
                | conditional
; question       : 'question' id typeName keyValuePairs
; conditional   : 'enable when' expression formSection
;

/* Types */ 
 typeName          : listTypeName
                   | primitiveTypeName
;listTypeName	   : 'list[' primitiveTypeName ']'
;primitiveTypeName : 'bool'
                   | 'string'
                   | 'date'
                   | 'int'
                   | 'decimal'
                   | 'money'
;type              : bool    #BoolValue
                   | string  #StringValue
                   | date    #DateValue
                   | num     #NumValue
                   | list    #ListValue
;bool              : 'True'
                   | 'False'
;date              : 'date(' year '/' month '/' day ')'
                   | 'date(' year '/' month')' 
                   | 'date(' year ')'
;num               : int      #NumInt
                   | money    #NumMoney
                   | decimal  #NumDecimal
;list              : '[' (type (',' type )*)? ']'
;

/* Literal Types*/
 year           : YEAR 
;month          : MONTH
;day            : DAY
;string         : STRING
;int            : INT
;decimal        : DECIMAL
;money          : MONEY
;id             : ALPHANUMERIC
;

/* KeyValPairs */   
 keyValuePairs  : '{' kvp+= keyValuePair (',' kvp+= keyValuePair)* '}'
;keyValuePair   : key '=' expression
;key            : ALPHANUMERIC
;

/* Expression & arithmetic */
 expression     : '(' expression ')'                         #PriorityExpression
                | type                                       #ValueExpression
                | id                                         #IdExpression
                |'!' expression                              #Negate
                | expression op='&&' expression              #And
                | expression op='||' expression              #Or
                | arithmetic op=( '!=' | '==' ) arithmetic   #Equality
                | comparison                                 #ComparisonExpression

;comparison     : '(' comparison ')'                                     #PriorityComparison
                | arithmetic op=( '>' | '<' | '>=' | '<=' ) arithmetic   #RelationalComparison

;arithmetic     : '(' arithmetic ')'                      #PriorityArithmetic
                | arithmetic op=( '*' | '/' ) arithmetic  #DivMul
                | arithmetic op=( '-' | '+' ) arithmetic  #SubAdd
                | type                                    #ValueArithmetic
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



/*Lexer rules*/
INT     : '-'?[0-9]+;
DECIMAL : '-'?[0-9]+ '.' [0-9]+;
MONEY   : '-'?[0-9]+ '.' [0-9][0-9];

YEAR  : [0-9]+;
MONTH : [0-9][0-9];
DAY   : [0-9][0-9];

ALPHANUMERIC : [a-zA-Z0-9]+;
STRING : '"' .*? '"';

/* White Space & Comments */
 WS             : (' ' | '\r' | '\n') -> channel(HIDDEN)
;BLOCK_COMMENT  : '/*' .*? '*/'       -> channel(HIDDEN)
;LINE_COMMENT   : '--' ~[\r\n]*       -> channel(HIDDEN)
;