// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.GrammarTreeVisitor
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr4.Misc;
using Antlr4.Tool;
using Antlr4.Tool.Ast;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class GrammarTreeVisitor : TreeParser
  {
    internal static readonly string[] tokenNames;
    public const int EOF = -1;
    public const int ACTION = 4;
    public const int ACTION_CHAR_LITERAL = 5;
    public const int ACTION_ESC = 6;
    public const int ACTION_STRING_LITERAL = 7;
    public const int ARG_ACTION = 8;
    public const int ARG_OR_CHARSET = 9;
    public const int ASSIGN = 10;
    public const int AT = 11;
    public const int CATCH = 12;
    public const int CHANNELS = 13;
    public const int COLON = 14;
    public const int COLONCOLON = 15;
    public const int COMMA = 16;
    public const int COMMENT = 17;
    public const int DOC_COMMENT = 18;
    public const int DOLLAR = 19;
    public const int DOT = 20;
    public const int ERRCHAR = 21;
    public const int ESC_SEQ = 22;
    public const int FINALLY = 23;
    public const int FRAGMENT = 24;
    public const int GRAMMAR = 25;
    public const int GT = 26;
    public const int HEX_DIGIT = 27;
    public const int ID = 28;
    public const int IMPORT = 29;
    public const int INT = 30;
    public const int LEXER = 31;
    public const int LEXER_CHAR_SET = 32;
    public const int LOCALS = 33;
    public const int LPAREN = 34;
    public const int LT = 35;
    public const int MODE = 36;
    public const int NESTED_ACTION = 37;
    public const int NLCHARS = 38;
    public const int NOT = 39;
    public const int NameChar = 40;
    public const int NameStartChar = 41;
    public const int OPTIONS = 42;
    public const int OR = 43;
    public const int PARSER = 44;
    public const int PLUS = 45;
    public const int PLUS_ASSIGN = 46;
    public const int POUND = 47;
    public const int PRIVATE = 48;
    public const int PROTECTED = 49;
    public const int PUBLIC = 50;
    public const int QUESTION = 51;
    public const int RANGE = 52;
    public const int RARROW = 53;
    public const int RBRACE = 54;
    public const int RETURNS = 55;
    public const int RPAREN = 56;
    public const int RULE_REF = 57;
    public const int SEMI = 58;
    public const int SEMPRED = 59;
    public const int SRC = 60;
    public const int STAR = 61;
    public const int STRING_LITERAL = 62;
    public const int SYNPRED = 63;
    public const int THROWS = 64;
    public const int TOKENS_SPEC = 65;
    public const int TOKEN_REF = 66;
    public const int TREE_GRAMMAR = 67;
    public const int UNICODE_ESC = 68;
    public const int UnicodeBOM = 69;
    public const int WS = 70;
    public const int WSCHARS = 71;
    public const int WSNLCHARS = 72;
    public const int ALT = 73;
    public const int ALTLIST = 74;
    public const int ARG = 75;
    public const int ARGLIST = 76;
    public const int BLOCK = 77;
    public const int CHAR_RANGE = 78;
    public const int CLOSURE = 79;
    public const int COMBINED = 80;
    public const int ELEMENT_OPTIONS = 81;
    public const int EPSILON = 82;
    public const int INITACTION = 83;
    public const int LABEL = 84;
    public const int LEXER_ACTION_CALL = 85;
    public const int LEXER_ALT_ACTION = 86;
    public const int LIST = 87;
    public const int OPTIONAL = 88;
    public const int POSITIVE_CLOSURE = 89;
    public const int PREC_RULE = 90;
    public const int RESULT = 91;
    public const int RET = 92;
    public const int RULE = 93;
    public const int RULEACTIONS = 94;
    public const int RULEMODIFIERS = 95;
    public const int RULES = 96;
    public const int SET = 97;
    public const int TEMPLATE = 98;
    public const int WILDCARD = 99;
    public string grammarName;
    public GrammarAST currentRuleAST;
    public string currentModeName;
    public string currentRuleName;
    public GrammarAST currentOuterAltRoot;
    public int currentOuterAltNumber;
    public int rewriteEBNFLevel;
    private GrammarTreeVisitor.DFA38 dfa38;

    public GrammarTreeVisitor(ITreeNodeStream input):this(input, new RecognizerSharedState())
    {
      
    }

    public GrammarTreeVisitor(ITreeNodeStream input, RecognizerSharedState state):base(input, state)
    {
      this.currentModeName = LexerGrammar.DEFAULT_MODE_NAME;
      this.currentOuterAltNumber = 1;
      
    }

    public override string[] TokenNames
    {
      get
      {
        return GrammarTreeVisitor.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\GrammarTreeVisitor.g3";
      }
    }

    public GrammarTreeVisitor():this((ITreeNodeStream) null)
    {
      
    }

    public virtual ErrorManager GetErrorManager()
    {
      return (ErrorManager) null;
    }

    public virtual void VisitGrammar(GrammarAST t)
    {
      this.Visit(t, "grammarSpec");
    }

    public virtual void Visit(GrammarAST t, string ruleName)
    {
      this.SetTreeNodeStream((ITreeNodeStream) new CommonTreeNodeStream((ITreeAdaptor) new GrammarASTAdaptor(), (object) t));
      try
      {
        typeof (GrammarTreeVisitor).GetTypeInfo().GetDeclaredMethod(ruleName).Invoke((object) this, (object[]) null);
      }
      catch (Exception ex)
      {
        Exception e = ex;
        ErrorManager errorManager = this.GetErrorManager();
        if (e is TargetInvocationException)
          e = e.InnerException;
        if (errorManager == null)
        {
          Console.Error.WriteLine("can't find rule " + ruleName + " or tree structure error: " + t.ToStringTree());
          Console.Error.WriteLine(e.Message);
          Console.Error.WriteLine(e.StackTrace);
        }
        else
          errorManager.ToolError(ErrorType.INTERNAL_ERROR, e, new object[0]);
      }
    }

    public virtual void DiscoverGrammar(GrammarRootAST root, GrammarAST ID)
    {
    }

    public virtual void FinishPrequels(GrammarAST firstPrequel)
    {
    }

    public virtual void FinishGrammar(GrammarRootAST root, GrammarAST ID)
    {
    }

    public virtual void GrammarOption(GrammarAST ID, GrammarAST valueAST)
    {
    }

    public virtual void RuleOption(GrammarAST ID, GrammarAST valueAST)
    {
    }

    public virtual void BlockOption(GrammarAST ID, GrammarAST valueAST)
    {
    }

    public virtual void DefineToken(GrammarAST ID)
    {
    }

    public virtual void DefineChannel(GrammarAST ID)
    {
    }

    public virtual void GlobalNamedAction(GrammarAST scope, GrammarAST ID, ActionAST action)
    {
    }

    public virtual void ImportGrammar(GrammarAST label, GrammarAST ID)
    {
    }

    public virtual void ModeDef(GrammarAST m, GrammarAST ID)
    {
    }

    public virtual void DiscoverRules(GrammarAST rules)
    {
    }

    public virtual void FinishRules(GrammarAST rule)
    {
    }

    public virtual void DiscoverRule(
      RuleAST rule,
      GrammarAST ID,
      IList<GrammarAST> modifiers,
      ActionAST arg,
      ActionAST returns,
      GrammarAST thrws,
      GrammarAST options,
      ActionAST locals,
      IList<GrammarAST> actions,
      GrammarAST block)
    {
    }

    public virtual void FinishRule(RuleAST rule, GrammarAST ID, GrammarAST block)
    {
    }

    public virtual void DiscoverLexerRule(
      RuleAST rule,
      GrammarAST ID,
      IList<GrammarAST> modifiers,
      GrammarAST block)
    {
    }

    public virtual void FinishLexerRule(RuleAST rule, GrammarAST ID, GrammarAST block)
    {
    }

    public virtual void RuleCatch(GrammarAST arg, ActionAST action)
    {
    }

    public virtual void FinallyAction(ActionAST action)
    {
    }

    public virtual void DiscoverOuterAlt(AltAST alt)
    {
    }

    public virtual void FinishOuterAlt(AltAST alt)
    {
    }

    public virtual void DiscoverAlt(AltAST alt)
    {
    }

    public virtual void FinishAlt(AltAST alt)
    {
    }

    public virtual void RuleRef(GrammarAST @ref, ActionAST arg)
    {
    }

    public virtual void TokenRef(TerminalAST @ref)
    {
    }

    public virtual void ElementOption(GrammarASTWithOptions t, GrammarAST ID, GrammarAST valueAST)
    {
    }

    public virtual void StringRef(TerminalAST @ref)
    {
    }

    public virtual void WildcardRef(GrammarAST @ref)
    {
    }

    public virtual void ActionInAlt(ActionAST action)
    {
    }

    public virtual void SempredInAlt(PredAST pred)
    {
    }

    public virtual void Label(GrammarAST op, GrammarAST ID, GrammarAST element)
    {
    }

    public virtual void LexerCallCommand(int outerAltNumber, GrammarAST ID, GrammarAST arg)
    {
    }

    public virtual void LexerCommand(int outerAltNumber, GrammarAST ID)
    {
    }

    protected virtual void EnterGrammarSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitGrammarSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterPrequelConstructs(GrammarAST tree)
    {
    }

    protected virtual void ExitPrequelConstructs(GrammarAST tree)
    {
    }

    protected virtual void EnterPrequelConstruct(GrammarAST tree)
    {
    }

    protected virtual void ExitPrequelConstruct(GrammarAST tree)
    {
    }

    protected virtual void EnterOptionsSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitOptionsSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterOption(GrammarAST tree)
    {
    }

    protected virtual void ExitOption(GrammarAST tree)
    {
    }

    protected virtual void EnterOptionValue(GrammarAST tree)
    {
    }

    protected virtual void ExitOptionValue(GrammarAST tree)
    {
    }

    protected virtual void EnterDelegateGrammars(GrammarAST tree)
    {
    }

    protected virtual void ExitDelegateGrammars(GrammarAST tree)
    {
    }

    protected virtual void EnterDelegateGrammar(GrammarAST tree)
    {
    }

    protected virtual void ExitDelegateGrammar(GrammarAST tree)
    {
    }

    protected virtual void EnterTokensSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitTokensSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterTokenSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitTokenSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterChannelsSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitChannelsSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterChannelSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitChannelSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterAction(GrammarAST tree)
    {
    }

    protected virtual void ExitAction(GrammarAST tree)
    {
    }

    protected virtual void EnterRules(GrammarAST tree)
    {
    }

    protected virtual void ExitRules(GrammarAST tree)
    {
    }

    protected virtual void EnterMode(GrammarAST tree)
    {
    }

    protected virtual void ExitMode(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerRule(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerRule(GrammarAST tree)
    {
    }

    protected virtual void EnterRule(GrammarAST tree)
    {
    }

    protected virtual void ExitRule(GrammarAST tree)
    {
    }

    protected virtual void EnterExceptionGroup(GrammarAST tree)
    {
    }

    protected virtual void ExitExceptionGroup(GrammarAST tree)
    {
    }

    protected virtual void EnterExceptionHandler(GrammarAST tree)
    {
    }

    protected virtual void ExitExceptionHandler(GrammarAST tree)
    {
    }

    protected virtual void EnterFinallyClause(GrammarAST tree)
    {
    }

    protected virtual void ExitFinallyClause(GrammarAST tree)
    {
    }

    protected virtual void EnterLocals(GrammarAST tree)
    {
    }

    protected virtual void ExitLocals(GrammarAST tree)
    {
    }

    protected virtual void EnterRuleReturns(GrammarAST tree)
    {
    }

    protected virtual void ExitRuleReturns(GrammarAST tree)
    {
    }

    protected virtual void EnterThrowsSpec(GrammarAST tree)
    {
    }

    protected virtual void ExitThrowsSpec(GrammarAST tree)
    {
    }

    protected virtual void EnterRuleAction(GrammarAST tree)
    {
    }

    protected virtual void ExitRuleAction(GrammarAST tree)
    {
    }

    protected virtual void EnterRuleModifier(GrammarAST tree)
    {
    }

    protected virtual void ExitRuleModifier(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerRuleBlock(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerRuleBlock(GrammarAST tree)
    {
    }

    protected virtual void EnterRuleBlock(GrammarAST tree)
    {
    }

    protected virtual void ExitRuleBlock(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerOuterAlternative(AltAST tree)
    {
    }

    protected virtual void ExitLexerOuterAlternative(AltAST tree)
    {
    }

    protected virtual void EnterOuterAlternative(AltAST tree)
    {
    }

    protected virtual void ExitOuterAlternative(AltAST tree)
    {
    }

    protected virtual void EnterLexerAlternative(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerAlternative(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerElements(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerElements(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerElement(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerElement(GrammarAST tree)
    {
    }

    protected virtual void EnterLabeledLexerElement(GrammarAST tree)
    {
    }

    protected virtual void ExitLabeledLexerElement(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerBlock(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerBlock(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerAtom(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerAtom(GrammarAST tree)
    {
    }

    protected virtual void EnterActionElement(GrammarAST tree)
    {
    }

    protected virtual void ExitActionElement(GrammarAST tree)
    {
    }

    protected virtual void EnterAlternative(AltAST tree)
    {
    }

    protected virtual void ExitAlternative(AltAST tree)
    {
    }

    protected virtual void EnterLexerCommand(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerCommand(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerCommandExpr(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerCommandExpr(GrammarAST tree)
    {
    }

    protected virtual void EnterElement(GrammarAST tree)
    {
    }

    protected virtual void ExitElement(GrammarAST tree)
    {
    }

    protected virtual void EnterAstOperand(GrammarAST tree)
    {
    }

    protected virtual void ExitAstOperand(GrammarAST tree)
    {
    }

    protected virtual void EnterLabeledElement(GrammarAST tree)
    {
    }

    protected virtual void ExitLabeledElement(GrammarAST tree)
    {
    }

    protected virtual void EnterSubrule(GrammarAST tree)
    {
    }

    protected virtual void ExitSubrule(GrammarAST tree)
    {
    }

    protected virtual void EnterLexerSubrule(GrammarAST tree)
    {
    }

    protected virtual void ExitLexerSubrule(GrammarAST tree)
    {
    }

    protected virtual void EnterBlockSuffix(GrammarAST tree)
    {
    }

    protected virtual void ExitBlockSuffix(GrammarAST tree)
    {
    }

    protected virtual void EnterEbnfSuffix(GrammarAST tree)
    {
    }

    protected virtual void ExitEbnfSuffix(GrammarAST tree)
    {
    }

    protected virtual void EnterAtom(GrammarAST tree)
    {
    }

    protected virtual void ExitAtom(GrammarAST tree)
    {
    }

    protected virtual void EnterBlockSet(GrammarAST tree)
    {
    }

    protected virtual void ExitBlockSet(GrammarAST tree)
    {
    }

    protected virtual void EnterSetElement(GrammarAST tree)
    {
    }

    protected virtual void ExitSetElement(GrammarAST tree)
    {
    }

    protected virtual void EnterBlock(GrammarAST tree)
    {
    }

    protected virtual void ExitBlock(GrammarAST tree)
    {
    }

    protected virtual void EnterRuleref(GrammarAST tree)
    {
    }

    protected virtual void ExitRuleref(GrammarAST tree)
    {
    }

    protected virtual void EnterRange(GrammarAST tree)
    {
    }

    protected virtual void ExitRange(GrammarAST tree)
    {
    }

    protected virtual void EnterTerminal(GrammarAST tree)
    {
    }

    protected virtual void ExitTerminal(GrammarAST tree)
    {
    }

    protected virtual void EnterElementOptions(GrammarAST tree)
    {
    }

    protected virtual void ExitElementOptions(GrammarAST tree)
    {
    }

    protected virtual void EnterElementOption(GrammarAST tree)
    {
    }

    protected virtual void ExitElementOption(GrammarAST tree)
    {
    }

    public override void TraceIn(string ruleName, int ruleIndex)
    {
      Console.Error.WriteLine("enter " + ruleName + ": " + this.input.LT(1));
    }

    public override void TraceOut(string ruleName, int ruleIndex)
    {
      Console.Error.WriteLine("exit " + ruleName + ": " + this.input.LT(1));
    }

    [GrammarRule("grammarSpec")]
    private TreeRuleReturnScope<GrammarAST> grammarSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      this.EnterGrammarSpec(treeRuleReturnScope1.Start);
      try
      {
        try
        {
          GrammarAST root = (GrammarAST) this.Match((IIntStream) this.input, 25, GrammarTreeVisitor.Follow._GRAMMAR_in_grammarSpec90);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_grammarSpec92);
          this.grammarName = ID?.Text;
          this.DiscoverGrammar((GrammarRootAST) root, ID);
          this.PushFollow(GrammarTreeVisitor.Follow._prequelConstructs_in_grammarSpec111);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.prequelConstructs();
          this.PopFollow();
          this.FinishPrequels(((GrammarTreeVisitor.prequelConstructs_return) treeRuleReturnScope2)?.firstOne);
          this.PushFollow(GrammarTreeVisitor.Follow._rules_in_grammarSpec128);
          this.rules();
          this.PopFollow();
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 36)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._mode_in_grammarSpec130);
                this.mode();
                this.PopFollow();
              }
              else
                break;
            }
          }
          finally
          {
          }
          this.FinishGrammar((GrammarRootAST) root, ID);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitGrammarSpec(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("prequelConstructs")]
    private GrammarTreeVisitor.prequelConstructs_return prequelConstructs()
    {
      GrammarTreeVisitor.prequelConstructs_return constructsReturn = new GrammarTreeVisitor.prequelConstructs_return(this);
      constructsReturn.Start = (GrammarAST) this.input.LT(1);
      this.EnterPrequelConstructs(constructsReturn.Start);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 11:
              case 13:
              case 29:
              case 42:
              case 65:
                num1 = 1;
                break;
              case 96:
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 3, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          if (num1 != 1)
          {
            if (num1 == 2)
              ;
          }
          else
          {
            constructsReturn.firstOne = constructsReturn.Start;
            int num2 = 0;
            try
            {
              while (true)
              {
                int num3 = 2;
                try
                {
                  switch (this.input.LA(1))
                  {
                    case 11:
                    case 13:
                    case 29:
                    case 42:
                    case 65:
                      num3 = 1;
                      break;
                  }
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._prequelConstruct_in_prequelConstructs172);
                  this.prequelConstruct();
                  this.PopFollow();
                  ++num2;
                }
                else
                  break;
              }
              if (num2 < 1)
                throw new EarlyExitException(2, (IIntStream) this.input);
            }
            finally
            {
            }
          }
          this.ExitPrequelConstructs(constructsReturn.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return constructsReturn;
    }

    [GrammarRule("prequelConstruct")]
    private TreeRuleReturnScope<GrammarAST> prequelConstruct()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterPrequelConstructs(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 5;
          try
          {
            switch (this.input.LA(1))
            {
              case 11:
                num = 5;
                break;
              case 13:
                num = 4;
                break;
              case 29:
                num = 2;
                break;
              case 42:
                num = 1;
                break;
              case 65:
                num = 3;
                break;
              default:
                throw new NoViableAltException("", 4, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._optionsSpec_in_prequelConstruct199);
              this.optionsSpec();
              this.PopFollow();
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._delegateGrammars_in_prequelConstruct209);
              this.delegateGrammars();
              this.PopFollow();
              break;
            case 3:
              this.PushFollow(GrammarTreeVisitor.Follow._tokensSpec_in_prequelConstruct219);
              this.tokensSpec();
              this.PopFollow();
              break;
            case 4:
              this.PushFollow(GrammarTreeVisitor.Follow._channelsSpec_in_prequelConstruct229);
              this.channelsSpec();
              this.PopFollow();
              break;
            case 5:
              this.PushFollow(GrammarTreeVisitor.Follow._action_in_prequelConstruct239);
              this.action();
              this.PopFollow();
              break;
          }
          this.ExitPrequelConstructs(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("optionsSpec")]
    private TreeRuleReturnScope<GrammarAST> optionsSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterOptionsSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 42, GrammarTreeVisitor.Follow._OPTIONS_in_optionsSpec264);
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            try
            {
              while (true)
              {
                int num = 2;
                try
                {
                  if (this.input.LA(1) == 10)
                    num = 1;
                }
                finally
                {
                }
                if (num == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._option_in_optionsSpec266);
                  this.option();
                  this.PopFollow();
                }
                else
                  break;
              }
            }
            finally
            {
            }
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          this.ExitOptionsSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("option")]
    private TreeRuleReturnScope<GrammarAST> option()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      this.EnterOption(treeRuleReturnScope1.Start);
      bool flag1 = this.InContext("RULE ...");
      bool flag2 = this.InContext("BLOCK ...");
      try
      {
        try
        {
          grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_option300);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_option302);
          this.PushFollow(GrammarTreeVisitor.Follow._optionValue_in_option306);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.optionValue();
          this.PopFollow();
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (flag2)
            this.BlockOption(ID, treeRuleReturnScope2?.Start);
          else if (flag1)
            this.RuleOption(ID, treeRuleReturnScope2?.Start);
          else
            this.GrammarOption(ID, treeRuleReturnScope2?.Start);
          this.ExitOption(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("optionValue")]
    private GrammarTreeVisitor.optionValue_return optionValue()
    {
      GrammarTreeVisitor.optionValue_return optionValueReturn = new GrammarTreeVisitor.optionValue_return(this);
      optionValueReturn.Start = (GrammarAST) this.input.LT(1);
      this.EnterOptionValue(optionValueReturn.Start);
      optionValueReturn.v = optionValueReturn.Start.Token.Text;
      try
      {
        try
        {
          if (this.input.LA(1) != 28 && this.input.LA(1) != 30 && this.input.LA(1) != 62)
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.ExitOptionValue(optionValueReturn.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return optionValueReturn;
    }

    [GrammarRule("delegateGrammars")]
    private TreeRuleReturnScope<GrammarAST> delegateGrammars()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterDelegateGrammars(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 29, GrammarTreeVisitor.Follow._IMPORT_in_delegateGrammars394);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 10:
                  case 28:
                    num2 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._delegateGrammar_in_delegateGrammars396);
                this.delegateGrammar();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(6, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitDelegateGrammars(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("delegateGrammar")]
    private TreeRuleReturnScope<GrammarAST> delegateGrammar()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterDelegateGrammar(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 10:
                num = 1;
                break;
              case 28:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 7, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_delegateGrammar425);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST label = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_delegateGrammar429);
              GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_delegateGrammar433);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ImportGrammar(label, ID);
              break;
            case 2:
              this.ImportGrammar((GrammarAST) null, (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_delegateGrammar448));
              break;
          }
          this.ExitDelegateGrammar(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("tokensSpec")]
    private TreeRuleReturnScope<GrammarAST> tokensSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterTokensSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 65, GrammarTreeVisitor.Follow._TOKENS_SPEC_in_tokensSpec482);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                if (this.input.LA(1) == 28)
                  num2 = 1;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._tokenSpec_in_tokensSpec484);
                this.tokenSpec();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(8, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitTokensSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("tokenSpec")]
    private TreeRuleReturnScope<GrammarAST> tokenSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterTokenSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.DefineToken((GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_tokenSpec507));
          this.ExitTokenSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("channelsSpec")]
    private TreeRuleReturnScope<GrammarAST> channelsSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterChannelsSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 13, GrammarTreeVisitor.Follow._CHANNELS_in_channelsSpec537);
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            try
            {
              while (true)
              {
                int num = 2;
                try
                {
                  if (this.input.LA(1) == 28)
                    num = 1;
                }
                finally
                {
                }
                if (num == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._channelSpec_in_channelsSpec539);
                  this.channelSpec();
                  this.PopFollow();
                }
                else
                  break;
              }
            }
            finally
            {
            }
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          this.ExitChannelsSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("channelSpec")]
    private TreeRuleReturnScope<GrammarAST> channelSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterChannelSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.DefineChannel((GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_channelSpec562));
          this.ExitChannelSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("action")]
    private TreeRuleReturnScope<GrammarAST> action()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST scope = (GrammarAST) null;
      this.EnterAction(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 11, GrammarTreeVisitor.Follow._AT_in_action590);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 28)
              {
                if (this.input.LA(2) == 28)
                  num = 1;
              }
            }
            finally
            {
            }
            if (num == 1)
              scope = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_action594);
          }
          finally
          {
          }
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_action599);
          GrammarAST action = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_action601);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.GlobalNamedAction(scope, ID, (ActionAST) action);
          this.ExitAction(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("rules")]
    private TreeRuleReturnScope<GrammarAST> rules()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRules(treeRuleReturnScope.Start);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 96, GrammarTreeVisitor.Follow._RULES_in_rules629);
          this.DiscoverRules(grammarAst);
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            try
            {
              while (true)
              {
                int num = 3;
                try
                {
                  if (this.input.LA(1) == 93)
                  {
                    if (this.input.LA(2) == 2)
                    {
                      switch (this.input.LA(3))
                      {
                        case 57:
                          num = 1;
                          break;
                        case 66:
                          num = 2;
                          break;
                      }
                    }
                  }
                }
                finally
                {
                }
                switch (num)
                {
                  case 1:
                    this.PushFollow(GrammarTreeVisitor.Follow._rule_in_rules634);
                    this.rule();
                    this.PopFollow();
                    continue;
                  case 2:
                    this.PushFollow(GrammarTreeVisitor.Follow._lexerRule_in_rules636);
                    this.lexerRule();
                    this.PopFollow();
                    continue;
                  default:
                    goto label_14;
                }
              }
            }
            finally
            {
            }
label_14:
            this.FinishRules(grammarAst);
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          this.ExitRules(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("mode")]
    private TreeRuleReturnScope<GrammarAST> mode()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterMode(treeRuleReturnScope.Start);
      try
      {
        try
        {
          GrammarAST m = (GrammarAST) this.Match((IIntStream) this.input, 36, GrammarTreeVisitor.Follow._MODE_in_mode667);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_mode669);
          this.currentModeName = ID?.Text;
          this.ModeDef(m, ID);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 93)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._lexerRule_in_mode673);
                this.lexerRule();
                this.PopFollow();
              }
              else
                break;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitMode(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerRule")]
    private TreeRuleReturnScope<GrammarAST> lexerRule()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerRule(treeRuleReturnScope1.Start);
      IList<GrammarAST> modifiers = (IList<GrammarAST>) new List<GrammarAST>();
      this.currentOuterAltNumber = 0;
      try
      {
        try
        {
          GrammarAST rule = (GrammarAST) this.Match((IIntStream) this.input, 93, GrammarTreeVisitor.Follow._RULE_in_lexerRule699);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 66, GrammarTreeVisitor.Follow._TOKEN_REF_in_lexerRule701);
          this.currentRuleName = ID?.Text;
          this.currentRuleAST = rule;
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 95)
                num = 1;
            }
            finally
            {
            }
            if (num == 1)
            {
              this.Match((IIntStream) this.input, 95, GrammarTreeVisitor.Follow._RULEMODIFIERS_in_lexerRule713);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 24, GrammarTreeVisitor.Follow._FRAGMENT_in_lexerRule717);
              modifiers.Add(grammarAst);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
            }
          }
          finally
          {
          }
          this.DiscoverLexerRule((RuleAST) rule, ID, modifiers, (GrammarAST) this.input.LT(1));
          this.PushFollow(GrammarTreeVisitor.Follow._lexerRuleBlock_in_lexerRule742);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = this.lexerRuleBlock();
          this.PopFollow();
          this.FinishLexerRule((RuleAST) rule, ID, treeRuleReturnScope2?.Start);
          this.currentRuleName = (string) null;
          this.currentRuleAST = (GrammarAST) null;
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLexerRule(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("rule")]
    public TreeRuleReturnScope<GrammarAST> rule()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) null;
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope3 = (TreeRuleReturnScope<GrammarAST>) null;
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope4 = (TreeRuleReturnScope<GrammarAST>) null;
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope5 = (TreeRuleReturnScope<GrammarAST>) null;
      this.EnterRule(treeRuleReturnScope1.Start);
      IList<GrammarAST> modifiers = (IList<GrammarAST>) new List<GrammarAST>();
      IList<GrammarAST> actions = (IList<GrammarAST>) new List<GrammarAST>();
      this.currentOuterAltNumber = 0;
      try
      {
        try
        {
          GrammarAST rule = (GrammarAST) this.Match((IIntStream) this.input, 93, GrammarTreeVisitor.Follow._RULE_in_rule789);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 57, GrammarTreeVisitor.Follow._RULE_REF_in_rule791);
          this.currentRuleName = ID?.Text;
          this.currentRuleAST = rule;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 95)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.Match((IIntStream) this.input, 95, GrammarTreeVisitor.Follow._RULEMODIFIERS_in_rule800);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num2 = 0;
              try
              {
                while (true)
                {
                  int num3 = 2;
                  try
                  {
                    switch (this.input.LA(1))
                    {
                      case 24:
                      case 48:
                      case 49:
                      case 50:
                        num3 = 1;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  if (num3 == 1)
                  {
                    this.PushFollow(GrammarTreeVisitor.Follow._ruleModifier_in_rule805);
                    TreeRuleReturnScope<GrammarAST> treeRuleReturnScope6 = this.ruleModifier();
                    this.PopFollow();
                    modifiers.Add(treeRuleReturnScope6?.Start);
                    ++num2;
                  }
                  else
                    break;
                }
                if (num2 < 1)
                  throw new EarlyExitException(14, (IIntStream) this.input);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
            }
          }
          finally
          {
          }
          int num4 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 8)
                num4 = 1;
            }
            finally
            {
            }
            if (num4 == 1)
              grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 8, GrammarTreeVisitor.Follow._ARG_ACTION_in_rule816);
          }
          finally
          {
          }
          int num5 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 55)
                num5 = 1;
            }
            finally
            {
            }
            if (num5 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._ruleReturns_in_rule829);
              treeRuleReturnScope2 = this.ruleReturns();
              this.PopFollow();
            }
          }
          finally
          {
          }
          int num6 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 64)
                num6 = 1;
            }
            finally
            {
            }
            if (num6 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._throwsSpec_in_rule842);
              treeRuleReturnScope3 = this.throwsSpec();
              this.PopFollow();
            }
          }
          finally
          {
          }
          int num7 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 33)
                num7 = 1;
            }
            finally
            {
            }
            if (num7 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._locals_in_rule855);
              treeRuleReturnScope4 = this.locals();
              this.PopFollow();
            }
          }
          finally
          {
          }
          try
          {
            while (true)
            {
              int num8 = 3;
              try
              {
                switch (this.input.LA(1))
                {
                  case 11:
                    num8 = 2;
                    break;
                  case 42:
                    num8 = 1;
                    break;
                }
              }
              finally
              {
              }
              switch (num8)
              {
                case 1:
                  this.PushFollow(GrammarTreeVisitor.Follow._optionsSpec_in_rule870);
                  treeRuleReturnScope5 = this.optionsSpec();
                  this.PopFollow();
                  continue;
                case 2:
                  this.PushFollow(GrammarTreeVisitor.Follow._ruleAction_in_rule884);
                  TreeRuleReturnScope<GrammarAST> treeRuleReturnScope7 = this.ruleAction();
                  this.PopFollow();
                  actions.Add(treeRuleReturnScope7?.Start);
                  continue;
                default:
                  goto label_56;
              }
            }
          }
          finally
          {
          }
label_56:
          this.DiscoverRule((RuleAST) rule, ID, modifiers, (ActionAST) grammarAst, treeRuleReturnScope2?.Start != null ? (ActionAST) treeRuleReturnScope2?.Start.GetChild(0) : (ActionAST) null, treeRuleReturnScope3?.Start, treeRuleReturnScope5?.Start, treeRuleReturnScope4?.Start != null ? (ActionAST) treeRuleReturnScope4?.Start.GetChild(0) : (ActionAST) null, actions, (GrammarAST) this.input.LT(1));
          this.PushFollow(GrammarTreeVisitor.Follow._ruleBlock_in_rule915);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope8 = this.ruleBlock();
          this.PopFollow();
          this.PushFollow(GrammarTreeVisitor.Follow._exceptionGroup_in_rule917);
          this.exceptionGroup();
          this.PopFollow();
          this.FinishRule((RuleAST) rule, ID, treeRuleReturnScope8?.Start);
          this.currentRuleName = (string) null;
          this.currentRuleAST = (GrammarAST) null;
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitRule(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("exceptionGroup")]
    private TreeRuleReturnScope<GrammarAST> exceptionGroup()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterExceptionGroup(treeRuleReturnScope.Start);
      try
      {
        try
        {
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 12)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._exceptionHandler_in_exceptionGroup964);
                this.exceptionHandler();
                this.PopFollow();
              }
              else
                break;
            }
          }
          finally
          {
          }
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 23)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._finallyClause_in_exceptionGroup967);
              this.finallyClause();
              this.PopFollow();
            }
          }
          finally
          {
          }
          this.ExitExceptionGroup(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("exceptionHandler")]
    private TreeRuleReturnScope<GrammarAST> exceptionHandler()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterExceptionHandler(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 12, GrammarTreeVisitor.Follow._CATCH_in_exceptionHandler993);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 8, GrammarTreeVisitor.Follow._ARG_ACTION_in_exceptionHandler995);
          GrammarAST action = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_exceptionHandler997);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.RuleCatch(grammarAst, (ActionAST) action);
          this.ExitExceptionHandler(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("finallyClause")]
    private TreeRuleReturnScope<GrammarAST> finallyClause()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterFinallyClause(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 23, GrammarTreeVisitor.Follow._FINALLY_in_finallyClause1022);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST action = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_finallyClause1024);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.FinallyAction((ActionAST) action);
          this.ExitFinallyClause(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("locals")]
    private TreeRuleReturnScope<GrammarAST> locals()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLocals(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 33, GrammarTreeVisitor.Follow._LOCALS_in_locals1052);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          this.Match((IIntStream) this.input, 8, GrammarTreeVisitor.Follow._ARG_ACTION_in_locals1054);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLocals(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ruleReturns")]
    private TreeRuleReturnScope<GrammarAST> ruleReturns()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRuleReturns(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 55, GrammarTreeVisitor.Follow._RETURNS_in_ruleReturns1077);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          this.Match((IIntStream) this.input, 8, GrammarTreeVisitor.Follow._ARG_ACTION_in_ruleReturns1079);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitRuleReturns(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("throwsSpec")]
    private TreeRuleReturnScope<GrammarAST> throwsSpec()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterThrowsSpec(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 64, GrammarTreeVisitor.Follow._THROWS_in_throwsSpec1105);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                if (this.input.LA(1) == 28)
                  num2 = 1;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_throwsSpec1107);
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(23, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitThrowsSpec(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ruleAction")]
    private TreeRuleReturnScope<GrammarAST> ruleAction()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRuleAction(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 11, GrammarTreeVisitor.Follow._AT_in_ruleAction1134);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_ruleAction1136);
          this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_ruleAction1138);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitRuleAction(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ruleModifier")]
    private TreeRuleReturnScope<GrammarAST> ruleModifier()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRuleModifier(treeRuleReturnScope.Start);
      try
      {
        try
        {
          if (this.input.LA(1) != 24 && (this.input.LA(1) < 48 || this.input.LA(1) > 50))
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.ExitRuleModifier(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerRuleBlock")]
    private TreeRuleReturnScope<GrammarAST> lexerRuleBlock()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerRuleBlock(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, GrammarTreeVisitor.Follow._BLOCK_in_lexerRuleBlock1216);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 73:
                  case 86:
                    num2 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.currentOuterAltRoot = (GrammarAST) this.input.LT(1);
                ++this.currentOuterAltNumber;
                this.PushFollow(GrammarTreeVisitor.Follow._lexerOuterAlternative_in_lexerRuleBlock1235);
                this.lexerOuterAlternative();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(24, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLexerRuleBlock(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ruleBlock")]
    private TreeRuleReturnScope<GrammarAST> ruleBlock()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRuleBlock(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, GrammarTreeVisitor.Follow._BLOCK_in_ruleBlock1280);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                if (this.input.LA(1) == 73)
                  num2 = 1;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.currentOuterAltRoot = (GrammarAST) this.input.LT(1);
                ++this.currentOuterAltNumber;
                this.PushFollow(GrammarTreeVisitor.Follow._outerAlternative_in_ruleBlock1299);
                this.outerAlternative();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(25, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitRuleBlock(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerOuterAlternative")]
    private TreeRuleReturnScope<GrammarAST> lexerOuterAlternative()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerOuterAlternative((AltAST) treeRuleReturnScope.Start);
      this.DiscoverOuterAlt((AltAST) treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.PushFollow(GrammarTreeVisitor.Follow._lexerAlternative_in_lexerOuterAlternative1339);
          this.lexerAlternative();
          this.PopFollow();
          this.FinishOuterAlt((AltAST) treeRuleReturnScope.Start);
          this.ExitLexerOuterAlternative((AltAST) treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("outerAlternative")]
    public TreeRuleReturnScope<GrammarAST> outerAlternative()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterOuterAlternative((AltAST) treeRuleReturnScope.Start);
      this.DiscoverOuterAlt((AltAST) treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.PushFollow(GrammarTreeVisitor.Follow._alternative_in_outerAlternative1362);
          this.alternative();
          this.PopFollow();
          this.FinishOuterAlt((AltAST) treeRuleReturnScope.Start);
          this.ExitOuterAlternative((AltAST) treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerAlternative")]
    private TreeRuleReturnScope<GrammarAST> lexerAlternative()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerAlternative(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 73:
                num1 = 2;
                break;
              case 86:
                num1 = 1;
                break;
              default:
                throw new NoViableAltException("", 27, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 86, GrammarTreeVisitor.Follow._LEXER_ALT_ACTION_in_lexerAlternative1384);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._lexerElements_in_lexerAlternative1386);
              this.lexerElements();
              this.PopFollow();
              int num2 = 0;
              try
              {
                while (true)
                {
                  int num3 = 2;
                  try
                  {
                    switch (this.input.LA(1))
                    {
                      case 28:
                      case 85:
                        num3 = 1;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  if (num3 == 1)
                  {
                    this.PushFollow(GrammarTreeVisitor.Follow._lexerCommand_in_lexerAlternative1388);
                    this.lexerCommand();
                    this.PopFollow();
                    ++num2;
                  }
                  else
                    break;
                }
                if (num2 < 1)
                  throw new EarlyExitException(26, (IIntStream) this.input);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._lexerElements_in_lexerAlternative1400);
              this.lexerElements();
              this.PopFollow();
              break;
          }
          this.ExitLexerAlternative(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerElements")]
    private TreeRuleReturnScope<GrammarAST> lexerElements()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerElements(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 73, GrammarTreeVisitor.Follow._ALT_in_lexerElements1428);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                int num3 = this.input.LA(1);
                if (num3 != 4 && num3 != 10 && num3 != 32 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && num3 != 82 && (num3 < 88 || num3 > 89) && num3 != 97)
                {
                  if (num3 != 99)
                    goto label_7;
                }
                num2 = 1;
              }
              finally
              {
              }
label_7:
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._lexerElement_in_lexerElements1430);
                this.lexerElement();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(28, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLexerElements(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerElement")]
    private TreeRuleReturnScope<GrammarAST> lexerElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerElement(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 8;
          try
          {
            int num2 = this.input.LA(1);
            if (num2 <= 59)
            {
              if (num2 <= 39)
              {
                if (num2 <= 10)
                {
                  if (num2 != 4)
                  {
                    if (num2 != 10)
                      goto label_35;
                  }
                  else
                  {
                    int num3 = this.input.LA(2);
                    if (num3 == 2)
                    {
                      num1 = 6;
                      goto label_37;
                    }
                    else
                    {
                      if ((num3 < 3 || num3 > 4) && num3 != 10 && num3 != 32 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && num3 != 82 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                        throw new NoViableAltException("", 29, 4, (IIntStream) this.input, 2);
                      num1 = 4;
                      goto label_37;
                    }
                  }
                }
                else if (num2 == 32 || num2 == 39)
                  goto label_22;
                else
                  goto label_35;
              }
              else if (num2 <= 52)
              {
                if (num2 != 46)
                {
                  if (num2 == 52)
                    goto label_22;
                  else
                    goto label_35;
                }
              }
              else if (num2 != 57)
              {
                if (num2 == 59)
                {
                  int num4 = this.input.LA(2);
                  if (num4 == 2)
                  {
                    num1 = 7;
                    goto label_37;
                  }
                  else
                  {
                    if ((num4 < 3 || num4 > 4) && num4 != 10 && num4 != 32 && num4 != 39 && num4 != 46 && num4 != 52 && num4 != 57 && num4 != 59 && num4 != 62 && num4 != 66 && num4 != 77 && num4 != 79 && num4 != 82 && (num4 < 88 || num4 > 89) && num4 != 97 && num4 != 99)
                      throw new NoViableAltException("", 29, 5, (IIntStream) this.input, 2);
                    num1 = 5;
                    goto label_37;
                  }
                }
                else
                  goto label_35;
              }
              else
                goto label_22;
              num1 = 1;
              goto label_37;
            }
            else
            {
              if (num2 <= 79)
              {
                if (num2 <= 66)
                {
                  if (num2 == 62 || num2 == 66)
                    goto label_22;
                  else
                    goto label_35;
                }
                else if (num2 != 77 && num2 != 79)
                  goto label_35;
              }
              else if (num2 <= 89)
              {
                if (num2 != 82)
                {
                  if ((uint) (num2 - 88) > 1U)
                    goto label_35;
                }
                else
                {
                  num1 = 8;
                  goto label_37;
                }
              }
              else if (num2 == 97 || num2 == 99)
                goto label_22;
              else
                goto label_35;
              num1 = 3;
              goto label_37;
            }
label_22:
            num1 = 2;
            goto label_37;
label_35:
            throw new NoViableAltException("", 29, 0, (IIntStream) this.input, 1);
          }
          finally
          {
          }
label_37:
          switch (num1)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._labeledLexerElement_in_lexerElement1456);
              this.labeledLexerElement();
              this.PopFollow();
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._lexerAtom_in_lexerElement1461);
              this.lexerAtom();
              this.PopFollow();
              break;
            case 3:
              this.PushFollow(GrammarTreeVisitor.Follow._lexerSubrule_in_lexerElement1466);
              this.lexerSubrule();
              this.PopFollow();
              break;
            case 4:
              this.ActionInAlt((ActionAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_lexerElement1473));
              break;
            case 5:
              this.SempredInAlt((PredAST) this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_lexerElement1487));
              break;
            case 6:
              GrammarAST action = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_lexerElement1502);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_lexerElement1504);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ActionInAlt((ActionAST) action);
              break;
            case 7:
              GrammarAST pred = (GrammarAST) this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_lexerElement1515);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_lexerElement1517);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.SempredInAlt((PredAST) pred);
              break;
            case 8:
              this.Match((IIntStream) this.input, 82, GrammarTreeVisitor.Follow._EPSILON_in_lexerElement1525);
              break;
          }
          this.ExitLexerElement(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("labeledLexerElement")]
    private TreeRuleReturnScope<GrammarAST> labeledLexerElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLabeledLexerElement(treeRuleReturnScope.Start);
      try
      {
        try
        {
          if (this.input.LA(1) != 10 && this.input.LA(1) != 46)
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_labeledLexerElement1558);
          int num = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 32:
                case 39:
                case 52:
                case 57:
                case 62:
                case 66:
                case 97:
                case 99:
                  num = 1;
                  break;
                case 77:
                  num = 2;
                  break;
                default:
                  throw new NoViableAltException("", 30, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num)
            {
              case 1:
                this.PushFollow(GrammarTreeVisitor.Follow._lexerAtom_in_labeledLexerElement1561);
                this.lexerAtom();
                this.PopFollow();
                break;
              case 2:
                this.PushFollow(GrammarTreeVisitor.Follow._block_in_labeledLexerElement1563);
                this.block();
                this.PopFollow();
                break;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLabeledLexerElement(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerBlock")]
    private TreeRuleReturnScope<GrammarAST> lexerBlock()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerBlock(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, GrammarTreeVisitor.Follow._BLOCK_in_lexerBlock1588);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 42)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._optionsSpec_in_lexerBlock1590);
              this.optionsSpec();
              this.PopFollow();
            }
          }
          finally
          {
          }
          int num2 = 0;
          try
          {
            while (true)
            {
              int num3 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 73:
                  case 86:
                    num3 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num3 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._lexerAlternative_in_lexerBlock1593);
                this.lexerAlternative();
                this.PopFollow();
                ++num2;
              }
              else
                break;
            }
            if (num2 < 1)
              throw new EarlyExitException(32, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitLexerBlock(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerAtom")]
    private TreeRuleReturnScope<GrammarAST> lexerAtom()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerAtom(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 8;
          try
          {
            switch (this.input.LA(1))
            {
              case 32:
                num1 = 6;
                break;
              case 39:
                num1 = 2;
                break;
              case 52:
                num1 = 7;
                break;
              case 57:
                num1 = 8;
                break;
              case 62:
              case 66:
                num1 = 1;
                break;
              case 97:
                num1 = 3;
                break;
              case 99:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 4;
                  break;
                }
                if ((num2 < 3 || num2 > 4) && num2 != 10 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && num2 != 82 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 33, 4, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              default:
                throw new NoViableAltException("", 33, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._terminal_in_lexerAtom1624);
              this.terminal();
              this.PopFollow();
              break;
            case 2:
              this.Match((IIntStream) this.input, 39, GrammarTreeVisitor.Follow._NOT_in_lexerAtom1635);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._blockSet_in_lexerAtom1637);
              this.blockSet();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.PushFollow(GrammarTreeVisitor.Follow._blockSet_in_lexerAtom1648);
              this.blockSet();
              this.PopFollow();
              break;
            case 4:
              this.Match((IIntStream) this.input, 99, GrammarTreeVisitor.Follow._WILDCARD_in_lexerAtom1659);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_lexerAtom1661);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 5:
              this.Match((IIntStream) this.input, 99, GrammarTreeVisitor.Follow._WILDCARD_in_lexerAtom1672);
              break;
            case 6:
              this.Match((IIntStream) this.input, 32, GrammarTreeVisitor.Follow._LEXER_CHAR_SET_in_lexerAtom1680);
              break;
            case 7:
              this.PushFollow(GrammarTreeVisitor.Follow._range_in_lexerAtom1690);
              this.range();
              this.PopFollow();
              break;
            case 8:
              this.PushFollow(GrammarTreeVisitor.Follow._ruleref_in_lexerAtom1700);
              this.ruleref();
              this.PopFollow();
              break;
          }
          this.ExitLexerAtom(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("actionElement")]
    private TreeRuleReturnScope<GrammarAST> actionElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterActionElement(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
                switch (this.input.LA(2))
                {
                  case -1:
                    num = 1;
                    break;
                  case 2:
                    num = 2;
                    break;
                  default:
                    throw new NoViableAltException("", 34, 1, (IIntStream) this.input, 2);
                }
                break;
              case 59:
                switch (this.input.LA(2))
                {
                  case -1:
                    num = 3;
                    break;
                  case 2:
                    num = 4;
                    break;
                  default:
                    throw new NoViableAltException("", 34, 2, (IIntStream) this.input, 2);
                }
                break;
              default:
                throw new NoViableAltException("", 34, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_actionElement1724);
              break;
            case 2:
              this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_actionElement1732);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_actionElement1734);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_actionElement1742);
              break;
            case 4:
              this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_actionElement1750);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_actionElement1752);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
          }
          this.ExitActionElement(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("alternative")]
    private TreeRuleReturnScope<GrammarAST> alternative()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterAlternative((AltAST) treeRuleReturnScope.Start);
      this.DiscoverAlt((AltAST) treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            num1 = this.dfa38.Predict((IIntStream) this.input);
          }
          catch (NoViableAltException ex)
          {
            throw;
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 73, GrammarTreeVisitor.Follow._ALT_in_alternative1775);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num2 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 81)
                    num2 = 1;
                }
                finally
                {
                }
                if (num2 == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_alternative1777);
                  this.elementOptions();
                  this.PopFollow();
                }
              }
              finally
              {
              }
              int num3 = 0;
              try
              {
                while (true)
                {
                  int num4 = 2;
                  try
                  {
                    int num5 = this.input.LA(1);
                    if (num5 != 4 && num5 != 10 && num5 != 20 && num5 != 39 && num5 != 46 && num5 != 52 && num5 != 57 && num5 != 59 && num5 != 62 && num5 != 66 && num5 != 77 && num5 != 79 && (num5 < 88 || num5 > 89) && num5 != 97)
                    {
                      if (num5 != 99)
                        goto label_19;
                    }
                    num4 = 1;
                  }
                  finally
                  {
                  }
label_19:
                  if (num4 == 1)
                  {
                    this.PushFollow(GrammarTreeVisitor.Follow._element_in_alternative1780);
                    this.element();
                    this.PopFollow();
                    ++num3;
                  }
                  else
                    break;
                }
                if (num3 < 1)
                  throw new EarlyExitException(36, (IIntStream) this.input);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.Match((IIntStream) this.input, 73, GrammarTreeVisitor.Follow._ALT_in_alternative1788);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num6 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 81)
                    num6 = 1;
                }
                finally
                {
                }
                if (num6 == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_alternative1790);
                  this.elementOptions();
                  this.PopFollow();
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 82, GrammarTreeVisitor.Follow._EPSILON_in_alternative1793);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
          }
          this.FinishAlt((AltAST) treeRuleReturnScope.Start);
          this.ExitAlternative((AltAST) treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerCommand")]
    private TreeRuleReturnScope<GrammarAST> lexerCommand()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerCommand(treeRuleReturnScope1.Start);
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 28:
                num = 2;
                break;
              case 85:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 39, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 85, GrammarTreeVisitor.Follow._LEXER_ACTION_CALL_in_lexerCommand1819);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_lexerCommand1821);
              this.PushFollow(GrammarTreeVisitor.Follow._lexerCommandExpr_in_lexerCommand1823);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = this.lexerCommandExpr();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.LexerCallCommand(this.currentOuterAltNumber, ID, treeRuleReturnScope2?.Start);
              break;
            case 2:
              this.LexerCommand(this.currentOuterAltNumber, (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_lexerCommand1839));
              break;
          }
          this.ExitLexerCommand(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("lexerCommandExpr")]
    private TreeRuleReturnScope<GrammarAST> lexerCommandExpr()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerCommandExpr(treeRuleReturnScope.Start);
      try
      {
        try
        {
          if (this.input.LA(1) != 28 && this.input.LA(1) != 30)
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.ExitLexerCommandExpr(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("element")]
    private TreeRuleReturnScope<GrammarAST> element()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterElement(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 10;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 6;
                  break;
                }
                if ((num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 40, 4, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              case 10:
              case 46:
                num1 = 1;
                break;
              case 20:
              case 57:
              case 62:
              case 66:
              case 97:
              case 99:
                num1 = 2;
                break;
              case 39:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 40, 7, (IIntStream) this.input, 2);
                switch (this.input.LA(3))
                {
                  case 77:
                    num1 = 10;
                    break;
                  case 97:
                    num1 = 9;
                    break;
                  default:
                    throw new NoViableAltException("", 40, 12, (IIntStream) this.input, 3);
                }
                break;
              case 52:
                num1 = 8;
                break;
              case 59:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 7;
                  break;
                }
                if ((num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 40, 5, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              case 77:
              case 79:
              case 88:
              case 89:
                num1 = 3;
                break;
              default:
                throw new NoViableAltException("", 40, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._labeledElement_in_element1896);
              this.labeledElement();
              this.PopFollow();
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._atom_in_element1901);
              this.atom();
              this.PopFollow();
              break;
            case 3:
              this.PushFollow(GrammarTreeVisitor.Follow._subrule_in_element1906);
              this.subrule();
              this.PopFollow();
              break;
            case 4:
              this.ActionInAlt((ActionAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_element1913));
              break;
            case 5:
              this.SempredInAlt((PredAST) this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_element1927));
              break;
            case 6:
              GrammarAST action = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_element1942);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_element1944);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ActionInAlt((ActionAST) action);
              break;
            case 7:
              GrammarAST pred = (GrammarAST) this.Match((IIntStream) this.input, 59, GrammarTreeVisitor.Follow._SEMPRED_in_element1955);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_element1957);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.SempredInAlt((PredAST) pred);
              break;
            case 8:
              this.PushFollow(GrammarTreeVisitor.Follow._range_in_element1965);
              this.range();
              this.PopFollow();
              break;
            case 9:
              this.Match((IIntStream) this.input, 39, GrammarTreeVisitor.Follow._NOT_in_element1971);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._blockSet_in_element1973);
              this.blockSet();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 10:
              this.Match((IIntStream) this.input, 39, GrammarTreeVisitor.Follow._NOT_in_element1980);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._block_in_element1982);
              this.block();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
          }
          this.ExitElement(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("astOperand")]
    private TreeRuleReturnScope<GrammarAST> astOperand()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterAstOperand(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 3;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
              case 57:
              case 62:
              case 66:
              case 97:
              case 99:
                num = 1;
                break;
              case 39:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 41, 2, (IIntStream) this.input, 2);
                switch (this.input.LA(3))
                {
                  case 77:
                    num = 3;
                    break;
                  case 97:
                    num = 2;
                    break;
                  default:
                    throw new NoViableAltException("", 41, 3, (IIntStream) this.input, 3);
                }
                break;
              default:
                throw new NoViableAltException("", 41, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._atom_in_astOperand2004);
              this.atom();
              this.PopFollow();
              break;
            case 2:
              this.Match((IIntStream) this.input, 39, GrammarTreeVisitor.Follow._NOT_in_astOperand2010);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._blockSet_in_astOperand2012);
              this.blockSet();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.Match((IIntStream) this.input, 39, GrammarTreeVisitor.Follow._NOT_in_astOperand2019);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._block_in_astOperand2021);
              this.block();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
          }
          this.ExitAstOperand(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("labeledElement")]
    private TreeRuleReturnScope<GrammarAST> labeledElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      this.EnterLabeledElement(treeRuleReturnScope1.Start);
      try
      {
        try
        {
          if (this.input.LA(1) != 10 && this.input.LA(1) != 46)
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_labeledElement2050);
          this.PushFollow(GrammarTreeVisitor.Follow._element_in_labeledElement2052);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = this.element();
          this.PopFollow();
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.Label(treeRuleReturnScope1.Start, ID, treeRuleReturnScope2?.Start);
          this.ExitLabeledElement(treeRuleReturnScope1.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope1;
    }

    [GrammarRule("subrule")]
    private TreeRuleReturnScope<GrammarAST> subrule()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterSubrule(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            int num2 = this.input.LA(1);
            if (num2 == 79 || num2 >= 88 && num2 <= 89)
            {
              num1 = 1;
            }
            else
            {
              if (num2 != 77)
                throw new NoViableAltException("", 42, 0, (IIntStream) this.input, 1);
              num1 = 2;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._blockSuffix_in_subrule2077);
              this.blockSuffix();
              this.PopFollow();
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._block_in_subrule2079);
              this.block();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._block_in_subrule2086);
              this.block();
              this.PopFollow();
              break;
          }
          this.ExitSubrule(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("lexerSubrule")]
    private TreeRuleReturnScope<GrammarAST> lexerSubrule()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterLexerSubrule(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            int num2 = this.input.LA(1);
            if (num2 == 79 || num2 >= 88 && num2 <= 89)
            {
              num1 = 1;
            }
            else
            {
              if (num2 != 77)
                throw new NoViableAltException("", 43, 0, (IIntStream) this.input, 1);
              num1 = 2;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(GrammarTreeVisitor.Follow._blockSuffix_in_lexerSubrule2111);
              this.blockSuffix();
              this.PopFollow();
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._lexerBlock_in_lexerSubrule2113);
              this.lexerBlock();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.PushFollow(GrammarTreeVisitor.Follow._lexerBlock_in_lexerSubrule2120);
              this.lexerBlock();
              this.PopFollow();
              break;
          }
          this.ExitLexerSubrule(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("blockSuffix")]
    private TreeRuleReturnScope<GrammarAST> blockSuffix()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterBlockSuffix(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.PushFollow(GrammarTreeVisitor.Follow._ebnfSuffix_in_blockSuffix2147);
          this.ebnfSuffix();
          this.PopFollow();
          this.ExitBlockSuffix(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ebnfSuffix")]
    private TreeRuleReturnScope<GrammarAST> ebnfSuffix()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterEbnfSuffix(treeRuleReturnScope.Start);
      try
      {
        try
        {
          if (this.input.LA(1) != 79 && (this.input.LA(1) < 88 || this.input.LA(1) > 89))
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
          this.ExitEbnfSuffix(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("atom")]
    private TreeRuleReturnScope<GrammarAST> atom()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterAtom(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 7;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 44, 1, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 44, 6, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 57:
                    num1 = 2;
                    break;
                  case 62:
                  case 66:
                    num1 = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 44, 9, (IIntStream) this.input, 4);
                }
                break;
              case 57:
                num1 = 7;
                break;
              case 62:
              case 66:
                num1 = 5;
                break;
              case 97:
                num1 = 6;
                break;
              case 99:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 3;
                  break;
                }
                if (num2 != -1 && (num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 44, 2, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              default:
                throw new NoViableAltException("", 44, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 20, GrammarTreeVisitor.Follow._DOT_in_atom2208);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_atom2210);
              this.PushFollow(GrammarTreeVisitor.Follow._terminal_in_atom2212);
              this.terminal();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.Match((IIntStream) this.input, 20, GrammarTreeVisitor.Follow._DOT_in_atom2219);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_atom2221);
              this.PushFollow(GrammarTreeVisitor.Follow._ruleref_in_atom2223);
              this.ruleref();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              GrammarAST @ref = (GrammarAST) this.Match((IIntStream) this.input, 99, GrammarTreeVisitor.Follow._WILDCARD_in_atom2233);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_atom2235);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.WildcardRef(@ref);
              break;
            case 4:
              this.WildcardRef((GrammarAST) this.Match((IIntStream) this.input, 99, GrammarTreeVisitor.Follow._WILDCARD_in_atom2246));
              break;
            case 5:
              this.PushFollow(GrammarTreeVisitor.Follow._terminal_in_atom2262);
              this.terminal();
              this.PopFollow();
              break;
            case 6:
              this.PushFollow(GrammarTreeVisitor.Follow._blockSet_in_atom2270);
              this.blockSet();
              this.PopFollow();
              break;
            case 7:
              this.PushFollow(GrammarTreeVisitor.Follow._ruleref_in_atom2280);
              this.ruleref();
              this.PopFollow();
              break;
          }
          this.ExitAtom(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("blockSet")]
    private TreeRuleReturnScope<GrammarAST> blockSet()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterBlockSet(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 97, GrammarTreeVisitor.Follow._SET_in_blockSet2305);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 0;
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 32:
                  case 52:
                  case 62:
                  case 66:
                    num2 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._setElement_in_blockSet2307);
                this.setElement();
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(45, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitBlockSet(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("setElement")]
    private TreeRuleReturnScope<GrammarAST> setElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterSetElement(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 6;
          try
          {
            switch (this.input.LA(1))
            {
              case 32:
                num = 6;
                break;
              case 52:
                num = 5;
                break;
              case 62:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 1;
                    break;
                  case 3:
                  case 32:
                  case 52:
                  case 62:
                  case 66:
                    num = 3;
                    break;
                  default:
                    throw new NoViableAltException("", 46, 1, (IIntStream) this.input, 2);
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 2;
                    break;
                  case 3:
                  case 32:
                  case 52:
                  case 62:
                  case 66:
                    num = 4;
                    break;
                  default:
                    throw new NoViableAltException("", 46, 2, (IIntStream) this.input, 2);
                }
                break;
              default:
                throw new NoViableAltException("", 46, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              GrammarAST ref1 = (GrammarAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2331);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_setElement2333);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.StringRef((TerminalAST) ref1);
              break;
            case 2:
              GrammarAST ref2 = (GrammarAST) this.Match((IIntStream) this.input, 66, GrammarTreeVisitor.Follow._TOKEN_REF_in_setElement2345);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_setElement2347);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.TokenRef((TerminalAST) ref2);
              break;
            case 3:
              this.StringRef((TerminalAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2357));
              break;
            case 4:
              this.TokenRef((TerminalAST) this.Match((IIntStream) this.input, 66, GrammarTreeVisitor.Follow._TOKEN_REF_in_setElement2382));
              break;
            case 5:
              this.Match((IIntStream) this.input, 52, GrammarTreeVisitor.Follow._RANGE_in_setElement2411);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ref3 = (GrammarAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2415);
              GrammarAST ref4 = (GrammarAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2419);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.StringRef((TerminalAST) ref3);
              this.StringRef((TerminalAST) ref4);
              break;
            case 6:
              this.Match((IIntStream) this.input, 32, GrammarTreeVisitor.Follow._LEXER_CHAR_SET_in_setElement2442);
              break;
          }
          this.ExitSetElement(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("block")]
    private TreeRuleReturnScope<GrammarAST> block()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterBlock(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, GrammarTreeVisitor.Follow._BLOCK_in_block2467);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 42)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(GrammarTreeVisitor.Follow._optionsSpec_in_block2469);
              this.optionsSpec();
              this.PopFollow();
            }
          }
          finally
          {
          }
          try
          {
            while (true)
            {
              int num2 = 2;
              try
              {
                if (this.input.LA(1) == 11)
                  num2 = 1;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._ruleAction_in_block2472);
                this.ruleAction();
                this.PopFollow();
              }
              else
                break;
            }
          }
          finally
          {
          }
          int num3 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 4)
                num3 = 1;
            }
            finally
            {
            }
            if (num3 == 1)
              this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_block2475);
          }
          finally
          {
          }
          int num4 = 0;
          try
          {
            while (true)
            {
              int num5 = 2;
              try
              {
                if (this.input.LA(1) == 73)
                  num5 = 1;
              }
              finally
              {
              }
              if (num5 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._alternative_in_block2478);
                this.alternative();
                this.PopFollow();
                ++num4;
              }
              else
                break;
            }
            if (num4 < 1)
              throw new EarlyExitException(50, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitBlock(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("ruleref")]
    private TreeRuleReturnScope<GrammarAST> ruleref()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST action = (GrammarAST) null;
      this.EnterRuleref(treeRuleReturnScope.Start);
      try
      {
        try
        {
          GrammarAST @ref = (GrammarAST) this.Match((IIntStream) this.input, 57, GrammarTreeVisitor.Follow._RULE_REF_in_ruleref2508);
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            int num1 = 2;
            try
            {
              try
              {
                if (this.input.LA(1) == 8)
                  num1 = 1;
              }
              finally
              {
              }
              if (num1 == 1)
                action = (GrammarAST) this.Match((IIntStream) this.input, 8, GrammarTreeVisitor.Follow._ARG_ACTION_in_ruleref2512);
            }
            finally
            {
            }
            int num2 = 2;
            try
            {
              try
              {
                if (this.input.LA(1) == 81)
                  num2 = 1;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_ruleref2515);
                this.elementOptions();
                this.PopFollow();
              }
            }
            finally
            {
            }
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          this.RuleRef(@ref, (ActionAST) action);
          if (action != null)
            this.ActionInAlt((ActionAST) action);
          this.ExitRuleref(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("range")]
    private TreeRuleReturnScope<GrammarAST> range()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterRange(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 52, GrammarTreeVisitor.Follow._RANGE_in_range2552);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_range2554);
          this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_range2556);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          this.ExitRange(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("terminal")]
    private TreeRuleReturnScope<GrammarAST> terminal()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterTerminal(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 62:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != -1 && (num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && num2 != 82 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 53, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 3;
                  break;
                }
                if (num3 != -1 && (num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 32 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && num3 != 82 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 53, 2, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              default:
                throw new NoViableAltException("", 53, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST ref1 = (GrammarAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_terminal2586);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_terminal2588);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.StringRef((TerminalAST) ref1);
              break;
            case 2:
              this.StringRef((TerminalAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_terminal2611));
              break;
            case 3:
              GrammarAST ref2 = (GrammarAST) this.Match((IIntStream) this.input, 66, GrammarTreeVisitor.Follow._TOKEN_REF_in_terminal2625);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(GrammarTreeVisitor.Follow._elementOptions_in_terminal2627);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.TokenRef((TerminalAST) ref2);
              break;
            case 4:
              this.TokenRef((TerminalAST) this.Match((IIntStream) this.input, 66, GrammarTreeVisitor.Follow._TOKEN_REF_in_terminal2638));
              break;
          }
          this.ExitTerminal(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("elementOptions")]
    private TreeRuleReturnScope<GrammarAST> elementOptions()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterElementOptions(treeRuleReturnScope.Start);
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 81, GrammarTreeVisitor.Follow._ELEMENT_OPTIONS_in_elementOptions2675);
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            try
            {
              while (true)
              {
                int num = 2;
                try
                {
                  switch (this.input.LA(1))
                  {
                    case 10:
                    case 28:
                      num = 1;
                      break;
                  }
                }
                finally
                {
                }
                if (num == 1)
                {
                  this.PushFollow(GrammarTreeVisitor.Follow._elementOption_in_elementOptions2677);
                  this.elementOption((GrammarASTWithOptions) treeRuleReturnScope.Start.Parent);
                  this.PopFollow();
                }
                else
                  break;
              }
            }
            finally
            {
            }
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          this.ExitElementOptions(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    [GrammarRule("elementOption")]
    private TreeRuleReturnScope<GrammarAST> elementOption(GrammarASTWithOptions t)
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      this.EnterElementOption(treeRuleReturnScope.Start);
      try
      {
        try
        {
          int num = 5;
          try
          {
            switch (this.input.LA(1))
            {
              case 10:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 55, 2, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 55, 3, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 4:
                    num = 4;
                    break;
                  case 28:
                    num = 2;
                    break;
                  case 30:
                    num = 5;
                    break;
                  case 62:
                    num = 3;
                    break;
                  default:
                    throw new NoViableAltException("", 55, 4, (IIntStream) this.input, 4);
                }
                break;
              case 28:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 55, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              GrammarAST ID1 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2708);
              this.ElementOption(t, ID1, (GrammarAST) null);
              break;
            case 2:
              this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2728);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID2 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2732);
              GrammarAST valueAST1 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2736);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ElementOption(t, ID2, valueAST1);
              break;
            case 3:
              this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2752);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID3 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2754);
              GrammarAST valueAST2 = (GrammarAST) this.Match((IIntStream) this.input, 62, GrammarTreeVisitor.Follow._STRING_LITERAL_in_elementOption2758);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ElementOption(t, ID3, valueAST2);
              break;
            case 4:
              this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2772);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID4 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2774);
              GrammarAST valueAST3 = (GrammarAST) this.Match((IIntStream) this.input, 4, GrammarTreeVisitor.Follow._ACTION_in_elementOption2778);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ElementOption(t, ID4, valueAST3);
              break;
            case 5:
              this.Match((IIntStream) this.input, 10, GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2794);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID5 = (GrammarAST) this.Match((IIntStream) this.input, 28, GrammarTreeVisitor.Follow._ID_in_elementOption2796);
              GrammarAST valueAST4 = (GrammarAST) this.Match((IIntStream) this.input, 30, GrammarTreeVisitor.Follow._INT_in_elementOption2800);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              this.ElementOption(t, ID5, valueAST4);
              break;
          }
          this.ExitElementOption(treeRuleReturnScope.Start);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return treeRuleReturnScope;
    }

    protected override void InitDFAs()
    {
      base.InitDFAs();
      this.dfa38 = new GrammarTreeVisitor.DFA38((BaseRecognizer) this);
    }

    static GrammarTreeVisitor()
    {
      GrammarTreeVisitor.tokenNames = new string[100]
      {
        "<invalid>",
        "<EOR>",
        "<DOWN>",
        "<UP>",
        nameof (ACTION),
        nameof (ACTION_CHAR_LITERAL),
        nameof (ACTION_ESC),
        nameof (ACTION_STRING_LITERAL),
        nameof (ARG_ACTION),
        nameof (ARG_OR_CHARSET),
        nameof (ASSIGN),
        nameof (AT),
        nameof (CATCH),
        nameof (CHANNELS),
        nameof (COLON),
        nameof (COLONCOLON),
        nameof (COMMA),
        nameof (COMMENT),
        nameof (DOC_COMMENT),
        nameof (DOLLAR),
        nameof (DOT),
        nameof (ERRCHAR),
        nameof (ESC_SEQ),
        nameof (FINALLY),
        nameof (FRAGMENT),
        nameof (GRAMMAR),
        nameof (GT),
        nameof (HEX_DIGIT),
        nameof (ID),
        nameof (IMPORT),
        nameof (INT),
        nameof (LEXER),
        nameof (LEXER_CHAR_SET),
        nameof (LOCALS),
        nameof (LPAREN),
        nameof (LT),
        nameof (MODE),
        nameof (NESTED_ACTION),
        nameof (NLCHARS),
        nameof (NOT),
        nameof (NameChar),
        nameof (NameStartChar),
        nameof (OPTIONS),
        nameof (OR),
        nameof (PARSER),
        nameof (PLUS),
        nameof (PLUS_ASSIGN),
        nameof (POUND),
        nameof (PRIVATE),
        nameof (PROTECTED),
        nameof (PUBLIC),
        nameof (QUESTION),
        nameof (RANGE),
        nameof (RARROW),
        nameof (RBRACE),
        nameof (RETURNS),
        nameof (RPAREN),
        nameof (RULE_REF),
        nameof (SEMI),
        nameof (SEMPRED),
        nameof (SRC),
        nameof (STAR),
        nameof (STRING_LITERAL),
        nameof (SYNPRED),
        nameof (THROWS),
        nameof (TOKENS_SPEC),
        nameof (TOKEN_REF),
        nameof (TREE_GRAMMAR),
        nameof (UNICODE_ESC),
        nameof (UnicodeBOM),
        nameof (WS),
        nameof (WSCHARS),
        nameof (WSNLCHARS),
        nameof (ALT),
        nameof (ALTLIST),
        nameof (ARG),
        nameof (ARGLIST),
        nameof (BLOCK),
        nameof (CHAR_RANGE),
        nameof (CLOSURE),
        nameof (COMBINED),
        nameof (ELEMENT_OPTIONS),
        nameof (EPSILON),
        nameof (INITACTION),
        nameof (LABEL),
        nameof (LEXER_ACTION_CALL),
        nameof (LEXER_ALT_ACTION),
        nameof (LIST),
        nameof (OPTIONAL),
        nameof (POSITIVE_CLOSURE),
        nameof (PREC_RULE),
        nameof (RESULT),
        nameof (RET),
        nameof (RULE),
        nameof (RULEACTIONS),
        nameof (RULEMODIFIERS),
        nameof (RULES),
        nameof (SET),
        nameof (TEMPLATE),
        nameof (WILDCARD)
      };
    }

    private sealed class prequelConstructs_return : TreeRuleReturnScope<GrammarAST>
    {
      public GrammarAST firstOne;

      public prequelConstructs_return(GrammarTreeVisitor grammar):base()
      {
      }
    }

    private sealed class optionValue_return : TreeRuleReturnScope<GrammarAST>
    {
      public string v;

      public optionValue_return(GrammarTreeVisitor grammar):base()
      {
      }
    }

    private class DFA38 : DFA
    {
      private const string DFA38_eotS = "\u0014\uFFFF";
      private const string DFA38_eofS = "\u0014\uFFFF";
      private const string DFA38_minS = "\u0001I\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0002\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003";
      private const string DFA38_maxS = "\u0001I\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C";
      private const string DFA38_acceptS = "\u0004\uFFFF\u0001\u0001\u0001\u0002\u000E\uFFFF";
      private const string DFA38_specialS = "\u0014\uFFFF}>";
      private static readonly string[] DFA38_transitionS;
      private static readonly short[] DFA38_eot;
      private static readonly short[] DFA38_eof;
      private static readonly char[] DFA38_min;
      private static readonly char[] DFA38_max;
      private static readonly short[] DFA38_accept;
      private static readonly short[] DFA38_special;
      private static readonly short[][] DFA38_transition;

      static DFA38()
      {
        GrammarTreeVisitor.DFA38.DFA38_transitionS = new string[20]
        {
          "\u0001\u0001",
          "\u0001\u0002",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0003\u0001\u0005\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0006",
          "",
          "",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a",
          "\u0001\n",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0005\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\v",
          "\u0001\u000E\u0017\uFFFF\u0001\f\u0001\uFFFF\u0001\u000F\u001F\uFFFF\u0001\r",
          "\u0001\u0010",
          "\u0001\u0011",
          "\u0001\u0012",
          "\u0001\u0013",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a",
          "\u0001\t\u0006\uFFFF\u0001\b\u0011\uFFFF\u0001\a"
        };
        GrammarTreeVisitor.DFA38.DFA38_eot = DFA.UnpackEncodedString("\u0014\uFFFF");
        GrammarTreeVisitor.DFA38.DFA38_eof = DFA.UnpackEncodedString("\u0014\uFFFF");
        GrammarTreeVisitor.DFA38.DFA38_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001I\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0002\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003");
        GrammarTreeVisitor.DFA38.DFA38_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001I\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C");
        GrammarTreeVisitor.DFA38.DFA38_accept = DFA.UnpackEncodedString("\u0004\uFFFF\u0001\u0001\u0001\u0002\u000E\uFFFF");
        GrammarTreeVisitor.DFA38.DFA38_special = DFA.UnpackEncodedString("\u0014\uFFFF}>");
        int length = GrammarTreeVisitor.DFA38.DFA38_transitionS.Length;
        GrammarTreeVisitor.DFA38.DFA38_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          GrammarTreeVisitor.DFA38.DFA38_transition[index] = DFA.UnpackEncodedString(GrammarTreeVisitor.DFA38.DFA38_transitionS[index]);
      }

      public DFA38(BaseRecognizer recognizer):base()
      {
        this.recognizer = recognizer;
        this.decisionNumber = 38;
        this.eot = GrammarTreeVisitor.DFA38.DFA38_eot;
        this.eof = GrammarTreeVisitor.DFA38.DFA38_eof;
        this.min = GrammarTreeVisitor.DFA38.DFA38_min;
        this.max = GrammarTreeVisitor.DFA38.DFA38_max;
        this.accept = GrammarTreeVisitor.DFA38.DFA38_accept;
        this.special = GrammarTreeVisitor.DFA38.DFA38_special;
        this.transition = GrammarTreeVisitor.DFA38.DFA38_transition;
      }

      public override string Description
      {
        get
        {
          return "748:1: alternative : ( ^( ALT ( elementOptions )? ( element )+ ) | ^( ALT ( elementOptions )? EPSILON ) );";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private static class Follow
    {
      public static readonly BitSet _GRAMMAR_in_grammarSpec90;
      public static readonly BitSet _ID_in_grammarSpec92;
      public static readonly BitSet _prequelConstructs_in_grammarSpec111;
      public static readonly BitSet _rules_in_grammarSpec128;
      public static readonly BitSet _mode_in_grammarSpec130;
      public static readonly BitSet _prequelConstruct_in_prequelConstructs172;
      public static readonly BitSet _optionsSpec_in_prequelConstruct199;
      public static readonly BitSet _delegateGrammars_in_prequelConstruct209;
      public static readonly BitSet _tokensSpec_in_prequelConstruct219;
      public static readonly BitSet _channelsSpec_in_prequelConstruct229;
      public static readonly BitSet _action_in_prequelConstruct239;
      public static readonly BitSet _OPTIONS_in_optionsSpec264;
      public static readonly BitSet _option_in_optionsSpec266;
      public static readonly BitSet _ASSIGN_in_option300;
      public static readonly BitSet _ID_in_option302;
      public static readonly BitSet _optionValue_in_option306;
      public static readonly BitSet _IMPORT_in_delegateGrammars394;
      public static readonly BitSet _delegateGrammar_in_delegateGrammars396;
      public static readonly BitSet _ASSIGN_in_delegateGrammar425;
      public static readonly BitSet _ID_in_delegateGrammar429;
      public static readonly BitSet _ID_in_delegateGrammar433;
      public static readonly BitSet _ID_in_delegateGrammar448;
      public static readonly BitSet _TOKENS_SPEC_in_tokensSpec482;
      public static readonly BitSet _tokenSpec_in_tokensSpec484;
      public static readonly BitSet _ID_in_tokenSpec507;
      public static readonly BitSet _CHANNELS_in_channelsSpec537;
      public static readonly BitSet _channelSpec_in_channelsSpec539;
      public static readonly BitSet _ID_in_channelSpec562;
      public static readonly BitSet _AT_in_action590;
      public static readonly BitSet _ID_in_action594;
      public static readonly BitSet _ID_in_action599;
      public static readonly BitSet _ACTION_in_action601;
      public static readonly BitSet _RULES_in_rules629;
      public static readonly BitSet _rule_in_rules634;
      public static readonly BitSet _lexerRule_in_rules636;
      public static readonly BitSet _MODE_in_mode667;
      public static readonly BitSet _ID_in_mode669;
      public static readonly BitSet _lexerRule_in_mode673;
      public static readonly BitSet _RULE_in_lexerRule699;
      public static readonly BitSet _TOKEN_REF_in_lexerRule701;
      public static readonly BitSet _RULEMODIFIERS_in_lexerRule713;
      public static readonly BitSet _FRAGMENT_in_lexerRule717;
      public static readonly BitSet _lexerRuleBlock_in_lexerRule742;
      public static readonly BitSet _RULE_in_rule789;
      public static readonly BitSet _RULE_REF_in_rule791;
      public static readonly BitSet _RULEMODIFIERS_in_rule800;
      public static readonly BitSet _ruleModifier_in_rule805;
      public static readonly BitSet _ARG_ACTION_in_rule816;
      public static readonly BitSet _ruleReturns_in_rule829;
      public static readonly BitSet _throwsSpec_in_rule842;
      public static readonly BitSet _locals_in_rule855;
      public static readonly BitSet _optionsSpec_in_rule870;
      public static readonly BitSet _ruleAction_in_rule884;
      public static readonly BitSet _ruleBlock_in_rule915;
      public static readonly BitSet _exceptionGroup_in_rule917;
      public static readonly BitSet _exceptionHandler_in_exceptionGroup964;
      public static readonly BitSet _finallyClause_in_exceptionGroup967;
      public static readonly BitSet _CATCH_in_exceptionHandler993;
      public static readonly BitSet _ARG_ACTION_in_exceptionHandler995;
      public static readonly BitSet _ACTION_in_exceptionHandler997;
      public static readonly BitSet _FINALLY_in_finallyClause1022;
      public static readonly BitSet _ACTION_in_finallyClause1024;
      public static readonly BitSet _LOCALS_in_locals1052;
      public static readonly BitSet _ARG_ACTION_in_locals1054;
      public static readonly BitSet _RETURNS_in_ruleReturns1077;
      public static readonly BitSet _ARG_ACTION_in_ruleReturns1079;
      public static readonly BitSet _THROWS_in_throwsSpec1105;
      public static readonly BitSet _ID_in_throwsSpec1107;
      public static readonly BitSet _AT_in_ruleAction1134;
      public static readonly BitSet _ID_in_ruleAction1136;
      public static readonly BitSet _ACTION_in_ruleAction1138;
      public static readonly BitSet _BLOCK_in_lexerRuleBlock1216;
      public static readonly BitSet _lexerOuterAlternative_in_lexerRuleBlock1235;
      public static readonly BitSet _BLOCK_in_ruleBlock1280;
      public static readonly BitSet _outerAlternative_in_ruleBlock1299;
      public static readonly BitSet _lexerAlternative_in_lexerOuterAlternative1339;
      public static readonly BitSet _alternative_in_outerAlternative1362;
      public static readonly BitSet _LEXER_ALT_ACTION_in_lexerAlternative1384;
      public static readonly BitSet _lexerElements_in_lexerAlternative1386;
      public static readonly BitSet _lexerCommand_in_lexerAlternative1388;
      public static readonly BitSet _lexerElements_in_lexerAlternative1400;
      public static readonly BitSet _ALT_in_lexerElements1428;
      public static readonly BitSet _lexerElement_in_lexerElements1430;
      public static readonly BitSet _labeledLexerElement_in_lexerElement1456;
      public static readonly BitSet _lexerAtom_in_lexerElement1461;
      public static readonly BitSet _lexerSubrule_in_lexerElement1466;
      public static readonly BitSet _ACTION_in_lexerElement1473;
      public static readonly BitSet _SEMPRED_in_lexerElement1487;
      public static readonly BitSet _ACTION_in_lexerElement1502;
      public static readonly BitSet _elementOptions_in_lexerElement1504;
      public static readonly BitSet _SEMPRED_in_lexerElement1515;
      public static readonly BitSet _elementOptions_in_lexerElement1517;
      public static readonly BitSet _EPSILON_in_lexerElement1525;
      public static readonly BitSet _set_in_labeledLexerElement1552;
      public static readonly BitSet _ID_in_labeledLexerElement1558;
      public static readonly BitSet _lexerAtom_in_labeledLexerElement1561;
      public static readonly BitSet _block_in_labeledLexerElement1563;
      public static readonly BitSet _BLOCK_in_lexerBlock1588;
      public static readonly BitSet _optionsSpec_in_lexerBlock1590;
      public static readonly BitSet _lexerAlternative_in_lexerBlock1593;
      public static readonly BitSet _terminal_in_lexerAtom1624;
      public static readonly BitSet _NOT_in_lexerAtom1635;
      public static readonly BitSet _blockSet_in_lexerAtom1637;
      public static readonly BitSet _blockSet_in_lexerAtom1648;
      public static readonly BitSet _WILDCARD_in_lexerAtom1659;
      public static readonly BitSet _elementOptions_in_lexerAtom1661;
      public static readonly BitSet _WILDCARD_in_lexerAtom1672;
      public static readonly BitSet _LEXER_CHAR_SET_in_lexerAtom1680;
      public static readonly BitSet _range_in_lexerAtom1690;
      public static readonly BitSet _ruleref_in_lexerAtom1700;
      public static readonly BitSet _ACTION_in_actionElement1724;
      public static readonly BitSet _ACTION_in_actionElement1732;
      public static readonly BitSet _elementOptions_in_actionElement1734;
      public static readonly BitSet _SEMPRED_in_actionElement1742;
      public static readonly BitSet _SEMPRED_in_actionElement1750;
      public static readonly BitSet _elementOptions_in_actionElement1752;
      public static readonly BitSet _ALT_in_alternative1775;
      public static readonly BitSet _elementOptions_in_alternative1777;
      public static readonly BitSet _element_in_alternative1780;
      public static readonly BitSet _ALT_in_alternative1788;
      public static readonly BitSet _elementOptions_in_alternative1790;
      public static readonly BitSet _EPSILON_in_alternative1793;
      public static readonly BitSet _LEXER_ACTION_CALL_in_lexerCommand1819;
      public static readonly BitSet _ID_in_lexerCommand1821;
      public static readonly BitSet _lexerCommandExpr_in_lexerCommand1823;
      public static readonly BitSet _ID_in_lexerCommand1839;
      public static readonly BitSet _labeledElement_in_element1896;
      public static readonly BitSet _atom_in_element1901;
      public static readonly BitSet _subrule_in_element1906;
      public static readonly BitSet _ACTION_in_element1913;
      public static readonly BitSet _SEMPRED_in_element1927;
      public static readonly BitSet _ACTION_in_element1942;
      public static readonly BitSet _elementOptions_in_element1944;
      public static readonly BitSet _SEMPRED_in_element1955;
      public static readonly BitSet _elementOptions_in_element1957;
      public static readonly BitSet _range_in_element1965;
      public static readonly BitSet _NOT_in_element1971;
      public static readonly BitSet _blockSet_in_element1973;
      public static readonly BitSet _NOT_in_element1980;
      public static readonly BitSet _block_in_element1982;
      public static readonly BitSet _atom_in_astOperand2004;
      public static readonly BitSet _NOT_in_astOperand2010;
      public static readonly BitSet _blockSet_in_astOperand2012;
      public static readonly BitSet _NOT_in_astOperand2019;
      public static readonly BitSet _block_in_astOperand2021;
      public static readonly BitSet _set_in_labeledElement2044;
      public static readonly BitSet _ID_in_labeledElement2050;
      public static readonly BitSet _element_in_labeledElement2052;
      public static readonly BitSet _blockSuffix_in_subrule2077;
      public static readonly BitSet _block_in_subrule2079;
      public static readonly BitSet _block_in_subrule2086;
      public static readonly BitSet _blockSuffix_in_lexerSubrule2111;
      public static readonly BitSet _lexerBlock_in_lexerSubrule2113;
      public static readonly BitSet _lexerBlock_in_lexerSubrule2120;
      public static readonly BitSet _ebnfSuffix_in_blockSuffix2147;
      public static readonly BitSet _DOT_in_atom2208;
      public static readonly BitSet _ID_in_atom2210;
      public static readonly BitSet _terminal_in_atom2212;
      public static readonly BitSet _DOT_in_atom2219;
      public static readonly BitSet _ID_in_atom2221;
      public static readonly BitSet _ruleref_in_atom2223;
      public static readonly BitSet _WILDCARD_in_atom2233;
      public static readonly BitSet _elementOptions_in_atom2235;
      public static readonly BitSet _WILDCARD_in_atom2246;
      public static readonly BitSet _terminal_in_atom2262;
      public static readonly BitSet _blockSet_in_atom2270;
      public static readonly BitSet _ruleref_in_atom2280;
      public static readonly BitSet _SET_in_blockSet2305;
      public static readonly BitSet _setElement_in_blockSet2307;
      public static readonly BitSet _STRING_LITERAL_in_setElement2331;
      public static readonly BitSet _elementOptions_in_setElement2333;
      public static readonly BitSet _TOKEN_REF_in_setElement2345;
      public static readonly BitSet _elementOptions_in_setElement2347;
      public static readonly BitSet _STRING_LITERAL_in_setElement2357;
      public static readonly BitSet _TOKEN_REF_in_setElement2382;
      public static readonly BitSet _RANGE_in_setElement2411;
      public static readonly BitSet _STRING_LITERAL_in_setElement2415;
      public static readonly BitSet _STRING_LITERAL_in_setElement2419;
      public static readonly BitSet _LEXER_CHAR_SET_in_setElement2442;
      public static readonly BitSet _BLOCK_in_block2467;
      public static readonly BitSet _optionsSpec_in_block2469;
      public static readonly BitSet _ruleAction_in_block2472;
      public static readonly BitSet _ACTION_in_block2475;
      public static readonly BitSet _alternative_in_block2478;
      public static readonly BitSet _RULE_REF_in_ruleref2508;
      public static readonly BitSet _ARG_ACTION_in_ruleref2512;
      public static readonly BitSet _elementOptions_in_ruleref2515;
      public static readonly BitSet _RANGE_in_range2552;
      public static readonly BitSet _STRING_LITERAL_in_range2554;
      public static readonly BitSet _STRING_LITERAL_in_range2556;
      public static readonly BitSet _STRING_LITERAL_in_terminal2586;
      public static readonly BitSet _elementOptions_in_terminal2588;
      public static readonly BitSet _STRING_LITERAL_in_terminal2611;
      public static readonly BitSet _TOKEN_REF_in_terminal2625;
      public static readonly BitSet _elementOptions_in_terminal2627;
      public static readonly BitSet _TOKEN_REF_in_terminal2638;
      public static readonly BitSet _ELEMENT_OPTIONS_in_elementOptions2675;
      public static readonly BitSet _elementOption_in_elementOptions2677;
      public static readonly BitSet _ID_in_elementOption2708;
      public static readonly BitSet _ASSIGN_in_elementOption2728;
      public static readonly BitSet _ID_in_elementOption2732;
      public static readonly BitSet _ID_in_elementOption2736;
      public static readonly BitSet _ASSIGN_in_elementOption2752;
      public static readonly BitSet _ID_in_elementOption2754;
      public static readonly BitSet _STRING_LITERAL_in_elementOption2758;
      public static readonly BitSet _ASSIGN_in_elementOption2772;
      public static readonly BitSet _ID_in_elementOption2774;
      public static readonly BitSet _ACTION_in_elementOption2778;
      public static readonly BitSet _ASSIGN_in_elementOption2794;
      public static readonly BitSet _ID_in_elementOption2796;
      public static readonly BitSet _INT_in_elementOption2800;

      static Follow()
      {
        GrammarTreeVisitor.Follow._GRAMMAR_in_grammarSpec90 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_grammarSpec92 = new BitSet(new ulong[2]
        {
          4398583392256UL,
          4294967298UL
        });
        GrammarTreeVisitor.Follow._prequelConstructs_in_grammarSpec111 = new BitSet(new ulong[2]
        {
          0UL,
          4294967296UL
        });
        GrammarTreeVisitor.Follow._rules_in_grammarSpec128 = new BitSet(new ulong[1]
        {
          68719476744UL
        });
        GrammarTreeVisitor.Follow._mode_in_grammarSpec130 = new BitSet(new ulong[1]
        {
          68719476744UL
        });
        GrammarTreeVisitor.Follow._prequelConstruct_in_prequelConstructs172 = new BitSet(new ulong[2]
        {
          4398583392258UL,
          2UL
        });
        GrammarTreeVisitor.Follow._optionsSpec_in_prequelConstruct199 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._delegateGrammars_in_prequelConstruct209 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._tokensSpec_in_prequelConstruct219 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._channelsSpec_in_prequelConstruct229 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._action_in_prequelConstruct239 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._OPTIONS_in_optionsSpec264 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._option_in_optionsSpec266 = new BitSet(new ulong[1]
        {
          1032UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_option300 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_option302 = new BitSet(new ulong[1]
        {
          4611686019769565184UL
        });
        GrammarTreeVisitor.Follow._optionValue_in_option306 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._IMPORT_in_delegateGrammars394 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._delegateGrammar_in_delegateGrammars396 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_delegateGrammar425 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_delegateGrammar429 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        GrammarTreeVisitor.Follow._ID_in_delegateGrammar433 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ID_in_delegateGrammar448 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._TOKENS_SPEC_in_tokensSpec482 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._tokenSpec_in_tokensSpec484 = new BitSet(new ulong[1]
        {
          268435464UL
        });
        GrammarTreeVisitor.Follow._ID_in_tokenSpec507 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._CHANNELS_in_channelsSpec537 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._channelSpec_in_channelsSpec539 = new BitSet(new ulong[1]
        {
          268435464UL
        });
        GrammarTreeVisitor.Follow._ID_in_channelSpec562 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._AT_in_action590 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_action594 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        GrammarTreeVisitor.Follow._ID_in_action599 = new BitSet(new ulong[1]
        {
          16UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_action601 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._RULES_in_rules629 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._rule_in_rules634 = new BitSet(new ulong[2]
        {
          8UL,
          536870912UL
        });
        GrammarTreeVisitor.Follow._lexerRule_in_rules636 = new BitSet(new ulong[2]
        {
          8UL,
          536870912UL
        });
        GrammarTreeVisitor.Follow._MODE_in_mode667 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_mode669 = new BitSet(new ulong[2]
        {
          8UL,
          536870912UL
        });
        GrammarTreeVisitor.Follow._lexerRule_in_mode673 = new BitSet(new ulong[2]
        {
          8UL,
          536870912UL
        });
        GrammarTreeVisitor.Follow._RULE_in_lexerRule699 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._TOKEN_REF_in_lexerRule701 = new BitSet(new ulong[2]
        {
          0UL,
          2147491840UL
        });
        GrammarTreeVisitor.Follow._RULEMODIFIERS_in_lexerRule713 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._FRAGMENT_in_lexerRule717 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._lexerRuleBlock_in_lexerRule742 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._RULE_in_rule789 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._RULE_REF_in_rule791 = new BitSet(new ulong[2]
        {
          36033203655411968UL,
          2147491841UL
        });
        GrammarTreeVisitor.Follow._RULEMODIFIERS_in_rule800 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ruleModifier_in_rule805 = new BitSet(new ulong[1]
        {
          1970324853751816UL
        });
        GrammarTreeVisitor.Follow._ARG_ACTION_in_rule816 = new BitSet(new ulong[2]
        {
          36033203655411712UL,
          8193UL
        });
        GrammarTreeVisitor.Follow._ruleReturns_in_rule829 = new BitSet(new ulong[2]
        {
          4406636447744UL,
          8193UL
        });
        GrammarTreeVisitor.Follow._throwsSpec_in_rule842 = new BitSet(new ulong[2]
        {
          4406636447744UL,
          8192UL
        });
        GrammarTreeVisitor.Follow._locals_in_rule855 = new BitSet(new ulong[2]
        {
          4398046513152UL,
          8192UL
        });
        GrammarTreeVisitor.Follow._optionsSpec_in_rule870 = new BitSet(new ulong[2]
        {
          4398046513152UL,
          8192UL
        });
        GrammarTreeVisitor.Follow._ruleAction_in_rule884 = new BitSet(new ulong[2]
        {
          4398046513152UL,
          8192UL
        });
        GrammarTreeVisitor.Follow._ruleBlock_in_rule915 = new BitSet(new ulong[1]
        {
          8392712UL
        });
        GrammarTreeVisitor.Follow._exceptionGroup_in_rule917 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._exceptionHandler_in_exceptionGroup964 = new BitSet(new ulong[1]
        {
          8392706UL
        });
        GrammarTreeVisitor.Follow._finallyClause_in_exceptionGroup967 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._CATCH_in_exceptionHandler993 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ARG_ACTION_in_exceptionHandler995 = new BitSet(new ulong[1]
        {
          16UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_exceptionHandler997 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._FINALLY_in_finallyClause1022 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_finallyClause1024 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._LOCALS_in_locals1052 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ARG_ACTION_in_locals1054 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._RETURNS_in_ruleReturns1077 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ARG_ACTION_in_ruleReturns1079 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._THROWS_in_throwsSpec1105 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_throwsSpec1107 = new BitSet(new ulong[1]
        {
          268435464UL
        });
        GrammarTreeVisitor.Follow._AT_in_ruleAction1134 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_ruleAction1136 = new BitSet(new ulong[1]
        {
          16UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_ruleAction1138 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._BLOCK_in_lexerRuleBlock1216 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._lexerOuterAlternative_in_lexerRuleBlock1235 = new BitSet(new ulong[2]
        {
          8UL,
          4194816UL
        });
        GrammarTreeVisitor.Follow._BLOCK_in_ruleBlock1280 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._outerAlternative_in_ruleBlock1299 = new BitSet(new ulong[2]
        {
          8UL,
          512UL
        });
        GrammarTreeVisitor.Follow._lexerAlternative_in_lexerOuterAlternative1339 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._alternative_in_outerAlternative1362 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._LEXER_ALT_ACTION_in_lexerAlternative1384 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._lexerElements_in_lexerAlternative1386 = new BitSet(new ulong[2]
        {
          268435456UL,
          2097152UL
        });
        GrammarTreeVisitor.Follow._lexerCommand_in_lexerAlternative1388 = new BitSet(new ulong[2]
        {
          268435464UL,
          2097152UL
        });
        GrammarTreeVisitor.Follow._lexerElements_in_lexerAlternative1400 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ALT_in_lexerElements1428 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._lexerElement_in_lexerElements1430 = new BitSet(new ulong[2]
        {
          5336836481228997656UL,
          43000307716UL
        });
        GrammarTreeVisitor.Follow._labeledLexerElement_in_lexerElement1456 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._lexerAtom_in_lexerElement1461 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._lexerSubrule_in_lexerElement1466 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_lexerElement1473 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_lexerElement1487 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_lexerElement1502 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_lexerElement1504 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_lexerElement1515 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_lexerElement1517 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._EPSILON_in_lexerElement1525 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._set_in_labeledLexerElement1552 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_labeledLexerElement1558 = new BitSet(new ulong[2]
        {
          4760305360181395456UL,
          42949681156UL
        });
        GrammarTreeVisitor.Follow._lexerAtom_in_labeledLexerElement1561 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._block_in_labeledLexerElement1563 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._BLOCK_in_lexerBlock1588 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._optionsSpec_in_lexerBlock1590 = new BitSet(new ulong[2]
        {
          0UL,
          4194816UL
        });
        GrammarTreeVisitor.Follow._lexerAlternative_in_lexerBlock1593 = new BitSet(new ulong[2]
        {
          8UL,
          4194816UL
        });
        GrammarTreeVisitor.Follow._terminal_in_lexerAtom1624 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._NOT_in_lexerAtom1635 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._blockSet_in_lexerAtom1637 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._blockSet_in_lexerAtom1648 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._WILDCARD_in_lexerAtom1659 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_lexerAtom1661 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._WILDCARD_in_lexerAtom1672 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._LEXER_CHAR_SET_in_lexerAtom1680 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._range_in_lexerAtom1690 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ruleref_in_lexerAtom1700 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_actionElement1724 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_actionElement1732 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_actionElement1734 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_actionElement1742 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_actionElement1750 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_actionElement1752 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ALT_in_alternative1775 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_alternative1777 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000045572UL
        });
        GrammarTreeVisitor.Follow._element_in_alternative1780 = new BitSet(new ulong[2]
        {
          5336836476935078936UL,
          43000045572UL
        });
        GrammarTreeVisitor.Follow._ALT_in_alternative1788 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_alternative1790 = new BitSet(new ulong[2]
        {
          0UL,
          262144UL
        });
        GrammarTreeVisitor.Follow._EPSILON_in_alternative1793 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._LEXER_ACTION_CALL_in_lexerCommand1819 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_lexerCommand1821 = new BitSet(new ulong[1]
        {
          1342177280UL
        });
        GrammarTreeVisitor.Follow._lexerCommandExpr_in_lexerCommand1823 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ID_in_lexerCommand1839 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._labeledElement_in_element1896 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._atom_in_element1901 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._subrule_in_element1906 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_element1913 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_element1927 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_element1942 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_element1944 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._SEMPRED_in_element1955 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_element1957 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._range_in_element1965 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._NOT_in_element1971 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._blockSet_in_element1973 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._NOT_in_element1980 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._block_in_element1982 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._atom_in_astOperand2004 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._NOT_in_astOperand2010 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._blockSet_in_astOperand2012 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._NOT_in_astOperand2019 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._block_in_astOperand2021 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._set_in_labeledElement2044 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_labeledElement2050 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000045572UL
        });
        GrammarTreeVisitor.Follow._element_in_labeledElement2052 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._blockSuffix_in_subrule2077 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._block_in_subrule2079 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._block_in_subrule2086 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._blockSuffix_in_lexerSubrule2111 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._lexerBlock_in_lexerSubrule2113 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._lexerBlock_in_lexerSubrule2120 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ebnfSuffix_in_blockSuffix2147 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._DOT_in_atom2208 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_atom2210 = new BitSet(new ulong[2]
        {
          4611686018427387904UL,
          4UL
        });
        GrammarTreeVisitor.Follow._terminal_in_atom2212 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._DOT_in_atom2219 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_atom2221 = new BitSet(new ulong[1]
        {
          144115188075855872UL
        });
        GrammarTreeVisitor.Follow._ruleref_in_atom2223 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._WILDCARD_in_atom2233 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_atom2235 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._WILDCARD_in_atom2246 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._terminal_in_atom2262 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._blockSet_in_atom2270 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ruleref_in_atom2280 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._SET_in_blockSet2305 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._setElement_in_blockSet2307 = new BitSet(new ulong[2]
        {
          4616189622349725704UL,
          4UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2331 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_setElement2333 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._TOKEN_REF_in_setElement2345 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_setElement2347 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2357 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._TOKEN_REF_in_setElement2382 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._RANGE_in_setElement2411 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2415 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_setElement2419 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._LEXER_CHAR_SET_in_setElement2442 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._BLOCK_in_block2467 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._optionsSpec_in_block2469 = new BitSet(new ulong[2]
        {
          2064UL,
          512UL
        });
        GrammarTreeVisitor.Follow._ruleAction_in_block2472 = new BitSet(new ulong[2]
        {
          2064UL,
          512UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_block2475 = new BitSet(new ulong[2]
        {
          0UL,
          512UL
        });
        GrammarTreeVisitor.Follow._alternative_in_block2478 = new BitSet(new ulong[2]
        {
          8UL,
          512UL
        });
        GrammarTreeVisitor.Follow._RULE_REF_in_ruleref2508 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ARG_ACTION_in_ruleref2512 = new BitSet(new ulong[2]
        {
          8UL,
          131072UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_ruleref2515 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._RANGE_in_range2552 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_range2554 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_range2556 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_terminal2586 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_terminal2588 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_terminal2611 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._TOKEN_REF_in_terminal2625 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOptions_in_terminal2627 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._TOKEN_REF_in_terminal2638 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ELEMENT_OPTIONS_in_elementOptions2675 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._elementOption_in_elementOptions2677 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2708 = new BitSet(new ulong[1]
        {
          2UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2728 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2732 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2736 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2752 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2754 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        GrammarTreeVisitor.Follow._STRING_LITERAL_in_elementOption2758 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2772 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2774 = new BitSet(new ulong[1]
        {
          16UL
        });
        GrammarTreeVisitor.Follow._ACTION_in_elementOption2778 = new BitSet(new ulong[1]
        {
          8UL
        });
        GrammarTreeVisitor.Follow._ASSIGN_in_elementOption2794 = new BitSet(new ulong[1]
        {
          4UL
        });
        GrammarTreeVisitor.Follow._ID_in_elementOption2796 = new BitSet(new ulong[1]
        {
          1073741824UL
        });
        GrammarTreeVisitor.Follow._INT_in_elementOption2800 = new BitSet(new ulong[1]
        {
          8UL
        });
      }
    }
  }
}
