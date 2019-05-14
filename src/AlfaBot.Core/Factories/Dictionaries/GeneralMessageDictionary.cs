﻿namespace AlfaBot.Core.Factories.Dictionaries
{
    public static class GeneralMessageDictionary
    {
        public const string WelcomeMessage = "Привет! Добро пожаловать на стенд Альфа-Банка." +
                                             "\nВ нашем ИТ-подразделении работает более 1 200 человек: мы занимаемся поддержкой наших клиентов, разработкой и внедрением всех digital-продуктов." +
                                             "\nНаши продукты — это «Альфа-Клик», «Альфа-Мобайл», «Мобайл для бизнеса», «Поток» и другие." +
                                             "\nОставь нам свой контакт из телефонной книги." +
                                             "\nОтправляя свои данные ты соглашаешься на обработку персональных данных. EULA https://goo.gl/em3CsJ";

        public const string NameMessage = "Контакт получен.\nКак мы можем к тебе обращаться?";
        public const string ContactMessage = "Пришли свой контакт";
        public const string EmailMessage = "Теперь пришли свой email.";

        public const string ProfessionMessage =
            "Ты у цели!\nВыбери направление, в котором ты силен, или укажи свой вариант";

        public const string EndMessage =
            "Опрос завершен. Как только у нас появится подходящая вакансия, мы свяжемся с тобой.\nТакже ты можешь узнать о наших вакансиях на сайте https://hr.alfabank.ru/vacancies";

        public const string WrongEMailMessage = "Хмм, это не выглядит как email.\nПопробуй ещё раз.";
        public const string WrongMessage = "Хмм, это не то, что я хочу услышать.\nПопробуй ещё раз.";
    }
}