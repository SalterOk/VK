//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VK {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public partial class VKApiManager {
        
        public class Secure : VKAPIBranch {
            
            private const string API_BRANCH = "secure.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Secure"/>.</summary>
            public Secure(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region secure.sendNotification
            /// <summary>Отправляет уведомление пользователю.</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uids">перечисленные через запятую ID пользователей, которым отправляется уведомление (максимум 100 штук)</param>
            /// <param name="message">текст уведомления, который следует передавать в кодировке UTF-8 (максимум 254 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase sendNotification(string timestamp, string random, string uids, string message) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uids", uids);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("sendNotification"), IsXMLResponse);
            }
            #endregion
            
            #region secure.getAppBalance
            /// <summary>Возвращает платежный баланс (счет) приложения в сотых долях голоса.</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getAppBalance(string timestamp, string random) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                return new VKResponseBase(GetResponse("getAppBalance"), IsXMLResponse);
            }
            #endregion
            
            #region secure.getBalance
            /// <summary>Возвращает баланс пользователя на счету приложения в сотых долях голоса.</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">ID пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getBalance(string timestamp, string random, System.Int64? uid) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                return new VKResponseBase(GetResponse("getBalance"), IsXMLResponse);
            }
            #endregion
            
            #region secure.withdrawVotes
            /// <summary>Списывает голоса со счета пользователя на счет приложения (в сотых долях).</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">ID пользователя</param>
            /// <param name="votes">количество списываемых с пользователя голосов (в сотых долях)</param>
            /// <param name="test_mode">включает тестовый режим при котором голоса не снимаются</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase withdrawVotes(string timestamp, string random, System.Int64? uid, string votes, string test_mode) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@votes", votes);
                manager.AddValueByName("@test_mode", test_mode);
                return new VKResponseBase(GetResponse("withdrawVotes"), IsXMLResponse);
            }
            #endregion
            
            #region secure.getTransactionsHistory
            /// <summary>Выводит историю транзакций по переводу голосов между пользователями и приложением.</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="type">Тип возвращаемых транзакций</param>
            /// <param name="uid_from">фильтр по ID пользователя, с баланса которого снимались голоса</param>
            /// <param name="uid_to">фильтр по ID пользователя, на баланс которого начислялись голоса</param>
            /// <param name="date_from">фильтр по дате начала</param>
            /// <param name="date_to">фильтр по дате окончания</param>
            /// <param name="limit">количество возвращаемых записей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getTransactionsHistory(string timestamp, string random, string type, string uid_from, string uid_to, string date_from, string date_to, string limit) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@type", type);
                manager.AddValueByName("@uid_from", uid_from);
                manager.AddValueByName("@uid_to", uid_to);
                manager.AddValueByName("@date_from", date_from);
                manager.AddValueByName("@date_to", date_to);
                manager.AddValueByName("@limit", limit);
                return new VKResponseBase(GetResponse("getTransactionsHistory"), IsXMLResponse);
            }
            #endregion
            
            #region secure.addRating
            /// <summary>Поднимает пользователю рейтинг от имени приложения.</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">id пользователя, которому повышается рейтинг</param>
            /// <param name="rate">количество баллов рейтинга, которое следует добавить</param>
            /// <param name="message">текст, прикрепляемый при повышению рейтинга</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase addRating(string timestamp, string random, System.Int64? uid, string rate, string message) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@rate", rate);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("addRating"), IsXMLResponse);
            }
            #endregion
            
            #region secure.setCounter
            /// <summary>Устанавливает счетчик, который выводится пользователю жирным шрифтом в левом меню. Это происходит только в том случае, если пользователь добавил приложение в левое меню со страницы приложения,</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">id пользователя, которому устанавливается счетчик</param>
            /// <param name="counter">значение счетчика</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase setCounter(string timestamp, string random, System.Int64? uid, string counter) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@counter", counter);
                return new VKResponseBase(GetResponse("setCounter"), IsXMLResponse);
            }
            #endregion
            
            #region secure.getSMSHistory
            /// <summary>Выводит список</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">фильтр по id пользователя, которому высылалось уведомление</param>
            /// <param name="date_from">фильтр по дате начала</param>
            /// <param name="date_to">фильтр по дате окончания</param>
            /// <param name="limit">количество возвращаемых записей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getSMSHistory(string timestamp, string random, System.Int64? uid, string date_from, string date_to, string limit) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@date_from", date_from);
                manager.AddValueByName("@date_to", date_to);
                manager.AddValueByName("@limit", limit);
                return new VKResponseBase(GetResponse("getSMSHistory"), IsXMLResponse);
            }
            #endregion
            
            #region secure.sendSMSNotification
            /// <summary>Отправляет</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">id пользователя, которому отправляется SMS-уведомление</param>
            /// <param name="message">текст SMS, который следует передавать в кодировке UTF-8</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase sendSMSNotification(string timestamp, string random, System.Int64? uid, string message) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("sendSMSNotification"), IsXMLResponse);
            }
            #endregion
            
            #region secure.getSMS
            /// <summary>Возвращает тексты</summary>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="uid">фильтр id пользователя: если этот параметр указан, то будут возвращаться только те SMS, которые отправил данный пользователь</param>
            /// <param name="date_from">фильтр по дате начала</param>
            /// <param name="date_to">фильтр по дате окончания</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getSMS(string timestamp, string random, System.Int64? uid, string date_from, string date_to) {
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@date_from", date_from);
                manager.AddValueByName("@date_to", date_to);
                return new VKResponseBase(GetResponse("getSMS"), IsXMLResponse);
            }
            #endregion
            
            #region secure.setLanguageValue
            /// <summary>Создает языковую фразу для перевода на другие языки.</summary>
            /// <param name="api_id">идентификатор приложения, присваивается при создании</param>
            /// <param name="sig">подпись запроса по безопасной схеме</param>
            /// <param name="v">версия API, текущая версия равна 2</param>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="key">уникальный для данного приложения ключ фразы</param>
            /// <param name="value">основной перевод фразы на выбранном языке</param>
            /// <param name="locale">язык передаваемой фразы</param>
            /// <param name="description">пояснение к переводимой фразе, которое будут видеть переводчики</param>
            /// <param name="format">формат возвращаемых данных – XML или JSON</param>
            /// <param name="test_mode">если этот параметр равен 1, разрешает тестовые запросы к данным приложения</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase setLanguageValue(string api_id, string sig, string v, string timestamp, string random, string key, string value, string locale, string description, string format, string test_mode) {
                manager.AddValueByName("@api_id", api_id);
                manager.AddValueByName("@sig", sig);
                manager.AddValueByName("@v", v);
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@key", key);
                manager.AddValueByName("@value", value);
                manager.AddValueByName("@locale", locale);
                manager.AddValueByName("@description", description);
                manager.AddValueByName("@format", format);
                manager.AddValueByName("@test_mode", test_mode);
                return new VKResponseBase(GetResponse("setLanguageValue"), IsXMLResponse);
            }
            #endregion
            
            #region secure.deleteLanguageValue
            /// <summary>Удаляет языковую фразу.</summary>
            /// <param name="api_id">идентификатор приложения, присваивается при создании</param>
            /// <param name="sig">подпись запроса по безопасной схеме</param>
            /// <param name="v">версия API, текущая версия равна 2</param>
            /// <param name="timestamp">UNIX-time сервера</param>
            /// <param name="random">любое случайное число для обеспечения уникальности запроса </param>
            /// <param name="key">ключ фразы, который необходимо удалить</param>
            /// <param name="format">формат возвращаемых данных – XML или JSON</param>
            /// <param name="test_mode">если этот параметр равен 1, разрешает тестовые запросы к данным приложения</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase deleteLanguageValue(string api_id, string sig, string v, string timestamp, string random, string key, string format, string test_mode) {
                manager.AddValueByName("@api_id", api_id);
                manager.AddValueByName("@sig", sig);
                manager.AddValueByName("@v", v);
                manager.AddValueByName("@timestamp", timestamp);
                manager.AddValueByName("@random", random);
                manager.AddValueByName("@key", key);
                manager.AddValueByName("@format", format);
                manager.AddValueByName("@test_mode", test_mode);
                return new VKResponseBase(GetResponse("deleteLanguageValue"), IsXMLResponse);
            }
            #endregion
        }
    }
}
