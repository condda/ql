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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="QLMainParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IQLMainVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>BoolType</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolType([NotNull] QLMainParser.BoolTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ADD</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitADD([NotNull] QLMainParser.ADDContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formObject"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormObject([NotNull] QLMainParser.FormObjectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.conditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConditional([NotNull] QLMainParser.ConditionalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] QLMainParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.computed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComputed([NotNull] QLMainParser.ComputedContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>StringType</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringType([NotNull] QLMainParser.StringTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>TrueBool</c>
	/// labeled alternative in <see cref="QLMainParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrueBool([NotNull] QLMainParser.TrueBoolContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>BoolValue</c>
	/// labeled alternative in <see cref="QLMainParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolValue([NotNull] QLMainParser.BoolValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionNonAssociative</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionNonAssociative([NotNull] QLMainParser.ExpressionNonAssociativeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LT</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLT([NotNull] QLMainParser.LTContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AssociativeId</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssociativeId([NotNull] QLMainParser.AssociativeIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IntType</c>
	/// labeled alternative in <see cref="QLMainParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntType([NotNull] QLMainParser.IntTypeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionValue</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionValue([NotNull] QLMainParser.ExpressionValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>FalseBool</c>
	/// labeled alternative in <see cref="QLMainParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFalseBool([NotNull] QLMainParser.FalseBoolContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NonAssociativeId</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonAssociativeId([NotNull] QLMainParser.NonAssociativeIdContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] QLMainParser.IdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>StringValue</c>
	/// labeled alternative in <see cref="QLMainParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringValue([NotNull] QLMainParser.StringValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IntValue</c>
	/// labeled alternative in <see cref="QLMainParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntValue([NotNull] QLMainParser.IntValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NonAssociativePriority</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonAssociativePriority([NotNull] QLMainParser.NonAssociativePriorityContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionId</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionId([NotNull] QLMainParser.ExpressionIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AssociativeValue</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssociativeValue([NotNull] QLMainParser.AssociativeValueContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>SUB</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSUB([NotNull] QLMainParser.SUBContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>OR</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOR([NotNull] QLMainParser.ORContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.question"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuestion([NotNull] QLMainParser.QuestionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MUL</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMUL([NotNull] QLMainParser.MULContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AssociativeUnary</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssociativeUnary([NotNull] QLMainParser.AssociativeUnaryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NonAssociativeValue</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonAssociativeValue([NotNull] QLMainParser.NonAssociativeValueContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLabel([NotNull] QLMainParser.LabelContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>EQ</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEQ([NotNull] QLMainParser.EQContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>GT</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGT([NotNull] QLMainParser.GTContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] QLMainParser.IntContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>DIV</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDIV([NotNull] QLMainParser.DIVContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForm([NotNull] QLMainParser.FormContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AND</c>
	/// labeled alternative in <see cref="QLMainParser.associative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAND([NotNull] QLMainParser.ANDContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>GET</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGET([NotNull] QLMainParser.GETContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="QLMainParser.formSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormSection([NotNull] QLMainParser.FormSectionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionAssociative</c>
	/// labeled alternative in <see cref="QLMainParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionAssociative([NotNull] QLMainParser.ExpressionAssociativeContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LET</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLET([NotNull] QLMainParser.LETContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NEQ</c>
	/// labeled alternative in <see cref="QLMainParser.nonAssociative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNEQ([NotNull] QLMainParser.NEQContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NegateUnary</c>
	/// labeled alternative in <see cref="QLMainParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegateUnary([NotNull] QLMainParser.NegateUnaryContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>PriorityUnary</c>
	/// labeled alternative in <see cref="QLMainParser.unary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPriorityUnary([NotNull] QLMainParser.PriorityUnaryContext context);
}
} // namespace Grammar
