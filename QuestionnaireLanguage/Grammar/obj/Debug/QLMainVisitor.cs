//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Jonatan\Desktop\Backup\QuestionnaireLanguage\Grammar\QLMain.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Grammar {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="QLMainParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IQLMainVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.date"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDate([NotNull] QLMainParser.DateContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormObject([NotNull] QLMainParser.FormObjectContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Or</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOr([NotNull] QLMainParser.OrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ArithmeticNum</c>
	/// labeled alternative in <see cref="QLMainParser.arithmetic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArithmeticNum([NotNull] QLMainParser.ArithmeticNumContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.conditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditional([NotNull] QLMainParser.ConditionalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool([NotNull] QLMainParser.BoolContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] QLMainParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.year"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitYear([NotNull] QLMainParser.YearContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ArithmeticId</c>
	/// labeled alternative in <see cref="QLMainParser.arithmetic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArithmeticId([NotNull] QLMainParser.ArithmeticIdContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] QLMainParser.TypeNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolValue</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolValue([NotNull] QLMainParser.BoolValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PriorityArithmetic</c>
	/// labeled alternative in <see cref="QLMainParser.arithmetic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPriorityArithmetic([NotNull] QLMainParser.PriorityArithmeticContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumInt</c>
	/// labeled alternative in <see cref="QLMainParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumInt([NotNull] QLMainParser.NumIntContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.keyValuePairs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyValuePairs([NotNull] QLMainParser.KeyValuePairsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumValue</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumValue([NotNull] QLMainParser.NumValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DateValue</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDateValue([NotNull] QLMainParser.DateValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionComparison</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionComparison([NotNull] QLMainParser.ExpressionComparisonContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] QLMainParser.IdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Equality</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquality([NotNull] QLMainParser.EqualityContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DivMul</c>
	/// labeled alternative in <see cref="QLMainParser.arithmetic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDivMul([NotNull] QLMainParser.DivMulContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>StringValue</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringValue([NotNull] QLMainParser.StringValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] QLMainParser.ValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.day"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDay([NotNull] QLMainParser.DayContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKey([NotNull] QLMainParser.KeyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionId</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionId([NotNull] QLMainParser.ExpressionIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SubAdd</c>
	/// labeled alternative in <see cref="QLMainParser.arithmetic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubAdd([NotNull] QLMainParser.SubAddContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.question"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuestion([NotNull] QLMainParser.QuestionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PriorityExpression</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPriorityExpression([NotNull] QLMainParser.PriorityExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PriorityComparison</c>
	/// labeled alternative in <see cref="QLMainParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPriorityComparison([NotNull] QLMainParser.PriorityComparisonContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ListValue</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListValue([NotNull] QLMainParser.ListValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumDecimal</c>
	/// labeled alternative in <see cref="QLMainParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumDecimal([NotNull] QLMainParser.NumDecimalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] QLMainParser.ListContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] QLMainParser.IntContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ArithmeticComparison</c>
	/// labeled alternative in <see cref="QLMainParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArithmeticComparison([NotNull] QLMainParser.ArithmeticComparisonContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.keyValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyValuePair([NotNull] QLMainParser.KeyValuePairContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.primitiveTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveTypeName([NotNull] QLMainParser.PrimitiveTypeNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForm([NotNull] QLMainParser.FormContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.month"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMonth([NotNull] QLMainParser.MonthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.money"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMoney([NotNull] QLMainParser.MoneyContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>And</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnd([NotNull] QLMainParser.AndContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormSection([NotNull] QLMainParser.FormSectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>Negate</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegate([NotNull] QLMainParser.NegateContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.genericTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericTypeName([NotNull] QLMainParser.GenericTypeNameContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumMoney</c>
	/// labeled alternative in <see cref="QLMainParser.num"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumMoney([NotNull] QLMainParser.NumMoneyContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.decimal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecimal([NotNull] QLMainParser.DecimalContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionType</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionType([NotNull] QLMainParser.ExpressionTypeContext context);
}
} // namespace Grammar
