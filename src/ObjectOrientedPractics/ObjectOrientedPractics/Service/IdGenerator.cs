using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Реализует генерацию уникальных идентификаторов.
    /// </summary>
    static class IdGenerator
    {
        /// <summary>
        /// Хранит новый уникальный идентификатор.
        /// </summary>
        private static int nextId = 1;

        /// <summary>
        /// Возвращает значение нового уникального идентификатора.
        /// </summary>
        /// <returns>Новый уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return nextId++;
        }
    }
}
