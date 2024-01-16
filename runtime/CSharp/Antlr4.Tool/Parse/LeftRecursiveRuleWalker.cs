// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.LeftRecursiveRuleWalker
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr4.Tool.Ast;
using System;
using System.CodeDom.Compiler;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class LeftRecursiveRuleWalker : TreeParser
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
    private string ruleName;
    private int currentOuterAltNumber;
    public int numAlts;
    private LeftRecursiveRuleWalker.DFA11 dfa11;
    private LeftRecursiveRuleWalker.DFA14 dfa14;

    public LeftRecursiveRuleWalker(ITreeNodeStream input): this(input, new RecognizerSharedState())
    {
      
    }

    public LeftRecursiveRuleWalker(ITreeNodeStream input, RecognizerSharedState state): base(input, state)
    {
      
    }

    public override string[] TokenNames
    {
      get
      {
        return LeftRecursiveRuleWalker.tokenNames;
      }
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\LeftRecursiveRuleWalker.g3";
      }
    }

    public virtual void SetAltAssoc(AltAST altTree, int alt)
    {
    }

    public virtual void BinaryAlt(AltAST altTree, int alt)
    {
    }

    public virtual void PrefixAlt(AltAST altTree, int alt)
    {
    }

    public virtual void SuffixAlt(AltAST altTree, int alt)
    {
    }

    public virtual void OtherAlt(AltAST altTree, int alt)
    {
    }

    public virtual void SetReturnValues(GrammarAST t)
    {
    }

    [GrammarRule("rec_rule")]
    public bool rec_rule()
    {
      bool flag = false;
      GrammarAST grammarAst1 = (GrammarAST) null;
      this.currentOuterAltNumber = 1;
      try
      {
        try
        {
          grammarAst1 = (GrammarAST) this.Match((IIntStream) this.input, 93, LeftRecursiveRuleWalker.Follow._RULE_in_rec_rule83);
          if (this.state.failed)
            return flag;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return flag;
          GrammarAST grammarAst2 = (GrammarAST) this.Match((IIntStream) this.input, 57, LeftRecursiveRuleWalker.Follow._RULE_REF_in_rec_rule87);
          if (this.state.failed)
            return flag;
          if (this.state.backtracking == 0)
            this.ruleName = grammarAst2.Text;
          int num1 = 2;
          try
          {
            try
            {
              switch (this.input.LA(1))
              {
                case 48:
                case 49:
                case 50:
                  num1 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._ruleModifier_in_rec_rule94);
              this.ruleModifier();
              this.PopFollow();
              if (this.state.failed)
                return flag;
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
              this.Match((IIntStream) this.input, 55, LeftRecursiveRuleWalker.Follow._RETURNS_in_rec_rule103);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return flag;
              GrammarAST t = (GrammarAST) this.Match((IIntStream) this.input, 8, LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_rec_rule107);
              if (this.state.failed)
                return flag;
              if (this.state.backtracking == 0)
                this.SetReturnValues(t);
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return flag;
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
              if (this.input.LA(1) == 33)
                num3 = 1;
            }
            finally
            {
            }
            if (num3 == 1)
            {
              this.Match((IIntStream) this.input, 33, LeftRecursiveRuleWalker.Follow._LOCALS_in_rec_rule126);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 8, LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_rec_rule128);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return flag;
            }
          }
          finally
          {
          }
          try
          {
            do
            {
              do
              {
                do
                {
                  int num4 = 3;
                  try
                  {
                    switch (this.input.LA(1))
                    {
                      case 11:
                        num4 = 2;
                        break;
                      case 42:
                        num4 = 1;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  switch (num4)
                  {
                    case 1:
                      this.Match((IIntStream) this.input, 42, LeftRecursiveRuleWalker.Follow._OPTIONS_in_rec_rule146);
                      if (this.state.failed)
                        return flag;
                      continue;
                    case 2:
                      goto label_71;
                    default:
                      goto label_82;
                  }
                }
                while (this.input.LA(1) != 2);
                this.Match((IIntStream) this.input, 2, (BitSet) null);
                if (this.state.failed)
                  return flag;
                try
                {
                  do
                  {
                    int num5 = 2;
                    try
                    {
                      int num6 = this.input.LA(1);
                      if (num6 >= 4 && num6 <= 99)
                        num5 = 1;
                      else if (num6 == 3)
                        num5 = 2;
                    }
                    finally
                    {
                    }
                    if (num5 == 1)
                      this.MatchAny((IIntStream) this.input);
                    else
                      goto label_69;
                  }
                  while (!this.state.failed);
                  return flag;
                }
                finally
                {
                }
label_69:
                this.Match((IIntStream) this.input, 3, (BitSet) null);
              }
              while (!this.state.failed);
              return flag;
label_71:
              this.Match((IIntStream) this.input, 11, LeftRecursiveRuleWalker.Follow._AT_in_rec_rule163);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_rec_rule165);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_rec_rule167);
              if (this.state.failed)
                return flag;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
            }
            while (!this.state.failed);
            return flag;
          }
          finally
          {
          }
label_82:
          this.PushFollow(LeftRecursiveRuleWalker.Follow._ruleBlock_in_rec_rule183);
          TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = (TreeRuleReturnScope<GrammarAST>) this.ruleBlock();
          this.PopFollow();
          if (this.state.failed)
            return flag;
          if (this.state.backtracking == 0)
            flag = treeRuleReturnScope != null && ((LeftRecursiveRuleWalker.ruleBlock_return) treeRuleReturnScope).isLeftRec;
          this.PushFollow(LeftRecursiveRuleWalker.Follow._exceptionGroup_in_rec_rule190);
          this.exceptionGroup();
          this.PopFollow();
          if (this.state.failed)
            return flag;
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed)
            return flag;
        }
        finally
        {
        }
      }
      finally
      {
      }
      return flag;
    }

    [GrammarRule("exceptionGroup")]
    private void exceptionGroup()
    {
      try
      {
        try
        {
          try
          {
            do
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
                this.PushFollow(LeftRecursiveRuleWalker.Follow._exceptionHandler_in_exceptionGroup208);
                this.exceptionHandler();
                this.PopFollow();
              }
              else
                goto label_7;
            }
            while (!this.state.failed);
            return;
          }
          finally
          {
          }
label_7:
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
            if (num1 != 1)
              return;
            this.PushFollow(LeftRecursiveRuleWalker.Follow._finallyClause_in_exceptionGroup211);
            this.finallyClause();
            this.PopFollow();
            if (!this.state.failed)
              ;
          }
          finally
          {
          }
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("exceptionHandler")]
    private void exceptionHandler()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 12, LeftRecursiveRuleWalker.Follow._CATCH_in_exceptionHandler227);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 8, LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_exceptionHandler229);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_exceptionHandler231);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("finallyClause")]
    private void finallyClause()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 23, LeftRecursiveRuleWalker.Follow._FINALLY_in_finallyClause244);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_finallyClause246);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("ruleModifier")]
    private void ruleModifier()
    {
      try
      {
        try
        {
          if (this.input.LA(1) >= 48 && this.input.LA(1) <= 50)
          {
            this.input.Consume();
            this.state.errorRecovery = false;
            this.state.failed = false;
          }
          else
          {
            if (this.state.backtracking <= 0)
              throw new MismatchedSetException((BitSet) null, (IIntStream) this.input);
            this.state.failed = true;
          }
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
    private LeftRecursiveRuleWalker.ruleBlock_return ruleBlock()
    {
      LeftRecursiveRuleWalker.ruleBlock_return ruleBlockReturn = new LeftRecursiveRuleWalker.ruleBlock_return(this);
      ruleBlockReturn.Start = (GrammarAST) this.input.LT(1);
      this.numAlts = ruleBlockReturn.Start.ChildCount;
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, LeftRecursiveRuleWalker.Follow._BLOCK_in_ruleBlock301);
          if (this.state.failed)
            return ruleBlockReturn;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return ruleBlockReturn;
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
                this.PushFollow(LeftRecursiveRuleWalker.Follow._outerAlternative_in_ruleBlock314);
                TreeRuleReturnScope<GrammarAST> treeRuleReturnScope = (TreeRuleReturnScope<GrammarAST>) this.outerAlternative();
                this.PopFollow();
                if (!this.state.failed)
                {
                  if (this.state.backtracking == 0 && (treeRuleReturnScope != null ? (((LeftRecursiveRuleWalker.outerAlternative_return) treeRuleReturnScope).isLeftRec ? 1 : 0) : 0) != 0)
                    ruleBlockReturn.isLeftRec = true;
                  if (this.state.backtracking == 0)
                    ++this.currentOuterAltNumber;
                  ++num1;
                }
                else
                  break;
              }
              else
                goto label_17;
            }
            return ruleBlockReturn;
label_17:
            if (num1 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(8, (IIntStream) this.input);
              this.state.failed = true;
              return ruleBlockReturn;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed)
            return ruleBlockReturn;
        }
        finally
        {
        }
      }
      finally
      {
      }
      return ruleBlockReturn;
    }

    [GrammarRule("outerAlternative")]
    private LeftRecursiveRuleWalker.outerAlternative_return outerAlternative()
    {
      LeftRecursiveRuleWalker.outerAlternative_return alternativeReturn = new LeftRecursiveRuleWalker.outerAlternative_return(this);
      alternativeReturn.Start = (GrammarAST) this.input.LT(1);
      try
      {
        try
        {
          int num = 4;
          try
          {
            if (this.input.LA(1) == 73)
            {
              this.input.LA(2);
              // ISSUE: method pointer
              // ISSUE: method pointer
              // ISSUE: method pointer
              num = !this.EvaluatePredicate(synpred1_LeftRecursiveRuleWalker_fragment) ?
	              !this.EvaluatePredicate(synpred2_LeftRecursiveRuleWalker_fragment) ?
		              !this.EvaluatePredicate(synpred3_LeftRecursiveRuleWalker_fragment) ?
			              4 : 3 : 2 : 1;
            }
            else
            {
              if (this.state.backtracking <= 0)
                throw new NoViableAltException("", 9, 0, (IIntStream) this.input, 1);
              this.state.failed = true;
              return alternativeReturn;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._binary_in_outerAlternative373);
              this.binary();
              this.PopFollow();
              if (this.state.failed || this.state.backtracking != 0)
                return alternativeReturn;
              this.BinaryAlt((AltAST) alternativeReturn.Start, this.currentOuterAltNumber);
              alternativeReturn.isLeftRec = true;
              break;
            case 2:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._prefix_in_outerAlternative429);
              this.prefix();
              this.PopFollow();
              if (this.state.failed || this.state.backtracking != 0)
                return alternativeReturn;
              this.PrefixAlt((AltAST) alternativeReturn.Start, this.currentOuterAltNumber);
              break;
            case 3:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._suffix_in_outerAlternative485);
              this.suffix();
              this.PopFollow();
              if (this.state.failed || this.state.backtracking != 0)
                return alternativeReturn;
              this.SuffixAlt((AltAST) alternativeReturn.Start, this.currentOuterAltNumber);
              alternativeReturn.isLeftRec = true;
              break;
            case 4:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._nonLeftRecur_in_outerAlternative526);
              this.nonLeftRecur();
              this.PopFollow();
              if (this.state.failed || this.state.backtracking != 0)
                return alternativeReturn;
              this.OtherAlt((AltAST) alternativeReturn.Start, this.currentOuterAltNumber);
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
      return alternativeReturn;
    }

    [GrammarRule("binary")]
    private void binary()
    {
      try
      {
        try
        {
          GrammarAST altTree = (GrammarAST) this.Match((IIntStream) this.input, 73, LeftRecursiveRuleWalker.Follow._ALT_in_binary552);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 81)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_binary554);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return;
            }
          }
          finally
          {
          }
          this.PushFollow(LeftRecursiveRuleWalker.Follow._recurse_in_binary557);
          this.recurse();
          this.PopFollow();
          if (this.state.failed)
            return;
          try
          {
            do
            {
              int num2 = 2;
              try
              {
                num2 = this.dfa11.Predict((IIntStream) this.input);
              }
              catch (NoViableAltException ex)
              {
                throw;
              }
              finally
              {
              }
              if (num2 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_binary559);
                this.element();
                this.PopFollow();
              }
              else
                goto label_21;
            }
            while (!this.state.failed);
            return;
          }
          finally
          {
          }
label_21:
          this.PushFollow(LeftRecursiveRuleWalker.Follow._recurse_in_binary562);
          this.recurse();
          this.PopFollow();
          if (this.state.failed)
            return;
          try
          {
            do
            {
              int num3 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 4:
                  case 59:
                  case 82:
                    num3 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._epsilonElement_in_binary564);
                this.epsilonElement();
                this.PopFollow();
              }
              else
                goto label_33;
            }
            while (!this.state.failed);
            return;
          }
          finally
          {
          }
label_33:
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed || this.state.backtracking != 0)
            return;
          this.SetAltAssoc((AltAST) altTree, this.currentOuterAltNumber);
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("prefix")]
    private void prefix()
    {
      try
      {
        try
        {
          GrammarAST altTree = (GrammarAST) this.Match((IIntStream) this.input, 73, LeftRecursiveRuleWalker.Follow._ALT_in_prefix590);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 81)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_prefix592);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return;
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
                num3 = this.dfa14.Predict((IIntStream) this.input);
              }
              catch (NoViableAltException ex)
              {
                throw;
              }
              finally
              {
              }
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_prefix598);
                this.element();
                this.PopFollow();
                if (!this.state.failed)
                  ++num2;
                else
                  break;
              }
              else
                goto label_19;
            }
            return;
label_19:
            if (num2 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(14, (IIntStream) this.input);
              this.state.failed = true;
              return;
            }
          }
          finally
          {
          }
          this.PushFollow(LeftRecursiveRuleWalker.Follow._recurse_in_prefix604);
          this.recurse();
          this.PopFollow();
          if (this.state.failed)
            return;
          try
          {
            do
            {
              int num4 = 2;
              try
              {
                switch (this.input.LA(1))
                {
                  case 4:
                  case 59:
                  case 82:
                    num4 = 1;
                    break;
                }
              }
              finally
              {
              }
              if (num4 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._epsilonElement_in_prefix606);
                this.epsilonElement();
                this.PopFollow();
              }
              else
                goto label_38;
            }
            while (!this.state.failed);
            return;
          }
          finally
          {
          }
label_38:
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed || this.state.backtracking != 0)
            return;
          this.SetAltAssoc((AltAST) altTree, this.currentOuterAltNumber);
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("suffix")]
    private void suffix()
    {
      try
      {
        try
        {
          GrammarAST altTree = (GrammarAST) this.Match((IIntStream) this.input, 73, LeftRecursiveRuleWalker.Follow._ALT_in_suffix641);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 81)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_suffix643);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return;
            }
          }
          finally
          {
          }
          this.PushFollow(LeftRecursiveRuleWalker.Follow._recurse_in_suffix646);
          this.recurse();
          this.PopFollow();
          if (this.state.failed)
            return;
          int num2 = 0;
          try
          {
            while (true)
            {
              int num3 = 2;
              try
              {
                int num4 = this.input.LA(1);
                if (num4 != 4 && num4 != 10 && num4 != 20 && num4 != 39 && num4 != 46 && num4 != 52 && num4 != 57 && num4 != 59 && num4 != 62 && num4 != 66 && num4 != 77 && num4 != 79 && num4 != 82 && (num4 < 88 || num4 > 89) && num4 != 97)
                {
                  if (num4 != 99)
                    goto label_21;
                }
                num3 = 1;
              }
              finally
              {
              }
label_21:
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_suffix648);
                this.element();
                this.PopFollow();
                if (!this.state.failed)
                  ++num2;
                else
                  break;
              }
              else
                goto label_24;
            }
            return;
label_24:
            if (num2 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(17, (IIntStream) this.input);
              this.state.failed = true;
              return;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (this.state.failed || this.state.backtracking != 0)
            return;
          this.SetAltAssoc((AltAST) altTree, this.currentOuterAltNumber);
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("nonLeftRecur")]
    private void nonLeftRecur()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 73, LeftRecursiveRuleWalker.Follow._ALT_in_nonLeftRecur682);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 81)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_nonLeftRecur684);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return;
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
                int num4 = this.input.LA(1);
                if (num4 != 4 && num4 != 10 && num4 != 20 && num4 != 39 && num4 != 46 && num4 != 52 && num4 != 57 && num4 != 59 && num4 != 62 && num4 != 66 && num4 != 77 && num4 != 79 && num4 != 82 && (num4 < 88 || num4 > 89) && num4 != 97)
                {
                  if (num4 != 99)
                    goto label_17;
                }
                num3 = 1;
              }
              finally
              {
              }
label_17:
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_nonLeftRecur687);
                this.element();
                this.PopFollow();
                if (!this.state.failed)
                  ++num2;
                else
                  break;
              }
              else
                goto label_20;
            }
            return;
label_20:
            if (num2 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(19, (IIntStream) this.input);
              this.state.failed = true;
              return;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("recurse")]
    private void recurse()
    {
      try
      {
        try
        {
          int num = 3;
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
              case 57:
                num = 3;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 20, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_recurse704);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_recurse706);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse708);
              this.recurseNoLabel();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 46, LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_recurse715);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_recurse717);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse719);
              this.recurseNoLabel();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse725);
              this.recurseNoLabel();
              this.PopFollow();
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("recurseNoLabel")]
    private void recurseNoLabel()
    {
      try
      {
        try
        {
          if (!((BaseTree) this.input.LT(1)).Text.Equals(this.ruleName))
          {
            if (this.state.backtracking <= 0)
              throw new FailedPredicateException((IIntStream) this.input, nameof (recurseNoLabel), "((CommonTree)input.LT(1)).Text.Equals(ruleName)");
            this.state.failed = true;
          }
          else
          {
            this.Match((IIntStream) this.input, 57, LeftRecursiveRuleWalker.Follow._RULE_REF_in_recurseNoLabel737);
            if (!this.state.failed)
              ;
          }
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("token")]
    private GrammarAST token()
    {
      GrammarAST grammarAst1 = (GrammarAST) null;
      try
      {
        try
        {
          int num = 6;
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
              case 62:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 4;
                    break;
                  case 3:
                    num = 3;
                    break;
                  default:
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 21, 3, (IIntStream) this.input, 2);
                    this.state.failed = true;
                    return grammarAst1;
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 5;
                    break;
                  case 3:
                    num = 6;
                    break;
                  default:
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 21, 4, (IIntStream) this.input, 2);
                    this.state.failed = true;
                    return grammarAst1;
                }
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 21, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return grammarAst1;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_token751);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_token753);
              if (this.state.failed)
                return grammarAst1;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._token_in_token757);
              GrammarAST grammarAst2 = this.token();
              this.PopFollow();
              if (this.state.failed)
                return grammarAst1;
              if (this.state.backtracking == 0)
                grammarAst1 = grammarAst2;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              break;
            case 2:
              this.Match((IIntStream) this.input, 46, LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_token766);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_token768);
              if (this.state.failed)
                return grammarAst1;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._token_in_token772);
              GrammarAST grammarAst3 = this.token();
              this.PopFollow();
              if (this.state.failed)
                return grammarAst1;
              if (this.state.backtracking == 0)
                grammarAst1 = grammarAst3;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              break;
            case 3:
              GrammarAST grammarAst4 = (GrammarAST) this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_token782);
              if (this.state.failed || this.state.backtracking != 0)
                return grammarAst1;
              grammarAst1 = grammarAst4;
              break;
            case 4:
              GrammarAST grammarAst5 = (GrammarAST) this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_token803);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_token805);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed || this.state.backtracking != 0)
                return grammarAst1;
              grammarAst1 = grammarAst5;
              break;
            case 5:
              GrammarAST grammarAst6 = (GrammarAST) this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_token820);
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                return grammarAst1;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_token822);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return grammarAst1;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (this.state.failed || this.state.backtracking != 0)
                return grammarAst1;
              grammarAst1 = grammarAst6;
              break;
            case 6:
              GrammarAST grammarAst7 = (GrammarAST) this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_token834);
              if (this.state.failed || this.state.backtracking != 0)
                return grammarAst1;
              grammarAst1 = grammarAst7;
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
      return grammarAst1;
    }

    [GrammarRule("elementOptions")]
    private void elementOptions()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 81, LeftRecursiveRuleWalker.Follow._ELEMENT_OPTIONS_in_elementOptions864);
          if (this.state.failed || this.input.LA(1) != 2)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          try
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
                this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOption_in_elementOptions866);
                this.elementOption();
                this.PopFollow();
              }
              else
                goto label_12;
            }
            while (!this.state.failed);
            return;
          }
          finally
          {
          }
label_12:
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
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
                          throw new NoViableAltException("", 23, 4, (IIntStream) this.input, 4);
                        this.state.failed = true;
                        return;
                    }
                  }
                  else
                  {
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 23, 3, (IIntStream) this.input, 3);
                    this.state.failed = true;
                    return;
                  }
                }
                else
                {
                  if (this.state.backtracking <= 0)
                    throw new NoViableAltException("", 23, 2, (IIntStream) this.input, 2);
                  this.state.failed = true;
                  return;
                }
                break;
              case 28:
                num = 1;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 23, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption885);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption896);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption898);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption900);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption912);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption914);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_elementOption916);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption928);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption930);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_elementOption932);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 5:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption944);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_elementOption946);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 30, LeftRecursiveRuleWalker.Follow._INT_in_elementOption948);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("element")]
    private void element()
    {
      try
      {
        try
        {
          int num1 = 9;
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
                    if (num2 == 10)
                    {
                      num1 = 4;
                      goto label_49;
                    }
                    else
                      goto label_45;
                  }
                  else
                    goto label_44;
                }
                else if (num2 != 20)
                {
                  if (num2 == 39)
                  {
                    num1 = 2;
                    goto label_49;
                  }
                  else
                    goto label_45;
                }
              }
              else if (num2 <= 52)
              {
                if (num2 != 46)
                {
                  if (num2 == 52)
                  {
                    num1 = 3;
                    goto label_49;
                  }
                  else
                    goto label_45;
                }
                else
                {
                  num1 = 5;
                  goto label_49;
                }
              }
              else if (num2 != 57)
              {
                if (num2 == 59)
                  goto label_44;
                else
                  goto label_45;
              }
              else
              {
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 1;
                  goto label_49;
                }
                else if (num3 >= 3 && num3 <= 4 || num3 == 10 || num3 == 20 || num3 == 39 || num3 == 46 || num3 == 52 || num3 == 57 || num3 == 59 || num3 == 62 || num3 == 66 || num3 == 77 || num3 == 79 || num3 == 82 || num3 >= 88 && num3 <= 89 || num3 == 97 || num3 == 99)
                {
                  num1 = 7;
                  goto label_49;
                }
                else
                {
                  if (this.state.backtracking <= 0)
                    throw new NoViableAltException("", 25, 1, (IIntStream) this.input, 2);
                  this.state.failed = true;
                  return;
                }
              }
            }
            else
            {
              if (num2 <= 79)
              {
                if (num2 <= 66)
                {
                  if (num2 == 62 || num2 == 66)
                    goto label_37;
                  else
                    goto label_45;
                }
                else if (num2 != 77 && num2 != 79)
                  goto label_45;
              }
              else if (num2 <= 89)
              {
                if (num2 != 82)
                {
                  if ((uint) (num2 - 88) > 1U)
                    goto label_45;
                }
                else
                  goto label_44;
              }
              else if (num2 != 97)
              {
                if (num2 == 99)
                  goto label_37;
                else
                  goto label_45;
              }
              else
              {
                num1 = 6;
                goto label_49;
              }
              num1 = 8;
              goto label_49;
            }
label_37:
            num1 = 1;
            goto label_49;
label_44:
            num1 = 9;
            goto label_49;
label_45:
            if (this.state.backtracking <= 0)
              throw new NoViableAltException("", 25, 0, (IIntStream) this.input, 1);
            this.state.failed = true;
            return;
          }
          finally
          {
          }
label_49:
          switch (num1)
          {
            case 1:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._atom_in_element963);
              this.atom();
              this.PopFollow();
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 39, LeftRecursiveRuleWalker.Follow._NOT_in_element969);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_element971);
              this.element();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 52, LeftRecursiveRuleWalker.Follow._RANGE_in_element978);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._atom_in_element980);
              this.atom();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._atom_in_element982);
              this.atom();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 10, LeftRecursiveRuleWalker.Follow._ASSIGN_in_element989);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_element991);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_element993);
              this.element();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 5:
              this.Match((IIntStream) this.input, 46, LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_element1000);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_element1002);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_element1004);
              this.element();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 6:
              this.Match((IIntStream) this.input, 97, LeftRecursiveRuleWalker.Follow._SET_in_element1014);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
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
                      case 62:
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
                    this.PushFollow(LeftRecursiveRuleWalker.Follow._setElement_in_element1016);
                    this.setElement();
                    this.PopFollow();
                    if (!this.state.failed)
                      ++num4;
                    else
                      break;
                  }
                  else
                    goto label_102;
                }
                break;
label_102:
                if (num4 < 1)
                {
                  if (this.state.backtracking <= 0)
                    throw new EarlyExitException(24, (IIntStream) this.input);
                  this.state.failed = true;
                  break;
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 7:
              this.Match((IIntStream) this.input, 57, LeftRecursiveRuleWalker.Follow._RULE_REF_in_element1028);
              if (!this.state.failed)
                break;
              break;
            case 8:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._ebnf_in_element1033);
              this.ebnf();
              this.PopFollow();
              if (!this.state.failed)
                break;
              break;
            case 9:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._epsilonElement_in_element1038);
              this.epsilonElement();
              this.PopFollow();
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("epsilonElement")]
    private void epsilonElement()
    {
      try
      {
        try
        {
          int num1 = 5;
          try
          {
            switch (this.input.LA(1))
            {
              case 4:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 4;
                  break;
                }
                if (num2 >= 3 && num2 <= 4 || num2 == 10 || num2 == 20 || num2 == 39 || num2 == 46 || num2 == 52 || num2 == 57 || num2 == 59 || num2 == 62 || num2 == 66 || num2 == 77 || num2 == 79 || num2 == 82 || num2 >= 88 && num2 <= 89 || num2 == 97 || num2 == 99)
                {
                  num1 = 1;
                  break;
                }
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 26, 1, (IIntStream) this.input, 2);
                this.state.failed = true;
                return;
              case 59:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 5;
                  break;
                }
                if (num3 >= 3 && num3 <= 4 || num3 == 10 || num3 == 20 || num3 == 39 || num3 == 46 || num3 == 52 || num3 == 57 || num3 == 59 || num3 == 62 || num3 == 66 || num3 == 77 || num3 == 79 || num3 == 82 || num3 >= 88 && num3 <= 89 || num3 == 97 || num3 == 99)
                {
                  num1 = 2;
                  break;
                }
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 26, 2, (IIntStream) this.input, 2);
                this.state.failed = true;
                return;
              case 82:
                num1 = 3;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 26, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_epsilonElement1049);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 59, LeftRecursiveRuleWalker.Follow._SEMPRED_in_epsilonElement1054);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 82, LeftRecursiveRuleWalker.Follow._EPSILON_in_epsilonElement1059);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_epsilonElement1065);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_epsilonElement1067);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 5:
              this.Match((IIntStream) this.input, 59, LeftRecursiveRuleWalker.Follow._SEMPRED_in_epsilonElement1074);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_epsilonElement1076);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("setElement")]
    private void setElement()
    {
      try
      {
        try
        {
          int num = 4;
          try
          {
            switch (this.input.LA(1))
            {
              case 62:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 1;
                    break;
                  case 3:
                  case 62:
                  case 66:
                    num = 3;
                    break;
                  default:
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 27, 1, (IIntStream) this.input, 2);
                    this.state.failed = true;
                    return;
                }
                break;
              case 66:
                switch (this.input.LA(2))
                {
                  case 2:
                    num = 2;
                    break;
                  case 3:
                  case 62:
                  case 66:
                    num = 4;
                    break;
                  default:
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 27, 2, (IIntStream) this.input, 2);
                    this.state.failed = true;
                    return;
                }
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 27, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_setElement1089);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_setElement1091);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_setElement1098);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_setElement1100);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_setElement1106);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_setElement1111);
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("ebnf")]
    private void ebnf()
    {
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
                num = 1;
                break;
              case 79:
                num = 3;
                break;
              case 88:
                num = 2;
                break;
              case 89:
                num = 4;
                break;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 28, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.PushFollow(LeftRecursiveRuleWalker.Follow._block_in_ebnf1122);
              this.block();
              this.PopFollow();
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 88, LeftRecursiveRuleWalker.Follow._OPTIONAL_in_ebnf1134);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._block_in_ebnf1136);
              this.block();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 79, LeftRecursiveRuleWalker.Follow._CLOSURE_in_ebnf1150);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._block_in_ebnf1152);
              this.block();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 89, LeftRecursiveRuleWalker.Follow._POSITIVE_CLOSURE_in_ebnf1166);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._block_in_ebnf1168);
              this.block();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
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
    }

    [GrammarRule("block")]
    private void block()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 77, LeftRecursiveRuleWalker.Follow._BLOCK_in_block1188);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 4)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.Match((IIntStream) this.input, 4, LeftRecursiveRuleWalker.Follow._ACTION_in_block1190);
              if (this.state.failed)
                return;
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
                if (this.input.LA(1) == 73)
                  num3 = 1;
              }
              finally
              {
              }
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._alternative_in_block1193);
                this.alternative();
                this.PopFollow();
                if (!this.state.failed)
                  ++num2;
                else
                  break;
              }
              else
                goto label_19;
            }
            return;
label_19:
            if (num2 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(30, (IIntStream) this.input);
              this.state.failed = true;
              return;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("alternative")]
    private void alternative()
    {
      try
      {
        try
        {
          this.Match((IIntStream) this.input, 73, LeftRecursiveRuleWalker.Follow._ALT_in_alternative1210);
          if (this.state.failed)
            return;
          this.Match((IIntStream) this.input, 2, (BitSet) null);
          if (this.state.failed)
            return;
          int num1 = 2;
          try
          {
            try
            {
              if (this.input.LA(1) == 81)
                num1 = 1;
            }
            finally
            {
            }
            if (num1 == 1)
            {
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_alternative1212);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                return;
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
                int num4 = this.input.LA(1);
                if (num4 != 4 && num4 != 10 && num4 != 20 && num4 != 39 && num4 != 46 && num4 != 52 && num4 != 57 && num4 != 59 && num4 != 62 && num4 != 66 && num4 != 77 && num4 != 79 && num4 != 82 && (num4 < 88 || num4 > 89) && num4 != 97)
                {
                  if (num4 != 99)
                    goto label_17;
                }
                num3 = 1;
              }
              finally
              {
              }
label_17:
              if (num3 == 1)
              {
                this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_alternative1215);
                this.element();
                this.PopFollow();
                if (!this.state.failed)
                  ++num2;
                else
                  break;
              }
              else
                goto label_20;
            }
            return;
label_20:
            if (num2 < 1)
            {
              if (this.state.backtracking <= 0)
                throw new EarlyExitException(32, (IIntStream) this.input);
              this.state.failed = true;
              return;
            }
          }
          finally
          {
          }
          this.Match((IIntStream) this.input, 3, (BitSet) null);
          if (!this.state.failed)
            ;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    [GrammarRule("atom")]
    private void atom()
    {
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
                num1 = 8;
                break;
              case 57:
                num1 = 1;
                break;
              case 62:
                int num2 = this.input.LA(2);
                if (num2 == 2)
                {
                  num1 = 2;
                  break;
                }
                if (num2 >= 3 && num2 <= 4 || num2 == 10 || num2 == 20 || num2 == 39 || num2 == 46 || num2 == 52 || num2 == 57 || num2 == 59 || num2 == 62 || num2 == 66 || num2 == 77 || num2 == 79 || num2 == 82 || num2 >= 88 && num2 <= 89 || num2 == 97 || num2 == 99)
                {
                  num1 = 3;
                  break;
                }
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 35, 2, (IIntStream) this.input, 2);
                this.state.failed = true;
                return;
              case 66:
                int num3 = this.input.LA(2);
                if (num3 == 2)
                {
                  num1 = 4;
                  break;
                }
                if (num3 >= 3 && num3 <= 4 || num3 == 10 || num3 == 20 || num3 == 39 || num3 == 46 || num3 == 52 || num3 == 57 || num3 == 59 || num3 == 62 || num3 == 66 || num3 == 77 || num3 == 79 || num3 == 82 || num3 >= 88 && num3 <= 89 || num3 == 97 || num3 == 99)
                {
                  num1 = 5;
                  break;
                }
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 35, 3, (IIntStream) this.input, 2);
                this.state.failed = true;
                return;
              case 99:
                int num4 = this.input.LA(2);
                if (num4 == 2)
                {
                  num1 = 6;
                  break;
                }
                if (num4 >= 3 && num4 <= 4 || num4 == 10 || num4 == 20 || num4 == 39 || num4 == 46 || num4 == 52 || num4 == 57 || num4 == 59 || num4 == 62 || num4 == 66 || num4 == 77 || num4 == 79 || num4 == 82 || num4 >= 88 && num4 <= 89 || num4 == 97 || num4 == 99)
                {
                  num1 = 7;
                  break;
                }
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 35, 4, (IIntStream) this.input, 2);
                this.state.failed = true;
                return;
              default:
                if (this.state.backtracking <= 0)
                  throw new NoViableAltException("", 35, 0, (IIntStream) this.input, 1);
                this.state.failed = true;
                return;
            }
          }
          finally
          {
          }
          switch (num1)
          {
            case 1:
              this.Match((IIntStream) this.input, 57, LeftRecursiveRuleWalker.Follow._RULE_REF_in_atom1232);
              if (this.state.failed || this.input.LA(1) != 2)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              int num5 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 8)
                    num5 = 1;
                }
                finally
                {
                }
                if (num5 == 1)
                {
                  this.Match((IIntStream) this.input, 8, LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_atom1234);
                  if (this.state.failed)
                    break;
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
                  if (this.input.LA(1) == 81)
                    num6 = 1;
                }
                finally
                {
                }
                if (num6 == 1)
                {
                  this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1237);
                  this.elementOptions();
                  this.PopFollow();
                  if (this.state.failed)
                    break;
                }
              }
              finally
              {
              }
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_atom1249);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1251);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match((IIntStream) this.input, 62, LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_atom1257);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_atom1266);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1268);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 5:
              this.Match((IIntStream) this.input, 66, LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_atom1274);
              if (!this.state.failed)
                break;
              break;
            case 6:
              this.Match((IIntStream) this.input, 99, LeftRecursiveRuleWalker.Follow._WILDCARD_in_atom1283);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1285);
              this.elementOptions();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
              break;
            case 7:
              this.Match((IIntStream) this.input, 99, LeftRecursiveRuleWalker.Follow._WILDCARD_in_atom1291);
              if (!this.state.failed)
                break;
              break;
            case 8:
              this.Match((IIntStream) this.input, 20, LeftRecursiveRuleWalker.Follow._DOT_in_atom1297);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 2, (BitSet) null);
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 28, LeftRecursiveRuleWalker.Follow._ID_in_atom1299);
              if (this.state.failed)
                break;
              this.PushFollow(LeftRecursiveRuleWalker.Follow._element_in_atom1301);
              this.element();
              this.PopFollow();
              if (this.state.failed)
                break;
              this.Match((IIntStream) this.input, 3, (BitSet) null);
              if (!this.state.failed)
                break;
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
    }

    private void synpred1_LeftRecursiveRuleWalker_fragment()
    {
      try
      {
        this.PushFollow(LeftRecursiveRuleWalker.Follow._binary_in_synpred1_LeftRecursiveRuleWalker359);
        this.binary();
        this.PopFollow();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred2_LeftRecursiveRuleWalker_fragment()
    {
      try
      {
        this.PushFollow(LeftRecursiveRuleWalker.Follow._prefix_in_synpred2_LeftRecursiveRuleWalker415);
        this.prefix();
        this.PopFollow();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred3_LeftRecursiveRuleWalker_fragment()
    {
      try
      {
        this.PushFollow(LeftRecursiveRuleWalker.Follow._suffix_in_synpred3_LeftRecursiveRuleWalker471);
        this.suffix();
        this.PopFollow();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private bool EvaluatePredicate(Action fragment)
    {
      bool predicate = false;
      ++this.state.backtracking;
      try
      {
        int marker = this.input.Mark();
        try
        {
          fragment();
        }
        catch (RecognitionException ex)
        {
          Console.Error.WriteLine("impossible: " + (object) ex);
        }
        predicate = !this.state.failed;
        this.input.Rewind(marker);
      }
      finally
      {
      }
      --this.state.backtracking;
      this.state.failed = false;
      return predicate;
    }

    protected override void InitDFAs()
    {
      base.InitDFAs();
      this.dfa11 = new LeftRecursiveRuleWalker.DFA11((BaseRecognizer) this);
      this.dfa14 = new LeftRecursiveRuleWalker.DFA14((BaseRecognizer) this);
    }

    static LeftRecursiveRuleWalker()
    {
      LeftRecursiveRuleWalker.tokenNames = new string[100]
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

    private sealed class ruleBlock_return : TreeRuleReturnScope<GrammarAST>
    {
      public bool isLeftRec;

      public ruleBlock_return(LeftRecursiveRuleWalker grammar): base()
      {
        
      }
    }

    private sealed class outerAlternative_return : TreeRuleReturnScope<GrammarAST>
    {
      public bool isLeftRec;

      public outerAlternative_return(LeftRecursiveRuleWalker grammar) : base()
      {
        
      }
    }

    private class DFA11 : DFA
    {
      private const string DFA11_eotS = "X\uFFFF";
      private const string DFA11_eofS = "X\uFFFF";
      private const string DFA11_minS = "\u0001\u0004\u0003\u0002\u0001\uFFFF\u0002\u001C\u0002\u0002\u0001\u0003\u0001\uFFFF\u0002\u0004\u0002Q\u0004\u0002\u0004\u0003\u0002\u0002\u0002\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0002\u0002\u0004\v\u0003\u0001\u0002\u0002\u0003\u0001\u0002\t\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0004\u0010\u0003";
      private const string DFA11_maxS = "\u0001c\u0002\u0002\u0001c\u0001\uFFFF\u0002\u001C\u0003c\u0001\uFFFF\u0002c\u0002Q\u0002\u0003\u0002\u0002\u0002c\u0002\u001C\u0003c\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001c\u0001\u001C\u0001c\u0002\u0002\u0002>\u0002\u001C\b\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\t\u001C\u0001c\u0001\u001C\u0001c\u0002>\b\u0003\b\u001C";
      private const string DFA11_acceptS = "\u0004\uFFFF\u0001\u0001\u0005\uFFFF\u0001\u0002M\uFFFF";
      private const string DFA11_specialS = "X\uFFFF}>";
      private static readonly string[] DFA11_transitionS;
      private static readonly short[] DFA11_eot;
      private static readonly short[] DFA11_eof;
      private static readonly char[] DFA11_min;
      private static readonly char[] DFA11_max;
      private static readonly short[] DFA11_accept;
      private static readonly short[] DFA11_special;
      private static readonly short[][] DFA11_transition;

      static DFA11()
      {
        LeftRecursiveRuleWalker.DFA11.DFA11_transitionS = new string[88]
        {
          "\u0001\u0004\u0005\uFFFF\u0001\u0001\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0002\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0003\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0005",
          "\u0001\u0006",
          "\u0001\u0004\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "",
          "\u0001\v",
          "\u0001\f",
          "\u0001\r\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u000E\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u000F\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0010\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0011",
          "\u0001\u0012",
          "\u0001\u0004\u0001\u0013",
          "\u0001\u0004\u0001\u0014",
          "\u0001\u0015",
          "\u0001\u0016",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001 \u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001!\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\"",
          "\u0001#",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001$",
          "\u0001%",
          "\u0001&",
          "\u0001'",
          "\u0001(",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001)",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001*",
          "\u0001+",
          "\u0001.\u0017\uFFFF\u0001,\u0001\uFFFF\u0001/\u001F\uFFFF\u0001-",
          "\u00012\u0017\uFFFF\u00010\u0001\uFFFF\u00013\u001F\uFFFF\u00011",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u0001:",
          "\u0001;",
          "\u0001<",
          "\u0001=",
          "\u0001>",
          "\u0001?",
          "\u0001@",
          "\u0001A",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u0001B",
          "\u0001C",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u0001D",
          "\u0001E",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001F",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001G",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001J\u0017\uFFFF\u0001H\u0001\uFFFF\u0001K\u001F\uFFFF\u0001I",
          "\u0001N\u0017\uFFFF\u0001L\u0001\uFFFF\u0001O\u001F\uFFFF\u0001M",
          "\u0001P",
          "\u0001Q",
          "\u0001R",
          "\u0001S",
          "\u0001T",
          "\u0001U",
          "\u0001V",
          "\u0001W",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017"
        };
        LeftRecursiveRuleWalker.DFA11.DFA11_eot = DFA.UnpackEncodedString("X\uFFFF");
        LeftRecursiveRuleWalker.DFA11.DFA11_eof = DFA.UnpackEncodedString("X\uFFFF");
        LeftRecursiveRuleWalker.DFA11.DFA11_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\u0004\u0003\u0002\u0001\uFFFF\u0002\u001C\u0002\u0002\u0001\u0003\u0001\uFFFF\u0002\u0004\u0002Q\u0004\u0002\u0004\u0003\u0002\u0002\u0002\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0002\u0002\u0004\v\u0003\u0001\u0002\u0002\u0003\u0001\u0002\t\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0004\u0010\u0003");
        LeftRecursiveRuleWalker.DFA11.DFA11_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001c\u0002\u0002\u0001c\u0001\uFFFF\u0002\u001C\u0003c\u0001\uFFFF\u0002c\u0002Q\u0002\u0003\u0002\u0002\u0002c\u0002\u001C\u0003c\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001c\u0001\u001C\u0001c\u0002\u0002\u0002>\u0002\u001C\b\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\t\u001C\u0001c\u0001\u001C\u0001c\u0002>\b\u0003\b\u001C");
        LeftRecursiveRuleWalker.DFA11.DFA11_accept = DFA.UnpackEncodedString("\u0004\uFFFF\u0001\u0001\u0005\uFFFF\u0001\u0002M\uFFFF");
        LeftRecursiveRuleWalker.DFA11.DFA11_special = DFA.UnpackEncodedString("X\uFFFF}>");
        int length = LeftRecursiveRuleWalker.DFA11.DFA11_transitionS.Length;
        LeftRecursiveRuleWalker.DFA11.DFA11_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          LeftRecursiveRuleWalker.DFA11.DFA11_transition[index] = DFA.UnpackEncodedString(LeftRecursiveRuleWalker.DFA11.DFA11_transitionS[index]);
      }

      public DFA11(BaseRecognizer recognizer) : base()
      {
        
        this.recognizer = recognizer;
        this.decisionNumber = 11;
        this.eot = LeftRecursiveRuleWalker.DFA11.DFA11_eot;
        this.eof = LeftRecursiveRuleWalker.DFA11.DFA11_eof;
        this.min = LeftRecursiveRuleWalker.DFA11.DFA11_min;
        this.max = LeftRecursiveRuleWalker.DFA11.DFA11_max;
        this.accept = LeftRecursiveRuleWalker.DFA11.DFA11_accept;
        this.special = LeftRecursiveRuleWalker.DFA11.DFA11_special;
        this.transition = LeftRecursiveRuleWalker.DFA11.DFA11_transition;
      }

      public override string Description
      {
        get
        {
          return "()* loopback of 98:35: ( element )*";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private class DFA14 : DFA
    {
      private const string DFA14_eotS = "X\uFFFF";
      private const string DFA14_eofS = "X\uFFFF";
      private const string DFA14_minS = "\u0001\u0004\u0003\u0002\u0001\uFFFF\u0002\u001C\u0002\u0002\u0001\u0003\u0001\uFFFF\u0002\u0004\u0002Q\u0004\u0002\u0004\u0003\u0002\u0002\u0002\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0002\u0002\u0004\v\u0003\u0001\u0002\u0002\u0003\u0001\u0002\t\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0004\u0010\u0003";
      private const string DFA14_maxS = "\u0001c\u0002\u0002\u0001c\u0001\uFFFF\u0002\u001C\u0003c\u0001\uFFFF\u0002c\u0002Q\u0002\u0003\u0002\u0002\u0002c\u0002\u001C\u0003c\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001c\u0001\u001C\u0001c\u0002\u0002\u0002>\u0002\u001C\b\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\t\u001C\u0001c\u0001\u001C\u0001c\u0002>\b\u0003\b\u001C";
      private const string DFA14_acceptS = "\u0004\uFFFF\u0001\u0001\u0005\uFFFF\u0001\u0002M\uFFFF";
      private const string DFA14_specialS = "X\uFFFF}>";
      private static readonly string[] DFA14_transitionS;
      private static readonly short[] DFA14_eot;
      private static readonly short[] DFA14_eof;
      private static readonly char[] DFA14_min;
      private static readonly char[] DFA14_max;
      private static readonly short[] DFA14_accept;
      private static readonly short[] DFA14_special;
      private static readonly short[][] DFA14_transition;

      static DFA14()
      {
        LeftRecursiveRuleWalker.DFA14.DFA14_transitionS = new string[88]
        {
          "\u0001\u0004\u0005\uFFFF\u0001\u0001\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0002\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0003\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0005",
          "\u0001\u0006",
          "\u0001\u0004\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "",
          "\u0001\v",
          "\u0001\f",
          "\u0001\r\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u000E\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u000F\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0004\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0010\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0004\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u0011",
          "\u0001\u0012",
          "\u0001\u0004\u0001\u0013",
          "\u0001\u0004\u0001\u0014",
          "\u0001\u0015",
          "\u0001\u0016",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001 \u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001!\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\"",
          "\u0001#",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001$",
          "\u0001%",
          "\u0001&",
          "\u0001'",
          "\u0001(",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001)",
          "\u0001\n\u0001\a\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\b\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\t\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001*",
          "\u0001+",
          "\u0001.\u0017\uFFFF\u0001,\u0001\uFFFF\u0001/\u001F\uFFFF\u0001-",
          "\u00012\u0017\uFFFF\u00010\u0001\uFFFF\u00013\u001F\uFFFF\u00011",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u0001:",
          "\u0001;",
          "\u0001<",
          "\u0001=",
          "\u0001>",
          "\u0001?",
          "\u0001@",
          "\u0001A",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u0001B",
          "\u0001C",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u0001D",
          "\u0001E",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001C\u0006\uFFFF\u0001\u001B\u0011\uFFFF\u0001\u001A",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001\u001F\u0006\uFFFF\u0001\u001E\u0011\uFFFF\u0001\u001D",
          "\u0001F",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001G",
          "\u0001\n\u0001\u0017\u0005\uFFFF\u0001\u0004\t\uFFFF\u0001\u0004\u0012\uFFFF\u0001\u0004\u0006\uFFFF\u0001\u0004\u0005\uFFFF\u0001\u0004\u0004\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0018\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0004\n\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004\u0002\uFFFF\u0001\u0019\u0005\uFFFF\u0002\u0004\a\uFFFF\u0001\u0004\u0001\uFFFF\u0001\u0004",
          "\u0001J\u0017\uFFFF\u0001H\u0001\uFFFF\u0001K\u001F\uFFFF\u0001I",
          "\u0001N\u0017\uFFFF\u0001L\u0001\uFFFF\u0001O\u001F\uFFFF\u0001M",
          "\u0001P",
          "\u0001Q",
          "\u0001R",
          "\u0001S",
          "\u0001T",
          "\u0001U",
          "\u0001V",
          "\u0001W",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00016\u0006\uFFFF\u00015\u0011\uFFFF\u00014",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017",
          "\u00019\u0006\uFFFF\u00018\u0011\uFFFF\u00017"
        };
        LeftRecursiveRuleWalker.DFA14.DFA14_eot = DFA.UnpackEncodedString("X\uFFFF");
        LeftRecursiveRuleWalker.DFA14.DFA14_eof = DFA.UnpackEncodedString("X\uFFFF");
        LeftRecursiveRuleWalker.DFA14.DFA14_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\u0004\u0003\u0002\u0001\uFFFF\u0002\u001C\u0002\u0002\u0001\u0003\u0001\uFFFF\u0002\u0004\u0002Q\u0004\u0002\u0004\u0003\u0002\u0002\u0002\u0003\u0001\u0002\u0002\u0003\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0002\u0002\u0004\v\u0003\u0001\u0002\u0002\u0003\u0001\u0002\t\u0003\u0001\u001C\u0001\u0003\u0001\u001C\u0001\u0003\u0002\u0004\u0010\u0003");
        LeftRecursiveRuleWalker.DFA14.DFA14_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001c\u0002\u0002\u0001c\u0001\uFFFF\u0002\u001C\u0003c\u0001\uFFFF\u0002c\u0002Q\u0002\u0003\u0002\u0002\u0002c\u0002\u001C\u0003c\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0002Q\u0001\u001C\u0001c\u0001\u001C\u0001c\u0002\u0002\u0002>\u0002\u001C\b\u0003\u0001\u001C\u0001\u0002\u0001\u0003\u0001\u001C\u0001\u0002\u0001\u0003\t\u001C\u0001c\u0001\u001C\u0001c\u0002>\b\u0003\b\u001C");
        LeftRecursiveRuleWalker.DFA14.DFA14_accept = DFA.UnpackEncodedString("\u0004\uFFFF\u0001\u0001\u0005\uFFFF\u0001\u0002M\uFFFF");
        LeftRecursiveRuleWalker.DFA14.DFA14_special = DFA.UnpackEncodedString("X\uFFFF}>");
        int length = LeftRecursiveRuleWalker.DFA14.DFA14_transitionS.Length;
        LeftRecursiveRuleWalker.DFA14.DFA14_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          LeftRecursiveRuleWalker.DFA14.DFA14_transition[index] = DFA.UnpackEncodedString(LeftRecursiveRuleWalker.DFA14.DFA14_transitionS[index]);
      }

      public DFA14(BaseRecognizer recognizer):base()
      {
        
        this.recognizer = recognizer;
        this.decisionNumber = 14;
        this.eot = LeftRecursiveRuleWalker.DFA14.DFA14_eot;
        this.eof = LeftRecursiveRuleWalker.DFA14.DFA14_eof;
        this.min = LeftRecursiveRuleWalker.DFA14.DFA14_min;
        this.max = LeftRecursiveRuleWalker.DFA14.DFA14_max;
        this.accept = LeftRecursiveRuleWalker.DFA14.DFA14_accept;
        this.special = LeftRecursiveRuleWalker.DFA14.DFA14_special;
        this.transition = LeftRecursiveRuleWalker.DFA14.DFA14_transition;
      }

      public override string Description
      {
        get
        {
          return "()+ loopback of 104:4: ( element )+";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private static class Follow
    {
      public static readonly BitSet _RULE_in_rec_rule83;
      public static readonly BitSet _RULE_REF_in_rec_rule87;
      public static readonly BitSet _ruleModifier_in_rec_rule94;
      public static readonly BitSet _RETURNS_in_rec_rule103;
      public static readonly BitSet _ARG_ACTION_in_rec_rule107;
      public static readonly BitSet _LOCALS_in_rec_rule126;
      public static readonly BitSet _ARG_ACTION_in_rec_rule128;
      public static readonly BitSet _OPTIONS_in_rec_rule146;
      public static readonly BitSet _AT_in_rec_rule163;
      public static readonly BitSet _ID_in_rec_rule165;
      public static readonly BitSet _ACTION_in_rec_rule167;
      public static readonly BitSet _ruleBlock_in_rec_rule183;
      public static readonly BitSet _exceptionGroup_in_rec_rule190;
      public static readonly BitSet _exceptionHandler_in_exceptionGroup208;
      public static readonly BitSet _finallyClause_in_exceptionGroup211;
      public static readonly BitSet _CATCH_in_exceptionHandler227;
      public static readonly BitSet _ARG_ACTION_in_exceptionHandler229;
      public static readonly BitSet _ACTION_in_exceptionHandler231;
      public static readonly BitSet _FINALLY_in_finallyClause244;
      public static readonly BitSet _ACTION_in_finallyClause246;
      public static readonly BitSet _BLOCK_in_ruleBlock301;
      public static readonly BitSet _outerAlternative_in_ruleBlock314;
      public static readonly BitSet _binary_in_outerAlternative373;
      public static readonly BitSet _prefix_in_outerAlternative429;
      public static readonly BitSet _suffix_in_outerAlternative485;
      public static readonly BitSet _nonLeftRecur_in_outerAlternative526;
      public static readonly BitSet _ALT_in_binary552;
      public static readonly BitSet _elementOptions_in_binary554;
      public static readonly BitSet _recurse_in_binary557;
      public static readonly BitSet _element_in_binary559;
      public static readonly BitSet _recurse_in_binary562;
      public static readonly BitSet _epsilonElement_in_binary564;
      public static readonly BitSet _ALT_in_prefix590;
      public static readonly BitSet _elementOptions_in_prefix592;
      public static readonly BitSet _element_in_prefix598;
      public static readonly BitSet _recurse_in_prefix604;
      public static readonly BitSet _epsilonElement_in_prefix606;
      public static readonly BitSet _ALT_in_suffix641;
      public static readonly BitSet _elementOptions_in_suffix643;
      public static readonly BitSet _recurse_in_suffix646;
      public static readonly BitSet _element_in_suffix648;
      public static readonly BitSet _ALT_in_nonLeftRecur682;
      public static readonly BitSet _elementOptions_in_nonLeftRecur684;
      public static readonly BitSet _element_in_nonLeftRecur687;
      public static readonly BitSet _ASSIGN_in_recurse704;
      public static readonly BitSet _ID_in_recurse706;
      public static readonly BitSet _recurseNoLabel_in_recurse708;
      public static readonly BitSet _PLUS_ASSIGN_in_recurse715;
      public static readonly BitSet _ID_in_recurse717;
      public static readonly BitSet _recurseNoLabel_in_recurse719;
      public static readonly BitSet _recurseNoLabel_in_recurse725;
      public static readonly BitSet _RULE_REF_in_recurseNoLabel737;
      public static readonly BitSet _ASSIGN_in_token751;
      public static readonly BitSet _ID_in_token753;
      public static readonly BitSet _token_in_token757;
      public static readonly BitSet _PLUS_ASSIGN_in_token766;
      public static readonly BitSet _ID_in_token768;
      public static readonly BitSet _token_in_token772;
      public static readonly BitSet _STRING_LITERAL_in_token782;
      public static readonly BitSet _STRING_LITERAL_in_token803;
      public static readonly BitSet _elementOptions_in_token805;
      public static readonly BitSet _TOKEN_REF_in_token820;
      public static readonly BitSet _elementOptions_in_token822;
      public static readonly BitSet _TOKEN_REF_in_token834;
      public static readonly BitSet _ELEMENT_OPTIONS_in_elementOptions864;
      public static readonly BitSet _elementOption_in_elementOptions866;
      public static readonly BitSet _ID_in_elementOption885;
      public static readonly BitSet _ASSIGN_in_elementOption896;
      public static readonly BitSet _ID_in_elementOption898;
      public static readonly BitSet _ID_in_elementOption900;
      public static readonly BitSet _ASSIGN_in_elementOption912;
      public static readonly BitSet _ID_in_elementOption914;
      public static readonly BitSet _STRING_LITERAL_in_elementOption916;
      public static readonly BitSet _ASSIGN_in_elementOption928;
      public static readonly BitSet _ID_in_elementOption930;
      public static readonly BitSet _ACTION_in_elementOption932;
      public static readonly BitSet _ASSIGN_in_elementOption944;
      public static readonly BitSet _ID_in_elementOption946;
      public static readonly BitSet _INT_in_elementOption948;
      public static readonly BitSet _atom_in_element963;
      public static readonly BitSet _NOT_in_element969;
      public static readonly BitSet _element_in_element971;
      public static readonly BitSet _RANGE_in_element978;
      public static readonly BitSet _atom_in_element980;
      public static readonly BitSet _atom_in_element982;
      public static readonly BitSet _ASSIGN_in_element989;
      public static readonly BitSet _ID_in_element991;
      public static readonly BitSet _element_in_element993;
      public static readonly BitSet _PLUS_ASSIGN_in_element1000;
      public static readonly BitSet _ID_in_element1002;
      public static readonly BitSet _element_in_element1004;
      public static readonly BitSet _SET_in_element1014;
      public static readonly BitSet _setElement_in_element1016;
      public static readonly BitSet _RULE_REF_in_element1028;
      public static readonly BitSet _ebnf_in_element1033;
      public static readonly BitSet _epsilonElement_in_element1038;
      public static readonly BitSet _ACTION_in_epsilonElement1049;
      public static readonly BitSet _SEMPRED_in_epsilonElement1054;
      public static readonly BitSet _EPSILON_in_epsilonElement1059;
      public static readonly BitSet _ACTION_in_epsilonElement1065;
      public static readonly BitSet _elementOptions_in_epsilonElement1067;
      public static readonly BitSet _SEMPRED_in_epsilonElement1074;
      public static readonly BitSet _elementOptions_in_epsilonElement1076;
      public static readonly BitSet _STRING_LITERAL_in_setElement1089;
      public static readonly BitSet _elementOptions_in_setElement1091;
      public static readonly BitSet _TOKEN_REF_in_setElement1098;
      public static readonly BitSet _elementOptions_in_setElement1100;
      public static readonly BitSet _STRING_LITERAL_in_setElement1106;
      public static readonly BitSet _TOKEN_REF_in_setElement1111;
      public static readonly BitSet _block_in_ebnf1122;
      public static readonly BitSet _OPTIONAL_in_ebnf1134;
      public static readonly BitSet _block_in_ebnf1136;
      public static readonly BitSet _CLOSURE_in_ebnf1150;
      public static readonly BitSet _block_in_ebnf1152;
      public static readonly BitSet _POSITIVE_CLOSURE_in_ebnf1166;
      public static readonly BitSet _block_in_ebnf1168;
      public static readonly BitSet _BLOCK_in_block1188;
      public static readonly BitSet _ACTION_in_block1190;
      public static readonly BitSet _alternative_in_block1193;
      public static readonly BitSet _ALT_in_alternative1210;
      public static readonly BitSet _elementOptions_in_alternative1212;
      public static readonly BitSet _element_in_alternative1215;
      public static readonly BitSet _RULE_REF_in_atom1232;
      public static readonly BitSet _ARG_ACTION_in_atom1234;
      public static readonly BitSet _elementOptions_in_atom1237;
      public static readonly BitSet _STRING_LITERAL_in_atom1249;
      public static readonly BitSet _elementOptions_in_atom1251;
      public static readonly BitSet _STRING_LITERAL_in_atom1257;
      public static readonly BitSet _TOKEN_REF_in_atom1266;
      public static readonly BitSet _elementOptions_in_atom1268;
      public static readonly BitSet _TOKEN_REF_in_atom1274;
      public static readonly BitSet _WILDCARD_in_atom1283;
      public static readonly BitSet _elementOptions_in_atom1285;
      public static readonly BitSet _WILDCARD_in_atom1291;
      public static readonly BitSet _DOT_in_atom1297;
      public static readonly BitSet _ID_in_atom1299;
      public static readonly BitSet _element_in_atom1301;
      public static readonly BitSet _binary_in_synpred1_LeftRecursiveRuleWalker359;
      public static readonly BitSet _prefix_in_synpred2_LeftRecursiveRuleWalker415;
      public static readonly BitSet _suffix_in_synpred3_LeftRecursiveRuleWalker471;

      static Follow()
      {
        LeftRecursiveRuleWalker.Follow._RULE_in_rec_rule83 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._RULE_REF_in_rec_rule87 = new BitSet(new ulong[2]
        {
          38003528492386304UL,
          8192UL
        });
        LeftRecursiveRuleWalker.Follow._ruleModifier_in_rec_rule94 = new BitSet(new ulong[2]
        {
          36033203655411712UL,
          8192UL
        });
        LeftRecursiveRuleWalker.Follow._RETURNS_in_rec_rule103 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_rec_rule107 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._LOCALS_in_rec_rule126 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_rec_rule128 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._OPTIONS_in_rec_rule146 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._AT_in_rec_rule163 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_rec_rule165 = new BitSet(new ulong[1]
        {
          16UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_rec_rule167 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._ruleBlock_in_rec_rule183 = new BitSet(new ulong[1]
        {
          8392712UL
        });
        LeftRecursiveRuleWalker.Follow._exceptionGroup_in_rec_rule190 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._exceptionHandler_in_exceptionGroup208 = new BitSet(new ulong[1]
        {
          8392706UL
        });
        LeftRecursiveRuleWalker.Follow._finallyClause_in_exceptionGroup211 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._CATCH_in_exceptionHandler227 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_exceptionHandler229 = new BitSet(new ulong[1]
        {
          16UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_exceptionHandler231 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._FINALLY_in_finallyClause244 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_finallyClause246 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._BLOCK_in_ruleBlock301 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._outerAlternative_in_ruleBlock314 = new BitSet(new ulong[2]
        {
          8UL,
          512UL
        });
        LeftRecursiveRuleWalker.Follow._binary_in_outerAlternative373 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._prefix_in_outerAlternative429 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._suffix_in_outerAlternative485 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._nonLeftRecur_in_outerAlternative526 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ALT_in_binary552 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_binary554 = new BitSet(new ulong[1]
        {
          144185556820034560UL
        });
        LeftRecursiveRuleWalker.Follow._recurse_in_binary557 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_binary559 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._recurse_in_binary562 = new BitSet(new ulong[2]
        {
          576460752303423512UL,
          262144UL
        });
        LeftRecursiveRuleWalker.Follow._epsilonElement_in_binary564 = new BitSet(new ulong[2]
        {
          576460752303423512UL,
          262144UL
        });
        LeftRecursiveRuleWalker.Follow._ALT_in_prefix590 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_prefix592 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_prefix598 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._recurse_in_prefix604 = new BitSet(new ulong[2]
        {
          576460752303423512UL,
          262144UL
        });
        LeftRecursiveRuleWalker.Follow._epsilonElement_in_prefix606 = new BitSet(new ulong[2]
        {
          576460752303423512UL,
          262144UL
        });
        LeftRecursiveRuleWalker.Follow._ALT_in_suffix641 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_suffix643 = new BitSet(new ulong[1]
        {
          144185556820034560UL
        });
        LeftRecursiveRuleWalker.Follow._recurse_in_suffix646 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_suffix648 = new BitSet(new ulong[2]
        {
          5336836476935078936UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._ALT_in_nonLeftRecur682 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_nonLeftRecur684 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_nonLeftRecur687 = new BitSet(new ulong[2]
        {
          5336836476935078936UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_recurse704 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_recurse706 = new BitSet(new ulong[1]
        {
          144115188075855872UL
        });
        LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse708 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_recurse715 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_recurse717 = new BitSet(new ulong[1]
        {
          144115188075855872UL
        });
        LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse719 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._recurseNoLabel_in_recurse725 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._RULE_REF_in_recurseNoLabel737 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_token751 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_token753 = new BitSet(new ulong[2]
        {
          4611756387171566592UL,
          4UL
        });
        LeftRecursiveRuleWalker.Follow._token_in_token757 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_token766 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_token768 = new BitSet(new ulong[2]
        {
          4611756387171566592UL,
          4UL
        });
        LeftRecursiveRuleWalker.Follow._token_in_token772 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_token782 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_token803 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_token805 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_token820 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_token822 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_token834 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ELEMENT_OPTIONS_in_elementOptions864 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOption_in_elementOptions866 = new BitSet(new ulong[1]
        {
          268436488UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption885 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption896 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption898 = new BitSet(new ulong[1]
        {
          268435456UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption900 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption912 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption914 = new BitSet(new ulong[1]
        {
          4611686018427387904UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_elementOption916 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption928 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption930 = new BitSet(new ulong[1]
        {
          16UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_elementOption932 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_elementOption944 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_elementOption946 = new BitSet(new ulong[1]
        {
          1073741824UL
        });
        LeftRecursiveRuleWalker.Follow._INT_in_elementOption948 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._atom_in_element963 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._NOT_in_element969 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_element971 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._RANGE_in_element978 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._atom_in_element980 = new BitSet(new ulong[2]
        {
          4755801206504292352UL,
          34359738372UL
        });
        LeftRecursiveRuleWalker.Follow._atom_in_element982 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._ASSIGN_in_element989 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_element991 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_element993 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._PLUS_ASSIGN_in_element1000 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_element1002 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_element1004 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._SET_in_element1014 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._setElement_in_element1016 = new BitSet(new ulong[2]
        {
          4611686018427387912UL,
          4UL
        });
        LeftRecursiveRuleWalker.Follow._RULE_REF_in_element1028 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ebnf_in_element1033 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._epsilonElement_in_element1038 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_epsilonElement1049 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._SEMPRED_in_epsilonElement1054 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._EPSILON_in_epsilonElement1059 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_epsilonElement1065 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_epsilonElement1067 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._SEMPRED_in_epsilonElement1074 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_epsilonElement1076 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_setElement1089 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_setElement1091 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_setElement1098 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_setElement1100 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_setElement1106 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_setElement1111 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._block_in_ebnf1122 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._OPTIONAL_in_ebnf1134 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._block_in_ebnf1136 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._CLOSURE_in_ebnf1150 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._block_in_ebnf1152 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._POSITIVE_CLOSURE_in_ebnf1166 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._block_in_ebnf1168 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._BLOCK_in_block1188 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ACTION_in_block1190 = new BitSet(new ulong[2]
        {
          0UL,
          512UL
        });
        LeftRecursiveRuleWalker.Follow._alternative_in_block1193 = new BitSet(new ulong[2]
        {
          8UL,
          512UL
        });
        LeftRecursiveRuleWalker.Follow._ALT_in_alternative1210 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_alternative1212 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_alternative1215 = new BitSet(new ulong[2]
        {
          5336836476935078936UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._RULE_REF_in_atom1232 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ARG_ACTION_in_atom1234 = new BitSet(new ulong[2]
        {
          8UL,
          131072UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1237 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_atom1249 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1251 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._STRING_LITERAL_in_atom1257 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_atom1266 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1268 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._TOKEN_REF_in_atom1274 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._WILDCARD_in_atom1283 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._elementOptions_in_atom1285 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._WILDCARD_in_atom1291 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._DOT_in_atom1297 = new BitSet(new ulong[1]
        {
          4UL
        });
        LeftRecursiveRuleWalker.Follow._ID_in_atom1299 = new BitSet(new ulong[2]
        {
          5336836476935078928UL,
          43000307716UL
        });
        LeftRecursiveRuleWalker.Follow._element_in_atom1301 = new BitSet(new ulong[1]
        {
          8UL
        });
        LeftRecursiveRuleWalker.Follow._binary_in_synpred1_LeftRecursiveRuleWalker359 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._prefix_in_synpred2_LeftRecursiveRuleWalker415 = new BitSet(new ulong[1]
        {
          2UL
        });
        LeftRecursiveRuleWalker.Follow._suffix_in_synpred3_LeftRecursiveRuleWalker471 = new BitSet(new ulong[1]
        {
          2UL
        });
      }
    }
  }
}
