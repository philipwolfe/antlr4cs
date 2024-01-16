// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.BlockSetTransformer
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

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class BlockSetTransformer : TreeRewriter
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
    private ITreeAdaptor adaptor;
    public string currentRuleName;
    public GrammarAST currentAlt;
    public Grammar g;
    private BlockSetTransformer.DFA10 dfa10;

    public BlockSetTransformer(ITreeNodeStream input) : this(input, new RecognizerSharedState())
    {
      
    }

    public BlockSetTransformer(ITreeNodeStream input, RecognizerSharedState state): base(input, state)
    {
      
      this.TreeAdaptor = (ITreeAdaptor) null ?? (ITreeAdaptor) new CommonTreeAdaptor();
    }

    public ITreeAdaptor TreeAdaptor
    {
      get
      {
        return this.adaptor;
      }
      set
      {
        this.adaptor = value;
      }
    }

    public override string[] TokenNames
    {
      get
      {
        return BlockSetTransformer.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\BlockSetTransformer.g3";
      }
    }

    public BlockSetTransformer(ITreeNodeStream input, Grammar g): this(input, new RecognizerSharedState())
    {
      
      this.g = g;
    }

    protected override IAstRuleReturnScope Topdown()
    {
      return (IAstRuleReturnScope) this.topdown();
    }

    [GrammarRule("topdown")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> topdown()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope1 = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      GrammarAST grammarAst3 = (GrammarAST) null;
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 73:
                num1 = 2;
                break;
              case 77:
                num1 = 4;
                break;
              case 79:
              case 88:
              case 89:
                num1 = 3;
                break;
              case 93:
                num1 = 1;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 3, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return treeRuleReturnScope1;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST grammarAst4 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst5 = (GrammarAST) null;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst6 = (GrammarAST) this.Match((IIntStream) this.input, 93, BlockSetTransformer.Follow._RULE_in_topdown91);
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst6;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              int num2 = 2;
              try
              {
                try
                {
                  switch (this.input.LA(1))
                  {
                    case 57:
                      num2 = 2;
                      break;
                    case 66:
                      num2 = 1;
                      break;
                    default:
                      if (this.state.backtracking <= 0)
                        throw new NoViableAltException("", 1, 0, (IIntStream) this.input, 1);
                      this.state.failed = true;
                      return treeRuleReturnScope1;
                  }
                }
                finally
                {
                }
                switch (num2)
                {
                  case 1:
                    grammarAst2 = (GrammarAST) this.input.LT(1);
                    grammarAst3 = (GrammarAST) this.Match((IIntStream) this.input, 66, BlockSetTransformer.Follow._TOKEN_REF_in_topdown96);
                    if (this.state.failed)
                      return treeRuleReturnScope1;
                    if (this.state.backtracking == 1 && grammarAst5 == null)
                      grammarAst5 = grammarAst3;
                    if (this.state.backtracking == 1)
                    {
                      treeRuleReturnScope1.Tree = grammarAst1;
                      if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                      {
                        if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                        {
                          treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                          break;
                        }
                        break;
                      }
                      break;
                    }
                    break;
                  case 2:
                    grammarAst2 = (GrammarAST) this.input.LT(1);
                    grammarAst3 = (GrammarAST) this.Match((IIntStream) this.input, 57, BlockSetTransformer.Follow._RULE_REF_in_topdown100);
                    if (this.state.failed)
                      return treeRuleReturnScope1;
                    if (this.state.backtracking == 1 && grammarAst5 == null)
                      grammarAst5 = grammarAst3;
                    if (this.state.backtracking == 1)
                    {
                      treeRuleReturnScope1.Tree = grammarAst1;
                      if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                      {
                        if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                        {
                          treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                          break;
                        }
                        break;
                      }
                      break;
                    }
                    break;
                }
              }
              finally
              {
              }
              if (this.state.backtracking == 1)
                this.currentRuleName = grammarAst3?.Text;
              int num3 = 0;
              try
              {
                while (true)
                {
                  int num4 = 2;
                  try
                  {
                    int num5 = this.input.LA(1);
                    if (num5 >= 4 && num5 <= 99)
                      num4 = 1;
                    else if (num5 == 3)
                      num4 = 2;
                  }
                  finally
                  {
                  }
                  if (num4 == 1)
                  {
                    grammarAst2 = (GrammarAST) this.input.LT(1);
                    GrammarAST grammarAst7 = (GrammarAST) this.input.LT(1);
                    this.MatchAny((IIntStream) this.input);
                    if (!this.state.failed)
                    {
                      if (this.state.backtracking == 1 && grammarAst5 == null)
                        grammarAst5 = grammarAst7;
                      if (this.state.backtracking == 1)
                      {
                        treeRuleReturnScope1.Tree = grammarAst1;
                        if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null && this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                          treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      }
                      ++num3;
                    }
                    else
                      break;
                  }
                  else
                    goto label_61;
                }
                return treeRuleReturnScope1;
label_61:
                if (num3 < 1)
                {
                  if (this.state.backtracking <= 0)
                    throw new EarlyExitException(2, (IIntStream) this.input);
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              grammarAst2 = grammarAst4;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                  {
                    treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 2:
              grammarAst2 = (GrammarAST) this.input.LT(1);
              this.PushFollow(BlockSetTransformer.Follow._setAlt_in_topdown115);
              AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope2 = this.setAlt();
              this.PopFollow();
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = treeRuleReturnScope2.Tree;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                  {
                    treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 3:
              grammarAst2 = (GrammarAST) this.input.LT(1);
              this.PushFollow(BlockSetTransformer.Follow._ebnfBlockSet_in_topdown123);
              AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope3 = this.ebnfBlockSet();
              this.PopFollow();
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = treeRuleReturnScope3.Tree;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                  {
                    treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 4:
              grammarAst2 = (GrammarAST) this.input.LT(1);
              this.PushFollow(BlockSetTransformer.Follow._blockSet_in_topdown131);
              AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope4 = this.blockSet();
              this.PopFollow();
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = treeRuleReturnScope4.Tree;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                  {
                    treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
          }
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

    [GrammarRule("setAlt")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> setAlt()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      try
      {
        try
        {
          if (!this.InContext("RULE BLOCK"))
          {
            if (this.state.backtracking <= 0)
              throw new FailedPredicateException((IIntStream) this.input, nameof (setAlt), "this.InContext(\"RULE BLOCK\")");
            this.state.failed = true;
            return treeRuleReturnScope;
          }
          grammarAst2 = (GrammarAST) this.input.LT(1);
          GrammarAST grammarAst3 = (GrammarAST) this.Match((IIntStream) this.input, 73, BlockSetTransformer.Follow._ALT_in_setAlt146);
          if (this.state.failed)
            return treeRuleReturnScope;
          if (this.state.backtracking == 1 && grammarAst1 == null)
            grammarAst1 = grammarAst3;
          if (this.state.backtracking == 1)
            this.currentAlt = treeRuleReturnScope.Start;
          if (this.state.backtracking == 1)
          {
            treeRuleReturnScope.Tree = grammarAst1;
            if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
            {
              if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
            }
          }
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

    [GrammarRule("ebnfBlockSet")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> ebnfBlockSet()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope1 = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      GrammarAST grammarAst3 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule ebnfSuffix");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule blockSet");
      try
      {
        try
        {
          GrammarAST grammarAst4 = (GrammarAST) this.input.LT(1);
          grammarAst3 = (GrammarAST) this.input.LT(1);
          this.PushFollow(BlockSetTransformer.Follow._ebnfSuffix_in_ebnfBlockSet166);
          AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope2 = this.ebnfSuffix();
          this.PopFollow();
          if (this.state.failed)
            return treeRuleReturnScope1;
          if (this.state.backtracking == 1)
            ruleSubtreeStream1.Add((object) treeRuleReturnScope2.Tree);
          if (this.state.backtracking == 1 && grammarAst2 == null)
          {
            GrammarAST tree = treeRuleReturnScope2.Tree;
          }
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return treeRuleReturnScope1;
          grammarAst3 = (GrammarAST) this.input.LT(1);
          this.PushFollow(BlockSetTransformer.Follow._blockSet_in_ebnfBlockSet168);
          AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope3 = this.blockSet();
          this.PopFollow();
          if (this.state.failed)
            return treeRuleReturnScope1;
          if (this.state.backtracking == 1)
            ruleSubtreeStream2.Add((object) treeRuleReturnScope3.Tree);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed)
            return treeRuleReturnScope1;
          GrammarAST t = grammarAst4;
          if (this.state.backtracking == 1)
          {
            treeRuleReturnScope1.Tree = grammarAst1;
            RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) treeRuleReturnScope1?.Tree);
            GrammarAST grammarAst5 = (GrammarAST) this.adaptor.Nil();
            GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
            GrammarAST grammarAst6 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream1.NextNode(), (object) oldRoot);
            GrammarAST grammarAst7 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77), (object) (GrammarAST) this.adaptor.Nil());
            GrammarAST grammarAst8 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
            this.adaptor.AddChild((object) grammarAst8, ruleSubtreeStream2.NextTree());
            this.adaptor.AddChild((object) grammarAst7, (object) grammarAst8);
            this.adaptor.AddChild((object) grammarAst6, (object) grammarAst7);
            this.adaptor.AddChild((object) grammarAst5, (object) grammarAst6);
            treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst5);
            if (treeRuleReturnScope1.Tree != null)
              this.input.ReplaceChildren(this.adaptor.GetParent((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) t), (object) treeRuleReturnScope1.Tree);
          }
          if (this.state.backtracking == 1)
            GrammarTransformPipeline.SetGrammarPtr(this.g, treeRuleReturnScope1.Tree);
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

    [GrammarRule("ebnfSuffix")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> ebnfSuffix()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      GrammarAST grammarAst3 = (GrammarAST) null;
      try
      {
        try
        {
          grammarAst2 = (GrammarAST) this.input.LT(1);
          grammarAst3 = (GrammarAST) this.input.LT(1);
          if (this.input.LA(1) == 79 || this.input.LA(1) >= 88 && this.input.LA(1) <= 89)
          {
            this.input.Consume();
            this.state.errorRecovery = false;
            this.state.failed = false;
            if (this.state.backtracking == 1)
            {
              treeRuleReturnScope.Tree = grammarAst1;
              if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null && this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
            }
            if (this.state.backtracking == 1)
              treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.DupNode((object) treeRuleReturnScope.Start);
          }
          else
          {
            if (this.state.backtracking <= 0)
              throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
            this.state.failed = true;
            return treeRuleReturnScope;
          }
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
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> blockSet()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope1 = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      GrammarAST grammarAst3 = (GrammarAST) null;
      RewriteRuleNodeStream rewriteRuleNodeStream1 = new RewriteRuleNodeStream(this.adaptor, "token BLOCK");
      RewriteRuleNodeStream rewriteRuleNodeStream2 = new RewriteRuleNodeStream(this.adaptor, "token ALT");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule setElement");
      bool inLexer = Grammar.IsTokenName(this.currentRuleName);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            num1 = this.dfa10.Predict((IIntStream) this.input);
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
              if (!this.InContext("RULE"))
              {
                if (this.state.backtracking <= 0)
                  throw new FailedPredicateException((IIntStream) this.input, nameof (blockSet), "this.InContext(\"RULE\")");
                this.state.failed = true;
                return treeRuleReturnScope1;
              }
              GrammarAST grammarAst4 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst5 = (GrammarAST) null;
              grammarAst3 = (GrammarAST) this.input.LT(1);
              GrammarAST el1 = (GrammarAST) this.Match((IIntStream) this.input, 77, BlockSetTransformer.Follow._BLOCK_in_blockSet253);
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                rewriteRuleNodeStream1.Add((object) el1);
              if (this.state.backtracking == 1 && grammarAst2 == null)
                grammarAst2 = el1;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              GrammarAST grammarAst6 = (GrammarAST) this.input.LT(1);
              grammarAst3 = (GrammarAST) this.input.LT(1);
              GrammarAST el2 = (GrammarAST) this.Match((IIntStream) this.input, 73, BlockSetTransformer.Follow._ALT_in_blockSet258);
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                rewriteRuleNodeStream2.Add((object) el2);
              if (this.state.backtracking == 1 && grammarAst5 == null)
                grammarAst5 = el2;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
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
                  grammarAst3 = (GrammarAST) this.input.LT(1);
                  this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_blockSet260);
                  AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope2 = this.elementOptions();
                  this.PopFollow();
                  if (this.state.failed)
                    return treeRuleReturnScope1;
                  if (this.state.backtracking == 1)
                    ruleSubtreeStream1.Add((object) treeRuleReturnScope2.Tree);
                  if (this.state.backtracking == 1)
                  {
                    treeRuleReturnScope1.Tree = grammarAst2;
                    if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                    {
                      if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                        treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    }
                  }
                }
              }
              finally
              {
              }
              if (((AltAST) el2).altLabel != null)
              {
                if (this.state.backtracking <= 0)
                  throw new FailedPredicateException((IIntStream) this.input, nameof (blockSet), "((AltAST)$alt).altLabel==null");
                this.state.failed = true;
                return treeRuleReturnScope1;
              }
              grammarAst3 = (GrammarAST) this.input.LT(1);
              this.PushFollow(BlockSetTransformer.Follow._setElement_in_blockSet265);
              AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope3 = this.setElement(inLexer);
              this.PopFollow();
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                ruleSubtreeStream2.Add((object) treeRuleReturnScope3.Tree);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              grammarAst3 = grammarAst6;
              int num3 = 0;
              try
              {
                while (true)
                {
                  int num4 = 2;
                  try
                  {
                    if (this.input.LA(1) == 73)
                      num4 = 1;
                  }
                  finally
                  {
                  }
                  if (num4 == 1)
                  {
                    GrammarAST grammarAst7 = (GrammarAST) this.input.LT(1);
                    grammarAst3 = (GrammarAST) this.input.LT(1);
                    GrammarAST el3 = (GrammarAST) this.Match((IIntStream) this.input, 73, BlockSetTransformer.Follow._ALT_in_blockSet272);
                    if (!this.state.failed)
                    {
                      if (this.state.backtracking == 1)
                        rewriteRuleNodeStream2.Add((object) el3);
                      if (this.state.backtracking == 1 && grammarAst5 == null)
                        grammarAst5 = el3;
                      this.Match((IIntStream) this.input, 2, (BitSet) null);
                      if (!this.state.failed)
                      {
                        int num5 = 2;
                        try
                        {
                          try
                          {
                            if (this.input.LA(1) == 81)
                              num5 = 1;
                          }
                          finally
                          {
                          }
                          if (num5 == 1)
                          {
                            grammarAst3 = (GrammarAST) this.input.LT(1);
                            this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_blockSet274);
                            AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope4 = this.elementOptions();
                            this.PopFollow();
                            if (this.state.failed)
                              return treeRuleReturnScope1;
                            if (this.state.backtracking == 1)
                              ruleSubtreeStream1.Add((object) treeRuleReturnScope4.Tree);
                            if (this.state.backtracking == 1)
                            {
                              treeRuleReturnScope1.Tree = grammarAst2;
                              if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                              {
                                if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                                  treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                              }
                            }
                          }
                        }
                        finally
                        {
                        }
                        grammarAst3 = (GrammarAST) this.input.LT(1);
                        this.PushFollow(BlockSetTransformer.Follow._setElement_in_blockSet277);
                        AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope5 = this.setElement(inLexer);
                        this.PopFollow();
                        if (!this.state.failed)
                        {
                          if (this.state.backtracking == 1)
                            ruleSubtreeStream2.Add((object) treeRuleReturnScope5.Tree);
                          this.Match((IIntStream) this.input, 3, (BitSet) null);
                          if (!this.state.failed)
                          {
                            grammarAst3 = grammarAst7;
                            if (this.state.backtracking == 1)
                            {
                              treeRuleReturnScope1.Tree = grammarAst2;
                              if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null && this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                            }
                            ++num3;
                          }
                          else
                            goto label_83;
                        }
                        else
                          goto label_79;
                      }
                      else
                        goto label_63;
                    }
                    else
                      break;
                  }
                  else
                    goto label_87;
                }
                return treeRuleReturnScope1;
label_63:
                return treeRuleReturnScope1;
label_79:
                return treeRuleReturnScope1;
label_83:
                return treeRuleReturnScope1;
label_87:
                if (num3 < 1)
                {
                  if (this.state.backtracking <= 0)
                    throw new EarlyExitException(6, (IIntStream) this.input);
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              GrammarAST t1 = grammarAst4;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) treeRuleReturnScope1?.Tree);
                GrammarAST grammarAst8 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst9 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, el1.Token), (object) oldRoot1);
                GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst10 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73, el1.Token, "ALT"), (object) oldRoot2);
                GrammarAST oldRoot3 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst11 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(97, el1.Token, "SET"), (object) oldRoot3);
                if (!ruleSubtreeStream2.HasNext)
                  throw new RewriteEarlyExitException();
                while (ruleSubtreeStream2.HasNext)
                  this.adaptor.AddChild((object) grammarAst11, ruleSubtreeStream2.NextTree());
                ruleSubtreeStream2.Reset();
                this.adaptor.AddChild((object) grammarAst10, (object) grammarAst11);
                this.adaptor.AddChild((object) grammarAst9, (object) grammarAst10);
                this.adaptor.AddChild((object) grammarAst8, (object) grammarAst9);
                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst8);
                if (treeRuleReturnScope1.Tree != null)
                {
                  this.input.ReplaceChildren(this.adaptor.GetParent((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) t1), (object) treeRuleReturnScope1.Tree);
                  break;
                }
                break;
              }
              break;
            case 2:
              if (this.InContext("RULE"))
              {
                if (this.state.backtracking <= 0)
                  throw new FailedPredicateException((IIntStream) this.input, nameof (blockSet), "!this.InContext(\"RULE\")");
                this.state.failed = true;
                return treeRuleReturnScope1;
              }
              GrammarAST grammarAst12 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst13 = (GrammarAST) null;
              grammarAst3 = (GrammarAST) this.input.LT(1);
              GrammarAST el4 = (GrammarAST) this.Match((IIntStream) this.input, 77, BlockSetTransformer.Follow._BLOCK_in_blockSet326);
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                rewriteRuleNodeStream1.Add((object) el4);
              if (this.state.backtracking == 1 && grammarAst2 == null)
                grammarAst2 = el4;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              GrammarAST grammarAst14 = (GrammarAST) this.input.LT(1);
              grammarAst3 = (GrammarAST) this.input.LT(1);
              GrammarAST el5 = (GrammarAST) this.Match((IIntStream) this.input, 73, BlockSetTransformer.Follow._ALT_in_blockSet329);
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                rewriteRuleNodeStream2.Add((object) el5);
              if (this.state.backtracking == 1 && grammarAst13 == null)
                grammarAst13 = el5;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
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
                  grammarAst3 = (GrammarAST) this.input.LT(1);
                  this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_blockSet331);
                  AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope6 = this.elementOptions();
                  this.PopFollow();
                  if (this.state.failed)
                    return treeRuleReturnScope1;
                  if (this.state.backtracking == 1)
                    ruleSubtreeStream1.Add((object) treeRuleReturnScope6.Tree);
                  if (this.state.backtracking == 1)
                  {
                    treeRuleReturnScope1.Tree = grammarAst2;
                    if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                    {
                      if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                        treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                    }
                  }
                }
              }
              finally
              {
              }
              grammarAst3 = (GrammarAST) this.input.LT(1);
              this.PushFollow(BlockSetTransformer.Follow._setElement_in_blockSet334);
              AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope7 = this.setElement(inLexer);
              this.PopFollow();
              if (this.state.failed)
                return treeRuleReturnScope1;
              if (this.state.backtracking == 1)
                ruleSubtreeStream2.Add((object) treeRuleReturnScope7.Tree);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              grammarAst3 = grammarAst14;
              int num7 = 0;
              try
              {
                while (true)
                {
                  int num8 = 2;
                  try
                  {
                    if (this.input.LA(1) == 73)
                      num8 = 1;
                  }
                  finally
                  {
                  }
                  if (num8 == 1)
                  {
                    GrammarAST grammarAst15 = (GrammarAST) this.input.LT(1);
                    grammarAst3 = (GrammarAST) this.input.LT(1);
                    GrammarAST el6 = (GrammarAST) this.Match((IIntStream) this.input, 73, BlockSetTransformer.Follow._ALT_in_blockSet341);
                    if (!this.state.failed)
                    {
                      if (this.state.backtracking == 1)
                        rewriteRuleNodeStream2.Add((object) el6);
                      if (this.state.backtracking == 1 && grammarAst13 == null)
                        grammarAst13 = el6;
                      this.Match((IIntStream) this.input, 2, (BitSet) null);
                      if (!this.state.failed)
                      {
                        int num9 = 2;
                        try
                        {
                          try
                          {
                            if (this.input.LA(1) == 81)
                              num9 = 1;
                          }
                          finally
                          {
                          }
                          if (num9 == 1)
                          {
                            grammarAst3 = (GrammarAST) this.input.LT(1);
                            this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_blockSet343);
                            AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope8 = this.elementOptions();
                            this.PopFollow();
                            if (this.state.failed)
                              return treeRuleReturnScope1;
                            if (this.state.backtracking == 1)
                              ruleSubtreeStream1.Add((object) treeRuleReturnScope8.Tree);
                            if (this.state.backtracking == 1)
                            {
                              treeRuleReturnScope1.Tree = grammarAst2;
                              if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                              {
                                if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                                  treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                              }
                            }
                          }
                        }
                        finally
                        {
                        }
                        grammarAst3 = (GrammarAST) this.input.LT(1);
                        this.PushFollow(BlockSetTransformer.Follow._setElement_in_blockSet346);
                        AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope9 = this.setElement(inLexer);
                        this.PopFollow();
                        if (!this.state.failed)
                        {
                          if (this.state.backtracking == 1)
                            ruleSubtreeStream2.Add((object) treeRuleReturnScope9.Tree);
                          this.Match((IIntStream) this.input, 3, (BitSet) null);
                          if (!this.state.failed)
                          {
                            grammarAst3 = grammarAst15;
                            if (this.state.backtracking == 1)
                            {
                              treeRuleReturnScope1.Tree = grammarAst2;
                              if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null && this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                            }
                            ++num7;
                          }
                          else
                            goto label_175;
                        }
                        else
                          goto label_171;
                      }
                      else
                        goto label_155;
                    }
                    else
                      break;
                  }
                  else
                    goto label_179;
                }
                return treeRuleReturnScope1;
label_155:
                return treeRuleReturnScope1;
label_171:
                return treeRuleReturnScope1;
label_175:
                return treeRuleReturnScope1;
label_179:
                if (num7 < 1)
                {
                  if (this.state.backtracking <= 0)
                    throw new EarlyExitException(9, (IIntStream) this.input);
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope1;
              GrammarAST t2 = grammarAst12;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) treeRuleReturnScope1?.Tree);
                GrammarAST grammarAst16 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst17 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(97, el4.Token, "SET"), (object) oldRoot);
                if (!ruleSubtreeStream2.HasNext)
                  throw new RewriteEarlyExitException();
                while (ruleSubtreeStream2.HasNext)
                  this.adaptor.AddChild((object) grammarAst17, ruleSubtreeStream2.NextTree());
                ruleSubtreeStream2.Reset();
                this.adaptor.AddChild((object) grammarAst16, (object) grammarAst17);
                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst16);
                if (treeRuleReturnScope1.Tree != null)
                {
                  this.input.ReplaceChildren(this.adaptor.GetParent((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) treeRuleReturnScope1.Start), this.adaptor.GetChildIndex((object) t2), (object) treeRuleReturnScope1.Tree);
                  break;
                }
                break;
              }
              break;
          }
          if (this.state.backtracking == 1)
            GrammarTransformPipeline.SetGrammarPtr(this.g, treeRuleReturnScope1.Tree);
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

    [GrammarRule("setElement")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> setElement(bool inLexer)
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope1 = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      try
      {
        try
        {
          int num1 = 5;
          try
          {
            try
            {
              int num2 = this.input.LA(1);
              switch (num2)
              {
                case 62:
                  switch (this.input.LA(2))
                  {
                    case 2:
                      num1 = 1;
                      goto label_23;
                    case 3:
                      num1 = 2;
                      goto label_23;
                    default:
                      if (this.state.backtracking <= 0)
                        throw new NoViableAltException("", 11, 1, (IIntStream) this.input, 2);
                      this.state.failed = true;
                      return treeRuleReturnScope1;
                  }
                case 66:
                  if (!inLexer)
                  {
                    int num3 = this.input.LA(2);
                    if (num3 == 2 && !inLexer)
                    {
                      num1 = 3;
                      goto label_23;
                    }
                    else if (num3 == 3 && !inLexer)
                    {
                      num1 = 4;
                      goto label_23;
                    }
                    else
                    {
                      if (this.state.backtracking <= 0)
                        throw new NoViableAltException("", 11, 2, (IIntStream) this.input, 2);
                      this.state.failed = true;
                      return treeRuleReturnScope1;
                    }
                  }
                  else
                    break;
              }
              if (num2 == 52 & inLexer)
              {
                num1 = 5;
              }
              else
              {
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 11, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return treeRuleReturnScope1;
              }
            }
            finally
            {
            }
label_23:
            switch (num1)
            {
              case 1:
                GrammarAST grammarAst3 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst4 = (GrammarAST) null;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst5 = (GrammarAST) this.Match((IIntStream) this.input, 62, BlockSetTransformer.Follow._STRING_LITERAL_in_setElement386);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst1 == null)
                  grammarAst1 = grammarAst5;
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_setElement388);
                AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope2 = this.elementOptions();
                this.PopFollow();
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst4 == null)
                {
                  GrammarAST tree1 = treeRuleReturnScope2.Tree;
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = grammarAst3;
                if (inLexer && CharSupport.GetCharValueFromGrammarCharLiteral(grammarAst5.Text) == -1)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), "!inLexer || CharSupport.GetCharValueFromGrammarCharLiteral($a.Text)!=-1");
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                if (this.state.backtracking == 1)
                {
                  treeRuleReturnScope1.Tree = grammarAst1;
                  if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                  {
                    if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                    {
                      treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      break;
                    }
                    break;
                  }
                  break;
                }
                break;
              case 2:
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst6 = (GrammarAST) this.Match((IIntStream) this.input, 62, BlockSetTransformer.Follow._STRING_LITERAL_in_setElement401);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst1 == null)
                  grammarAst1 = grammarAst6;
                if (inLexer && CharSupport.GetCharValueFromGrammarCharLiteral(grammarAst6.Text) == -1)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), "!inLexer || CharSupport.GetCharValueFromGrammarCharLiteral($a.Text)!=-1");
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                if (this.state.backtracking == 1)
                {
                  treeRuleReturnScope1.Tree = grammarAst1;
                  if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                  {
                    if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                    {
                      treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      break;
                    }
                    break;
                  }
                  break;
                }
                break;
              case 3:
                if (inLexer)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), "!inLexer");
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                GrammarAST grammarAst7 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst8 = (GrammarAST) null;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst9 = (GrammarAST) this.Match((IIntStream) this.input, 66, BlockSetTransformer.Follow._TOKEN_REF_in_setElement413);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst1 == null)
                  grammarAst1 = grammarAst9;
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                this.PushFollow(BlockSetTransformer.Follow._elementOptions_in_setElement415);
                AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope3 = this.elementOptions();
                this.PopFollow();
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst8 == null)
                {
                  GrammarAST tree2 = treeRuleReturnScope3.Tree;
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = grammarAst7;
                if (this.state.backtracking == 1)
                {
                  treeRuleReturnScope1.Tree = grammarAst1;
                  if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                  {
                    if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                    {
                      treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      break;
                    }
                    break;
                  }
                  break;
                }
                break;
              case 4:
                if (inLexer)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), "!inLexer");
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst10 = (GrammarAST) this.Match((IIntStream) this.input, 66, BlockSetTransformer.Follow._TOKEN_REF_in_setElement427);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst1 == null)
                  grammarAst1 = grammarAst10;
                if (this.state.backtracking == 1)
                {
                  treeRuleReturnScope1.Tree = grammarAst1;
                  if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                  {
                    if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                    {
                      treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      break;
                    }
                    break;
                  }
                  break;
                }
                break;
              case 5:
                if (!inLexer)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), nameof (inLexer));
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                GrammarAST grammarAst11 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst12 = (GrammarAST) null;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst13 = (GrammarAST) this.Match((IIntStream) this.input, 52, BlockSetTransformer.Follow._RANGE_in_setElement438);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst1 == null)
                  grammarAst1 = grammarAst13;
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst14 = (GrammarAST) this.Match((IIntStream) this.input, 62, BlockSetTransformer.Follow._STRING_LITERAL_in_setElement442);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst12 == null)
                  grammarAst12 = grammarAst14;
                grammarAst2 = (GrammarAST) this.input.LT(1);
                GrammarAST grammarAst15 = (GrammarAST) this.Match((IIntStream) this.input, 62, BlockSetTransformer.Follow._STRING_LITERAL_in_setElement446);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                if (this.state.backtracking == 1 && grammarAst12 == null)
                  ;
                this.Match((IIntStream) this.input, 3, (BitSet) null);
                if (this.state.failed)
                  return treeRuleReturnScope1;
                grammarAst2 = grammarAst11;
                if (CharSupport.GetCharValueFromGrammarCharLiteral(grammarAst14.Text) == -1 || CharSupport.GetCharValueFromGrammarCharLiteral(grammarAst15.Text) == -1)
                {
                  if (this.state.backtracking <= 0)
                    throw new FailedPredicateException((IIntStream) this.input, nameof (setElement), "CharSupport.GetCharValueFromGrammarCharLiteral($a.Text)!=-1 &&\r\n\t\t\t CharSupport.GetCharValueFromGrammarCharLiteral($b.Text)!=-1");
                  this.state.failed = true;
                  return treeRuleReturnScope1;
                }
                if (this.state.backtracking == 1)
                {
                  treeRuleReturnScope1.Tree = grammarAst1;
                  if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
                  {
                    if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                    {
                      treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
                      break;
                    }
                    break;
                  }
                  break;
                }
                break;
            }
          }
          finally
          {
          }
          if (this.state.backtracking == 1)
          {
            treeRuleReturnScope1.Tree = grammarAst1;
            if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null && this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
              treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
          }
          if (this.state.backtracking == 1)
            GrammarTransformPipeline.SetGrammarPtr(this.g, treeRuleReturnScope1.Tree);
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

    [GrammarRule("elementOptions")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> elementOptions()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope1 = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope1.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      try
      {
        try
        {
          GrammarAST grammarAst3 = (GrammarAST) this.input.LT(1);
          GrammarAST grammarAst4 = (GrammarAST) null;
          grammarAst2 = (GrammarAST) this.input.LT(1);
          GrammarAST grammarAst5 = (GrammarAST) this.Match((IIntStream) this.input, 81, BlockSetTransformer.Follow._ELEMENT_OPTIONS_in_elementOptions468);
          if (this.state.failed)
            return treeRuleReturnScope1;
          if (this.state.backtracking == 1 && grammarAst1 == null)
            grammarAst1 = grammarAst5;
          if (this.input.LA(1) == 2)
          {
            this.Match((IIntStream) this.input, 2, (BitSet) null);
            if (this.state.failed)
              return treeRuleReturnScope1;
            try
            {
              while (true)
              {
                do
                {
                  do
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
                      grammarAst2 = (GrammarAST) this.input.LT(1);
                      this.PushFollow(BlockSetTransformer.Follow._elementOption_in_elementOptions470);
                      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope2 = this.elementOption();
                      this.PopFollow();
                      if (this.state.failed)
                        return treeRuleReturnScope1;
                      if (this.state.backtracking == 1 && grammarAst4 == null)
                        grammarAst4 = treeRuleReturnScope2.Tree;
                    }
                    else
                      goto label_21;
                  }
                  while (this.state.backtracking != 1);
                  treeRuleReturnScope1.Tree = grammarAst1;
                }
                while (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) == null || !this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)));
                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
              }
            }
            finally
            {
            }
label_21:
            this.Match((IIntStream) this.input, 3, (BitSet) null);
            if (this.state.failed)
              return treeRuleReturnScope1;
          }
          grammarAst2 = grammarAst3;
          if (this.state.backtracking == 1)
          {
            treeRuleReturnScope1.Tree = grammarAst1;
            if (this.adaptor.GetParent((object) treeRuleReturnScope1.Tree) != null)
            {
              if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope1.Tree)))
                treeRuleReturnScope1.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope1.Tree);
            }
          }
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

    [GrammarRule("elementOption")]
    private AstTreeRuleReturnScope<GrammarAST, GrammarAST> elementOption()
    {
      AstTreeRuleReturnScope<GrammarAST, GrammarAST> treeRuleReturnScope = new AstTreeRuleReturnScope<GrammarAST, GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
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
                if (this.input.LA(2) == 2)
                {
                  if (this.input.LA(3) == 28)
                  {
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
                        if (this.state.backtracking <= 0)
                          throw new NoViableAltException("", 13, 4, (IIntStream) this.input, 4);
                        this.state.failed = true;
                        return treeRuleReturnScope;
                    }
                  }
                  else
                  {
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 13, 3, (IIntStream) this.input, 3);
                    this.state.failed = true;
                    return treeRuleReturnScope;
                  }
                }
                else
                {
                  if (this.state.backtracking <= 0)
                    throw new NoViableAltException("", 13, 2, (IIntStream) this.input, 2);
                  this.state.failed = true;
                  return treeRuleReturnScope;
                }
                break;
              case 28:
                num = 1;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 13, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return treeRuleReturnScope;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst3 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption483);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst3;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                  {
                    treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 2:
              GrammarAST grammarAst4 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst5 = (GrammarAST) null;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst6 = (GrammarAST) this.Match((IIntStream) this.input, 10, BlockSetTransformer.Follow._ASSIGN_in_elementOption489);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst6;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst7 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption493);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst5 == null)
                grammarAst5 = grammarAst7;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst8 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption497);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst5 == null)
                ;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = grammarAst4;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                  {
                    treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 3:
              GrammarAST grammarAst9 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst10 = (GrammarAST) null;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst11 = (GrammarAST) this.Match((IIntStream) this.input, 10, BlockSetTransformer.Follow._ASSIGN_in_elementOption504);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst11;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst12 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption506);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst10 == null)
                grammarAst10 = grammarAst12;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst13 = (GrammarAST) this.Match((IIntStream) this.input, 62, BlockSetTransformer.Follow._STRING_LITERAL_in_elementOption510);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst10 == null)
                ;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = grammarAst9;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                  {
                    treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 4:
              GrammarAST grammarAst14 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst15 = (GrammarAST) null;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst16 = (GrammarAST) this.Match((IIntStream) this.input, 10, BlockSetTransformer.Follow._ASSIGN_in_elementOption517);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst16;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst17 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption519);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst15 == null)
                grammarAst15 = grammarAst17;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst18 = (GrammarAST) this.Match((IIntStream) this.input, 4, BlockSetTransformer.Follow._ACTION_in_elementOption523);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst15 == null)
                ;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = grammarAst14;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                  {
                    treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            case 5:
              GrammarAST grammarAst19 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst20 = (GrammarAST) null;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst21 = (GrammarAST) this.Match((IIntStream) this.input, 10, BlockSetTransformer.Follow._ASSIGN_in_elementOption530);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst1 == null)
                grammarAst1 = grammarAst21;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst22 = (GrammarAST) this.Match((IIntStream) this.input, 28, BlockSetTransformer.Follow._ID_in_elementOption532);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst20 == null)
                grammarAst20 = grammarAst22;
              grammarAst2 = (GrammarAST) this.input.LT(1);
              GrammarAST grammarAst23 = (GrammarAST) this.Match((IIntStream) this.input, 30, BlockSetTransformer.Follow._INT_in_elementOption536);
              if (this.state.failed)
                return treeRuleReturnScope;
              if (this.state.backtracking == 1 && grammarAst20 == null)
                ;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return treeRuleReturnScope;
              grammarAst2 = grammarAst19;
              if (this.state.backtracking == 1)
              {
                treeRuleReturnScope.Tree = grammarAst1;
                if (this.adaptor.GetParent((object) treeRuleReturnScope.Tree) != null)
                {
                  if (this.adaptor.IsNil(this.adaptor.GetParent((object) treeRuleReturnScope.Tree)))
                  {
                    treeRuleReturnScope.Tree = (GrammarAST) this.adaptor.GetParent((object) treeRuleReturnScope.Tree);
                    break;
                  }
                  break;
                }
                break;
              }
              break;
          }
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
      // ISSUE: method pointer
      this.dfa10 = new BlockSetTransformer.DFA10((BaseRecognizer) this, new SpecialStateTransitionHandler(SpecialStateTransition10));
    }

    private int SpecialStateTransition10(DFA dfa, int s, IIntStream _input)
    {
      ITreeNodeStream input = (ITreeNodeStream) _input;
      int stateNumber = s;
      s = -1;
      input.LA(1);
      int index = input.Index;
      if (stateNumber == 0)
      {
        input.Rewind();
        if (this.InContext("RULE"))
          s = 70;
        else if (!this.InContext("RULE"))
          s = 71;
        input.Seek(index);
      }
      if (s >= 0)
        return s;
      if (this.state.backtracking > 0)
      {
        this.state.failed = true;
        return -1;
      }
      NoViableAltException nvae = new NoViableAltException(dfa.Description, 10, stateNumber, (IIntStream) input);
      dfa.Error(nvae);
      throw nvae;
    }

    static BlockSetTransformer()
    {
      BlockSetTransformer.tokenNames = new string[100]
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

    private class DFA10 : DFA
    {
      private const string DFA10_eotS = "|\uFFFF";
      private const string DFA10_eofS = "|\uFFFF";
      private const string DFA10_minS = "\u0001M\u0001\u0002\u0001I\u0001\u0002\u00014\u0004\u0002\u0001\u0003\u0001Q\u0001I\u0001Q\u0001>\u0001\u0003\u0001\u0002\u00014\u0003\u0002\u0001>\u0001\u001C\u0001\u0003\u00014\u0002\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u0001\u0003\u0004\u0002\u0001\u0003\u0001\u0002\u0006\u0003\u0001\u001C\u0002\u0003\u0001Q\u0001\u0003\u0001Q\u0001>\u0001\u001C\u0005\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u00014\u0001\u0002\u0001\0\u0001\u0002\u0001>\u0001\u0004\u0004\u0003\u0001\u001C\u0001\u0003\u0002\uFFFF\n\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u0002\u0003\u0001\u0002\n\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0005\u0003\u0002\u0004\u0010\u0003";
      private const string DFA10_maxS = "\u0001M\u0001\u0002\u0001I\u0001\u0002\u0001Q\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u001C\u0001Q\u0001I\u0001Q\u0001>\u0001\u001C\u0001\u0002\u0001B\u0003\u0002\u0001>\u0002\u001C\u0001Q\u0001\u001C\u0001\u0003\u0001>\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u001C\u0001\u0002\u0006\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001Q\u0001I\u0001Q\u0001>\u0001\u001C\u0001\u0003\u0004\u001C\u0001>\u0001\u001C\u0001\u0002\u0001B\u0001\u0002\u0001\0\u0001\u0002\u0002>\u0004\u0003\u0002\u001C\u0002\uFFFF\u0001\u001C\u0005\u0003\u0004\u001C\u0001>\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0002\u0003\u0004\u001C\u0004\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0004\u001C\u0002>\b\u0003\b\u001C";
      private const string DFA10_acceptS = "F\uFFFF\u0001\u0001\u0001\u00024\uFFFF";
      private const string DFA10_specialS = "<\uFFFF\u0001\0?\uFFFF}>";
      private static readonly string[] DFA10_transitionS;
      private static readonly short[] DFA10_eot;
      private static readonly short[] DFA10_eof;
      private static readonly char[] DFA10_min;
      private static readonly char[] DFA10_max;
      private static readonly short[] DFA10_accept;
      private static readonly short[] DFA10_special;
      private static readonly short[][] DFA10_transition;

      static DFA10()
      {
        BlockSetTransformer.DFA10.DFA10_transitionS = new string[124]
        {
          "\u0001\u0001",
          "\u0001\u0002",
          "\u0001\u0003",
          "\u0001\u0004",
          "\u0001\b\t\uFFFF\u0001\u0006\u0003\uFFFF\u0001\a\u000E\uFFFF\u0001\u0005",
          "\u0001\t",
          "\u0001\n\u0001\v",
          "\u0001\f\u0001\v",
          "\u0001\r",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001\u0011",
          "\u0001\u0012",
          "\u0001\u0013",
          "\u0001\u0014",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001\u0015",
          "\u0001\b\t\uFFFF\u0001\u0006\u0003\uFFFF\u0001\a",
          "\u0001\u0016",
          "\u0001\u0017",
          "\u0001\u0018",
          "\u0001\u0019",
          "\u0001\u001A",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001!\t\uFFFF\u0001\u001F\u0003\uFFFF\u0001 \u000E\uFFFF\u0001\u001E",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u0001%",
          "\u0001(\u0017\uFFFF\u0001&\u0001\uFFFF\u0001)\u001F\uFFFF\u0001'",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001*",
          "\u0001+",
          "\u0001,",
          "\u0001-\u0001.",
          "\u0001/\u0001.",
          "\u00010",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u00011",
          "\u00012",
          "\u0001\v",
          "\u00013",
          "\u00014",
          "\u00015",
          "\u00016",
          "\u00017",
          "\u0001\v",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001;",
          "\u0001<E\uFFFF\u0001\u0012",
          "\u0001=",
          "\u0001>",
          "\u0001?",
          "\u0001\v",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001\u0010\u0006\uFFFF\u0001\u000F\u0011\uFFFF\u0001\u000E",
          "\u0001B\u0017\uFFFF\u0001@\u0001\uFFFF\u0001C\u001F\uFFFF\u0001A",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001D",
          "\u0001!\t\uFFFF\u0001\u001F\u0003\uFFFF\u0001 ",
          "\u0001E",
          "\u0001\uFFFF",
          "\u0001H",
          "\u0001I",
          "\u0001L\u0017\uFFFF\u0001J\u0001\uFFFF\u0001M\u001F\uFFFF\u0001K",
          "\u0001N",
          "\u0001O",
          "\u0001P",
          "\u0001Q",
          "\u0001R",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "",
          "",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V",
          "\u0001Y",
          "\u0001Z",
          "\u0001[",
          "\u0001\\",
          "\u0001]",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001\u001D\u0006\uFFFF\u0001\u001C\u0011\uFFFF\u0001\u001B",
          "\u0001`\u0017\uFFFF\u0001^\u0001\uFFFF\u0001a\u001F\uFFFF\u0001_",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "\u0001b",
          "\u0001c",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V",
          "\u0001d",
          "\u0001e",
          "\u0001.",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u0001$\u0006\uFFFF\u0001#\u0011\uFFFF\u0001\"",
          "\u0001f",
          "\u0001g",
          "\u0001h",
          "\u0001i",
          "\u0001j",
          "\u0001.",
          "\u0001k",
          "\u0001.",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001:\u0006\uFFFF\u00019\u0011\uFFFF\u00018",
          "\u0001n\u0017\uFFFF\u0001l\u0001\uFFFF\u0001o\u001F\uFFFF\u0001m",
          "\u0001r\u0017\uFFFF\u0001p\u0001\uFFFF\u0001s\u001F\uFFFF\u0001q",
          "\u0001t",
          "\u0001u",
          "\u0001v",
          "\u0001w",
          "\u0001x",
          "\u0001y",
          "\u0001z",
          "\u0001{",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "\u0001U\u0006\uFFFF\u0001T\u0011\uFFFF\u0001S",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V",
          "\u0001X\u0006\uFFFF\u0001W\u0011\uFFFF\u0001V"
        };
        BlockSetTransformer.DFA10.DFA10_eot = DFA.UnpackEncodedString("|\uFFFF");
        BlockSetTransformer.DFA10.DFA10_eof = DFA.UnpackEncodedString("|\uFFFF");
        BlockSetTransformer.DFA10.DFA10_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001M\u0001\u0002\u0001I\u0001\u0002\u00014\u0004\u0002\u0001\u0003\u0001Q\u0001I\u0001Q\u0001>\u0001\u0003\u0001\u0002\u00014\u0003\u0002\u0001>\u0001\u001C\u0001\u0003\u00014\u0002\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u0001\u0003\u0004\u0002\u0001\u0003\u0001\u0002\u0006\u0003\u0001\u001C\u0002\u0003\u0001Q\u0001\u0003\u0001Q\u0001>\u0001\u001C\u0005\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u00014\u0001\u0002\u0001\0\u0001\u0002\u0001>\u0001\u0004\u0004\u0003\u0001\u001C\u0001\u0003\u0002\uFFFF\n\u0003\u0001\u0004\u0001\u0003\u0001\u0002\u0002\u0003\u0001\u0002\n\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0005\u0003\u0002\u0004\u0010\u0003");
        BlockSetTransformer.DFA10.DFA10_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001M\u0001\u0002\u0001I\u0001\u0002\u0001Q\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u001C\u0001Q\u0001I\u0001Q\u0001>\u0001\u001C\u0001\u0002\u0001B\u0003\u0002\u0001>\u0002\u001C\u0001Q\u0001\u001C\u0001\u0003\u0001>\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u001C\u0001\u0002\u0006\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001Q\u0001I\u0001Q\u0001>\u0001\u001C\u0001\u0003\u0004\u001C\u0001>\u0001\u001C\u0001\u0002\u0001B\u0001\u0002\u0001\0\u0001\u0002\u0002>\u0004\u0003\u0002\u001C\u0002\uFFFF\u0001\u001C\u0005\u0003\u0004\u001C\u0001>\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0002\u0003\u0004\u001C\u0004\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0004\u001C\u0002>\b\u0003\b\u001C");
        BlockSetTransformer.DFA10.DFA10_accept = DFA.UnpackEncodedString("F\uFFFF\u0001\u0001\u0001\u00024\uFFFF");
        BlockSetTransformer.DFA10.DFA10_special = DFA.UnpackEncodedString("<\uFFFF\u0001\0?\uFFFF}>");
        int length = BlockSetTransformer.DFA10.DFA10_transitionS.Length;
        BlockSetTransformer.DFA10.DFA10_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          BlockSetTransformer.DFA10.DFA10_transition[index] = DFA.UnpackEncodedString(BlockSetTransformer.DFA10.DFA10_transitionS[index]);
      }

      public DFA10(
        BaseRecognizer recognizer,
        SpecialStateTransitionHandler specialStateTransition):base(specialStateTransition)
      {
        
        this.recognizer = recognizer;
        this.decisionNumber = 10;
        this.eot = BlockSetTransformer.DFA10.DFA10_eot;
        this.eof = BlockSetTransformer.DFA10.DFA10_eof;
        this.min = BlockSetTransformer.DFA10.DFA10_min;
        this.max = BlockSetTransformer.DFA10.DFA10_max;
        this.accept = BlockSetTransformer.DFA10.DFA10_accept;
        this.special = BlockSetTransformer.DFA10.DFA10_special;
        this.transition = BlockSetTransformer.DFA10.DFA10_transition;
      }

      public override string Description
      {
        get
        {
          return "61:1: blockSet : ({...}? ^( BLOCK ^(alt= ALT ( elementOptions )? {...}? setElement[inLexer] ) ( ^( ALT ( elementOptions )? setElement[inLexer] ) )+ ) -> ^( BLOCK[$BLOCK.Token] ^( ALT[$BLOCK.Token,\"ALT\"] ^( SET[$BLOCK.Token, \"SET\"] ( setElement )+ ) ) ) |{...}? ^( BLOCK ^( ALT ( elementOptions )? setElement[inLexer] ) ( ^( ALT ( elementOptions )? setElement[inLexer] ) )+ ) -> ^( SET[$BLOCK.Token, \"SET\"] ( setElement )+ ) );";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private static class Follow
    {
      public static readonly BitSet _RULE_in_topdown91;
      public static readonly BitSet _TOKEN_REF_in_topdown96;
      public static readonly BitSet _RULE_REF_in_topdown100;
      public static readonly BitSet _setAlt_in_topdown115;
      public static readonly BitSet _ebnfBlockSet_in_topdown123;
      public static readonly BitSet _blockSet_in_topdown131;
      public static readonly BitSet _ALT_in_setAlt146;
      public static readonly BitSet _ebnfSuffix_in_ebnfBlockSet166;
      public static readonly BitSet _blockSet_in_ebnfBlockSet168;
      public static readonly BitSet _BLOCK_in_blockSet253;
      public static readonly BitSet _ALT_in_blockSet258;
      public static readonly BitSet _elementOptions_in_blockSet260;
      public static readonly BitSet _setElement_in_blockSet265;
      public static readonly BitSet _ALT_in_blockSet272;
      public static readonly BitSet _elementOptions_in_blockSet274;
      public static readonly BitSet _setElement_in_blockSet277;
      public static readonly BitSet _BLOCK_in_blockSet326;
      public static readonly BitSet _ALT_in_blockSet329;
      public static readonly BitSet _elementOptions_in_blockSet331;
      public static readonly BitSet _setElement_in_blockSet334;
      public static readonly BitSet _ALT_in_blockSet341;
      public static readonly BitSet _elementOptions_in_blockSet343;
      public static readonly BitSet _setElement_in_blockSet346;
      public static readonly BitSet _STRING_LITERAL_in_setElement386;
      public static readonly BitSet _elementOptions_in_setElement388;
      public static readonly BitSet _STRING_LITERAL_in_setElement401;
      public static readonly BitSet _TOKEN_REF_in_setElement413;
      public static readonly BitSet _elementOptions_in_setElement415;
      public static readonly BitSet _TOKEN_REF_in_setElement427;
      public static readonly BitSet _RANGE_in_setElement438;
      public static readonly BitSet _STRING_LITERAL_in_setElement442;
      public static readonly BitSet _STRING_LITERAL_in_setElement446;
      public static readonly BitSet _ELEMENT_OPTIONS_in_elementOptions468;
      public static readonly BitSet _elementOption_in_elementOptions470;
      public static readonly BitSet _ID_in_elementOption483;
      public static readonly BitSet _ASSIGN_in_elementOption489;
      public static readonly BitSet _ID_in_elementOption493;
      public static readonly BitSet _ID_in_elementOption497;
      public static readonly BitSet _ASSIGN_in_elementOption504;
      public static readonly BitSet _ID_in_elementOption506;
      public static readonly BitSet _STRING_LITERAL_in_elementOption510;
      public static readonly BitSet _ASSIGN_in_elementOption517;
      public static readonly BitSet _ID_in_elementOption519;
      public static readonly BitSet _ACTION_in_elementOption523;
      public static readonly BitSet _ASSIGN_in_elementOption530;
      public static readonly BitSet _ID_in_elementOption532;
      public static readonly BitSet _INT_in_elementOption536;

      static Follow()
      {
        BlockSetTransformer.Follow._RULE_in_topdown91 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._TOKEN_REF_in_topdown96 = new BitSet(new ulong[2]
        {
          18446744073709551600UL,
          68719476735UL
        });
        BlockSetTransformer.Follow._RULE_REF_in_topdown100 = new BitSet(new ulong[2]
        {
          18446744073709551600UL,
          68719476735UL
        });
        BlockSetTransformer.Follow._setAlt_in_topdown115 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._ebnfBlockSet_in_topdown123 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._blockSet_in_topdown131 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._ALT_in_setAlt146 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._ebnfSuffix_in_ebnfBlockSet166 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._blockSet_in_ebnfBlockSet168 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._BLOCK_in_blockSet253 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ALT_in_blockSet258 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_blockSet260 = new BitSet(new ulong[2]
        {
          4616189618054758400UL,
          4UL
        });
        BlockSetTransformer.Follow._setElement_in_blockSet265 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ALT_in_blockSet272 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_blockSet274 = new BitSet(new ulong[2]
        {
          4616189618054758400UL,
          4UL
        });
        BlockSetTransformer.Follow._setElement_in_blockSet277 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._BLOCK_in_blockSet326 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ALT_in_blockSet329 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_blockSet331 = new BitSet(new ulong[2]
        {
          4616189618054758400UL,
          4UL
        });
        BlockSetTransformer.Follow._setElement_in_blockSet334 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ALT_in_blockSet341 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_blockSet343 = new BitSet(new ulong[2]
        {
          4616189618054758400UL,
          4UL
        });
        BlockSetTransformer.Follow._setElement_in_blockSet346 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._STRING_LITERAL_in_setElement386 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_setElement388 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._STRING_LITERAL_in_setElement401 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._TOKEN_REF_in_setElement413 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOptions_in_setElement415 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._TOKEN_REF_in_setElement427 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._RANGE_in_setElement438 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._STRING_LITERAL_in_setElement442 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        BlockSetTransformer.Follow._STRING_LITERAL_in_setElement446 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ELEMENT_OPTIONS_in_elementOptions468 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._elementOption_in_elementOptions470 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption483 = new BitSet(new ulong[1]
        {
          2UL
        });
        BlockSetTransformer.Follow._ASSIGN_in_elementOption489 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption493 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption497 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ASSIGN_in_elementOption504 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption506 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        BlockSetTransformer.Follow._STRING_LITERAL_in_elementOption510 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ASSIGN_in_elementOption517 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption519 = new BitSet(new ulong[1]
        {
          16UL
        });
        BlockSetTransformer.Follow._ACTION_in_elementOption523 = new BitSet(new ulong[1]
        {
          8UL
        });
        BlockSetTransformer.Follow._ASSIGN_in_elementOption530 = new BitSet(new ulong[1]
        {
          4UL
        });
        BlockSetTransformer.Follow._ID_in_elementOption532 = new BitSet(new ulong[1]
        {
          1073741824UL
        });
        BlockSetTransformer.Follow._INT_in_elementOption536 = new BitSet(new ulong[1]
        {
          8UL
        });
      }
    }
  }
}
