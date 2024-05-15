# Разработка информационной системы по школьному предмету “Химия” (C#)

### [Скриншоты программы](https://drive.google.com/drive/folders/1Ofs-2jfTpFQ3pcADwuJfEWOFzGr_FT0r)
*Хранение изображений: Google.disk*

![скрин1](https://github.com/serega23467/ChemistryEducation/assets/114952677/38685906-6672-4c88-a17b-67f0e834cc84)

## Функциональность

1. **Просмотр лекций**: Пролистываемый список слева содержит все темы, выбирая одну из них лекция переключается.

2. **Поиск в таблице просмотр таблицы Менделеева**: По нажатию на кнопку открывается таблица Менделеева.

3. **Поиск в таблице Менделеева**: Пользователь может искать химический элемент по ключевым словам, содержащимся в номере, символе, названии элемента.


## Технические детали

- **Разработано на **: WinForms
- **База данных**: SQLite с использованием Entity Framework
- **Гибкая архитектура**: Возможно добавление огромного количества лекций, переключение между ними останется комфортным

  ## Создание классов ChemystryEducation и ApplicationContext для связи с БД

``` C#
using System.ComponentModel.DataAnnotations;
namespace ChemistryEducation
{
    public class ChemicalElement
    {
        [Key]
        public string ElementNumber { get; set; }
        public string ElementName { get; set; }
        public string ElementFullname { get; set; }
        public string Description { get; set; }
        public string MetalStatus { get; set; }

        //конструктор по умолчанию необходим для подключения
        public ChemicalElement() { }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ChemistryEducation
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ChemicalElement> PeriodicTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ChemicalInfo.db");
        }
    }
}

ChemicalElement представляет отдельную запись в БД, атрибут Key обозначает первичный ключ. ApplicationContext представляет подключение к БД.
```
  ## Код создания таблицы PeriodicTable SQLite

``` SQLite
CREATE TABLE PeriodicTable (
    ElementNumber INTEGER PRIMARY KEY,
    ElementName TEXT,
    ElementFullname TEXT,
    Description TEXT,
    MetalStatus TEXT
)

По порядку: номер элемента в таблице, его символ (например H), полное название (например Водород), Краткое описание, Металл это или неметалл
```

## Автор программы

### Сергей А.
