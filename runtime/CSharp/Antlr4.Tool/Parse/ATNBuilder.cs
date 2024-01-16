// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.ATNBuilder
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr4.Automata;
using Antlr4.Tool.Ast;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class ATNBuilder : TreeParser
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
    private ATNFactory factory;
    private ATNBuilder.DFA10 dfa10;

    public ATNBuilder(ITreeNodeStream input) : this(input, new RecognizerSharedState())
    {
      
    }

    public ATNBuilder(ITreeNodeStream input, RecognizerSharedState state): base(input, state)
    {
      
    }

    public override string[] TokenNames
    {
      get
      {
        return ATNBuilder.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\ATNBuilder.g3";
      }
    }

    public ATNBuilder(ITreeNodeStream input, ATNFactory factory):this(input)
    {
      
      this.factory = factory;
    }

    [GrammarRule("dummy")]
    private void dummy()
    {
      try
      {
        try
        {
          this.PushFollow(ATNBuilder.Follow._block_in_dummy68);
          this.block((GrammarAST) null);
          this.PopFollow();
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
    }

    [GrammarRule("ruleBlock")]
    public Handle ruleBlock(GrammarAST ebnfRoot)
    {
      Handle handle1 = (Handle) null;
      IList<Handle> alternativeGrips = (IList<Handle>) new List<Handle>();
      int alt = 1;
      this.factory.SetCurrentOuterAlt(alt);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 77, ATNBuilder.Follow._BLOCK_in_ruleBlock96);
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
              this.Match((IIntStream) this.input, 42, ATNBuilder.Follow._OPTIONS_in_ruleBlock112);
              if (this.input.LA(1) == 2)
              {
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                try
                {
                  while (true)
                  {
                    int num2 = 2;
                    try
                    {
                      int num3 = this.input.LA(1);
                      if (num3 >= 4 && num3 <= 99)
                        num2 = 1;
                      else if (num3 == 3)
                        num2 = 2;
                    }
                    finally
                    {
                    }
                    if (num2 == 1)
                      this.MatchAny((IIntStream) this.input);
                    else
                      break;
                  }
                }
                finally
                {
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
              }
            }
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
                switch (this.input.LA(1))
                {
                  case 73:
                  case 86:
                    num5 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num5 == 1)
              {
                this.PushFollow(ATNBuilder.Follow._alternative_in_ruleBlock138);
                Handle handle2 = this.alternative();
                this.PopFollow();
                alternativeGrips.Add(handle2);
                this.factory.SetCurrentOuterAlt(++alt);
                ++num4;
              }
              else
                break;
            }
            if (num4 < 1)
              throw new EarlyExitException(3, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          handle1 = this.factory.Block((BlockAST) grammarAst, ebnfRoot, alternativeGrips);
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
      return handle1;
    }

    [GrammarRule("block")]
    private Handle block(GrammarAST ebnfRoot)
    {
      Handle handle1 = (Handle) null;
      IList<Handle> alternativeGrips = (IList<Handle>) new List<Handle>();
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.Match((IIntStream) this.input, 77, ATNBuilder.Follow._BLOCK_in_block216);
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
              this.Match((IIntStream) this.input, 42, ATNBuilder.Follow._OPTIONS_in_block220);
              if (this.input.LA(1) == 2)
              {
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                try
                {
                  while (true)
                  {
                    int num2 = 2;
                    try
                    {
                      int num3 = this.input.LA(1);
                      if (num3 >= 4 && num3 <= 99)
                        num2 = 1;
                      else if (num3 == 3)
                        num2 = 2;
                    }
                    finally
                    {
                    }
                    if (num2 == 1)
                      this.MatchAny((IIntStream) this.input);
                    else
                      break;
                  }
                }
                finally
                {
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
              }
            }
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
                switch (this.input.LA(1))
                {
                  case 73:
                  case 86:
                    num5 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num5 == 1)
              {
                this.PushFollow(ATNBuilder.Follow._alternative_in_block231);
                Handle handle2 = this.alternative();
                this.PopFollow();
                alternativeGrips.Add(handle2);
                ++num4;
              }
              else
                break;
            }
            if (num4 < 1)
              throw new EarlyExitException(6, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          handle1 = this.factory.Block((BlockAST) grammarAst, ebnfRoot, alternativeGrips);
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
      return handle1;
    }

    [GrammarRule("alternative")]
    private Handle alternative()
    {
      Handle handle = (Handle) null;
      IList<Handle> els = (IList<Handle>) new List<Handle>();
      try
      {
        try
        {
          int num1 = 3;
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
              this.Match((IIntStream) this.input, 86, ATNBuilder.Follow._LEXER_ALT_ACTION_in_alternative270);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._alternative_in_alternative274);
              Handle alt = this.alternative();
              this.PopFollow();
              this.PushFollow(ATNBuilder.Follow._lexerCommands_in_alternative276);
              Handle cmds = this.lexerCommands();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.LexerAltCommands(alt, cmds);
              break;
            case 2:
              this.Match((IIntStream) this.input, 73, ATNBuilder.Follow._ALT_in_alternative296);
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
                  this.PushFollow(ATNBuilder.Follow._elementOptions_in_alternative298);
                  this.elementOptions();
                  this.PopFollow();
                }
              }
              finally
              {
              }
              GrammarAST node = (GrammarAST) this.Match((IIntStream) this.input, 82, ATNBuilder.Follow._EPSILON_in_alternative301);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.Epsilon(node);
              break;
            case 3:
              this.Match((IIntStream) this.input, 73, ATNBuilder.Follow._ALT_in_alternative321);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num3 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 81)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  this.PushFollow(ATNBuilder.Follow._elementOptions_in_alternative323);
                  this.elementOptions();
                  this.PopFollow();
                }
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
                    int num6 = this.input.LA(1);
                    if (num6 != 4 && num6 != 10 && num6 != 20 && num6 != 32 && num6 != 39 && num6 != 46 && num6 != 52 && num6 != 57 && num6 != 59 && num6 != 62 && num6 != 66 && num6 != 77 && num6 != 79 && (num6 < 88 || num6 > 89) && num6 != 97)
                    {
                      if (num6 != 99)
                        goto label_28;
                    }
                    num5 = 1;
                  }
                  finally
                  {
                  }
label_28:
                  if (num5 == 1)
                  {
                    this.PushFollow(ATNBuilder.Follow._element_in_alternative329);
                    TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = (TreeRuleReturnScope<GrammarAST>) this.element();
                    this.PopFollow();
                    els.Add(((ATNBuilder.element_return) treeRuleReturnScope)?.p);
                    ++num4;
                  }
                  else
                    break;
                }
                if (num4 < 1)
                  throw new EarlyExitException(9, (IIntStream) this.input);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.Alt(els);
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
      return handle;
    }

    [GrammarRule("lexerCommands")]
    private Handle lexerCommands()
    {
      Handle handle1 = (Handle) null;
      IList<Handle> els = (IList<Handle>) new List<Handle>();
      try
      {
        try
        {
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
                  case 28:
                  case 85:
                    num2 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(ATNBuilder.Follow._lexerCommand_in_lexerCommands367);
                Handle handle2 = this.lexerCommand();
                this.PopFollow();
                if (handle2 != null)
                  els.Add(handle2);
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(11, (IIntStream) this.input);
          }
          finally
          {
          }
          handle1 = this.factory.Alt(els);
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
      return handle1;
    }

    [GrammarRule("lexerCommand")]
    private Handle lexerCommand()
    {
      Handle handle = (Handle) null;
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
                throw new NoViableAltException("", 12, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 85, ATNBuilder.Follow._LEXER_ACTION_CALL_in_lexerCommand400);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_lexerCommand402);
              this.PushFollow(ATNBuilder.Follow._lexerCommandExpr_in_lexerCommand404);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = this.lexerCommandExpr();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.LexerCallCommand(ID, treeRuleReturnScope?.Start);
              break;
            case 2:
              handle = this.factory.LexerCommand((GrammarAST) this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_lexerCommand420));
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
      return handle;
    }

    [GrammarRule("lexerCommandExpr")]
    private TreeRuleReturnScope<GrammarAST> lexerCommandExpr()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          if (this.input.LA(1) != 28 && this.input.LA(1) != 30)
            throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.input.Consume();
          this.state.errorRecovery = false;
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
    private ATNBuilder.element_return element()
    {
      ATNBuilder.element_return elementReturn = new ATNBuilder.element_return(this);
      elementReturn.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          int num1 = 9;
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
                if ((num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 13, 4, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              case 10:
              case 46:
                num1 = 1;
                break;
              case 20:
              case 52:
              case 57:
              case 62:
              case 66:
              case 97:
              case 99:
                num1 = 2;
                break;
              case 32:
                num1 = 9;
                break;
              case 39:
                num1 = 8;
                break;
              case 59:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 7;
                  break;
                }
                if ((num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 32 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 13, 5, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              case 77:
              case 79:
              case 88:
              case 89:
                num1 = 3;
                break;
              default:
                throw new NoViableAltException("", 13, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(ATNBuilder.Follow._labeledElement_in_element461);
              Handle handle = this.labeledElement();
              this.PopFollow();
              elementReturn.p = handle;
              break;
            case 2:
              this.PushFollow(ATNBuilder.Follow._atom_in_element471);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = (TreeRuleReturnScope<GrammarAST>) this.atom();
              this.PopFollow();
              elementReturn.p = ((ATNBuilder.atom_return) treeRuleReturnScope1)?.p;
              break;
            case 3:
              this.PushFollow(ATNBuilder.Follow._subrule_in_element483);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.subrule();
              this.PopFollow();
              elementReturn.p = ((ATNBuilder.subrule_return) treeRuleReturnScope2)?.p;
              break;
            case 4:
              GrammarAST action1 = (GrammarAST) this.Match((IIntStream) this.input, 4, ATNBuilder.Follow._ACTION_in_element497);
              elementReturn.p = this.factory.Action((ActionAST) action1);
              break;
            case 5:
              GrammarAST pred1 = (GrammarAST) this.Match((IIntStream) this.input, 59, ATNBuilder.Follow._SEMPRED_in_element511);
              elementReturn.p = this.factory.Sempred((PredAST) pred1);
              break;
            case 6:
              GrammarAST action2 = (GrammarAST) this.Match((IIntStream) this.input, 4, ATNBuilder.Follow._ACTION_in_element526);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              elementReturn.p = this.factory.Action((ActionAST) action2);
              break;
            case 7:
              GrammarAST pred2 = (GrammarAST) this.Match((IIntStream) this.input, 59, ATNBuilder.Follow._SEMPRED_in_element543);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              elementReturn.p = this.factory.Sempred((PredAST) pred2);
              break;
            case 8:
              this.Match((IIntStream) this.input, 39, ATNBuilder.Follow._NOT_in_element560);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._blockSet_in_element564);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope3 = (TreeRuleReturnScope<GrammarAST>) this.blockSet(true);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              elementReturn.p = ((ATNBuilder.blockSet_return) treeRuleReturnScope3)?.p;
              break;
            case 9:
              this.Match((IIntStream) this.input, 32, ATNBuilder.Follow._LEXER_CHAR_SET_in_element577);
              elementReturn.p = this.factory.CharSetLiteral(elementReturn.Start);
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
      return elementReturn;
    }

    [GrammarRule("astOperand")]
    private Handle astOperand()
    {
      Handle handle = (Handle) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
              case 52:
              case 57:
              case 62:
              case 66:
              case 97:
              case 99:
                num = 1;
                break;
              case 39:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 14, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.PushFollow(ATNBuilder.Follow._atom_in_astOperand598);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = (TreeRuleReturnScope<GrammarAST>) this.atom();
              this.PopFollow();
              handle = ((ATNBuilder.atom_return) treeRuleReturnScope1)?.p;
              break;
            case 2:
              this.Match((IIntStream) this.input, 39, ATNBuilder.Follow._NOT_in_astOperand611);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._blockSet_in_astOperand613);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.blockSet(true);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = ((ATNBuilder.blockSet_return) treeRuleReturnScope2)?.p;
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
      return handle;
    }

    [GrammarRule("labeledElement")]
    private Handle labeledElement()
    {
      Handle handle = (Handle) null;
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
              case 46:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 15, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 10, ATNBuilder.Follow._ASSIGN_in_labeledElement634);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_labeledElement636);
              this.PushFollow(ATNBuilder.Follow._element_in_labeledElement638);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = (TreeRuleReturnScope<GrammarAST>) this.element();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.Label(((ATNBuilder.element_return) treeRuleReturnScope1)?.p);
              break;
            case 2:
              this.Match((IIntStream) this.input, 46, ATNBuilder.Follow._PLUS_ASSIGN_in_labeledElement651);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_labeledElement653);
              this.PushFollow(ATNBuilder.Follow._element_in_labeledElement655);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.element();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.ListLabel(((ATNBuilder.element_return) treeRuleReturnScope2)?.p);
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
      return handle;
    }

    [GrammarRule("subrule")]
    private ATNBuilder.subrule_return subrule()
    {
      ATNBuilder.subrule_return subruleReturn = new ATNBuilder.subrule_return(this);
      subruleReturn.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          int num = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 77:
                num = 4;
                break;
              case 79:
                num = 2;
                break;
              case 88:
                num = 1;
                break;
              case 89:
                num = 3;
                break;
              default:
                throw new NoViableAltException("", 16, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 88, ATNBuilder.Follow._OPTIONAL_in_subrule676);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._block_in_subrule678);
              Handle handle1 = this.block(subruleReturn.Start);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              subruleReturn.p = handle1;
              break;
            case 2:
              this.Match((IIntStream) this.input, 79, ATNBuilder.Follow._CLOSURE_in_subrule690);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._block_in_subrule692);
              Handle handle2 = this.block(subruleReturn.Start);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              subruleReturn.p = handle2;
              break;
            case 3:
              this.Match((IIntStream) this.input, 89, ATNBuilder.Follow._POSITIVE_CLOSURE_in_subrule704);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(ATNBuilder.Follow._block_in_subrule706);
              Handle handle3 = this.block(subruleReturn.Start);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              subruleReturn.p = handle3;
              break;
            case 4:
              this.PushFollow(ATNBuilder.Follow._block_in_subrule716);
              Handle handle4 = this.block((GrammarAST) null);
              this.PopFollow();
              subruleReturn.p = handle4;
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
      return subruleReturn;
    }

    [GrammarRule("blockSet")]
    private ATNBuilder.blockSet_return blockSet(bool invert)
    {
      ATNBuilder.blockSet_return blockSetReturn = new ATNBuilder.blockSet_return(this);
      blockSetReturn.Start = (GrammarAST) this.input.LT(1);
      IList<GrammarAST> alts = (IList<GrammarAST>) new List<GrammarAST>();
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 97, ATNBuilder.Follow._SET_in_blockSet750);
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
                this.PushFollow(ATNBuilder.Follow._setElement_in_blockSet753);
                TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = this.setElement();
                this.PopFollow();
                alts.Add(treeRuleReturnScope?.Start);
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(17, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          blockSetReturn.p = this.factory.Set(blockSetReturn.Start, alts, invert);
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
      return blockSetReturn;
    }

    [GrammarRule("setElement")]
    private TreeRuleReturnScope<GrammarAST> setElement()
    {
      TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = new TreeRuleReturnScope<GrammarAST>();
      treeRuleReturnScope.Start = (GrammarAST) this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
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
                    throw new NoViableAltException("", 18, 1, (IIntStream) this.input, 2);
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
                    throw new NoViableAltException("", 18, 2, (IIntStream) this.input, 2);
                }
                break;
              default:
                throw new NoViableAltException("", 18, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_setElement774);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.Match((IIntStream) this.input, 66, ATNBuilder.Follow._TOKEN_REF_in_setElement783);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_setElement791);
              break;
            case 4:
              this.Match((IIntStream) this.input, 66, ATNBuilder.Follow._TOKEN_REF_in_setElement796);
              break;
            case 5:
              this.Match((IIntStream) this.input, 52, ATNBuilder.Follow._RANGE_in_setElement802);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              grammarAst1 = (GrammarAST) this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_setElement806);
              grammarAst2 = (GrammarAST) this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_setElement810);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 6:
              this.Match((IIntStream) this.input, 32, ATNBuilder.Follow._LEXER_CHAR_SET_in_setElement821);
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

    [GrammarRule("atom")]
    private ATNBuilder.atom_return atom()
    {
      ATNBuilder.atom_return atomReturn = new ATNBuilder.atom_return(this);
      atomReturn.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          int num1 = 8;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 19, 2, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 19, 7, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 57:
                    num1 = 3;
                    break;
                  case 62:
                  case 66:
                    num1 = 2;
                    break;
                  default:
                    throw new NoViableAltException("", 19, 10, (IIntStream) this.input, 4);
                }
                break;
              case 52:
                num1 = 1;
                break;
              case 57:
                num1 = 8;
                break;
              case 62:
              case 66:
                num1 = 7;
                break;
              case 97:
                num1 = 6;
                break;
              case 99:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 4;
                  break;
                }
                if (num2 != -1 && (num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 19, 3, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              default:
                throw new NoViableAltException("", 19, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(ATNBuilder.Follow._range_in_atom836);
              Handle handle1 = this.range();
              this.PopFollow();
              atomReturn.p = handle1;
              break;
            case 2:
              this.Match((IIntStream) this.input, 20, ATNBuilder.Follow._DOT_in_atom848);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_atom850);
              this.PushFollow(ATNBuilder.Follow._terminal_in_atom852);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope1 = (TreeRuleReturnScope<GrammarAST>) this.terminal();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              atomReturn.p = ((ATNBuilder.terminal_return) treeRuleReturnScope1)?.p;
              break;
            case 3:
              this.Match((IIntStream) this.input, 20, ATNBuilder.Follow._DOT_in_atom862);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_atom864);
              this.PushFollow(ATNBuilder.Follow._ruleref_in_atom866);
              Handle handle2 = this.ruleref();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              atomReturn.p = handle2;
              break;
            case 4:
              this.Match((IIntStream) this.input, 99, ATNBuilder.Follow._WILDCARD_in_atom879);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              atomReturn.p = this.factory.Wildcard(atomReturn.Start);
              break;
            case 5:
              this.Match((IIntStream) this.input, 99, ATNBuilder.Follow._WILDCARD_in_atom894);
              atomReturn.p = this.factory.Wildcard(atomReturn.Start);
              break;
            case 6:
              this.PushFollow(ATNBuilder.Follow._blockSet_in_atom907);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope2 = (TreeRuleReturnScope<GrammarAST>) this.blockSet(false);
              this.PopFollow();
              atomReturn.p = ((ATNBuilder.blockSet_return) treeRuleReturnScope2)?.p;
              break;
            case 7:
              this.PushFollow(ATNBuilder.Follow._terminal_in_atom922);
              TreeRuleReturnScope<GrammarAST> treeRuleReturnScope3 = (TreeRuleReturnScope<GrammarAST>) this.terminal();
              this.PopFollow();
              atomReturn.p = ((ATNBuilder.terminal_return) treeRuleReturnScope3)?.p;
              break;
            case 8:
              this.PushFollow(ATNBuilder.Follow._ruleref_in_atom937);
              Handle handle3 = this.ruleref();
              this.PopFollow();
              atomReturn.p = handle3;
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
      return atomReturn;
    }

    [GrammarRule("ruleref")]
    private Handle ruleref()
    {
      Handle handle = (Handle) null;
      try
      {
        try
        {
          int num1 = 3;
          try
          {
            if (this.input.LA(1) != 57)
              throw new NoViableAltException("", 23, 0, (IIntStream) this.input, 1);
            int num2 = this.input.LA(2);
            if (num2 == 2)
            {
              switch (this.input.LA(3))
              {
                case 3:
                  num1 = 2;
                  break;
                case 8:
                  switch (this.input.LA(4))
                  {
                    case 3:
                      num1 = 2;
                      break;
                    case 81:
                      num1 = 1;
                      break;
                    default:
                      throw new NoViableAltException("", 23, 4, (IIntStream) this.input, 4);
                  }
                  break;
                case 81:
                  num1 = 1;
                  break;
                default:
                  throw new NoViableAltException("", 23, 2, (IIntStream) this.input, 3);
              }
            }
            else
            {
              if (num2 != -1 && (num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                throw new NoViableAltException("", 23, 1, (IIntStream) this.input, 2);
              num1 = 3;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST node1 = (GrammarAST) this.Match((IIntStream) this.input, 57, ATNBuilder.Follow._RULE_REF_in_ruleref965);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num3 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 8)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                  this.Match((IIntStream) this.input, 8, ATNBuilder.Follow._ARG_ACTION_in_ruleref967);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 81, ATNBuilder.Follow._ELEMENT_OPTIONS_in_ruleref971);
              if (this.input.LA(1) == 2)
              {
                this.Match((IIntStream) this.input, 2, (BitSet) null);
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
                      this.MatchAny((IIntStream) this.input);
                    else
                      break;
                  }
                }
                finally
                {
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              handle = this.factory.RuleRef(node1);
              break;
            case 2:
              GrammarAST node2 = (GrammarAST) this.Match((IIntStream) this.input, 57, ATNBuilder.Follow._RULE_REF_in_ruleref988);
              if (this.input.LA(1) == 2)
              {
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                int num6 = 2;
                try
                {
                  try
                  {
                    if (this.input.LA(1) == 8)
                      num6 = 1;
                  }
                  finally
                  {
                  }
                  if (num6 == 1)
                    this.Match((IIntStream) this.input, 8, ATNBuilder.Follow._ARG_ACTION_in_ruleref990);
                }
                finally
                {
                }
                this.Match((IIntStream) this.input, 3, (BitSet) null);
              }
              handle = this.factory.RuleRef(node2);
              break;
            case 3:
              handle = this.factory.RuleRef((GrammarAST) this.Match((IIntStream) this.input, 57, ATNBuilder.Follow._RULE_REF_in_ruleref1009));
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
      return handle;
    }

    [GrammarRule("range")]
    private Handle range()
    {
      Handle handle = (Handle) null;
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 52, ATNBuilder.Follow._RANGE_in_range1043);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          GrammarAST a = (GrammarAST) this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_range1047);
          GrammarAST b = (GrammarAST) this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_range1051);
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          handle = this.factory.Range(a, b);
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
      return handle;
    }

    [GrammarRule("terminal")]
    private ATNBuilder.terminal_return terminal()
    {
      ATNBuilder.terminal_return terminalReturn = new ATNBuilder.terminal_return(this);
      terminalReturn.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          int num1 = 5;
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
                if (num2 != -1 && (num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 32 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 24, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  int num4 = this.input.LA(3);
                  if (num4 == 8)
                  {
                    int num5 = this.input.LA(4);
                    if (num5 >= 4 && num5 <= 99)
                    {
                      num1 = 3;
                      break;
                    }
                    if (num5 < 2 || num5 > 3)
                      throw new NoViableAltException("", 24, 7, (IIntStream) this.input, 4);
                    num1 = 4;
                    break;
                  }
                  if ((num4 < 4 || num4 > 7) && (num4 < 9 || num4 > 99))
                    throw new NoViableAltException("", 24, 5, (IIntStream) this.input, 3);
                  num1 = 4;
                  break;
                }
                if (num3 != -1 && (num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 32 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 24, 2, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              default:
                throw new NoViableAltException("", 24, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_terminal1077);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              terminalReturn.p = this.factory.StringLiteral((TerminalAST) terminalReturn.Start);
              break;
            case 2:
              this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_terminal1092);
              terminalReturn.p = this.factory.StringLiteral((TerminalAST) terminalReturn.Start);
              break;
            case 3:
              this.Match((IIntStream) this.input, 66, ATNBuilder.Follow._TOKEN_REF_in_terminal1106);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 8, ATNBuilder.Follow._ARG_ACTION_in_terminal1108);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              terminalReturn.p = this.factory.TokenRef((TerminalAST) terminalReturn.Start);
              break;
            case 4:
              this.Match((IIntStream) this.input, 66, ATNBuilder.Follow._TOKEN_REF_in_terminal1122);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              terminalReturn.p = this.factory.TokenRef((TerminalAST) terminalReturn.Start);
              break;
            case 5:
              this.Match((IIntStream) this.input, 66, ATNBuilder.Follow._TOKEN_REF_in_terminal1138);
              terminalReturn.p = this.factory.TokenRef((TerminalAST) terminalReturn.Start);
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
      return terminalReturn;
    }

    [GrammarRule("elementOptions")]
    private void elementOptions()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 81, ATNBuilder.Follow._ELEMENT_OPTIONS_in_elementOptions1159);
          if (this.input.LA(1) != 2)
            return;
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
                this.PushFollow(ATNBuilder.Follow._elementOption_in_elementOptions1161);
                this.elementOption();
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
    }

    [GrammarRule("elementOption")]
    private void elementOption()
    {
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
                  throw new NoViableAltException("", 26, 2, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 26, 3, (IIntStream) this.input, 3);
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
                    throw new NoViableAltException("", 26, 4, (IIntStream) this.input, 4);
                }
                break;
              case 28:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 26, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1174);
              break;
            case 2:
              this.Match((IIntStream) this.input, 10, ATNBuilder.Follow._ASSIGN_in_elementOption1180);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1182);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1184);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.Match((IIntStream) this.input, 10, ATNBuilder.Follow._ASSIGN_in_elementOption1191);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1193);
              this.Match((IIntStream) this.input, 62, ATNBuilder.Follow._STRING_LITERAL_in_elementOption1195);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 4:
              this.Match((IIntStream) this.input, 10, ATNBuilder.Follow._ASSIGN_in_elementOption1202);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1204);
              this.Match((IIntStream) this.input, 4, ATNBuilder.Follow._ACTION_in_elementOption1206);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 5:
              this.Match((IIntStream) this.input, 10, ATNBuilder.Follow._ASSIGN_in_elementOption1213);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, ATNBuilder.Follow._ID_in_elementOption1215);
              this.Match((IIntStream) this.input, 30, ATNBuilder.Follow._INT_in_elementOption1217);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
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
    }

    protected override void InitDFAs()
    {
      base.InitDFAs();
      this.dfa10 = new ATNBuilder.DFA10((BaseRecognizer) this);
    }

    static ATNBuilder()
    {
      ATNBuilder.tokenNames = new string[100]
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

    private sealed class element_return : TreeRuleReturnScope<GrammarAST>
    {
      public Handle p;

      public element_return(ATNBuilder grammar) : base()
      {
      }
    }

    private sealed class subrule_return : TreeRuleReturnScope<GrammarAST>
    {
      public Handle p;

      public subrule_return(ATNBuilder grammar) :base()
      {
      }
    }

    private sealed class blockSet_return : TreeRuleReturnScope<GrammarAST>
    {
      public Handle p;

      public blockSet_return(ATNBuilder grammar):base()
      {
      }
    }

    private sealed class atom_return : TreeRuleReturnScope<GrammarAST>
    {
      public Handle p;

      public atom_return(ATNBuilder grammar):base()
      {
      }
    }

    private sealed class terminal_return : TreeRuleReturnScope<GrammarAST>
    {
      public Handle p;

      public terminal_return(ATNBuilder grammar):base()
      {
      }
    }

    private class DFA10 : DFA
    {
      private const string DFA10_eotS = "\u0015\uFFFF";
      private const string DFA10_eofS = "\u0015\uFFFF";
      private const string DFA10_minS = "\u0001I\u0001\uFFFF\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0002\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003";
      private const string DFA10_maxS = "\u0001V\u0001\uFFFF\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C";
      private const string DFA10_acceptS = "\u0001\uFFFF\u0001\u0001\u0003\uFFFF\u0001\u0002\u0001\u0003\u000E\uFFFF";
      private const string DFA10_specialS = "\u0015\uFFFF}>";
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
        ATNBuilder.DFA10.DFA10_transitionS = new string[21]
        {
          "\u0001\u0002\f\uFFFF\u0001\u0001",
          "",
          "\u0001\u0003",
          "\u0001\u0006\u0005\uFFFF\u0001\u0006\t\uFFFF\u0001\u0006\v\uFFFF\u0001\u0006\u0006\uFFFF\u0001\u0006\u0006\uFFFF\u0001\u0006\u0005\uFFFF\u0001\u0006\u0004\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006\u0002\uFFFF\u0001\u0006\u0003\uFFFF\u0001\u0006\n\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0004\u0001\u0005\u0005\uFFFF\u0002\u0006\a\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006",
          "\u0001\a",
          "",
          "",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b",
          "\u0001\v",
          "\u0001\u0006\u0005\uFFFF\u0001\u0006\t\uFFFF\u0001\u0006\v\uFFFF\u0001\u0006\u0006\uFFFF\u0001\u0006\u0006\uFFFF\u0001\u0006\u0005\uFFFF\u0001\u0006\u0004\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006\u0002\uFFFF\u0001\u0006\u0003\uFFFF\u0001\u0006\n\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006\u0002\uFFFF\u0001\u0005\u0005\uFFFF\u0002\u0006\a\uFFFF\u0001\u0006\u0001\uFFFF\u0001\u0006",
          "\u0001\f",
          "\u0001\u000F\u0017\uFFFF\u0001\r\u0001\uFFFF\u0001\u0010\u001F\uFFFF\u0001\u000E",
          "\u0001\u0011",
          "\u0001\u0012",
          "\u0001\u0013",
          "\u0001\u0014",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b",
          "\u0001\n\u0006\uFFFF\u0001\t\u0011\uFFFF\u0001\b"
        };
        ATNBuilder.DFA10.DFA10_eot = DFA.UnpackEncodedString("\u0015\uFFFF");
        ATNBuilder.DFA10.DFA10_eof = DFA.UnpackEncodedString("\u0015\uFFFF");
        ATNBuilder.DFA10.DFA10_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001I\u0001\uFFFF\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0002\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003");
        ATNBuilder.DFA10.DFA10_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001V\u0001\uFFFF\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C");
        ATNBuilder.DFA10.DFA10_accept = DFA.UnpackEncodedString("\u0001\uFFFF\u0001\u0001\u0003\uFFFF\u0001\u0002\u0001\u0003\u000E\uFFFF");
        ATNBuilder.DFA10.DFA10_special = DFA.UnpackEncodedString("\u0015\uFFFF}>");
        int length = ATNBuilder.DFA10.DFA10_transitionS.Length;
        ATNBuilder.DFA10.DFA10_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          ATNBuilder.DFA10.DFA10_transition[index] = DFA.UnpackEncodedString(ATNBuilder.DFA10.DFA10_transitionS[index]);
      }

      public DFA10(BaseRecognizer recognizer):base()
      {
        this.recognizer = recognizer;
        this.decisionNumber = 10;
        this.eot = ATNBuilder.DFA10.DFA10_eot;
        this.eof = ATNBuilder.DFA10.DFA10_eof;
        this.min = ATNBuilder.DFA10.DFA10_min;
        this.max = ATNBuilder.DFA10.DFA10_max;
        this.accept = ATNBuilder.DFA10.DFA10_accept;
        this.special = ATNBuilder.DFA10.DFA10_special;
        this.transition = ATNBuilder.DFA10.DFA10_transition;
      }

      public override string Description
      {
        get
        {
          return "59:1: alternative returns [Handle p] : ( ^( LEXER_ALT_ACTION a= alternative lexerCommands ) | ^( ALT ( elementOptions )? EPSILON ) | ^( ALT ( elementOptions )? (e= element )+ ) );";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private static class Follow
    {
      public static readonly BitSet _block_in_dummy68;
      public static readonly BitSet _BLOCK_in_ruleBlock96;
      public static readonly BitSet _OPTIONS_in_ruleBlock112;
      public static readonly BitSet _alternative_in_ruleBlock138;
      public static readonly BitSet _BLOCK_in_block216;
      public static readonly BitSet _OPTIONS_in_block220;
      public static readonly BitSet _alternative_in_block231;
      public static readonly BitSet _LEXER_ALT_ACTION_in_alternative270;
      public static readonly BitSet _alternative_in_alternative274;
      public static readonly BitSet _lexerCommands_in_alternative276;
      public static readonly BitSet _ALT_in_alternative296;
      public static readonly BitSet _elementOptions_in_alternative298;
      public static readonly BitSet _EPSILON_in_alternative301;
      public static readonly BitSet _ALT_in_alternative321;
      public static readonly BitSet _elementOptions_in_alternative323;
      public static readonly BitSet _element_in_alternative329;
      public static readonly BitSet _lexerCommand_in_lexerCommands367;
      public static readonly BitSet _LEXER_ACTION_CALL_in_lexerCommand400;
      public static readonly BitSet _ID_in_lexerCommand402;
      public static readonly BitSet _lexerCommandExpr_in_lexerCommand404;
      public static readonly BitSet _ID_in_lexerCommand420;
      public static readonly BitSet _labeledElement_in_element461;
      public static readonly BitSet _atom_in_element471;
      public static readonly BitSet _subrule_in_element483;
      public static readonly BitSet _ACTION_in_element497;
      public static readonly BitSet _SEMPRED_in_element511;
      public static readonly BitSet _ACTION_in_element526;
      public static readonly BitSet _SEMPRED_in_element543;
      public static readonly BitSet _NOT_in_element560;
      public static readonly BitSet _blockSet_in_element564;
      public static readonly BitSet _LEXER_CHAR_SET_in_element577;
      public static readonly BitSet _atom_in_astOperand598;
      public static readonly BitSet _NOT_in_astOperand611;
      public static readonly BitSet _blockSet_in_astOperand613;
      public static readonly BitSet _ASSIGN_in_labeledElement634;
      public static readonly BitSet _ID_in_labeledElement636;
      public static readonly BitSet _element_in_labeledElement638;
      public static readonly BitSet _PLUS_ASSIGN_in_labeledElement651;
      public static readonly BitSet _ID_in_labeledElement653;
      public static readonly BitSet _element_in_labeledElement655;
      public static readonly BitSet _OPTIONAL_in_subrule676;
      public static readonly BitSet _block_in_subrule678;
      public static readonly BitSet _CLOSURE_in_subrule690;
      public static readonly BitSet _block_in_subrule692;
      public static readonly BitSet _POSITIVE_CLOSURE_in_subrule704;
      public static readonly BitSet _block_in_subrule706;
      public static readonly BitSet _block_in_subrule716;
      public static readonly BitSet _SET_in_blockSet750;
      public static readonly BitSet _setElement_in_blockSet753;
      public static readonly BitSet _STRING_LITERAL_in_setElement774;
      public static readonly BitSet _TOKEN_REF_in_setElement783;
      public static readonly BitSet _STRING_LITERAL_in_setElement791;
      public static readonly BitSet _TOKEN_REF_in_setElement796;
      public static readonly BitSet _RANGE_in_setElement802;
      public static readonly BitSet _STRING_LITERAL_in_setElement806;
      public static readonly BitSet _STRING_LITERAL_in_setElement810;
      public static readonly BitSet _LEXER_CHAR_SET_in_setElement821;
      public static readonly BitSet _range_in_atom836;
      public static readonly BitSet _DOT_in_atom848;
      public static readonly BitSet _ID_in_atom850;
      public static readonly BitSet _terminal_in_atom852;
      public static readonly BitSet _DOT_in_atom862;
      public static readonly BitSet _ID_in_atom864;
      public static readonly BitSet _ruleref_in_atom866;
      public static readonly BitSet _WILDCARD_in_atom879;
      public static readonly BitSet _WILDCARD_in_atom894;
      public static readonly BitSet _blockSet_in_atom907;
      public static readonly BitSet _terminal_in_atom922;
      public static readonly BitSet _ruleref_in_atom937;
      public static readonly BitSet _RULE_REF_in_ruleref965;
      public static readonly BitSet _ARG_ACTION_in_ruleref967;
      public static readonly BitSet _ELEMENT_OPTIONS_in_ruleref971;
      public static readonly BitSet _RULE_REF_in_ruleref988;
      public static readonly BitSet _ARG_ACTION_in_ruleref990;
      public static readonly BitSet _RULE_REF_in_ruleref1009;
      public static readonly BitSet _RANGE_in_range1043;
      public static readonly BitSet _STRING_LITERAL_in_range1047;
      public static readonly BitSet _STRING_LITERAL_in_range1051;
      public static readonly BitSet _STRING_LITERAL_in_terminal1077;
      public static readonly BitSet _STRING_LITERAL_in_terminal1092;
      public static readonly BitSet _TOKEN_REF_in_terminal1106;
      public static readonly BitSet _ARG_ACTION_in_terminal1108;
      public static readonly BitSet _TOKEN_REF_in_terminal1122;
      public static readonly BitSet _TOKEN_REF_in_terminal1138;
      public static readonly BitSet _ELEMENT_OPTIONS_in_elementOptions1159;
      public static readonly BitSet _elementOption_in_elementOptions1161;
      public static readonly BitSet _ID_in_elementOption1174;
      public static readonly BitSet _ASSIGN_in_elementOption1180;
      public static readonly BitSet _ID_in_elementOption1182;
      public static readonly BitSet _ID_in_elementOption1184;
      public static readonly BitSet _ASSIGN_in_elementOption1191;
      public static readonly BitSet _ID_in_elementOption1193;
      public static readonly BitSet _STRING_LITERAL_in_elementOption1195;
      public static readonly BitSet _ASSIGN_in_elementOption1202;
      public static readonly BitSet _ID_in_elementOption1204;
      public static readonly BitSet _ACTION_in_elementOption1206;
      public static readonly BitSet _ASSIGN_in_elementOption1213;
      public static readonly BitSet _ID_in_elementOption1215;
      public static readonly BitSet _INT_in_elementOption1217;

      static Follow()
      {
        ATNBuilder.Follow._block_in_dummy68 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._BLOCK_in_ruleBlock96 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._OPTIONS_in_ruleBlock112 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._alternative_in_ruleBlock138 = new BitSet(new ulong[2]
        {
          8UL,
          4194816UL
        });
        ATNBuilder.Follow._BLOCK_in_block216 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._OPTIONS_in_block220 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._alternative_in_block231 = new BitSet(new ulong[2]
        {
          8UL,
          4194816UL
        });
        ATNBuilder.Follow._LEXER_ALT_ACTION_in_alternative270 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._alternative_in_alternative274 = new BitSet(new ulong[2]
        {
          268435456UL,
          2097152UL
        });
        ATNBuilder.Follow._lexerCommands_in_alternative276 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ALT_in_alternative296 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._elementOptions_in_alternative298 = new BitSet(new ulong[2]
        {
          0UL,
          262144UL
        });
        ATNBuilder.Follow._EPSILON_in_alternative301 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ALT_in_alternative321 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._elementOptions_in_alternative323 = new BitSet(new ulong[2]
        {
          5336836481230046224UL,
          43000045572UL
        });
        ATNBuilder.Follow._element_in_alternative329 = new BitSet(new ulong[2]
        {
          5336836481230046232UL,
          43000045572UL
        });
        ATNBuilder.Follow._lexerCommand_in_lexerCommands367 = new BitSet(new ulong[2]
        {
          268435458UL,
          2097152UL
        });
        ATNBuilder.Follow._LEXER_ACTION_CALL_in_lexerCommand400 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_lexerCommand402 = new BitSet(new ulong[1]
        {
          1342177280UL
        });
        ATNBuilder.Follow._lexerCommandExpr_in_lexerCommand404 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ID_in_lexerCommand420 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._labeledElement_in_element461 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._atom_in_element471 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._subrule_in_element483 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._ACTION_in_element497 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._SEMPRED_in_element511 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._ACTION_in_element526 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._SEMPRED_in_element543 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._NOT_in_element560 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._blockSet_in_element564 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._LEXER_CHAR_SET_in_element577 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._atom_in_astOperand598 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._NOT_in_astOperand611 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._blockSet_in_astOperand613 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ASSIGN_in_labeledElement634 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_labeledElement636 = new BitSet(new ulong[2]
        {
          5336836481230046224UL,
          43000045572UL
        });
        ATNBuilder.Follow._element_in_labeledElement638 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._PLUS_ASSIGN_in_labeledElement651 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_labeledElement653 = new BitSet(new ulong[2]
        {
          5336836481230046224UL,
          43000045572UL
        });
        ATNBuilder.Follow._element_in_labeledElement655 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._OPTIONAL_in_subrule676 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._block_in_subrule678 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._CLOSURE_in_subrule690 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._block_in_subrule692 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._POSITIVE_CLOSURE_in_subrule704 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._block_in_subrule706 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._block_in_subrule716 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._SET_in_blockSet750 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._setElement_in_blockSet753 = new BitSet(new ulong[2]
        {
          4616189622349725704UL,
          4UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_setElement774 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._TOKEN_REF_in_setElement783 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_setElement791 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._TOKEN_REF_in_setElement796 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._RANGE_in_setElement802 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_setElement806 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_setElement810 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._LEXER_CHAR_SET_in_setElement821 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._range_in_atom836 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._DOT_in_atom848 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_atom850 = new BitSet(new ulong[2]
        {
          4611686018427387904UL,
          4UL
        });
        ATNBuilder.Follow._terminal_in_atom852 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._DOT_in_atom862 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_atom864 = new BitSet(new ulong[1]
        {
          144115188075855872UL
        });
        ATNBuilder.Follow._ruleref_in_atom866 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._WILDCARD_in_atom879 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._WILDCARD_in_atom894 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._blockSet_in_atom907 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._terminal_in_atom922 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._ruleref_in_atom937 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._RULE_REF_in_ruleref965 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ARG_ACTION_in_ruleref967 = new BitSet(new ulong[2]
        {
          0UL,
          131072UL
        });
        ATNBuilder.Follow._ELEMENT_OPTIONS_in_ruleref971 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._RULE_REF_in_ruleref988 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ARG_ACTION_in_ruleref990 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._RULE_REF_in_ruleref1009 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._RANGE_in_range1043 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_range1047 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_range1051 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_terminal1077 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_terminal1092 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._TOKEN_REF_in_terminal1106 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ARG_ACTION_in_terminal1108 = new BitSet(new ulong[2]
        {
          18446744073709551600UL,
          68719476735UL
        });
        ATNBuilder.Follow._TOKEN_REF_in_terminal1122 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._TOKEN_REF_in_terminal1138 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._ELEMENT_OPTIONS_in_elementOptions1159 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._elementOption_in_elementOptions1161 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        ATNBuilder.Follow._ID_in_elementOption1174 = new BitSet(new ulong[1]
        {
          2UL
        });
        ATNBuilder.Follow._ASSIGN_in_elementOption1180 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_elementOption1182 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        ATNBuilder.Follow._ID_in_elementOption1184 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ASSIGN_in_elementOption1191 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_elementOption1193 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        ATNBuilder.Follow._STRING_LITERAL_in_elementOption1195 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ASSIGN_in_elementOption1202 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_elementOption1204 = new BitSet(new ulong[1]
        {
          16UL
        });
        ATNBuilder.Follow._ACTION_in_elementOption1206 = new BitSet(new ulong[1]
        {
          8UL
        });
        ATNBuilder.Follow._ASSIGN_in_elementOption1213 = new BitSet(new ulong[1]
        {
          4UL
        });
        ATNBuilder.Follow._ID_in_elementOption1215 = new BitSet(new ulong[1]
        {
          1073741824UL
        });
        ATNBuilder.Follow._INT_in_elementOption1217 = new BitSet(new ulong[1]
        {
          8UL
        });
      }
    }
  }
}
