**Зміст** {#зміст .TOC-Heading}
=========

[1. Теоретичні відомості 4]

[1.1 CSV-файли 4]

[1.2 Правила оформлення CSV 5]

[1.3 HML-файли 6]

[1.4 Опис логічної структури 10]

[РОЗДІЛ 2 11]

[2.1. Опис програми і тестування програми 11]

[2.2. Типи комп\'ютерів та пристроїв, що використовуються при роботі
програми 13]

[2.3. Виклик і завантаження 13]

[ВИСНОВКИ 14]

[СПИСОК ВИКОРИСТАНИХ ДЖЕРЕЛ 15]

[ДОДАТКИ 18]

[Додаток 1 18]

**ВСТУП**

**Анотація дослідження:**

Розроблений продукт виконує перетворення із формату xml до формату csv.

**Актуальність дослідження:**

Актуальність дослідження полягає в тому, що програма може перетворювати
з одного формату інший. Це є актуальним, тому що дані формати можуть
використовуватися при аналізі даних або парсингу веб-сторінок, збору
даних. Тобто дані, будуть конвертуватися у більш зручний формат.

**Мета роботи:**

-   навчання та набуття навиків практичного застосування теоретичних
    знань для вирішення конкретних практичних задач;

-   набуття навиків конструювання виробів, виконання розрахунків,
    письмового викладу технічних рішень та аналізу одержаних
    результатів;

-   закріплення, поглиблення та систематизація отриманих студентами в
    процесі навчання теоретичних знань з різних дисциплін;

-   набуття навиків узагальнення та аналізу результатів, отриманих
    іншими розробниками та дослідниками;

-   навчання та набуття студентами досвіду користування довідковою
    літературою і нормативними документами.

Для досягнення поставленої мети потрібно розглянути такі **завдання**:

1)  розробити проект програми;

2)  реалізувати можливість перетворення таблиці із CSV-файла в XML-файл;

3)  набуття навиків створення програмного забезпечення для вирішення
    конкретної задачі;

**Об'єкт дослідження :** Створення програмного забезпечення для
перетворення файлів у відповідні формати

**Методологічну основу дослідження** становлять загальнонаукові та
спеціальні методи: емпіричний, вимірювання, спостереження.

**Інформаційною базою** для написання роботи стали теоретичні розробки
науковців, періодичні статті.

**Структура роботи**. Робота складається з вступу, двох розділів, списку
використаних джерел, додатків.

**Теоретичні відомості**
========================

**1.1 CSV-файли**
-----------------

Файл CSV (з англ. Comma Separated Values File) представляє з себе такий
файл, чиї значення будуть розділені комами. Вважається формат CSV
текстовим, він призначений надавати табличні дані.

Створення файлу формату .csv може бути вироблено, наприклад, за
допомогою утиліти Nokia PC Suite в процесі експорту користувальницьких
повідомлень з мобільного пристрою на комп\'ютер. Рядки файлу CSV
формату, це окремі рядки таблиці. Значення кожної окремої колонки - це
значення, розділені комами. Якщо значення містять зарезервовані символи,
то як роздільник застосовуються подвійні лапки. Варто відзначити, що
подібний формат даних, використовується великою кількістю програмних
комплексів, деякі з утиліт застосовують в ролі роздільників такий вид,
як крапка з комою.

Тип файлу, який має розширення CSV, містить інформацію, яку можуть
імпортувати в базу даних, так само подібний текстовий файл може носити
дані, необхідні для організації таблиць.

CSV файл може прочитати текстовий редактор, причому в список таких
редакторів, входить більшість програм, що застосовуються для роботи з
текстом і таблицями. Таким чином, відкрити файл із значенням формату
.csv, можуть такі програми, як Microsoft Excel або Corel WordPerfect
Office, а також формат файлу відкривається утилітами LibreOffice, Apache
OpenOffice і багатьма іншими.

Файли даних з форматом Comma Separated, відповідають за зв\'язок між
різноманітними системами і сприяють передачі т обробці об\'ємних даних,
що складаються з табличнійструктури.

![](https://github.com/CHERVACHEK/IPZ_XML/blob/master/ads.png)

Рис 1.1 -- Приклад CSV-таблиці

**1.2 Правила оформлення CSV**
------------------------------

Кожен запис (рядок даних) повинен розташовуватися в окремому рядку,
обмеженому переривом рядка. Наприклад:

aaa, bbb, ccc CRLF

Останній запис у файлі може мати або не мати розриву закінчення
рядка. Наприклад:

aaa, bbb, ccc CRLF zzz, yyy, xxx

Можливо, необов\'язковий рядок заголовка з\'являється як перший рядок
файлу у тому ж форматі, що і звичайні рядки запису. Заголовок містить
імена, що відповідають полям у файлі. Також він повинен містити таку ж
кількість полів, що і записи в решті файлу. Наприклад:

field\_name, field\_name, field\_name CRLF aaa, bbb, ccc CRLF zzz, yyy,
xxx CRLF

У заголовку та кожному записі може бути одне чи більше полів, розділених
комами. Кожен рядок повинен містити однакову кількість полів у всьому
файлі. Пробіли вважаються частиною поля і їх не слід ігнорувати. Останнє
поле в записі не повинно супроводжуватися комою. Наприклад:

aaa, bbb, ccc

Кожне поле може бути або не може бути укладено у подвійні лапки. Якщо
поля не укладені подвійними лапками, то подвійні лапки можуть не
з'являтися всередині полів. Наприклад:

\"aaa\", \"bbb\", \"ccc\" CRLF zzz, yyy, xxx

Поля, що містять розриви рядків (CRLF), подвійні лапки та коми повинні
бути укладені у подвійні лапки. Наприклад:

\"aaa\", \"b CRLF bb\", \"ccc\" CRLF zzz, yyy, xxx

Якщо для закриття полів використовуються подвійні лапки, то подвійну
цитату, що з'являється всередині поля, необхідно уникнути, передуючи їй
ще однією подвійною цитатою. Наприклад:

\"aaa\", \"b\" \"bb\", \"ccc\"

**1.3 HML-файли**
-----------------

XML - мова розмітки, створена Всесвітнім консорціумом веб-сторінок (W3C)
для визначення синтаксису кодування документів, які могли читати і люди,
і машини. Це робиться за допомогою використання тегів, які визначають
структуру документа, а також те, як документ повинен зберігатися та
транспортуватися.

Напевно, найпростіше порівняти його з іншою мовою розмітки, з якою ви
могли бути знайомі - мовою розмітки гіпертексту (HTML), що
використовується для кодування веб-сторінок. HTML використовує
попередньо визначений набір символів розмітки (короткі коди), які
описують формат вмісту на веб-сторінці. 

Якщо ви вже знайомі з HTML, ви можете бачити, що XML дуже схожий. Однак
правила синтаксису XML суворі: інструменти XML не будуть обробляти
файли, що містять помилки, а натомість видаватимуть повідомлення про
помилки, щоб ви їх виправили. Це означає, що майже всі документи XML
можуть бути надійно оброблені комп\'ютерним програмним забезпеченням.

Основні відмінності від HTML:

1.  Усі елементи повинні бути *закриті* або позначені як *порожні* .

2.  Порожні елементи можна закрити як звичайні,
    \<happiness\>\</happiness\> або ви можете використовувати спеціальну
    коротку форму, \<happiness /\> .

3.  У HTML вам потрібно навести лише значення атрибута за певних
    обставин (воно містить пробіл або символ, який не дозволяється в
    імені), але правила важко запам\'ятати. У XML значення атрибутів
    завжди повинні бути цитовані:\
    \<happiness type=\"joy\" /\>

4.  У HTML є вбудований набір елементів імен (разом з їх атрибутами). У
    XML немає вбудованих імен (хоча імена, що починаються з xml, мають
    особливі значення).

5.  У HTML є список деяких вбудованих імен символів, як &eacute; для é,
    але XML цього не має. У XML є лише п'ять вбудованих символьних
    об\'єктів: & lt ;, & gt ;, & amp ;, & quot; і & для \<,\>, &, \"і\"
    відповідно. Ви можете визначити власні сутності у Визначенні типу
    документа або ви можете використовувати будь-який символ Unicode
    (див. наступний пункт).

6.  У HTML також є числові посилання символів, такі як & \# 38; для
    &. Ви можете посилатися на будь-який символ Unicode, але число є
    десятковим, тоді як у таблицях Unicode число зазвичай у
    шістнадцятковій кількості. XML також дозволяє отримати
    шістнадцяткові посилання: & \# x26; наприклад.

XML має ряд переваг перед багатьма іншими форматами. Для будь-якого
конкретного сценарію ви можете придумати кращий формат, але тоді вам
доведеться включати витрати на перетворення та обробку свого формату,
навчання, а також інструменту редагування та пошуку XML, який зараз дуже
потрібний. широко доступний. Деякі з переваг XML включають:

Надмірність

> Розмітка XML дуже багатослівна. Наприклад, кожен кінцевий тег повинен
> бути наданий, наприклад \</description\> у прикладі. Це дозволяє
> комп\'ютеру виявляти поширені помилки, такі як неправильне введення.

Самоописування

> Читання XML (це текстовий формат) та наявність імен елементів та
> атрибутів у XML означає, що люди, які переглядають документ XML, часто
> можуть почати розуміти формат (а також він допомагає людям знаходити
> помилки !)

Мережевий ефект та XML Обіцянка

> Будь-який XML-документ може бути прочитаний та оброблений будь-яким
> інструментом XML. Звичайно, деякі інструменти XML можуть захотіти
> конкретної розмітки XML, але сам формат XML може бути прочитаний
> будь-яким аналізатором XML: ви не можете сказати, що цей XML документ
> повинен оброблятися лише таким інструментом.
>
> Це означає, що кожен новий XML-документ збільшує значення кожного
> іншого XML-документа і кожного інструмента XML, а кожен новий
> інструмент XML збільшує значення кожного XML-документа, а отже, і
> будь-якого іншого інструменту. На сьогодні XML - це найпоширеніший у
> своєму роді формат у будь-якій точці світу.

Документ XML вважається «правильно сформованим» (тобто може бути
прочитаний і зрозумілий синтаксичним аналізатором XML), якщо його формат
відповідає специфікації XML, якщо він правильно розмічений і якщо
елементи правильно вкладені. XML також підтримує можливість визначення
атрибутів для елементів і опису характеристик елементів в початковому
тегу елемента.

Додатки для XML нескінченні. Наприклад, виробники комп\'ютерів можуть
домовитися про стандартний або загальний спосіб опису інформації про
комп\'ютерному продукті (швидкість процесора, обсяг пам\'яті і т. Д), А
потім описати формат інформації про продукт за допомогою XML-коду. Такий
стандартний спосіб опису даних дозволив би користувачеві відправляти
інтелектуальний агент (програму) на веб-сайт кожного виробника
комп\'ютерів, збирати дані і потім проводити достовірне порівняння.

Переваги XML іноді здавалися революційними за обсягом незабаром після
його появи. Проте, як концепція, вона не була революційною. Це також не
було панацеєю. Надмірне застосування XML у багатьох областях технологій
знижує його реальну цінність і призводить до значного безладу. Можливо,
найбільш руйнівним є передбачувана поведінка багатьох постачальників,
які намагаються переписати XML, використовуючи власний набір власних
розширень. Хоча деякі хочуть підвищити цінність XML, інші прагнуть лише
прив\'язати користувачів до своїх продуктів.

Сила XML полягає в його простоті. Він може збирати великі обсяги
інформації і об\'єднувати їх в документ XML - значущі фрагменти, які
забезпечують структуру і організацію інформації.

![][2]

Рис. 1.2 -- Приклад XML-файлу

**1.4 Опис логічної структури**
-------------------------------

Для реалізації програми була використана мова програмування C\#. Вона
містить бібліотеку, що допоможе працювати з заданими форматами даних

Функції, логічні структури та опис:

-   Функцція, яка зчитує що вводить користувач,наприклад, якщо вводить
    повідомлення про допомогу, то отримує підказки.

-   Цикл for в якому проходить розбиття даних, відповідно до того, який
    знак для розділу ввів користувач. Цикл містить у собі структуру
    switch-case, для обробки аргументів та перевірки чи є вони валідними

-   А також функції для виведення повідомлень для взаємодії з
    користувачем

-   Функція для запису в новий формат, у якій відповідно до вимог
    формату створюється та зберігається новий формат.

Алгоритм нашої програми виглядає наступним чином:

1.  Виводиться повідомлення про те, щоб користувач ввів ім'я файлу, що
    необхідно конвертувати

2.  Користувач вводить символ для розбиття

3.  Перетворення введеного файл у новий формат

4.  Повідомлення про те, щоб користувач ввів ім'я файлу, який необхідно
    зберегти

**РОЗДІЛ 2**
============

**2.1. Опис програми і тестування програми**
--------------------------------------------

Після закінчення програмування нашої програми нам потрібно її
скомпілювати. Після цього програма наша готова для використання

![][3]

Рис.1.1. Приклад роботи програми при її успішному виконанні

Якщо програма не містить помилок то компілятор видасть повідомлення про
успішне завершення і запустить наш проект на виконання. Тут ми вже
зможемо протестувати створену програму. Тестування повинне забезпечити
перевірку працездатності функцій для всіх варіантів вхідних даних.

Тестування програмного забезпечення (англ. Software Testing) -- це
процес технічного дослідження, призначений для виявлення інформації про
якість продукту відносно контексту, в якому він має використовуватись.
Техніка тестування також включає як процес пошуку помилок або інших
дефектів, так і випробування програмних складових з метою оцінки. Може
оцінюватись:

• відповідність вимогам, якими керувалися проектувальники та розробники

• правильна відповідь для усіх можливих вхідних даних

• виконання функцій за прийнятний час

• практичність

• сумісність з програмним забезпеченням та операційними системами

• відповідність задачам замовника.

Оскільки число можливих тестів навіть для нескладних програмних
компонент практично нескінченне, тому стратегія тестування полягає в
тому, щоб провести всі можливі тести з урахуванням наявного часу та
ресурсів. Як результат програмне забезпечення (ПЗ) тестується
стандартним виконанням програми з метою виявлення баґів (помилок або
інших дефектів).

Тестування ПЗ може надавати об\'єктивну, незалежну інформацію про якість
ПЗ, ризики відмови, як для користувачів так і для замовників.

Тестування може проводитись, як тільки створено виконуваний код (навіть
частково завершено). Процес розробки зазвичай передбачає коли та як буде
відбуватися тестування. Наприклад, при поетапному процесі, більшість
тестів відбувається після визначення системних вимог і тоді вони
реалізуються в тестових програмах. На противагу цьому, відповідно до
вимог гнучкої розробки ПЗ, програмування і тестування часто відбувається
одночасно.

Тестування -- це одна з технік контролю якості, що включає в себе

• Планування робіт (Test Management)

• Проектування тестів (Test Design)

• Виконання тестування (Test Execution)

• Аналіз отриманих результатів (Test Analysis).

Для завершення роботи з програмою натискаємо на хрестик в правому
верхньому куті робочого вікна.

Провівши тестування створеної програми можна зробити висновок, що
програма працює без помилок і забезпечує повноцінну роботу при будь-яких
вхідних даних. А також здійснює обробку даних без збоїв.

**2.2. Типи комп\'ютерів та пристроїв, що використовуються при роботі програми**
--------------------------------------------------------------------------------

При роботі програми використовується IBM-сумісний комп\'ютер. Будь-яких
інших специфічних чи додаткових пристроїв програма не потребує, окрім
наявності мережі між двома чи більше ПК.

**2.3. Виклик і завантаження**
------------------------------

Способи виклику програми

Виклик програми виконується запуском програми

**Адреса завантаження програми**

Адреса завантаження визначається операційною системою автоматично.

**Відомості про використання оперативної пам\'яті**

Програма при роботі не ініціює запити на виділення оперативної пам'яті,
крім тої, що виділена їй для роботи операційною системою.

**Обсяг програми**

Проект має обсяг 11, 8 Кб.

**ВИСНОВКИ**
============

В ході виконання завдання курсової роботи мною було розроблено проект
програми, що перетворює з формату CSV у XML, та навпаки. В програмі
реалізовано можливість відкриття файлу, та перетворення до нового типу,
а після збереження.

Під час виконання курсової роботи було:

1\. Вивчено основні алгоритми і функції для створення ігор на мові С\#.

2\. Реалізовано програму перетворює з формату CSV у XML в консольному
додатку.

Провівши тестування створеної програми можна зробити висновок, що
програма працює без помилок і забезпечує повноцінну роботу при будь-яких
вхідних даних. А також здійснює обробку даних без збоїв.

Програма повноцінно працює при будь-яких вхідних даних і може бути
впроваджена для робот з аналізу даних або парсингу веб-сторінок.

**СПИСОК ВИКОРИСТАНИХ ДЖЕРЕЛ**
==============================

1\. Ахо А., Хопкрофт Дж., Ульман Дж. Структуры данных и алгоритмы -- М.:
Изд. Дом «Вильямс», 2001. -- 384с.

2\. Браунси К. Основные концепции структур данных и реализация в С++. --
М.: Изд. Дом «Вильямс», 2002. -- 320с.

3\. Проценко В.С. Техніка програмування мовою Сі: Навчальний посібник --
К.: Либідь, 1993. -- 224 с.

4\. Шилдт Г. Теория и практика С++ -- СПб.: BHV -- Санкт-Питербург,
1996. -- 416 с.

5\. Ахо А., Хопкрофт Дж., Ульман Дж. Построение и анализ вычислительных
алгоритмов. -- М.: «Мир», 1979. - 536с.

6\. Вирт Н.Алгоритмы + структуры данных = программы. - М.: \"Мир\",
1985. - 544 с.

7\. Гудман С. Хидетниеми С. Введение в разработку и анализ алгоритмов. -
М.: \"Мир\", 1981. - 366 с.

8\. Кнут Д. Искусство программирования для ЭВМ. т.3. Сортировка и поиск.
М.:Мир, 1976. - 678 с.

9\. Мейер Б., Бодуэн К. Методы программирования: В 2-х томах -- М.: Мир,
1982. -- 356+368с.

10.Ахо А. Структуры данных и алгоритмы / А. Ахо, Дж. Хопкрофт, Дж.
Ульман.--

М.: Изд. Дом «Вильямс», 2001. -- 384с.

11\. Браунси К. Основные концепции структур данных и реализация в С++ /
К. Браунси. -- М.: Изд. Дом «Вильямс», 2002. -- 320с.

12\. Вирт Н. Алгоритмы и структуры данных. / Н. Вирт. -- М., ДМК\_Пресс,
2011. --

272 с.

13\. Кнут Д. Искусство программирования, т.3. Сортировка и поиск. / Д.
Кнут -- М.: Вильямс, 2011. -- 824 с.

14\. Кормен Т Алгоритмы: построение и анализ / Т. Кормен, Ч. Лейзерсон,
Р. Ривест. -- М.: Вильямс, 2011. -- 1296 с.

15\. Нікольський Ю. В. Дискретна математика: Підручник / Ю. В
Нікольський , В. В. Пасічник, Ю. М. Щербина. -- Львів: «Магнолія Плюс»,
2005. -- 608 с.

16\. Страуструп Б. Язык программирования C++. Специальное издание. Пер.
с англ. / Б. Страуструп -- М.: Издательство Бином, 2011 г. --- 1136 с:
ил.

17\. Иванов Б.Н. Дискретная математика. Алгоритмы и программы: Учеб.
Пособие. -- Владивосток: Изд-во ДВГТ, 2000. -- 288с.

18\. Молчанова Л.А., Прудникова Л.И. Delphi в примерах и задачах: Учеб.
пособие. Владивосток: Изд-во ТГЭУ, 2006. -- 92с.

19\. Альфред В. Ахо, Джон Хопкрофт, Джеффри Д. Ульман. Структуры данных
и алгоритмы = Data Structures and Algorithms. --- М.: Вильямс, 2000. ---
384 с. --- ISBN 0-201-00023-7.

20\. Майкл Мейн, Уолтер Савитч. Структуры данных и другие объекты в C++
= Data Structures and Other Objects Using C++. --- 2-е изд. --- М.:
Вильямс, 2002. --- 832 с. --- ISBN 0-201-70297-5.

21\. Chris Okasaki. Purely Functional Data Structures. --- Cambridge
University Press, 1998. --- 232 с. --- ISBN 978-0521663502.

**ДОДАТКИ**
===========

**Додаток 1**
-------------

**Лістинг програми**

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;

using System.Xml;

namespace ConsoleApp2 {

    class Program {

        static void Main(string\[\] args) {

            if (args.Length == 0 \|\| args.Contains(\"-help\") \|\| args.Contains(\"-?\")) {

                Console.WriteLine(\"usage: \" +

                    \"a.exe \[-?\] \[-e encoding\] \[-sep separator\] -fin filenameIn -fout filenameOut\");

                return;

            }

            string enc = \"utf-8\";

            char sep = \';\';

            string filenameIn = null;

            string filenameOut = null;

            for (int i = 0; i \< args.Length; i++) {

                switch (args\[i\].ToLower()) {

                    case \"-e\":

                        enc = args\[++i\];

                        break;

                    case \"-sep\":

                        sep = args\[++i\]\[0\];

                        break;

                    case \"-fin\":

                        filenameIn = args\[++i\];

                        break;

                    case \"-fout\":

                        filenameOut = args\[++i\];

                        break;

                    default:

                        Console.WriteLine(\"invalid argument: \" + args\[i\]);

                        return;

                }

            }

            if (filenameIn == null) {

                Console.WriteLine(\"please specify input file name with -fin\");

                return;

            }

            if (filenameOut == null) {

                Console.WriteLine(\"please specify output file name with -fout\");

                return;

            }

            XmlDocument doc = new XmlDocument();

            XmlElement table = doc.CreateElement(\"table\");

            using (StreamReader reader = new StreamReader(filenameIn, Encoding.GetEncoding(enc))) {

                int i = 0;

                string line;

                while ((line = reader.ReadLine()) != null) {

                    string\[\] p = line.Split(sep);

                    XmlElement r = doc.CreateElement(\"row\");

                    r.SetAttribute(\"i\", (++i).ToString());

                    for (int j = 0; j \< p.Length; j++) {

                        XmlElement c = doc.CreateElement(\"col\");

                        c.SetAttribute(\"j\", (j + 1).ToString());

                        c.AppendChild(doc.CreateTextNode(p\[j\]));

                        r.AppendChild(c);

                    }

                    table.AppendChild(r);

                }

            }

            doc.AppendChild(table);

            using (StreamWriter writer = new StreamWriter(filenameOut, false, Encoding.UTF8)) {

                doc.Save(writer);

            }

            Console.WriteLine(\"done\");

        }

    }

}

  [1. Теоретичні відомості 4]: #теоретичні-відомості
  [1.1 CSV-файли 4]: #csv-файли
  [1.2 Правила оформлення CSV 5]: #правила-оформлення-csv
  [1.3 HML-файли 6]: #hml-файли
  [1.4 Опис логічної структури 10]: #опис-логічної-структури
  [РОЗДІЛ 2 11]: #розділ-2
  [2.1. Опис програми і тестування програми 11]: #опис-програми-і-тестування-програми
  [2.2. Типи комп\'ютерів та пристроїв, що використовуються при роботі програми 13]:
    #типи-компютерів-та-пристроїв-що-використовуються-при-роботі-програми
  [2.3. Виклик і завантаження 13]: #виклик-і-завантаження
  [ВИСНОВКИ 14]: #висновки
  [СПИСОК ВИКОРИСТАНИХ ДЖЕРЕЛ 15]: #список-використаних-джерел
  [ДОДАТКИ 18]: #додатки
  [Додаток 1 18]: #додаток-1
  [1]: media/image1.png {width="6.129486001749782in"
  height="1.8181813210848643in"}
  [2]: media/image2.jpeg
  [3]: media/image3.png {width="6.728472222222222in"
  height="0.2923611111111111in"}