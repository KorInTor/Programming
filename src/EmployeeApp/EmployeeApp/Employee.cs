using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    /// <summary>
    /// Хранит информацию о сотруднике.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Закрытое поле данного класса, хранит информацию о полном именни сотрудника.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Закрытое поле данного класса, хранит информацию о должности сотрудника.
        /// </summary>
        private string _position;

        /// <summary>
        /// Закрытое поле данного класса, хранит информацию о дате найма сотрудника. Не может быть в будущем.
        /// </summary>
        private DateTime _dateOfEmployment;

        /// <summary>
        /// Закрытое поле данного класса, хранит информацию о зарплает сотрудника. Должно быть выщественным числов.
        /// </summary>
        private double _salary;

        /// <summary>
        /// Возвращает, уникальный номер присвоенный каждому сотруднику.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Статичный счётчик работников данного класса.
        /// </summary>
        private static int _employeeCount = 0;

        /// <summary>
        /// Возвращает и задаёт значение полного имени. Значение не должно превышать 500 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertStringLengthInRange(value, 500,nameof(FullName));
                _fullName = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт значение должности. Значение не должно превышать 50 символов.
        /// </summary>
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                Validator.AssertStringLengthInRange(value, 50, nameof(FullName));
                _position = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение даты найма. Значение не должно быть в будущем.
        /// </summary>
        public DateTime DateOfEmployment
        {
            get
            {
                return _dateOfEmployment;

            }
            set
            {
                Validator.AssertDateIsntFuture(value, nameof(DateOfEmployment));
                _dateOfEmployment = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение зарплаты. Должно быть вещественным числом.
        /// </summary>
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 500000,nameof(Salary));
                _salary = value;
            }
        }

        /// <summary>
        /// Конструкор, cоздаёт экземпляр класса <see cref="Employee"/>. При какждом вызове увеличивает <see cref="_employeeCount"/> на 1.
        /// </summary>
        /// <param name="fullName">Полное имя. Значение не должно превышать 500 символов.</param>
        /// <param name="position">Должность. Значение не должно превышать 50 символов.</param>
        /// <param name="dateOfEmployment">Дата найма, не может быть в будущем.</param>
        /// <param name="salary">Зарплата. Должна быть вещественным числом.</param>
        public Employee(string fullName, string position, DateTime dateOfEmployment, double salary)
        {
            FullName = fullName;
            Position = position;
            DateOfEmployment = dateOfEmployment;
            Salary = salary;
            Id = _employeeCount;
            _employeeCount = _employeeCount + 1;
        }
    }
}
