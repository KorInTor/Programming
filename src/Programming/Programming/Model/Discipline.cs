using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Содержит данные о изучаемой дисциплине.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Закрытоое поле хранящее номер семестра.
        /// </summary>
        private int _semester;

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string Professor { get; set; }

        /// <summary>
        /// Закрытое поле хранящее оценки.
        /// </summary>
        private double _grade;

        
        /// <summary>
        /// Возвращает и задаёт номер семестра, значение должно быть положительным.
        /// </summary>
        public int Semester
        {
            get
            {
                return _semester;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Semester));
                _semester = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт Оценку. Должна быть от 2 до 5.
        /// </summary>
        public double Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                Validator.AssertValueInRange(value, 2, 5, nameof(Grade));
                _grade = value;
            }
        }

        public Discipline() { }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="semester">Номер семестра. Должен быть положительным.</param>
        /// <param name="professor">Имя преподавателя.</param>
        /// <param name="grade">Оценка. Должна быть от 2 до 5.</param>
        public Discipline(string name, int semester, string professor, double grade)
        {
            Name = name;
            Semester = semester;
            Professor = professor;
            Grade = grade;
        }
    }
}
