using System;
using Programming.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Programming.Model.AppColors;
using Rectangle = Programming.Model.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View
{
    public partial class RectanglesListControl : UserControl
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle = new Rectangle();
        public RectanglesListControl()
        {
            InitializeComponent();
            InittializeRectangleList();
            RectanglesListBox.SelectedIndex = 0;
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectanglesLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectanglesColorTextBox.Text = _currentRectangle.Color;
            RectanglesXCoordinateTextBox.Text = _currentRectangle.Center.X.ToString();
            RectanglesYCoordinateTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectanglesIdTextBox.Text = _currentRectangle._id.ToString();
        }
        private void RectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToInt32(RectanglesLengthTextBox.Text);
                RectanglesLengthTextBox.BackColor = NormalColor;
            }
            catch (Exception)
            {
                RectanglesLengthTextBox.BackColor = ErrorColor;
            }
        }
        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToInt32(RectanglesWidthTextBox.Text);
                RectanglesWidthTextBox.BackColor = NormalColor;
            }
            catch (Exception)
            {
                RectanglesWidthTextBox.BackColor = ErrorColor;
            }
        }
        private void RectanglesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectanglesColorTextBox.Text;
        }
        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
        private void InittializeRectangleList()
        {
            Random random = new Random();
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _currentRectangle = RectangleFactory.Randomize(100, 100);
                _rectangles[i] = _currentRectangle;
            }
        }
        private int FindRectangleWithMaxWidth(Rectangle[] _rectangles)
        {
            double MaxWidth = 0;
            int Index = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = _rectangles[i].Width;
                    Index = i;
                }
            }
            return Index;
        }
    }
}
