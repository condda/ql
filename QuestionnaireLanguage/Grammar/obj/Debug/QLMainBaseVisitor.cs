//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Daniel\Desktop\Backup\QuestionnaireLanguage\Grammar\QLMain.g4 by ANTLR 4.3

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
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IQLMainVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class QLMainBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IQLMainVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.BoolType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolType([NotNull] QLMainParser.BoolTypeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formObject"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormObject([NotNull] QLMainParser.FormObjectContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.Or"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOr([NotNull] QLMainParser.OrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.conditional"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConditional([NotNull] QLMainParser.ConditionalContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.@string"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitString([NotNull] QLMainParser.StringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.computed"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComputed([NotNull] QLMainParser.ComputedContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.StringType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringType([NotNull] QLMainParser.StringTypeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.TrueBool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTrueBool([NotNull] QLMainParser.TrueBoolContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.BoolValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolValue([NotNull] QLMainParser.BoolValueContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.ComputationValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComputationValue([NotNull] QLMainParser.ComputationValueContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.PriorityArithmetic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPriorityArithmetic([NotNull] QLMainParser.PriorityArithmeticContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.IntType"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntType([NotNull] QLMainParser.IntTypeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.BoolExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolExpression([NotNull] QLMainParser.BoolExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.FalseBool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFalseBool([NotNull] QLMainParser.FalseBoolContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.ComputationExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComputationExpression([NotNull] QLMainParser.ComputationExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.id"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitId([NotNull] QLMainParser.IdContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.Equality"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEquality([NotNull] QLMainParser.EqualityContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.DivMul"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDivMul([NotNull] QLMainParser.DivMulContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.StringValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringValue([NotNull] QLMainParser.StringValueContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.IntValue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntValue([NotNull] QLMainParser.IntValueContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.IntArithmetic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntArithmetic([NotNull] QLMainParser.IntArithmeticContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.ComputationArithmetic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComputationArithmetic([NotNull] QLMainParser.ComputationArithmeticContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.SubAdd"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubAdd([NotNull] QLMainParser.SubAddContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.question"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuestion([NotNull] QLMainParser.QuestionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.PriorityExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPriorityExpression([NotNull] QLMainParser.PriorityExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.PriorityComparison"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPriorityComparison([NotNull] QLMainParser.PriorityComparisonContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.label"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLabel([NotNull] QLMainParser.LabelContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.@int"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInt([NotNull] QLMainParser.IntContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.ComputationId"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComputationId([NotNull] QLMainParser.ComputationIdContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.ComparisonExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComparisonExpression([NotNull] QLMainParser.ComparisonExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.form"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitForm([NotNull] QLMainParser.FormContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.And"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAnd([NotNull] QLMainParser.AndContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.IdArithmetic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdArithmetic([NotNull] QLMainParser.IdArithmeticContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.IdExpression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIdExpression([NotNull] QLMainParser.IdExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formSection"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFormSection([NotNull] QLMainParser.FormSectionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.Negate"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNegate([NotNull] QLMainParser.NegateContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.RelationalComparison"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelationalComparison([NotNull] QLMainParser.RelationalComparisonContext context) { return VisitChildren(context); }
}
} // namespace Grammar
