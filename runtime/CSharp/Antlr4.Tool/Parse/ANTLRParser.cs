// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.ANTLRParser
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr4.Tool;
using Antlr4.Tool.Ast;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class ANTLRParser : Parser
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
    internal Stack<string> paraphrases;

    public ANTLRParser(ITokenStream input):this(input, new RecognizerSharedState())
    {
      
    }

    public ANTLRParser(ITokenStream input, RecognizerSharedState state):base(input, state)
    {
      this.paraphrases = new Stack<string>();
      
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
        return ANTLRParser.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\ANTLRParser.g3";
      }
    }

    public virtual void GrammarError(ErrorType etype, IToken token, params object[] args)
    {
    }

    [GrammarRule("grammarSpec")]
    public AstParserRuleReturnScope<GrammarAST, IToken> grammarSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token EOF");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule grammarType");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule sync");
      RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule prequelConstruct");
      RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule rules");
      RewriteRuleSubtreeStream ruleSubtreeStream6 = new RewriteRuleSubtreeStream(this.adaptor, "rule modeSpec");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._grammarType_in_grammarSpec403);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.grammarType();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          this.PushFollow(ANTLRParser.Follow._id_in_grammarSpec405);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
          this.PopFollow();
          ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_grammarSpec407);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._sync_in_grammarSpec445);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.sync();
          this.PopFollow();
          ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 11:
                  case 13:
                  case 29:
                  case 42:
                  case 65:
                    num = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(ANTLRParser.Follow._prequelConstruct_in_grammarSpec449);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.prequelConstruct();
                this.PopFollow();
                ruleSubtreeStream4.Add((object) parserRuleReturnScope5.Tree);
                this.PushFollow(ANTLRParser.Follow._sync_in_grammarSpec451);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.sync();
                this.PopFollow();
                ruleSubtreeStream3.Add((object) parserRuleReturnScope6.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          this.PushFollow(ANTLRParser.Follow._rules_in_grammarSpec476);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope7 = this.rules();
          this.PopFollow();
          ruleSubtreeStream5.Add((object) parserRuleReturnScope7.Tree);
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
                this.PushFollow(ANTLRParser.Follow._modeSpec_in_grammarSpec482);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope8 = this.modeSpec();
                this.PopFollow();
                ruleSubtreeStream6.Add((object) parserRuleReturnScope8.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          IToken el2 = (IToken) this.Match((IIntStream) this.input, -1, ANTLRParser.Follow._EOF_in_grammarSpec520);
          rewriteRuleTokenStream2.Add((object) el2);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream7 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream1.NextNode(), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream2.NextTree());
          while (ruleSubtreeStream4.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream4.NextTree());
          ruleSubtreeStream4.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream5.NextTree());
          while (ruleSubtreeStream6.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream6.NextTree());
          ruleSubtreeStream6.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(42);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("grammarType")]
    private AstParserRuleReturnScope<GrammarAST, IToken> grammarType()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      IToken el = (IToken) null;
      IToken token1 = (IToken) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LEXER");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token GRAMMAR");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token PARSER");
      RewriteRuleTokenStream rewriteRuleTokenStream4 = new RewriteRuleTokenStream(this.adaptor, "token TREE_GRAMMAR");
      try
      {
        try
        {
          int num = 4;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 25:
                  num = 3;
                  break;
                case 31:
                  num = 1;
                  break;
                case 44:
                  num = 2;
                  break;
                case 67:
                  num = 4;
                  break;
                default:
                  throw new NoViableAltException("", 3, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num)
            {
              case 1:
                el = (IToken) this.Match((IIntStream) this.input, 31, ANTLRParser.Follow._LEXER_in_grammarType690);
                rewriteRuleTokenStream1.Add((object) el);
                IToken token2 = (IToken) this.Match((IIntStream) this.input, 25, ANTLRParser.Follow._GRAMMAR_in_grammarType694);
                rewriteRuleTokenStream2.Add((object) token2);
                parserRuleReturnScope.Tree = grammarAst;
                RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
                grammarAst = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst, (object) new GrammarRootAST(25, token2, "LEXER_GRAMMAR", this.TokenStream));
                parserRuleReturnScope.Tree = grammarAst;
                break;
              case 2:
                el = (IToken) this.Match((IIntStream) this.input, 44, ANTLRParser.Follow._PARSER_in_grammarType719);
                rewriteRuleTokenStream3.Add((object) el);
                IToken token3 = (IToken) this.Match((IIntStream) this.input, 25, ANTLRParser.Follow._GRAMMAR_in_grammarType723);
                rewriteRuleTokenStream2.Add((object) token3);
                parserRuleReturnScope.Tree = grammarAst;
                RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
                grammarAst = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst, (object) new GrammarRootAST(25, token3, "PARSER_GRAMMAR", this.TokenStream));
                parserRuleReturnScope.Tree = grammarAst;
                break;
              case 3:
                IToken token4 = (IToken) this.Match((IIntStream) this.input, 25, ANTLRParser.Follow._GRAMMAR_in_grammarType746);
                rewriteRuleTokenStream2.Add((object) token4);
                parserRuleReturnScope.Tree = grammarAst;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
                grammarAst = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst, (object) new GrammarRootAST(25, token4, "COMBINED_GRAMMAR", this.TokenStream));
                parserRuleReturnScope.Tree = grammarAst;
                break;
              case 4:
                token1 = (IToken) this.Match((IIntStream) this.input, 67, ANTLRParser.Follow._TREE_GRAMMAR_in_grammarType775);
                rewriteRuleTokenStream4.Add((object) token1);
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
          if (token1 != null)
            throw new v3TreeGrammarException(token1);
          if (el != null)
            ((GrammarRootAST) parserRuleReturnScope.Tree).grammarType = el != null ? el.Type : 0;
          else
            ((GrammarRootAST) parserRuleReturnScope.Tree).grammarType = 80;
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("prequelConstruct")]
    private AstParserRuleReturnScope<GrammarAST, IToken> prequelConstruct()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
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
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._optionsSpec_in_prequelConstruct801);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.optionsSpec();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._delegateGrammars_in_prequelConstruct824);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.delegateGrammars();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
              break;
            case 3:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._tokensSpec_in_prequelConstruct868);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.tokensSpec();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope4.Tree);
              break;
            case 4:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._channelsSpec_in_prequelConstruct878);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.channelsSpec();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope5.Tree);
              break;
            case 5:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._action_in_prequelConstruct915);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.action();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope6.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("optionsSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> optionsSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token OPTIONS");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token RBRACE");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule option");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 42, ANTLRParser.Follow._OPTIONS_in_optionsSpec930);
          rewriteRuleTokenStream1.Add((object) token);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 57:
                  case 66:
                    num = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(ANTLRParser.Follow._option_in_optionsSpec933);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.option();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
                IToken el = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_optionsSpec935);
                rewriteRuleTokenStream2.Add((object) el);
              }
              else
                break;
            }
          }
          finally
          {
          }
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 54, ANTLRParser.Follow._RBRACE_in_optionsSpec939);
          rewriteRuleTokenStream3.Add((object) el1);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(42, token, "OPTIONS"), (object) oldRoot);
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("option")]
    private AstParserRuleReturnScope<GrammarAST, IToken> option()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst1 = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._id_in_option968);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope2.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_option970)), (object) grammarAst1);
          this.PushFollow(ANTLRParser.Follow._optionValue_in_option973);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.optionValue();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst2, (object) parserRuleReturnScope3.Tree);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("optionValue")]
    private AstParserRuleReturnScope<GrammarAST, IToken> optionValue()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
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
                num = 3;
                break;
              case 30:
                num = 4;
                break;
              case 57:
              case 66:
                num = 1;
                break;
              case 62:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 6, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._qid_in_optionValue1016);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.qid();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child1 = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_optionValue1024));
              this.adaptor.AddChild((object) grammarAst, (object) child1);
              break;
            case 3:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child2 = (GrammarAST) new ActionAST((IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_optionValue1029));
              this.adaptor.AddChild((object) grammarAst, (object) child2);
              break;
            case 4:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child3 = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 30, ANTLRParser.Follow._INT_in_optionValue1042));
              this.adaptor.AddChild((object) grammarAst, (object) child3);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("delegateGrammars")]
    private AstParserRuleReturnScope<GrammarAST, IToken> delegateGrammars()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token IMPORT");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COMMA");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule delegateGrammar");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 29, ANTLRParser.Follow._IMPORT_in_delegateGrammars1058);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._delegateGrammar_in_delegateGrammars1060);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.delegateGrammar();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 16)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el2 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_delegateGrammars1063);
                rewriteRuleTokenStream2.Add((object) el2);
                this.PushFollow(ANTLRParser.Follow._delegateGrammar_in_delegateGrammars1065);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.delegateGrammar();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          IToken el3 = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_delegateGrammars1069);
          rewriteRuleTokenStream3.Add((object) el3);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("delegateGrammar")]
    private AstParserRuleReturnScope<GrammarAST, IToken> delegateGrammar()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 57:
                switch (this.input.LA(2))
                {
                  case 10:
                    num = 1;
                    break;
                  case 16:
                  case 58:
                    num = 2;
                    break;
                  default:
                    throw new NoViableAltException("", 8, 1, (IIntStream) this.input, 2);
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 10:
                    num = 1;
                    break;
                  case 16:
                  case 58:
                    num = 2;
                    break;
                  default:
                    throw new NoViableAltException("", 8, 2, (IIntStream) this.input, 2);
                }
                break;
              default:
                throw new NoViableAltException("", 8, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_delegateGrammar1096);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst2, (object) parserRuleReturnScope2.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_delegateGrammar1098)), (object) grammarAst2);
              this.PushFollow(ANTLRParser.Follow._id_in_delegateGrammar1101);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope3.Tree);
              break;
            case 2:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_delegateGrammar1111);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope4.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("tokensSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> tokensSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      IToken token1 = (IToken) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token TOKENS_SPEC");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COMMA");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token RBRACE");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      try
      {
        try
        {
          int num1 = 3;
          try
          {
            if (this.input.LA(1) != 65)
              throw new NoViableAltException("", 12, 0, (IIntStream) this.input, 1);
            switch (this.input.LA(2))
            {
              case 54:
                num1 = 2;
                break;
              case 57:
                switch (this.input.LA(3))
                {
                  case 10:
                  case 58:
                    num1 = 3;
                    break;
                  case 16:
                  case 54:
                    num1 = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 12, 3, (IIntStream) this.input, 3);
                }
                break;
              case 66:
                switch (this.input.LA(3))
                {
                  case 10:
                  case 58:
                    num1 = 3;
                    break;
                  case 16:
                  case 54:
                    num1 = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 12, 4, (IIntStream) this.input, 3);
                }
                break;
              default:
                throw new NoViableAltException("", 12, 1, (IIntStream) this.input, 2);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              IToken el1 = (IToken) this.Match((IIntStream) this.input, 65, ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1125);
              rewriteRuleTokenStream1.Add((object) el1);
              this.PushFollow(ANTLRParser.Follow._id_in_tokensSpec1127);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              try
              {
                while (true)
                {
                  int num2 = 2;
                  try
                  {
                    if (this.input.LA(1) == 16)
                    {
                      switch (this.input.LA(2))
                      {
                        case 57:
                        case 66:
                          num2 = 1;
                          break;
                      }
                    }
                  }
                  finally
                  {
                  }
                  if (num2 == 1)
                  {
                    IToken el2 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_tokensSpec1130);
                    rewriteRuleTokenStream2.Add((object) el2);
                    this.PushFollow(ANTLRParser.Follow._id_in_tokensSpec1132);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
                    this.PopFollow();
                    ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
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
                  if (this.input.LA(1) == 16)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  IToken el3 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_tokensSpec1136);
                  rewriteRuleTokenStream2.Add((object) el3);
                }
              }
              finally
              {
              }
              IToken el4 = (IToken) this.Match((IIntStream) this.input, 54, ANTLRParser.Follow._RBRACE_in_tokensSpec1139);
              rewriteRuleTokenStream3.Add((object) el4);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot1);
              if (!ruleSubtreeStream1.HasNext)
                throw new RewriteEarlyExitException();
              while (ruleSubtreeStream1.HasNext)
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
              ruleSubtreeStream1.Reset();
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 2:
              IToken el5 = (IToken) this.Match((IIntStream) this.input, 65, ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1156);
              rewriteRuleTokenStream1.Add((object) el5);
              IToken el6 = (IToken) this.Match((IIntStream) this.input, 54, ANTLRParser.Follow._RBRACE_in_tokensSpec1158);
              rewriteRuleTokenStream3.Add((object) el6);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              GrammarAST grammarAst3 = (GrammarAST) this.adaptor.Nil();
              grammarAst1 = (GrammarAST) null;
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 3:
              GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
              IToken token2 = (IToken) this.Match((IIntStream) this.input, 65, ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1168);
              grammarAst1 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(token2), (object) oldRoot2);
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
                      case 57:
                      case 66:
                        num5 = 1;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  if (num5 == 1)
                  {
                    this.PushFollow(ANTLRParser.Follow._v3tokenSpec_in_tokensSpec1171);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.v3tokenSpec();
                    this.PopFollow();
                    this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope4.Tree);
                    ++num4;
                  }
                  else
                    break;
                }
                if (num4 < 1)
                  throw new EarlyExitException(11, (IIntStream) this.input);
              }
              finally
              {
              }
              token1 = (IToken) this.Match((IIntStream) this.input, 54, ANTLRParser.Follow._RBRACE_in_tokensSpec1174);
              this.GrammarError(ErrorType.V3_TOKENS_SYNTAX, token2, new object[0]);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("v3tokenSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> v3tokenSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token ASSIGN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token STRING_LITERAL");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._id_in_v3tokenSpec1194);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          int num = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 10:
                  num = 1;
                  break;
                case 58:
                  num = 2;
                  break;
                default:
                  throw new NoViableAltException("", 13, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num)
            {
              case 1:
                IToken el1 = (IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_v3tokenSpec1200);
                rewriteRuleTokenStream1.Add((object) el1);
                IToken el2 = (IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_v3tokenSpec1204);
                rewriteRuleTokenStream2.Add((object) el2);
                this.GrammarError(ErrorType.V3_ASSIGN_IN_TOKENS, parserRuleReturnScope2?.Start, new object[2]
                {
                  parserRuleReturnScope2 != null ? (object) this.input.ToString(parserRuleReturnScope2.Start, parserRuleReturnScope2.Stop) : (object) (string) null,
                  (object) el2.Text
                });
                parserRuleReturnScope1.Tree = grammarAst;
                RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst, ruleSubtreeStream1.NextTree());
                parserRuleReturnScope1.Tree = grammarAst;
                break;
              case 2:
                parserRuleReturnScope1.Tree = grammarAst;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst, ruleSubtreeStream1.NextTree());
                parserRuleReturnScope1.Tree = grammarAst;
                break;
            }
          }
          finally
          {
          }
          IToken el = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_v3tokenSpec1265);
          rewriteRuleTokenStream3.Add((object) el);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("channelsSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> channelsSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      IToken token1 = (IToken) null;
      IToken token2 = (IToken) null;
      try
      {
        try
        {
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 13, ANTLRParser.Follow._CHANNELS_in_channelsSpec1276)), (object) oldRoot);
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 57:
                case 66:
                  num1 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._id_in_channelsSpec1280);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              try
              {
                while (true)
                {
                  int num2 = 2;
                  try
                  {
                    if (this.input.LA(1) == 16)
                    {
                      switch (this.input.LA(2))
                      {
                        case 57:
                        case 66:
                          num2 = 1;
                          break;
                      }
                    }
                  }
                  finally
                  {
                  }
                  if (num2 == 1)
                  {
                    token1 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_channelsSpec1283);
                    this.PushFollow(ANTLRParser.Follow._id_in_channelsSpec1286);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
                    this.PopFollow();
                    this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
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
                  if (this.input.LA(1) == 16)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_channelsSpec1290));
                  this.adaptor.AddChild((object) grammarAst, (object) child);
                }
              }
              finally
              {
              }
            }
          }
          finally
          {
          }
          token2 = (IToken) this.Match((IIntStream) this.input, 54, ANTLRParser.Follow._RBRACE_in_channelsSpec1295);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("action")]
    private AstParserRuleReturnScope<GrammarAST, IToken> action()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token AT");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COLONCOLON");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token ACTION");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule actionScopeName");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 11, ANTLRParser.Follow._AT_in_action1312);
          rewriteRuleTokenStream1.Add((object) el1);
          int num = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 31:
                case 44:
                  num = 1;
                  break;
                case 57:
                  if (this.input.LA(2) == 15)
                  {
                    num = 1;
                    break;
                  }
                  break;
                case 66:
                  if (this.input.LA(2) == 15)
                  {
                    num = 1;
                    break;
                  }
                  break;
              }
            }
            finally
            {
            }
            if (num == 1)
            {
              this.PushFollow(ANTLRParser.Follow._actionScopeName_in_action1315);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.actionScopeName();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 15, ANTLRParser.Follow._COLONCOLON_in_action1317);
              rewriteRuleTokenStream2.Add((object) el2);
            }
          }
          finally
          {
          }
          this.PushFollow(ANTLRParser.Follow._id_in_action1321);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
          this.PopFollow();
          ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
          IToken el3 = (IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_action1323);
          rewriteRuleTokenStream3.Add((object) el3);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream2.NextTree());
          this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream3.NextToken()));
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("actionScopeName")]
    private AstParserRuleReturnScope<GrammarAST, IToken> actionScopeName()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LEXER");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token PARSER");
      try
      {
        try
        {
          int num = 3;
          try
          {
            switch (this.input.LA(1))
            {
              case 31:
                num = 2;
                break;
              case 44:
                num = 3;
                break;
              case 57:
              case 66:
                num = 1;
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
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_actionScopeName1354);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              IToken token1 = (IToken) this.Match((IIntStream) this.input, 31, ANTLRParser.Follow._LEXER_in_actionScopeName1359);
              rewriteRuleTokenStream1.Add((object) token1);
              parserRuleReturnScope1.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) (GrammarAST) this.adaptor.Create(28, token1));
              parserRuleReturnScope1.Tree = grammarAst;
              break;
            case 3:
              IToken token2 = (IToken) this.Match((IIntStream) this.input, 44, ANTLRParser.Follow._PARSER_in_actionScopeName1374);
              rewriteRuleTokenStream2.Add((object) token2);
              parserRuleReturnScope1.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) (GrammarAST) this.adaptor.Create(28, token2));
              parserRuleReturnScope1.Tree = grammarAst;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("modeSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> modeSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token MODE");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule sync");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerRule");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 36, ANTLRParser.Follow._MODE_in_modeSpec1393);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._id_in_modeSpec1395);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          IToken el2 = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_modeSpec1397);
          rewriteRuleTokenStream2.Add((object) el2);
          this.PushFollow(ANTLRParser.Follow._sync_in_modeSpec1399);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.sync();
          this.PopFollow();
          ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 24:
                  case 66:
                    num = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(ANTLRParser.Follow._lexerRule_in_modeSpec1402);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.lexerRule();
                this.PopFollow();
                ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
                this.PushFollow(ANTLRParser.Follow._sync_in_modeSpec1404);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.sync();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope5.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          while (ruleSubtreeStream3.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream3.NextTree());
          ruleSubtreeStream3.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("rules")]
    private AstParserRuleReturnScope<GrammarAST, IToken> rules()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule sync");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule rule");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._sync_in_rules1435);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.sync();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 24:
                  case 57:
                  case 66:
                    num = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(ANTLRParser.Follow._rule_in_rules1438);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.rule();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                this.PushFollow(ANTLRParser.Follow._sync_in_rules1440);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.sync();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope4.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(96, "RULES"), (object) oldRoot);
          while (ruleSubtreeStream2.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream2.NextTree());
          ruleSubtreeStream2.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("sync")]
    private AstParserRuleReturnScope<GrammarAST, IToken> sync()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST root = (GrammarAST) this.adaptor.Nil();
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) root);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("rule")]
    public AstParserRuleReturnScope<GrammarAST, IToken> rule()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 24:
              case 66:
                num = 2;
                break;
              case 57:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 21, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._parserRule_in_rule1504);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.parserRule();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._lexerRule_in_rule1509);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerRule();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("parserRule")]
    private AstParserRuleReturnScope<GrammarAST, IToken> parserRule()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token RULE_REF");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token ARG_ACTION");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token COLON");
      RewriteRuleTokenStream rewriteRuleTokenStream4 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule ruleReturns");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule throwsSpec");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule localsSpec");
      RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule rulePrequels");
      RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule ruleBlock");
      RewriteRuleSubtreeStream ruleSubtreeStream6 = new RewriteRuleSubtreeStream(this.adaptor, "rule exceptionGroup");
      this.paraphrases.Push("matching a rule");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 57, ANTLRParser.Follow._RULE_REF_in_parserRule1558);
          rewriteRuleTokenStream1.Add((object) el1);
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
            {
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 8, ANTLRParser.Follow._ARG_ACTION_in_parserRule1588);
              rewriteRuleTokenStream2.Add((object) el2);
            }
          }
          finally
          {
          }
          int num2 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 55)
                num2 = 1;
            }
            finally
            {
            }
            if (num2 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._ruleReturns_in_parserRule1595);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.ruleReturns();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
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
              if (this.input.LA(1) == 64)
                num3 = 1;
            }
            finally
            {
            }
            if (num3 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._throwsSpec_in_parserRule1602);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.throwsSpec();
              this.PopFollow();
              ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
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
              if (this.input.LA(1) == 33)
                num4 = 1;
            }
            finally
            {
            }
            if (num4 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._localsSpec_in_parserRule1609);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.localsSpec();
              this.PopFollow();
              ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
            }
          }
          finally
          {
          }
          this.PushFollow(ANTLRParser.Follow._rulePrequels_in_parserRule1647);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.rulePrequels();
          this.PopFollow();
          ruleSubtreeStream4.Add((object) parserRuleReturnScope5.Tree);
          IToken el3 = (IToken) this.Match((IIntStream) this.input, 14, ANTLRParser.Follow._COLON_in_parserRule1656);
          rewriteRuleTokenStream3.Add((object) el3);
          this.PushFollow(ANTLRParser.Follow._ruleBlock_in_parserRule1679);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.ruleBlock();
          this.PopFollow();
          ruleSubtreeStream5.Add((object) parserRuleReturnScope6.Tree);
          IToken el4 = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_parserRule1688);
          rewriteRuleTokenStream4.Add((object) el4);
          this.PushFollow(ANTLRParser.Follow._exceptionGroup_in_parserRule1697);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope7 = this.exceptionGroup();
          this.PopFollow();
          ruleSubtreeStream6.Add((object) parserRuleReturnScope7.Tree);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream7 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new RuleAST(93), (object) (GrammarAST) this.adaptor.Nil());
          this.adaptor.AddChild((object) grammarAst3, rewriteRuleTokenStream1.NextNode());
          if (rewriteRuleTokenStream2.HasNext)
            this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream2.NextToken()));
          rewriteRuleTokenStream2.Reset();
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          if (ruleSubtreeStream2.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream2.NextTree());
          ruleSubtreeStream2.Reset();
          if (ruleSubtreeStream3.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream3.NextTree());
          ruleSubtreeStream3.Reset();
          if (ruleSubtreeStream4.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream4.NextTree());
          ruleSubtreeStream4.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream5.NextTree());
          while (ruleSubtreeStream6.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream6.NextTree());
          ruleSubtreeStream6.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(42);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("exceptionGroup")]
    private AstParserRuleReturnScope<GrammarAST, IToken> exceptionGroup()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
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
                this.PushFollow(ANTLRParser.Follow._exceptionHandler_in_exceptionGroup1784);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.exceptionHandler();
                this.PopFollow();
                this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
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
              this.PushFollow(ANTLRParser.Follow._finallyClause_in_exceptionGroup1787);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.finallyClause();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("exceptionHandler")]
    private AstParserRuleReturnScope<GrammarAST, IToken> exceptionHandler()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token CATCH");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token ARG_ACTION");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token ACTION");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 12, ANTLRParser.Follow._CATCH_in_exceptionHandler1804);
          rewriteRuleTokenStream1.Add((object) el1);
          IToken el2 = (IToken) this.Match((IIntStream) this.input, 8, ANTLRParser.Follow._ARG_ACTION_in_exceptionHandler1806);
          rewriteRuleTokenStream2.Add((object) el2);
          IToken el3 = (IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_exceptionHandler1808);
          rewriteRuleTokenStream3.Add((object) el3);
          parserRuleReturnScope.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream2.NextToken()));
          this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream3.NextToken()));
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope.Tree = grammarAst2;
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("finallyClause")]
    private AstParserRuleReturnScope<GrammarAST, IToken> finallyClause()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token FINALLY");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token ACTION");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 23, ANTLRParser.Follow._FINALLY_in_finallyClause1839);
          rewriteRuleTokenStream1.Add((object) el1);
          IToken el2 = (IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_finallyClause1841);
          rewriteRuleTokenStream2.Add((object) el2);
          parserRuleReturnScope.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream2.NextToken()));
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope.Tree = grammarAst2;
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("rulePrequels")]
    private AstParserRuleReturnScope<GrammarAST, IToken> rulePrequels()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule sync");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule rulePrequel");
      this.paraphrases.Push("matching rule preamble");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._sync_in_rulePrequels1875);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.sync();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 11:
                  case 42:
                    num = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num == 1)
              {
                this.PushFollow(ANTLRParser.Follow._rulePrequel_in_rulePrequels1878);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.rulePrequel();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                this.PushFollow(ANTLRParser.Follow._sync_in_rulePrequels1880);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.sync();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope4.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          while (ruleSubtreeStream2.HasNext)
            this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream2.NextTree());
          ruleSubtreeStream2.Reset();
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("rulePrequel")]
    private AstParserRuleReturnScope<GrammarAST, IToken> rulePrequel()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 11:
                num = 2;
                break;
              case 42:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 29, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._optionsSpec_in_rulePrequel1904);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.optionsSpec();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._ruleAction_in_rulePrequel1912);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.ruleAction();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ruleReturns")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleReturns()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 55, ANTLRParser.Follow._RETURNS_in_ruleReturns1932)), (object) oldRoot);
          GrammarAST child = (GrammarAST) new ActionAST((IToken) this.Match((IIntStream) this.input, 8, ANTLRParser.Follow._ARG_ACTION_in_ruleReturns1935));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("throwsSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> throwsSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token THROWS");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COMMA");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule qid");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 64, ANTLRParser.Follow._THROWS_in_throwsSpec1965);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._qid_in_throwsSpec1967);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.qid();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 16)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el2 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_throwsSpec1970);
                rewriteRuleTokenStream2.Add((object) el2);
                this.PushFollow(ANTLRParser.Follow._qid_in_throwsSpec1972);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.qid();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("localsSpec")]
    private AstParserRuleReturnScope<GrammarAST, IToken> localsSpec()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 33, ANTLRParser.Follow._LOCALS_in_localsSpec1997)), (object) oldRoot);
          GrammarAST child = (GrammarAST) new ActionAST((IToken) this.Match((IIntStream) this.input, 8, ANTLRParser.Follow._ARG_ACTION_in_localsSpec2000));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("ruleAction")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleAction()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token AT");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token ACTION");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 11, ANTLRParser.Follow._AT_in_ruleAction2025);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._id_in_ruleAction2027);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          IToken el2 = (IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_ruleAction2029);
          rewriteRuleTokenStream2.Add((object) el2);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream1.NextNode(), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream2.NextToken()));
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ruleBlock")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleBlock()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule ruleAltList");
      IToken t = this.input.LT(-1);
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._ruleAltList_in_ruleBlock2069);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.ruleAltList();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, t, "BLOCK"), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (ResyncToEndOfRuleBlock ex)
        {
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), (RecognitionException) null);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ruleAltList")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleAltList()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token OR");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule labeledAlt");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._labeledAlt_in_ruleAltList2107);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.labeledAlt();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 43)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el = (IToken) this.Match((IIntStream) this.input, 43, ANTLRParser.Follow._OR_in_ruleAltList2110);
                rewriteRuleTokenStream.Add((object) el);
                this.PushFollow(ANTLRParser.Follow._labeledAlt_in_ruleAltList2112);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.labeledAlt();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("labeledAlt")]
    private AstParserRuleReturnScope<GrammarAST, IToken> labeledAlt()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      IToken token = (IToken) null;
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._alternative_in_labeledAlt2130);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.alternative();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 47)
                num = 1;
            }
            finally
            {
            }
            if (num == 1)
            {
              token = (IToken) this.Match((IIntStream) this.input, 47, ANTLRParser.Follow._POUND_in_labeledAlt2136);
              this.PushFollow(ANTLRParser.Follow._id_in_labeledAlt2139);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
              this.PopFollow();
              ((AltAST) parserRuleReturnScope2?.Tree).altLabel = parserRuleReturnScope3?.Tree;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerRule")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerRule()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token FRAGMENT");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token TOKEN_REF");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token COLON");
      RewriteRuleTokenStream rewriteRuleTokenStream4 = new RewriteRuleTokenStream(this.adaptor, "token SEMI");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerRuleBlock");
      this.paraphrases.Push("matching a lexer rule");
      try
      {
        try
        {
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 24)
                num = 1;
            }
            finally
            {
            }
            if (num == 1)
            {
              IToken el = (IToken) this.Match((IIntStream) this.input, 24, ANTLRParser.Follow._FRAGMENT_in_lexerRule2171);
              rewriteRuleTokenStream1.Add((object) el);
            }
          }
          finally
          {
          }
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 66, ANTLRParser.Follow._TOKEN_REF_in_lexerRule2177);
          rewriteRuleTokenStream2.Add((object) el1);
          IToken el2 = (IToken) this.Match((IIntStream) this.input, 14, ANTLRParser.Follow._COLON_in_lexerRule2179);
          rewriteRuleTokenStream3.Add((object) el2);
          this.PushFollow(ANTLRParser.Follow._lexerRuleBlock_in_lexerRule2181);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerRuleBlock();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          IToken el3 = (IToken) this.Match((IIntStream) this.input, 58, ANTLRParser.Follow._SEMI_in_lexerRule2183);
          rewriteRuleTokenStream4.Add((object) el3);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new RuleAST(93), (object) (GrammarAST) this.adaptor.Nil());
          this.adaptor.AddChild((object) grammarAst3, rewriteRuleTokenStream2.NextNode());
          if (rewriteRuleTokenStream1.HasNext)
          {
            GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
            GrammarAST grammarAst4 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(95, "RULEMODIFIERS"), (object) oldRoot);
            this.adaptor.AddChild((object) grammarAst4, rewriteRuleTokenStream1.NextNode());
            this.adaptor.AddChild((object) grammarAst3, (object) grammarAst4);
          }
          rewriteRuleTokenStream1.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerRuleBlock")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerRuleBlock()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerAltList");
      IToken t = this.input.LT(-1);
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._lexerAltList_in_lexerRuleBlock2249);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerAltList();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, t, "BLOCK"), (object) oldRoot);
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (ResyncToEndOfRuleBlock ex)
        {
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), (RecognitionException) null);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerAltList")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerAltList()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token OR");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerAlt");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._lexerAlt_in_lexerAltList2287);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerAlt();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 43)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el = (IToken) this.Match((IIntStream) this.input, 43, ANTLRParser.Follow._OR_in_lexerAltList2290);
                rewriteRuleTokenStream.Add((object) el);
                this.PushFollow(ANTLRParser.Follow._lexerAlt_in_lexerAltList2292);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerAlt();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerAlt")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerAlt()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerElements");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerCommands");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._lexerElements_in_lexerAlt2310);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerElements();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          int num = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 43:
                case 56:
                case 58:
                  num = 2;
                  break;
                case 53:
                  num = 1;
                  break;
                default:
                  throw new NoViableAltException("", 35, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num)
            {
              case 1:
                this.PushFollow(ANTLRParser.Follow._lexerCommands_in_lexerAlt2316);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerCommands();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(86), (object) (GrammarAST) this.adaptor.Nil());
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream2.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
              case 2:
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream1.NextTree());
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerElements")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerElements()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerElement");
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
              case 20:
              case 32:
              case 34:
              case 39:
              case 57:
              case 59:
              case 62:
              case 66:
                num1 = 1;
                break;
              case 43:
              case 53:
              case 56:
              case 58:
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 37, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
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
                      case 4:
                      case 20:
                      case 32:
                      case 34:
                      case 39:
                      case 57:
                      case 59:
                      case 62:
                      case 66:
                        num3 = 1;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  if (num3 == 1)
                  {
                    this.PushFollow(ANTLRParser.Follow._lexerElement_in_lexerElements2361);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerElement();
                    this.PopFollow();
                    ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
                    ++num2;
                  }
                  else
                    break;
                }
                if (num2 < 1)
                  throw new EarlyExitException(36, (IIntStream) this.input);
              }
              finally
              {
              }
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
              if (!ruleSubtreeStream1.HasNext)
                throw new RewriteEarlyExitException();
              while (ruleSubtreeStream1.HasNext)
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
              ruleSubtreeStream1.Reset();
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 2:
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
              this.adaptor.AddChild((object) grammarAst3, (object) (GrammarAST) this.adaptor.Create(82, "EPSILON"));
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerElement")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerElement()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule labeledLexerElement");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule ebnfSuffix");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerAtom");
      RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerBlock");
      this.paraphrases.Push("looking for lexer rule element");
      this.input.Mark();
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
              case 59:
                num1 = 4;
                break;
              case 20:
              case 32:
              case 39:
              case 62:
                num1 = 2;
                break;
              case 34:
                num1 = 3;
                break;
              case 57:
                int num2 = this.input.LA(2);
                if (num2 == 10 || num2 == 46)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != 4 && num2 != 20 && num2 != 32 && num2 != 34 && num2 != 39 && num2 != 43 && num2 != 45 && num2 != 51 && num2 != 53 && (num2 < 56 || num2 > 59) && (num2 < 61 || num2 > 62) && num2 != 66)
                  throw new NoViableAltException("", 41, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                int num3 = this.input.LA(2);
                if (num3 == 10 || num3 == 46)
                {
                  num1 = 1;
                  break;
                }
                if (num3 != 4 && num3 != 20 && num3 != 32 && (num3 < 34 || num3 > 35) && num3 != 39 && num3 != 43 && num3 != 45 && num3 != 51 && num3 != 53 && (num3 < 56 || num3 > 59) && (num3 < 61 || num3 > 62) && num3 != 66)
                  throw new NoViableAltException("", 41, 2, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 41, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(ANTLRParser.Follow._labeledLexerElement_in_lexerElement2421);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.labeledLexerElement();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              int num4 = 2;
              try
              {
                try
                {
                  int num5 = this.input.LA(1);
                  if (num5 == 45 || num5 == 51 || num5 == 61)
                  {
                    num4 = 1;
                  }
                  else
                  {
                    if (num5 != 4 && num5 != 20 && num5 != 32 && num5 != 34 && num5 != 39 && num5 != 43 && num5 != 53 && (num5 < 56 || num5 > 59) && num5 != 62 && num5 != 66)
                      throw new NoViableAltException("", 38, 0, (IIntStream) this.input, 1);
                    num4 = 2;
                  }
                }
                finally
                {
                }
                switch (num4)
                {
                  case 1:
                    this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_lexerElement2427);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.ebnfSuffix();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot1);
                    GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, parserRuleReturnScope2?.Start, "BLOCK"), (object) oldRoot2);
                    GrammarAST grammarAst4 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                    this.adaptor.AddChild((object) grammarAst4, ruleSubtreeStream1.NextTree());
                    this.adaptor.AddChild((object) grammarAst3, (object) grammarAst4);
                    this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
                    this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                  case 2:
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream6 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream1.NextTree());
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 2:
              this.PushFollow(ANTLRParser.Follow._lexerAtom_in_lexerElement2477);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.lexerAtom();
              this.PopFollow();
              ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
              int num6 = 2;
              try
              {
                try
                {
                  int num7 = this.input.LA(1);
                  if (num7 == 45 || num7 == 51 || num7 == 61)
                  {
                    num6 = 1;
                  }
                  else
                  {
                    if (num7 != 4 && num7 != 20 && num7 != 32 && num7 != 34 && num7 != 39 && num7 != 43 && num7 != 53 && (num7 < 56 || num7 > 59) && num7 != 62 && num7 != 66)
                      throw new NoViableAltException("", 39, 0, (IIntStream) this.input, 1);
                    num6 = 2;
                  }
                }
                finally
                {
                }
                switch (num6)
                {
                  case 1:
                    this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_lexerElement2483);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.ebnfSuffix();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope5.Tree);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream7 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST oldRoot3 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst5 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot3);
                    GrammarAST oldRoot4 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst6 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, parserRuleReturnScope4?.Start, "BLOCK"), (object) oldRoot4);
                    GrammarAST grammarAst7 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                    this.adaptor.AddChild((object) grammarAst7, ruleSubtreeStream3.NextTree());
                    this.adaptor.AddChild((object) grammarAst6, (object) grammarAst7);
                    this.adaptor.AddChild((object) grammarAst5, (object) grammarAst6);
                    this.adaptor.AddChild((object) grammarAst1, (object) grammarAst5);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                  case 2:
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream8 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream3.NextTree());
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 3:
              this.PushFollow(ANTLRParser.Follow._lexerBlock_in_lexerElement2533);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.lexerBlock();
              this.PopFollow();
              ruleSubtreeStream4.Add((object) parserRuleReturnScope6.Tree);
              int num8 = 2;
              try
              {
                try
                {
                  int num9 = this.input.LA(1);
                  if (num9 == 45 || num9 == 51 || num9 == 61)
                  {
                    num8 = 1;
                  }
                  else
                  {
                    if (num9 != 4 && num9 != 20 && num9 != 32 && num9 != 34 && num9 != 39 && num9 != 43 && num9 != 53 && (num9 < 56 || num9 > 59) && num9 != 62 && num9 != 66)
                      throw new NoViableAltException("", 40, 0, (IIntStream) this.input, 1);
                    num8 = 2;
                  }
                }
                finally
                {
                }
                switch (num8)
                {
                  case 1:
                    this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_lexerElement2539);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope7 = this.ebnfSuffix();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope7.Tree);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream9 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst8 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot);
                    this.adaptor.AddChild((object) grammarAst8, ruleSubtreeStream4.NextTree());
                    this.adaptor.AddChild((object) grammarAst1, (object) grammarAst8);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                  case 2:
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream10 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream4.NextTree());
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 4:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._actionElement_in_lexerElement2567);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope8 = this.actionElement();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope8.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
          int type = this.input.Get(this.input.Range).Type;
          switch (type)
          {
            case -1:
            case 11:
            case 12:
            case 14:
            case 23:
            case 55:
              this.ReportError((RecognitionException) new v4ParserException("unterminated rule (missing ';') detected at '" + this.input.LT(1).Text + " " + this.input.LT(2).Text + "'", (IIntStream) this.input));
              if (type == -1)
                this.input.Seek(this.input.Index + 1);
              else if (type == 12 || type == 23)
                this.input.Seek(this.input.Range);
              else if (type == 55 || type == 11)
              {
                int index = this.input.Index;
                for (IToken token = this.input.Get(index); token.Type != 57 && token.Type != 66; token = this.input.Get(index))
                  --index;
                this.input.Seek(index);
              }
              throw new ResyncToEndOfRuleBlock();
            default:
              this.ReportError(ex);
              this.Recover((IIntStream) this.input, ex);
              break;
          }
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("labeledLexerElement")]
    private AstParserRuleReturnScope<GrammarAST, IToken> labeledLexerElement()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      IToken token = (IToken) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token ASSIGN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token PLUS_ASSIGN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerAtom");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerBlock");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._id_in_labeledLexerElement2597);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 10:
                  num1 = 1;
                  break;
                case 46:
                  num1 = 2;
                  break;
                default:
                  throw new NoViableAltException("", 42, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num1)
            {
              case 1:
                token = (IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_labeledLexerElement2602);
                rewriteRuleTokenStream1.Add((object) token);
                break;
              case 2:
                token = (IToken) this.Match((IIntStream) this.input, 46, ANTLRParser.Follow._PLUS_ASSIGN_in_labeledLexerElement2606);
                rewriteRuleTokenStream2.Add((object) token);
                break;
            }
          }
          finally
          {
          }
          int num2 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 20:
                case 32:
                case 39:
                case 57:
                case 62:
                case 66:
                  num2 = 1;
                  break;
                case 34:
                  num2 = 2;
                  break;
                default:
                  throw new NoViableAltException("", 43, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num2)
            {
              case 1:
                this.PushFollow(ANTLRParser.Follow._lexerAtom_in_labeledLexerElement2613);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerAtom();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token ass", (object) token);
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream3.NextNode(), (object) oldRoot1);
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream2.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
              case 2:
                this.PushFollow(ANTLRParser.Follow._lexerBlock_in_labeledLexerElement2630);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.lexerBlock();
                this.PopFollow();
                ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleTokenStream rewriteRuleTokenStream4 = new RewriteRuleTokenStream(this.adaptor, "token ass", (object) token);
                RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream4.NextNode(), (object) oldRoot2);
                this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream3.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerBlock")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerBlock()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LPAREN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COLON");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token RPAREN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule optionsSpec");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerAltList");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 34, ANTLRParser.Follow._LPAREN_in_lexerBlock2663);
          rewriteRuleTokenStream1.Add((object) token);
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 42)
                num = 1;
            }
            finally
            {
            }
            if (num == 1)
            {
              this.PushFollow(ANTLRParser.Follow._optionsSpec_in_lexerBlock2675);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.optionsSpec();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              IToken el = (IToken) this.Match((IIntStream) this.input, 14, ANTLRParser.Follow._COLON_in_lexerBlock2677);
              rewriteRuleTokenStream2.Add((object) el);
            }
          }
          finally
          {
          }
          this.PushFollow(ANTLRParser.Follow._lexerAltList_in_lexerBlock2690);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerAltList();
          this.PopFollow();
          ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 56, ANTLRParser.Follow._RPAREN_in_lexerBlock2700);
          rewriteRuleTokenStream3.Add((object) el1);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, token, "BLOCK"), (object) oldRoot);
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream2.NextTree());
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(42);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerCommands")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerCommands()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token RARROW");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COMMA");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerCommand");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 53, ANTLRParser.Follow._RARROW_in_lexerCommands2739);
          rewriteRuleTokenStream1.Add((object) el1);
          this.PushFollow(ANTLRParser.Follow._lexerCommand_in_lexerCommands2741);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerCommand();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 16)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el2 = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_lexerCommands2744);
                rewriteRuleTokenStream2.Add((object) el2);
                this.PushFollow(ANTLRParser.Follow._lexerCommand_in_lexerCommands2746);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerCommand();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerCommand")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerCommand()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LPAREN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token RPAREN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerCommandName");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule lexerCommandExpr");
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 36:
                switch (this.input.LA(2))
                {
                  case 16:
                  case 43:
                  case 56:
                  case 58:
                    num = 2;
                    break;
                  case 34:
                    num = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 46, 3, (IIntStream) this.input, 2);
                }
                break;
              case 57:
                switch (this.input.LA(2))
                {
                  case 16:
                  case 43:
                  case 56:
                  case 58:
                    num = 2;
                    break;
                  case 34:
                    num = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 46, 1, (IIntStream) this.input, 2);
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 16:
                  case 43:
                  case 56:
                  case 58:
                    num = 2;
                    break;
                  case 34:
                    num = 1;
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
              this.PushFollow(ANTLRParser.Follow._lexerCommandName_in_lexerCommand2764);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.lexerCommandName();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              IToken el1 = (IToken) this.Match((IIntStream) this.input, 34, ANTLRParser.Follow._LPAREN_in_lexerCommand2766);
              rewriteRuleTokenStream1.Add((object) el1);
              this.PushFollow(ANTLRParser.Follow._lexerCommandExpr_in_lexerCommand2768);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.lexerCommandExpr();
              this.PopFollow();
              ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 56, ANTLRParser.Follow._RPAREN_in_lexerCommand2770);
              rewriteRuleTokenStream2.Add((object) el2);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(85, "LEXER_ACTION_CALL"), (object) oldRoot);
              this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
              this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream2.NextTree());
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 2:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._lexerCommandName_in_lexerCommand2785);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.lexerCommandName();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope4.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerCommandExpr")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerCommandExpr()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 30:
                num = 2;
                break;
              case 57:
              case 66:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 47, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_lexerCommandExpr2796);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 30, ANTLRParser.Follow._INT_in_lexerCommandExpr2801));
              this.adaptor.AddChild((object) grammarAst, (object) child);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("lexerCommandName")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerCommandName()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token MODE");
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 36:
                num = 2;
                break;
              case 57:
              case 66:
                num = 1;
                break;
              default:
                throw new NoViableAltException("", 48, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_lexerCommandName2825);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              IToken token = (IToken) this.Match((IIntStream) this.input, 36, ANTLRParser.Follow._MODE_in_lexerCommandName2843);
              rewriteRuleTokenStream.Add((object) token);
              parserRuleReturnScope1.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) (GrammarAST) this.adaptor.Create(28, token));
              parserRuleReturnScope1.Tree = grammarAst;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("altList")]
    private AstParserRuleReturnScope<GrammarAST, IToken> altList()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token OR");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule alternative");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._alternative_in_altList2871);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.alternative();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 43)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el = (IToken) this.Match((IIntStream) this.input, 43, ANTLRParser.Follow._OR_in_altList2874);
                rewriteRuleTokenStream.Add((object) el);
                this.PushFollow(ANTLRParser.Follow._alternative_in_altList2876);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.alternative();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("alternative")]
    private AstParserRuleReturnScope<GrammarAST, IToken> alternative()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      List<GrammarAST> elements = (List<GrammarAST>) null;
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = (AstParserRuleReturnScope<GrammarAST, IToken>) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule element");
      this.paraphrases.Push("matching alternative");
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 35)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._elementOptions_in_alternative2910);
              parserRuleReturnScope2 = this.elementOptions();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
            }
          }
          finally
          {
          }
          int num2 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case -1:
                case 43:
                case 47:
                case 56:
                case 58:
                  num2 = 2;
                  break;
                case 4:
                case 20:
                case 34:
                case 39:
                case 57:
                case 59:
                case 62:
                case 66:
                  num2 = 1;
                  break;
                default:
                  throw new NoViableAltException("", 52, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num2)
            {
              case 1:
                int num3 = 0;
                try
                {
                  while (true)
                  {
                    int num4 = 2;
                    try
                    {
                      switch (this.input.LA(1))
                      {
                        case 4:
                        case 20:
                        case 34:
                        case 39:
                        case 57:
                        case 59:
                        case 62:
                        case 66:
                          num4 = 1;
                          break;
                      }
                    }
                    finally
                    {
                    }
                    if (num4 == 1)
                    {
                      this.PushFollow(ANTLRParser.Follow._element_in_alternative2919);
                      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.element();
                      this.PopFollow();
                      ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                      if (elements == null)
                        elements = new List<GrammarAST>();
                      elements.Add(parserRuleReturnScope3.Tree);
                      ++num3;
                    }
                    else
                      break;
                  }
                  if (num3 < 1)
                    throw new EarlyExitException(51, (IIntStream) this.input);
                }
                finally
                {
                }
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "token e", (IList) elements);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                if (ruleSubtreeStream1.HasNext)
                  this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
                ruleSubtreeStream1.Reset();
                if (!ruleSubtreeStream4.HasNext)
                  throw new RewriteEarlyExitException();
                while (ruleSubtreeStream4.HasNext)
                  this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream4.NextTree());
                ruleSubtreeStream4.Reset();
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
              case 2:
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                if (ruleSubtreeStream1.HasNext)
                  this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
                ruleSubtreeStream1.Reset();
                this.adaptor.AddChild((object) grammarAst3, (object) (GrammarAST) this.adaptor.Create(82, "EPSILON"));
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
          Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, parserRuleReturnScope2?.Tree);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("element")]
    private AstParserRuleReturnScope<GrammarAST, IToken> element()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule labeledElement");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule ebnfSuffix");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule atom");
      this.paraphrases.Push("looking for rule element");
      this.input.Mark();
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
              case 59:
                num1 = 4;
                break;
              case 20:
              case 39:
              case 62:
                num1 = 2;
                break;
              case 34:
                num1 = 3;
                break;
              case 57:
                int num2 = this.input.LA(2);
                if (num2 == 10 || num2 == 46)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != -1 && num2 != 4 && num2 != 8 && num2 != 20 && (num2 < 34 || num2 > 35) && num2 != 39 && num2 != 43 && num2 != 45 && num2 != 47 && num2 != 51 && (num2 < 56 || num2 > 59) && (num2 < 61 || num2 > 62) && num2 != 66)
                  throw new NoViableAltException("", 55, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                int num3 = this.input.LA(2);
                if (num3 == 10 || num3 == 46)
                {
                  num1 = 1;
                  break;
                }
                if (num3 != -1 && num3 != 4 && num3 != 20 && (num3 < 34 || num3 > 35) && num3 != 39 && num3 != 43 && num3 != 45 && num3 != 47 && num3 != 51 && (num3 < 56 || num3 > 59) && (num3 < 61 || num3 > 62) && num3 != 66)
                  throw new NoViableAltException("", 55, 2, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 55, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(ANTLRParser.Follow._labeledElement_in_element3038);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.labeledElement();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              int num4 = 2;
              try
              {
                try
                {
                  int num5 = this.input.LA(1);
                  if (num5 == 45 || num5 == 51 || num5 == 61)
                  {
                    num4 = 1;
                  }
                  else
                  {
                    if (num5 != -1 && num5 != 4 && num5 != 20 && num5 != 34 && num5 != 39 && num5 != 43 && num5 != 47 && (num5 < 56 || num5 > 59) && num5 != 62 && num5 != 66)
                      throw new NoViableAltException("", 53, 0, (IIntStream) this.input, 1);
                    num4 = 2;
                  }
                }
                finally
                {
                }
                switch (num4)
                {
                  case 1:
                    this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_element3044);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.ebnfSuffix();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot1);
                    GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, parserRuleReturnScope2?.Start, "BLOCK"), (object) oldRoot2);
                    GrammarAST grammarAst4 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                    this.adaptor.AddChild((object) grammarAst4, ruleSubtreeStream1.NextTree());
                    this.adaptor.AddChild((object) grammarAst3, (object) grammarAst4);
                    this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
                    this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                  case 2:
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream1.NextTree());
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 2:
              this.PushFollow(ANTLRParser.Follow._atom_in_element3094);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.atom();
              this.PopFollow();
              ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
              int num6 = 2;
              try
              {
                try
                {
                  int num7 = this.input.LA(1);
                  if (num7 == 45 || num7 == 51 || num7 == 61)
                  {
                    num6 = 1;
                  }
                  else
                  {
                    if (num7 != -1 && num7 != 4 && num7 != 20 && num7 != 34 && num7 != 39 && num7 != 43 && num7 != 47 && (num7 < 56 || num7 > 59) && num7 != 62 && num7 != 66)
                      throw new NoViableAltException("", 54, 0, (IIntStream) this.input, 1);
                    num6 = 2;
                  }
                }
                finally
                {
                }
                switch (num6)
                {
                  case 1:
                    this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_element3100);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.ebnfSuffix();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope5.Tree);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream6 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST oldRoot3 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst5 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot3);
                    GrammarAST oldRoot4 = (GrammarAST) this.adaptor.Nil();
                    GrammarAST grammarAst6 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, parserRuleReturnScope4?.Start, "BLOCK"), (object) oldRoot4);
                    GrammarAST grammarAst7 = (GrammarAST) this.adaptor.BecomeRoot((object) new AltAST(73), (object) (GrammarAST) this.adaptor.Nil());
                    this.adaptor.AddChild((object) grammarAst7, ruleSubtreeStream3.NextTree());
                    this.adaptor.AddChild((object) grammarAst6, (object) grammarAst7);
                    this.adaptor.AddChild((object) grammarAst5, (object) grammarAst6);
                    this.adaptor.AddChild((object) grammarAst1, (object) grammarAst5);
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                  case 2:
                    parserRuleReturnScope1.Tree = grammarAst1;
                    RewriteRuleSubtreeStream ruleSubtreeStream7 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                    grammarAst1 = (GrammarAST) this.adaptor.Nil();
                    this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream3.NextTree());
                    parserRuleReturnScope1.Tree = grammarAst1;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 3:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._ebnf_in_element3150);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.ebnf();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope6.Tree);
              break;
            case 4:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._actionElement_in_element3155);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope7 = this.actionElement();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope7.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
          int type = this.input.Get(this.input.Range).Type;
          switch (type)
          {
            case 11:
            case 12:
            case 14:
            case 23:
            case 55:
              this.ReportError((RecognitionException) new v4ParserException("unterminated rule (missing ';') detected at '" + this.input.LT(1).Text + " " + this.input.LT(2).Text + "'", (IIntStream) this.input));
              if (type == 12 || type == 23)
                this.input.Seek(this.input.Range);
              if (type == 55 || type == 11)
              {
                int index = this.input.Index;
                for (IToken token = this.input.Get(index); token.Type != 57 && token.Type != 66; token = this.input.Get(index))
                  --index;
                this.input.Seek(index);
              }
              throw new ResyncToEndOfRuleBlock();
            default:
              this.ReportError(ex);
              this.Recover((IIntStream) this.input, ex);
              break;
          }
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("actionElement")]
    private AstParserRuleReturnScope<GrammarAST, IToken> actionElement()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token ACTION");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token SEMPRED");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
                int num2 = this.input.LA(2);
                if (num2 == -1 || num2 == 4 || num2 == 20 || num2 == 32 || num2 == 34 || num2 == 39 || num2 == 43 || num2 == 47 || num2 == 53 || num2 >= 56 && num2 <= 59 || num2 == 62 || num2 == 66)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != 35)
                  throw new NoViableAltException("", 56, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 59:
                int num3 = this.input.LA(2);
                if (num3 == -1 || num3 == 4 || num3 == 20 || num3 == 32 || num3 == 34 || num3 == 39 || num3 == 43 || num3 == 47 || num3 == 53 || num3 >= 56 && num3 <= 59 || num3 == 62 || num3 == 66)
                {
                  num1 = 3;
                  break;
                }
                if (num3 != 35)
                  throw new NoViableAltException("", 56, 2, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              default:
                throw new NoViableAltException("", 56, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST child1 = (GrammarAST) new ActionAST((IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_actionElement3181));
              this.adaptor.AddChild((object) grammarAst1, (object) child1);
              break;
            case 2:
              IToken el1 = (IToken) this.Match((IIntStream) this.input, 4, ANTLRParser.Follow._ACTION_in_actionElement3193);
              rewriteRuleTokenStream1.Add((object) el1);
              this.PushFollow(ANTLRParser.Follow._elementOptions_in_actionElement3195);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOptions();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new ActionAST(rewriteRuleTokenStream1.NextToken()), (object) oldRoot1);
              this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 3:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST child2 = (GrammarAST) new PredAST((IToken) this.Match((IIntStream) this.input, 59, ANTLRParser.Follow._SEMPRED_in_actionElement3215));
              this.adaptor.AddChild((object) grammarAst1, (object) child2);
              break;
            case 4:
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 59, ANTLRParser.Follow._SEMPRED_in_actionElement3227);
              rewriteRuleTokenStream2.Add((object) el2);
              this.PushFollow(ANTLRParser.Follow._elementOptions_in_actionElement3229);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.elementOptions();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new PredAST(rewriteRuleTokenStream2.NextToken()), (object) oldRoot2);
              this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(81);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("labeledElement")]
    private AstParserRuleReturnScope<GrammarAST, IToken> labeledElement()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      IToken token = (IToken) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token ASSIGN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token PLUS_ASSIGN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule atom");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule block");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._id_in_labeledElement3253);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 10:
                  num1 = 1;
                  break;
                case 46:
                  num1 = 2;
                  break;
                default:
                  throw new NoViableAltException("", 57, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num1)
            {
              case 1:
                token = (IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_labeledElement3258);
                rewriteRuleTokenStream1.Add((object) token);
                break;
              case 2:
                token = (IToken) this.Match((IIntStream) this.input, 46, ANTLRParser.Follow._PLUS_ASSIGN_in_labeledElement3262);
                rewriteRuleTokenStream2.Add((object) token);
                break;
            }
          }
          finally
          {
          }
          int num2 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 20:
                case 39:
                case 57:
                case 62:
                case 66:
                  num2 = 1;
                  break;
                case 34:
                  num2 = 2;
                  break;
                default:
                  throw new NoViableAltException("", 58, 0, (IIntStream) this.input, 1);
              }
            }
            finally
            {
            }
            switch (num2)
            {
              case 1:
                this.PushFollow(ANTLRParser.Follow._atom_in_labeledElement3269);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.atom();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token ass", (object) token);
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream3.NextNode(), (object) oldRoot1);
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream2.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
              case 2:
                this.PushFollow(ANTLRParser.Follow._block_in_labeledElement3291);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.block();
                this.PopFollow();
                ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleTokenStream rewriteRuleTokenStream4 = new RewriteRuleTokenStream(this.adaptor, "token ass", (object) token);
                RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot(rewriteRuleTokenStream4.NextNode(), (object) oldRoot2);
                this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream3.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ebnf")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ebnf()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule block");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule blockSuffix");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._block_in_ebnf3327);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.block();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          int num1 = 2;
          try
          {
            try
            {
              int num2 = this.input.LA(1);
              if (num2 == 45 || num2 == 51 || num2 == 61)
              {
                num1 = 1;
              }
              else
              {
                if (num2 != -1 && num2 != 4 && num2 != 20 && num2 != 34 && num2 != 39 && num2 != 43 && num2 != 47 && (num2 < 56 || num2 > 59) && num2 != 62 && num2 != 66)
                  throw new NoViableAltException("", 59, 0, (IIntStream) this.input, 1);
                num1 = 2;
              }
            }
            finally
            {
            }
            switch (num1)
            {
              case 1:
                this.PushFollow(ANTLRParser.Follow._blockSuffix_in_ebnf3351);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.blockSuffix();
                this.PopFollow();
                ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
                GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot(ruleSubtreeStream2.NextNode(), (object) oldRoot);
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
                this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
              case 2:
                parserRuleReturnScope1.Tree = grammarAst1;
                RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
                grammarAst1 = (GrammarAST) this.adaptor.Nil();
                this.adaptor.AddChild((object) grammarAst1, ruleSubtreeStream1.NextTree());
                parserRuleReturnScope1.Tree = grammarAst1;
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("blockSuffix")]
    private AstParserRuleReturnScope<GrammarAST, IToken> blockSuffix()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._ebnfSuffix_in_blockSuffix3401);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.ebnfSuffix();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ebnfSuffix")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ebnfSuffix()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      IToken token = (IToken) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token QUESTION");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token STAR");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token PLUS");
      try
      {
        try
        {
          int num1 = 3;
          try
          {
            switch (this.input.LA(1))
            {
              case 45:
                num1 = 3;
                break;
              case 51:
                num1 = 1;
                break;
              case 61:
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 63, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              IToken el1 = (IToken) this.Match((IIntStream) this.input, 51, ANTLRParser.Follow._QUESTION_in_ebnfSuffix3416);
              rewriteRuleTokenStream1.Add((object) el1);
              int num2 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 51)
                    num2 = 1;
                }
                finally
                {
                }
                if (num2 == 1)
                {
                  token = (IToken) this.Match((IIntStream) this.input, 51, ANTLRParser.Follow._QUESTION_in_ebnfSuffix3420);
                  rewriteRuleTokenStream1.Add((object) token);
                }
              }
              finally
              {
              }
              parserRuleReturnScope.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) new OptionalBlockAST(88, parserRuleReturnScope.Start, token));
              parserRuleReturnScope.Tree = grammarAst;
              break;
            case 2:
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 61, ANTLRParser.Follow._STAR_in_ebnfSuffix3438);
              rewriteRuleTokenStream2.Add((object) el2);
              int num3 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 51)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  token = (IToken) this.Match((IIntStream) this.input, 51, ANTLRParser.Follow._QUESTION_in_ebnfSuffix3442);
                  rewriteRuleTokenStream1.Add((object) token);
                }
              }
              finally
              {
              }
              parserRuleReturnScope.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) new StarBlockAST(79, parserRuleReturnScope.Start, token));
              parserRuleReturnScope.Tree = grammarAst;
              break;
            case 3:
              IToken el3 = (IToken) this.Match((IIntStream) this.input, 45, ANTLRParser.Follow._PLUS_in_ebnfSuffix3462);
              rewriteRuleTokenStream3.Add((object) el3);
              int num4 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 51)
                    num4 = 1;
                }
                finally
                {
                }
                if (num4 == 1)
                {
                  token = (IToken) this.Match((IIntStream) this.input, 51, ANTLRParser.Follow._QUESTION_in_ebnfSuffix3466);
                  rewriteRuleTokenStream1.Add((object) token);
                }
              }
              finally
              {
              }
              parserRuleReturnScope.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) new PlusBlockAST(89, parserRuleReturnScope.Start, token));
              parserRuleReturnScope.Tree = grammarAst;
              break;
          }
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("lexerAtom")]
    private AstParserRuleReturnScope<GrammarAST, IToken> lexerAtom()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num1 = 6;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
                num1 = 5;
                break;
              case 32:
                num1 = 6;
                break;
              case 39:
                num1 = 4;
                break;
              case 57:
                num1 = 3;
                break;
              case 62:
                int num2 = this.input.LA(2);
                if (num2 == 52)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != 4 && num2 != 20 && num2 != 32 && (num2 < 34 || num2 > 35) && num2 != 39 && num2 != 43 && num2 != 45 && num2 != 51 && num2 != 53 && (num2 < 56 || num2 > 59) && (num2 < 61 || num2 > 62) && num2 != 66)
                  throw new NoViableAltException("", 64, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 64, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._range_in_lexerAtom3489);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.range();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._terminal_in_lexerAtom3494);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.terminal();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
              break;
            case 3:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child1 = (GrammarAST) new RuleRefAST((IToken) this.Match((IIntStream) this.input, 57, ANTLRParser.Follow._RULE_REF_in_lexerAtom3504));
              this.adaptor.AddChild((object) grammarAst, (object) child1);
              break;
            case 4:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._notSet_in_lexerAtom3517);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.notSet();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope4.Tree);
              break;
            case 5:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._wildcard_in_lexerAtom3525);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.wildcard();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope5.Tree);
              break;
            case 6:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child2 = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 32, ANTLRParser.Follow._LEXER_CHAR_SET_in_lexerAtom3533));
              this.adaptor.AddChild((object) grammarAst, (object) child2);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("atom")]
    private AstParserRuleReturnScope<GrammarAST, IToken> atom()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num1 = 5;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
                num1 = 5;
                break;
              case 39:
                num1 = 4;
                break;
              case 57:
                num1 = 3;
                break;
              case 62:
                int num2 = this.input.LA(2);
                if (num2 == 52)
                {
                  num1 = 1;
                  break;
                }
                if (num2 != -1 && num2 != 4 && num2 != 20 && (num2 < 34 || num2 > 35) && num2 != 39 && num2 != 43 && num2 != 45 && num2 != 47 && num2 != 51 && (num2 < 56 || num2 > 59) && (num2 < 61 || num2 > 62) && num2 != 66)
                  throw new NoViableAltException("", 65, 1, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                num1 = 2;
                break;
              default:
                throw new NoViableAltException("", 65, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._range_in_atom3578);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.range();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._terminal_in_atom3585);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.terminal();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
              break;
            case 3:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._ruleref_in_atom3595);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.ruleref();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope4.Tree);
              break;
            case 4:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._notSet_in_atom3603);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope5 = this.notSet();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope5.Tree);
              break;
            case 5:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._wildcard_in_atom3611);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope6 = this.wildcard();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope6.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          throw ex;
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("wildcard")]
    private AstParserRuleReturnScope<GrammarAST, IToken> wildcard()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token DOT");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 20, ANTLRParser.Follow._DOT_in_wildcard3659);
          rewriteRuleTokenStream.Add((object) token);
          int num = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 35)
                num = 1;
            }
            finally
            {
            }
            if (num == 1)
            {
              this.PushFollow(ANTLRParser.Follow._elementOptions_in_wildcard3661);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOptions();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(99, token), (object) oldRoot);
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(81);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("notSet")]
    private AstParserRuleReturnScope<GrammarAST, IToken> notSet()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token NOT");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule setElement");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule blockSet");
      try
      {
        try
        {
          int num = 2;
          try
          {
            if (this.input.LA(1) != 39)
              throw new NoViableAltException("", 67, 0, (IIntStream) this.input, 1);
            switch (this.input.LA(2))
            {
              case 32:
              case 62:
              case 66:
                num = 1;
                break;
              case 34:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 67, 1, (IIntStream) this.input, 2);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              IToken token1 = (IToken) this.Match((IIntStream) this.input, 39, ANTLRParser.Follow._NOT_in_notSet3699);
              rewriteRuleTokenStream.Add((object) token1);
              this.PushFollow(ANTLRParser.Follow._setElement_in_notSet3701);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.setElement();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new NotAST(39, token1), (object) oldRoot1);
              GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new SetAST(97, parserRuleReturnScope2?.Start, "SET"), (object) oldRoot2);
              this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
              this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 2:
              IToken token2 = (IToken) this.Match((IIntStream) this.input, 39, ANTLRParser.Follow._NOT_in_notSet3733);
              rewriteRuleTokenStream.Add((object) token2);
              this.PushFollow(ANTLRParser.Follow._blockSet_in_notSet3735);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.blockSet();
              this.PopFollow();
              ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot3 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst4 = (GrammarAST) this.adaptor.BecomeRoot((object) new NotAST(39, token2), (object) oldRoot3);
              this.adaptor.AddChild((object) grammarAst4, ruleSubtreeStream2.NextTree());
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst4);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("blockSet")]
    private AstParserRuleReturnScope<GrammarAST, IToken> blockSet()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LPAREN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token OR");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token RPAREN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule setElement");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 34, ANTLRParser.Follow._LPAREN_in_blockSet3767);
          rewriteRuleTokenStream1.Add((object) token);
          this.PushFollow(ANTLRParser.Follow._setElement_in_blockSet3769);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.setElement();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 43)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el = (IToken) this.Match((IIntStream) this.input, 43, ANTLRParser.Follow._OR_in_blockSet3772);
                rewriteRuleTokenStream2.Add((object) el);
                this.PushFollow(ANTLRParser.Follow._setElement_in_blockSet3774);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.setElement();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 56, ANTLRParser.Follow._RPAREN_in_blockSet3778);
          rewriteRuleTokenStream3.Add((object) el1);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new SetAST(97, token, "SET"), (object) oldRoot);
          if (!ruleSubtreeStream1.HasNext)
            throw new RewriteEarlyExitException();
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("setElement")]
    private AstParserRuleReturnScope<GrammarAST, IToken> setElement()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      try
      {
        try
        {
          int num1 = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 32:
                num1 = 4;
                break;
              case 62:
                int num2 = this.input.LA(2);
                if (num2 == 52)
                {
                  num1 = 3;
                  break;
                }
                if (num2 != -1 && num2 != 4 && num2 != 20 && num2 != 32 && (num2 < 34 || num2 > 35) && num2 != 39 && num2 != 43 && num2 != 45 && num2 != 47 && num2 != 51 && num2 != 53 && (num2 < 56 || num2 > 59) && (num2 < 61 || num2 > 62) && num2 != 66)
                  throw new NoViableAltException("", 71, 2, (IIntStream) this.input, 2);
                num1 = 2;
                break;
              case 66:
                num1 = 1;
                break;
              default:
                throw new NoViableAltException("", 71, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
              grammarAst = (GrammarAST) this.adaptor.BecomeRoot((object) new TerminalAST((IToken) this.Match((IIntStream) this.input, 66, ANTLRParser.Follow._TOKEN_REF_in_setElement3810)), (object) oldRoot1);
              int num3 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 35)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  this.PushFollow(ANTLRParser.Follow._elementOptions_in_setElement3818);
                  AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOptions();
                  this.PopFollow();
                  this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
                  break;
                }
                break;
              }
              finally
              {
              }
            case 2:
              GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
              grammarAst = (GrammarAST) this.adaptor.BecomeRoot((object) new TerminalAST((IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_setElement3824)), (object) oldRoot2);
              int num4 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 35)
                    num4 = 1;
                }
                finally
                {
                }
                if (num4 == 1)
                {
                  this.PushFollow(ANTLRParser.Follow._elementOptions_in_setElement3832);
                  AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.elementOptions();
                  this.PopFollow();
                  this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope3.Tree);
                  break;
                }
                break;
              }
              finally
              {
              }
            case 3:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._range_in_setElement3838);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.range();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope4.Tree);
              break;
            case 4:
              grammarAst = (GrammarAST) this.adaptor.Nil();
              GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 32, ANTLRParser.Follow._LEXER_CHAR_SET_in_setElement3848));
              this.adaptor.AddChild((object) grammarAst, (object) child);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("block")]
    private AstParserRuleReturnScope<GrammarAST, IToken> block()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      List<GrammarAST> elements = (List<GrammarAST>) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LPAREN");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COLON");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token RPAREN");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule optionsSpec");
      RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule ruleAction");
      RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule altList");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 34, ANTLRParser.Follow._LPAREN_in_block3872);
          rewriteRuleTokenStream1.Add((object) token);
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 11:
                case 14:
                case 42:
                  num1 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num1 == 1)
            {
              int num2 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 42)
                    num2 = 1;
                }
                finally
                {
                }
                if (num2 == 1)
                {
                  this.PushFollow(ANTLRParser.Follow._optionsSpec_in_block3884);
                  AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.optionsSpec();
                  this.PopFollow();
                  ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
                }
              }
              finally
              {
              }
              try
              {
                while (true)
                {
                  int num3 = 2;
                  try
                  {
                    if (this.input.LA(1) == 11)
                      num3 = 1;
                  }
                  finally
                  {
                  }
                  if (num3 == 1)
                  {
                    this.PushFollow(ANTLRParser.Follow._ruleAction_in_block3889);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.ruleAction();
                    this.PopFollow();
                    ruleSubtreeStream2.Add((object) parserRuleReturnScope3.Tree);
                    if (elements == null)
                      elements = new List<GrammarAST>();
                    elements.Add(parserRuleReturnScope3.Tree);
                  }
                  else
                    break;
                }
              }
              finally
              {
              }
              IToken el = (IToken) this.Match((IIntStream) this.input, 14, ANTLRParser.Follow._COLON_in_block3892);
              rewriteRuleTokenStream2.Add((object) el);
            }
          }
          finally
          {
          }
          this.PushFollow(ANTLRParser.Follow._altList_in_block3905);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.altList();
          this.PopFollow();
          ruleSubtreeStream3.Add((object) parserRuleReturnScope4.Tree);
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 56, ANTLRParser.Follow._RPAREN_in_block3909);
          rewriteRuleTokenStream3.Add((object) el1);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream4 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          RewriteRuleSubtreeStream ruleSubtreeStream5 = new RewriteRuleSubtreeStream(this.adaptor, "token ra", (IList) elements);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new BlockAST(77, token, "BLOCK"), (object) oldRoot);
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          while (ruleSubtreeStream5.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream5.NextTree());
          ruleSubtreeStream5.Reset();
          this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream3.NextTree());
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(42);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ruleref")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleref()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token RULE_REF");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token ARG_ACTION");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      try
      {
        try
        {
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 57, ANTLRParser.Follow._RULE_REF_in_ruleref3965);
          rewriteRuleTokenStream1.Add((object) el1);
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
            {
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 8, ANTLRParser.Follow._ARG_ACTION_in_ruleref3967);
              rewriteRuleTokenStream2.Add((object) el2);
            }
          }
          finally
          {
          }
          int num2 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 35)
                num2 = 1;
            }
            finally
            {
            }
            if (num2 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._elementOptions_in_ruleref3970);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOptions();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new RuleRefAST(rewriteRuleTokenStream1.NextToken()), (object) oldRoot);
          if (rewriteRuleTokenStream2.HasNext)
            this.adaptor.AddChild((object) grammarAst3, (object) new ActionAST(rewriteRuleTokenStream2.NextToken()));
          rewriteRuleTokenStream2.Reset();
          if (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(81);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          throw ex;
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("range")]
    private AstParserRuleReturnScope<GrammarAST, IToken> range()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst1 = (GrammarAST) this.adaptor.Nil();
          GrammarAST child1 = (GrammarAST) new TerminalAST((IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_range4030));
          this.adaptor.AddChild((object) grammarAst1, (object) child1);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new RangeAST((IToken) this.Match((IIntStream) this.input, 52, ANTLRParser.Follow._RANGE_in_range4037)), (object) grammarAst1);
          GrammarAST child2 = (GrammarAST) new TerminalAST((IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_range4045));
          this.adaptor.AddChild((object) grammarAst2, (object) child2);
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("terminal")]
    private AstParserRuleReturnScope<GrammarAST, IToken> terminal()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token TOKEN_REF");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token STRING_LITERAL");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOptions");
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 62:
                num1 = 2;
                break;
              case 66:
                num1 = 1;
                break;
              default:
                throw new NoViableAltException("", 79, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              IToken el1 = (IToken) this.Match((IIntStream) this.input, 66, ANTLRParser.Follow._TOKEN_REF_in_terminal4071);
              rewriteRuleTokenStream1.Add((object) el1);
              int num2 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 35)
                    num2 = 1;
                }
                finally
                {
                }
                if (num2 == 1)
                {
                  this.PushFollow(ANTLRParser.Follow._elementOptions_in_terminal4073);
                  AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOptions();
                  this.PopFollow();
                  ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
                }
              }
              finally
              {
              }
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.BecomeRoot((object) new TerminalAST(rewriteRuleTokenStream1.NextToken()), (object) oldRoot1);
              if (ruleSubtreeStream1.HasNext)
                this.adaptor.AddChild((object) grammarAst2, ruleSubtreeStream1.NextTree());
              ruleSubtreeStream1.Reset();
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst2);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
            case 2:
              IToken el2 = (IToken) this.Match((IIntStream) this.input, 62, ANTLRParser.Follow._STRING_LITERAL_in_terminal4096);
              rewriteRuleTokenStream2.Add((object) el2);
              int num3 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 35)
                    num3 = 1;
                }
                finally
                {
                }
                if (num3 == 1)
                {
                  this.PushFollow(ANTLRParser.Follow._elementOptions_in_terminal4098);
                  AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.elementOptions();
                  this.PopFollow();
                  ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
                }
              }
              finally
              {
              }
              parserRuleReturnScope1.Tree = grammarAst1;
              RewriteRuleSubtreeStream ruleSubtreeStream3 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              GrammarAST oldRoot2 = (GrammarAST) this.adaptor.Nil();
              GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) new TerminalAST(rewriteRuleTokenStream2.NextToken()), (object) oldRoot2);
              if (ruleSubtreeStream1.HasNext)
                this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
              ruleSubtreeStream1.Reset();
              this.adaptor.AddChild((object) grammarAst1, (object) grammarAst3);
              parserRuleReturnScope1.Tree = grammarAst1;
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          GrammarAST firstChildWithType = (GrammarAST) parserRuleReturnScope1.Tree.GetFirstChildWithType(81);
          if (firstChildWithType != null)
            Grammar.SetNodeOptions(parserRuleReturnScope1.Tree, firstChildWithType);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("elementOptions")]
    private AstParserRuleReturnScope<GrammarAST, IToken> elementOptions()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token LT");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token COMMA");
      RewriteRuleTokenStream rewriteRuleTokenStream3 = new RewriteRuleTokenStream(this.adaptor, "token GT");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule elementOption");
      try
      {
        try
        {
          IToken token = (IToken) this.Match((IIntStream) this.input, 35, ANTLRParser.Follow._LT_in_elementOptions4131);
          rewriteRuleTokenStream1.Add((object) token);
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 57:
                case 66:
                  num1 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(ANTLRParser.Follow._elementOption_in_elementOptions4134);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.elementOption();
              this.PopFollow();
              ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
              try
              {
                while (true)
                {
                  int num2 = 2;
                  try
                  {
                    if (this.input.LA(1) == 16)
                      num2 = 1;
                  }
                  finally
                  {
                  }
                  if (num2 == 1)
                  {
                    IToken el = (IToken) this.Match((IIntStream) this.input, 16, ANTLRParser.Follow._COMMA_in_elementOptions4137);
                    rewriteRuleTokenStream2.Add((object) el);
                    this.PushFollow(ANTLRParser.Follow._elementOption_in_elementOptions4139);
                    AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.elementOption();
                    this.PopFollow();
                    ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
                  }
                  else
                    break;
                }
              }
              finally
              {
              }
            }
          }
          finally
          {
          }
          IToken el1 = (IToken) this.Match((IIntStream) this.input, 26, ANTLRParser.Follow._GT_in_elementOptions4145);
          rewriteRuleTokenStream3.Add((object) el1);
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          GrammarAST oldRoot = (GrammarAST) this.adaptor.Nil();
          GrammarAST grammarAst3 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create(81, token, "ELEMENT_OPTIONS"), (object) oldRoot);
          while (ruleSubtreeStream1.HasNext)
            this.adaptor.AddChild((object) grammarAst3, ruleSubtreeStream1.NextTree());
          ruleSubtreeStream1.Reset();
          this.adaptor.AddChild((object) grammarAst2, (object) grammarAst3);
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("elementOption")]
    private AstParserRuleReturnScope<GrammarAST, IToken> elementOption()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 57:
                switch (this.input.LA(2))
                {
                  case 10:
                    num = 2;
                    break;
                  case 16:
                  case 20:
                  case 26:
                    num = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 82, 1, (IIntStream) this.input, 2);
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 10:
                    num = 2;
                    break;
                  case 16:
                  case 20:
                  case 26:
                    num = 1;
                    break;
                  default:
                    throw new NoViableAltException("", 82, 2, (IIntStream) this.input, 2);
                }
                break;
              default:
                throw new NoViableAltException("", 82, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              grammarAst1 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._qid_in_elementOption4193);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.qid();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope2.Tree);
              break;
            case 2:
              GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
              this.PushFollow(ANTLRParser.Follow._id_in_elementOption4201);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst2, (object) parserRuleReturnScope3.Tree);
              grammarAst1 = (GrammarAST) this.adaptor.BecomeRoot((object) (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, 10, ANTLRParser.Follow._ASSIGN_in_elementOption4203)), (object) grammarAst2);
              this.PushFollow(ANTLRParser.Follow._optionValue_in_elementOption4206);
              AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope4 = this.optionValue();
              this.PopFollow();
              this.adaptor.AddChild((object) grammarAst1, (object) parserRuleReturnScope4.Tree);
              break;
          }
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst1);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("id")]
    private AstParserRuleReturnScope<GrammarAST, IToken> id()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope.Start = this.input.LT(1);
      GrammarAST grammarAst = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream1 = new RewriteRuleTokenStream(this.adaptor, "token RULE_REF");
      RewriteRuleTokenStream rewriteRuleTokenStream2 = new RewriteRuleTokenStream(this.adaptor, "token TOKEN_REF");
      this.paraphrases.Push("looking for an identifier");
      try
      {
        try
        {
          int num = 2;
          try
          {
            switch (this.input.LA(1))
            {
              case 57:
                num = 1;
                break;
              case 66:
                num = 2;
                break;
              default:
                throw new NoViableAltException("", 83, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              IToken token1 = (IToken) this.Match((IIntStream) this.input, 57, ANTLRParser.Follow._RULE_REF_in_id4237);
              rewriteRuleTokenStream1.Add((object) token1);
              parserRuleReturnScope.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) (GrammarAST) this.adaptor.Create(28, token1));
              parserRuleReturnScope.Tree = grammarAst;
              break;
            case 2:
              IToken token2 = (IToken) this.Match((IIntStream) this.input, 66, ANTLRParser.Follow._TOKEN_REF_in_id4250);
              rewriteRuleTokenStream2.Add((object) token2);
              parserRuleReturnScope.Tree = grammarAst;
              RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope?.Tree);
              grammarAst = (GrammarAST) this.adaptor.Nil();
              this.adaptor.AddChild((object) grammarAst, (object) (GrammarAST) this.adaptor.Create(28, token2));
              parserRuleReturnScope.Tree = grammarAst;
              break;
          }
          parserRuleReturnScope.Stop = this.input.LT(-1);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope.Tree, parserRuleReturnScope.Start, parserRuleReturnScope.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope;
    }

    [GrammarRule("qid")]
    private AstParserRuleReturnScope<GrammarAST, IToken> qid()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      GrammarAST grammarAst1 = (GrammarAST) null;
      RewriteRuleTokenStream rewriteRuleTokenStream = new RewriteRuleTokenStream(this.adaptor, "token DOT");
      RewriteRuleSubtreeStream ruleSubtreeStream1 = new RewriteRuleSubtreeStream(this.adaptor, "rule id");
      this.paraphrases.Push("looking for a qualified identifier");
      try
      {
        try
        {
          this.PushFollow(ANTLRParser.Follow._id_in_qid4278);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.id();
          this.PopFollow();
          ruleSubtreeStream1.Add((object) parserRuleReturnScope2.Tree);
          try
          {
            while (true)
            {
              int num = 2;
              try
              {
                if (this.input.LA(1) == 20)
                  num = 1;
              }
              finally
              {
              }
              if (num == 1)
              {
                IToken el = (IToken) this.Match((IIntStream) this.input, 20, ANTLRParser.Follow._DOT_in_qid4281);
                rewriteRuleTokenStream.Add((object) el);
                this.PushFollow(ANTLRParser.Follow._id_in_qid4283);
                AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope3 = this.id();
                this.PopFollow();
                ruleSubtreeStream1.Add((object) parserRuleReturnScope3.Tree);
              }
              else
                break;
            }
          }
          finally
          {
          }
          parserRuleReturnScope1.Tree = grammarAst1;
          RewriteRuleSubtreeStream ruleSubtreeStream2 = new RewriteRuleSubtreeStream(this.adaptor, "rule retval", (object) parserRuleReturnScope1?.Tree);
          GrammarAST grammarAst2 = (GrammarAST) this.adaptor.Nil();
          this.adaptor.AddChild((object) grammarAst2, (object) (GrammarAST) this.adaptor.Create(28, parserRuleReturnScope1.Start, this.input.ToString(parserRuleReturnScope1.Start, this.input.LT(-1))));
          parserRuleReturnScope1.Tree = grammarAst2;
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst2);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
          this.paraphrases.Pop();
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("alternativeEntry")]
    private AstParserRuleReturnScope<GrammarAST, IToken> alternativeEntry()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._alternative_in_alternativeEntry4300);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.alternative();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, -1, ANTLRParser.Follow._EOF_in_alternativeEntry4302));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("elementEntry")]
    private AstParserRuleReturnScope<GrammarAST, IToken> elementEntry()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._element_in_elementEntry4311);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.element();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, -1, ANTLRParser.Follow._EOF_in_elementEntry4313));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("ruleEntry")]
    private AstParserRuleReturnScope<GrammarAST, IToken> ruleEntry()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._rule_in_ruleEntry4321);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.rule();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, -1, ANTLRParser.Follow._EOF_in_ruleEntry4323));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    [GrammarRule("blockEntry")]
    private AstParserRuleReturnScope<GrammarAST, IToken> blockEntry()
    {
      AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope1 = new AstParserRuleReturnScope<GrammarAST, IToken>();
      parserRuleReturnScope1.Start = this.input.LT(1);
      try
      {
        try
        {
          GrammarAST grammarAst = (GrammarAST) this.adaptor.Nil();
          this.PushFollow(ANTLRParser.Follow._block_in_blockEntry4331);
          AstParserRuleReturnScope<GrammarAST, IToken> parserRuleReturnScope2 = this.block();
          this.PopFollow();
          this.adaptor.AddChild((object) grammarAst, (object) parserRuleReturnScope2.Tree);
          GrammarAST child = (GrammarAST) this.adaptor.Create((IToken) this.Match((IIntStream) this.input, -1, ANTLRParser.Follow._EOF_in_blockEntry4333));
          this.adaptor.AddChild((object) grammarAst, (object) child);
          parserRuleReturnScope1.Stop = this.input.LT(-1);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.RulePostProcessing((object) grammarAst);
          this.adaptor.SetTokenBoundaries((object) parserRuleReturnScope1.Tree, parserRuleReturnScope1.Start, parserRuleReturnScope1.Stop);
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover((IIntStream) this.input, ex);
          parserRuleReturnScope1.Tree = (GrammarAST) this.adaptor.ErrorNode(this.input, parserRuleReturnScope1.Start, this.input.LT(-1), ex);
        }
        finally
        {
        }
      }
      finally
      {
      }
      return parserRuleReturnScope1;
    }

    static ANTLRParser()
    {
      ANTLRParser.tokenNames = new string[100]
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

    private static class Follow
    {
      public static readonly BitSet _grammarType_in_grammarSpec403;
      public static readonly BitSet _id_in_grammarSpec405;
      public static readonly BitSet _SEMI_in_grammarSpec407;
      public static readonly BitSet _sync_in_grammarSpec445;
      public static readonly BitSet _prequelConstruct_in_grammarSpec449;
      public static readonly BitSet _sync_in_grammarSpec451;
      public static readonly BitSet _rules_in_grammarSpec476;
      public static readonly BitSet _modeSpec_in_grammarSpec482;
      public static readonly BitSet _EOF_in_grammarSpec520;
      public static readonly BitSet _LEXER_in_grammarType690;
      public static readonly BitSet _GRAMMAR_in_grammarType694;
      public static readonly BitSet _PARSER_in_grammarType719;
      public static readonly BitSet _GRAMMAR_in_grammarType723;
      public static readonly BitSet _GRAMMAR_in_grammarType746;
      public static readonly BitSet _TREE_GRAMMAR_in_grammarType775;
      public static readonly BitSet _optionsSpec_in_prequelConstruct801;
      public static readonly BitSet _delegateGrammars_in_prequelConstruct824;
      public static readonly BitSet _tokensSpec_in_prequelConstruct868;
      public static readonly BitSet _channelsSpec_in_prequelConstruct878;
      public static readonly BitSet _action_in_prequelConstruct915;
      public static readonly BitSet _OPTIONS_in_optionsSpec930;
      public static readonly BitSet _option_in_optionsSpec933;
      public static readonly BitSet _SEMI_in_optionsSpec935;
      public static readonly BitSet _RBRACE_in_optionsSpec939;
      public static readonly BitSet _id_in_option968;
      public static readonly BitSet _ASSIGN_in_option970;
      public static readonly BitSet _optionValue_in_option973;
      public static readonly BitSet _qid_in_optionValue1016;
      public static readonly BitSet _STRING_LITERAL_in_optionValue1024;
      public static readonly BitSet _ACTION_in_optionValue1029;
      public static readonly BitSet _INT_in_optionValue1042;
      public static readonly BitSet _IMPORT_in_delegateGrammars1058;
      public static readonly BitSet _delegateGrammar_in_delegateGrammars1060;
      public static readonly BitSet _COMMA_in_delegateGrammars1063;
      public static readonly BitSet _delegateGrammar_in_delegateGrammars1065;
      public static readonly BitSet _SEMI_in_delegateGrammars1069;
      public static readonly BitSet _id_in_delegateGrammar1096;
      public static readonly BitSet _ASSIGN_in_delegateGrammar1098;
      public static readonly BitSet _id_in_delegateGrammar1101;
      public static readonly BitSet _id_in_delegateGrammar1111;
      public static readonly BitSet _TOKENS_SPEC_in_tokensSpec1125;
      public static readonly BitSet _id_in_tokensSpec1127;
      public static readonly BitSet _COMMA_in_tokensSpec1130;
      public static readonly BitSet _id_in_tokensSpec1132;
      public static readonly BitSet _COMMA_in_tokensSpec1136;
      public static readonly BitSet _RBRACE_in_tokensSpec1139;
      public static readonly BitSet _TOKENS_SPEC_in_tokensSpec1156;
      public static readonly BitSet _RBRACE_in_tokensSpec1158;
      public static readonly BitSet _TOKENS_SPEC_in_tokensSpec1168;
      public static readonly BitSet _v3tokenSpec_in_tokensSpec1171;
      public static readonly BitSet _RBRACE_in_tokensSpec1174;
      public static readonly BitSet _id_in_v3tokenSpec1194;
      public static readonly BitSet _ASSIGN_in_v3tokenSpec1200;
      public static readonly BitSet _STRING_LITERAL_in_v3tokenSpec1204;
      public static readonly BitSet _SEMI_in_v3tokenSpec1265;
      public static readonly BitSet _CHANNELS_in_channelsSpec1276;
      public static readonly BitSet _id_in_channelsSpec1280;
      public static readonly BitSet _COMMA_in_channelsSpec1283;
      public static readonly BitSet _id_in_channelsSpec1286;
      public static readonly BitSet _COMMA_in_channelsSpec1290;
      public static readonly BitSet _RBRACE_in_channelsSpec1295;
      public static readonly BitSet _AT_in_action1312;
      public static readonly BitSet _actionScopeName_in_action1315;
      public static readonly BitSet _COLONCOLON_in_action1317;
      public static readonly BitSet _id_in_action1321;
      public static readonly BitSet _ACTION_in_action1323;
      public static readonly BitSet _id_in_actionScopeName1354;
      public static readonly BitSet _LEXER_in_actionScopeName1359;
      public static readonly BitSet _PARSER_in_actionScopeName1374;
      public static readonly BitSet _MODE_in_modeSpec1393;
      public static readonly BitSet _id_in_modeSpec1395;
      public static readonly BitSet _SEMI_in_modeSpec1397;
      public static readonly BitSet _sync_in_modeSpec1399;
      public static readonly BitSet _lexerRule_in_modeSpec1402;
      public static readonly BitSet _sync_in_modeSpec1404;
      public static readonly BitSet _sync_in_rules1435;
      public static readonly BitSet _rule_in_rules1438;
      public static readonly BitSet _sync_in_rules1440;
      public static readonly BitSet _parserRule_in_rule1504;
      public static readonly BitSet _lexerRule_in_rule1509;
      public static readonly BitSet _RULE_REF_in_parserRule1558;
      public static readonly BitSet _ARG_ACTION_in_parserRule1588;
      public static readonly BitSet _ruleReturns_in_parserRule1595;
      public static readonly BitSet _throwsSpec_in_parserRule1602;
      public static readonly BitSet _localsSpec_in_parserRule1609;
      public static readonly BitSet _rulePrequels_in_parserRule1647;
      public static readonly BitSet _COLON_in_parserRule1656;
      public static readonly BitSet _ruleBlock_in_parserRule1679;
      public static readonly BitSet _SEMI_in_parserRule1688;
      public static readonly BitSet _exceptionGroup_in_parserRule1697;
      public static readonly BitSet _exceptionHandler_in_exceptionGroup1784;
      public static readonly BitSet _finallyClause_in_exceptionGroup1787;
      public static readonly BitSet _CATCH_in_exceptionHandler1804;
      public static readonly BitSet _ARG_ACTION_in_exceptionHandler1806;
      public static readonly BitSet _ACTION_in_exceptionHandler1808;
      public static readonly BitSet _FINALLY_in_finallyClause1839;
      public static readonly BitSet _ACTION_in_finallyClause1841;
      public static readonly BitSet _sync_in_rulePrequels1875;
      public static readonly BitSet _rulePrequel_in_rulePrequels1878;
      public static readonly BitSet _sync_in_rulePrequels1880;
      public static readonly BitSet _optionsSpec_in_rulePrequel1904;
      public static readonly BitSet _ruleAction_in_rulePrequel1912;
      public static readonly BitSet _RETURNS_in_ruleReturns1932;
      public static readonly BitSet _ARG_ACTION_in_ruleReturns1935;
      public static readonly BitSet _THROWS_in_throwsSpec1965;
      public static readonly BitSet _qid_in_throwsSpec1967;
      public static readonly BitSet _COMMA_in_throwsSpec1970;
      public static readonly BitSet _qid_in_throwsSpec1972;
      public static readonly BitSet _LOCALS_in_localsSpec1997;
      public static readonly BitSet _ARG_ACTION_in_localsSpec2000;
      public static readonly BitSet _AT_in_ruleAction2025;
      public static readonly BitSet _id_in_ruleAction2027;
      public static readonly BitSet _ACTION_in_ruleAction2029;
      public static readonly BitSet _ruleAltList_in_ruleBlock2069;
      public static readonly BitSet _labeledAlt_in_ruleAltList2107;
      public static readonly BitSet _OR_in_ruleAltList2110;
      public static readonly BitSet _labeledAlt_in_ruleAltList2112;
      public static readonly BitSet _alternative_in_labeledAlt2130;
      public static readonly BitSet _POUND_in_labeledAlt2136;
      public static readonly BitSet _id_in_labeledAlt2139;
      public static readonly BitSet _FRAGMENT_in_lexerRule2171;
      public static readonly BitSet _TOKEN_REF_in_lexerRule2177;
      public static readonly BitSet _COLON_in_lexerRule2179;
      public static readonly BitSet _lexerRuleBlock_in_lexerRule2181;
      public static readonly BitSet _SEMI_in_lexerRule2183;
      public static readonly BitSet _lexerAltList_in_lexerRuleBlock2249;
      public static readonly BitSet _lexerAlt_in_lexerAltList2287;
      public static readonly BitSet _OR_in_lexerAltList2290;
      public static readonly BitSet _lexerAlt_in_lexerAltList2292;
      public static readonly BitSet _lexerElements_in_lexerAlt2310;
      public static readonly BitSet _lexerCommands_in_lexerAlt2316;
      public static readonly BitSet _lexerElement_in_lexerElements2361;
      public static readonly BitSet _labeledLexerElement_in_lexerElement2421;
      public static readonly BitSet _ebnfSuffix_in_lexerElement2427;
      public static readonly BitSet _lexerAtom_in_lexerElement2477;
      public static readonly BitSet _ebnfSuffix_in_lexerElement2483;
      public static readonly BitSet _lexerBlock_in_lexerElement2533;
      public static readonly BitSet _ebnfSuffix_in_lexerElement2539;
      public static readonly BitSet _actionElement_in_lexerElement2567;
      public static readonly BitSet _id_in_labeledLexerElement2597;
      public static readonly BitSet _ASSIGN_in_labeledLexerElement2602;
      public static readonly BitSet _PLUS_ASSIGN_in_labeledLexerElement2606;
      public static readonly BitSet _lexerAtom_in_labeledLexerElement2613;
      public static readonly BitSet _lexerBlock_in_labeledLexerElement2630;
      public static readonly BitSet _LPAREN_in_lexerBlock2663;
      public static readonly BitSet _optionsSpec_in_lexerBlock2675;
      public static readonly BitSet _COLON_in_lexerBlock2677;
      public static readonly BitSet _lexerAltList_in_lexerBlock2690;
      public static readonly BitSet _RPAREN_in_lexerBlock2700;
      public static readonly BitSet _RARROW_in_lexerCommands2739;
      public static readonly BitSet _lexerCommand_in_lexerCommands2741;
      public static readonly BitSet _COMMA_in_lexerCommands2744;
      public static readonly BitSet _lexerCommand_in_lexerCommands2746;
      public static readonly BitSet _lexerCommandName_in_lexerCommand2764;
      public static readonly BitSet _LPAREN_in_lexerCommand2766;
      public static readonly BitSet _lexerCommandExpr_in_lexerCommand2768;
      public static readonly BitSet _RPAREN_in_lexerCommand2770;
      public static readonly BitSet _lexerCommandName_in_lexerCommand2785;
      public static readonly BitSet _id_in_lexerCommandExpr2796;
      public static readonly BitSet _INT_in_lexerCommandExpr2801;
      public static readonly BitSet _id_in_lexerCommandName2825;
      public static readonly BitSet _MODE_in_lexerCommandName2843;
      public static readonly BitSet _alternative_in_altList2871;
      public static readonly BitSet _OR_in_altList2874;
      public static readonly BitSet _alternative_in_altList2876;
      public static readonly BitSet _elementOptions_in_alternative2910;
      public static readonly BitSet _element_in_alternative2919;
      public static readonly BitSet _labeledElement_in_element3038;
      public static readonly BitSet _ebnfSuffix_in_element3044;
      public static readonly BitSet _atom_in_element3094;
      public static readonly BitSet _ebnfSuffix_in_element3100;
      public static readonly BitSet _ebnf_in_element3150;
      public static readonly BitSet _actionElement_in_element3155;
      public static readonly BitSet _ACTION_in_actionElement3181;
      public static readonly BitSet _ACTION_in_actionElement3193;
      public static readonly BitSet _elementOptions_in_actionElement3195;
      public static readonly BitSet _SEMPRED_in_actionElement3215;
      public static readonly BitSet _SEMPRED_in_actionElement3227;
      public static readonly BitSet _elementOptions_in_actionElement3229;
      public static readonly BitSet _id_in_labeledElement3253;
      public static readonly BitSet _ASSIGN_in_labeledElement3258;
      public static readonly BitSet _PLUS_ASSIGN_in_labeledElement3262;
      public static readonly BitSet _atom_in_labeledElement3269;
      public static readonly BitSet _block_in_labeledElement3291;
      public static readonly BitSet _block_in_ebnf3327;
      public static readonly BitSet _blockSuffix_in_ebnf3351;
      public static readonly BitSet _ebnfSuffix_in_blockSuffix3401;
      public static readonly BitSet _QUESTION_in_ebnfSuffix3416;
      public static readonly BitSet _QUESTION_in_ebnfSuffix3420;
      public static readonly BitSet _STAR_in_ebnfSuffix3438;
      public static readonly BitSet _QUESTION_in_ebnfSuffix3442;
      public static readonly BitSet _PLUS_in_ebnfSuffix3462;
      public static readonly BitSet _QUESTION_in_ebnfSuffix3466;
      public static readonly BitSet _range_in_lexerAtom3489;
      public static readonly BitSet _terminal_in_lexerAtom3494;
      public static readonly BitSet _RULE_REF_in_lexerAtom3504;
      public static readonly BitSet _notSet_in_lexerAtom3517;
      public static readonly BitSet _wildcard_in_lexerAtom3525;
      public static readonly BitSet _LEXER_CHAR_SET_in_lexerAtom3533;
      public static readonly BitSet _range_in_atom3578;
      public static readonly BitSet _terminal_in_atom3585;
      public static readonly BitSet _ruleref_in_atom3595;
      public static readonly BitSet _notSet_in_atom3603;
      public static readonly BitSet _wildcard_in_atom3611;
      public static readonly BitSet _DOT_in_wildcard3659;
      public static readonly BitSet _elementOptions_in_wildcard3661;
      public static readonly BitSet _NOT_in_notSet3699;
      public static readonly BitSet _setElement_in_notSet3701;
      public static readonly BitSet _NOT_in_notSet3733;
      public static readonly BitSet _blockSet_in_notSet3735;
      public static readonly BitSet _LPAREN_in_blockSet3767;
      public static readonly BitSet _setElement_in_blockSet3769;
      public static readonly BitSet _OR_in_blockSet3772;
      public static readonly BitSet _setElement_in_blockSet3774;
      public static readonly BitSet _RPAREN_in_blockSet3778;
      public static readonly BitSet _TOKEN_REF_in_setElement3810;
      public static readonly BitSet _elementOptions_in_setElement3818;
      public static readonly BitSet _STRING_LITERAL_in_setElement3824;
      public static readonly BitSet _elementOptions_in_setElement3832;
      public static readonly BitSet _range_in_setElement3838;
      public static readonly BitSet _LEXER_CHAR_SET_in_setElement3848;
      public static readonly BitSet _LPAREN_in_block3872;
      public static readonly BitSet _optionsSpec_in_block3884;
      public static readonly BitSet _ruleAction_in_block3889;
      public static readonly BitSet _COLON_in_block3892;
      public static readonly BitSet _altList_in_block3905;
      public static readonly BitSet _RPAREN_in_block3909;
      public static readonly BitSet _RULE_REF_in_ruleref3965;
      public static readonly BitSet _ARG_ACTION_in_ruleref3967;
      public static readonly BitSet _elementOptions_in_ruleref3970;
      public static readonly BitSet _STRING_LITERAL_in_range4030;
      public static readonly BitSet _RANGE_in_range4037;
      public static readonly BitSet _STRING_LITERAL_in_range4045;
      public static readonly BitSet _TOKEN_REF_in_terminal4071;
      public static readonly BitSet _elementOptions_in_terminal4073;
      public static readonly BitSet _STRING_LITERAL_in_terminal4096;
      public static readonly BitSet _elementOptions_in_terminal4098;
      public static readonly BitSet _LT_in_elementOptions4131;
      public static readonly BitSet _elementOption_in_elementOptions4134;
      public static readonly BitSet _COMMA_in_elementOptions4137;
      public static readonly BitSet _elementOption_in_elementOptions4139;
      public static readonly BitSet _GT_in_elementOptions4145;
      public static readonly BitSet _qid_in_elementOption4193;
      public static readonly BitSet _id_in_elementOption4201;
      public static readonly BitSet _ASSIGN_in_elementOption4203;
      public static readonly BitSet _optionValue_in_elementOption4206;
      public static readonly BitSet _RULE_REF_in_id4237;
      public static readonly BitSet _TOKEN_REF_in_id4250;
      public static readonly BitSet _id_in_qid4278;
      public static readonly BitSet _DOT_in_qid4281;
      public static readonly BitSet _id_in_qid4283;
      public static readonly BitSet _alternative_in_alternativeEntry4300;
      public static readonly BitSet _EOF_in_alternativeEntry4302;
      public static readonly BitSet _element_in_elementEntry4311;
      public static readonly BitSet _EOF_in_elementEntry4313;
      public static readonly BitSet _rule_in_ruleEntry4321;
      public static readonly BitSet _EOF_in_ruleEntry4323;
      public static readonly BitSet _block_in_blockEntry4331;
      public static readonly BitSet _EOF_in_blockEntry4333;

      static Follow()
      {
        ANTLRParser.Follow._grammarType_in_grammarSpec403 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_grammarSpec405 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_grammarSpec407 = new BitSet(new ulong[2]
        {
          144119586676025344UL,
          6UL
        });
        ANTLRParser.Follow._sync_in_grammarSpec445 = new BitSet(new ulong[2]
        {
          144119586676025344UL,
          6UL
        });
        ANTLRParser.Follow._prequelConstruct_in_grammarSpec449 = new BitSet(new ulong[2]
        {
          144119586676025344UL,
          6UL
        });
        ANTLRParser.Follow._sync_in_grammarSpec451 = new BitSet(new ulong[2]
        {
          144119586676025344UL,
          6UL
        });
        ANTLRParser.Follow._rules_in_grammarSpec476 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._modeSpec_in_grammarSpec482 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._EOF_in_grammarSpec520 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LEXER_in_grammarType690 = new BitSet(new ulong[1]
        {
          33554432UL
        });
        ANTLRParser.Follow._GRAMMAR_in_grammarType694 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._PARSER_in_grammarType719 = new BitSet(new ulong[1]
        {
          33554432UL
        });
        ANTLRParser.Follow._GRAMMAR_in_grammarType723 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._GRAMMAR_in_grammarType746 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TREE_GRAMMAR_in_grammarType775 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._optionsSpec_in_prequelConstruct801 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._delegateGrammars_in_prequelConstruct824 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._tokensSpec_in_prequelConstruct868 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._channelsSpec_in_prequelConstruct878 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._action_in_prequelConstruct915 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._OPTIONS_in_optionsSpec930 = new BitSet(new ulong[2]
        {
          162129586585337856UL,
          4UL
        });
        ANTLRParser.Follow._option_in_optionsSpec933 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_optionsSpec935 = new BitSet(new ulong[2]
        {
          162129586585337856UL,
          4UL
        });
        ANTLRParser.Follow._RBRACE_in_optionsSpec939 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_option968 = new BitSet(new ulong[1]
        {
          1024UL
        });
        ANTLRParser.Follow._ASSIGN_in_option970 = new BitSet(new ulong[2]
        {
          4755801207576985616UL,
          4UL
        });
        ANTLRParser.Follow._optionValue_in_option973 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._qid_in_optionValue1016 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_optionValue1024 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ACTION_in_optionValue1029 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._INT_in_optionValue1042 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._IMPORT_in_delegateGrammars1058 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._delegateGrammar_in_delegateGrammars1060 = new BitSet(new ulong[1]
        {
          288230376151777280UL
        });
        ANTLRParser.Follow._COMMA_in_delegateGrammars1063 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._delegateGrammar_in_delegateGrammars1065 = new BitSet(new ulong[1]
        {
          288230376151777280UL
        });
        ANTLRParser.Follow._SEMI_in_delegateGrammars1069 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_delegateGrammar1096 = new BitSet(new ulong[1]
        {
          1024UL
        });
        ANTLRParser.Follow._ASSIGN_in_delegateGrammar1098 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_delegateGrammar1101 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_delegateGrammar1111 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1125 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_tokensSpec1127 = new BitSet(new ulong[1]
        {
          18014398509547520UL
        });
        ANTLRParser.Follow._COMMA_in_tokensSpec1130 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_tokensSpec1132 = new BitSet(new ulong[1]
        {
          18014398509547520UL
        });
        ANTLRParser.Follow._COMMA_in_tokensSpec1136 = new BitSet(new ulong[1]
        {
          18014398509481984UL
        });
        ANTLRParser.Follow._RBRACE_in_tokensSpec1139 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1156 = new BitSet(new ulong[1]
        {
          18014398509481984UL
        });
        ANTLRParser.Follow._RBRACE_in_tokensSpec1158 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKENS_SPEC_in_tokensSpec1168 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._v3tokenSpec_in_tokensSpec1171 = new BitSet(new ulong[2]
        {
          162129586585337856UL,
          4UL
        });
        ANTLRParser.Follow._RBRACE_in_tokensSpec1174 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_v3tokenSpec1194 = new BitSet(new ulong[1]
        {
          288230376151712768UL
        });
        ANTLRParser.Follow._ASSIGN_in_v3tokenSpec1200 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_v3tokenSpec1204 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_v3tokenSpec1265 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._CHANNELS_in_channelsSpec1276 = new BitSet(new ulong[2]
        {
          162129586585337856UL,
          4UL
        });
        ANTLRParser.Follow._id_in_channelsSpec1280 = new BitSet(new ulong[1]
        {
          18014398509547520UL
        });
        ANTLRParser.Follow._COMMA_in_channelsSpec1283 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_channelsSpec1286 = new BitSet(new ulong[1]
        {
          18014398509547520UL
        });
        ANTLRParser.Follow._COMMA_in_channelsSpec1290 = new BitSet(new ulong[1]
        {
          18014398509481984UL
        });
        ANTLRParser.Follow._RBRACE_in_channelsSpec1295 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._AT_in_action1312 = new BitSet(new ulong[2]
        {
          144132782409383936UL,
          4UL
        });
        ANTLRParser.Follow._actionScopeName_in_action1315 = new BitSet(new ulong[1]
        {
          32768UL
        });
        ANTLRParser.Follow._COLONCOLON_in_action1317 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_action1321 = new BitSet(new ulong[1]
        {
          16UL
        });
        ANTLRParser.Follow._ACTION_in_action1323 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_actionScopeName1354 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LEXER_in_actionScopeName1359 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._PARSER_in_actionScopeName1374 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._MODE_in_modeSpec1393 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_modeSpec1395 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_modeSpec1397 = new BitSet(new ulong[2]
        {
          16777216UL,
          4UL
        });
        ANTLRParser.Follow._sync_in_modeSpec1399 = new BitSet(new ulong[2]
        {
          16777218UL,
          4UL
        });
        ANTLRParser.Follow._lexerRule_in_modeSpec1402 = new BitSet(new ulong[2]
        {
          16777216UL,
          4UL
        });
        ANTLRParser.Follow._sync_in_modeSpec1404 = new BitSet(new ulong[2]
        {
          16777218UL,
          4UL
        });
        ANTLRParser.Follow._sync_in_rules1435 = new BitSet(new ulong[2]
        {
          144115188092633090UL,
          4UL
        });
        ANTLRParser.Follow._rule_in_rules1438 = new BitSet(new ulong[2]
        {
          144115188092633088UL,
          4UL
        });
        ANTLRParser.Follow._sync_in_rules1440 = new BitSet(new ulong[2]
        {
          144115188092633090UL,
          4UL
        });
        ANTLRParser.Follow._parserRule_in_rule1504 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerRule_in_rule1509 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RULE_REF_in_parserRule1558 = new BitSet(new ulong[2]
        {
          36033203655411968UL,
          1UL
        });
        ANTLRParser.Follow._ARG_ACTION_in_parserRule1588 = new BitSet(new ulong[2]
        {
          36033203655411712UL,
          1UL
        });
        ANTLRParser.Follow._ruleReturns_in_parserRule1595 = new BitSet(new ulong[2]
        {
          4406636447744UL,
          1UL
        });
        ANTLRParser.Follow._throwsSpec_in_parserRule1602 = new BitSet(new ulong[1]
        {
          4406636447744UL
        });
        ANTLRParser.Follow._localsSpec_in_parserRule1609 = new BitSet(new ulong[1]
        {
          4398046513152UL
        });
        ANTLRParser.Follow._rulePrequels_in_parserRule1647 = new BitSet(new ulong[1]
        {
          16384UL
        });
        ANTLRParser.Follow._COLON_in_parserRule1656 = new BitSet(new ulong[2]
        {
          5332403297591492624UL,
          4UL
        });
        ANTLRParser.Follow._ruleBlock_in_parserRule1679 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_parserRule1688 = new BitSet(new ulong[1]
        {
          8392704UL
        });
        ANTLRParser.Follow._exceptionGroup_in_parserRule1697 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._exceptionHandler_in_exceptionGroup1784 = new BitSet(new ulong[1]
        {
          8392706UL
        });
        ANTLRParser.Follow._finallyClause_in_exceptionGroup1787 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._CATCH_in_exceptionHandler1804 = new BitSet(new ulong[1]
        {
          256UL
        });
        ANTLRParser.Follow._ARG_ACTION_in_exceptionHandler1806 = new BitSet(new ulong[1]
        {
          16UL
        });
        ANTLRParser.Follow._ACTION_in_exceptionHandler1808 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._FINALLY_in_finallyClause1839 = new BitSet(new ulong[1]
        {
          16UL
        });
        ANTLRParser.Follow._ACTION_in_finallyClause1841 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._sync_in_rulePrequels1875 = new BitSet(new ulong[1]
        {
          4398046513154UL
        });
        ANTLRParser.Follow._rulePrequel_in_rulePrequels1878 = new BitSet(new ulong[1]
        {
          4398046513152UL
        });
        ANTLRParser.Follow._sync_in_rulePrequels1880 = new BitSet(new ulong[1]
        {
          4398046513154UL
        });
        ANTLRParser.Follow._optionsSpec_in_rulePrequel1904 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ruleAction_in_rulePrequel1912 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RETURNS_in_ruleReturns1932 = new BitSet(new ulong[1]
        {
          256UL
        });
        ANTLRParser.Follow._ARG_ACTION_in_ruleReturns1935 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._THROWS_in_throwsSpec1965 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._qid_in_throwsSpec1967 = new BitSet(new ulong[1]
        {
          65538UL
        });
        ANTLRParser.Follow._COMMA_in_throwsSpec1970 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._qid_in_throwsSpec1972 = new BitSet(new ulong[1]
        {
          65538UL
        });
        ANTLRParser.Follow._LOCALS_in_localsSpec1997 = new BitSet(new ulong[1]
        {
          256UL
        });
        ANTLRParser.Follow._ARG_ACTION_in_localsSpec2000 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._AT_in_ruleAction2025 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_ruleAction2027 = new BitSet(new ulong[1]
        {
          16UL
        });
        ANTLRParser.Follow._ACTION_in_ruleAction2029 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ruleAltList_in_ruleBlock2069 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._labeledAlt_in_ruleAltList2107 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._OR_in_ruleAltList2110 = new BitSet(new ulong[2]
        {
          5332403297591492624UL,
          4UL
        });
        ANTLRParser.Follow._labeledAlt_in_ruleAltList2112 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._alternative_in_labeledAlt2130 = new BitSet(new ulong[1]
        {
          140737488355330UL
        });
        ANTLRParser.Follow._POUND_in_labeledAlt2136 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_labeledAlt2139 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._FRAGMENT_in_lexerRule2171 = new BitSet(new ulong[2]
        {
          0UL,
          4UL
        });
        ANTLRParser.Follow._TOKEN_REF_in_lexerRule2177 = new BitSet(new ulong[1]
        {
          16384UL
        });
        ANTLRParser.Follow._COLON_in_lexerRule2179 = new BitSet(new ulong[2]
        {
          5341269729293107216UL,
          4UL
        });
        ANTLRParser.Follow._lexerRuleBlock_in_lexerRule2181 = new BitSet(new ulong[1]
        {
          288230376151711744UL
        });
        ANTLRParser.Follow._SEMI_in_lexerRule2183 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerAltList_in_lexerRuleBlock2249 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerAlt_in_lexerAltList2287 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._OR_in_lexerAltList2290 = new BitSet(new ulong[2]
        {
          5341269729293107216UL,
          4UL
        });
        ANTLRParser.Follow._lexerAlt_in_lexerAltList2292 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._lexerElements_in_lexerAlt2310 = new BitSet(new ulong[1]
        {
          9007199254740994UL
        });
        ANTLRParser.Follow._lexerCommands_in_lexerAlt2316 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerElement_in_lexerElements2361 = new BitSet(new ulong[2]
        {
          5332262530038366226UL,
          4UL
        });
        ANTLRParser.Follow._labeledLexerElement_in_lexerElement2421 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_lexerElement2427 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerAtom_in_lexerElement2477 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_lexerElement2483 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerBlock_in_lexerElement2533 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_lexerElement2539 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._actionElement_in_lexerElement2567 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_labeledLexerElement2597 = new BitSet(new ulong[1]
        {
          70368744178688UL
        });
        ANTLRParser.Follow._ASSIGN_in_labeledLexerElement2602 = new BitSet(new ulong[2]
        {
          4755801777734942720UL,
          4UL
        });
        ANTLRParser.Follow._PLUS_ASSIGN_in_labeledLexerElement2606 = new BitSet(new ulong[2]
        {
          4755801777734942720UL,
          4UL
        });
        ANTLRParser.Follow._lexerAtom_in_labeledLexerElement2613 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerBlock_in_labeledLexerElement2630 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LPAREN_in_lexerBlock2663 = new BitSet(new ulong[2]
        {
          5341274127339618320UL,
          4UL
        });
        ANTLRParser.Follow._optionsSpec_in_lexerBlock2675 = new BitSet(new ulong[1]
        {
          16384UL
        });
        ANTLRParser.Follow._COLON_in_lexerBlock2677 = new BitSet(new ulong[2]
        {
          5341269729293107216UL,
          4UL
        });
        ANTLRParser.Follow._lexerAltList_in_lexerBlock2690 = new BitSet(new ulong[1]
        {
          72057594037927936UL
        });
        ANTLRParser.Follow._RPAREN_in_lexerBlock2700 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RARROW_in_lexerCommands2739 = new BitSet(new ulong[2]
        {
          144115256795332608UL,
          4UL
        });
        ANTLRParser.Follow._lexerCommand_in_lexerCommands2741 = new BitSet(new ulong[1]
        {
          65538UL
        });
        ANTLRParser.Follow._COMMA_in_lexerCommands2744 = new BitSet(new ulong[2]
        {
          144115256795332608UL,
          4UL
        });
        ANTLRParser.Follow._lexerCommand_in_lexerCommands2746 = new BitSet(new ulong[1]
        {
          65538UL
        });
        ANTLRParser.Follow._lexerCommandName_in_lexerCommand2764 = new BitSet(new ulong[1]
        {
          17179869184UL
        });
        ANTLRParser.Follow._LPAREN_in_lexerCommand2766 = new BitSet(new ulong[2]
        {
          144115189149597696UL,
          4UL
        });
        ANTLRParser.Follow._lexerCommandExpr_in_lexerCommand2768 = new BitSet(new ulong[1]
        {
          72057594037927936UL
        });
        ANTLRParser.Follow._RPAREN_in_lexerCommand2770 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._lexerCommandName_in_lexerCommand2785 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_lexerCommandExpr2796 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._INT_in_lexerCommandExpr2801 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_lexerCommandName2825 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._MODE_in_lexerCommandName2843 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._alternative_in_altList2871 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._OR_in_altList2874 = new BitSet(new ulong[2]
        {
          5332271356196159504UL,
          4UL
        });
        ANTLRParser.Follow._alternative_in_altList2876 = new BitSet(new ulong[1]
        {
          8796093022210UL
        });
        ANTLRParser.Follow._elementOptions_in_alternative2910 = new BitSet(new ulong[2]
        {
          5332262525743398930UL,
          4UL
        });
        ANTLRParser.Follow._element_in_alternative2919 = new BitSet(new ulong[2]
        {
          5332262525743398930UL,
          4UL
        });
        ANTLRParser.Follow._labeledElement_in_element3038 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_element3044 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._atom_in_element3094 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_element3100 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ebnf_in_element3150 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._actionElement_in_element3155 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ACTION_in_actionElement3181 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ACTION_in_actionElement3193 = new BitSet(new ulong[1]
        {
          34359738368UL
        });
        ANTLRParser.Follow._elementOptions_in_actionElement3195 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._SEMPRED_in_actionElement3215 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._SEMPRED_in_actionElement3227 = new BitSet(new ulong[1]
        {
          34359738368UL
        });
        ANTLRParser.Follow._elementOptions_in_actionElement3229 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_labeledElement3253 = new BitSet(new ulong[1]
        {
          70368744178688UL
        });
        ANTLRParser.Follow._ASSIGN_in_labeledElement3258 = new BitSet(new ulong[2]
        {
          4755801773439975424UL,
          4UL
        });
        ANTLRParser.Follow._PLUS_ASSIGN_in_labeledElement3262 = new BitSet(new ulong[2]
        {
          4755801773439975424UL,
          4UL
        });
        ANTLRParser.Follow._atom_in_labeledElement3269 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._block_in_labeledElement3291 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._block_in_ebnf3327 = new BitSet(new ulong[1]
        {
          2308129993399468034UL
        });
        ANTLRParser.Follow._blockSuffix_in_ebnf3351 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ebnfSuffix_in_blockSuffix3401 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._QUESTION_in_ebnfSuffix3416 = new BitSet(new ulong[1]
        {
          2251799813685250UL
        });
        ANTLRParser.Follow._QUESTION_in_ebnfSuffix3420 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._STAR_in_ebnfSuffix3438 = new BitSet(new ulong[1]
        {
          2251799813685250UL
        });
        ANTLRParser.Follow._QUESTION_in_ebnfSuffix3442 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._PLUS_in_ebnfSuffix3462 = new BitSet(new ulong[1]
        {
          2251799813685250UL
        });
        ANTLRParser.Follow._QUESTION_in_ebnfSuffix3466 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._range_in_lexerAtom3489 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._terminal_in_lexerAtom3494 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RULE_REF_in_lexerAtom3504 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._notSet_in_lexerAtom3517 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._wildcard_in_lexerAtom3525 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LEXER_CHAR_SET_in_lexerAtom3533 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._range_in_atom3578 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._terminal_in_atom3585 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._ruleref_in_atom3595 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._notSet_in_atom3603 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._wildcard_in_atom3611 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._DOT_in_wildcard3659 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_wildcard3661 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._NOT_in_notSet3699 = new BitSet(new ulong[2]
        {
          4611686022722355200UL,
          4UL
        });
        ANTLRParser.Follow._setElement_in_notSet3701 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._NOT_in_notSet3733 = new BitSet(new ulong[1]
        {
          17179869184UL
        });
        ANTLRParser.Follow._blockSet_in_notSet3735 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LPAREN_in_blockSet3767 = new BitSet(new ulong[2]
        {
          4611686022722355200UL,
          4UL
        });
        ANTLRParser.Follow._setElement_in_blockSet3769 = new BitSet(new ulong[1]
        {
          72066390130950144UL
        });
        ANTLRParser.Follow._OR_in_blockSet3772 = new BitSet(new ulong[2]
        {
          4611686022722355200UL,
          4UL
        });
        ANTLRParser.Follow._setElement_in_blockSet3774 = new BitSet(new ulong[1]
        {
          72066390130950144UL
        });
        ANTLRParser.Follow._RPAREN_in_blockSet3778 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKEN_REF_in_setElement3810 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_setElement3818 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_setElement3824 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_setElement3832 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._range_in_setElement3838 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LEXER_CHAR_SET_in_setElement3848 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LPAREN_in_block3872 = new BitSet(new ulong[2]
        {
          5332275754242689040UL,
          4UL
        });
        ANTLRParser.Follow._optionsSpec_in_block3884 = new BitSet(new ulong[1]
        {
          18432UL
        });
        ANTLRParser.Follow._ruleAction_in_block3889 = new BitSet(new ulong[1]
        {
          18432UL
        });
        ANTLRParser.Follow._COLON_in_block3892 = new BitSet(new ulong[2]
        {
          5332271356196159504UL,
          4UL
        });
        ANTLRParser.Follow._altList_in_block3905 = new BitSet(new ulong[1]
        {
          72057594037927936UL
        });
        ANTLRParser.Follow._RPAREN_in_block3909 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RULE_REF_in_ruleref3965 = new BitSet(new ulong[1]
        {
          34359738626UL
        });
        ANTLRParser.Follow._ARG_ACTION_in_ruleref3967 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_ruleref3970 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_range4030 = new BitSet(new ulong[1]
        {
          4503599627370496UL
        });
        ANTLRParser.Follow._RANGE_in_range4037 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_range4045 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKEN_REF_in_terminal4071 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_terminal4073 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._STRING_LITERAL_in_terminal4096 = new BitSet(new ulong[1]
        {
          34359738370UL
        });
        ANTLRParser.Follow._elementOptions_in_terminal4098 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._LT_in_elementOptions4131 = new BitSet(new ulong[2]
        {
          144115188142964736UL,
          4UL
        });
        ANTLRParser.Follow._elementOption_in_elementOptions4134 = new BitSet(new ulong[1]
        {
          67174400UL
        });
        ANTLRParser.Follow._COMMA_in_elementOptions4137 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._elementOption_in_elementOptions4139 = new BitSet(new ulong[1]
        {
          67174400UL
        });
        ANTLRParser.Follow._GT_in_elementOptions4145 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._qid_in_elementOption4193 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_elementOption4201 = new BitSet(new ulong[1]
        {
          1024UL
        });
        ANTLRParser.Follow._ASSIGN_in_elementOption4203 = new BitSet(new ulong[2]
        {
          4755801207576985616UL,
          4UL
        });
        ANTLRParser.Follow._optionValue_in_elementOption4206 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._RULE_REF_in_id4237 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._TOKEN_REF_in_id4250 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._id_in_qid4278 = new BitSet(new ulong[1]
        {
          1048578UL
        });
        ANTLRParser.Follow._DOT_in_qid4281 = new BitSet(new ulong[2]
        {
          144115188075855872UL,
          4UL
        });
        ANTLRParser.Follow._id_in_qid4283 = new BitSet(new ulong[1]
        {
          1048578UL
        });
        ANTLRParser.Follow._alternative_in_alternativeEntry4300 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._EOF_in_alternativeEntry4302 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._element_in_elementEntry4311 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._EOF_in_elementEntry4313 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._rule_in_ruleEntry4321 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._EOF_in_ruleEntry4323 = new BitSet(new ulong[1]
        {
          2UL
        });
        ANTLRParser.Follow._block_in_blockEntry4331 = new BitSet(new ulong[1]);
        ANTLRParser.Follow._EOF_in_blockEntry4333 = new BitSet(new ulong[1]
        {
          2UL
        });
      }
    }
  }
}
