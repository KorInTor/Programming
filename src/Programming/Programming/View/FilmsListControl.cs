using Programming.Model;
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

namespace Programming.View
{
    public partial class FilmsListControl : UserControl
    {
        private Movie[] _films;
        private Movie _currentFilm = new Movie();
        private string[] _filmNames = new string[] {"The Shawshank Redemption", "The Godfather",
            "The Dark Knight", "The Godfather Part II", "12 Angry Men", "Schindler’s List",
            "The Lord of the Rings: The Return of the King", "Pulp Fiction",
            "The Lord of the Rings: The Fellowship of the Ring", "The Good the Bad and the Ugly",
            "Forrest Gump", "Fight Club", "The Lord of the Rings: The Two Towers", "Inception",
            "Star Wars: Episode V - The Empire Strikes Back", "The Matrix", "Goodfellas",
            "One Flew Over the Cuckoo’s Nest", "Se7en", "Seven Samurai" };
        public FilmsListControl()
        {
            InitializeComponent();
            InitializeFilmList();
            FilmsListBox.SelectedIndex = 0;
        }
        private void InitializeFilmList()
        {
            Random random = new Random();
            _films = new Movie[5];
            int lengthGenre = Enum.GetNames(typeof(Genre)).Length;
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Movie(
                random.Next(1, 322),
                random.Next(1900, 2023),
                random.Next(1, 10),
                _filmNames[random.Next(0, _filmNames.Length)],
                ((Genre)random.Next(lengthGenre)).ToString());
            }
        }
        private int FindFilmWithMaxRating(Movie[] _films)
        {
            double MaxRating = 0;
            int Index = 0;
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > MaxRating)
                {
                    MaxRating = _films[i].Rating;
                    Index = i;
                }
            }
            return Index;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];
            FilmsDurationTextBox.Text = (_currentFilm.DurationInMinutes).ToString();
            FilmsYearOfReleaseTextBox.Text = (_currentFilm.YearOfRelease).ToString();
            FilmsTitleTextBox.Text = _currentFilm.Title;
            FilmsGenreTextBox.Text = _currentFilm.Genre;
            FilmsRatingTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void FilmsTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = FilmsTitleTextBox.Text;
        }

        private void FilmsDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.DurationInMinutes = Convert.ToInt32(FilmsDurationTextBox.Text);
                FilmsDurationTextBox.BackColor = NormalColor;
            }
            catch (Exception)
            {
                FilmsDurationTextBox.BackColor = ErrorColor;
                return;
            }
        }

        private void FilmsYearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.YearOfRelease = int.Parse(FilmsYearOfReleaseTextBox.Text);
                FilmsYearOfReleaseTextBox.BackColor = NormalColor;
            }
            catch (Exception)
            {
                FilmsYearOfReleaseTextBox.BackColor = ErrorColor;
            }
        }

        private void FilmsGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = FilmsGenreTextBox.Text;
        }

        private void FilmsRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = int.Parse(FilmsRatingTextBox.Text);
                FilmsRatingTextBox.BackColor = NormalColor;
            }
            catch (Exception)
            {
                FilmsRatingTextBox.BackColor = ErrorColor;
            }
        }
        private void FilmsFindMaxRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }
    }
}
