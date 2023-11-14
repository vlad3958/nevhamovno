using System.Text;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Nevhamovno;



class TgBot
{
    public static void Main()
    {
        var client = new TelegramBotClient("6086878374:AAEkFyyPSyoGg5jg6vj1r4hoZH3i--nNpus");

        client.StartReceiving(Update1, Error);
        Console.ReadLine();
    }
    
    public static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }

    public static async Task Update1(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        try
        {


            var message = update.Message;
            if (message != null)
            {
                if (message.Type == MessageType.Text)
                {

                    if (message.Text == "/start")
                    {
                        //  Parallel.Invoke(()=>Main2(),() => Main3());

                        Console.WriteLine(message.Chat.Id); //443022729
                        Console.WriteLine(message.Chat.Username);
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Українська🇺🇦", "English🇬🇧" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "Оберіть мову\nChoose language",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "Про школу “невгаМОВНО”")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "«невгаМОВНО» — онлайн-школа української мови, метою якої є закохувати в українську мову та розвивати українськість. Ми навчаємо дітей, дорослих, готуємо до іспитів, допомагаємо перейти на українську мову, навчаємо команди. Але загалом ми просто любимо українську мову та культуру й прагнемо ділитися цією любов’ю. Для нас важливо показувати українську не як кабінетну мову, а як сучасну та актуальну — через тексти, пісні, фільми, книги, подкасти, меми тощо.\n" +
                                                                              "Ми прагнемо створити новий образ української мови та навчання загалом. І сподіваємося, що ми пройдемо цей шлях разом з вами!\n\n" +
                                                                              "Наші цінності\n" +
                                                                              "◼особистість\n" +
                                                                              "◼навчання і розвиток\n" +
                                                                              "◼довіра\n" +
                                                                              "◼свідомість\n" +
                                                                              "◼ відповідальність\n" +
                                                                              "◼ національна ідентичність\n\n" +
                                                                              "Ми стаємо друзями нашим учням — наставниками на шляху пізнання. Окрім професійної освіти та досвіду роботи, ми маємо вміння знаходити спільну мову та індивідуальний підхід.  Наші учні для нас — не безліч стандартних «я», а безліч всесвітів різних.\n\n" +
                                                                              "Сайт: https://www.nevhamovno.com\n" +
                                                                              "Instagram: https://www.instagram.com/nevhamovno/\n" +
                                                                              "Facebook: https://www.facebook.com/nevhamovno/\n" +
                                                                              "TikTok: https://www.tiktok.com/@nevhamovnoschool\n" +
                                                                              "Twitter: https://twitter.com/nevhamovno");
                    }

                    if (message.Text == "Українська🇺🇦")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[]
                                { "Про школу “невгаМОВНО” ", "Хочу дізнатись про послуги й записатись на уроки" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "Оберіть опцію:",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "Хочу записатись!")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Форма заповнена! Що далі?" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Дайте відповідь на кілька запитань у цьому опитувальнику: https://forms.gle/ywttKSEtHdZtfLaw5  Вони допоможуть нам визначити для вас наставницю з української мови та сформувати програму розвитку. Орієнтовний час заповнення 7-10 хвилин.",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "Хочу записатись!(ЗНО/НМТ)")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Форма заповнена! Що далі?" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Дайте відповідь на кілька запитань у цьому опитувальнику: https://forms.gle/ZhATYfTGUE9iQSAW7  Вони допоможуть нам визначити для вас наставницю з української мови та сформувати програму розвитку. Орієнтовний час заповнення 7-10 хвилин.",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "Форма заповнена! Що далі?")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "Дякуємо за ваші відповіді! Ми вже підбираємо для вас наставницю з української мови, яка невдовзі з вами сконтактує, щоб спланувати перший урок. Гарного дня й дякуємо, що обрали “невгаМОВНО”");
                    }

                    if (message.Text == "Мені потрібна ще додаткова інформація")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "Одну хвилиночку. Наша менеджерка сконтактує з вами, щоб відповісти на додаткові запитання");

                        await botClient.SendTextMessageAsync((ChatId)443022729,
                            $"{message.Chat.Username} потребує допомоги"); //6267297624
                        await botClient.SendTextMessageAsync((ChatId)6267297624,
                            $"{message.Chat.Username} потребує допомоги");

                    }

                    if (message.Text == "Хочу дізнатись про послуги й записатись на уроки")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[]
                                { "🟡українська для учнів 5-10 класів", "🟡підготовка до ЗНО/НМТ з української мови" },
                            new KeyboardButton[] { "🟡українська для дорослих", "🟡українська для команд" },
                            new KeyboardButton[] { "🟡українська для іноземців", "🟡безкоштовні уроки для військових" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "Вітаємо! Дякуємо, що прагнете поліпшувати свою українську. Ми тішимося, що ви обрали саме нас. Оберіть свою категорію:",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "🟡українська для учнів 5-10 класів")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Хочу записатись!", "Мені потрібна ще додаткова інформація" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              " Індивідуальні онлайн-уроки з української мови для учнів 5-10 класів.\n\n" +
                                                                              "🟡 навчання за шкільною програмою вашого класу (5–10 клас);\n" +
                                                                              "🟡 практика матеріалу в онлайн-іграх;\n" +
                                                                              "🟡 робота з ментальними картами та інтерактивними дошками;\n" +
                                                                              "🟡 розвиток компетентностей та навичок ХХІ століття.\n" +
                                                                              "\nДля нас важливо не просто надати теоретичний матеріал, а сформувати позитивну асоціацію з навчанням, тому на наших уроках багато ігор та цікавих активностей. Водночас для нас важливо виховувати свідомих українців, тому ми вчимо учнів також:\n\n" +
                                                                              "🔵 бути проактивними громадянами,\n" +
                                                                              "🔵 мислити критично та креативно,\n" +
                                                                              "🔵 перевіряти факти,\n" +
                                                                              "🔵 розуміти та виражати власні емоції,\n" +
                                                                              "🔵 ненасильницько комунікувати,\n" +
                                                                              "🔵 бути екологічно свідомими тощо.\n\n" +
                                                                              "🖥️ Формат: онлайн (Google meet)\n" +
                                                                              "💳 Ціна: 400 грн/1 год заняття\n",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "🟡підготовка до ЗНО/НМТ з української мови")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[]
                                { "Хочу записатись!(ЗНО/НМТ)", "Мені потрібна ще додаткова інформація" },
                        });
                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Уроки підготовки до ЗНО/НМТ з української мови\n\n" +

                                                                              "🟡 групові (до 6 людей у групі) та індивідуальні заняття;\n" +
                                                                              "🟡 навчання з мемами, піснями, тиктоками, відео тощо;\n" +
                                                                              "🟡 система бонусів за навчальні успіхи;\n" +
                                                                              "🟡 телеграм-канал, щоб практикувати тести будь-де та будь-коли;\n" +
                                                                              "🟡 спільний чат абітурієнтів для спілкування, мемів і розмов про журбу;\n" +
                                                                              "🟡 постійна менторська підтримка для мотивації учнів;\n" +
                                                                              "🟡 профорієнтаційні зустрічі з представниками різних професій;\n" +
                                                                              "🟡 зустрічі підтримки із психологом.\n\n" +

                                                                              "🖥️ Формат: онлайн (Google meet)\n\n" +

                                                                              "Індивідульні уроки\n" +
                                                                              "   💳 Ціна: 400 грн/1 год заняття\n\n" +

                                                                              "Групові заняття (у групі до 6 людей)\n" +
                                                                              "   💳 Ціна: 200 грн/1,5 год заняття (2 рази на тиждень)\n\n",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "🟡українська для дорослих")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Хочу записатись!", "Мені потрібна ще додаткова інформація" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Індивідуальні онлайн-уроки з української мови для дорослих\n\n" +
                                                                              "Для нас важливо не просто навчати української, а вчити людей бачити світ українською –  пізнавати культуру та менталітет через мову. Ми підтримаємо вас у переході на українську, або ж покращимо професійну українську, або ж згадаємо правила та попрактикуємо нововведення в українській мові.\n\n" +
                                                                              "Ми пропонуємо:\n\n" +
                                                                              "🟡 комфортні дружні уроки без зазубрювань;\n" +
                                                                              "🟡 індивідуальна програма розвитку під запит;\n" +
                                                                              "🟡 поліпшення вимови, вивчення нових слів, практика розмовного та писемного мовлення;\n" +
                                                                              "🟡 індивідуальний підбір додаткових матеріалів (фільми, подкасти, відео, статті);\n" +
                                                                              "🟡 гнучкий графік (стале заняття або змінний день і час щотижня).\n\n" +
                                                                              "🖥️ Формат:  онлайн-уроки в Google meet\n" +
                                                                              "💳 Ціна: 400 грн/1 год заняття",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "🟡українська для команд")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Хочу записатись!", "Мені потрібна ще додаткова інформація" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Ми враховуємо рівень і запит кожного учасника команди, професію, рід зайнятості та інтереси для складання вашої програми розвитку з української мови, за якою ви будете навчатися. " +
                                                                              "Для нас важливо не просто навчати української, а вчити людей бачити світ українською – пізнавати культуру та менталітет через мову. Ми підтримаємо вас у переході на українську, або ж покращимо професійну українську, або ж згадаємо правила та попрактикуємо нововведення в українській мові.\n\n" +
                                                                              "Ми пропонуємо:\n\n" +
                                                                              "🟡 комфортні дружні уроки без зазубрювань;\n" +
                                                                              "🟡 програма розвитку під ваш запит;\n" +
                                                                              "🟡 поліпшення вимови, вивчення нових слів, практика розмовного та писемного мовлення;\n" +
                                                                              "🟡 індивідуальний підбір додаткових матеріалів (фільми, подкасти, відео, статті);\n" +
                                                                              "🟡 гнучкий графік (стале заняття або змінний день і час щотижня).\n\n" +
                                                                              "🖥️ Формат:  онлайн-уроки в Google meet. Можливий курс з певної кількості онлайн-уроків або групові заняття щотижня\n" +
                                                                              "💳 Ціна: 800 грн/1 год заняття\n",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "🟡українська для іноземців")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "I want to apply!", "I need more information" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "NevhaMOVNO is a creative educational institution devoted to fostering an appreciation for the Ukrainian language and culture. We has been spreading our love for Ukraine globally, providing lessons to students from Canada, the United States, Germany, France, Belgium, Switzerland, and the United Kingdom." +
                                                                              "\n\n“NevhaMOVNO” offers the following services:\n\n" +
                                                                              "🟡 individual online lessons,\n" +
                                                                              "🟡 learning the Ukrainian language from scratch for children and adults,\n" +
                                                                              "🟡 individual selection of materials tailored to a given learning style,\n" +
                                                                              "🟡 personalized training programs based upon requested goals,\n" +
                                                                              "🟡 a welcoming and comfortable atmosphere,\n" +
                                                                              "🟡 flexible scheduling.\n\n" +
                                                                              "The study of the Ukrainian language during Russia's full-scale war against Ukraine may be an essential factor in achieving a victory for Ukraine and developing international relations between peoples. Moreover, it can help you:\n" +
                                                                              "1.To understand the current situation: understanding the Ukrainian language will aid in learning more about the situation on the ground and help put current events into context.\n" +
                                                                              "2.Facilitate communication with forced migrants from Ukraine.\n" +
                                                                              "3.Build relationships: knowing Ukrainian can help foreign powers build bridges and have open conversations with the locals, creating a better understanding of the region and strengthening relationships.\n\n" +
                                                                              "🖥️: online (Google meet)\n" +
                                                                              "💳: 15$/1 hour-lesson (PayPal)",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "🟡безкоштовні уроки для військових")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Хочу записатись!", "Мені потрібна ще додаткова інформація" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Індивідуальні онлайн-уроки з української для військових\n\n" +
                                                                              "Ми неймовірно вдячні нашим захисникам і захисницям. Тому з радістю допоможемо їм з поліпшенням української.\n\n" +
                                                                              "🟡 комфортні дружні уроки без зазубрювань;\n" +
                                                                              "🟡 програма розвитку під ваш запит;\n" +
                                                                              "🟡 поліпшення вимови, вивчення нових слів, практика розмовного та писемного мовлення;\n" +
                                                                              "🟡 індивідуальний підбір додаткових матеріалів (фільми, подкасти, відео, статті);\n" +
                                                                              "🟡 гнучкий графік (стале заняття або змінний день і час щотижня).\n\n" +
                                                                              "Віримо у ЗСУ та навчаймося невпинно для розвитку держави!\n\n" +
                                                                              "! Ми надаємо уроки українським військовим та іноземним військовим, що захищають Україну.\n\n" +
                                                                              "🖥️: онлайн (Google meet)\n" +
                                                                              "💳: БЕЗКОШТОВНО",
                            replyMarkup: replyKeyboardMarkup
                        );
                    }

                    if (message.Text == "English🇬🇧")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "About school", "Services" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "Choose:",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "About school")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "About school\n\n" +
                                                                              "“nevhaMOVNO” is an online Ukrainian language school. Our goal to make you fall in love with the Ukrainian language and develop Ukrainianness. We teach children and adults, prepare for exams, help to switch to the Ukrainian language, train teams. But in general, we just love the Ukrainian language and culture and strive to share this love. It is important for us to show Ukrainian not as a formal language, but as modern and relevant — through texts, songs, films, books, podcasts, memes, etc." +
                                                                              "\n    We want to create a new image of the Ukrainian language and education in general. And we hope that we will walk this path together with you!" +
                                                                              "\n\nOur values" +
                                                                              "\n◼personality" +
                                                                              "\n◼learning and development" +
                                                                              "\n◼trust" +
                                                                              "\n◼ consciousness" +
                                                                              "\n◼ responsibility" +
                                                                              "\n◼ national identity" +
                                                                              "\n\n    We become friends to our students - mentors on the way to knowledge. In addition to professional education and work experience, we have the ability to find an individual approach to each person. For us, our students are not a set of standard \"I\", but a set of different universes." +
                                                                              "\n\nInstagram 🇬🇧: https://www.instagram.com/nevhamovno_eng/ " +
                                                                              "\n\nSite: https://www.nevhamovno.com " +
                                                                              "\nInstagram 🇺🇦: https://www.instagram.com/nevhamovno/ " +
                                                                              "\nFacebook: https://www.facebook.com/nevhamovno/ " +
                                                                              "\nTikTok: https://www.tiktok.com/@nevhamovnoschool " +
                                                                              "\nTwitter: https://twitter.com/nevhamovno");
                    }

                    if (message.Text == "Services")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "Ukrainian for english-speaking people" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "Choose:",
                            replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "Ukrainian for english-speaking people")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "I want to apply!", "I need more information" },
                        });

                        await botClient.SendTextMessageAsync(message.Chat.Id, "" +
                                                                              "Ukrainian for english-speaking people\n\n" +
                                                                              "NevhaMOVNO is a creative educational institution devoted to fostering an appreciation for the Ukrainian language and culture. We has been spreading our love for Ukraine globally, providing lessons to students from Canada, the United States, Germany, France, Belgium, Switzerland, and the United Kingdom.\n\n" +
                                                                              "\"NevhaMOVNO\" offers the following services:\n\n" +
                                                                              "🟡 individual online lessons,\n" +
                                                                              "🟡 learning the Ukrainian language from scratch for children and adults,\n" +
                                                                              "🟡 individual selection of materials tailored to a given learning style,\n" +
                                                                              "🟡 personalized training programs based upon requested goals,\n" +
                                                                              "🟡 a welcoming and comfortable atmosphere,\n" +
                                                                              "🟡 flexible scheduling.\n" +
                                                                              "The study of the Ukrainian language during Russia's full-scale war against Ukraine may be an essential factor in achieving a victory for Ukraine and developing international relations between peoples. Moreover, it can help you:\n" +
                                                                              "To understand the current situation: understanding the Ukrainian language will aid in learning more about the situation on the ground and help put current events into context.\n" +
                                                                              "Facilitate communication with forced migrants from Ukraine.\n" +
                                                                              "Build relationships: knowing Ukrainian can help foreign powers build bridges and have open conversations with the locals, creating a better understanding of the region and strengthening relationships.\n\n" +
                                                                              "🖥️: online (Google meet)\n" +
                                                                              "💳: 15$/1 hour-lesson (PayPal)"
                            , replyMarkup: replyKeyboardMarkup);
                    }

                    if (message.Text == "I need more information")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "One minute! Our manager will contact you to give more information and answer your questions :)");

                        await botClient.SendTextMessageAsync((ChatId)443022729,
                            $"англомовний {message.Chat.Username} потребує допомоги");
                        await botClient.SendTextMessageAsync((ChatId)6267297624,
                            $"англомовний {message.Chat.Username} потребує допомоги");
                    }

                    if (message.Text == "I want to apply!")
                    {
                        var replyKeyboardMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new KeyboardButton[] { "I’ve filled it! What’s next?" },
                        });
                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "Please, fill the form: https://forms.gle/VetEYh5fjDWVaLcd7  It’ll help us to understand your goals and develop your personal learning plan. Approximate filling time is 7-10 minutes.",
                            replyMarkup: replyKeyboardMarkup);

                    }

                    if (message.Text == "I’ve filled it! What’s next?")
                    {
                        await botClient.SendTextMessageAsync(message.Chat.Id,
                            "Thank you for your answers! We are already selecting a Ukrainian language tutor for you, who will contact you soon to plan the first lesson. Have a nice day and thank you for choosing \"NevhaMOVNO\"!");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
          
        }
        }
}