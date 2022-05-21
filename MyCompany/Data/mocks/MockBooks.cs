using MyCompany.Data.interfaces;
using MyCompany.wwwroot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Data.mocks
{
    public class MockBooks: IAllBooks
    {
        private readonly IBooksCategory _booksCategory = new MockCategory();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book
                    {
                        name = "Гарри Потер",
                        shortDecc = "Серия фильмов о Гарри Поттере — серия фильмов, основанных на книгах о Гарри Поттере английской писательницы Дж. К. Роулинг.",
                        longDesc = "«Га́рри По́ттер и филосо́фский ка́мень» (англ. Harry Potter and the Philosopher’s Stone, в США и Индии вышел под названием Harry Potter and the Sorcerer’s Stone[3][4]) — британско-американский фэнтезийный фильм 2001 года режиссёра Криса Коламбуса по сценарию Стива Кловиса. Первый фильм франшизы о мальчике-волшебнике Гарри Поттере, экранизация одноимённого романа Джоан Роулинг (1997). Главные роли исполнили Дэниел Рэдклифф, Руперт Гринт и Эмма Уотсон. Во многих взрослых ролях заняты ведущие британские актёры, такие как Мэгги Смит, Алан Рикман, Джон Клиз и другиеПерейти к разделу «#Актёры и роли».Проект был официально запущен в производство в 1999 году после того,как компания Warner Bros.выкупила у Джоан Роулинг права на адаптацию первых четырёх романов.В марте 2000 года режиссёром фильма назначили Криса Коламбуса,а написать сценарий было поручено Стиву Кловису,которого утвердили месяцем ранееПерейти к разделу «#Разработка». Съёмки картины проходили с осени 2000 по весну 2001 года в студии Leavesden и многочисленных архитектурных строениях АнглииПерейти к разделу «#Съёмки».Фильм был выпущен в США и Великобритании 16 ноября 2001 года.Кинолента получила положительные отзывы критиковПерейти к разделу «#Критика», а также имела коммерческий успех, собрав более 1 млрд долларов по всему миру и став самым кассовым фильмом 2001 годаПерейти к разделу «#Кассовые сборы». Картина выдвигалась на три премии «Оскар» (лучшие костюмы, лучшая работа художника-постановщика и лучшая музыка), а также была удостоена множества других наград и номинацийПерейти к разделу «#Награды и номинации». В период с 2002 по 2011 год вышло семь продолжений фильма.",
                        img = "https://static.daru-dar.org/s1024/02/01/07/13/0713b92aa67b09e2b12da60da42f2931a12de722.jpg",
                        price = 5000,
                        isFavourite = true,
                        available = true,
                        Category = _booksCategory.AllCategories.First()

                    }
                };
            }
        }

        public IEnumerable<IBooksCategory> getFavBooks => throw new NotImplementedException();

        public IBooksCategory getObjectByBook(int bookID)
        {
            throw new NotImplementedException();
        }
    }
}
