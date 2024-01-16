// Decompiled with JetBrains decompiler
// Type: Antlr4.Parse.ANTLRLexer
// Assembly: Antlr4, Version=4.6.0.0, Culture=neutral, PublicKeyToken=09abb75b9ed49849
// MVID: 79E75635-627E-4EC3-B7B5-86FFCE159823
// Assembly location: C:\Users\Philip.Wolfe\.nuget\packages\antlr4.codegenerator\4.6.6\tools\net45\Antlr4.exe
// Compiler-generated code is shown

using Antlr.Runtime;
using Antlr4.Tool;
using System;
using System.CodeDom.Compiler;

namespace Antlr4.Parse
{
  [GeneratedCode("ANTLR", "3.5.2-beta1")]
  public class ANTLRLexer : Lexer
  {
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
    public static readonly int COMMENTS_CHANNEL;
    public CommonTokenStream tokens;
    public bool isLexerRule;
    private ANTLRLexer.DFA2 dfa2;
    private ANTLRLexer.DFA34 dfa34;

    public virtual void GrammarError(ErrorType etype, IToken token, params object[] args)
    {
    }

    public virtual IToken GetRuleOrSubruleStartToken()
    {
      if (this.tokens == null)
        return (IToken) null;
      int i = this.tokens.Index;
      int count = this.tokens.Count;
      if (i >= count)
        i = count - 1;
      for (; i >= 0 && i < count; --i)
      {
        switch (this.tokens.Get(i).Type)
        {
          case 34:
          case 57:
          case 66:
            return this.tokens.Get(i);
        }
      }
      return (IToken) null;
    }

    public ANTLRLexer():base()
    {
    }

    public ANTLRLexer(ICharStream input) : this(input, new RecognizerSharedState())
    {
      
    }

    public ANTLRLexer(ICharStream input, RecognizerSharedState state): base(input, state)
    {
      
    }

    public override string GrammarFileName
    {
      get
      {
        return "Parse\\ANTLRLexer.g3";
      }
    }

    [GrammarRule("DOC_COMMENT")]
    private void mDOC_COMMENT()
    {
      try
      {
      }
      finally
      {
      }
    }

    [GrammarRule("COMMENT")]
    private void mCOMMENT()
    {
      try
      {
        int num1 = 17;
        int num2 = 0;
        int tokenStartLine = this.state.tokenStartLine;
        int charPositionInLine = this.CharPositionInLine;
        this.Match(47);
        if (this.state.failed)
          return;
        int num3 = 3;
        try
        {
          try
          {
            switch (this.input.LA(1))
            {
              case 42:
                num3 = 2;
                break;
              case 47:
                num3 = 1;
                break;
              default:
                num3 = 3;
                break;
            }
          }
          finally
          {
          }
          switch (num3)
          {
            case 1:
              this.Match(47);
              if (this.state.failed)
                return;
              int num4 = 2;
              try
              {
                try
                {
                  num4 = this.dfa2.Predict((IIntStream) this.input);
                }
                catch (NoViableAltException ex)
                {
                  throw;
                }
                finally
                {
                }
                switch (num4)
                {
                  case 1:
                    this.Match(" $ANTLR");
                    if (this.state.failed)
                      return;
                    this.mSRC();
                    if (this.state.failed)
                      return;
                    break;
                  case 2:
                    try
                    {
                      while (true)
                      {
                        int num5 = 2;
                        try
                        {
                          int num6 = this.input.LA(1);
                          if ((num6 < 0 || num6 > 9) && (num6 < 11 || num6 > 12))
                          {
                            if (num6 >= 14)
                            {
                              if (num6 > (int) ushort.MaxValue)
                                goto label_22;
                            }
                            else
                              goto label_22;
                          }
                          num5 = 1;
                        }
                        finally
                        {
                        }
label_22:
                        if (num5 == 1)
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

                    break;
                }
              }
              finally
              {
              }
              break;
            case 2:
              this.Match(42);
              if (this.state.failed)
                return;
              int num7 = 2;
              try
              {
                try
                {
                  if (this.input.LA(1) == 42)
                  {
                    this.input.LA(2);
                    this.input.LA(2);
                    num7 = this.input.LA(2) == 47 ? 2 : 1;
                  }
                  else
                    num7 = 2;
                }
                finally
                {
                }
                if (num7 != 1)
                {
                  if (num7 == 2)
                    ;
                }
                else
                {
                  if (this.input.LA(2) == 47)
                  {
                    if (this.state.backtracking <= 0)
                      throw new FailedPredicateException((IIntStream) this.input, "COMMENT", " input.LA(2) != '/'");
                    this.state.failed = true;
                    return;
                  }
                  this.Match(42);
                  if (this.state.failed)
                    return;
                  if (this.state.backtracking == 0)
                    num1 = 18;
                }
              }
              finally
              {
              }
              try
              {
                do
                {
                  int num8 = 2;
                  try
                  {
                    int num9 = this.input.LA(1);
                    if (num9 == 42)
                    {
                      if (this.input.LA(2) == 47)
                      {
                        this.input.LA(3);
                        if (this.input.LA(1) == 42)
                        {
                          if (this.input.LA(2) == 47)
                            goto label_61;
                        }
                        num8 = 1;
                      }
                      else
                        num8 = 1;
                    }
                    else
                    {
                      if (num9 < 0 || num9 > 41)
                      {
                        if (num9 >= 43)
                        {
                          if (num9 > (int) ushort.MaxValue)
                            goto label_61;
                        }
                        else
                          goto label_61;
                      }
                      num8 = 1;
                    }
                  }
                  finally
                  {
                  }
label_61:
                  if (num8 == 1)
                  {
                    if (this.input.LA(1) == 42 && this.input.LA(2) == 47)
                    {
                      if (this.state.backtracking <= 0)
                        throw new FailedPredicateException((IIntStream) this.input, "COMMENT", "    !(input.LA(1) == '*' && input.LA(2) == '/') ");
                      this.state.failed = true;
                      break;
                    }
                    this.MatchAny();
                  }
                  else
                    goto label_70;
                }
                while (!this.state.failed);
                return;
              }
              finally
              {
              }
label_70:
              int num10 = 2;
              try
              {
                try
                {
                  num10 = this.input.LA(1) != 42 ? 2 : 1;
                }
                finally
                {
                }
                switch (num10)
                {
                  case 1:
                    this.Match("*/");
                    if (this.state.failed)
                      return;
                    break;
                  case 2:
                    int backtracking = this.state.backtracking;
                    break;
                }
              }
              finally
              {
              }
              break;
            case 3:
              int backtracking1 = this.state.backtracking;
              break;
          }
        }
        finally
        {
        }
        if (this.state.backtracking == 0)
          num2 = ANTLRLexer.COMMENTS_CHANNEL;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("ARG_OR_CHARSET")]
    private void mARG_OR_CHARSET()
    {
      try
      {
        int num1 = 9;
        int num2 = 0;
        int num3 = 2;
        try
        {
          if (this.input.LA(1) == 91 && (this.isLexerRule || !this.isLexerRule))
          {
            this.input.LA(2);
            if (this.isLexerRule)
              num3 = 1;
            else if (!this.isLexerRule)
            {
              num3 = 2;
            }
            else
            {
              if (this.state.backtracking <= 0)
                throw new NoViableAltException("", 7, 1, (IIntStream) this.input, 2);
              this.state.failed = true;
              return;
            }
          }
          else
          {
            if (this.state.backtracking <= 0)
              throw new NoViableAltException("", 7, 0, (IIntStream) this.input, 1);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        switch (num3)
        {
          case 1:
            if (!this.isLexerRule)
            {
              if (this.state.backtracking <= 0)
                throw new FailedPredicateException((IIntStream) this.input, "ARG_OR_CHARSET", "isLexerRule");
              this.state.failed = true;
              return;
            }
            this.mLEXER_CHAR_SET();
            if (this.state.failed)
              return;
            if (this.state.backtracking == 0)
            {
              num1 = 32;
              break;
            }
            break;
          case 2:
            if (this.isLexerRule)
            {
              if (this.state.backtracking <= 0)
                throw new FailedPredicateException((IIntStream) this.input, "ARG_OR_CHARSET", "!isLexerRule");
              this.state.failed = true;
              return;
            }
            this.mARG_ACTION();
            if (this.state.failed)
              return;
            if (this.state.backtracking == 0)
            {
              num1 = 8;
              string text = this.Text;
              this.Text = text.Substring(1, text.Length - 2);
              break;
            }
            break;
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LEXER_CHAR_SET")]
    private void mLEXER_CHAR_SET()
    {
      try
      {
        this.Match(91);
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            int num1 = 3;
            try
            {
              int num2 = this.input.LA(1);
              if (num2 == 92)
              {
                num1 = 1;
              }
              else
              {
                if ((num2 < 0 || num2 > 9) && (num2 < 11 || num2 > 12) && (num2 < 14 || num2 > 91))
                {
                  if (num2 >= 94)
                  {
                    if (num2 > (int) ushort.MaxValue)
                      goto label_10;
                  }
                  else
                    goto label_10;
                }
                num1 = 2;
              }
            }
            finally
            {
            }
label_10:
            switch (num1)
            {
              case 1:
                this.Match(92);
                if (!this.state.failed)
                {
                  this.input.Consume();
                  this.state.failed = false;
                  continue;
                }
                goto label_8;
              case 2:
                this.input.Consume();
                this.state.failed = false;
                continue;
              default:
                goto label_16;
            }
          }
label_8:
          return;
        }
        finally
        {
        }
label_16:
        this.Match(93);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    [GrammarRule("ARG_ACTION")]
    private void mARG_ACTION()
    {
      try
      {
        this.Match(91);
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            do
            {
              do
              {
                do
                {
                  int num1 = 5;
                  try
                  {
                    int num2 = this.input.LA(1);
                    switch (num2)
                    {
                      case 34:
                        this.input.LA(2);
                        // ISSUE: method pointer
                        num1 = !this.EvaluatePredicate(synpred2_ANTLRLexer_fragment) ? 4 : 2;
                        break;
                      case 39:
                        this.input.LA(2);
                        // ISSUE: method pointer
                        num1 = !this.EvaluatePredicate(synpred3_ANTLRLexer_fragment) ? 4 : 3;
                        break;
                      case 91:
                        num1 = 1;
                        break;
                      default:
                        if ((num2 < 0 || num2 > 33) && (num2 < 35 || num2 > 38) && (num2 < 40 || num2 > 90) && num2 != 92)
                        {
                          if (num2 >= 94)
                          {
                            if (num2 > (int) ushort.MaxValue)
                              break;
                          }
                          else
                            break;
                        }
                        num1 = 4;
                        break;
                    }
                  }
                  finally
                  {
                  }
                  switch (num1)
                  {
                    case 1:
                      this.mARG_ACTION();
                      continue;
                    case 2:
                      goto label_16;
                    case 3:
                      goto label_18;
                    case 4:
                      goto label_19;
                    default:
                      goto label_21;
                  }
                }
                while (!this.state.failed);
                goto label_15;
label_16:
                this.mACTION_STRING_LITERAL();
              }
              while (!this.state.failed);
              goto label_13;
label_18:
              this.mACTION_CHAR_LITERAL();
            }
            while (!this.state.failed);
            goto label_10;
label_19:
            this.input.Consume();
            this.state.failed = false;
          }
label_15:
          return;
label_13:
          return;
label_10:
          return;
        }
        finally
        {
        }
label_21:
        this.Match(93);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    [GrammarRule("ACTION")]
    private void mACTION()
    {
      try
      {
        int num1 = 4;
        int num2 = 0;
        this.mNESTED_ACTION();
        if (this.state.failed)
          return;
        int num3 = 2;
        try
        {
          try
          {
            if (this.input.LA(1) == 63)
              num3 = 1;
          }
          finally
          {
          }
          if (num3 == 1)
          {
            this.Match(63);
            if (this.state.failed)
              return;
            if (this.state.backtracking == 0)
              num1 = 59;
            int num4 = 2;
            try
            {
              try
              {
                int num5 = this.input.LA(1);
                // ISSUE: method pointer
                if ((num5 >= 9 && num5 <= 10 || num5 >= 12 && num5 <= 13 || num5 == 32) && this.EvaluatePredicate(synpred4_ANTLRLexer_fragment))
                  num4 = 1;
                else if (num5 == 61)
                {
                  // ISSUE: method pointer
                  if (this.EvaluatePredicate(synpred4_ANTLRLexer_fragment))
                    num4 = 1;
                }
              }
              finally
              {
              }
              if (num4 == 1)
              {
                try
                {
                  while (true)
                  {
                    int num6 = 2;
                    try
                    {
                      int num7 = this.input.LA(1);
                      if ((num7 < 9 || num7 > 10) && (num7 < 12 || num7 > 13))
                      {
                        if (num7 != 32)
                          goto label_23;
                      }
                      num6 = 1;
                    }
                    finally
                    {
                    }
label_23:
                    if (num6 == 1)
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
                this.Match("=>");
                if (this.state.failed)
                  return;
                if (this.state.backtracking == 0)
                {
                  IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.state.tokenStartCharIndex, this.CharIndex - 1);
                  token.Line = this.state.tokenStartLine;
                  token.Text = this.state.text;
                  token.CharPositionInLine = this.state.tokenStartCharPositionInLine;
                  this.GrammarError(ErrorType.V3_GATED_SEMPRED, token, new object[0]);
                }
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
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("NESTED_ACTION")]
    private void mNESTED_ACTION()
    {
      try
      {
        int line = this.Line;
        int charPositionInLine = this.CharPositionInLine;
        this.Match(123);
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            do
            {
              do
              {
                do
                {
                  do
                  {
                    do
                    {
                      int num1 = 7;
                      try
                      {
                        int num2 = this.input.LA(1);
                        switch (num2)
                        {
                          case 34:
                            num1 = 4;
                            break;
                          case 39:
                            num1 = 2;
                            break;
                          case 47:
                            num1 = 3;
                            break;
                          case 92:
                            num1 = 5;
                            break;
                          case 123:
                            num1 = 1;
                            break;
                          default:
                            if ((num2 < 0 || num2 > 33) && (num2 < 35 || num2 > 38) && (num2 < 40 || num2 > 46) && (num2 < 48 || num2 > 91) && (num2 < 93 || num2 > 122) && num2 != 124)
                            {
                              if (num2 >= 126)
                              {
                                if (num2 > (int) ushort.MaxValue)
                                  break;
                              }
                              else
                                break;
                            }
                            num1 = 6;
                            break;
                        }
                      }
                      finally
                      {
                      }
                      switch (num1)
                      {
                        case 1:
                          this.mNESTED_ACTION();
                          continue;
                        case 2:
                          goto label_18;
                        case 3:
                          goto label_20;
                        case 4:
                          goto label_22;
                        case 5:
                          goto label_24;
                        case 6:
                          goto label_26;
                        default:
                          goto label_28;
                      }
                    }
                    while (!this.state.failed);
                    goto label_34;
label_18:
                    this.mACTION_CHAR_LITERAL();
                  }
                  while (!this.state.failed);
                  goto label_32;
label_20:
                  this.mCOMMENT();
                }
                while (!this.state.failed);
                goto label_25;
label_22:
                this.mACTION_STRING_LITERAL();
              }
              while (!this.state.failed);
              goto label_23;
label_24:
              this.mACTION_ESC();
            }
            while (!this.state.failed);
            goto label_21;
label_26:
            this.input.Consume();
            this.state.failed = false;
          }
label_34:
          return;
label_32:
          return;
label_25:
          return;
label_23:
          return;
label_21:
          return;
        }
        finally
        {
        }
label_28:
        int num = 2;
        try
        {
          try
          {
            num = this.input.LA(1) != 125 ? 2 : 1;
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match(125);
              if (!this.state.failed)
                break;
              break;
            case 2:
              if (this.state.backtracking != 0)
                break;
              Console.WriteLine("Block starting  at line " + (object) line + " offset " + (object) (charPositionInLine + 1) + " contains imbalanced {} or is missing a }");
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

    [GrammarRule("OPTIONS")]
    private void mOPTIONS()
    {
      try
      {
        int num1 = 42;
        int num2 = 0;
        this.Match("options");
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
              if ((num4 < 9 || num4 > 10) && (num4 < 12 || num4 > 13))
              {
                if (num4 != 32)
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
        this.Match(123);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("TOKENS_SPEC")]
    private void mTOKENS_SPEC()
    {
      try
      {
        int num1 = 65;
        int num2 = 0;
        this.Match("tokens");
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
              if ((num4 < 9 || num4 > 10) && (num4 < 12 || num4 > 13))
              {
                if (num4 != 32)
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
        this.Match(123);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("CHANNELS")]
    private void mCHANNELS()
    {
      try
      {
        int num1 = 13;
        int num2 = 0;
        this.Match("channels");
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
              if ((num4 < 9 || num4 > 10) && (num4 < 12 || num4 > 13))
              {
                if (num4 != 32)
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
        this.Match(123);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("IMPORT")]
    private void mIMPORT()
    {
      try
      {
        int num1 = 29;
        int num2 = 0;
        this.Match("import");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("FRAGMENT")]
    private void mFRAGMENT()
    {
      try
      {
        int num1 = 24;
        int num2 = 0;
        this.Match("fragment");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LEXER")]
    private void mLEXER()
    {
      try
      {
        int num1 = 31;
        int num2 = 0;
        this.Match("lexer");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PARSER")]
    private void mPARSER()
    {
      try
      {
        int num1 = 44;
        int num2 = 0;
        this.Match("parser");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("GRAMMAR")]
    private void mGRAMMAR()
    {
      try
      {
        int num1 = 25;
        int num2 = 0;
        this.Match("grammar");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("TREE_GRAMMAR")]
    private void mTREE_GRAMMAR()
    {
      try
      {
        int num1 = 67;
        int num2 = 0;
        this.Match("tree");
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
              if ((num4 < 9 || num4 > 10) && (num4 < 12 || num4 > 13))
              {
                if (num4 != 32)
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
        this.Match("grammar");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PROTECTED")]
    private void mPROTECTED()
    {
      try
      {
        int num1 = 49;
        int num2 = 0;
        this.Match("protected");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PUBLIC")]
    private void mPUBLIC()
    {
      try
      {
        int num1 = 50;
        int num2 = 0;
        this.Match("public");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PRIVATE")]
    private void mPRIVATE()
    {
      try
      {
        int num1 = 48;
        int num2 = 0;
        this.Match("private");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("RETURNS")]
    private void mRETURNS()
    {
      try
      {
        int num1 = 55;
        int num2 = 0;
        this.Match("returns");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LOCALS")]
    private void mLOCALS()
    {
      try
      {
        int num1 = 33;
        int num2 = 0;
        this.Match("locals");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("THROWS")]
    private void mTHROWS()
    {
      try
      {
        int num1 = 64;
        int num2 = 0;
        this.Match("throws");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("CATCH")]
    private void mCATCH()
    {
      try
      {
        int num1 = 12;
        int num2 = 0;
        this.Match("catch");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("FINALLY")]
    private void mFINALLY()
    {
      try
      {
        int num1 = 23;
        int num2 = 0;
        this.Match("finally");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("MODE")]
    private void mMODE()
    {
      try
      {
        int num1 = 36;
        int num2 = 0;
        this.Match("mode");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("COLON")]
    private void mCOLON()
    {
      try
      {
        int num1 = 14;
        int num2 = 0;
        this.Match(58);
        if (this.state.failed)
          return;
        if (this.state.backtracking == 0)
        {
          IToken subruleStartToken = this.GetRuleOrSubruleStartToken();
          if (subruleStartToken != null)
          {
            if (subruleStartToken.Type == 57)
              this.isLexerRule = false;
            else if (subruleStartToken.Type == 66)
              this.isLexerRule = true;
          }
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("COLONCOLON")]
    private void mCOLONCOLON()
    {
      try
      {
        int num1 = 15;
        int num2 = 0;
        this.Match("::");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("COMMA")]
    private void mCOMMA()
    {
      try
      {
        int num1 = 16;
        int num2 = 0;
        this.Match(44);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("SEMI")]
    private void mSEMI()
    {
      try
      {
        int num1 = 58;
        int num2 = 0;
        this.Match(59);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LPAREN")]
    private void mLPAREN()
    {
      try
      {
        int num1 = 34;
        int num2 = 0;
        this.Match(40);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("RPAREN")]
    private void mRPAREN()
    {
      try
      {
        int num1 = 56;
        int num2 = 0;
        this.Match(41);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("RARROW")]
    private void mRARROW()
    {
      try
      {
        int num1 = 53;
        int num2 = 0;
        this.Match("->");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("LT")]
    private void mLT()
    {
      try
      {
        int num1 = 35;
        int num2 = 0;
        this.Match(60);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("GT")]
    private void mGT()
    {
      try
      {
        int num1 = 26;
        int num2 = 0;
        this.Match(62);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("ASSIGN")]
    private void mASSIGN()
    {
      try
      {
        int num1 = 10;
        int num2 = 0;
        this.Match(61);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("QUESTION")]
    private void mQUESTION()
    {
      try
      {
        int num1 = 51;
        int num2 = 0;
        this.Match(63);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("SYNPRED")]
    private void mSYNPRED()
    {
      try
      {
        int num1 = 63;
        int num2 = 0;
        this.Match("=>");
        if (this.state.failed)
          return;
        if (this.state.backtracking == 0)
        {
          IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.state.tokenStartCharIndex, this.CharIndex - 1);
          token.Line = this.state.tokenStartLine;
          token.Text = this.state.text;
          token.CharPositionInLine = this.state.tokenStartCharPositionInLine;
          this.GrammarError(ErrorType.V3_SYNPRED, token, new object[0]);
          num2 = 99;
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("STAR")]
    private void mSTAR()
    {
      try
      {
        int num1 = 61;
        int num2 = 0;
        this.Match(42);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PLUS")]
    private void mPLUS()
    {
      try
      {
        int num1 = 45;
        int num2 = 0;
        this.Match(43);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("PLUS_ASSIGN")]
    private void mPLUS_ASSIGN()
    {
      try
      {
        int num1 = 46;
        int num2 = 0;
        this.Match("+=");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("OR")]
    private void mOR()
    {
      try
      {
        int num1 = 43;
        int num2 = 0;
        this.Match(124);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("DOLLAR")]
    private void mDOLLAR()
    {
      try
      {
        int num1 = 19;
        int num2 = 0;
        this.Match(36);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("DOT")]
    private void mDOT()
    {
      try
      {
        int num1 = 20;
        int num2 = 0;
        this.Match(46);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("RANGE")]
    private void mRANGE()
    {
      try
      {
        int num1 = 52;
        int num2 = 0;
        this.Match("..");
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("AT")]
    private void mAT()
    {
      try
      {
        int num1 = 11;
        int num2 = 0;
        this.Match(64);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("POUND")]
    private void mPOUND()
    {
      try
      {
        int num1 = 47;
        int num2 = 0;
        this.Match(35);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("NOT")]
    private void mNOT()
    {
      try
      {
        int num1 = 39;
        int num2 = 0;
        this.Match(126);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("RBRACE")]
    private void mRBRACE()
    {
      try
      {
        int num1 = 54;
        int num2 = 0;
        this.Match(125);
        if (this.state.failed)
          return;
        this.state.type = num1;
        this.state.channel = num2;
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
        int num1 = 28;
        int num2 = 0;
        int charIndex = this.CharIndex;
        int line = this.Line;
        int charPositionInLine = this.CharPositionInLine;
        this.mNameStartChar();
        if (this.state.failed)
          return;
        CommonToken commonToken = new CommonToken(this.input, 0, 0, charIndex, this.CharIndex - 1);
        commonToken.Line = line;
        commonToken.CharPositionInLine = charPositionInLine;
        try
        {
          while (true)
          {
            int num3 = 2;
            try
            {
              int num4 = this.input.LA(1);
              if ((num4 < 48 || num4 > 57) && (num4 < 65 || num4 > 90) && num4 != 95 && (num4 < 97 || num4 > 122) && num4 != 183 && (num4 < 192 || num4 > 214) && (num4 < 216 || num4 > 246) && (num4 < 248 || num4 > 893) && (num4 < 895 || num4 > 8191) && (num4 < 8204 || num4 > 8205) && (num4 < 8255 || num4 > 8256) && (num4 < 8304 || num4 > 8591) && (num4 < 11264 || num4 > 12271) && (num4 < 12289 || num4 > 55295) && (num4 < 63744 || num4 > 64975) && (num4 < 65008 || num4 > 65278))
              {
                if (num4 >= 65280)
                {
                  if (num4 > 65533)
                    goto label_9;
                }
                else
                  goto label_9;
              }
              num3 = 1;
            }
            finally
            {
            }
label_9:
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
        if (this.state.backtracking == 0)
          num1 = !Grammar.IsTokenName(commonToken?.Text) ? 57 : 66;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("NameChar")]
    private void mNameChar()
    {
      try
      {
        if (this.input.LA(1) >= 48 && this.input.LA(1) <= 57 || this.input.LA(1) >= 65 && this.input.LA(1) <= 90 || this.input.LA(1) == 95 || this.input.LA(1) >= 97 && this.input.LA(1) <= 122 || this.input.LA(1) == 183 || this.input.LA(1) >= 192 && this.input.LA(1) <= 214 || this.input.LA(1) >= 216 && this.input.LA(1) <= 246 || this.input.LA(1) >= 248 && this.input.LA(1) <= 893 || this.input.LA(1) >= 895 && this.input.LA(1) <= 8191 || this.input.LA(1) >= 8204 && this.input.LA(1) <= 8205 || this.input.LA(1) >= 8255 && this.input.LA(1) <= 8256 || this.input.LA(1) >= 8304 && this.input.LA(1) <= 8591 || this.input.LA(1) >= 11264 && this.input.LA(1) <= 12271 || this.input.LA(1) >= 12289 && this.input.LA(1) <= 55295 || this.input.LA(1) >= 63744 && this.input.LA(1) <= 64975 || this.input.LA(1) >= 65008 && this.input.LA(1) <= 65278 || this.input.LA(1) >= 65280 && this.input.LA(1) <= 65533)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("NameStartChar")]
    private void mNameStartChar()
    {
      try
      {
        if (this.input.LA(1) >= 65 && this.input.LA(1) <= 90 || this.input.LA(1) >= 97 && this.input.LA(1) <= 122 || this.input.LA(1) >= 192 && this.input.LA(1) <= 214 || this.input.LA(1) >= 216 && this.input.LA(1) <= 246 || this.input.LA(1) >= 248 && this.input.LA(1) <= 767 || this.input.LA(1) >= 880 && this.input.LA(1) <= 893 || this.input.LA(1) >= 895 && this.input.LA(1) <= 8191 || this.input.LA(1) >= 8204 && this.input.LA(1) <= 8205 || this.input.LA(1) >= 8304 && this.input.LA(1) <= 8591 || this.input.LA(1) >= 11264 && this.input.LA(1) <= 12271 || this.input.LA(1) >= 12289 && this.input.LA(1) <= 55295 || this.input.LA(1) >= 63744 && this.input.LA(1) <= 64975 || this.input.LA(1) >= 65008 && this.input.LA(1) <= 65278 || this.input.LA(1) >= 65280 && this.input.LA(1) <= 65533)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("ACTION_CHAR_LITERAL")]
    private void mACTION_CHAR_LITERAL()
    {
      try
      {
        this.Match(39);
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            do
            {
              int num1 = 3;
              try
              {
                int num2 = this.input.LA(1);
                if (num2 == 92)
                {
                  int num3 = this.input.LA(2);
                  switch (num3)
                  {
                    case 39:
                      int num4 = this.input.LA(3);
                      // ISSUE: method pointer
                      // ISSUE: method pointer
                      // ISSUE: method pointer
                      num1 = num4 != 39 || !this.EvaluatePredicate(synpred5_ANTLRLexer_fragment) ? (num4 != 92 || !this.EvaluatePredicate(synpred5_ANTLRLexer_fragment) ? ((num4 < 0 || num4 > 38) && (num4 < 40 || num4 > 91) && (num4 < 93 || num4 > (int) ushort.MaxValue) || !this.EvaluatePredicate(synpred5_ANTLRLexer_fragment) ? 2 : 1) : 1) : 1;
                      break;
                    case 92:
                      this.input.LA(3);
                      // ISSUE: method pointer
                      num1 = !this.EvaluatePredicate(synpred5_ANTLRLexer_fragment) ? 2 : 1;
                      break;
                    default:
                      if ((num3 < 0 || num3 > 38) && (num3 < 40 || num3 > 91))
                      {
                        if (num3 >= 93)
                        {
                          if (num3 > (int) ushort.MaxValue)
                            break;
                        }
                        else
                          break;
                      }
                      this.input.LA(3);
                      // ISSUE: method pointer
                      num1 = !this.EvaluatePredicate(synpred5_ANTLRLexer_fragment) ? 2 : 1;
                      break;
                  }
                }
                else
                {
                  if ((num2 < 0 || num2 > 38) && (num2 < 40 || num2 > 91))
                  {
                    if (num2 >= 93)
                    {
                      if (num2 > (int) ushort.MaxValue)
                        goto label_16;
                    }
                    else
                      goto label_16;
                  }
                  num1 = 2;
                }
              }
              finally
              {
              }
label_16:
              switch (num1)
              {
                case 1:
                  this.mACTION_ESC();
                  continue;
                case 2:
                  goto label_19;
                default:
                  goto label_21;
              }
            }
            while (!this.state.failed);
            break;
label_19:
            this.input.Consume();
            this.state.failed = false;
          }
          return;
        }
        finally
        {
        }
label_21:
        this.Match(39);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    [GrammarRule("ACTION_STRING_LITERAL")]
    private void mACTION_STRING_LITERAL()
    {
      try
      {
        this.Match(34);
        if (this.state.failed)
          return;
        try
        {
          while (true)
          {
            do
            {
              int num1 = 3;
              try
              {
                int num2 = this.input.LA(1);
                if (num2 == 92)
                {
                  int num3 = this.input.LA(2);
                  switch (num3)
                  {
                    case 34:
                      int num4 = this.input.LA(3);
                      // ISSUE: method pointer
                      // ISSUE: method pointer
                      // ISSUE: method pointer
                      num1 = num4 != 34 || !this.EvaluatePredicate(synpred6_ANTLRLexer_fragment) ? (num4 != 92 || !this.EvaluatePredicate(synpred6_ANTLRLexer_fragment) ? ((num4 < 0 || num4 > 33) && (num4 < 35 || num4 > 91) && (num4 < 93 || num4 > (int) ushort.MaxValue) || !this.EvaluatePredicate(synpred6_ANTLRLexer_fragment) ? 2 : 1) : 1) : 1;
                      break;
                    case 92:
                      this.input.LA(3);
                      // ISSUE: method pointer
                      num1 = !this.EvaluatePredicate(synpred6_ANTLRLexer_fragment) ? 2 : 1;
                      break;
                    default:
                      if ((num3 < 0 || num3 > 33) && (num3 < 35 || num3 > 91))
                      {
                        if (num3 >= 93)
                        {
                          if (num3 > (int) ushort.MaxValue)
                            break;
                        }
                        else
                          break;
                      }
                      this.input.LA(3);
                      // ISSUE: method pointer
                      num1 = !this.EvaluatePredicate(synpred6_ANTLRLexer_fragment) ? 2 : 1;
                      break;
                  }
                }
                else
                {
                  if ((num2 < 0 || num2 > 33) && (num2 < 35 || num2 > 91))
                  {
                    if (num2 >= 93)
                    {
                      if (num2 > (int) ushort.MaxValue)
                        goto label_16;
                    }
                    else
                      goto label_16;
                  }
                  num1 = 2;
                }
              }
              finally
              {
              }
label_16:
              switch (num1)
              {
                case 1:
                  this.mACTION_ESC();
                  continue;
                case 2:
                  goto label_19;
                default:
                  goto label_21;
              }
            }
            while (!this.state.failed);
            break;
label_19:
            this.input.Consume();
            this.state.failed = false;
          }
          return;
        }
        finally
        {
        }
label_21:
        this.Match(34);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    [GrammarRule("ACTION_ESC")]
    private void mACTION_ESC()
    {
      try
      {
        this.Match(92);
        if (this.state.failed)
          return;
        this.MatchAny();
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    [GrammarRule("INT")]
    private void mINT()
    {
      try
      {
        int num1 = 30;
        int num2 = 0;
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
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                  num4 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num4 == 1)
            {
              this.input.Consume();
              this.state.failed = false;
              ++num3;
            }
            else
              break;
          }
          if (num3 < 1)
          {
            if (this.state.backtracking <= 0)
              throw new EarlyExitException(22, (IIntStream) this.input);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("SRC")]
    private void mSRC()
    {
      try
      {
        this.Match("src");
        if (this.state.failed)
          return;
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
                case 9:
                case 12:
                case 32:
                  num2 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num2 == 1)
            {
              this.input.Consume();
              this.state.failed = false;
              ++num1;
            }
            else
              break;
          }
          if (num1 < 1)
          {
            if (this.state.backtracking <= 0)
              throw new EarlyExitException(23, (IIntStream) this.input);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        int charIndex1 = this.CharIndex;
        int line1 = this.Line;
        int charPositionInLine1 = this.CharPositionInLine;
        this.mACTION_STRING_LITERAL();
        if (this.state.failed)
          return;
        CommonToken commonToken1 = new CommonToken(this.input, 0, 0, charIndex1, this.CharIndex - 1);
        commonToken1.Line = line1;
        commonToken1.CharPositionInLine = charPositionInLine1;
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
                case 9:
                case 12:
                case 32:
                  num4 = 1;
                  break;
              }
            }
            finally
            {
            }
            if (num4 == 1)
            {
              this.input.Consume();
              this.state.failed = false;
              ++num3;
            }
            else
              break;
          }
          if (num3 < 1)
          {
            if (this.state.backtracking <= 0)
              throw new EarlyExitException(24, (IIntStream) this.input);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        int charIndex2 = this.CharIndex;
        int line2 = this.Line;
        int charPositionInLine2 = this.CharPositionInLine;
        this.mINT();
        if (this.state.failed)
          return;
        CommonToken commonToken2 = new CommonToken(this.input, 0, 0, charIndex2, this.CharIndex - 1);
        commonToken2.Line = line2;
        commonToken2.CharPositionInLine = charPositionInLine2;
        int backtracking = this.state.backtracking;
      }
      finally
      {
      }
    }

    [GrammarRule("STRING_LITERAL")]
    private void mSTRING_LITERAL()
    {
      try
      {
        int num1 = 62;
        int num2 = 0;
        this.Match(39);
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
              if ((num4 < 0 || num4 > 9) && (num4 < 11 || num4 > 12) && (num4 < 14 || num4 > 38))
              {
                if (num4 >= 40)
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
              int num5 = 2;
              try
              {
                try
                {
                  int num6 = this.input.LA(1);
                  if (num6 == 92)
                    num5 = 1;
                  else if (num6 >= 0 && num6 <= 9 || num6 >= 11 && num6 <= 12 || num6 >= 14 && num6 <= 38 || num6 >= 40 && num6 <= 91 || num6 >= 93 && num6 <= (int) ushort.MaxValue)
                  {
                    num5 = 2;
                  }
                  else
                  {
                    if (this.state.backtracking <= 0)
                      throw new NoViableAltException("", 25, 0, (IIntStream) this.input, 1);
                    this.state.failed = true;
                    return;
                  }
                }
                finally
                {
                }
                switch (num5)
                {
                  case 1:
                    this.mESC_SEQ();
                    if (this.state.failed)
                      return;
                    continue;
                  case 2:
                    this.input.Consume();
                    this.state.failed = false;
                    continue;
                  default:
                    continue;
                }
              }
              finally
              {
              }
            }
            else
              break;
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
            num7 = this.input.LA(1) != 39 ? 2 : 1;
          }
          finally
          {
          }
          switch (num7)
          {
            case 1:
              this.Match(39);
              if (this.state.failed)
                return;
              break;
            case 2:
              if (this.state.backtracking == 0)
              {
                IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.state.tokenStartCharIndex, this.CharIndex - 1);
                token.Line = this.state.tokenStartLine;
                token.Text = this.state.text;
                token.CharPositionInLine = this.state.tokenStartCharPositionInLine;
                this.GrammarError(ErrorType.UNTERMINATED_STRING_LITERAL, token, new object[0]);
                break;
              }
              break;
          }
        }
        finally
        {
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("HEX_DIGIT")]
    private void mHEX_DIGIT()
    {
      try
      {
        if (this.input.LA(1) >= 48 && this.input.LA(1) <= 57 || this.input.LA(1) >= 65 && this.input.LA(1) <= 70 || this.input.LA(1) >= 97 && this.input.LA(1) <= 102)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("ESC_SEQ")]
    private void mESC_SEQ()
    {
      try
      {
        this.Match(92);
        if (this.state.failed)
          return;
        int num = 10;
        try
        {
          try
          {
            switch (this.input.LA(1))
            {
              case 34:
                num = 6;
                break;
              case 39:
                num = 7;
                break;
              case 92:
                num = 8;
                break;
              case 98:
                num = 1;
                break;
              case 102:
                num = 4;
                break;
              case 110:
                num = 3;
                break;
              case 114:
                num = 5;
                break;
              case 116:
                num = 2;
                break;
              case 117:
                num = 9;
                break;
              default:
                num = 10;
                break;
            }
          }
          finally
          {
          }
          switch (num)
          {
            case 1:
              this.Match(98);
              if (!this.state.failed)
                break;
              break;
            case 2:
              this.Match(116);
              if (!this.state.failed)
                break;
              break;
            case 3:
              this.Match(110);
              if (!this.state.failed)
                break;
              break;
            case 4:
              this.Match(102);
              if (!this.state.failed)
                break;
              break;
            case 5:
              this.Match(114);
              if (!this.state.failed)
                break;
              break;
            case 6:
              this.Match(34);
              if (!this.state.failed)
                break;
              break;
            case 7:
              this.Match(39);
              if (!this.state.failed)
                break;
              break;
            case 8:
              this.Match(92);
              if (!this.state.failed)
                break;
              break;
            case 9:
              this.mUNICODE_ESC();
              if (!this.state.failed)
                break;
              break;
            case 10:
              if (this.state.backtracking != 0)
                break;
              IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.CharIndex - 1, this.CharIndex);
              token.Text = token.Text;
              token.Line = this.input.Line;
              token.CharPositionInLine = this.input.CharPositionInLine - 1;
              this.GrammarError(ErrorType.INVALID_ESCAPE_SEQUENCE, token, new object[0]);
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

    [GrammarRule("UNICODE_ESC")]
    private void mUNICODE_ESC()
    {
      try
      {
        int num1 = 0;
        this.Match(117);
        if (this.state.failed)
          return;
        int num2 = 2;
        try
        {
          try
          {
            int num3 = this.input.LA(1);
            num2 = num3 >= 48 && num3 <= 57 || num3 >= 65 && num3 <= 70 || num3 >= 97 && num3 <= 102 ? 1 : 2;
          }
          finally
          {
          }
          if (num2 != 1)
          {
            if (num2 == 2)
              ;
          }
          else
          {
            this.mHEX_DIGIT();
            if (this.state.failed)
              return;
            if (this.state.backtracking == 0)
              ++num1;
            int num4 = 2;
            try
            {
              try
              {
                int num5 = this.input.LA(1);
                num4 = num5 >= 48 && num5 <= 57 || num5 >= 65 && num5 <= 70 || num5 >= 97 && num5 <= 102 ? 1 : 2;
              }
              finally
              {
              }
              if (num4 != 1)
              {
                if (num4 == 2)
                  ;
              }
              else
              {
                this.mHEX_DIGIT();
                if (this.state.failed)
                  return;
                if (this.state.backtracking == 0)
                  ++num1;
                int num6 = 2;
                try
                {
                  try
                  {
                    int num7 = this.input.LA(1);
                    num6 = num7 >= 48 && num7 <= 57 || num7 >= 65 && num7 <= 70 || num7 >= 97 && num7 <= 102 ? 1 : 2;
                  }
                  finally
                  {
                  }
                  if (num6 != 1)
                  {
                    if (num6 == 2)
                      ;
                  }
                  else
                  {
                    this.mHEX_DIGIT();
                    if (this.state.failed)
                      return;
                    if (this.state.backtracking == 0)
                      ++num1;
                    int num8 = 2;
                    try
                    {
                      try
                      {
                        int num9 = this.input.LA(1);
                        num8 = num9 >= 48 && num9 <= 57 || num9 >= 65 && num9 <= 70 || num9 >= 97 && num9 <= 102 ? 1 : 2;
                      }
                      finally
                      {
                      }
                      if (num8 != 1)
                      {
                        if (num8 == 2)
                          ;
                      }
                      else
                      {
                        this.mHEX_DIGIT();
                        if (this.state.failed)
                          return;
                        if (this.state.backtracking == 0)
                          ++num1;
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
        if (this.state.backtracking != 0 || num1 == 4)
          return;
        IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.CharIndex - 3 - num1, this.CharIndex - 1);
        token.Text = token.Text;
        token.Line = this.input.Line;
        token.CharPositionInLine = this.input.CharPositionInLine - num1 - 2;
        this.GrammarError(ErrorType.INVALID_ESCAPE_SEQUENCE, token, new object[0]);
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
        int num1 = 70;
        int num2 = 0;
        int num3 = 0;
        try
        {
          while (true)
          {
            int num4 = 2;
            try
            {
              int num5 = this.input.LA(1);
              if ((num5 < 9 || num5 > 10) && (num5 < 12 || num5 > 13))
              {
                if (num5 != 32)
                  goto label_6;
              }
              num4 = 1;
            }
            finally
            {
            }
label_6:
            if (num4 == 1)
            {
              this.input.Consume();
              this.state.failed = false;
              ++num3;
            }
            else
              break;
          }
          if (num3 < 1)
          {
            if (this.state.backtracking <= 0)
              throw new EarlyExitException(33, (IIntStream) this.input);
            this.state.failed = true;
            return;
          }
        }
        finally
        {
        }
        if (this.state.backtracking == 0)
          num2 = 99;
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("NLCHARS")]
    private void mNLCHARS()
    {
      try
      {
        if (this.input.LA(1) == 10 || this.input.LA(1) == 13)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("WSCHARS")]
    private void mWSCHARS()
    {
      try
      {
        if (this.input.LA(1) == 9 || this.input.LA(1) == 12 || this.input.LA(1) == 32)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("WSNLCHARS")]
    private void mWSNLCHARS()
    {
      try
      {
        if (this.input.LA(1) >= 9 && this.input.LA(1) <= 10 || this.input.LA(1) >= 12 && this.input.LA(1) <= 13 || this.input.LA(1) == 32)
        {
          this.input.Consume();
          this.state.failed = false;
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

    [GrammarRule("UnicodeBOM")]
    private void mUnicodeBOM()
    {
      try
      {
        int num1 = 69;
        int num2 = 0;
        this.Match(65279);
        if (this.state.failed)
          return;
        if (this.state.backtracking == 0)
          this.Skip();
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    [GrammarRule("ERRCHAR")]
    private void mERRCHAR()
    {
      try
      {
        int num1 = 21;
        int num2 = 0;
        this.MatchAny();
        if (this.state.failed)
          return;
        if (this.state.backtracking == 0)
        {
          IToken token = (IToken) new CommonToken(this.input, this.state.type, this.state.channel, this.state.tokenStartCharIndex, this.CharIndex - 1);
          token.Line = this.state.tokenStartLine;
          token.Text = this.state.text;
          token.CharPositionInLine = this.state.tokenStartCharPositionInLine;
          string str = this.GetTokenErrorDisplay(token) + " came as a complete surprise to me";
          this.GrammarError(ErrorType.SYNTAX_ERROR, token, new object[1]
          {
            (object) str
          });
          ++this.state.syntaxErrors;
          this.Skip();
        }
        this.state.type = num1;
        this.state.channel = num2;
      }
      finally
      {
      }
    }

    public override void mTokens()
    {
      int num1 = 50;
      try
      {
        num1 = this.dfa34.Predict((IIntStream) this.input);
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
          this.mCOMMENT();
          int num2 = this.state.failed ? 1 : 0;
          break;
        case 2:
          this.mARG_OR_CHARSET();
          int num3 = this.state.failed ? 1 : 0;
          break;
        case 3:
          this.mACTION();
          int num4 = this.state.failed ? 1 : 0;
          break;
        case 4:
          this.mOPTIONS();
          int num5 = this.state.failed ? 1 : 0;
          break;
        case 5:
          this.mTOKENS_SPEC();
          int num6 = this.state.failed ? 1 : 0;
          break;
        case 6:
          this.mCHANNELS();
          int num7 = this.state.failed ? 1 : 0;
          break;
        case 7:
          this.mIMPORT();
          int num8 = this.state.failed ? 1 : 0;
          break;
        case 8:
          this.mFRAGMENT();
          int num9 = this.state.failed ? 1 : 0;
          break;
        case 9:
          this.mLEXER();
          int num10 = this.state.failed ? 1 : 0;
          break;
        case 10:
          this.mPARSER();
          int num11 = this.state.failed ? 1 : 0;
          break;
        case 11:
          this.mGRAMMAR();
          int num12 = this.state.failed ? 1 : 0;
          break;
        case 12:
          this.mTREE_GRAMMAR();
          int num13 = this.state.failed ? 1 : 0;
          break;
        case 13:
          this.mPROTECTED();
          int num14 = this.state.failed ? 1 : 0;
          break;
        case 14:
          this.mPUBLIC();
          int num15 = this.state.failed ? 1 : 0;
          break;
        case 15:
          this.mPRIVATE();
          int num16 = this.state.failed ? 1 : 0;
          break;
        case 16:
          this.mRETURNS();
          int num17 = this.state.failed ? 1 : 0;
          break;
        case 17:
          this.mLOCALS();
          int num18 = this.state.failed ? 1 : 0;
          break;
        case 18:
          this.mTHROWS();
          int num19 = this.state.failed ? 1 : 0;
          break;
        case 19:
          this.mCATCH();
          int num20 = this.state.failed ? 1 : 0;
          break;
        case 20:
          this.mFINALLY();
          int num21 = this.state.failed ? 1 : 0;
          break;
        case 21:
          this.mMODE();
          int num22 = this.state.failed ? 1 : 0;
          break;
        case 22:
          this.mCOLON();
          int num23 = this.state.failed ? 1 : 0;
          break;
        case 23:
          this.mCOLONCOLON();
          int num24 = this.state.failed ? 1 : 0;
          break;
        case 24:
          this.mCOMMA();
          int num25 = this.state.failed ? 1 : 0;
          break;
        case 25:
          this.mSEMI();
          int num26 = this.state.failed ? 1 : 0;
          break;
        case 26:
          this.mLPAREN();
          int num27 = this.state.failed ? 1 : 0;
          break;
        case 27:
          this.mRPAREN();
          int num28 = this.state.failed ? 1 : 0;
          break;
        case 28:
          this.mRARROW();
          int num29 = this.state.failed ? 1 : 0;
          break;
        case 29:
          this.mLT();
          int num30 = this.state.failed ? 1 : 0;
          break;
        case 30:
          this.mGT();
          int num31 = this.state.failed ? 1 : 0;
          break;
        case 31:
          this.mASSIGN();
          int num32 = this.state.failed ? 1 : 0;
          break;
        case 32:
          this.mQUESTION();
          int num33 = this.state.failed ? 1 : 0;
          break;
        case 33:
          this.mSYNPRED();
          int num34 = this.state.failed ? 1 : 0;
          break;
        case 34:
          this.mSTAR();
          int num35 = this.state.failed ? 1 : 0;
          break;
        case 35:
          this.mPLUS();
          int num36 = this.state.failed ? 1 : 0;
          break;
        case 36:
          this.mPLUS_ASSIGN();
          int num37 = this.state.failed ? 1 : 0;
          break;
        case 37:
          this.mOR();
          int num38 = this.state.failed ? 1 : 0;
          break;
        case 38:
          this.mDOLLAR();
          int num39 = this.state.failed ? 1 : 0;
          break;
        case 39:
          this.mDOT();
          int num40 = this.state.failed ? 1 : 0;
          break;
        case 40:
          this.mRANGE();
          int num41 = this.state.failed ? 1 : 0;
          break;
        case 41:
          this.mAT();
          int num42 = this.state.failed ? 1 : 0;
          break;
        case 42:
          this.mPOUND();
          int num43 = this.state.failed ? 1 : 0;
          break;
        case 43:
          this.mNOT();
          int num44 = this.state.failed ? 1 : 0;
          break;
        case 44:
          this.mRBRACE();
          int num45 = this.state.failed ? 1 : 0;
          break;
        case 45:
          this.mID();
          int num46 = this.state.failed ? 1 : 0;
          break;
        case 46:
          this.mINT();
          int num47 = this.state.failed ? 1 : 0;
          break;
        case 47:
          this.mSTRING_LITERAL();
          int num48 = this.state.failed ? 1 : 0;
          break;
        case 48:
          this.mWS();
          int num49 = this.state.failed ? 1 : 0;
          break;
        case 49:
          this.mUnicodeBOM();
          int num50 = this.state.failed ? 1 : 0;
          break;
        case 50:
          this.mERRCHAR();
          int num51 = this.state.failed ? 1 : 0;
          break;
      }
    }

    private void synpred1_ANTLRLexer_fragment()
    {
      try
      {
        this.Match(" $ANTLR");
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred2_ANTLRLexer_fragment()
    {
      try
      {
        this.Match(34);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred3_ANTLRLexer_fragment()
    {
      try
      {
        this.Match(39);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred4_ANTLRLexer_fragment()
    {
      try
      {
        try
        {
          while (true)
          {
            int num1 = 2;
            try
            {
              int num2 = this.input.LA(1);
              if ((num2 < 9 || num2 > 10) && (num2 < 12 || num2 > 13))
              {
                if (num2 != 32)
                  goto label_5;
              }
              num1 = 1;
            }
            finally
            {
            }
label_5:
            if (num1 == 1)
            {
              if (this.input.LA(1) >= 9 && this.input.LA(1) <= 10 || this.input.LA(1) >= 12 && this.input.LA(1) <= 13 || this.input.LA(1) == 32)
              {
                this.input.Consume();
                this.state.failed = false;
              }
              else
                break;
            }
            else
              goto label_12;
          }
          if (this.state.backtracking > 0)
          {
            this.state.failed = true;
            return;
          }
          MismatchedSetException re = new MismatchedSetException((BitSet) null, (IIntStream) this.input);
          this.Recover((RecognitionException) re);
          throw re;
        }
        finally
        {
        }
label_12:
        this.Match("=>");
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred5_ANTLRLexer_fragment()
    {
      try
      {
        this.Match(92);
        int num = this.state.failed ? 1 : 0;
      }
      finally
      {
      }
    }

    private void synpred6_ANTLRLexer_fragment()
    {
      try
      {
        this.Match(92);
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
      // ISSUE: method pointer
      this.dfa2 = new ANTLRLexer.DFA2((BaseRecognizer) this, new SpecialStateTransitionHandler(SpecialStateTransition2));
      // ISSUE: method pointer
      this.dfa34 = new ANTLRLexer.DFA34((BaseRecognizer) this, new SpecialStateTransitionHandler(SpecialStateTransition34));
    }

    private int SpecialStateTransition2(DFA dfa, int s, IIntStream _input)
    {
      IIntStream input = _input;
      int stateNumber = s;
      s = -1;
      int num = input.LA(1);
      int index = input.Index;
      switch (stateNumber)
      {
        case 0:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 92 ? (num >= 0 && num <= 9 || num >= 11 && num <= 12 || num >= 14 && num <= 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 15 : (num != 34 ? (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 17) : 16)) : 14;
          input.Seek(index);
          break;
        case 1:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num >= 0 && num <= 9 || num >= 11 && num <= 12 || num >= 14 && num <= 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 20 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 21)) : 19) : 18;
          input.Seek(index);
          break;
        case 2:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num >= 0 && num <= 9 || num >= 11 && num <= 12 || num >= 14 && num <= 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 15 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 17)) : 14) : 16;
          input.Seek(index);
          break;
        case 3:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num == 9 || num == 12 || num == 32 ? 23 : (num >= 0 && num <= 8 || num == 11 || num >= 14 && num <= 31 || num == 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 15 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 17))) : 14) : 16;
          input.Seek(index);
          break;
        case 4:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num >= 0 && num <= 9 || num >= 11 && num <= 12 || num >= 14 && num <= 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 20 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 21)) : 19) : 18;
          input.Seek(index);
          break;
        case 5:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num >= 0 && num <= 9 || num >= 11 && num <= 12 || num >= 14 && num <= 33 || num >= 35 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 15 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 17)) : 14) : 16;
          input.Seek(index);
          break;
        case 6:
          input.Rewind();
          // ISSUE: method pointer
          s = num != 34 ? (num != 92 ? (num < 48 || num > 57 ? (num == 9 || num == 12 || num == 32 ? 23 : (num >= 0 && num <= 8 || num == 11 || num >= 14 && num <= 31 || num == 33 || num >= 35 && num <= 47 || num >= 58 && num <= 91 || num >= 93 && num <= (int) ushort.MaxValue ? 15 : (num != 10 && num != 13 || !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 17))) : 25) : 14) : 16;
          input.Seek(index);
          break;
        case 7:
          input.Rewind();
          // ISSUE: method pointer
          s = !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 21;
          input.Seek(index);
          break;
        case 8:
          input.Rewind();
          // ISSUE: method pointer
          s = !this.EvaluatePredicate(synpred1_ANTLRLexer_fragment) ? 2 : 21;
          input.Seek(index);
          break;
      }
      if (s >= 0)
        return s;
      if (this.state.backtracking > 0)
      {
        this.state.failed = true;
        return -1;
      }
      NoViableAltException nvae = new NoViableAltException(dfa.Description, 2, stateNumber, input);
      dfa.Error(nvae);
      throw nvae;
    }

    private int SpecialStateTransition34(DFA dfa, int s, IIntStream _input)
    {
      IIntStream input = _input;
      int stateNumber = s;
      s = -1;
      int num = input.LA(1);
      int index = input.Index;
      switch (stateNumber)
      {
        case 0:
          switch (num)
          {
            case 35:
              s = 30;
              break;
            case 36:
              s = 27;
              break;
            case 40:
              s = 17;
              break;
            case 41:
              s = 18;
              break;
            case 42:
              s = 24;
              break;
            case 43:
              s = 25;
              break;
            case 44:
              s = 15;
              break;
            case 45:
              s = 19;
              break;
            case 46:
              s = 28;
              break;
            case 47:
              s = 1;
              break;
            case 58:
              s = 14;
              break;
            case 59:
              s = 16;
              break;
            case 60:
              s = 20;
              break;
            case 61:
              s = 22;
              break;
            case 62:
              s = 21;
              break;
            case 63:
              s = 23;
              break;
            case 64:
              s = 29;
              break;
            case 91:
              s = 2;
              break;
            case 99:
              s = 6;
              break;
            case 102:
              s = 8;
              break;
            case 103:
              s = 11;
              break;
            case 105:
              s = 7;
              break;
            case 108:
              s = 9;
              break;
            case 109:
              s = 13;
              break;
            case 111:
              s = 4;
              break;
            case 112:
              s = 10;
              break;
            case 114:
              s = 12;
              break;
            case 116:
              s = 5;
              break;
            case 123:
              s = 3;
              break;
            case 124:
              s = 26;
              break;
            case 125:
              s = 32;
              break;
            case 126:
              s = 31;
              break;
            default:
              if (num >= 65 && num <= 90 || num >= 97 && num <= 98 || num >= 100 && num <= 101 || num == 104 || num >= 106 && num <= 107 || num == 110 || num == 113 || num == 115 || num >= 117 && num <= 122 || num >= 192 && num <= 214 || num >= 216 && num <= 246 || num >= 248 && num <= 767 || num >= 880 && num <= 893 || num >= 895 && num <= 8191 || num >= 8204 && num <= 8205 || num >= 8304 && num <= 8591 || num >= 11264 && num <= 12271 || num >= 12289 && num <= 55295 || num >= 63744 && num <= 64975 || num >= 65008 && num <= 65278 || num >= 65280 && num <= 65533)
              {
                s = 33;
                break;
              }
              if (num >= 48 && num <= 57)
              {
                s = 34;
                break;
              }
              if (num == 39)
              {
                s = 35;
                break;
              }
              if (num >= 9 && num <= 10 || num >= 12 && num <= 13 || num == 32)
              {
                s = 36;
                break;
              }
              if (num == 65279)
              {
                s = 37;
                break;
              }
              if (num >= 0 && num <= 8 || num == 11 || num >= 14 && num <= 31 || num >= 33 && num <= 34 || num >= 37 && num <= 38 || num >= 92 && num <= 96 || num >= (int) sbyte.MaxValue && num <= 191 || num == 215 || num == 247 || num >= 768 && num <= 879 || num == 894 || num >= 8192 && num <= 8203 || num >= 8206 && num <= 8303 || num >= 8592 && num <= 11263 || num >= 12272 && num <= 12288 || num >= 55296 && num <= 63743 || num >= 64976 && num <= 65007 || num >= 65534 && num <= (int) ushort.MaxValue)
              {
                s = 38;
                break;
              }
              break;
          }
          break;
        case 1:
          input.Rewind();
          s = (num < 0 || num > 9) && (num < 11 || num > 12) && (num < 14 || num > (int) ushort.MaxValue) || !this.isLexerRule && this.isLexerRule ? (num != 10 && num != 13 || this.isLexerRule ? 38 : 41) : 40;
          input.Seek(index);
          break;
      }
      if (s >= 0)
        return s;
      if (this.state.backtracking > 0)
      {
        this.state.failed = true;
        return -1;
      }
      NoViableAltException nvae = new NoViableAltException(dfa.Description, 34, stateNumber, input);
      dfa.Error(nvae);
      throw nvae;
    }

    static ANTLRLexer()
    {
      ANTLRLexer.COMMENTS_CHANNEL = 2;
    }

    private class DFA2 : DFA
    {
      private const string DFA2_eotS = "\u0002\u0002\u0001\uFFFF\u000E\u0002\u0001\uFFFF\u0003\u0002\u0001\uFFFF\u0002\u0002\u0002\uFFFF";
      private const string DFA2_eofS = "\u001A\uFFFF";
      private const string DFA2_minS = "\u0001 \u0001$\u0001\uFFFF\u0001A\u0001N\u0001T\u0001L\u0001R\u0001s\u0001r\u0001c\u0002\t\u0003\0\u0001\t\u0001\uFFFF\u0003\0\u0001\uFFFF\u0001\t\u0003\0";
      private const string DFA2_maxS = "\u0001 \u0001$\u0001\uFFFF\u0001A\u0001N\u0001T\u0001L\u0001R\u0001s\u0001r\u0001c\u0001 \u0001\"\u0003\uFFFF\u0001 \u0001\uFFFF\u0003\uFFFF\u0001\uFFFF\u00019\u0001\uFFFF\u0002\0";
      private const string DFA2_acceptS = "\u0002\uFFFF\u0001\u0002\u000E\uFFFF\u0001\u0001\u0003\uFFFF\u0001\u0001\u0004\uFFFF";
      private const string DFA2_specialS = "\r\uFFFF\u0001\0\u0001\u0001\u0001\u0002\u0002\uFFFF\u0001\u0003\u0001\u0004\u0001\u0005\u0002\uFFFF\u0001\u0006\u0001\a\u0001\b}>";
      private static readonly string[] DFA2_transitionS;
      private static readonly short[] DFA2_eot;
      private static readonly short[] DFA2_eof;
      private static readonly char[] DFA2_min;
      private static readonly char[] DFA2_max;
      private static readonly short[] DFA2_accept;
      private static readonly short[] DFA2_special;
      private static readonly short[][] DFA2_transition;

      static DFA2()
      {
        ANTLRLexer.DFA2.DFA2_transitionS = new string[26]
        {
          "\u0001\u0001",
          "\u0001\u0003",
          "",
          "\u0001\u0004",
          "\u0001\u0005",
          "\u0001\u0006",
          "\u0001\a",
          "\u0001\b",
          "\u0001\t",
          "\u0001\n",
          "\u0001\v",
          "\u0001\f\u0002\uFFFF\u0001\f\u0013\uFFFF\u0001\f",
          "\u0001\f\u0002\uFFFF\u0001\f\u0013\uFFFF\u0001\f\u0001\uFFFF\u0001\r",
          "\n\u000F\u0001\u0011\u0002\u000F\u0001\u0011\u0014\u000F\u0001\u00109\u000F\u0001\u000Eﾣ\u000F",
          "\n\u0014\u0001\u0015\u0002\u0014\u0001\u0015\u0014\u0014\u0001\u00129\u0014\u0001\u0013ﾣ\u0014",
          "\n\u000F\u0001\u0011\u0002\u000F\u0001\u0011\u0014\u000F\u0001\u00109\u000F\u0001\u000Eﾣ\u000F",
          "\u0001\u0016\u0002\uFFFF\u0001\u0016\u0013\uFFFF\u0001\u0016",
          "",
          "\t\u000F\u0001\u0017\u0001\u0011\u0001\u000F\u0001\u0017\u0001\u0011\u0012\u000F\u0001\u0017\u0001\u000F\u0001\u00109\u000F\u0001\u000Eﾣ\u000F",
          "\n\u0014\u0001\u0015\u0002\u0014\u0001\u0015\u0014\u0014\u0001\u00129\u0014\u0001\u0013ﾣ\u0014",
          "\n\u000F\u0001\u0011\u0002\u000F\u0001\u0011\u0014\u000F\u0001\u00109\u000F\u0001\u000Eﾣ\u000F",
          "",
          "\u0001\u0016\u0002\uFFFF\u0001\u0016\u0013\uFFFF\u0001\u0016\u000F\uFFFF\n\u0018",
          "\t\u000F\u0001\u0017\u0001\u0011\u0001\u000F\u0001\u0017\u0001\u0011\u0012\u000F\u0001\u0017\u0001\u000F\u0001\u0010\r\u000F\n\u0019\"\u000F\u0001\u000Eﾣ\u000F",
          "\u0001\uFFFF",
          "\u0001\uFFFF"
        };
        ANTLRLexer.DFA2.DFA2_eot = DFA.UnpackEncodedString("\u0002\u0002\u0001\uFFFF\u000E\u0002\u0001\uFFFF\u0003\u0002\u0001\uFFFF\u0002\u0002\u0002\uFFFF");
        ANTLRLexer.DFA2.DFA2_eof = DFA.UnpackEncodedString("\u001A\uFFFF");
        ANTLRLexer.DFA2.DFA2_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001 \u0001$\u0001\uFFFF\u0001A\u0001N\u0001T\u0001L\u0001R\u0001s\u0001r\u0001c\u0002\t\u0003\0\u0001\t\u0001\uFFFF\u0003\0\u0001\uFFFF\u0001\t\u0003\0");
        ANTLRLexer.DFA2.DFA2_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001 \u0001$\u0001\uFFFF\u0001A\u0001N\u0001T\u0001L\u0001R\u0001s\u0001r\u0001c\u0001 \u0001\"\u0003\uFFFF\u0001 \u0001\uFFFF\u0003\uFFFF\u0001\uFFFF\u00019\u0001\uFFFF\u0002\0");
        ANTLRLexer.DFA2.DFA2_accept = DFA.UnpackEncodedString("\u0002\uFFFF\u0001\u0002\u000E\uFFFF\u0001\u0001\u0003\uFFFF\u0001\u0001\u0004\uFFFF");
        ANTLRLexer.DFA2.DFA2_special = DFA.UnpackEncodedString("\r\uFFFF\u0001\0\u0001\u0001\u0001\u0002\u0002\uFFFF\u0001\u0003\u0001\u0004\u0001\u0005\u0002\uFFFF\u0001\u0006\u0001\a\u0001\b}>");
        int length = ANTLRLexer.DFA2.DFA2_transitionS.Length;
        ANTLRLexer.DFA2.DFA2_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          ANTLRLexer.DFA2.DFA2_transition[index] = DFA.UnpackEncodedString(ANTLRLexer.DFA2.DFA2_transitionS[index]);
      }

      public DFA2(
        BaseRecognizer recognizer,
        SpecialStateTransitionHandler specialStateTransition): base(specialStateTransition)
      {
        
        this.recognizer = recognizer;
        this.decisionNumber = 2;
        this.eot = ANTLRLexer.DFA2.DFA2_eot;
        this.eof = ANTLRLexer.DFA2.DFA2_eof;
        this.min = ANTLRLexer.DFA2.DFA2_min;
        this.max = ANTLRLexer.DFA2.DFA2_max;
        this.accept = ANTLRLexer.DFA2.DFA2_accept;
        this.special = ANTLRLexer.DFA2.DFA2_special;
        this.transition = ANTLRLexer.DFA2.DFA2_transition;
      }

      public override string Description
      {
        get
        {
          return "164:13: ( ( ' $ANTLR' )=> ' $ANTLR' SRC | (~ ( NLCHARS ) )* )";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }

    private class DFA34 : DFA
    {
      private const string DFA34_eotS = "\u0002\uFFFF\u0001&\u0001\uFFFF\n,\u0001>\u0004\uFFFF\u0001&\u0002\uFFFF\u0001G\u0002\uFFFF\u0001K\u0002\uFFFF\u0001O\u000E\uFFFF\u0001,\u0001\uFFFF\u0010,\u001B\uFFFF#,\u0001\u008E\u0002,\u0001\uFFFF\u0003,\u0001\u0094\u0003,\u0001\u0098\a,\u0001\uFFFF\u0003,\u0001£\u0001,\u0001\uFFFF\u0001¥\u0002,\u0001\uFFFF\u0001¨\u0001©\u0002,\u0001¬\u0003,\u0001\uFFFF\u0001,\u0001\uFFFF\u0001,\u0001\uFFFF\u0001,\u0001\u00B3\u0002\uFFFF\u0001,\u0001µ\u0001\uFFFF\u0001¶\u0001·\u0001\uFFFF\u0002,\u0001º\u0001\uFFFF\u0001,\u0003\uFFFF\u0001,\u0002\uFFFF\u0001\u00BD\u0001,\u0001\uFFFF\u0001~";
      private const string DFA34_eofS = "¿\uFFFF";
      private const string DFA34_minS = "\u0001\0\u0001\uFFFF\u0001\0\u0001\uFFFF\u0001p\u0001h\u0001a\u0001m\u0001i\u0001e\u0001a\u0001r\u0001e\u0001o\u0001:\u0004\uFFFF\u0001>\u0002\uFFFF\u0001>\u0002\uFFFF\u0001=\u0002\uFFFF\u0001.\u000E\uFFFF\u0001t\u0001\uFFFF\u0001k\u0001e\u0001r\u0001a\u0001t\u0001p\u0001a\u0001n\u0001x\u0001c\u0001r\u0001i\u0001b\u0001a\u0001t\u0001d\u001B\uFFFF\u0001i\u0002e\u0001o\u0001n\u0001c\u0001o\u0001g\u0001a\u0001e\u0001a\u0001s\u0001t\u0001v\u0001l\u0001m\u0001u\u0001e\u0001o\u0001n\u0001\t\u0001w\u0001n\u0001h\u0001r\u0001m\u0001l\u0001r\u0001l\u0002e\u0001a\u0001i\u0001m\u0001r\u00010\u0001n\u0001s\u0001\uFFFF\u0001r\u0001s\u0001e\u00010\u0001t\u0001e\u0001l\u00010\u0001s\u0001r\u0001c\u0001t\u0001c\u0001a\u0001n\u0001\uFFFF\u0001s\u0001\t\u0001a\u00010\u0001l\u0001\uFFFF\u00010\u0001n\u0001y\u0001\uFFFF\u00020\u0001t\u0001e\u00010\u0001r\u0001s\u0001\t\u0001\uFFFF\u0001m\u0001\uFFFF\u0001s\u0001\uFFFF\u0001t\u00010\u0002\uFFFF\u0001e\u00010\u0001\uFFFF\u00020\u0001\uFFFF\u0001m\u0001\t\u00010\u0001\uFFFF\u0001d\u0003\uFFFF\u0001a\u0002\uFFFF\u00010\u0001r\u0001\uFFFF\u00010";
      private const string DFA34_maxS = "\u0001\uFFFF\u0001\uFFFF\u0001\uFFFF\u0001\uFFFF\u0001p\u0001r\u0001h\u0001m\u0001r\u0001o\u0001u\u0001r\u0001e\u0001o\u0001:\u0004\uFFFF\u0001>\u0002\uFFFF\u0001>\u0002\uFFFF\u0001=\u0002\uFFFF\u0001.\u000E\uFFFF\u0001t\u0001\uFFFF\u0001k\u0001e\u0001r\u0001a\u0001t\u0001p\u0001a\u0001n\u0001x\u0001c\u0001r\u0001o\u0001b\u0001a\u0001t\u0001d\u001B\uFFFF\u0001i\u0002e\u0001o\u0001n\u0001c\u0001o\u0001g\u0001a\u0001e\u0001a\u0001s\u0001t\u0001v\u0001l\u0001m\u0001u\u0001e\u0001o\u0001n\u0001g\u0001w\u0001n\u0001h\u0001r\u0001m\u0001l\u0001r\u0001l\u0002e\u0001a\u0001i\u0001m\u0001r\u0001�\u0001n\u0001s\u0001\uFFFF\u0001r\u0001s\u0001e\u0001�\u0001t\u0001e\u0001l\u0001�\u0001s\u0001r\u0001c\u0001t\u0001c\u0001a\u0001n\u0001\uFFFF\u0001s\u0001{\u0001a\u0001�\u0001l\u0001\uFFFF\u0001�\u0001n\u0001y\u0001\uFFFF\u0002�\u0001t\u0001e\u0001�\u0001r\u0001s\u0001{\u0001\uFFFF\u0001m\u0001\uFFFF\u0001s\u0001\uFFFF\u0001t\u0001�\u0002\uFFFF\u0001e\u0001�\u0001\uFFFF\u0002�\u0001\uFFFF\u0001m\u0001{\u0001�\u0001\uFFFF\u0001d\u0003\uFFFF\u0001a\u0002\uFFFF\u0001�\u0001r\u0001\uFFFF\u0001�";
      private const string DFA34_acceptS = "\u0001\uFFFF\u0001\u0001\u0001\uFFFF\u0001\u0003\v\uFFFF\u0001\u0018\u0001\u0019\u0001\u001A\u0001\u001B\u0001\uFFFF\u0001\u001D\u0001\u001E\u0001\uFFFF\u0001 \u0001\"\u0001\uFFFF\u0001%\u0001&\u0001\uFFFF\u0001)\u0001*\u0001+\u0001,\u0001-\u0001.\u0001/\u00010\u00011\u00012\u0001\u0001\u0002\u0002\u0001\u0003\u0001\uFFFF\u0001-\u0010\uFFFF\u0001\u0017\u0001\u0016\u0001\u0018\u0001\u0019\u0001\u001A\u0001\u001B\u0001\u001C\u0001\u001D\u0001\u001E\u0001!\u0001\u001F\u0001 \u0001\"\u0001$\u0001#\u0001%\u0001&\u0001(\u0001'\u0001)\u0001*\u0001+\u0001,\u0001.\u0001/\u00010\u00011&\uFFFF\u0001\f\u000F\uFFFF\u0001\u0015\u0005\uFFFF\u0001\u0013\u0003\uFFFF\u0001\t\b\uFFFF\u0001\u0005\u0001\uFFFF\u0001\u0012\u0001\uFFFF\u0001\a\u0002\uFFFF\u0001\u0011\u0001\n\u0002\uFFFF\u0001\u000E\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0014\u0001\uFFFF\u0001\u000F\u0001\v\u0001\u0010\u0001\uFFFF\u0001\u0006\u0001\b\u0002\uFFFF\u0001\r\u0001\uFFFF";
      private const string DFA34_specialS = "\u0001\0\u0001\uFFFF\u0001\u0001\u00BC\uFFFF}>";
      private static readonly string[] DFA34_transitionS;
      private static readonly short[] DFA34_eot;
      private static readonly short[] DFA34_eof;
      private static readonly char[] DFA34_min;
      private static readonly char[] DFA34_max;
      private static readonly short[] DFA34_accept;
      private static readonly short[] DFA34_special;
      private static readonly short[][] DFA34_transition;

      static DFA34()
      {
        ANTLRLexer.DFA34.DFA34_transitionS = new string[191]
        {
          "\t&\u0002$\u0001&\u0002$\u0012&\u0001$\u0002&\u0001\u001E\u0001\u001B\u0002&\u0001#\u0001\u0011\u0001\u0012\u0001\u0018\u0001\u0019\u0001\u000F\u0001\u0013\u0001\u001C\u0001\u0001\n\"\u0001\u000E\u0001\u0010\u0001\u0014\u0001\u0016\u0001\u0015\u0001\u0017\u0001\u001D\u001A!\u0001\u0002\u0005&\u0002!\u0001\u0006\u0002!\u0001\b\u0001\v\u0001!\u0001\a\u0002!\u0001\t\u0001\r\u0001!\u0001\u0004\u0001\n\u0001!\u0001\f\u0001!\u0001\u0005\u0006!\u0001\u0003\u0001\u001A\u0001 \u0001\u001FA&\u0017!\u0001&\u001F!\u0001&Ȉ!p&\u000E!\u0001&\u1C81!\f&\u0002!b&Ġ!ੰ&ϰ!\u0011&ꟿ!℀&Ӑ! &ď!\u0001%þ!\u0002&",
          "",
          "\n(\u0001)\u0002(\u0001)\uFFF2(",
          "",
          "\u0001+",
          "\u0001/\u0006\uFFFF\u0001-\u0002\uFFFF\u0001.",
          "\u00011\u0006\uFFFF\u00010",
          "\u00012",
          "\u00014\b\uFFFF\u00013",
          "\u00015\t\uFFFF\u00016",
          "\u00017\u0010\uFFFF\u00018\u0002\uFFFF\u00019",
          "\u0001:",
          "\u0001;",
          "\u0001<",
          "\u0001=",
          "",
          "",
          "",
          "",
          "\u0001C",
          "",
          "",
          "\u0001F",
          "",
          "",
          "\u0001J",
          "",
          "",
          "\u0001N",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "\u0001X",
          "",
          "\u0001Y",
          "\u0001Z",
          "\u0001[",
          "\u0001\\",
          "\u0001]",
          "\u0001^",
          "\u0001_",
          "\u0001`",
          "\u0001a",
          "\u0001b",
          "\u0001c",
          "\u0001e\u0005\uFFFF\u0001d",
          "\u0001f",
          "\u0001g",
          "\u0001h",
          "\u0001i",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          "\u0001j",
          "\u0001k",
          "\u0001l",
          "\u0001m",
          "\u0001n",
          "\u0001o",
          "\u0001p",
          "\u0001q",
          "\u0001r",
          "\u0001s",
          "\u0001t",
          "\u0001u",
          "\u0001v",
          "\u0001w",
          "\u0001x",
          "\u0001y",
          "\u0001z",
          "\u0001{",
          "\u0001|",
          "\u0001}",
          "\u0002~\u0001\uFFFF\u0002~\u0012\uFFFF\u0001~F\uFFFF\u0001\u007F",
          "\u0001\u0080",
          "\u0001\u0081",
          "\u0001\u0082",
          "\u0001\u0083",
          "\u0001\u0084",
          "\u0001\u0085",
          "\u0001\u0086",
          "\u0001\u0087",
          "\u0001\u0088",
          "\u0001\u0089",
          "\u0001\u008A",
          "\u0001\u008B",
          "\u0001\u008C",
          "\u0001\u008D",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001\u008F",
          "\u0001\u0090",
          "",
          "\u0001\u0091",
          "\u0001\u0092",
          "\u0001\u0093",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001\u0095",
          "\u0001\u0096",
          "\u0001\u0097",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001\u0099",
          "\u0001\u009A",
          "\u0001\u009B",
          "\u0001\u009C",
          "\u0001\u009D",
          "\u0001\u009E",
          "\u0001\u009F",
          "",
          "\u0001 ",
          "\u0002¡\u0001\uFFFF\u0002¡\u0012\uFFFF\u0001¡Z\uFFFF\u0001¡",
          "\u0001¢",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001¤",
          "",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001¦",
          "\u0001§",
          "",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001ª",
          "\u0001«",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001\u00AD",
          "\u0001®",
          "\u0002¯\u0001\uFFFF\u0002¯\u0012\uFFFF\u0001¯Z\uFFFF\u0001¯",
          "",
          "\u0001°",
          "",
          "\u0001±",
          "",
          "\u0001\u00B2",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "",
          "",
          "\u0001´",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "",
          "\u0001¸",
          "\u0002\u00B9\u0001\uFFFF\u0002\u00B9\u0012\uFFFF\u0001\u00B9Z\uFFFF\u0001\u00B9",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "",
          "\u0001»",
          "",
          "",
          "",
          "\u0001\u00BC",
          "",
          "",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,",
          "\u0001\u00BE",
          "",
          "\n,\a\uFFFF\u001A,\u0004\uFFFF\u0001,\u0001\uFFFF\u001A,<\uFFFF\u0001,\b\uFFFF\u0017,\u0001\uFFFF\u001F,\u0001\uFFFFʆ,\u0001\uFFFF\u1C81,\f\uFFFF\u0002,1\uFFFF\u0002,/\uFFFFĠ,ੰ\uFFFFϰ,\u0011\uFFFFꟿ,℀\uFFFFӐ, \uFFFFď,\u0001\uFFFFþ,"
        };
        ANTLRLexer.DFA34.DFA34_eot = DFA.UnpackEncodedString("\u0002\uFFFF\u0001&\u0001\uFFFF\n,\u0001>\u0004\uFFFF\u0001&\u0002\uFFFF\u0001G\u0002\uFFFF\u0001K\u0002\uFFFF\u0001O\u000E\uFFFF\u0001,\u0001\uFFFF\u0010,\u001B\uFFFF#,\u0001\u008E\u0002,\u0001\uFFFF\u0003,\u0001\u0094\u0003,\u0001\u0098\a,\u0001\uFFFF\u0003,\u0001£\u0001,\u0001\uFFFF\u0001¥\u0002,\u0001\uFFFF\u0001¨\u0001©\u0002,\u0001¬\u0003,\u0001\uFFFF\u0001,\u0001\uFFFF\u0001,\u0001\uFFFF\u0001,\u0001\u00B3\u0002\uFFFF\u0001,\u0001µ\u0001\uFFFF\u0001¶\u0001·\u0001\uFFFF\u0002,\u0001º\u0001\uFFFF\u0001,\u0003\uFFFF\u0001,\u0002\uFFFF\u0001\u00BD\u0001,\u0001\uFFFF\u0001~");
        ANTLRLexer.DFA34.DFA34_eof = DFA.UnpackEncodedString("¿\uFFFF");
        ANTLRLexer.DFA34.DFA34_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\0\u0001\uFFFF\u0001\0\u0001\uFFFF\u0001p\u0001h\u0001a\u0001m\u0001i\u0001e\u0001a\u0001r\u0001e\u0001o\u0001:\u0004\uFFFF\u0001>\u0002\uFFFF\u0001>\u0002\uFFFF\u0001=\u0002\uFFFF\u0001.\u000E\uFFFF\u0001t\u0001\uFFFF\u0001k\u0001e\u0001r\u0001a\u0001t\u0001p\u0001a\u0001n\u0001x\u0001c\u0001r\u0001i\u0001b\u0001a\u0001t\u0001d\u001B\uFFFF\u0001i\u0002e\u0001o\u0001n\u0001c\u0001o\u0001g\u0001a\u0001e\u0001a\u0001s\u0001t\u0001v\u0001l\u0001m\u0001u\u0001e\u0001o\u0001n\u0001\t\u0001w\u0001n\u0001h\u0001r\u0001m\u0001l\u0001r\u0001l\u0002e\u0001a\u0001i\u0001m\u0001r\u00010\u0001n\u0001s\u0001\uFFFF\u0001r\u0001s\u0001e\u00010\u0001t\u0001e\u0001l\u00010\u0001s\u0001r\u0001c\u0001t\u0001c\u0001a\u0001n\u0001\uFFFF\u0001s\u0001\t\u0001a\u00010\u0001l\u0001\uFFFF\u00010\u0001n\u0001y\u0001\uFFFF\u00020\u0001t\u0001e\u00010\u0001r\u0001s\u0001\t\u0001\uFFFF\u0001m\u0001\uFFFF\u0001s\u0001\uFFFF\u0001t\u00010\u0002\uFFFF\u0001e\u00010\u0001\uFFFF\u00020\u0001\uFFFF\u0001m\u0001\t\u00010\u0001\uFFFF\u0001d\u0003\uFFFF\u0001a\u0002\uFFFF\u00010\u0001r\u0001\uFFFF\u00010");
        ANTLRLexer.DFA34.DFA34_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001\uFFFF\u0001\uFFFF\u0001\uFFFF\u0001\uFFFF\u0001p\u0001r\u0001h\u0001m\u0001r\u0001o\u0001u\u0001r\u0001e\u0001o\u0001:\u0004\uFFFF\u0001>\u0002\uFFFF\u0001>\u0002\uFFFF\u0001=\u0002\uFFFF\u0001.\u000E\uFFFF\u0001t\u0001\uFFFF\u0001k\u0001e\u0001r\u0001a\u0001t\u0001p\u0001a\u0001n\u0001x\u0001c\u0001r\u0001o\u0001b\u0001a\u0001t\u0001d\u001B\uFFFF\u0001i\u0002e\u0001o\u0001n\u0001c\u0001o\u0001g\u0001a\u0001e\u0001a\u0001s\u0001t\u0001v\u0001l\u0001m\u0001u\u0001e\u0001o\u0001n\u0001g\u0001w\u0001n\u0001h\u0001r\u0001m\u0001l\u0001r\u0001l\u0002e\u0001a\u0001i\u0001m\u0001r\u0001�\u0001n\u0001s\u0001\uFFFF\u0001r\u0001s\u0001e\u0001�\u0001t\u0001e\u0001l\u0001�\u0001s\u0001r\u0001c\u0001t\u0001c\u0001a\u0001n\u0001\uFFFF\u0001s\u0001{\u0001a\u0001�\u0001l\u0001\uFFFF\u0001�\u0001n\u0001y\u0001\uFFFF\u0002�\u0001t\u0001e\u0001�\u0001r\u0001s\u0001{\u0001\uFFFF\u0001m\u0001\uFFFF\u0001s\u0001\uFFFF\u0001t\u0001�\u0002\uFFFF\u0001e\u0001�\u0001\uFFFF\u0002�\u0001\uFFFF\u0001m\u0001{\u0001�\u0001\uFFFF\u0001d\u0003\uFFFF\u0001a\u0002\uFFFF\u0001�\u0001r\u0001\uFFFF\u0001�");
        ANTLRLexer.DFA34.DFA34_accept = DFA.UnpackEncodedString("\u0001\uFFFF\u0001\u0001\u0001\uFFFF\u0001\u0003\v\uFFFF\u0001\u0018\u0001\u0019\u0001\u001A\u0001\u001B\u0001\uFFFF\u0001\u001D\u0001\u001E\u0001\uFFFF\u0001 \u0001\"\u0001\uFFFF\u0001%\u0001&\u0001\uFFFF\u0001)\u0001*\u0001+\u0001,\u0001-\u0001.\u0001/\u00010\u00011\u00012\u0001\u0001\u0002\u0002\u0001\u0003\u0001\uFFFF\u0001-\u0010\uFFFF\u0001\u0017\u0001\u0016\u0001\u0018\u0001\u0019\u0001\u001A\u0001\u001B\u0001\u001C\u0001\u001D\u0001\u001E\u0001!\u0001\u001F\u0001 \u0001\"\u0001$\u0001#\u0001%\u0001&\u0001(\u0001'\u0001)\u0001*\u0001+\u0001,\u0001.\u0001/\u00010\u00011&\uFFFF\u0001\f\u000F\uFFFF\u0001\u0015\u0005\uFFFF\u0001\u0013\u0003\uFFFF\u0001\t\b\uFFFF\u0001\u0005\u0001\uFFFF\u0001\u0012\u0001\uFFFF\u0001\a\u0002\uFFFF\u0001\u0011\u0001\n\u0002\uFFFF\u0001\u000E\u0002\uFFFF\u0001\u0004\u0003\uFFFF\u0001\u0014\u0001\uFFFF\u0001\u000F\u0001\v\u0001\u0010\u0001\uFFFF\u0001\u0006\u0001\b\u0002\uFFFF\u0001\r\u0001\uFFFF");
        ANTLRLexer.DFA34.DFA34_special = DFA.UnpackEncodedString("\u0001\0\u0001\uFFFF\u0001\u0001\u00BC\uFFFF}>");
        int length = ANTLRLexer.DFA34.DFA34_transitionS.Length;
        ANTLRLexer.DFA34.DFA34_transition = new short[length][];
        for (int index = 0; index < length; ++index)
          ANTLRLexer.DFA34.DFA34_transition[index] = DFA.UnpackEncodedString(ANTLRLexer.DFA34.DFA34_transitionS[index]);
      }

      public DFA34(
        BaseRecognizer recognizer,
        SpecialStateTransitionHandler specialStateTransition) : base(specialStateTransition)
      {
        
        this.recognizer = recognizer;
        this.decisionNumber = 34;
        this.eot = ANTLRLexer.DFA34.DFA34_eot;
        this.eof = ANTLRLexer.DFA34.DFA34_eof;
        this.min = ANTLRLexer.DFA34.DFA34_min;
        this.max = ANTLRLexer.DFA34.DFA34_max;
        this.accept = ANTLRLexer.DFA34.DFA34_accept;
        this.special = ANTLRLexer.DFA34.DFA34_special;
        this.transition = ANTLRLexer.DFA34.DFA34_transition;
      }

      public override string Description
      {
        get
        {
          return "1:1: Tokens : ( COMMENT | ARG_OR_CHARSET | ACTION | OPTIONS | TOKENS_SPEC | CHANNELS | IMPORT | FRAGMENT | LEXER | PARSER | GRAMMAR | TREE_GRAMMAR | PROTECTED | PUBLIC | PRIVATE | RETURNS | LOCALS | THROWS | CATCH | FINALLY | MODE | COLON | COLONCOLON | COMMA | SEMI | LPAREN | RPAREN | RARROW | LT | GT | ASSIGN | QUESTION | SYNPRED | STAR | PLUS | PLUS_ASSIGN | OR | DOLLAR | DOT | RANGE | AT | POUND | NOT | RBRACE | ID | INT | STRING_LITERAL | WS | UnicodeBOM | ERRCHAR );";
        }
      }

      public override void Error(NoViableAltException nvae)
      {
      }
    }
  }
}
