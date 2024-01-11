using Programming.Model.Geometry;
using System;
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

namespace Programming.View
{
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Переменная типа <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        /// <summary>
        /// List типа <see cref="Rectangle"/>. Хранит значения прямоугольников.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();

        /// <summary>
        /// List типа <see cref="Panel"/> для содержания панелей выведенных на канву.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сравнивает все предметы списка <see cref="_rectanglePanels"/> пересекаются ли они.
        /// В случае пересечения меняет их цвет на <see cref="ErrorColor"/>
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (i != j && CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                    {
                        _rectanglePanels[i].BackColor = ErrorColor;
                        _rectanglePanels[j].BackColor = ErrorColor;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет значения для TextBox'ов относительно заданного прямоугольника.
        /// </summary>
        /// <param name="rectangle">Заданный прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            SelectedRectangleIdTextBox.Text = rectangle._id.ToString();
            SelectedRectangleXTextBox.Text = rectangle.Center.X.ToString();
            SelectedRectangleXTextBox.BackColor = NormalColor;
            SelectedRectangleYTextBox.Text = rectangle.Center.Y.ToString();
            SelectedRectangleYTextBox.BackColor = NormalColor;
            SelectedRectangleWidthTextBox.Text = rectangle.Width.ToString();
            SelectedRectangleWidthTextBox.BackColor = NormalColor;
            SelectedRectangleHeightTextBox.Text = rectangle.Length.ToString();
            SelectedRectangleHeightTextBox.BackColor = NormalColor;
        }

        /// <summary>
        /// Очищает TextBoxes и придаёт им цвет <see cref="NormalColor"/>.
        /// </summary>
        private void ClearRectangleInfo()
        {
            SelectedRectangleHeightTextBox.Clear();
            SelectedRectangleHeightTextBox.BackColor = NormalColor;
            SelectedRectangleWidthTextBox.Clear();
            SelectedRectangleWidthTextBox.BackColor = NormalColor;
            SelectedRectangleXTextBox.Clear();
            SelectedRectangleXTextBox.BackColor = NormalColor;
            SelectedRectangleYTextBox.Clear();
            SelectedRectangleYTextBox.BackColor = NormalColor;
            SelectedRectangleIdTextBox.Clear();
        }

        /// <summary>
        /// Обновляет данные на лист бокс для выбранного прямоугольника значениями из <see cref="_currentRectangle"/>
        /// </summary>
        private void UpdateSelectedRectangle()
        {
            RectanglesPanelListBox.Items[RectanglesPanelListBox.SelectedIndex] = ($"{_currentRectangle._id}: "+
                $"(X= {_currentRectangle.Center.X}" +
                $"; Y={_currentRectangle.Center.Y}; " +
                $"W={_currentRectangle.Width}; H={_currentRectangle.Length})");
        }

        private void RectanglesButtonAdd_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectanglesList.Add(rectangle);
            RectanglesPanelListBox.Items.Add($"{rectangle._id}: (X= {rectangle.Center.X}; Y={rectangle.Center.Y}; " +
                $"W={rectangle.Width}; H={rectangle.Length})");
            Panel panel = new Panel();
            panel.Height = (int)rectangle.Length;
            panel.Width = (int)rectangle.Width;
            panel.Location = new Point((int)rectangle.Center.X, (int)rectangle.Center.Y);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
            FindCollisions();
        }
        private void RectanglesButtonRemove_Click(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedItem != null && RectanglesPanelListBox.Items.Count != 0)
            {
                _rectanglesList.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                CanvasPanel.Controls.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                RectanglesPanelListBox.Items.Remove(RectanglesPanelListBox.SelectedItem);
                FindCollisions();
            }
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedItem == null || RectanglesPanelListBox.Items.Count == 0)
            {
                ClearRectangleInfo();
            }
            else
            {
                _currentRectangle = _rectanglesList[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                _currentRectangle.Center.X = Convert.ToInt32(SelectedRectangleXTextBox.Text);
                SelectedRectangleXTextBox.BackColor = NormalColor;
                UpdateSelectedRectangle();
                _rectanglePanels[RectanglesPanelListBox.SelectedIndex].Location = new Point((int)_currentRectangle.Center.X, (int)_currentRectangle.Center.Y);
                FindCollisions();

            }
            catch (Exception)
            {
                SelectedRectangleXTextBox.BackColor = ErrorColor;
            }
        }
        private void SelectedRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                _currentRectangle.Center.Y = Convert.ToInt32(SelectedRectangleYTextBox.Text);
                SelectedRectangleYTextBox.BackColor = NormalColor;
                UpdateSelectedRectangle();
                _rectanglePanels[RectanglesPanelListBox.SelectedIndex].Location = new Point((int)_currentRectangle.Center.X, (int)_currentRectangle.Center.Y);
                FindCollisions();
            }
            catch (Exception)
            {
                SelectedRectangleYTextBox.BackColor = ErrorColor;
            }
        }

        private void SelectedRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                _currentRectangle.Width = Convert.ToInt32(SelectedRectangleWidthTextBox.Text);
                SelectedRectangleWidthTextBox.BackColor = NormalColor;
                UpdateSelectedRectangle();
                _rectanglePanels[RectanglesPanelListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                FindCollisions();
            }
            catch (Exception)
            {
                SelectedRectangleWidthTextBox.BackColor = ErrorColor;
            }
        }

        private void SelectedRectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                _currentRectangle.Length = Convert.ToInt32(SelectedRectangleHeightTextBox.Text);
                SelectedRectangleHeightTextBox.BackColor = NormalColor;
                UpdateSelectedRectangle();
                _rectanglePanels[RectanglesPanelListBox.SelectedIndex].Height = (int)_currentRectangle.Length;
                FindCollisions();
            }
            catch (Exception)
            {
                SelectedRectangleHeightTextBox.BackColor = ErrorColor;
            }
        }

        private void PictureBoxAdd_MouseHover(object sender, EventArgs e)
        {
            PictureBoxAdd.Image = Programming.Properties.Resources.rectangle_add_24x24;
        }

        private void PictureBoxAdd_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxAdd.Image = Programming.Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void PictureBoxRemove_MouseEnter(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Programming.Properties.Resources.rectangle_remove_24x24;
        }
        private void PictureBoxRemove_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxRemove.Image = Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
