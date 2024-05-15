# Разработка информационной системы по школьному предмету “Химия” (C#)

![скрин1](https://github.com/serega23467/ChemistryEducation/assets/114952677/38685906-6672-4c88-a17b-67f0e834cc84)
![скрин2](https://github.com/serega23467/ChemistryEducation/assets/114952677/002f6d7d-b943-49bc-804d-186ad4277a0a)
![скрин3](https://github.com/serega23467/ChemistryEducation/assets/114952677/b778ee2f-2361-4a85-8035-86f86714108e)
![скрин4](https://github.com/serega23467/ChemistryEducation/assets/114952677/ce97d430-a0d5-438e-b2ce-e63cf72c6881)
![скрин5](https://github.com/serega23467/ChemistryEducation/assets/114952677/c663b9f7-6b28-4378-b035-f273b0ade26b)


## Функциональность

1. **Просмотр лекций**: Пролистываемый список слева содержит все темы, выбирая одну из них лекция переключается.

2. **Поиск в таблице просмотр таблицы Менделеева**: По нажатию на значок слева сверху открывается таблица Менделеева.

3. **Поиск в таблице Менделеева**: Пользователь может искать химический элемент по ключевым словам, содержащимся в номере, символе, названии элемента.


## Технические детали

- **Разработано на**: WinForms
- **База данных**: SQLite с использованием Entity Framework
- **Гибкая архитектура**: Возможно добавление огромного количества лекций, переключение между ними останется комфортным

  ## Создание классов ChemicalElement и ApplicationContext для связи с БД

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
