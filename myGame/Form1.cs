using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int _stepArrow = 10;

        Button btn = new Button();
        Button btnMin;

        private List<Mar> _objMar = new List<Mar>();        
        private int _number = 0;
        private void CreateMin()
        {
            btnMin = new Button();
            Random rand = new Random();
            var x = rand.Next(1, 85) * _stepArrow;
            var y = rand.Next(1, 42) * _stepArrow;

            btnMin.Location = new Point(x, y);
            btnMin.Size = new Size(20, 20);
            btnMin.BackColor = Color.Blue;
            panelBoard.Controls.Add(btnMin);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn.Size = new Size(20, 20);
            btn.Location = new Point(410, 210);
            btn.BackColor = Color.Red;
            panelBoard.Controls.Add(btn);
            Mar obj = new Mar
            {
                X = btn.Location.X,
                Y = btn.Location.Y,
                Active = true,
            };
            _objMar.Add(obj);
            CreateMin();
            txtNumber.Text = _number.ToString(); ;
        }
        public void CheckMin()
        {
            if((btnMin.Location.X == _objMar[0].X)&&
                (btnMin.Location.Y == _objMar[0].Y))
            {
                _number++;
                txtNumber.Text = _number.ToString();
                btnMin.Dispose();
                CreateMin();
            }
        }
        private void btnTop_Click(object sender, EventArgs e)
        {
            _objMar[0].Y -= _stepArrow;
            _objMar[0].Arrowkey = Arrow.Top;
            btn.Location = new Point(_objMar[0].X, _objMar[0].Y);
            CheckMin();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _objMar[0].X += _stepArrow;
            _objMar[0].Arrowkey = Arrow.Right;
            btn.Location = new Point(_objMar[0].X, _objMar[0].Y);
            CheckMin();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            _objMar[0].Y += _stepArrow;
            _objMar[0].Arrowkey = Arrow.Bottom;
            btn.Location = new Point(_objMar[0].X, _objMar[0].Y);
            CheckMin();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _objMar[0].X -= _stepArrow;
            _objMar[0].Arrowkey = Arrow.Left;
            btn.Location = new Point(_objMar[0].X, _objMar[0].Y);
            CheckMin();
        }
    }
}
