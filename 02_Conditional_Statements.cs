using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Tasks_IJunior
//{
//    internal class _02_Conditional_Statements
//    {
//        static void Main(string[] args)
//        {
//            //Циклы
//            //Напишите простейшую программу, которая выводит указанное пользователем сообщение заданное количество раз.
//            //Количество повторов также должен ввести пользователь.

//            string message;
//            int repeatsCount;

//            Console.Write("Введите свое сообщение: ");
//            message = Console.ReadLine();
//            Console.Write("Введите, сколько раз его повторить: ");
//            repeatsCount = Convert.ToInt32(Console.ReadLine());

//            for (int i = 0; i < repeatsCount; i++)
//            {
//                Console.WriteLine(message);
//            }

//            //Контроль выхода
//            //Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit. 

//            string userInput;
//            string userExit = "exit";

//            Console.Write("Your word: ");
//            userInput = Console.ReadLine();

//            while (userInput != userExit)
//            {
//                Console.WriteLine(@userInput);
//            }

//            //Последовательность
//            //Нужно написать программу, чтобы она выводила следующую последовательность 5 12 19 26 33 40 47 54 61 68 75 82 89 96  

//            int maxNumber = 97;
//            int startNumber = 5;
//            int step = 7;

//            for (int i = startNumber; i < maxNumber; i += step)
//            {
//                Console.WriteLine(i);
//            }

//            //Конвертер валют
//            //У пользователя есть баланс в каждой из представленных валют.Он может попросить сконвертировать часть баланса с одной валюты в другую.
//            //Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.Курс конвертации должен быть просто прописан в программе. 

//            bool isWorking = true;

//            const string MenuDollarsToRubles = "1";
//            const string MenuRublesToDollars = "2";
//            const string MenuEuroToRuble = "3";
//            const string MenuRublesToEuros = "4";
//            const string MenuDollarsToEuros = "5";
//            const string MenuEurosToDollars = "6";

//            float moneyInDollar = 1000;
//            float moneyInEuro = 1500;
//            float moneyInRuble = 200000;
//            float rubleToDollar = 100;
//            float rubleToEuro = 100;
//            float dollarToRuble = 0.01f;
//            float euroToRuble = 0.01f;
//            float dollarToEuro = 100;
//            float euroToDollar = 100;
//            float currencyAmount;
//            string userChoice;
//            string commandExit = "выйти";
//            string userInput;

//            while (isWorking)
//            {

//                Console.WriteLine($"Баланс Вашего счета: \nДоллары: {moneyInDollar} Евро: {moneyInEuro} Рубли: {moneyInRuble}");
//                Console.WriteLine("Вы желаете конвертировать валюту или выйти?");
//                userChoice = Console.ReadLine();

//                Console.WriteLine("Выберете нужную конвертацию: ");
//                Console.WriteLine($"{MenuDollarsToRubles} - доллары конвертировать в рубли {MenuRublesToDollars} - рубли конвентировать в доллары {MenuEuroToRuble} - евро конвентировать в рубли");
//                Console.WriteLine($"{MenuRublesToEuros} - рубли конвентировать в евро {MenuDollarsToEuros} - доллары конвентировать в евро {MenuEurosToDollars} - евро конвентировать в доллары");
//                userInput = Console.ReadLine();

//                if (userInput == MenuDollarsToRubles)
//                {
//                    Console.WriteLine("Сколько долларов перевести в рубли?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInDollar)
//                    {
//                        float result = currencyAmount * dollarToRuble;
//                        moneyInDollar -= result;
//                        moneyInRuble += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userInput == MenuRublesToDollars)
//                {
//                    Console.WriteLine("Сколько рублей перевести в доллары?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInRuble)
//                    {
//                        float result = currencyAmount * rubleToDollar;
//                        moneyInRuble = moneyInRuble - result;
//                        moneyInDollar += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userInput == MenuEuroToRuble)
//                {
//                    Console.WriteLine("Сколько евро перевести в рубли?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInRuble)
//                    {
//                        float result = currencyAmount * euroToRuble;
//                        moneyInEuro = moneyInEuro - result;
//                        moneyInRuble += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userInput == MenuRublesToEuros)
//                {
//                    Console.WriteLine("Сколько рублей перевести в евро?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInRuble)
//                    {
//                        float result = currencyAmount * rubleToEuro;
//                        moneyInRuble = moneyInRuble - result;
//                        moneyInEuro += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userInput == MenuDollarsToEuros)
//                {
//                    Console.WriteLine("Сколько долларов перевести в евро?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInDollar)
//                    {
//                        float result = currencyAmount * dollarToEuro;
//                        moneyInDollar = moneyInDollar - result;
//                        moneyInEuro += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userInput == MenuEurosToDollars)
//                {
//                    Console.WriteLine("Сколько евро перевести в доллары?");
//                    currencyAmount = Convert.ToInt32(Console.ReadLine());

//                    if (currencyAmount <= moneyInDollar)
//                    {
//                        float result = currencyAmount * euroToDollar;
//                        moneyInEuro = moneyInEuro - result;
//                        moneyInDollar += result;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Вы вышли за придел баланса");
//                    }
//                }
//                else if (userChoice == commandExit)
//                {
//                    isWorking = false;
//                }
//                else
//                {
//                    Console.WriteLine("Введены неверные параметры!");
//                }

//                Console.WriteLine($"Баланс Вашего счета: \nДоларры: {moneyInDollar} Евро: {moneyInEuro} Рубли: {moneyInRuble}");
//            }

//            //Консольное меню
//            //При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды. Т.е. вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде. 

//            bool isWorking = true;

//            while (isWorking)
//            {
//                const string CommandSignIn = "Войти в систему";
//                const string CommandChangeИackgroundСolor = "Изменить цвет";
//                const string CommandChangeTextColor = "Изменить цвет текста";
//                const string CommandReduceConsoleSize = "Уменьшить размер консоли";
//                const string CommandSignOut = "Выйти";

//                Console.WriteLine($"\nВыберете команду: \n{CommandSignIn}\n{CommandChangeИackgroundСolor}\n{CommandChangeTextColor}\n{CommandReduceConsoleSize}\n{CommandSignOut}");
//                string userInput = Console.ReadLine();

//                switch (userInput)
//                {
//                    case CommandSignIn:
//                        int triesCount = 5;
//                        int userPassword = 123;
//                        int userInputPassword;

//                        for (int i = 0; i < triesCount; i++)
//                        {
//                            Console.WriteLine("Введите пароль: ");
//                            userInputPassword = Convert.ToInt32(Console.ReadLine());

//                            if (userPassword == userInputPassword)
//                            {
//                                const string CommandEditName = "1";
//                                const string CommandEditPassword = "2";

//                                Console.WriteLine($"Теперь вы можете выбрать действие:\n{CommandEditName} - изменить имя\n{CommandEditPassword} - изменить пороль");
//                                string authorizedUserInput = Console.ReadLine();
//                                switch (authorizedUserInput)
//                                {
//                                    case CommandEditName:
//                                        Console.WriteLine("Введите ваше имя: ");
//                                        string userName = Console.ReadLine();
//                                        Console.Write($"Ваше имя: {userName}");
//                                        break;

//                                    case CommandEditPassword:
//                                        Console.WriteLine("Введите ваш возраст: ");
//                                        int userAge = Convert.ToInt32(Console.ReadLine());
//                                        Console.Write($"Ваш возраст: {userAge}");
//                                        break;
//                                }
//                                break;
//                            }
//                            else
//                            {
//                                Console.WriteLine("Введен неверный пароль");
//                                triesCount -= (i + 1);
//                                Console.WriteLine("У Вас осталось попыток " + triesCount);
//                            }

//                        }
//                        break;

//                    case CommandChangeИackgroundСolor:

//                        const string CommandColorGrey = "1";
//                        const string CommandColorWhite = "2";
//                        const string CommandColorGreen = "3";

//                        Console.WriteLine($"Выберете цвет:\n{CommandColorGrey} - серый\n{CommandColorWhite} - белый\n{CommandColorGreen} - зеленый");
//                        string backgroundColor = Console.ReadLine();

//                        switch (backgroundColor)
//                        {
//                            case CommandColorGrey:
//                                Console.BackgroundColor = ConsoleColor.DarkGray;
//                                Console.Clear();
//                                break;

//                            case CommandColorWhite:
//                                Console.BackgroundColor = ConsoleColor.White;
//                                Console.Clear();
//                                break;

//                            case CommandColorGreen:
//                                Console.BackgroundColor = ConsoleColor.Green;
//                                Console.Clear();
//                                break;

//                            default:
//                                Console.WriteLine("Неверный ввод");
//                                break;
//                        }
//                        break;

//                    case CommandChangeTextColor:

//                        const string CommandColorBlack = "1";
//                        const string CommandColorBlue = "2";
//                        const string CommandColorYellow = "3";

//                        Console.WriteLine($"Выберете цвет:\n{CommandColorBlack} - черный\n{CommandColorBlue} - голубой\n{CommandColorYellow} - желтый");
//                        string textColor = Console.ReadLine();

//                        switch (textColor)
//                        {
//                            case CommandColorBlack:
//                                Console.ForegroundColor = ConsoleColor.Black;
//                                Console.Clear();
//                                break;

//                            case CommandColorBlue:
//                                Console.ForegroundColor = ConsoleColor.Blue;
//                                Console.Clear();
//                                break;

//                            case CommandColorYellow:
//                                Console.ForegroundColor = ConsoleColor.Yellow;
//                                Console.Clear();
//                                break;

//                            default:
//                                Console.WriteLine("Неверный ввод");
//                                break;
//                        }
//                        break;

//                    case CommandReduceConsoleSize:
//                        Console.WindowHeight = 10;
//                        Console.WindowWidth = 30;
//                        break;

//                    case CommandSignOut:
//                        isWorking = false;
//                        break;

//                    default:
//                        Console.WriteLine("Неверно введена команда");
//                        break;
//                }
//            }
//            //Вывод имени
//            //Вывести имя в прямоугольник из символа, который введет сам пользователь. 

//            Console.WriteLine("Ведите ваше имя: ");
//            string userName = Console.ReadLine();
//            Console.WriteLine("Введите символ: ");
//            char userSymbol = Console.ReadKey(true).KeyChar;

//            string rectangleWidth = userSymbol + userName + userSymbol;
//            string symbols = "";

//            for (int i = 0; i < rectangleWidth.Length; i++)
//            {
//                symbols += userSymbol;
//            }

//            Console.WriteLine(symbols);
//            Console.WriteLine(rectangleWidth);
//            Console.WriteLine(symbols);

//            //Программа под паролем
//            //Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. 
//            //Проверяется его правильность и открытие или отказ в доступе к сообщению.

//            string userPassword = "MyPasswordIsVeryStrong123";
//            string userInputPassword;
//            int triesCount = 3;

//            for (int i = triesCount; i > 0; i--)
//            {
//                Console.WriteLine("Введите пароль: ");
//                userInputPassword = Console.ReadLine();

//                if (userInputPassword == userPassword)
//                {
//                    Console.WriteLine("Секретное сообщение:\nЭто очень секретное сообщение");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Введен неверный пароль");
//                    triesCount--;
//                    Console.WriteLine("У Вас осталось попыток " + triesCount);
//                }
//            }
//            //Кратные числа
//            //Дано N (1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, которые кратны N. Операции деления (/, %) не использовать. А умножение не требуется.
//            //Число N всего одно, его надо получить в нужном диапазоне.

//            Random random = new Random();
//            int minRandom = 1;
//            int maxRandom = 27;
//            int numberN = random.Next(minRandom, maxRandom + 1);
//            Console.WriteLine($"Число N - {numberN}");
//            int minNumber = 100;
//            int maxNumber = 1000;
//            int threedigitNumbers = 0;

//            for (int i = 0; i < maxNumber; i += numberN)
//            {
//                if (i >= minNumber)
//                {
//                    Console.WriteLine($"Трехзначные кратные числа: {i}");
//                    threedigitNumbers++;
//                }
//                else if (i < minNumber)
//                {
//                    Console.WriteLine($"Не трехзначные кратные числа {i}");
//                }
//            }

//            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {numberN}: {threedigitNumbers}");

//            //Степень двойки
//            //Найдите минимальную степень двойки, превосходящую заданное число. 
//            //К примеру, для числа 4 будет 2 в степени 3, то есть 8. 4 < 8.

//            int randomNumber;
//            int degreeOfTwo = 2;
//            int minDegreeOfTwo = 0;
//            int numberInDegreeOfTwo = 1;

//            Random random = new Random();
//            randomNumber = random.Next();

//            while (numberInDegreeOfTwo <= randomNumber)
//            {
//                numberInDegreeOfTwo = numberInDegreeOfTwo * degreeOfTwo;
//                minDegreeOfTwo++;
//            }

//            Console.WriteLine($"Случайное число {randomNumber}\nCтепень {degreeOfTwo} в степени {minDegreeOfTwo} будет {numberInDegreeOfTwo} > {randomNumber}");

//            //Скобочное выражение
//            //Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением. 
//            //Определить максимальную глубину вложенности скобок.

//            Console.WriteLine("Введите скобочное выражение: ");
//            string bracketExpression = Console.ReadLine();
//            char openBracket = '(';
//            char closingBracket = ')';
//            int currentSumOfBrackets = 0;
//            int maxSumOfBrackets = 0;

//            foreach (var symbol in bracketExpression)
//            {
//                if (symbol == openBracket)
//                {
//                    currentSumOfBrackets++;

//                    if (currentSumOfBrackets > maxSumOfBrackets)
//                    {
//                        maxSumOfBrackets = currentSumOfBrackets;
//                    }
//                }
//                else if (symbol == closingBracket)
//                {
//                    currentSumOfBrackets--;
//                }

//                if (currentSumOfBrackets < 0)
//                {
//                    break;
//                }
//            }

//            if (currentSumOfBrackets == 0)
//                Console.WriteLine($"Строка {bracketExpression} является корректным скобочным выражением\nМаксимальная глубина вложенности скобок {maxSumOfBrackets}");
//            else
//                Console.WriteLine($"Строка {bracketExpression} не является корректным скобочным выражением");

//            //Бой с боссом
//            //Легенда: Вы – теневой маг и у вас в арсенале есть несколько заклинаний, которые вы можете использовать против Босса.
//            //Вы должны уничтожить босса и только после этого будет вам покой. 

//            const string MenuSpellRashamon = "1";
//            const string MenuSpellKurama = "2";
//            const string MenuSpellHyganzakura = "3";
//            const string MenuSpellInterdimensionalRift = "4";

//            int darkMagicianHealth = 100;
//            int spellRashamon = 30;
//            int spellKurama = 30;
//            int spellHyganzakura = 60;
//            int spellInterdimensionalRift = 45;

//            int bossHealth = 200;
//            Random random = new Random();
//            int minRandomDamage = 0;
//            int maxRandomDamage = 30;
//            int retaliatoryDamage = random.Next(minRandomDamage, maxRandomDamage);

//            bool isSpell = false;

//            while (bossHealth > 0 && darkMagicianHealth > 0)
//            {
//                Console.WriteLine($"Ваш уровень здоровья: {darkMagicianHealth}\nУровень здоровья противника: {bossHealth}");
//                Console.WriteLine($"Пришло время аттаковать!\nВыберете заклинание:\n{MenuSpellRashamon} Призвать демона Рашамон\n{MenuSpellKurama} Попросить о помощи лиса Кураму\n{MenuSpellHyganzakura} 3аклинание Хуганзакура - двойной урон, возможен только после применения {MenuSpellRashamon} {MenuSpellKurama}\n{MenuSpellInterdimensionalRift} Межпространственный разлом - поможет скрыться и восстановиться, возможен только после применения {MenuSpellRashamon} {MenuSpellKurama}");
//                string choseSpell = Console.ReadLine();

//                if (choseSpell == MenuSpellRashamon)
//                {
//                    isSpell = true;
//                    bossHealth -= spellRashamon;
//                    Console.WriteLine($"Вы призвали Рашимона, он нанес урон противнику -{spellRashamon}");
//                }
//                else if (choseSpell == MenuSpellKurama)
//                {
//                    isSpell = true;
//                    bossHealth -= spellKurama;
//                    Console.WriteLine($"Вы призвали Кураму, он нанес урон противнику -{spellKurama}");
//                }
//                else if (choseSpell == MenuSpellHyganzakura)
//                {
//                    if (isSpell == true)
//                    {
//                        bossHealth -= spellHyganzakura;
//                        Console.WriteLine($"Вы использовали мощное заклинание, оно нанесло урон противнику -{spellHyganzakura}");
//                    }
//                    else if (isSpell == false)
//                    {
//                        Console.WriteLine($"Сначала используйте {MenuSpellRashamon} и {MenuSpellKurama}");
//                    }
//                }
//                else if (choseSpell == MenuSpellInterdimensionalRift)
//                {
//                    if (isSpell == true)
//                    {
//                        darkMagicianHealth += spellInterdimensionalRift;
//                        Console.WriteLine($"Вы скрылись в межпространственном разломе и восстановили свое здоровье на +{spellInterdimensionalRift}");
//                    }
//                    else if (isSpell == false)
//                    {
//                        Console.WriteLine($"Сначала используйте {MenuSpellRashamon} и {MenuSpellKurama}");
//                    }
//                }

//                if (bossHealth > 0 && darkMagicianHealth > 0)
//                {
//                    bool isSpellInterdimensionalRift = choseSpell == MenuSpellInterdimensionalRift;

//                    if (isSpellInterdimensionalRift == false)
//                    {
//                        darkMagicianHealth -= retaliatoryDamage;
//                        Console.WriteLine($"Вам нанесли ответный урон -{retaliatoryDamage}!");
//                    }
//                    else if (isSpellInterdimensionalRift == true && isSpell == true)
//                    {
//                        Console.WriteLine("Урон не нанесен");
//                    }
//                }
//            }

//            if (darkMagicianHealth == 0 && bossHealth == 0)
//            {
//                Console.WriteLine("Ничья!");
//            }
//            else if (darkMagicianHealth <= 0)
//            {
//                Console.WriteLine($"Уровень вашего здоровья: {darkMagicianHealth}. Вы проиграли...");
//            }
//            else if (bossHealth <= 0)
//            {
//                Console.WriteLine("Ура! Вы победили!");
//            }
//        }
//    }
//}
