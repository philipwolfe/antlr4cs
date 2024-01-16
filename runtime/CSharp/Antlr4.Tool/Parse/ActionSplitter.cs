// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.ActionSplitter
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class ActionSplitter : Lexer
  {
    public const int EOF = -1;
    public const int ATTR = 4;
    public const int ATTR_VALUE_EXPR = 5;
    public const int COMMENT = 6;
    public const int ID = 7;
    public const int LINE_COMMENT = 8;
    public const int NONLOCAL_ATTR = 9;
    public const int QUALIFIED_ATTR = 10;
    public const int SET_ATTR = 11;
    public const int SET_NONLOCAL_ATTR = 12;
    public const int TEXT = 13;
    public const int WS = 14;
    private ActionSplitterListener @delegate;

    public ActionSplitter(ICharStream input, ActionSplitterListener @delegate) : this(input, new RecognizerSharedState())
    {
      
      this.@delegate = @delegate;
    }

    public virtual IList<IToken> GetActionTokens()
    {
      IList<IToken> actionTokens = (IList<IToken>) new List<IToken>();
      for (IToken token = this.NextToken(); token.Type != -1; token = this.NextToken())
        actionTokens.Add(token);
      return actionTokens;
    }

    private bool IsIDStartChar(int c)
    {
      return c == 95 || char.IsLetter((char) c);
    }

    public ActionSplitter() : base()
    {
    }

    public ActionSplitter(ICharStream input): this(input, new RecognizerSharedState())
    {
      
    }

    public ActionSplitter(ICharStream input, RecognizerSharedState state) : base(input, state)
    {
      
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\ActionSplitter.g3";
      }
    }

    public override IToken NextToken()
    {
      while (this.input.LA(1) != -1)
      {
        this.state.token = (IToken) null;
        this.state.channel = 0;
        this.state.tokenStartCharIndex = this.input.Index;
        this.state.tokenStartCharPositionInLine = this.input.CharPositionInLine;
        this.state.tokenStartLine = this.input.Line;
        this.state.text = (string) null;
        try
        {
          int marker = this.input.Mark();
          this.state.backtracking = 1;
          this.state.failed = false;
          this.mTokens();
          this.state.backtracking = 0;
          if (this.state.failed)
          {
            this.input.Rewind(marker);
            this.input.Consume();
          }
          else
          {
            this.Emit();
            return this.state.token;
          }
        }
        catch (RecognitionException ex)
        {
          this.ReportError(ex);
          this.Recover(ex);
        }
      }
      IToken token = (IToken) new CommonToken(this.input, -1, 0, this.input.Index, this.input.Index);
      token.Line = this.Line;
      token.CharPositionInLine = this.CharPositionInLine;
      return token;
    }

    public override void Memoize(IIntStream input, int ruleIndex, int ruleStartIndex)
    {
      if (this.state.backtracking <= 1)
        return;
      base.Memoize(input, ruleIndex, ruleStartIndex);
    }

    public override bool AlreadyParsedRule(IIntStream input, int ruleIndex)
    {
      return this.state.backtracking > 1 && base.AlreadyParsedRule(input, ruleIndex);
    }

    [GrammarRule("COMMENT")]
    private void mCOMMENT()
    {
      try
      {
        int num1 = 6;
        int num2 = 0;
        this.Match("/*");
        if (this.state.failed)
          return;
        try
        {
          do
          {
            int num3 = 2;
            try
            {
              int num4 = this.input.LA(1);
              if (num4 == 42)
              {
                int num5 = this.input.LA(2);
                if (num5 == 47)
                {
                  num3 = 2;
                }
                else
                {
                  if (num5 < 0 || num5 > 46)
                  {
                    if (num5 >= 48)
                    {
                      if (num5 > (int) ushort.MaxValue)
                        goto label_15;
                    }
                    else
                      goto label_15;
                  }
                  num3 = 1;
                }
              }
              else
              {
                if (num4 < 0 || num4 > 41)
                {
                  if (num4 >= 43)
                  {
                    if (num4 > (int) ushort.MaxValue)
                      goto label_15;
                  }
                  else
                    goto label_15;
                }
                num3 = 1;
              }
            }
            finally
            {
            }
label_15:
            if (num3 == 1)
              this.MatchAny();
            else
              goto label_20;
          }
          while (!this.state.failed);
          return;
        }
        finally
        {
        }
label_20:
        this.Match("*/");
        if (this.state.failed)
          return;
        if (this.state.backtracking == 1)
          this.@delegate.Text(this.Text);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LINE_COMMENT")]
    private void mLINE_COMMENT()
    {
      try
      {
        int num1 = 8;
        int num2 = 0;
        this.Match("//");
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            int num3 = 2;
            try
            {
              int num4 = this.input.LA(1);
              if ((num4 < 0 || num4 > 9) && (num4 < 11 || num4 > 12))
              {
                if (num4 >= 14)
                {
                  if (num4 > (int) ushort.MaxValue)
                    goto label_7;
                }
                else
                  goto label_7;
              }
              num3 = 1;
            }
            finally
            {
            }
label_7:
            if (num3 == 1)
            {
              this.input.Consume();
              this.state.failed = false;
            }
            else
              break;
          }
        }
        finally
        {
        }
        int num5 = 2;
        try
        {
          try
          {
            if (this.input.LA(1) == 13)
              num5 = 1;
          }
          finally
          {
          }
          if (num5 == 1)
          {
            this.Match(13);
            if (this.state.failed)
              return;
          }
        }
        finally
        {
        }
        this.Match(10);
        if (this.state.failed)
          return;
        if (this.state.backtracking == 1)
          this.@delegate.Text(this.Text);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("SET_NONLOCAL_ATTR")]
    private void mSET_NONLOCAL_ATTR()
    {
      try
      {
        int num1 = 12;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        int charIndex1 = this.CharIndex;
        int line1 = this.Line;
        int charPositionInLine1 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken x = new CommonToken(this.input, 0, 0, charIndex1, this.CharIndex - 1);
        x.Line = line1;
        x.CharPositionInLine = charPositionInLine1;
        this.Match("::");
        if (this.state.failed)
          return;
        int charIndex2 = this.CharIndex;
        int line2 = this.Line;
        int charPositionInLine2 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken y = new CommonToken(this.input, 0, 0, charIndex2, this.CharIndex - 1);
        y.Line = line2;
        y.CharPositionInLine = charPositionInLine2;
        int num3 = 2;
        try
        {
          try
          {
            int num4 = this.input.LA(1);
            if ((num4 < 9 || num4 > 10) && num4 != 13)
            {
              if (num4 != 32)
                goto label_12;
            }
            num3 = 1;
          }
          finally
          {
          }
label_12:
          if (num3 == 1)
          {
            this.mWS();
            if (this.state.failed)
              return;
          }
        }
        finally
        {
        }
        this.Match(61);
        if (this.state.failed)
          return;
        int charIndex3 = this.CharIndex;
        int line3 = this.Line;
        int charPositionInLine3 = this.CharPositionInLine;
        this.mATTR_VALUE_EXPR();
        if (this.state.failed)
          return;
        CommonToken rhs = new CommonToken(this.input, 0, 0, charIndex3, this.CharIndex - 1);
        rhs.Line = line3;
        rhs.CharPositionInLine = charPositionInLine3;
        this.Match(59);
        if (this.state.failed)
          return;
        if (this.state.backtracking == 1)
          this.@delegate.SetNonLocalAttr(this.Text, (IToken) x, (IToken) y, (IToken) rhs);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("NONLOCAL_ATTR")]
    private void mNONLOCAL_ATTR()
    {
      try
      {
        int num1 = 9;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        int charIndex1 = this.CharIndex;
        int line1 = this.Line;
        int charPositionInLine1 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken x = new CommonToken(this.input, 0, 0, charIndex1, this.CharIndex - 1);
        x.Line = line1;
        x.CharPositionInLine = charPositionInLine1;
        this.Match("::");
        if (this.state.failed)
          return;
        int charIndex2 = this.CharIndex;
        int line2 = this.Line;
        int charPositionInLine2 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken y = new CommonToken(this.input, 0, 0, charIndex2, this.CharIndex - 1);
        y.Line = line2;
        y.CharPositionInLine = charPositionInLine2;
        if (this.state.backtracking == 1)
          this.@delegate.NonLocalAttr(this.Text, (IToken) x, (IToken) y);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("QUALIFIED_ATTR")]
    private void mQUALIFIED_ATTR()
    {
      try
      {
        int num1 = 10;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        int charIndex1 = this.CharIndex;
        int line1 = this.Line;
        int charPositionInLine1 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken x = new CommonToken(this.input, 0, 0, charIndex1, this.CharIndex - 1);
        x.Line = line1;
        x.CharPositionInLine = charPositionInLine1;
        this.Match(46);
        if (this.state.failed)
          return;
        int charIndex2 = this.CharIndex;
        int line2 = this.Line;
        int charPositionInLine2 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken y = new CommonToken(this.input, 0, 0, charIndex2, this.CharIndex - 1);
        y.Line = line2;
        y.CharPositionInLine = charPositionInLine2;
        if (this.input.LA(1) == 40)
        {
          if (this.state.backtracking <= 0)
            throw new FailedPredicateException((IIntStream) this.input, "QUALIFIED_ATTR", "input.LA(1)!='('");
          this.state.failed = true;
        }
        else
        {
          if (this.state.backtracking == 1)
            this.@delegate.QualifiedAttr(this.Text, (IToken) x, (IToken) y);
          this.state.type = num1;
          this.state.channel = num2;
        }
      }
      finally
      {
      }
    }

    [GrammarRule("SET_ATTR")]
    private void mSET_ATTR()
    {
      try
      {
        int num1 = 11;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        int charIndex1 = this.CharIndex;
        int line1 = this.Line;
        int charPositionInLine1 = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken x = new CommonToken(this.input, 0, 0, charIndex1, this.CharIndex - 1);
        x.Line = line1;
        x.CharPositionInLine = charPositionInLine1;
        int num3 = 2;
        try
        {
          try
          {
            int num4 = this.input.LA(1);
            if ((num4 < 9 || num4 > 10) && num4 != 13)
            {
              if (num4 != 32)
                goto label_8;
            }
            num3 = 1;
          }
          finally
          {
          }
label_8:
          if (num3 == 1)
          {
            this.mWS();
            if (this.state.failed)
              return;
          }
        }
        finally
        {
        }
        this.Match(61);
        if (this.state.failed)
          return;
        int charIndex2 = this.CharIndex;
        int line2 = this.Line;
        int charPositionInLine2 = this.CharPositionInLine;
        this.mATTR_VALUE_EXPR();
        if (this.state.failed)
          return;
        CommonToken rhs = new CommonToken(this.input, 0, 0, charIndex2, this.CharIndex - 1);
        rhs.Line = line2;
        rhs.CharPositionInLine = charPositionInLine2;
        this.Match(59);
        if (this.state.failed)
          return;
        if (this.state.backtracking == 1)
          this.@delegate.SetAttr(this.Text, (IToken) x, (IToken) rhs);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("ATTR")]
    private void mATTR()
    {
      try
      {
        int num1 = 4;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        int charIndex = this.CharIndex;
        int line = this.Line;
        int charPositionInLine = this.CharPositionInLine;
        this.mID();
        if (this.state.failed)
          return;
        CommonToken x = new CommonToken(this.input, 0, 0, charIndex, this.CharIndex - 1);
        x.Line = line;
        x.CharPositionInLine = charPositionInLine;
        if (this.state.backtracking == 1)
          this.@delegate.Attr(this.Text, (IToken) x);
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("TEXT")]
    private void mTEXT()
    {
      try
      {
        int num1 = 13;
        int num2 = 0;
        StringBuilder stringBuilder = new StringBuilder();
        int num3 = 0;
        try
        {
          while (true)
          {
            int num4 = 5;
            try
            {
              int num5 = this.input.LA(1);
              if (num5 >= 0 && num5 <= 35 || num5 >= 37 && num5 <= 91 || num5 >= 93 && num5 <= (int) ushort.MaxValue)
              {
                num4 = 1;
              }
              else
              {
                switch (num5)
                {
                  case 36:
                    if (!this.IsIDStartChar(this.input.LA(2)))
                    {
                      num4 = 4;
                      break;
                    }
                    break;
                  case 92:
                    int num6 = this.input.LA(2);
                    if (num6 == 36)
                    {
                      num4 = 2;
                      break;
                    }
                    if (num6 < 0 || num6 > 35)
                    {
                      if (num6 >= 37)
                      {
                        if (num6 > (int) ushort.MaxValue)
                          break;
                      }
                      else
                        break;
                    }
                    num4 = 3;
                    break;
                }
              }
            }
            finally
            {
            }
            switch (num4)
            {
              case 1:
                int num7 = this.input.LA(1);
                this.input.Consume();
                this.state.failed = false;
                if (this.state.backtracking == 1)
                {
                  stringBuilder.Append((char) num7);
                  break;
                }
                break;
              case 2:
                this.Match("\\$");
                if (!this.state.failed)
                {
                  if (this.state.backtracking == 1)
                  {
                    stringBuilder.Append('$');
                    break;
                  }
                  break;
                }
                goto label_31;
              case 3:
                this.Match(92);
                if (!this.state.failed)
                {
                  int num8 = this.input.LA(1);
                  this.input.Consume();
                  this.state.failed = false;
                  if (this.state.backtracking == 1)
                  {
                    stringBuilder.Append('\\').Append((char) num8);
                    break;
                  }
                  break;
                }
                goto label_23;
              case 4:
                if (!this.IsIDStartChar(this.input.LA(2)))
                {
                  this.Match(36);
                  if (!this.state.failed)
                  {
                    if (this.state.backtracking == 1)
                    {
                      stringBuilder.Append('$');
                      break;
                    }
                    break;
                  }
                  goto label_19;
                }
                else
                  goto label_27;
              default:
                goto label_34;
            }
            ++num3;
          }
label_31:
          return;
label_23:
          return;
label_27:
          if (this.state.backtracking <= 0)
            throw new FailedPredicateException((IIntStream) this.input, "TEXT", "!IsIDStartChar(input.LA(2))");
          this.state.failed = true;
          return;
label_19:
          return;
label_34:
          if (num3 < 1)
          {
            if (this.state.backtracking <= 0)
              throw new EarlyExitException(6, (IIntStream) this.input);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        this.state.type = num1;
        this.state.channel = num2;
        if (this.state.backtracking != 1)
          return;
        this.@delegate.Text(stringBuilder.ToString());
      }
      finally
      {
      }
    }

    [GrammarRule("ID")]
    private void mID()
    {
      try
      {
        if (this.input.LA(1) >= 65 && this.input.LA(1) <= 90 || this.input.LA(1) == 95 || this.input.LA(1) >= 97 && this.input.LA(1) <= 122)
        {
          this.input.Consume();
          this.state.failed = false;
          try
          {
            while (true)
            {
              int num1 = 2;
              try
              {
                int num2 = this.input.LA(1);
                if ((num2 < 48 || num2 > 57) && (num2 < 65 || num2 > 90) && num2 != 95)
                {
                  if (num2 >= 97)
                  {
                    if (num2 > 122)
                      goto label_12;
                  }
                  else
                    goto label_12;
                }
                num1 = 1;
              }
              finally
              {
              }
label_12:
              if (num1 == 1)
              {
                this.input.Consume();
                this.state.failed = false;
              }
              else
                break;
            }
          }
          finally
          {
          }
        }
        else if (this.state.backtracking > 0)
        {
          this.state.failed = true;
        }
        else
        {
          MismatchedSetException re = new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.Recover((RecognitionException) re);
          throw re;
        }
      }
      finally
      {
      }
    }

    [GrammarRule("ATTR_VALUE_EXPR")]
    private void mATTR_VALUE_EXPR()
    {
      try
      {
        if (this.input.LA(1) >= 0 && this.input.LA(1) <= 60 || this.input.LA(1) >= 62 && this.input.LA(1) <= (int) ushort.MaxValue)
        {
          this.input.Consume();
          this.state.failed = false;
          try
          {
            while (true)
            {
              int num1 = 2;
              try
              {
                int num2 = this.input.LA(1);
                if (num2 < 0 || num2 > 58)
                {
                  if (num2 >= 60)
                  {
                    if (num2 > (int) ushort.MaxValue)
                      goto label_12;
                  }
                  else
                    goto label_12;
                }
                num1 = 1;
              }
              finally
              {
              }
label_12:
              if (num1 == 1)
              {
                this.input.Consume();
                this.state.failed = false;
              }
              else
                break;
            }
          }
          finally
          {
          }
        }
        else if (this.state.backtracking > 0)
        {
          this.state.failed = true;
        }
        else
        {
          MismatchedSetException re = new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.Recover((RecognitionException) re);
          throw re;
        }
      }
      finally
      {
      }
    }

    [GrammarRule("WS")]
    private void mWS()
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
              int num3 = this.input.LA(1);
              if ((num3 < 9 || num3 > 10) && num3 != 13)
              {
                if (num3 != 32)
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
              this.input.Consume();
              this.state.failed = false;
              ++num1;
            }
            else
              break;
          }
          if (num1 >= 1)
            return;
          if (this.state.backtracking <= 0)
            throw new EarlyExitException(9, (IIntStream) this.input);
          this.state.failed = true;
        }
        finally
        {
        }
      }
      finally
      {
      }
    }

    public override void mTokens()
    {
      int num1 = 8;
      try
      {
        int num2 = this.input.LA(1);
        switch (num2)
        {
          case 36:
            this.input.LA(2);
            // ISSUE: method pointer
            if (this.EvaluatePredicate(synpred3_ActionSplitter_fragment))
            {
              num1 = 3;
              break;
            }
            // ISSUE: method pointer
            if (this.EvaluatePredicate(synpred4_ActionSplitter_fragment))
            {
              num1 = 4;
              break;
            }
            // ISSUE: method pointer
            if (this.EvaluatePredicate(synpred5_ActionSplitter_fragment))
            {
              num1 = 5;
              break;
            }
            // ISSUE: method pointer
            if (this.EvaluatePredicate(synpred6_ActionSplitter_fragment))
            {
              num1 = 6;
              break;
            }
            // ISSUE: method pointer
            if (this.EvaluatePredicate(synpred7_ActionSplitter_fragment))
            {
              num1 = 7;
              break;
            }
            if (!this.IsIDStartChar(this.input.LA(2)))
            {
              num1 = 8;
              break;
            }
            if (this.state.backtracking <= 0)
              throw new NoViableAltException("", 10, 2, (IIntStream) this.input, 2);
            this.state.failed = true;
            return;
          case 47:
            this.input.LA(2);
            // ISSUE: method pointer
            // ISSUE: method pointer
            num1 = !this.EvaluatePredicate(synpred1_ActionSplitter_fragment) ? (!this.EvaluatePredicate(synpred2_ActionSplitter_fragment) ? 8 : 2) : 1;
            break;
          default:
            if (num2 >= 0 && num2 <= 35 || num2 >= 37 && num2 <= 46 || num2 >= 48 && num2 <= (int) ushort.MaxValue)
            {
              num1 = 8;
              break;
            }
            if (this.state.backtracking <= 0)
              throw new NoViableAltException("", 10, 0, (IIntStream) this.input, 1);
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
          this.mCOMMENT();
          int num3 = this.state.failed ? 1 : 0;
          break;
        case 2:
          this.mLINE_COMMENT();
          int num4 = this.state.failed ? 1 : 0;
          break;
        case 3:
          this.mSET_NONLOCAL_ATTR();
          int num5 = this.state.failed ? 1 : 0;
          break;
        case 4:
          this.mNONLOCAL_ATTR();
          int num6 = this.state.failed ? 1 : 0;
          break;
        case 5:
          this.mQUALIFIED_ATTR();
          int num7 = this.state.failed ? 1 : 0;
          break;
        case 6:
          this.mSET_ATTR();
          int num8 = this.state.failed ? 1 : 0;
          break;
        case 7:
          this.mATTR();
          int num9 = this.state.failed ? 1 : 0;
          break;
        case 8:
          this.mTEXT();
          int num10 = this.state.failed ? 1 : 0;
          break;
      }
    }

    private void synpred1_ActionSplitter_fragment()
    {
      try
      {
        this.mCOMMENT();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred2_ActionSplitter_fragment()
    {
      try
      {
        this.mLINE_COMMENT();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred3_ActionSplitter_fragment()
    {
      try
      {
        this.mSET_NONLOCAL_ATTR();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred4_ActionSplitter_fragment()
    {
      try
      {
        this.mNONLOCAL_ATTR();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred5_ActionSplitter_fragment()
    {
      try
      {
        this.mQUALIFIED_ATTR();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred6_ActionSplitter_fragment()
    {
      try
      {
        this.mSET_ATTR();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred7_ActionSplitter_fragment()
    {
      try
      {
        this.mATTR();
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
    }
  }
}
