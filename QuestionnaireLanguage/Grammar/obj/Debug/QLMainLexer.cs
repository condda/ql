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
		T__18=1, T__17=2, T__16=3, T__15=4, T__14=5, T__13=6, T__12=7, T__11=8, 
		T__10=9, T__9=10, T__8=11, T__7=12, T__6=13, T__5=14, T__4=15, T__3=16, 
		T__2=17, T__1=18, T__0=19, GT=20, LT=21, EQ=22, NEQ=23, GET=24, LET=25, 
		AND=26, OR=27, NOT=28, MUL=29, DIV=30, SUB=31, ADD=32, TRUE=33, FALSE=34, 
		INT=35, DECIMAL=36, MONEY=37, YEAR=38, MONTH=39, DAY=40, ALPHANUMERIC=41, 
		STRING=42, WS=43, BLOCK_COMMENT=44, LINE_COMMENT=45;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'", 
		"'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'", 
		"'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'", 
		"'\\u001F'", "' '", "'!'", "'\"'", "'#'", "'$'", "'%'", "'&'", "'''", 
		"'('", "')'", "'*'", "'+'", "','", "'-'"
	};
	public static readonly string[] ruleNames = {
		"T__18", "T__17", "T__16", "T__15", "T__14", "T__13", "T__12", "T__11", 
		"T__10", "T__9", "T__8", "T__7", "T__6", "T__5", "T__4", "T__3", "T__2", 
		"T__1", "T__0", "GT", "LT", "EQ", "NEQ", "GET", "LET", "AND", "OR", "NOT", 
		"MUL", "DIV", "SUB", "ADD", "TRUE", "FALSE", "INT", "DECIMAL", "MONEY", 
		"YEAR", "MONTH", "DAY", "ALPHANUMERIC", "STRING", "WS", "BLOCK_COMMENT", 
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2/\x139\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\v"+
		"\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3"+
		"\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14"+
		"\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3"+
		" \x3!\x3!\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3$\x5$\xE3"+
		"\n$\x3$\x6$\xE6\n$\r$\xE$\xE7\x3%\x5%\xEB\n%\x3%\x6%\xEE\n%\r%\xE%\xEF"+
		"\x3%\x3%\x6%\xF4\n%\r%\xE%\xF5\x3&\x5&\xF9\n&\x3&\x6&\xFC\n&\r&\xE&\xFD"+
		"\x3&\x3&\x3&\x3&\x3\'\x6\'\x105\n\'\r\'\xE\'\x106\x3(\x3(\x3(\x3)\x3)"+
		"\x3)\x3*\x6*\x110\n*\r*\xE*\x111\x3+\x3+\a+\x116\n+\f+\xE+\x119\v+\x3"+
		"+\x3+\x3,\x3,\x3,\x3,\x3-\x3-\x3-\x3-\a-\x125\n-\f-\xE-\x128\v-\x3-\x3"+
		"-\x3-\x3-\x3-\x3.\x3.\x3.\x3.\a.\x133\n.\f.\xE.\x136\v.\x3.\x3.\x4\x117"+
		"\x126\x2\x2/\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11"+
		"\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2"+
		"\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2"+
		",W\x2-Y\x2.[\x2/\x3\x2\x6\x3\x2\x32;\x5\x2\x32;\x43\\\x63|\x5\x2\f\f\xF"+
		"\xF\"\"\x4\x2\f\f\xF\xF\x144\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a"+
		"\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF"+
		"\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2"+
		"\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2"+
		"\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2"+
		"\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2"+
		"/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2"+
		"\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2"+
		"O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2"+
		"\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x3]\x3\x2\x2\x2\x5\x65\x3\x2\x2"+
		"\x2\aq\x3\x2\x2\x2\ts\x3\x2\x2\x2\vu\x3\x2\x2\x2\rw\x3\x2\x2\x2\xF}\x3"+
		"\x2\x2\x2\x11\x83\x3\x2\x2\x2\x13\x87\x3\x2\x2\x2\x15\x89\x3\x2\x2\x2"+
		"\x17\x8B\x3\x2\x2\x2\x19\x8D\x3\x2\x2\x2\x1B\x8F\x3\x2\x2\x2\x1D\x95\x3"+
		"\x2\x2\x2\x1F\x9A\x3\x2\x2\x2!\xA3\x3\x2\x2\x2#\xA8\x3\x2\x2\x2%\xAF\x3"+
		"\x2\x2\x2\'\xB1\x3\x2\x2\x2)\xB6\x3\x2\x2\x2+\xB8\x3\x2\x2\x2-\xBA\x3"+
		"\x2\x2\x2/\xBD\x3\x2\x2\x2\x31\xC0\x3\x2\x2\x2\x33\xC3\x3\x2\x2\x2\x35"+
		"\xC6\x3\x2\x2\x2\x37\xC9\x3\x2\x2\x2\x39\xCC\x3\x2\x2\x2;\xCE\x3\x2\x2"+
		"\x2=\xD0\x3\x2\x2\x2?\xD2\x3\x2\x2\x2\x41\xD4\x3\x2\x2\x2\x43\xD6\x3\x2"+
		"\x2\x2\x45\xDB\x3\x2\x2\x2G\xE2\x3\x2\x2\x2I\xEA\x3\x2\x2\x2K\xF8\x3\x2"+
		"\x2\x2M\x104\x3\x2\x2\x2O\x108\x3\x2\x2\x2Q\x10B\x3\x2\x2\x2S\x10F\x3"+
		"\x2\x2\x2U\x113\x3\x2\x2\x2W\x11C\x3\x2\x2\x2Y\x120\x3\x2\x2\x2[\x12E"+
		"\x3\x2\x2\x2]^\a\x66\x2\x2^_\ag\x2\x2_`\a\x65\x2\x2`\x61\ak\x2\x2\x61"+
		"\x62\ao\x2\x2\x62\x63\a\x63\x2\x2\x63\x64\an\x2\x2\x64\x4\x3\x2\x2\x2"+
		"\x65\x66\ag\x2\x2\x66g\ap\x2\x2gh\a\x63\x2\x2hi\a\x64\x2\x2ij\an\x2\x2"+
		"jk\ag\x2\x2kl\a\"\x2\x2lm\ay\x2\x2mn\aj\x2\x2no\ag\x2\x2op\ap\x2\x2p\x6"+
		"\x3\x2\x2\x2qr\a}\x2\x2r\b\x3\x2\x2\x2st\a?\x2\x2t\n\x3\x2\x2\x2uv\a\x7F"+
		"\x2\x2v\f\x3\x2\x2\x2wx\an\x2\x2xy\ak\x2\x2yz\au\x2\x2z{\av\x2\x2{|\a"+
		"]\x2\x2|\xE\x3\x2\x2\x2}~\ao\x2\x2~\x7F\aq\x2\x2\x7F\x80\ap\x2\x2\x80"+
		"\x81\ag\x2\x2\x81\x82\a{\x2\x2\x82\x10\x3\x2\x2\x2\x83\x84\ak\x2\x2\x84"+
		"\x85\ap\x2\x2\x85\x86\av\x2\x2\x86\x12\x3\x2\x2\x2\x87\x88\a*\x2\x2\x88"+
		"\x14\x3\x2\x2\x2\x89\x8A\a.\x2\x2\x8A\x16\x3\x2\x2\x2\x8B\x8C\a]\x2\x2"+
		"\x8C\x18\x3\x2\x2\x2\x8D\x8E\a_\x2\x2\x8E\x1A\x3\x2\x2\x2\x8F\x90\a\x66"+
		"\x2\x2\x90\x91\a\x63\x2\x2\x91\x92\av\x2\x2\x92\x93\ag\x2\x2\x93\x94\a"+
		"*\x2\x2\x94\x1C\x3\x2\x2\x2\x95\x96\a\x64\x2\x2\x96\x97\aq\x2\x2\x97\x98"+
		"\aq\x2\x2\x98\x99\an\x2\x2\x99\x1E\x3\x2\x2\x2\x9A\x9B\as\x2\x2\x9B\x9C"+
		"\aw\x2\x2\x9C\x9D\ag\x2\x2\x9D\x9E\au\x2\x2\x9E\x9F\av\x2\x2\x9F\xA0\a"+
		"k\x2\x2\xA0\xA1\aq\x2\x2\xA1\xA2\ap\x2\x2\xA2 \x3\x2\x2\x2\xA3\xA4\a\x66"+
		"\x2\x2\xA4\xA5\a\x63\x2\x2\xA5\xA6\av\x2\x2\xA6\xA7\ag\x2\x2\xA7\"\x3"+
		"\x2\x2\x2\xA8\xA9\au\x2\x2\xA9\xAA\av\x2\x2\xAA\xAB\at\x2\x2\xAB\xAC\a"+
		"k\x2\x2\xAC\xAD\ap\x2\x2\xAD\xAE\ai\x2\x2\xAE$\x3\x2\x2\x2\xAF\xB0\a+"+
		"\x2\x2\xB0&\x3\x2\x2\x2\xB1\xB2\ah\x2\x2\xB2\xB3\aq\x2\x2\xB3\xB4\at\x2"+
		"\x2\xB4\xB5\ao\x2\x2\xB5(\x3\x2\x2\x2\xB6\xB7\a@\x2\x2\xB7*\x3\x2\x2\x2"+
		"\xB8\xB9\a>\x2\x2\xB9,\x3\x2\x2\x2\xBA\xBB\a?\x2\x2\xBB\xBC\a?\x2\x2\xBC"+
		".\x3\x2\x2\x2\xBD\xBE\a#\x2\x2\xBE\xBF\a?\x2\x2\xBF\x30\x3\x2\x2\x2\xC0"+
		"\xC1\a@\x2\x2\xC1\xC2\a?\x2\x2\xC2\x32\x3\x2\x2\x2\xC3\xC4\a>\x2\x2\xC4"+
		"\xC5\a?\x2\x2\xC5\x34\x3\x2\x2\x2\xC6\xC7\a(\x2\x2\xC7\xC8\a(\x2\x2\xC8"+
		"\x36\x3\x2\x2\x2\xC9\xCA\a~\x2\x2\xCA\xCB\a~\x2\x2\xCB\x38\x3\x2\x2\x2"+
		"\xCC\xCD\a#\x2\x2\xCD:\x3\x2\x2\x2\xCE\xCF\a,\x2\x2\xCF<\x3\x2\x2\x2\xD0"+
		"\xD1\a\x31\x2\x2\xD1>\x3\x2\x2\x2\xD2\xD3\a/\x2\x2\xD3@\x3\x2\x2\x2\xD4"+
		"\xD5\a-\x2\x2\xD5\x42\x3\x2\x2\x2\xD6\xD7\aV\x2\x2\xD7\xD8\at\x2\x2\xD8"+
		"\xD9\aw\x2\x2\xD9\xDA\ag\x2\x2\xDA\x44\x3\x2\x2\x2\xDB\xDC\aH\x2\x2\xDC"+
		"\xDD\a\x63\x2\x2\xDD\xDE\an\x2\x2\xDE\xDF\au\x2\x2\xDF\xE0\ag\x2\x2\xE0"+
		"\x46\x3\x2\x2\x2\xE1\xE3\a/\x2\x2\xE2\xE1\x3\x2\x2\x2\xE2\xE3\x3\x2\x2"+
		"\x2\xE3\xE5\x3\x2\x2\x2\xE4\xE6\t\x2\x2\x2\xE5\xE4\x3\x2\x2\x2\xE6\xE7"+
		"\x3\x2\x2\x2\xE7\xE5\x3\x2\x2\x2\xE7\xE8\x3\x2\x2\x2\xE8H\x3\x2\x2\x2"+
		"\xE9\xEB\a/\x2\x2\xEA\xE9\x3\x2\x2\x2\xEA\xEB\x3\x2\x2\x2\xEB\xED\x3\x2"+
		"\x2\x2\xEC\xEE\t\x2\x2\x2\xED\xEC\x3\x2\x2\x2\xEE\xEF\x3\x2\x2\x2\xEF"+
		"\xED\x3\x2\x2\x2\xEF\xF0\x3\x2\x2\x2\xF0\xF1\x3\x2\x2\x2\xF1\xF3\a\x30"+
		"\x2\x2\xF2\xF4\t\x2\x2\x2\xF3\xF2\x3\x2\x2\x2\xF4\xF5\x3\x2\x2\x2\xF5"+
		"\xF3\x3\x2\x2\x2\xF5\xF6\x3\x2\x2\x2\xF6J\x3\x2\x2\x2\xF7\xF9\a/\x2\x2"+
		"\xF8\xF7\x3\x2\x2\x2\xF8\xF9\x3\x2\x2\x2\xF9\xFB\x3\x2\x2\x2\xFA\xFC\t"+
		"\x2\x2\x2\xFB\xFA\x3\x2\x2\x2\xFC\xFD\x3\x2\x2\x2\xFD\xFB\x3\x2\x2\x2"+
		"\xFD\xFE\x3\x2\x2\x2\xFE\xFF\x3\x2\x2\x2\xFF\x100\a\x30\x2\x2\x100\x101"+
		"\t\x2\x2\x2\x101\x102\t\x2\x2\x2\x102L\x3\x2\x2\x2\x103\x105\t\x2\x2\x2"+
		"\x104\x103\x3\x2\x2\x2\x105\x106\x3\x2\x2\x2\x106\x104\x3\x2\x2\x2\x106"+
		"\x107\x3\x2\x2\x2\x107N\x3\x2\x2\x2\x108\x109\t\x2\x2\x2\x109\x10A\t\x2"+
		"\x2\x2\x10AP\x3\x2\x2\x2\x10B\x10C\t\x2\x2\x2\x10C\x10D\t\x2\x2\x2\x10D"+
		"R\x3\x2\x2\x2\x10E\x110\t\x3\x2\x2\x10F\x10E\x3\x2\x2\x2\x110\x111\x3"+
		"\x2\x2\x2\x111\x10F\x3\x2\x2\x2\x111\x112\x3\x2\x2\x2\x112T\x3\x2\x2\x2"+
		"\x113\x117\a$\x2\x2\x114\x116\v\x2\x2\x2\x115\x114\x3\x2\x2\x2\x116\x119"+
		"\x3\x2\x2\x2\x117\x118\x3\x2\x2\x2\x117\x115\x3\x2\x2\x2\x118\x11A\x3"+
		"\x2\x2\x2\x119\x117\x3\x2\x2\x2\x11A\x11B\a$\x2\x2\x11BV\x3\x2\x2\x2\x11C"+
		"\x11D\t\x4\x2\x2\x11D\x11E\x3\x2\x2\x2\x11E\x11F\b,\x2\x2\x11FX\x3\x2"+
		"\x2\x2\x120\x121\a\x31\x2\x2\x121\x122\a,\x2\x2\x122\x126\x3\x2\x2\x2"+
		"\x123\x125\v\x2\x2\x2\x124\x123\x3\x2\x2\x2\x125\x128\x3\x2\x2\x2\x126"+
		"\x127\x3\x2\x2\x2\x126\x124\x3\x2\x2\x2\x127\x129\x3\x2\x2\x2\x128\x126"+
		"\x3\x2\x2\x2\x129\x12A\a,\x2\x2\x12A\x12B\a\x31\x2\x2\x12B\x12C\x3\x2"+
		"\x2\x2\x12C\x12D\b-\x2\x2\x12DZ\x3\x2\x2\x2\x12E\x12F\a/\x2\x2\x12F\x130"+
		"\a/\x2\x2\x130\x134\x3\x2\x2\x2\x131\x133\n\x5\x2\x2\x132\x131\x3\x2\x2"+
		"\x2\x133\x136\x3\x2\x2\x2\x134\x132\x3\x2\x2\x2\x134\x135\x3\x2\x2\x2"+
		"\x135\x137\x3\x2\x2\x2\x136\x134\x3\x2\x2\x2\x137\x138\b.\x2\x2\x138\\"+
		"\x3\x2\x2\x2\xF\x2\xE2\xE7\xEA\xEF\xF5\xF8\xFD\x106\x111\x117\x126\x134"+
		"\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Grammar
