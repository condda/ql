//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Jonatan\Desktop\QL Github\ql\QuestionnaireLanguage\Grammar\QLMain.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Grammar {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class QLMainLexer : Lexer {
	public const int
		T__8=1, T__7=2, T__6=3, T__5=4, T__4=5, T__3=6, T__2=7, T__1=8, T__0=9, 
		GT=10, LT=11, EQ=12, NEQ=13, GET=14, LET=15, AND=16, OR=17, NOT=18, MUL=19, 
		DIV=20, SUB=21, ADD=22, TRUE=23, FALSE=24, BOOL=25, STRING=26, DATE=27, 
		INT=28, INTLITERAL=29, YEAR=30, MONTH=31, DAY=32, ALPHANUMERIC=33, STRINGLITERAL=34, 
		WS=35, BLOCK_COMMENT=36, LINE_COMMENT=37;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'", 
		"'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'", 
		"'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'", 
		"'\\u001F'", "' '", "'!'", "'\"'", "'#'", "'$'", "'%'"
	};
	public static readonly string[] ruleNames = {
		"T__8", "T__7", "T__6", "T__5", "T__4", "T__3", "T__2", "T__1", "T__0", 
		"GT", "LT", "EQ", "NEQ", "GET", "LET", "AND", "OR", "NOT", "MUL", "DIV", 
		"SUB", "ADD", "TRUE", "FALSE", "BOOL", "STRING", "DATE", "INT", "INTLITERAL", 
		"YEAR", "MONTH", "DAY", "ALPHANUMERIC", "STRINGLITERAL", "WS", "BLOCK_COMMENT", 
		"LINE_COMMENT"
	};


	public QLMainLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "QLMain.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\'\xF1\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3"+
		"\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10"+
		"\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14"+
		"\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x5\x1E"+
		"\xB5\n\x1E\x3\x1E\x6\x1E\xB8\n\x1E\r\x1E\xE\x1E\xB9\x3\x1F\x6\x1F\xBD"+
		"\n\x1F\r\x1F\xE\x1F\xBE\x3 \x3 \x3 \x3!\x3!\x3!\x3\"\x6\"\xC8\n\"\r\""+
		"\xE\"\xC9\x3#\x3#\a#\xCE\n#\f#\xE#\xD1\v#\x3#\x3#\x3$\x3$\x3$\x3$\x3%"+
		"\x3%\x3%\x3%\a%\xDD\n%\f%\xE%\xE0\v%\x3%\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3"+
		"&\a&\xEB\n&\f&\xE&\xEE\v&\x3&\x3&\x4\xCF\xDE\x2\x2\'\x3\x2\x3\x5\x2\x4"+
		"\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2"+
		"\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$"+
		"G\x2%I\x2&K\x2\'\x3\x2\x6\x3\x2\x32;\x5\x2\x32;\x43\\\x63|\x5\x2\f\f\xF"+
		"\xF\"\"\x4\x2\f\f\xF\xF\xF7\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3"+
		"\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3"+
		"\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2"+
		"\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2"+
		"\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2"+
		"\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/"+
		"\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2"+
		"\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x3M\x3\x2\x2\x2\x5"+
		"V\x3\x2\x2\x2\aX\x3\x2\x2\x2\tZ\x3\x2\x2\x2\v\x66\x3\x2\x2\x2\rh\x3\x2"+
		"\x2\x2\xFj\x3\x2\x2\x2\x11o\x3\x2\x2\x2\x13q\x3\x2\x2\x2\x15s\x3\x2\x2"+
		"\x2\x17u\x3\x2\x2\x2\x19w\x3\x2\x2\x2\x1Bz\x3\x2\x2\x2\x1D}\x3\x2\x2\x2"+
		"\x1F\x80\x3\x2\x2\x2!\x83\x3\x2\x2\x2#\x86\x3\x2\x2\x2%\x89\x3\x2\x2\x2"+
		"\'\x8B\x3\x2\x2\x2)\x8D\x3\x2\x2\x2+\x8F\x3\x2\x2\x2-\x91\x3\x2\x2\x2"+
		"/\x93\x3\x2\x2\x2\x31\x98\x3\x2\x2\x2\x33\x9E\x3\x2\x2\x2\x35\xA3\x3\x2"+
		"\x2\x2\x37\xAA\x3\x2\x2\x2\x39\xAF\x3\x2\x2\x2;\xB4\x3\x2\x2\x2=\xBC\x3"+
		"\x2\x2\x2?\xC0\x3\x2\x2\x2\x41\xC3\x3\x2\x2\x2\x43\xC7\x3\x2\x2\x2\x45"+
		"\xCB\x3\x2\x2\x2G\xD4\x3\x2\x2\x2I\xD8\x3\x2\x2\x2K\xE6\x3\x2\x2\x2MN"+
		"\as\x2\x2NO\aw\x2\x2OP\ag\x2\x2PQ\au\x2\x2QR\av\x2\x2RS\ak\x2\x2ST\aq"+
		"\x2\x2TU\ap\x2\x2U\x4\x3\x2\x2\x2VW\a*\x2\x2W\x6\x3\x2\x2\x2XY\a+\x2\x2"+
		"Y\b\x3\x2\x2\x2Z[\ag\x2\x2[\\\ap\x2\x2\\]\a\x63\x2\x2]^\a\x64\x2\x2^_"+
		"\an\x2\x2_`\ag\x2\x2`\x61\a\"\x2\x2\x61\x62\ay\x2\x2\x62\x63\aj\x2\x2"+
		"\x63\x64\ag\x2\x2\x64\x65\ap\x2\x2\x65\n\x3\x2\x2\x2\x66g\a}\x2\x2g\f"+
		"\x3\x2\x2\x2hi\a.\x2\x2i\xE\x3\x2\x2\x2jk\ah\x2\x2kl\aq\x2\x2lm\at\x2"+
		"\x2mn\ao\x2\x2n\x10\x3\x2\x2\x2op\a?\x2\x2p\x12\x3\x2\x2\x2qr\a\x7F\x2"+
		"\x2r\x14\x3\x2\x2\x2st\a@\x2\x2t\x16\x3\x2\x2\x2uv\a>\x2\x2v\x18\x3\x2"+
		"\x2\x2wx\a?\x2\x2xy\a?\x2\x2y\x1A\x3\x2\x2\x2z{\a#\x2\x2{|\a?\x2\x2|\x1C"+
		"\x3\x2\x2\x2}~\a@\x2\x2~\x7F\a?\x2\x2\x7F\x1E\x3\x2\x2\x2\x80\x81\a>\x2"+
		"\x2\x81\x82\a?\x2\x2\x82 \x3\x2\x2\x2\x83\x84\a(\x2\x2\x84\x85\a(\x2\x2"+
		"\x85\"\x3\x2\x2\x2\x86\x87\a~\x2\x2\x87\x88\a~\x2\x2\x88$\x3\x2\x2\x2"+
		"\x89\x8A\a#\x2\x2\x8A&\x3\x2\x2\x2\x8B\x8C\a,\x2\x2\x8C(\x3\x2\x2\x2\x8D"+
		"\x8E\a\x31\x2\x2\x8E*\x3\x2\x2\x2\x8F\x90\a/\x2\x2\x90,\x3\x2\x2\x2\x91"+
		"\x92\a-\x2\x2\x92.\x3\x2\x2\x2\x93\x94\aV\x2\x2\x94\x95\at\x2\x2\x95\x96"+
		"\aw\x2\x2\x96\x97\ag\x2\x2\x97\x30\x3\x2\x2\x2\x98\x99\aH\x2\x2\x99\x9A"+
		"\a\x63\x2\x2\x9A\x9B\an\x2\x2\x9B\x9C\au\x2\x2\x9C\x9D\ag\x2\x2\x9D\x32"+
		"\x3\x2\x2\x2\x9E\x9F\a\x64\x2\x2\x9F\xA0\aq\x2\x2\xA0\xA1\aq\x2\x2\xA1"+
		"\xA2\an\x2\x2\xA2\x34\x3\x2\x2\x2\xA3\xA4\au\x2\x2\xA4\xA5\av\x2\x2\xA5"+
		"\xA6\at\x2\x2\xA6\xA7\ak\x2\x2\xA7\xA8\ap\x2\x2\xA8\xA9\ai\x2\x2\xA9\x36"+
		"\x3\x2\x2\x2\xAA\xAB\a\x66\x2\x2\xAB\xAC\a\x63\x2\x2\xAC\xAD\av\x2\x2"+
		"\xAD\xAE\ag\x2\x2\xAE\x38\x3\x2\x2\x2\xAF\xB0\ak\x2\x2\xB0\xB1\ap\x2\x2"+
		"\xB1\xB2\av\x2\x2\xB2:\x3\x2\x2\x2\xB3\xB5\a/\x2\x2\xB4\xB3\x3\x2\x2\x2"+
		"\xB4\xB5\x3\x2\x2\x2\xB5\xB7\x3\x2\x2\x2\xB6\xB8\t\x2\x2\x2\xB7\xB6\x3"+
		"\x2\x2\x2\xB8\xB9\x3\x2\x2\x2\xB9\xB7\x3\x2\x2\x2\xB9\xBA\x3\x2\x2\x2"+
		"\xBA<\x3\x2\x2\x2\xBB\xBD\t\x2\x2\x2\xBC\xBB\x3\x2\x2\x2\xBD\xBE\x3\x2"+
		"\x2\x2\xBE\xBC\x3\x2\x2\x2\xBE\xBF\x3\x2\x2\x2\xBF>\x3\x2\x2\x2\xC0\xC1"+
		"\t\x2\x2\x2\xC1\xC2\t\x2\x2\x2\xC2@\x3\x2\x2\x2\xC3\xC4\t\x2\x2\x2\xC4"+
		"\xC5\t\x2\x2\x2\xC5\x42\x3\x2\x2\x2\xC6\xC8\t\x3\x2\x2\xC7\xC6\x3\x2\x2"+
		"\x2\xC8\xC9\x3\x2\x2\x2\xC9\xC7\x3\x2\x2\x2\xC9\xCA\x3\x2\x2\x2\xCA\x44"+
		"\x3\x2\x2\x2\xCB\xCF\a$\x2\x2\xCC\xCE\v\x2\x2\x2\xCD\xCC\x3\x2\x2\x2\xCE"+
		"\xD1\x3\x2\x2\x2\xCF\xD0\x3\x2\x2\x2\xCF\xCD\x3\x2\x2\x2\xD0\xD2\x3\x2"+
		"\x2\x2\xD1\xCF\x3\x2\x2\x2\xD2\xD3\a$\x2\x2\xD3\x46\x3\x2\x2\x2\xD4\xD5"+
		"\t\x4\x2\x2\xD5\xD6\x3\x2\x2\x2\xD6\xD7\b$\x2\x2\xD7H\x3\x2\x2\x2\xD8"+
		"\xD9\a\x31\x2\x2\xD9\xDA\a,\x2\x2\xDA\xDE\x3\x2\x2\x2\xDB\xDD\v\x2\x2"+
		"\x2\xDC\xDB\x3\x2\x2\x2\xDD\xE0\x3\x2\x2\x2\xDE\xDF\x3\x2\x2\x2\xDE\xDC"+
		"\x3\x2\x2\x2\xDF\xE1\x3\x2\x2\x2\xE0\xDE\x3\x2\x2\x2\xE1\xE2\a,\x2\x2"+
		"\xE2\xE3\a\x31\x2\x2\xE3\xE4\x3\x2\x2\x2\xE4\xE5\b%\x2\x2\xE5J\x3\x2\x2"+
		"\x2\xE6\xE7\a/\x2\x2\xE7\xE8\a/\x2\x2\xE8\xEC\x3\x2\x2\x2\xE9\xEB\n\x5"+
		"\x2\x2\xEA\xE9\x3\x2\x2\x2\xEB\xEE\x3\x2\x2\x2\xEC\xEA\x3\x2\x2\x2\xEC"+
		"\xED\x3\x2\x2\x2\xED\xEF\x3\x2\x2\x2\xEE\xEC\x3\x2\x2\x2\xEF\xF0\b&\x2"+
		"\x2\xF0L\x3\x2\x2\x2\n\x2\xB4\xB9\xBE\xC9\xCF\xDE\xEC\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Grammar
