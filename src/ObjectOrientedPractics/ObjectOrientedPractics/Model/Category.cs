using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Открытое перечисление, хранит наименование категорий товара.
    /// </summary>
    public enum Category
    {
        ElectricalAndLighting = 1, //Электрика и свет.
        BrakeSystem, //Тормозная система.
        Accessory, //Аксесуар.
        Suspension, //Подвеска.
        Trim, //Диски.
        Tire, //Шины.
        EnginePart, //Части двигателя.
    }
}
