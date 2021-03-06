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
        
        public class Users : VKAPIBranch {
            
            private const string API_BRANCH = "users.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Users"/>.</summary>
            public Users(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region isAppUser
            /// <summary>Данный метод возвращает информацию о том, установил ли текущий пользователь приложение или нет.</summary>
            /// <param name="uid">ID пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase isAppUser(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return new VKResponseBase(GetResponse("isAppUser", true), IsXMLResponse);
            }
            
            /// <summary>Данный метод возвращает информацию о том, установил ли текущий пользователь приложение или нет.</summary>
            /// <param name="uid">ID пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase IsAppUser(System.Int64? uid = null) {
                return isAppUser(uid);
            }
            #endregion
            
            #region users.get
            /// <summary>Возвращает расширенную информацию о пользователях.</summary>
            /// <param name="uids">перечисленные через запятую ID пользователей или их короткие имена (screen_name)</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase get(string uids, ProfileFields? fields, NameCase? name_case) {
                manager.AddValueByName("@uids", uids);
                manager.AddValueByName("@fields", fields);
                manager.AddValueByName("@name_case", name_case);
                return new VKResponseBase(GetResponse("get"), IsXMLResponse);
            }
            
            /// <summary>Возвращает расширенную информацию о пользователях.</summary>
            /// <param name="uids">перечисленные через запятую ID пользователей или их короткие имена (screen_name)</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(string uids, ProfileFields? fields, NameCase? name_case) {
                return get(uids, fields, name_case);
            }
            
            /// <summary>Возвращает расширенную информацию о пользователях.</summary>
            /// <param name="uids">перечисленные через запятую ID пользователей или их короткие имена (screen_name)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(params System.Int64[] uids) {
                return get(String.Join(",", uids.Select(t => t.ToString()).ToArray()), null, null);
            }
            
            /// <summary>Возвращает расширенную информацию о пользователях.</summary>
            /// <param name="uids">перечисленные через запятую ID пользователей или их короткие имена (screen_name)</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(long[] uids, ProfileFields? fields, NameCase? name_case) {
				return get(String.Join(",", uids.Select(t => t.ToString()).ToArray()), fields, name_case);
            }
            #endregion
            
            #region users.search
            /// <summary>Возвращает список пользователей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="count">количество возвращаемых пользователей (максимум 1000)</param>
            /// <param name="offset">смещение относительно первого найденного пользователя для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase search(string q, ProfileFields? fields, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@q", q);
                manager.AddValueByName("@fields", fields);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("search"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список пользователей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="count">количество возвращаемых пользователей (максимум 1000)</param>
            /// <param name="offset">смещение относительно первого найденного пользователя для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Search(string q, ProfileFields? fields, int count, int offset) {
                return search(q, fields, count, offset);
            }
            
            /// <summary>Возвращает список пользователей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="count">количество возвращаемых пользователей (максимум 1000)</param>
            /// <param name="offset">смещение относительно первого найденного пользователя для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Search(string q, System.Int32? count = null, System.Int32? offset = null) {
                return search(q, null, count, offset);
            }
            #endregion
            
            #region getUserBalance
            /// <summary></summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUserBalance() {
                return new VKResponseBase(GetResponse("getUserBalance", true), IsXMLResponse);
            }
            
            /// <summary></summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetUserBalance() {
                return getUserBalance();
            }
            #endregion
            
            #region getUserSettings
            /// <summary>Получает настройки текущего пользователя в данном приложении.</summary>
            /// <param name="uid">ID пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUserSettings(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return new VKResponseBase(GetResponse("getUserSettings", true), IsXMLResponse);
            }
            
            /// <summary>Получает настройки текущего пользователя в данном приложении.</summary>
            /// <param name="uid">ID пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetUserSettings(System.Int64? uid = null) {
                return getUserSettings(uid);
            }
            #endregion
            
            #region getGroups
            /// <summary>Возвращает список id групп текущего пользователя.</summary>
            /// <param name="uid">ID пользователя, группы которого необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getGroups(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return new VKResponseBase(GetResponse("getGroups", true), IsXMLResponse);
            }
            
            /// <summary>Возвращает список id групп текущего пользователя.</summary>
            /// <param name="uid">ID пользователя, группы которого необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetGroups(System.Int64? uid) {
                return getGroups(uid);
            }
            #endregion
            
            #region getGroupsFull
            /// <summary>Возвращает базовую информацию о группах текущего пользователя или о группах из списка gids.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getGroupsFull() {
                return new VKResponseBase(GetResponse("getGroupsFull", true), IsXMLResponse);
            }
            
            /// <summary>Возвращает базовую информацию о группах текущего пользователя или о группах из списка gids.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetGroupsFull() {
                return getGroupsFull();
            }
            #endregion
        }
    }
}
