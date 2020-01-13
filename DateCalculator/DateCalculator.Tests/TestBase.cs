using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Tests
{
    // базовый класс для всех тестов 
    [TestFixture] 
    public class TestBase
    {
        #region TestCharacteristics
        // Характеристики хорошего теста: 
        // 1. Независимость, те создаем новый экз класса.
        // 2. Атомарность, каждый тест тестирует один конкретный кейс.
        // 3. Быстрота выполнения, максимально быстрый тест - меньше минуты
        // 4. Повторяемость, всегда выдает одинаковый результат независимо от кол-ва и порядка запуска тестов. 
        // 5. Независимость от внешних факторов ( БД, ОС, интернет, диск, файловая система и тд ) 
        #endregion

        [SetUp] 
        public void Setup()
        {

        }
    }
}
