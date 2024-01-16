// Decompiled with JetBrains decompiler
// Type: Antlr4.Codegen.SourceGenTriggers
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr4.Codegen.Model;
using Antlr4.Codegen.Model.Decl;
using Antlr4.Misc;
using Antlr4.Tool.Ast;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace Antlr4.Codegen
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class SourceGenTriggers : TreeParser
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
    public OutputModelController controller;
    public bool hasLookaheadBlock;
    private SourceGenTriggers.DFA7 dfa7;

    public SourceGenTriggers(ITreeNodeStream input):this(input, new RecognizerSharedState())
    {
      
    }

    public SourceGenTriggers(ITreeNodeStream input, RecognizerSharedState state):base(input, state)
    {
      
    }

    public override string[] TokenNames
    {
      get
      {
        return SourceGenTriggers.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Codegen\\SourceGenTriggers.g3";
      }
    }

    public SourceGenTriggers(ITreeNodeStream input, OutputModelController controller):this(input)
    {
      
      this.controller = controller;
    }

    [GrammarRule("dummy")]
    private void dummy()
    {
      try
      {
        try
        {
          this.PushFollow(SourceGenTriggers.Follow._block_in_dummy66);
          this.block((GrammarAST) null, (GrammarAST) null);
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

    [GrammarRule("block")]
    public IList<SrcOp> block(GrammarAST label, GrammarAST ebnfRoot)
    {
      IList<SrcOp> srcOpList = (IList<SrcOp>) null;
      try
      {
        try
        {
          GrammarAST blkAST = (GrammarAST) this.Match((IIntStream) this.input, 77, SourceGenTriggers.Follow._BLOCK_in_block91);
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
              this.Match((IIntStream) this.input, 42, SourceGenTriggers.Follow._OPTIONS_in_block95);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              int num2 = 0;
              try
              {
                while (true)
                {
                  int num3 = 2;
                  try
                  {
                    int num4 = this.input.LA(1);
                    if (num4 >= 4 && num4 <= 99)
                      num3 = 1;
                    else if (num4 == 3)
                      num3 = 2;
                  }
                  finally
                  {
                  }
                  if (num3 == 1)
                  {
                    this.MatchAny((IIntStream) this.input);
                    ++num2;
                  }
                  else
                    break;
                }
                if (num2 < 1)
                  throw new EarlyExitException(1, (IIntStream) this.input);
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
          IList<CodeBlockForAlt> codeBlockForAltList = (IList<CodeBlockForAlt>) new List<CodeBlockForAlt>();
          int num5 = 0;
          try
          {
            while (true)
            {
              int num6 = 2;
              try
              {
                if (this.input.LA(1) == 73)
                  num6 = 1;
              }
              finally
              {
              }
              if (num6 == 1)
              {
                this.PushFollow(SourceGenTriggers.Follow._alternative_in_block116);
                TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = (TreeRuleReturnScope<GrammarAST>) this.alternative();
                this.PopFollow();
                codeBlockForAltList.Add(((SourceGenTriggers.alternative_return) treeRuleReturnScope)?.altCodeBlock);
                ++num5;
              }
              else
                break;
            }
            if (num5 < 1)
              throw new EarlyExitException(3, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (codeBlockForAltList.Count == 1 && ebnfRoot == null)
            return (IList<SrcOp>) codeBlockForAltList.Cast<SrcOp>().ToArray<SrcOp>();
          if (ebnfRoot == null)
          {
            srcOpList = DefaultOutputModelFactory.List(new SrcOp[1]
            {
              (SrcOp) this.controller.GetChoiceBlock((BlockAST) blkAST, codeBlockForAltList, label)
            });
          }
          else
          {
            Choice ebnfBlock = this.controller.GetEBNFBlock(ebnfRoot, codeBlockForAltList);
            this.hasLookaheadBlock = ((this.hasLookaheadBlock ? 1 : 0) | (ebnfBlock is PlusBlock ? 1 : (ebnfBlock is StarBlock ? 1 : 0))) != 0;
            srcOpList = DefaultOutputModelFactory.List(new SrcOp[1]
            {
              (SrcOp) ebnfBlock
            });
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
      return srcOpList;
    }

    [GrammarRule("alternative")]
    private SourceGenTriggers.alternative_return alternative()
    {
      SourceGenTriggers.alternative_return alternativeReturn = new SourceGenTriggers.alternative_return(this);
      alternativeReturn.Start = (GrammarAST) this.input.LT(1);
      bool outerMost = this.InContext("RULE BLOCK");
      try
      {
        try
        {
          this.PushFollow(SourceGenTriggers.Follow._alt_in_alternative168);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = (TreeRuleReturnScope<GrammarAST>) this.alt(outerMost);
          this.PopFollow();
          alternativeReturn.altCodeBlock = ((SourceGenTriggers.alt_return) treeRuleReturnScope)?.altCodeBlock;
          alternativeReturn.ops = ((SourceGenTriggers.alt_return) treeRuleReturnScope)?.ops;
          this.controller.FinishAlternative(alternativeReturn.altCodeBlock, alternativeReturn.ops, outerMost);
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
      return alternativeReturn;
    }

    [GrammarRule("alt")]
    private SourceGenTriggers.alt_return alt(bool outerMost)
    {
      SourceGenTriggers.alt_return altReturn = new SourceGenTriggers.alt_return(this);
      altReturn.Start = (GrammarAST) this.input.LT(1);
      AltAST start = (AltAST) altReturn.Start;
      if (outerMost)
        this.controller.SetCurrentOuterMostAlt(start.alt);
      try
      {
        try
        {
          int num1 = 2;
          try
          {
            num1 = this.dfa7.Predict((IIntStream) this.input);
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
              IList<SrcOp> srcOpList1 = (IList<SrcOp>) new List<SrcOp>();
              altReturn.altCodeBlock = this.controller.Alternative(this.controller.GetCurrentOuterMostAlt(), outerMost);
              altReturn.altCodeBlock.ops = altReturn.ops = srcOpList1;
              this.controller.SetCurrentBlock((CodeBlock) altReturn.altCodeBlock);
              this.Match((IIntStream) this.input, 73, SourceGenTriggers.Follow._ALT_in_alt198);
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
                  this.PushFollow(SourceGenTriggers.Follow._elementOptions_in_alt200);
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
                        goto label_21;
                    }
                    num4 = 1;
                  }
                  finally
                  {
                  }
label_21:
                  if (num4 == 1)
                  {
                    this.PushFollow(SourceGenTriggers.Follow._element_in_alt205);
                    IList<SrcOp> srcOpList2 = this.element();
                    this.PopFollow();
                    if (srcOpList2 != null)
                    {
                      foreach (SrcOp srcOp in (IEnumerable<SrcOp>) srcOpList2)
                        srcOpList1.Add(srcOp);
                    }
                    ++num3;
                  }
                  else
                    break;
                }
                if (num3 < 1)
                  throw new EarlyExitException(5, (IIntStream) this.input);
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 2:
              this.Match((IIntStream) this.input, 73, SourceGenTriggers.Follow._ALT_in_alt219);
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
                  this.PushFollow(SourceGenTriggers.Follow._elementOptions_in_alt221);
                  this.elementOptions();
                  this.PopFollow();
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 82, SourceGenTriggers.Follow._EPSILON_in_alt224);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              altReturn.altCodeBlock = this.controller.Epsilon(this.controller.GetCurrentOuterMostAlt(), outerMost);
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
      return altReturn;
    }

    [GrammarRule("element")]
    private IList<SrcOp> element()
    {
      IList<SrcOp> srcOpList1 = (IList<SrcOp>) null;
      try
      {
        try
        {
          int num1 = 7;
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
                  throw new NoViableAltException("", 8, 4, (IIntStream) this.input, 2);
                num1 = 4;
                break;
              case 10:
              case 46:
                num1 = 1;
                break;
              case 20:
              case 39:
              case 52:
              case 57:
              case 62:
              case 66:
              case 97:
              case 99:
                num1 = 2;
                break;
              case 59:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 7;
                  break;
                }
                if ((num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 8, 5, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              case 77:
              case 79:
              case 88:
              case 89:
                num1 = 3;
                break;
              default:
                throw new NoViableAltException("", 8, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.PushFollow(SourceGenTriggers.Follow._labeledElement_in_element253);
              IList<SrcOp> srcOpList2 = this.labeledElement();
              this.PopFollow();
              srcOpList1 = srcOpList2;
              break;
            case 2:
              this.PushFollow(SourceGenTriggers.Follow._atom_in_element264);
              IList<SrcOp> srcOpList3 = this.atom((GrammarAST) null, false);
              this.PopFollow();
              srcOpList1 = srcOpList3;
              break;
            case 3:
              this.PushFollow(SourceGenTriggers.Follow._subrule_in_element274);
              IList<SrcOp> srcOpList4 = this.subrule();
              this.PopFollow();
              srcOpList1 = srcOpList4;
              break;
            case 4:
              srcOpList1 = this.controller.Action((ActionAST) this.Match((IIntStream) this.input, 4, SourceGenTriggers.Follow._ACTION_in_element289));
              break;
            case 5:
              srcOpList1 = this.controller.Sempred((ActionAST) this.Match((IIntStream) this.input, 59, SourceGenTriggers.Follow._SEMPRED_in_element304));
              break;
            case 6:
              GrammarAST ast1 = (GrammarAST) this.Match((IIntStream) this.input, 4, SourceGenTriggers.Follow._ACTION_in_element318);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(SourceGenTriggers.Follow._elementOptions_in_element320);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = this.controller.Action((ActionAST) ast1);
              break;
            case 7:
              GrammarAST ast2 = (GrammarAST) this.Match((IIntStream) this.input, 59, SourceGenTriggers.Follow._SEMPRED_in_element332);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(SourceGenTriggers.Follow._elementOptions_in_element334);
              this.elementOptions();
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = this.controller.Sempred((ActionAST) ast2);
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
      return srcOpList1;
    }

    [GrammarRule("labeledElement")]
    private IList<SrcOp> labeledElement()
    {
      IList<SrcOp> srcOpList1 = (IList<SrcOp>) null;
      try
      {
        try
        {
          int num = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 10:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 9, 1, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 9, 3, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 20:
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
                    num = 3;
                    break;
                  default:
                    throw new NoViableAltException("", 9, 5, (IIntStream) this.input, 4);
                }
                break;
              case 46:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 9, 2, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 9, 4, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 20:
                  case 39:
                  case 52:
                  case 57:
                  case 62:
                  case 66:
                  case 97:
                  case 99:
                    num = 2;
                    break;
                  case 77:
                    num = 4;
                    break;
                  default:
                    throw new NoViableAltException("", 9, 6, (IIntStream) this.input, 4);
                }
                break;
              default:
                throw new NoViableAltException("", 9, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_labeledElement354);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST label1 = (GrammarAST) this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_labeledElement356);
              this.PushFollow(SourceGenTriggers.Follow._atom_in_labeledElement358);
              IList<SrcOp> srcOpList2 = this.atom(label1, false);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList2;
              break;
            case 2:
              this.Match((IIntStream) this.input, 46, SourceGenTriggers.Follow._PLUS_ASSIGN_in_labeledElement371);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST label2 = (GrammarAST) this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_labeledElement373);
              this.PushFollow(SourceGenTriggers.Follow._atom_in_labeledElement375);
              IList<SrcOp> srcOpList3 = this.atom(label2, false);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList3;
              break;
            case 3:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_labeledElement386);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST label3 = (GrammarAST) this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_labeledElement388);
              this.PushFollow(SourceGenTriggers.Follow._block_in_labeledElement390);
              IList<SrcOp> srcOpList4 = this.block(label3, (GrammarAST) null);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList4;
              break;
            case 4:
              this.Match((IIntStream) this.input, 46, SourceGenTriggers.Follow._PLUS_ASSIGN_in_labeledElement403);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST label4 = (GrammarAST) this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_labeledElement405);
              this.PushFollow(SourceGenTriggers.Follow._block_in_labeledElement407);
              IList<SrcOp> srcOpList5 = this.block(label4, (GrammarAST) null);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList5;
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
      return srcOpList1;
    }

    [GrammarRule("subrule")]
    private IList<SrcOp> subrule()
    {
      IList<SrcOp> srcOpList1 = (IList<SrcOp>) null;
      GrammarAST ebnfRoot1 = (GrammarAST) null;
      IList<SrcOp> srcOpList2 = (IList<SrcOp>) null;
      try
      {
        try
        {
          int num1 = 3;
          try
          {
            switch (this.input.LA(1))
            {
              case 77:
                num1 = 3;
                break;
              case 79:
              case 89:
                num1 = 2;
                break;
              case 88:
                num1 = 1;
                break;
              default:
                throw new NoViableAltException("", 11, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST ebnfRoot2 = (GrammarAST) this.Match((IIntStream) this.input, 88, SourceGenTriggers.Follow._OPTIONAL_in_subrule428);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(SourceGenTriggers.Follow._block_in_subrule432);
              IList<SrcOp> srcOpList3 = this.block((GrammarAST) null, ebnfRoot2);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList3;
              break;
            case 2:
              int num2 = 2;
              try
              {
                try
                {
                  switch (this.input.LA(1))
                  {
                    case 79:
                      num2 = 1;
                      break;
                    case 89:
                      num2 = 2;
                      break;
                    default:
                      throw new NoViableAltException("", 10, 0, (IIntStream) this.input, 1);
                  }
                }
                finally
                {
                }
                switch (num2)
                {
                  case 1:
                    ebnfRoot1 = (GrammarAST) this.Match((IIntStream) this.input, 79, SourceGenTriggers.Follow._CLOSURE_in_subrule448);
                    this.Match((IIntStream) this.input, 2, (BitSet) null);
                    this.PushFollow(SourceGenTriggers.Follow._block_in_subrule452);
                    srcOpList2 = this.block((GrammarAST) null, (GrammarAST) null);
                    this.PopFollow();
                    this.Match((IIntStream) this.input, 3, (BitSet) null);
                    break;
                  case 2:
                    ebnfRoot1 = (GrammarAST) this.Match((IIntStream) this.input, 89, SourceGenTriggers.Follow._POSITIVE_CLOSURE_in_subrule463);
                    this.Match((IIntStream) this.input, 2, (BitSet) null);
                    this.PushFollow(SourceGenTriggers.Follow._block_in_subrule467);
                    srcOpList2 = this.block((GrammarAST) null, (GrammarAST) null);
                    this.PopFollow();
                    this.Match((IIntStream) this.input, 3, (BitSet) null);
                    break;
                }
              }
              finally
              {
              }
              IList<CodeBlockForAlt> alts = (IList<CodeBlockForAlt>) new List<CodeBlockForAlt>();
              SrcOp op = srcOpList2[0];
              CodeBlockForAlt codeBlockForAlt = new CodeBlockForAlt(this.controller.@delegate);
              codeBlockForAlt.AddOp(op);
              alts.Add(codeBlockForAlt);
              SrcOp ebnfBlock = (SrcOp) this.controller.GetEBNFBlock(ebnfRoot1, alts);
              this.hasLookaheadBlock = ((this.hasLookaheadBlock ? 1 : 0) | (ebnfBlock is PlusBlock ? 1 : (ebnfBlock is StarBlock ? 1 : 0))) != 0;
              srcOpList1 = DefaultOutputModelFactory.List(new SrcOp[1]
              {
                ebnfBlock
              });
              break;
            case 3:
              this.PushFollow(SourceGenTriggers.Follow._block_in_subrule483);
              IList<SrcOp> srcOpList4 = this.block((GrammarAST) null, (GrammarAST) null);
              this.PopFollow();
              srcOpList1 = srcOpList4;
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
      return srcOpList1;
    }

    [GrammarRule("blockSet")]
    private IList<SrcOp> blockSet(GrammarAST label, bool invert)
    {
      IList<SrcOp> srcOpList = (IList<SrcOp>) null;
      try
      {
        try
        {
          GrammarAST setAST = (GrammarAST) this.Match((IIntStream) this.input, 97, SourceGenTriggers.Follow._SET_in_blockSet513);
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
                  case 20:
                  case 39:
                  case 52:
                  case 57:
                  case 62:
                  case 66:
                  case 97:
                  case 99:
                    num2 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(SourceGenTriggers.Follow._atom_in_blockSet515);
                this.atom(label, invert);
                this.PopFollow();
                ++num1;
              }
              else
                break;
            }
            if (num1 < 1)
              throw new EarlyExitException(12, (IIntStream) this.input);
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          srcOpList = this.controller.Set(setAST, label, invert);
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
      return srcOpList;
    }

    [GrammarRule("atom")]
    private IList<SrcOp> atom(GrammarAST label, bool invert)
    {
      IList<SrcOp> srcOpList1 = (IList<SrcOp>) null;
      try
      {
        try
        {
          int num1 = 9;
          try
          {
            switch (this.input.LA(1))
            {
              case 20:
                if (this.input.LA(2) != 2)
                  throw new NoViableAltException("", 13, 3, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 13, 8, (IIntStream) this.input, 3);
                switch (this.input.LA(4))
                {
                  case 57:
                    num1 = 4;
                    break;
                  case 62:
                  case 66:
                    num1 = 3;
                    break;
                  default:
                    throw new NoViableAltException("", 13, 11, (IIntStream) this.input, 4);
                }
                break;
              case 39:
                num1 = 1;
                break;
              case 52:
                num1 = 2;
                break;
              case 57:
                num1 = 8;
                break;
              case 62:
              case 66:
                num1 = 7;
                break;
              case 97:
                num1 = 9;
                break;
              case 99:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 5;
                  break;
                }
                if ((num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 13, 4, (IIntStream) this.input, 2);
                num1 = 6;
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
              this.Match((IIntStream) this.input, 39, SourceGenTriggers.Follow._NOT_in_atom545);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.PushFollow(SourceGenTriggers.Follow._atom_in_atom549);
              IList<SrcOp> srcOpList2 = this.atom(label, true);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = srcOpList2;
              break;
            case 2:
              this.PushFollow(SourceGenTriggers.Follow._range_in_atom559);
              IList<SrcOp> srcOpList3 = this.range(label);
              this.PopFollow();
              srcOpList1 = srcOpList3;
              break;
            case 3:
              this.Match((IIntStream) this.input, 20, SourceGenTriggers.Follow._DOT_in_atom574);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_atom576);
              this.PushFollow(SourceGenTriggers.Follow._terminal_in_atom578);
              this.terminal(label);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 4:
              this.Match((IIntStream) this.input, 20, SourceGenTriggers.Follow._DOT_in_atom586);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_atom588);
              this.PushFollow(SourceGenTriggers.Follow._ruleref_in_atom590);
              this.ruleref(label);
              this.PopFollow();
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 5:
              GrammarAST ast = (GrammarAST) this.Match((IIntStream) this.input, 99, SourceGenTriggers.Follow._WILDCARD_in_atom601);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList1 = this.controller.Wildcard(ast, label);
              break;
            case 6:
              srcOpList1 = this.controller.Wildcard((GrammarAST) this.Match((IIntStream) this.input, 99, SourceGenTriggers.Follow._WILDCARD_in_atom620), label);
              break;
            case 7:
              this.PushFollow(SourceGenTriggers.Follow._terminal_in_atom639);
              IList<SrcOp> srcOpList4 = this.terminal(label);
              this.PopFollow();
              srcOpList1 = srcOpList4;
              break;
            case 8:
              this.PushFollow(SourceGenTriggers.Follow._ruleref_in_atom656);
              IList<SrcOp> srcOpList5 = this.ruleref(label);
              this.PopFollow();
              srcOpList1 = srcOpList5;
              break;
            case 9:
              this.PushFollow(SourceGenTriggers.Follow._blockSet_in_atom668);
              IList<SrcOp> srcOpList6 = this.blockSet(label, invert);
              this.PopFollow();
              srcOpList1 = srcOpList6;
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
      return srcOpList1;
    }

    [GrammarRule("ruleref")]
    private IList<SrcOp> ruleref(GrammarAST label)
    {
      IList<SrcOp> srcOpList = (IList<SrcOp>) null;
      GrammarAST args = (GrammarAST) null;
      try
      {
        try
        {
          GrammarAST ID = (GrammarAST) this.Match((IIntStream) this.input, 57, SourceGenTriggers.Follow._RULE_REF_in_ruleref692);
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
                args = (GrammarAST) this.Match((IIntStream) this.input, 8, SourceGenTriggers.Follow._ARG_ACTION_in_ruleref694);
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
                this.PushFollow(SourceGenTriggers.Follow._elementOptions_in_ruleref697);
                this.elementOptions();
                this.PopFollow();
              }
            }
            finally
            {
            }
            this.Match((IIntStream) this.input, 3, (BitSet) null);
          }
          srcOpList = this.controller.RuleRef(ID, label, args);
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
      return srcOpList;
    }

    [GrammarRule("range")]
    private IList<SrcOp> range(GrammarAST label)
    {
      IList<SrcOp> srcOpList = (IList<SrcOp>) null;
      GrammarAST grammarAst1 = (GrammarAST) null;
      GrammarAST grammarAst2 = (GrammarAST) null;
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 52, SourceGenTriggers.Follow._RANGE_in_range725);
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          grammarAst1 = (GrammarAST) this.Match((IIntStream) this.input, 62, SourceGenTriggers.Follow._STRING_LITERAL_in_range729);
          grammarAst2 = (GrammarAST) this.Match((IIntStream) this.input, 62, SourceGenTriggers.Follow._STRING_LITERAL_in_range733);
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
      return srcOpList;
    }

    [GrammarRule("terminal")]
    private IList<SrcOp> terminal(GrammarAST label)
    {
      IList<SrcOp> srcOpList = (IList<SrcOp>) null;
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
                if ((num2 < 3 || num2 > 4) && num2 != 10 && num2 != 20 && num2 != 39 && num2 != 46 && num2 != 52 && num2 != 57 && num2 != 59 && num2 != 62 && num2 != 66 && num2 != 77 && num2 != 79 && (num2 < 88 || num2 > 89) && num2 != 97 && num2 != 99)
                  throw new NoViableAltException("", 16, 1, (IIntStream) this.input, 2);
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
                      throw new NoViableAltException("", 16, 7, (IIntStream) this.input, 4);
                    num1 = 4;
                    break;
                  }
                  if ((num4 < 4 || num4 > 7) && (num4 < 9 || num4 > 99))
                    throw new NoViableAltException("", 16, 5, (IIntStream) this.input, 3);
                  num1 = 4;
                  break;
                }
                if ((num3 < 3 || num3 > 4) && num3 != 10 && num3 != 20 && num3 != 39 && num3 != 46 && num3 != 52 && num3 != 57 && num3 != 59 && num3 != 62 && num3 != 66 && num3 != 77 && num3 != 79 && (num3 < 88 || num3 > 89) && num3 != 97 && num3 != 99)
                  throw new NoViableAltException("", 16, 2, (IIntStream) this.input, 2);
                num1 = 5;
                break;
              default:
                throw new NoViableAltException("", 16, 0, (IIntStream) this.input, 1);
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              GrammarAST ID1 = (GrammarAST) this.Match((IIntStream) this.input, 62, SourceGenTriggers.Follow._STRING_LITERAL_in_terminal758);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList = this.controller.StringRef(ID1, label);
              break;
            case 2:
              srcOpList = this.controller.StringRef((GrammarAST) this.Match((IIntStream) this.input, 62, SourceGenTriggers.Follow._STRING_LITERAL_in_terminal773), label);
              break;
            case 3:
              GrammarAST ID2 = (GrammarAST) this.Match((IIntStream) this.input, 66, SourceGenTriggers.Follow._TOKEN_REF_in_terminal787);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              GrammarAST args = (GrammarAST) this.Match((IIntStream) this.input, 8, SourceGenTriggers.Follow._ARG_ACTION_in_terminal789);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList = this.controller.TokenRef(ID2, label, args);
              break;
            case 4:
              GrammarAST ID3 = (GrammarAST) this.Match((IIntStream) this.input, 66, SourceGenTriggers.Follow._TOKEN_REF_in_terminal803);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.MatchAny((IIntStream) this.input);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              srcOpList = this.controller.TokenRef(ID3, label, (GrammarAST) null);
              break;
            case 5:
              srcOpList = this.controller.TokenRef((GrammarAST) this.Match((IIntStream) this.input, 66, SourceGenTriggers.Follow._TOKEN_REF_in_terminal819), label, (GrammarAST) null);
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
      return srcOpList;
    }

    [GrammarRule("elementOptions")]
    private void elementOptions()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 81, SourceGenTriggers.Follow._ELEMENT_OPTIONS_in_elementOptions843);
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
                this.PushFollow(SourceGenTriggers.Follow._elementOption_in_elementOptions845);
                this.elementOption();
                this.PopFollow();
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
                  throw new NoViableAltException("", 18, 2, (IIntStream) this.input, 2);
                if (this.input.LA(3) != 28)
                  throw new NoViableAltException("", 18, 3, (IIntStream) this.input, 3);
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
                    throw new NoViableAltException("", 18, 4, (IIntStream) this.input, 4);
                }
                break;
              case 28:
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
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption864);
              break;
            case 2:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_elementOption875);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption877);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption879);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 3:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_elementOption891);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption893);
              this.Match((IIntStream) this.input, 62, SourceGenTriggers.Follow._STRING_LITERAL_in_elementOption895);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 4:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_elementOption907);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption909);
              this.Match((IIntStream) this.input, 4, SourceGenTriggers.Follow._ACTION_in_elementOption911);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              break;
            case 5:
              this.Match((IIntStream) this.input, 10, SourceGenTriggers.Follow._ASSIGN_in_elementOption923);
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              this.Match((IIntStream) this.input, 28, SourceGenTriggers.Follow._ID_in_elementOption925);
              this.Match((IIntStream) this.input, 30, SourceGenTriggers.Follow._INT_in_elementOption927);
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
      this.dfa7 = new SourceGenTriggers.DFA7((BaseRecognizer) this);
    }

    static SourceGenTriggers()
    {
      SourceGenTriggers.tokenNames = new string[100]
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

    private sealed class alternative_return : TreeRuleReturnScope<GrammarAST>
    {
      public CodeBlockForAlt altCodeBlock;
      public IList<SrcOp> ops;

      public alternative_return(SourceGenTriggers grammar):base()
      {
      }
    }

    private sealed class alt_return : TreeRuleReturnScope<GrammarAST>
    {
      public CodeBlockForAlt altCodeBlock;
      public IList<SrcOp> ops;

      public alt_return(SourceGenTriggers grammar):base()
      {
      }
    }

    private class DFA7 : DFA
    {
      private const string DFA7_eotS = "\u0014\uFFFF";
      private const string DFA7_eofS = "\u0014\uFFFF";
      private const string DFA7_minS = "\u0001I\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0001\n\u0001\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003";
      private const string DFA7_maxS = "\u0001I\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C";
      private const string DFA7_acceptS = "\u0004\uFFFF\u0001\u0001\u0001\u0002\u000E\uFFFF";
      private const string DFA7_specialS = "\u0014\uFFFF}>";
      private static readonly string[] DFA7_transitionS;
      private static readonly short[] DFA7_eot;
      private static readonly short[] DFA7_eof;
      private static readonly char[] DFA7_min;
      private static readonly char[] DFA7_max;
      private static readonly short[] DFA7_accept;
      private static readonly short[] DFA7_special;
      private static readonly short[][] DFA7_transition;

      static DFA7()
      {
        SourceGenTriggers.DFA7.DFA7_transitionS = new string[20]
        {
          "\u0001\u0001",
          "\u0001\u0002",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0003\u0001\u0005\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0006",
          "",
          "",
          "\u0001\b\u0011\uFFFF\u0001\a",
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
        SourceGenTriggers.DFA7.DFA7_eot = DFA.UnpackEncodedString("\u0014\uFFFF");
        SourceGenTriggers.DFA7.DFA7_eof = DFA.UnpackEncodedString("\u0014\uFFFF");
        SourceGenTriggers.DFA7.DFA7_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001I\u0001\u0002\u0001\u0004\u0001\u0002\u0002\uFFFF\u0001\n\u0001\u0003\u0001\u0002\u0001\u0004\u0001\u001C\u0001\u0004\b\u0003");
        SourceGenTriggers.DFA7.DFA7_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001I\u0001\u0002\u0001c\u0001\u0002\u0002\uFFFF\u0002\u001C\u0001\u0002\u0001c\u0001\u001C\u0001>\u0004\u0003\u0004\u001C");
        SourceGenTriggers.DFA7.DFA7_accept = DFA.UnpackEncodedString("\u0004\uFFFF\u0001\u0001\u0001\u0002\u000E\uFFFF");
        SourceGenTriggers.DFA7.DFA7_special = DFA.UnpackEncodedString("\u0014\uFFFF}>");
        int length = SourceGenTriggers.DFA7.DFA7_transitionS.Length;
        SourceGenTriggers.DFA7.DFA7_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          SourceGenTriggers.DFA7.DFA7_transition[index] = DFA.UnpackEncodedString(SourceGenTriggers.DFA7.DFA7_transitionS[index]);
      }

      public DFA7(BaseRecognizer recognizer) : base()
      {
        this.recognizer = recognizer;
        this.decisionNumber = 7;
        this.eot = SourceGenTriggers.DFA7.DFA7_eot;
        this.eof = SourceGenTriggers.DFA7.DFA7_eof;
        this.min = SourceGenTriggers.DFA7.DFA7_min;
        this.max = SourceGenTriggers.DFA7.DFA7_max;
        this.accept = SourceGenTriggers.DFA7.DFA7_accept;
        this.special = SourceGenTriggers.DFA7.DFA7_special;
        this.transition = SourceGenTriggers.DFA7.DFA7_transition;
      }

      public override string Description
      {
        get
        {
          return "64:1: alt[bool outerMost] returns [CodeBlockForAlt altCodeBlock, IList<SrcOp> ops] : ( ^( ALT ( elementOptions )? ( element )+ ) | ^( ALT ( elementOptions )? EPSILON ) );";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private static class Follow
    {
      public static readonly BitSet _block_in_dummy66;
      public static readonly BitSet _BLOCK_in_block91;
      public static readonly BitSet _OPTIONS_in_block95;
      public static readonly BitSet _alternative_in_block116;
      public static readonly BitSet _alt_in_alternative168;
      public static readonly BitSet _ALT_in_alt198;
      public static readonly BitSet _elementOptions_in_alt200;
      public static readonly BitSet _element_in_alt205;
      public static readonly BitSet _ALT_in_alt219;
      public static readonly BitSet _elementOptions_in_alt221;
      public static readonly BitSet _EPSILON_in_alt224;
      public static readonly BitSet _labeledElement_in_element253;
      public static readonly BitSet _atom_in_element264;
      public static readonly BitSet _subrule_in_element274;
      public static readonly BitSet _ACTION_in_element289;
      public static readonly BitSet _SEMPRED_in_element304;
      public static readonly BitSet _ACTION_in_element318;
      public static readonly BitSet _elementOptions_in_element320;
      public static readonly BitSet _SEMPRED_in_element332;
      public static readonly BitSet _elementOptions_in_element334;
      public static readonly BitSet _ASSIGN_in_labeledElement354;
      public static readonly BitSet _ID_in_labeledElement356;
      public static readonly BitSet _atom_in_labeledElement358;
      public static readonly BitSet _PLUS_ASSIGN_in_labeledElement371;
      public static readonly BitSet _ID_in_labeledElement373;
      public static readonly BitSet _atom_in_labeledElement375;
      public static readonly BitSet _ASSIGN_in_labeledElement386;
      public static readonly BitSet _ID_in_labeledElement388;
      public static readonly BitSet _block_in_labeledElement390;
      public static readonly BitSet _PLUS_ASSIGN_in_labeledElement403;
      public static readonly BitSet _ID_in_labeledElement405;
      public static readonly BitSet _block_in_labeledElement407;
      public static readonly BitSet _OPTIONAL_in_subrule428;
      public static readonly BitSet _block_in_subrule432;
      public static readonly BitSet _CLOSURE_in_subrule448;
      public static readonly BitSet _block_in_subrule452;
      public static readonly BitSet _POSITIVE_CLOSURE_in_subrule463;
      public static readonly BitSet _block_in_subrule467;
      public static readonly BitSet _block_in_subrule483;
      public static readonly BitSet _SET_in_blockSet513;
      public static readonly BitSet _atom_in_blockSet515;
      public static readonly BitSet _NOT_in_atom545;
      public static readonly BitSet _atom_in_atom549;
      public static readonly BitSet _range_in_atom559;
      public static readonly BitSet _DOT_in_atom574;
      public static readonly BitSet _ID_in_atom576;
      public static readonly BitSet _terminal_in_atom578;
      public static readonly BitSet _DOT_in_atom586;
      public static readonly BitSet _ID_in_atom588;
      public static readonly BitSet _ruleref_in_atom590;
      public static readonly BitSet _WILDCARD_in_atom601;
      public static readonly BitSet _WILDCARD_in_atom620;
      public static readonly BitSet _terminal_in_atom639;
      public static readonly BitSet _ruleref_in_atom656;
      public static readonly BitSet _blockSet_in_atom668;
      public static readonly BitSet _RULE_REF_in_ruleref692;
      public static readonly BitSet _ARG_ACTION_in_ruleref694;
      public static readonly BitSet _elementOptions_in_ruleref697;
      public static readonly BitSet _RANGE_in_range725;
      public static readonly BitSet _STRING_LITERAL_in_range729;
      public static readonly BitSet _STRING_LITERAL_in_range733;
      public static readonly BitSet _STRING_LITERAL_in_terminal758;
      public static readonly BitSet _STRING_LITERAL_in_terminal773;
      public static readonly BitSet _TOKEN_REF_in_terminal787;
      public static readonly BitSet _ARG_ACTION_in_terminal789;
      public static readonly BitSet _TOKEN_REF_in_terminal803;
      public static readonly BitSet _TOKEN_REF_in_terminal819;
      public static readonly BitSet _ELEMENT_OPTIONS_in_elementOptions843;
      public static readonly BitSet _elementOption_in_elementOptions845;
      public static readonly BitSet _ID_in_elementOption864;
      public static readonly BitSet _ASSIGN_in_elementOption875;
      public static readonly BitSet _ID_in_elementOption877;
      public static readonly BitSet _ID_in_elementOption879;
      public static readonly BitSet _ASSIGN_in_elementOption891;
      public static readonly BitSet _ID_in_elementOption893;
      public static readonly BitSet _STRING_LITERAL_in_elementOption895;
      public static readonly BitSet _ASSIGN_in_elementOption907;
      public static readonly BitSet _ID_in_elementOption909;
      public static readonly BitSet _ACTION_in_elementOption911;
      public static readonly BitSet _ASSIGN_in_elementOption923;
      public static readonly BitSet _ID_in_elementOption925;
      public static readonly BitSet _INT_in_elementOption927;

      static Follow()
      {
        SourceGenTriggers.Follow._block_in_dummy66 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._BLOCK_in_block91 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._OPTIONS_in_block95 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._alternative_in_block116 = new BitSet(new ulong[2]
        {
          8UL,
          512UL
        });
        SourceGenTriggers.Follow._alt_in_alternative168 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ALT_in_alt198 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._elementOptions_in_alt200 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000045572UL
        });
        SourceGenTriggers.Follow._element_in_alt205 = new BitSet(new ulong[2]
        {
          5336836476935078936UL,
          43000045572UL
        });
        SourceGenTriggers.Follow._ALT_in_alt219 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._elementOptions_in_alt221 = new BitSet(new ulong[2]
        {
          0UL,
          262144UL
        });
        SourceGenTriggers.Follow._EPSILON_in_alt224 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._labeledElement_in_element253 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._atom_in_element264 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._subrule_in_element274 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ACTION_in_element289 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._SEMPRED_in_element304 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ACTION_in_element318 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._elementOptions_in_element320 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._SEMPRED_in_element332 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._elementOptions_in_element334 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_labeledElement354 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_labeledElement356 = new BitSet(new ulong[2]
        {
          4760305355887476736UL,
          42949672964UL
        });
        SourceGenTriggers.Follow._atom_in_labeledElement358 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._PLUS_ASSIGN_in_labeledElement371 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_labeledElement373 = new BitSet(new ulong[2]
        {
          4760305355887476736UL,
          42949672964UL
        });
        SourceGenTriggers.Follow._atom_in_labeledElement375 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_labeledElement386 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_labeledElement388 = new BitSet(new ulong[2]
        {
          0UL,
          8192UL
        });
        SourceGenTriggers.Follow._block_in_labeledElement390 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._PLUS_ASSIGN_in_labeledElement403 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_labeledElement405 = new BitSet(new ulong[2]
        {
          0UL,
          8192UL
        });
        SourceGenTriggers.Follow._block_in_labeledElement407 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._OPTIONAL_in_subrule428 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._block_in_subrule432 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._CLOSURE_in_subrule448 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._block_in_subrule452 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._POSITIVE_CLOSURE_in_subrule463 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._block_in_subrule467 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._block_in_subrule483 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._SET_in_blockSet513 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._atom_in_blockSet515 = new BitSet(new ulong[2]
        {
          4760305355887476744UL,
          42949672964UL
        });
        SourceGenTriggers.Follow._NOT_in_atom545 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._atom_in_atom549 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._range_in_atom559 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._DOT_in_atom574 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_atom576 = new BitSet(new ulong[2]
        {
          4611686018427387904UL,
          4UL
        });
        SourceGenTriggers.Follow._terminal_in_atom578 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._DOT_in_atom586 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_atom588 = new BitSet(new ulong[1]
        {
          144115188075855872UL
        });
        SourceGenTriggers.Follow._ruleref_in_atom590 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._WILDCARD_in_atom601 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._WILDCARD_in_atom620 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._terminal_in_atom639 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ruleref_in_atom656 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._blockSet_in_atom668 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._RULE_REF_in_ruleref692 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ARG_ACTION_in_ruleref694 = new BitSet(new ulong[2]
        {
          8UL,
          131072UL
        });
        SourceGenTriggers.Follow._elementOptions_in_ruleref697 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._RANGE_in_range725 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._STRING_LITERAL_in_range729 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        SourceGenTriggers.Follow._STRING_LITERAL_in_range733 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._STRING_LITERAL_in_terminal758 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._STRING_LITERAL_in_terminal773 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._TOKEN_REF_in_terminal787 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ARG_ACTION_in_terminal789 = new BitSet(new ulong[2]
        {
          18446744073709551600UL,
          68719476735UL
        });
        SourceGenTriggers.Follow._TOKEN_REF_in_terminal803 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._TOKEN_REF_in_terminal819 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ELEMENT_OPTIONS_in_elementOptions843 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._elementOption_in_elementOptions845 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption864 = new BitSet(new ulong[1]
        {
          2UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_elementOption875 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption877 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption879 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_elementOption891 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption893 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        SourceGenTriggers.Follow._STRING_LITERAL_in_elementOption895 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_elementOption907 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption909 = new BitSet(new ulong[1]
        {
          16UL
        });
        SourceGenTriggers.Follow._ACTION_in_elementOption911 = new BitSet(new ulong[1]
        {
          8UL
        });
        SourceGenTriggers.Follow._ASSIGN_in_elementOption923 = new BitSet(new ulong[1]
        {
          4UL
        });
        SourceGenTriggers.Follow._ID_in_elementOption925 = new BitSet(new ulong[1]
        {
          1073741824UL
        });
        SourceGenTriggers.Follow._INT_in_elementOption927 = new BitSet(new ulong[1]
        {
          8UL
        });
      }
    }
  }
}
