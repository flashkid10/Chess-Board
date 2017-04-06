using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        string WKing = "♔";
        string WQueen = "♕";
        string WBishop = "♗";
        string WRook = "♖";
        string WKnight = "♘";
        string WPawn = "♙";
        string BKing = "♚";
        string BQueen = "♛";
        string BBishop = "♝";
        string BRook = "♜";
        string BKnight = "♞";
        string BPawn = "♟";

        Point TopLocation;// = BlackHeatlh.Location;
        Point BottomLocation;// = WhiteHeatlh.Location;

        //string WKing = "WK";
        //string WQueen = "WQ";
        //string WBishop = "WB";
        //string WRook = "WR";
        //string WKnight = "WK";
        //string WPawn = "WP";
        //string BKing = "BK";
        //string BQueen = "BQ";
        //string BBishop = "BB";
        //string BRook = "BR";
        //string BKnight = "BK";
        //string BPawn = "BP";

        public bool WhiteTurn = false;
        public bool BlackTurn = true;

        public static int PawnPoint = 1;
        public static int KnightPoint = 3;
        public static int BishopPoint = 3;
        public static int RookPoint = 5;
        public static int QueenPoint = 9;
        public static int TeamPoint = (9 * PawnPoint) + (2 * (KnightPoint + BishopPoint + RookPoint)) + QueenPoint;
        //public static double ConvertFactor = (double)100 / 39;
        //public static double PawnDouble = (double)PawnPoint * ConvertFactor;
        //public static double KnightDouble = (double)KnightPoint * ConvertFactor;
        //public static double BishopDouble = (double)BishopPoint * ConvertFactor;
        //public static double RookDouble = (double)RookPoint * ConvertFactor;
        //public static double QueenDouble = (double)QueenPoint * ConvertFactor;
        //public static double BasePoint = (8 * PawnDouble) + (2 * (KnightDouble + BishopDouble + RookDouble)) + QueenDouble;
        //public static int TeamBasePoint = 100;
        //location: 1, 24
        //Size: 599, 532

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            Val.Father = this;
            TopLocation = WhiteHeatlh.Location;
            BottomLocation = BlackHeatlh.Location;
            Board.CellClick += Board_CellClickOne;
            Board.AllowUserToAddRows = false;
            Board.AllowUserToResizeColumns = false;
            Board.AllowUserToResizeRows = false;
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            Board.Rows.Add("");
            //Board.cel += Board_CellPainting;
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            for (int i = 0; i < 8; i++)
            {
                this.Board.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            foreach (DataGridViewColumn c in Board.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 8.5F, GraphicsUnit.Pixel);
            }
            //white chess king ♔ U + 2654 &#9812; 
            //white chess queen ♕ U + 2655 &#9813; 
            //white chess rook ♖ U + 2656 &#9814; 
            //white chess bishop ♗ U + 2657 &#9815; 
            //white chess knight ♘ U + 2658 &#9816; 
            //white chess pawn ♙ U + 2659 &#9817; 
            //black chess king ♚ U + 265A &#9818; 
            //black chess queen ♛ U + 265B &#9819; 
            //black chess rook ♜ U + 265C &#9820; 
            //black chess bishop ♝ U + 265D &#9821; 
            //black chess knight ♞ U + 265E &#9822; 
            //black chess pawn ♟ U + 265F &#9823; 
            Board.ReadOnly = true;
            BoardSize();
            BoardSet();
            UpdateFont();
            UpDateBoard();

            BlackHeatlh.Maximum = TeamPoint;
            BlackHeatlh.Step = 1;
            BlackHeatlh.Value = TeamPoint;

            WhiteHeatlh.Maximum = TeamPoint;
            WhiteHeatlh.Step = 1;
            WhiteHeatlh.Value = TeamPoint;

            ScoreTracker.DoWork += ScoreTracker_DoWork;
            //SaveWorker.RunWorkerCompleted += SaveWorker_RunWorkerCompleted;
            //SaveWorker.ProgressChanged += SaveWorker_ProgressChanged;
            //UpdateHeatlh();
            this.Load += Form1_Load;
            Board.CellFormatting += Board_CellFormatting;
            //label1.Text = BlackHeatlh.Value.ToString();
            //label2.Text = WhiteHeatlh.Value.ToString();
            //label3.Text = TeamBasePoint.ToString();
            //Board.CellPainting += Board_CellPainting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Board.CurrentCell = null;
            ToggleSides();
        }

        TestObject test = new TestObject { OneValue = 5, TwoValue = 4 };

        private void ScoreTracker_DoWork(object sender, DoWorkEventArgs e)
        {
            TestObject argumentTest = e.Argument as TestObject;
            //Thread.Sleep(1000);
            argumentTest.OneValue = 6;
            argumentTest.TwoValue = 3;
            e.Result = argumentTest;
            PecieCounter();
        }

        private int WhiteTeamMate = 16;
        private int BlackTeamMate = 16;
        private void PecieCounter()
        {
            int WhitePoint = 0;
            int BlackPoint = 0;
            int CurrentWhiteTeamMate = 0;
            int CurrentBlackTeamMate = 0;
            for (int V = 0; V < 8; V++)
            {
                for (int VV = 0; VV < 8; VV++)
                {
                    string Pecie = Board.Rows[V].Cells[VV].Value.ToString();
                    if (Pecie != "")
                    {
                        bool AddtoWhite = Val.IsWhite(Pecie);

                        if (AddtoWhite) CurrentWhiteTeamMate++;
                        else CurrentBlackTeamMate++;

                        if (Val.IsPawn(Pecie))
                            if (AddtoWhite) WhitePoint += PawnPoint;
                            else BlackPoint += PawnPoint;

                        if (Val.IsBishop(Pecie))
                            if (AddtoWhite) WhitePoint += BishopPoint;
                            else BlackPoint += BishopPoint;

                        if (Val.IsKnight(Pecie))
                            if (AddtoWhite) WhitePoint += KnightPoint;
                            else BlackPoint += KnightPoint;

                        if (Val.IsRook(Pecie))
                            if (AddtoWhite) WhitePoint += RookPoint;
                            else BlackPoint += RookPoint;

                        if (Val.IsQueen(Pecie))
                            if (AddtoWhite) WhitePoint += QueenPoint;
                            else BlackPoint += QueenPoint;
                    }
                }
            }
            int WP = BlackHeatlh.Value;
            int BP = WhiteHeatlh.Value;

            //int difference = new int();
            //WhitePoint = Math.Round(WhitePoint, 0);
            //BlackPoint = Math.Round(BlackPoint, 0);

            if (CurrentWhiteTeamMate != WhiteTeamMate)
            {
                WhiteTeamMate = CurrentWhiteTeamMate;
                if (WP != WhitePoint)
                {
                    int difference = WP - WhitePoint;
                    if (WhitePoint == TeamPoint) { }
                    else if (WhitePoint > TeamPoint) WhiteHeatlh.Value = TeamPoint;
                    else WhiteHeatlh.Value -= difference;
                }
            }
            if (CurrentBlackTeamMate != BlackTeamMate)
            {
                BlackTeamMate = CurrentBlackTeamMate;
                if (BP != BlackPoint)
                {
                    int difference = BP - BlackPoint;
                    if (BlackPoint == TeamPoint) { }
                    else if (BlackPoint > TeamPoint) BlackHeatlh.Value = TeamPoint;
                    else BlackHeatlh.Value -= difference;
                }
            }
            //WhiteHeatlh.Value += Convert.ToInt32(BlackHealth);
            //BlackHeatlh.Value += Convert.ToInt32(WhiteHealth);


            if (WhiteTurn)
            {
                //Top.Location = TopLocation;
                //Bottom.Location = BottomLocationTopLocation
                WhiteHeatlh.Location = BottomLocation;// TopLocation;
                BlackHeatlh.Location = TopLocation;

                //label1.Text = ((BlackHeatlh.Value / BlackHeatlh.Maximum) * 100).ToString();
                // label2.Text = ((WhiteHeatlh.Value / WhiteHeatlh.Maximum) * 100).ToString();
            }
            if (BlackTurn)
            {

                WhiteHeatlh.Location = TopLocation;// BottomLocation;
                BlackHeatlh.Location = BottomLocation;
                //label2.Text = ((BlackHeatlh.Value / BlackHeatlh.Maximum) * 100).ToString();
                // label1.Text = ((WhiteHeatlh.Value / WhiteHeatlh.Maximum) * 100).ToString();
            }
        }

        private void UpdateFont()
        {
            foreach (DataGridViewColumn c in Board.Columns)
            {   //45
                c.DefaultCellStyle.Font = new Font("Arial", 45, GraphicsUnit.Pixel);
            }
        }
        public void BoardSize()
        {
            double BoardX = Board.Size.Width;//Width
            double BoardY = Board.Size.Height;//Height

            double oneNinethX = BoardX / 9;
            double oneNinethY = BoardY / 9;

            foreach (DataGridViewColumn x in Board.Columns)
                x.Width = Convert.ToInt32(oneNinethX);

            foreach (DataGridViewRow x in Board.Rows)
                x.Height = Convert.ToInt32(oneNinethY);
        }
        public void BoardSet()
        {


            //string[] BlackPowerP = { "BRook", "BKnight", "BBishop", "BQueen", "BKing", "BBishop", "BKnight", "BRook" };
            //string[] BlackPawnS = { "BPawn", "BPawn", "BPawn", "BPawn", "BPawn", "BPawn", "BPawn", "BPawn" };
            //string[] WhitePawnS = { "WPawn", "WPawn", "WPawn", "WPawn", "WPawn", "WPawn", "WPawn", "WPawn" };
            //string[] WhitePowerP = { "WRook", "WKnight", "WBishop", "WQueen", "WKing", "WBishop", "WKnight", "WRook" };

            string[] BlackPowerP = { BRook, BKnight, BBishop, BQueen, BKing, BBishop, BKnight, BRook };
            string[] BlackPawnS = { BPawn, BPawn, BPawn, BPawn, BPawn, BPawn, BPawn, BPawn };
            string[] WhitePawnS = { WPawn, WPawn, WPawn, WPawn, WPawn, WPawn, WPawn, WPawn };
            string[] WhitePowerP = { WRook, WKnight, WBishop, WQueen, WKing, WBishop, WKnight, WRook };

            int tracker = 0;
            foreach (DataGridViewRow row in Board.Rows)
            {
                if (row.Index == 7)
                {
                    for (int V = 0; V < 8; V++) row.Cells[V].Value = BlackPowerP[V];
                }
                else if (row.Index == 6)
                {
                    for (int V = 0; V < 8; V++) row.Cells[V].Value = BlackPawnS[V];
                }
                else if (row.Index == 1)
                {
                    for (int V = 0; V < 8; V++) row.Cells[V].Value = WhitePawnS[V];
                }
                else if (row.Index == 0)
                {
                    for (int V = 0; V < 8; V++) row.Cells[V].Value = WhitePowerP[V];
                }
                else
                {
                    for (int V = 0; V < 8; V++) row.Cells[V].Value = "";
                }
                tracker++;
            }
            //Board.Rows[0].(BlackPowerP);
            //ToggleSides();
        }

        public void UpDateBoard()
        {
            foreach (DataGridViewRow row in Board.Rows)
            {
                for (int V = 0; V < 8; V++)
                {
                    Board.Columns[V].SortMode = DataGridViewColumnSortMode.NotSortable;
                    this.Board.Columns[V].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            NullBoard();
        }

        //public bool IsPiece(string x)
        //{
        //    if (x == WRook ||
        //        x == BRook ||
        //        x == WKing ||
        //        x == BKing ||
        //        x == WQueen ||
        //        x == BQueen ||
        //        x == WBishop ||
        //        x == BBishop ||
        //        x == WKnight ||
        //        x == BKnight ||
        //        x == WPawn ||
        //        x == BPawn)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsBlack(string x)
        //{
        //    if (x == BRook ||
        //        x == BKing ||
        //        x == BQueen ||
        //        x == BBishop ||
        //        x == BKnight ||
        //        x == BPawn)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsWhite(string x)
        //{
        //    if (x == WRook ||
        //        x == WKing ||
        //        x == WQueen ||
        //        x == WBishop ||
        //        x == WKnight ||
        //        x == WPawn)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsKing(string x)
        //{
        //    if (x == WKing ||
        //        x == BKing)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        //public bool IsQueen(string x)
        //{
        //    if (x == WQueen ||
        //        x == BQueen)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsBishop(string x)
        //{
        //    if (x == WBishop ||
        //        x == BBishop)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsKnight(string x)
        //{
        //    if (x == WKnight ||
        //        x == BKnight)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsRook(string x)
        //{
        //    if (x == WRook ||
        //        x == BRook)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public bool IsPawn(string x)
        //{
        //    if (x == WPawn ||
        //        x == BPawn)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}


        public void NullBoard()
        {
            for (int V = 0; V < 8; V++)
            {
                for (int VV = 0; VV < 8; VV++)
                {
                    Board.Rows[V].Cells[VV].Tag = false;
                }
            }
            Val.RePaintBoard();
        }

        //public void HighLightBoard()
        //{
        //    for (int V = 0; V < 8; V++)
        //    {
        //        //for (int VV = 0; VV < 8; VV++)
        //        //{
        //        //    if ((bool)Board.Rows[V].Cells[VV].Tag == false)
        //        //        Board.Rows[V].Cells[VV].
        //        //    else
        //        //        int h = 7;
        //        //}
        //    }
        //}
        //void Board_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
        //    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
        //    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
        //    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);
        //    //using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
        //    //using (var gridlinePen = new Pen(dataGridView1.GridColor, 1))
        //    if ((bool)Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == false)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
        //        using (Pen BK = new Pen(SystemColors.ControlDark, 1))
        //        using (Pen customPen = new Pen(Color.DarkSlateGray, 2))//DarkGreen //DarkSlateGray
        //        {
        //            e.Graphics.DrawLine(customPen, topLeftPoint, bottomleftPoint);
        //            e.Graphics.DrawLine(customPen, bottomRightPoint, topRightPoint);
        //            e.Graphics.DrawLine(BK, bottomRightPoint, bottomleftPoint);
        //        }
        //        e.Handled = true;
        //    }
        //    else
        //    {
        //        //e.Graphics.;
        //    }
        //}
        //private void Board_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if ((bool)Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == false)
        //    {
        //        e.back
        //    }
        //}

        private void Board_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((bool)Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == false)
            {
                e.CellStyle.BackColor = SystemColors.Control;
            }
            else
            {
                //Easter Purple     #cc99ff     204 153 255     
                //e.CellStyle.BackColor = Color.LightGreen;
                Point temp = Val.InvertY(Val.LastDoubleJump);
                if (Val.PossablePassant && e.RowIndex == temp.Y - 1 && e.ColumnIndex == temp.X)
                { e.CellStyle.BackColor = Color.FromArgb(204, 153, 255); }//MediumPurple//Magenta
                else if (Val.IsPiece(Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                { e.CellStyle.BackColor = Color.LightCoral; }
                else
                { e.CellStyle.BackColor = Color.LightGreen; }
            }
        }


        string clickOne = "";
        Point clickOneLocation;
        private void Board_CellClickOne(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NullBoard();
                clickOne = Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (clickOne != "" && clickOne != null)
                {
                    //NullBoard();
                    clickOneLocation.X = e.ColumnIndex;
                    clickOneLocation.Y = e.RowIndex;
                    //clickOneColumen = e.ColumnIndex;
                    //clickOneRow = e.RowIndex;
                    Board.CellClick -= Board_CellClickOne;
                    Board.CellClick += Board_CellClickTwo;
                    Val.ShowMoves(clickOneLocation, clickOne);

                }
            }
            catch { }
        }


        string clickTwo = "";
        Point clickTwoLocation;
        //bool FromClickTwo = false;
        private void Board_CellClickTwo(object sender, DataGridViewCellEventArgs e)
        {
            clickTwo = Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            clickTwoLocation.X = e.ColumnIndex;
            clickTwoLocation.Y = e.RowIndex;
            bool theHell = true;
            bool Exit = false;


            if ((bool)Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag)
            {

                PieceMove(clickOneLocation, clickTwoLocation);
                ToggleSides();

                clickOneLocation = new Point();
                clickTwoLocation = new Point();
                Board.CellClick += Board_CellClickOne;
                Board.CellClick -= Board_CellClickTwo;
                NullBoard();
                theHell = false;
            }

            else if (clickTwo == "" || clickTwo == null)
            {
                theHell = false;
                NullBoard();
            }

            else if (WhiteTurn)
            {
                if (Val.IsWhite(clickTwo))
                {
                    NullBoard();
                    theHell = false;
                    clickOne = clickTwo;
                    clickOneLocation = clickTwoLocation;
                    Val.ShowMoves(clickTwoLocation, clickTwo);
                }
                else Exit = true;
            }

            else if (BlackTurn)
            {
                if (Val.IsBlack(clickTwo))
                {
                    NullBoard();
                    theHell = false;
                    clickOne = clickTwo;
                    clickOneLocation = clickTwoLocation;
                    Val.ShowMoves(clickTwoLocation, clickTwo);
                }
                else Exit = true;
            }


            if (Exit)
            {

                NullBoard();
                theHell = false;
                clickOneLocation = new Point();
                clickTwoLocation = new Point();
                Board.CellClick += Board_CellClickOne;
                Board.CellClick -= Board_CellClickTwo;

            }
            else if (theHell)
            {
                MessageBox.Show("...");
                MessageBox.Show("How you hell did you manage this?");

            }
        }

        private string PointToString(Point p)
        {
            string col = Board.Columns[p.X].HeaderText.ToString().ToLower();
            string row = Board.Rows[p.Y].HeaderCell.Value.ToString();
            return col + row;
        }
        private void PieceMove(Point Intial, Point Final)
        {
            string currenTeam = "";
            if (WhiteTurn)
                currenTeam = "W: ";
            else
                currenTeam = "B : ";

            string CurrentPiece = Val.WhatPiece(Intial);
            currenTeam += CurrentPiece;
            string mid = "";
            if (Val.IsPiece(Final))
                mid = " x ";
            else
                mid = " to ";

            string Notation = currenTeam + PointToString(Intial) + mid + PointToString(Final);

            if (Final.Y == 0 && CurrentPiece == "P")
            {
                if (WhiteTurn)
                {
                    clickOne = Val.WQueen;
                    Notation = currenTeam + PointToString(Final) + " = Q";
                }
                else
                {
                    clickOne = Val.BQueen;
                    Notation = currenTeam + PointToString(Final) + " = Q";
                }
            }


            listBox1.Items.Add(Notation);
            Board.Rows[Final.Y].Cells[Final.X].Value = clickOne;
            Board.Rows[Intial.Y].Cells[Intial.X].Value = "";

            if (Val.PossablePassant)
                Board.Rows[Final.Y + 1].Cells[Final.X].Value = "";
            if (Final == Val.LastDoubleJumpTemp)
                Val.LastDoubleJump = Final;
            else
            {
                Val.LastDoubleJump = new Point();
                Val.LastDoubleJumpTemp = new Point();
            }
        }

        public async void WaitSomeTime()
        {
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = false;
            await Task.Delay(200);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        //Pawn - 1 point
        //Knight - 3 points
        //Bishop - 3 points
        //Rook - 5 points
        //Queen - 9 points
        //List<DataGridViewRow> Lil = new List<DataGridViewRow>();
        //List<DataGridViewRow> Bil = new List<DataGridViewRow>();
        private void ToggleSides()
        {
            //WaitSomeTime();
            NullBoard();
            Val.RePaintBoard();
            List<string[]> ro = new List<string[]>();
            for (int x = 0; x < 8; x++)
            {
                string[] Row = {
                Board.Rows[7-x].Cells[0].Value.ToString(),
                Board.Rows[7-x].Cells[1].Value.ToString(),
                Board.Rows[7-x].Cells[2].Value.ToString(),
                Board.Rows[7-x].Cells[3].Value.ToString(),
                Board.Rows[7-x].Cells[4].Value.ToString(),
                Board.Rows[7-x].Cells[5].Value.ToString(),
                Board.Rows[7-x].Cells[6].Value.ToString(),
                Board.Rows[7-x].Cells[7].Value.ToString()
                };
                ro.Add(Row);
            }

            foreach (DataGridViewRow row in Board.Rows)
            {
                string[] Row = ro[row.Index];
                for (int V = 0; V < 8; V++)
                {
                    row.Cells[V].Value = Row[V];
                }
            }

            WhiteTurn = !WhiteTurn;
            BlackTurn = !BlackTurn;

            PecieCounter();


            if (WhiteTurn)
            {
                Board.Rows[0].HeaderCell.Value = "8";
                Board.Rows[1].HeaderCell.Value = "7 ";
                Board.Rows[2].HeaderCell.Value = "6 ";
                Board.Rows[3].HeaderCell.Value = "5 ";
                Board.Rows[4].HeaderCell.Value = "4 ";
                Board.Rows[5].HeaderCell.Value = "3 ";
                Board.Rows[6].HeaderCell.Value = "2 ";
                Board.Rows[7].HeaderCell.Value = "1 ";
            }
            else
            {
                Board.Rows[0].HeaderCell.Value = "1";
                Board.Rows[1].HeaderCell.Value = "2 ";
                Board.Rows[2].HeaderCell.Value = "3 ";
                Board.Rows[3].HeaderCell.Value = "4 ";
                Board.Rows[4].HeaderCell.Value = "5 ";
                Board.Rows[5].HeaderCell.Value = "6 ";
                Board.Rows[6].HeaderCell.Value = "7 ";
                Board.Rows[7].HeaderCell.Value = "8 ";
            }

            Board.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Board.Rows[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            //Val.RePaintBoard();
            //ScoreTracker.RunWorkerAsync(test);
            Board.CurrentCell = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleSides();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoardSet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Board.CellClick -= Board_CellClickOne;
            Board.CellClick -= Board_CellClickTwo;
            Board.CellClick += Board_CellClickSet;
        }

        //private void Top()
        //{
        //    //for (int i = 0; i < 4; i++)
        //    //    for (int V = 0; V < 8; V++)
        //    //        Board.Rows[i].Cells[V].Value = Lil[7 - i].Cells[V].Value;//.ToString();
        //}
        //private void Bot()
        //{
        //    //for (int i = 4; i < 8; i++)
        //    //    for (int V = 0; V < 8; V++)
        //    //        Board.Rows[i].Cells[V].Value = Bil[7 - i].Cells[V].Value;//.ToString();

        //}
        ////private void button1_Click(object sender, EventArgs e)
        ////{
        //    Top();
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Bot();
        //}
        //private void UpdateHeatlh()
        //{
        //}

        private void Board_CellClickSet(object sender, DataGridViewCellEventArgs e)
        {
            string space = "";
            if (Nul.Checked) space = "";
            else if (Wteam.Checked)
            {
                if (KP.Checked) space = WKing;
                else if (QP.Checked) space = WQueen;
                else if (BP.Checked) space = WBishop;
                else if (NP.Checked) space = WKnight;
                else if (RP.Checked) space = WRook;
                else if (PP.Checked) space = WPawn;
                else if (Nul.Checked) space = "";
            }
            else
            {
                if (KP.Checked) space = BKing;
                else if (QP.Checked) space = BQueen;
                else if (BP.Checked) space = BBishop;
                else if (NP.Checked) space = BKnight;
                else if (RP.Checked) space = BRook;
                else if (PP.Checked) space = BPawn;
                else if (Nul.Checked) space = "";
            }
            Board.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = space;
            //Board.CellClick -= Board_CellClickTwo;
            //Board.CellClick -= Board_CellClickSet;
            //Board.CellClick += Board_CellClickOne;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Board.CellClick -= Board_CellClickTwo;
            Board.CellClick -= Board_CellClickSet;
            Board.CellClick += Board_CellClickOne;
        }
    }

    public class TestObject
    {
        public int OneValue { get; set; }
        public int TwoValue { get; set; }
    }

}
