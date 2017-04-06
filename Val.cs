using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chess
{
    class Val
    {
        public static Form1 Father;
        private static string WKing = "♔";
        public static string WQueen = "♕";
        private static string WBishop = "♗";
        private static string WRook = "♖";
        private static string WKnight = "♘";
        private static string WPawn = "♙";
        private static string BKing = "♚";
        public static string BQueen = "♛";
        private static string BBishop = "♝";
        private static string BRook = "♜";
        private static string BKnight = "♞";
        private static string BPawn = "♟";


        public bool White = true;
        public bool Black = false;

        public static string WhatPiece(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            if (IsPawn(h)) return "P";
            if (IsKnight(h)) return "N";
            if (IsBishop(h)) return "B";
            if (IsQueen(h)) return "Q";
            if (IsRook(h)) return "R";
            if (IsKing(h)) return "K";
            else return "";
        }
        public static bool IsBlack(Point piece)
        {
            //if (DoesPointExist(p//iece))
            //{
                string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
                return IsBlack(h);
            //}
            //else return false;
        }

        public static bool IsWhite(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            return IsWhite(h);
        }
        public static bool IsPiece(Point piece)
        {
            try
            {
                string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
                return IsPiece(h);
            }
            catch { return false; }
        }
        public static bool IsNull(Point piece)
        {
            try
            {
                string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
                return IsNull(h);
            }
            catch { return true; }
        }
        public static bool IsPawn(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            return IsPiece(h);
        }
        public static bool IsKnight(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            return IsKnight(h);
        }
        public static bool IsNotQorR(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            return IsNotQorR(h);
        }
        public static bool IsNotQorB(Point piece)
        {
            string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
            return IsNotQorB(h);
        }

        public static bool DoesPointExist(Point piece)
        {
            try
            {
                string h = Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();
                return true;
            }
            catch { return false; }
        }

        public static bool IsNull(string x)
        {
            if (x.Trim() == "")
            {
                return true;
            }
            else if (x.Trim() == " ")
            {
                return true;
            }
            else if (x == null)
            {
                return true;
            }
            else if (x == string.Empty)
            {
                return true;
            }
            else return false;
        }
        public static bool IsPiece(string x)
        {
            if (x == WRook ||
                x == BRook ||
                x == WKing ||
                x == BKing ||
                x == WQueen ||
                x == BQueen ||
                x == WBishop ||
                x == BBishop ||
                x == WKnight ||
                x == BKnight ||
                x == WPawn ||
                x == BPawn)
            {
                return true;
            }
            else return false;
        }
        public static bool IsBlack(string x)
        {
            if (x == BRook ||
                x == BKing ||
                x == BQueen ||
                x == BBishop ||
                x == BKnight ||
                x == BPawn)
            {
                return true;
            }
            else return false;
        }
        public static bool IsWhite(string x)
        {
            if (x == WRook ||
                x == WKing ||
                x == WQueen ||
                x == WBishop ||
                x == WKnight ||
                x == WPawn)
            {
                return true;
            }
            else return false;
        }
        public static bool IsKing(string x)
        {
            if (x == WKing ||
                x == BKing)
            {
                return true;
            }
            else return false;
        }
        public static bool IsQueen(string x)
        {
            if (x == WQueen ||
                x == BQueen)
            {
                return true;
            }
            else return false;
        }
        public static bool IsBishop(string x)
        {
            if (x == WBishop ||
                x == BBishop)
            {
                return true;
            }
            else return false;
        }
        public static bool IsKnight(string x)
        {
            if (x == WKnight ||
                x == BKnight)
            {
                return true;
            }
            else return false;
        }
        public static bool IsRook(string x)
        {
            if (x == WRook ||
                x == BRook)
            {
                return true;
            }
            else return false;
        }
        public static bool IsPawn(string x)
        {
            if (x == WPawn ||
                x == BPawn)
            {
                return true;
            }
            else return false;
        }

        public static void TagToTrue(Point Target)
        {
            try
            {
                Father.Board.Rows[Target.Y].Cells[Target.X].Tag = true;
            }
            catch { }
        }

        public static void ShowMoves(Point x, string peice)
        {
            if (IsPawn(peice)) PawnMovesHighlight(x);
            if (IsKnight(peice)) KnightMovesHighlight(x);
            if (IsBishop(peice)) BishopMovesHighlight(x);
            if (IsRook(peice)) RookMovesHighlight(x);
            if (IsQueen(peice)) QueenMovesHighlight(x);
            if (IsKing(peice)) KingMovesHighlight(x);
        }

        public static Point InvertY(Point Loct)
        {
            if (Loct.Y == 0) Loct.Y = 7;
            else if (Loct.Y == 1) Loct.Y = 6;
            else if (Loct.Y == 2) Loct.Y = 5;
            else if (Loct.Y == 3) Loct.Y = 4;
            else if (Loct.Y == 4) Loct.Y = 3;
            else if (Loct.Y == 5) Loct.Y = 2;
            else if (Loct.Y == 6) Loct.Y = 1;
            else if (Loct.Y == 7) Loct.Y = 0;
            return Loct;
        }

        public static bool PossablePassant = false;
        public static Point LastDoubleJumpTemp = new Point();
        public static Point LastDoubleJump = new Point();

        public static bool ValWhiteMove(Point P)
        {
            if (DoesPointExist(P))
            {
                if (IsWhite(P))
                {
                    return true;
                }
                else if (IsBlack(P))
                {
                    TagToTrue(P);
                    return true;
                }
                else if (!IsPiece(P))
                {
                    TagToTrue(P);
                }
            }
            return false;
        }

        public static bool ValBlackMove(Point P)
        {
            if (DoesPointExist(P))
            {
                if (IsWhite(P))
                {
                    TagToTrue(P);
                    return true;
                }
                else if (IsBlack(P))
                {
                    return true;
                }
                else if (!IsPiece(P))
                {
                    TagToTrue(P);
                }
            }
            return false;
        }


        public static void PawnMovesHighlight(Point x)
        {
            Point ForwardMarch = new Point(x.X, x.Y - 1);
            Point DoubleJump = new Point(x.X, x.Y - 2);
            Point LeftStrike = new Point(x.X - 1, x.Y - 1);
            Point RightStrike = new Point(x.X + 1, x.Y - 1);


            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                try
                {
                    if (IsWhite(ForwardMarch) == false && IsBlack(ForwardMarch) == false)
                        TagToTrue(ForwardMarch);
                }
                catch { }
                try
                {
                    if (x.Y == 6 && IsWhite(DoubleJump) == false && IsBlack(DoubleJump) == false)
                    {
                        TagToTrue(DoubleJump);
                        LastDoubleJumpTemp = DoubleJump;
                    }
                }
                catch { }

                bool Lstrike = false;
                try
                {
                    if (IsBlack(LeftStrike))
                    {
                        TagToTrue(LeftStrike);
                        Lstrike = true;
                    }
                }
                catch { }
                bool Rstrike = false;
                try
                {
                    if (IsBlack(RightStrike))
                    {
                        TagToTrue(RightStrike);
                        Rstrike = true;
                    }
                }
                catch { }

                try
                {
                    if (x.Y == 3)
                    {
                        Point LeftBalck = new Point(x.X - 1, x.Y);
                        Point RightBalck = new Point(x.X + 1, x.Y);
                        Point Null = new Point(0, 0);
                        if (LastDoubleJump != Null)
                        {
                            if (!Lstrike && IsBlack(LeftBalck) && IsPawn(LeftBalck))
                            {
                                Point left = InvertY(LastDoubleJump);
                                left.Y -= 1;
                                TagToTrue(left);
                                PossablePassant = true;
                            }
                            else if (!Rstrike && IsBlack(RightBalck) && IsPawn(RightBalck))
                            {
                                Point right = InvertY(LastDoubleJump);
                                right.Y -= 1;
                                TagToTrue(right);
                                PossablePassant = true;
                            }
                        }
                    }
                }
                catch { }
            }

            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                try
                {
                    if (IsWhite(ForwardMarch) == false && IsBlack(ForwardMarch) == false)
                        TagToTrue(ForwardMarch);
                }
                catch { }
                try
                {
                    if (x.Y == 6 && IsWhite(DoubleJump) == false && IsBlack(DoubleJump) == false)
                    {
                        TagToTrue(DoubleJump);
                        LastDoubleJumpTemp = DoubleJump;
                    }
                }
                catch { }

                bool Lstrike = false;
                try
                {
                    if (IsWhite(LeftStrike))
                    {
                        TagToTrue(LeftStrike);
                        Lstrike = true;
                    }
                }
                catch { }

                bool Rstrike = false;
                try
                {
                    if (IsWhite(RightStrike))
                    {
                        TagToTrue(RightStrike);
                        Rstrike = true;
                    }
                }
                catch { }
                try
                {
                    if (x.Y == 3)
                    {
                        Point LeftWhite = new Point(x.X - 1, x.Y);
                        Point RightWhite = new Point(x.X + 1, x.Y);
                        Point Null = new Point(0, 0);
                        if (LastDoubleJump != Null)
                        {
                            if (!Lstrike && IsWhite(LeftWhite) && IsPawn(LeftWhite))
                            {
                                Point left = InvertY(LastDoubleJump);
                                left.Y -= 1;
                                TagToTrue(left);
                                PossablePassant = true;
                            }
                            else if (!Rstrike && IsWhite(RightWhite) && IsPawn(RightWhite))
                            {
                                Point right = InvertY(LastDoubleJump);
                                right.Y -= 1;
                                TagToTrue(right);
                                PossablePassant = true;
                            }
                        }
                    }
                }
                catch { }
            }
            RePaintBoard();
        }

        public static void RookMovesHighlight(Point x)
        {
            bool UpDone = false;
            bool DownDone = false;
            bool LeftDone = false;
            bool RightDone = false;

            Point UpPoint = new Point();
            Point DownPoint = new Point();
            Point LeftPoint = new Point();
            Point RightPoint = new Point();

            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpDone && DownDone && LeftDone && RightDone)
                        break;

                    UpPoint = new Point(x.X, x.Y - Y);
                    DownPoint = new Point(x.X, x.Y + Y);
                    LeftPoint = new Point(x.X - Y, x.Y);
                    RightPoint = new Point(x.X + Y, x.Y);

                    if (!UpDone)
                        UpDone = ValWhiteMove(UpPoint);

                    if (!DownDone)
                        DownDone = ValWhiteMove(DownPoint);

                    if (!LeftDone)
                        LeftDone = ValWhiteMove(LeftPoint);

                    if (!RightDone)
                        RightDone = ValWhiteMove(RightPoint);
                }
            }
            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpDone && DownDone && LeftDone && RightDone)
                        break;

                    UpPoint = new Point(x.X, x.Y - Y);
                    DownPoint = new Point(x.X, x.Y + Y);
                    LeftPoint = new Point(x.X - Y, x.Y);
                    RightPoint = new Point(x.X + Y, x.Y);

                    if (!UpDone)
                        UpDone = ValBlackMove(UpPoint);

                    if (!DownDone)
                        DownDone = ValBlackMove(DownPoint);

                    if (!LeftDone)
                        LeftDone = ValBlackMove(LeftPoint);

                    if (!RightDone)
                        RightDone = ValBlackMove(RightPoint);
                }
            }
            RePaintBoard();
        }

        public static void BishopMovesHighlight(Point x)
        {
            bool UpLeft = true;
            bool UpRight = true;
            bool DownLeft = true;
            bool DownRight = true;

            bool UpLeftDone = false;
            bool UpRightDone = false;
            bool DownLeftDone = false;
            bool DownRightDone = false;

            Point UpLeftPoint = new Point();
            Point UpRightPoint = new Point();
            Point DownLeftPoint = new Point();
            Point DownRightPoint = new Point();

            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpLeftDone && UpRightDone && DownLeftDone && DownRightDone)
                        break;

                    UpLeftPoint = new Point(x.X - Y, x.Y - Y);
                    UpLeft = DoesPointExist(UpLeftPoint);

                    UpRightPoint = new Point(x.X + Y, x.Y - Y);
                    UpRight = DoesPointExist(UpRightPoint);

                    DownLeftPoint = new Point(x.X - Y, x.Y + Y);
                    DownLeft = DoesPointExist(DownLeftPoint);

                    DownRightPoint = new Point(x.X + Y, x.Y + Y);
                    DownRight = DoesPointExist(DownRightPoint);

                    if (UpLeft && !UpLeftDone)
                        UpLeftDone = ValWhiteMove(UpLeftPoint);

                    if (UpRight && !UpRightDone)
                        UpRightDone = ValWhiteMove(UpRightPoint);

                    if (DownLeft && !DownLeftDone)
                        DownLeftDone = ValWhiteMove(DownLeftPoint);

                    if (DownRight && !DownRightDone)
                        DownRightDone = ValWhiteMove(DownRightPoint);
                }
            }
            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpLeftDone && UpRightDone && DownLeftDone && DownRightDone)
                        break;
                    UpLeftPoint = new Point(x.X - Y, x.Y - Y);
                    UpLeft = DoesPointExist(UpLeftPoint);

                    UpRightPoint = new Point(x.X + Y, x.Y - Y);
                    UpRight = DoesPointExist(UpRightPoint);

                    DownLeftPoint = new Point(x.X - Y, x.Y + Y);
                    DownLeft = DoesPointExist(DownLeftPoint);

                    DownRightPoint = new Point(x.X + Y, x.Y + Y);
                    DownRight = DoesPointExist(DownRightPoint);

                    if (UpLeft && !UpLeftDone)
                        UpLeftDone = ValBlackMove(UpLeftPoint);

                    if (UpRight && !UpRightDone)
                        UpRightDone = ValBlackMove(UpRightPoint);

                    if (DownLeft && !DownLeftDone)
                        DownLeftDone = ValBlackMove(DownLeftPoint);

                    if (DownRight && !DownRightDone)
                        DownRightDone = ValBlackMove(DownRightPoint);
                }
            }
            RePaintBoard();
        }

        public static void QueenMovesHighlight(Point x)
        {
            bool UpDone = false;
            bool DownDone = false;
            bool LeftDone = false;
            bool RightDone = false;

            Point UpPoint = new Point();
            Point DownPoint = new Point();
            Point LeftPoint = new Point();
            Point RightPoint = new Point();

            bool UpLeftDone = false;
            bool UpRightDone = false;
            bool DownLeftDone = false;
            bool DownRightDone = false;

            Point UpLeftPoint = new Point();
            Point UpRightPoint = new Point();
            Point DownLeftPoint = new Point();
            Point DownRightPoint = new Point();

            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpDone && DownDone && LeftDone && RightDone && UpLeftDone && UpRightDone && DownLeftDone && DownRightDone)
                        break;

                    UpLeftPoint = new Point(x.X - Y, x.Y - Y);
                    UpRightPoint = new Point(x.X + Y, x.Y - Y);
                    DownLeftPoint = new Point(x.X - Y, x.Y + Y);
                    DownRightPoint = new Point(x.X + Y, x.Y + Y);
                    UpPoint = new Point(x.X, x.Y - Y);
                    DownPoint = new Point(x.X, x.Y + Y);
                    LeftPoint = new Point(x.X - Y, x.Y);
                    RightPoint = new Point(x.X + Y, x.Y);

                    if (!UpDone)
                        UpDone = ValWhiteMove(UpPoint);

                    if (!DownDone)
                        DownDone = ValWhiteMove(DownPoint);

                    if (!LeftDone)
                        LeftDone = ValWhiteMove(LeftPoint);

                    if (!RightDone)
                        RightDone = ValWhiteMove(RightPoint);

                    if (!UpLeftDone)
                        UpLeftDone = ValWhiteMove(UpLeftPoint);

                    if (!UpRightDone)
                        UpRightDone = ValWhiteMove(UpRightPoint);

                    if (!DownLeftDone)
                        DownLeftDone = ValWhiteMove(DownLeftPoint);

                    if (!DownRightDone)
                        DownRightDone = ValWhiteMove(DownRightPoint);
                }


            }
            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                for (int Y = 1; Y < 8; Y++)
                {
                    if (UpDone && DownDone && LeftDone && RightDone && UpLeftDone && UpRightDone && DownLeftDone && DownRightDone)
                        break;

                    UpLeftPoint = new Point(x.X - Y, x.Y - Y);
                    UpRightPoint = new Point(x.X + Y, x.Y - Y);
                    DownLeftPoint = new Point(x.X - Y, x.Y + Y);
                    DownRightPoint = new Point(x.X + Y, x.Y + Y);
                    UpPoint = new Point(x.X, x.Y - Y);
                    DownPoint = new Point(x.X, x.Y + Y);
                    LeftPoint = new Point(x.X - Y, x.Y);
                    RightPoint = new Point(x.X + Y, x.Y);

                    if (!UpDone)
                        UpDone = ValBlackMove(UpPoint);

                    if (!DownDone)
                        DownDone = ValBlackMove(DownPoint);

                    if (!LeftDone)
                        LeftDone = ValBlackMove(LeftPoint);

                    if (!RightDone)
                        RightDone = ValBlackMove(RightPoint);

                    if (!UpLeftDone)
                        UpLeftDone = ValBlackMove(UpLeftPoint);

                    if (!UpRightDone)
                        UpRightDone = ValBlackMove(UpRightPoint);

                    if (!DownLeftDone)
                        DownLeftDone = ValBlackMove(DownLeftPoint);

                    if (!DownRightDone)
                        DownRightDone = ValBlackMove(DownRightPoint);
                }
            }
            RePaintBoard();
        }

        public static void KnightMovesHighlight(Point x)
        {
            

            bool UpLeftDone = false;
            bool UpRightDone = false;
            bool DownLeftDone = false;
            bool DownRightDone = false;
            bool LeftupDone = false;
            bool LeftDownDone = false;
            bool RightUpDone = false;
            bool RightDownDone = false;

            Point UpLeftPoint = new Point(x.X + 1, x.Y - 2);
            Point UpRightPoint = new Point(x.X - 1, x.Y - 2);

            Point DownLeftPoint = new Point(x.X - 1, x.Y + 2);
            Point DownRightPoint = new Point(x.X + 1, x.Y + 2);

            Point LeftupPoint = new Point(x.X - 2, x.Y - 1);
            Point LeftDownPoint = new Point(x.X - 2, x.Y + 1);

            Point RightUpPoint = new Point(x.X + 2, x.Y - 1);
            Point RightDownPoint = new Point(x.X + 2, x.Y + 1);


            //bool UpLeft = DoesPointExist(UpLeftPoint);
            //bool UpRight = DoesPointExist(UpRightPoint);
            //bool DownLeft = DoesPointExist(DownLeftPoint);
            //bool DownRight = DoesPointExist(DownRightPoint);
            //bool Leftup = DoesPointExist(LeftupPoint);
            //bool LeftDown = DoesPointExist(LeftDownPoint);
            //bool RightUp = DoesPointExist(RightUpPoint);
            //bool RightDown = DoesPointExist(RightDownPoint);

            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                if (!UpLeftDone)
                    UpLeftDone = ValWhiteMove(UpLeftPoint);

                if (!UpRightDone)
                    UpRightDone = ValWhiteMove(UpRightPoint);

                if (!DownLeftDone)
                    DownLeftDone = ValWhiteMove(DownLeftPoint);

                if (!DownRightDone)
                    DownRightDone = ValWhiteMove(DownRightPoint);

                if (!LeftupDone)
                    LeftupDone = ValWhiteMove(LeftupPoint);

                if (!LeftDownDone)
                    LeftDownDone = ValWhiteMove(LeftDownPoint);

                if (!RightUpDone)
                    RightUpDone = ValWhiteMove(RightUpPoint);

                if (!RightDownDone)
                    RightDownDone = ValWhiteMove(RightDownPoint);
            }
            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                if (!UpLeftDone)
                    UpLeftDone = ValBlackMove(UpLeftPoint);

                if (!UpRightDone)
                    UpRightDone = ValBlackMove(UpRightPoint);

                if (!DownLeftDone)
                    DownLeftDone = ValBlackMove(DownLeftPoint);

                if (!DownRightDone)
                    DownRightDone = ValBlackMove(DownRightPoint);

                if (!LeftupDone)
                    LeftupDone = ValBlackMove(LeftupPoint);

                if (!LeftDownDone)
                    LeftDownDone = ValBlackMove(LeftDownPoint);

                if (!RightUpDone)
                    RightUpDone = ValBlackMove(RightUpPoint);

                if (!RightDownDone)
                    RightDownDone = ValBlackMove(RightDownPoint);
            }
            RePaintBoard();
        }

        public static void KingMovesHighlight(Point x)
        {
            Point UpPoint = new Point(x.X, x.Y - 1);
            Point DownPoint = new Point(x.X, x.Y + 1);
            Point LeftPoint = new Point(x.X - 1, x.Y);
            Point RightPoint = new Point(x.X + 1, x.Y);

            Point UpLeftPoint = new Point(x.X - 1, x.Y - 1);
            Point UpRightPoint = new Point(x.X + 1, x.Y - 1);
            Point DownLeftPoint = new Point(x.X - 1, x.Y + 1);
            Point DownRightPoint = new Point(x.X + 1, x.Y + 1);

            if ((Father.WhiteTurn && IsWhite(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString())))
            {
                if (DoesPointExist(UpPoint) && IsSpaceDangerous(UpPoint))
                    ValWhiteMove(UpPoint);
                if ( DoesPointExist(DownPoint) && IsSpaceDangerous(DownPoint))
                     ValWhiteMove(DownPoint);
                if (DoesPointExist(LeftPoint) && IsSpaceDangerous(LeftPoint))
                     ValWhiteMove(LeftPoint);
                if ( DoesPointExist(RightPoint) && IsSpaceDangerous(RightPoint))
                    ValWhiteMove(RightPoint);

                if ( DoesPointExist(UpLeftPoint) && IsSpaceDangerous(UpLeftPoint))
                     ValWhiteMove(UpLeftPoint);
                if ( DoesPointExist(UpRightPoint) && IsSpaceDangerous(UpRightPoint))
                     ValWhiteMove(UpRightPoint);
                if ( DoesPointExist(DownLeftPoint) && IsSpaceDangerous(DownLeftPoint))
                    ValWhiteMove(DownLeftPoint);
                if ( DoesPointExist(DownRightPoint) && IsSpaceDangerous(DownRightPoint))
                     ValWhiteMove(DownRightPoint);
            }
            else if (Father.BlackTurn && IsBlack(Father.Board.Rows[x.Y].Cells[x.X].Value.ToString()))
            {
                if ( DoesPointExist(UpPoint) && IsSpaceDangerous(UpPoint))
                     ValBlackMove(UpPoint);
                if ( DoesPointExist(DownPoint) && IsSpaceDangerous(DownPoint))
                     ValBlackMove(DownPoint);
                if (DoesPointExist(LeftPoint) && IsSpaceDangerous(LeftPoint))
                    ValBlackMove(LeftPoint);
                if ( DoesPointExist(RightPoint) && IsSpaceDangerous(RightPoint))
                    ValBlackMove(RightPoint);

                if (DoesPointExist(UpLeftPoint) && IsSpaceDangerous(UpLeftPoint))
                    ValBlackMove(UpLeftPoint);
                if ( DoesPointExist(UpRightPoint) && IsSpaceDangerous(UpRightPoint))
                    ValBlackMove(UpRightPoint);
                if ( DoesPointExist(DownLeftPoint) && IsSpaceDangerous(DownLeftPoint))
                     ValBlackMove(DownLeftPoint);
                if ( DoesPointExist(DownRightPoint) && IsSpaceDangerous(DownRightPoint))
                     ValBlackMove(DownRightPoint);
            }
            RePaintBoard();
        }

        public static bool IsNotQorB(string x)
        {
            if (x == WKing ||
                x == BKing ||
                x == WRook ||
                x == BRook ||
                x == WKnight ||
                x == BKnight ||
                x == WPawn ||
                x == BPawn)
            {
                return true;
            }
            else return false;
        }
        public static bool IsNotQorR(string x)
        {
            if (x == WKing ||
                x == BKing ||
                x == WBishop ||
                x == BBishop ||
                x == WKnight ||
                x == BKnight ||
                x == WPawn ||
                x == BPawn)
            {
                return true;
            }
            else return false;
        }
        public static bool IsSpaceDangerous(Point x)
        {
            bool NoDanger = true;
            //Father.Board.Rows[piece.Y].Cells[piece.X].Value.ToString();

            Point LeftPawn = new Point(x.X - 1, x.Y - 1);
            Point RightPawn = new Point(x.X + 1, x.Y - 1);

            Point UpLeftKnight = new Point(x.X + 1, x.Y - 2);
            Point UpRightKnight = new Point(x.X - 1, x.Y - 2);

            Point DownLeftKnight = new Point(x.X - 1, x.Y + 2);
            Point DownRightKnight = new Point(x.X + 1, x.Y + 2);

            Point LeftupKnight = new Point(x.X - 2, x.Y - 1);
            Point LeftDownKnight = new Point(x.X - 2, x.Y + 1);

            Point RightUpKnight = new Point(x.X + 2, x.Y - 1);
            Point RightDownKnight = new Point(x.X + 2, x.Y + 1);

            if (Father.WhiteTurn)
            {
                try
                {
                    if (NoDanger && IsBlack(LeftPawn) && IsPawn(LeftPawn))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(RightPawn) && IsPawn(LeftPawn))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(UpLeftKnight) && IsKnight(UpLeftKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(UpRightKnight) && IsKnight(UpRightKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(DownLeftKnight) && IsKnight(DownLeftKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(DownRightKnight) && IsKnight(DownRightKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(LeftupKnight) && IsKnight(LeftupKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(LeftDownKnight) && IsKnight(LeftDownKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(RightUpKnight) && IsKnight(RightUpKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }
                try
                {
                    if (NoDanger && IsBlack(RightDownKnight) && IsKnight(RightDownKnight))
                        NoDanger = false;
                }
                catch { NoDanger = true; }

                if (NoDanger)
                {
                    bool UpDone = false;
                    bool DownDone = false;
                    bool LeftDone = false;
                    bool RightDone = false;

                    bool UpLeftDone = false;
                    bool UpRightDone = false;
                    bool DownLeftDone = false;
                    bool DownRightDone = false;


                    for (int Y = 0; Y < 8; Y++)
                    {
                        if (!UpDone && NoDanger)
                        {
                            int Case = x.Y - Y;
                            if (Case >= 0)
                            {
                                Point UpPoint = new Point(x.X, Case);
                                if (DoesPointExist(UpPoint) && IsNotQorR(UpPoint))
                                { NoDanger = true; UpDone = true; }
                                else if (IsNull(UpPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!DownDone && NoDanger)
                        {
                            int Case = x.Y + Y;

                            if (Case >= 0 && Case < 8)
                            {
                                Point DownPoint = new Point(x.X, Case);
                                if (DoesPointExist(DownPoint) && IsNotQorR(DownPoint))
                                { NoDanger = true; DownDone = true; }
                                else if (IsNull(DownPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!LeftDone && NoDanger)
                        {
                            int Case = x.X - Y;

                            if (Case >= 0 && Case < 8)
                            {
                                Point LeftPoint = new Point(Case, x.Y);
                                if (DoesPointExist(LeftPoint) && IsNotQorR(LeftPoint))
                                { NoDanger = true; LeftDone = true; }
                                else if (IsNull(LeftPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!RightDone && NoDanger)
                        {
                            int Case = x.X + Y;
                            if (Case >= 0 && Case < 8)
                            {
                                Point RightPoint = new Point(Case, x.Y);
                                if (DoesPointExist(RightPoint) && IsNotQorR(RightPoint))
                                { NoDanger = true; RightDone = true; }
                                else if (IsNull(RightPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!UpLeftDone && NoDanger)
                        {
                            int CaseOne = x.X - Y;
                            int CaseTwo = x.Y - Y;
                            if (CaseOne >= 0 && CaseTwo >= 0 && CaseOne < 8 && CaseTwo < 8)
                            {
                                Point UpLeftPoint = new Point(CaseOne, CaseTwo);
                                if (DoesPointExist(UpLeftPoint) && IsNotQorB(UpLeftPoint))
                                { NoDanger = true; UpLeftDone = true; }
                                else if (IsNull(UpLeftPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!UpRightDone && NoDanger)
                        {
                            int CaseOne = x.X + Y;
                            int CaseTwo = x.Y - Y;
                            if (CaseOne >= 0 && CaseTwo >= 0 && CaseOne < 8 && CaseTwo < 8)
                            {
                                Point UpRightPoint = new Point(CaseOne, CaseTwo);
                                if (DoesPointExist(UpRightPoint) && IsNotQorB(UpRightPoint))
                                { NoDanger = true; UpRightDone = true; }
                                else if (IsNull(UpRightPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!DownLeftDone && NoDanger)
                        {
                            int CaseOne = x.X - Y;
                            int CaseTwo = x.Y + Y;
                            if (CaseOne >= 0 && CaseTwo >= 0 && CaseOne < 8 && CaseTwo < 8)
                            {
                                Point DownLeftPoint = new Point(CaseOne, CaseTwo);
                                if (DoesPointExist(DownLeftPoint) && IsNotQorB(DownLeftPoint))
                                { NoDanger = true; DownLeftDone = true; }
                                else if (IsNull(DownLeftPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!DownRightDone && NoDanger)
                        {
                            int CaseOne = x.X + Y;
                            int CaseTwo = x.Y + Y;
                            if (CaseOne >= 0 && CaseTwo >= 0 && CaseOne < 8 && CaseTwo < 8)
                            {
                                Point DownRightPoint = new Point(CaseOne, CaseTwo);
                                if (DoesPointExist(DownRightPoint) && IsNotQorB(DownRightPoint))
                                { NoDanger = true; DownRightDone = true; }
                                else if (IsNull(DownRightPoint))
                                    NoDanger = true;
                                else
                                    NoDanger = false;
                            }
                        }

                        if (!NoDanger)
                            break;
                    }
                }
                bool temp = NoDanger;
                bool temps = NoDanger;
            }
            else
            {
                //if (NoDanger && IsWhite(LeftPawn) && IsPawn(LeftPawn))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(RightPawn) && IsPawn(LeftPawn))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(UpLeftKnight) && IsKnight(UpLeftKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(UpRightKnight) && IsKnight(UpRightKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(DownLeftKnight) && IsKnight(DownLeftKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(DownRightKnight) && IsKnight(DownRightKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(LeftupKnight) && IsKnight(LeftupKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(LeftDownKnight) && IsKnight(LeftDownKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(RightUpKnight) && IsKnight(RightUpKnight))
                //    NoDanger = false;
                //if (NoDanger && IsWhite(RightDownKnight) && IsKnight(RightDownKnight))
                //    NoDanger = false;
            }


            return NoDanger;
        }



        public static void RePaintBoard()
        {
            Father.Board.InvalidateColumn(0);
            Father.Board.InvalidateColumn(1);
            Father.Board.InvalidateColumn(2);
            Father.Board.InvalidateColumn(3);
            Father.Board.InvalidateColumn(4);
            Father.Board.InvalidateColumn(5);
            Father.Board.InvalidateColumn(6);
            Father.Board.InvalidateColumn(7);
            Father.Board.CurrentCell = null;
        }


    }
}
