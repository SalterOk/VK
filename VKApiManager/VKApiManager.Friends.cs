//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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
        
        public class Friends : VKAPIBranch {
            
            private const string API_BRANCH = "friends.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Friends"/>.</summary>
            public Friends(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region friends.get
            /// <summary>Возвращает список идентификаторов друзей пользователя или расширенную информацию о друзьях пользователя (при использовании параметра</summary>
            /// <param name="uid">идентификатор пользователя, для которого необходимо получить список друзей</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <param name="count">количество друзей, которое нужно вернуть</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества друзей</param>
            /// <param name="lid">идентификатор списка друзей, полученный методом friends</param>
            /// <param name="order">Порядок в котором нужно вернуть список друзей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(System.Int64? uid, ProfileFields? fields, NameCase? name_case, System.Int32? count, System.Int32? offset, System.Int64? lid, string order) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@fields", fields);
                manager.AddValueByName("@name_case", name_case);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@lid", lid);
                manager.AddValueByName("@order", order);
                return GetResponse("get");
            }
            
            /// <summary>Возвращает список идентификаторов друзей пользователя или расширенную информацию о друзьях пользователя (при использовании параметра</summary>
            /// <param name="uid">идентификатор пользователя, для которого необходимо получить список друзей</param>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <param name="count">количество друзей, которое нужно вернуть</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества друзей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string Get(long uid, ProfileFields fields, NameCase name_case, System.Int32? count = null, System.Int32? offset = null) {
                return get(uid, fields, name_case, count, offset, 0, null);
            }
            
            /// <summary>Возвращает список идентификаторов друзей пользователя или расширенную информацию о друзьях пользователя (при использовании параметра</summary>
            /// <param name="fields">перечисленные через запятую поля анкет, необходимые для получения</param>
            /// <param name="name_case">падеж для склонения имени и фамилии пользователя</param>
            /// <param name="lid">идентификатор списка друзей, полученный методом friends</param>
            /// <param name="count">количество друзей, которое нужно вернуть</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества друзей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			public string Get(ProfileFields fields, NameCase name_case, System.Int64? lid = null, System.Int32? count = null, System.Int32? offset = null)
			{
                return get(0, fields, name_case, count, offset, lid, null);
            }
            
            /// <summary>Возвращает список идентификаторов друзей пользователя или расширенную информацию о друзьях пользователя (при использовании параметра</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string Get() {
                return get(0, null, null, 0, 0, 0, null);
            }
            #endregion
            
            #region friends.getAppUsers
            /// <summary>Возвращает список идентификаторов друзей текущего пользователя, которые установили данное приложение.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getAppUsers() {
                return GetResponse("getAppUsers");
            }
            
            /// <summary>Возвращает список идентификаторов друзей текущего пользователя, которые установили данное приложение.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetAppUsers() {
                return getAppUsers();
            }
            #endregion
            
            #region friends.getOnline
            /// <summary>Возвращает список идентификаторов, находящихся на сайте друзей, текущего пользователя.</summary>
            /// <param name="uid">идентификатор пользователя, для которого необходимо получить список друзей, находящихся сейчас на сайте</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getOnline(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return GetResponse("getOnline");
            }
            
            /// <summary>Возвращает список идентификаторов, находящихся на сайте друзей, текущего пользователя.</summary>
            /// <param name="uid">идентификатор пользователя, для которого необходимо получить список друзей, находящихся сейчас на сайте</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetOnline(System.Int64? uid = null) {
                return getOnline(uid);
            }
            #endregion
            
            #region friends.getMutual
            /// <summary>Возвращает список идентификаторов общих друзей между парой пользователей.</summary>
            /// <param name="target_uid">идентификатор пользователя, с которым необходимо искать общих друзей</param>
            /// <param name="source_uid">идентификатор пользователя, чьи друзья пересекаются с друзьями пользователя с идентификатором target_uid</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getMutual(System.Int64? target_uid, System.Int64? source_uid) {
                manager.AddValueByName("@target_uid", target_uid);
                manager.AddValueByName("@source_uid", source_uid);
                return GetResponse("getMutual");
            }
            
            /// <summary>Возвращает список идентификаторов общих друзей между парой пользователей.</summary>
            /// <param name="target_uid">идентификатор пользователя, с которым необходимо искать общих друзей</param>
            /// <param name="source_uid">идентификатор пользователя, чьи друзья пересекаются с друзьями пользователя с идентификатором target_uid</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetMutual(long target_uid, System.Int64? source_uid = null) {
                return getMutual(target_uid, source_uid);
            }
            #endregion
            
            #region friends.areFriends
            /// <summary>Возвращает информацию о том добавлен ли текущий пользователь в друзья у указанных пользователей.</summary>
            /// <param name="uids">Список идентификаторов пользователей, раделённых запятыми, статус дружбы с которыми необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string areFriends(IdList uids) {
                manager.AddValueByName("@uids", uids);
                return GetResponse("areFriends");
            }
            
            /// <summary>Возвращает информацию о том добавлен ли текущий пользователь в друзья у указанных пользователей.</summary>
            /// <param name="uids">Список идентификаторов пользователей, раделённых запятыми, статус дружбы с которыми необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string AreFriends(IdList uids) {
                return areFriends(uids);
            }
            
            /// <summary>Возвращает информацию о том добавлен ли текущий пользователь в друзья у указанных пользователей.</summary>
            /// <param name="uids">Список идентификаторов пользователей, раделённых запятыми, статус дружбы с которыми необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string AreFriends(params System.Int64[] uids) {
                return areFriends(new IdList(uids));
            }
            #endregion
            
            #region friends.getLists
            /// <summary>Возвращает список меток друзей текущего пользователя.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getLists() {
                return GetResponse("getLists");
            }
            
            /// <summary>Возвращает список меток друзей текущего пользователя.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetLists() {
                return getLists();
            }
            #endregion
            
            #region friends.addList
            /// <summary>Создает новый список друзей у текущего пользователя.</summary>
            /// <param name="name">название создаваемого списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которых необходимо включить в создаваемый список</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string addList(string name, IdList uids) {
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@uids", uids);
                return GetResponse("addList");
            }
            
            /// <summary>Создает новый список друзей у текущего пользователя.</summary>
            /// <param name="name">название создаваемого списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которых необходимо включить в создаваемый список</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string AddList(string name, IdList uids) {
                return addList(name, uids);
            }
            
            /// <summary>Создает новый список друзей у текущего пользователя.</summary>
            /// <param name="name">название создаваемого списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которых необходимо включить в создаваемый список</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string AddList(string name, params System.Int64[] uids) {
                return addList(name, new IdList(uids));
            }
            #endregion
            
            #region friends.editList
            /// <summary>Редактирует существующий список друзей текущего пользователя.</summary>
            /// <param name="lid">идентификатор существующего списка друзей</param>
            /// <param name="name">название списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которым необходимо поставить метку</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string editList(System.Int64? lid, string name, IdList uids) {
                manager.AddValueByName("@lid", lid);
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@uids", uids);
                return GetResponse("editList");
            }
            
            /// <summary>Редактирует существующий список друзей текущего пользователя.</summary>
            /// <param name="lid">идентификатор существующего списка друзей</param>
            /// <param name="name">название списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которым необходимо поставить метку</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			public string EditList(long lid, string name, IdList uids)
			{
                return editList(lid, name, uids);
            }
            
            /// <summary>Редактирует существующий список друзей текущего пользователя.</summary>
            /// <param name="lid">идентификатор существующего списка друзей</param>
            /// <param name="name">название списка друзей</param>
            /// <param name="uids">перечисленные через запятую идентификаторы друзей пользователя, которым необходимо поставить метку</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string EditList(long lid, string name, params System.Int64[] uids) {
                return editList(lid, name, new IdList(uids));
            }
            #endregion
            
            #region friends.add
            /// <summary>Если идентификатор выбранного пользователя присутствует в списке заявок на добавление в друзья, полученным методом</summary>
            /// <param name="uid">идентификатор пользователя которому необходимо отправить заявку, либо заявку от которого необходимо одобрить</param>
            /// <param name="text">текст сопроводительного сообщения для заявки на добавление в друзья</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string add(System.Int64? uid, string text) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@text", text);
                return GetResponse("add");
            }
            
            /// <summary>Если идентификатор выбранного пользователя присутствует в списке заявок на добавление в друзья, полученным методом</summary>
            /// <param name="uid">идентификатор пользователя которому необходимо отправить заявку, либо заявку от которого необходимо одобрить</param>
            /// <param name="text">текст сопроводительного сообщения для заявки на добавление в друзья</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string Add(long uid, string text = null) {
                return add(uid, text);
            }
            #endregion
            
            #region friends.delete
            /// <summary>Если идентификатор выбранного пользователя присутствует в списке заявок на добавление в друзья, полученным методом</summary>
            /// <param name="uid">идентификатор пользователя, которого необходимо удалить из списка друзей, либо заявку от которого необходимо отклонить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string delete(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return GetResponse("delete");
            }
            
            /// <summary>Если идентификатор выбранного пользователя присутствует в списке заявок на добавление в друзья, полученным методом</summary>
            /// <param name="uid">идентификатор пользователя, которого необходимо удалить из списка друзей, либо заявку от которого необходимо отклонить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string Delete(long uid) {
                return delete(uid);
            }
            #endregion
            
            #region friends.getRequests
            /// <summary>Возвращает информацию о полученных или отправленных заявках на добавление в друзья для текущего пользователя.</summary>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества заявок на добавление в друзья</param>
            /// <param name="count">максимальное количество заявок на добавление в друзья, которые необходимо получить (не более 1000)</param>
            /// <param name="need_messages">определяет требуется ли возвращать в ответе сообщения от пользователей, подавших заявку на добавление в друзья</param>
            /// <param name="need_mutual">определяет требуется ли возвращать в ответе список общих друзей, если они есть</param>
            /// <param name="out">0 - возвращать полученные заявки в друзья (по умолчанию), 1 - возвращать отправленные пользователем заявки</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getRequests(System.Int32? offset, System.Int32? count, bool? need_messages, bool? need_mutual, bool? @out) {
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@need_messages", need_messages);
                manager.AddValueByName("@need_mutual", need_mutual);
                manager.AddValueByName("@out", @out);
                return GetResponse("getRequests");
            }
            
            /// <summary>Возвращает информацию о полученных или отправленных заявках на добавление в друзья для текущего пользователя.</summary>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества заявок на добавление в друзья</param>
            /// <param name="count">максимальное количество заявок на добавление в друзья, которые необходимо получить (не более 1000)</param>
            /// <param name="need_messages">определяет требуется ли возвращать в ответе сообщения от пользователей, подавших заявку на добавление в друзья</param>
            /// <param name="need_mutual">определяет требуется ли возвращать в ответе список общих друзей, если они есть</param>
            /// <param name="out">0 - возвращать полученные заявки в друзья (по умолчанию), 1 - возвращать отправленные пользователем заявки</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetRequests(int offset, int count, bool? need_messages = null, bool? need_mutual = null, bool? @out = null) {
                return getRequests(offset, count, need_messages, need_mutual, @out);
            }
            #endregion
            
            #region friends.deleteAllRequests
            /// <summary>Отмечает все входящие заявки на добавление в друзья как просмотренные.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string deleteAllRequests() {
                return GetResponse("deleteAllRequests");
            }
            
            /// <summary>Отмечает все входящие заявки на добавление в друзья как просмотренные.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string DeleteAllRequests() {
                return deleteAllRequests();
            }
            #endregion
            
            #region friends.getSuggestions
            /// <summary>Возвращает список профилей пользователей, которые могут быть друзьями текущего пользователя.</summary>
            /// <param name="filter">Типы предрагаемых друзей которые нужно вернуть, перечисленные через запятую</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getSuggestions(Filter filter) {
                manager.AddValueByName("@filter", filter);
                return GetResponse("getSuggestions");
            }
            
            /// <summary>Возвращает список профилей пользователей, которые могут быть друзьями текущего пользователя.</summary>
            /// <param name="filter">Типы предрагаемых друзей которые нужно вернуть, перечисленные через запятую</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public string GetSuggestions(Filter filter) {
                return getSuggestions(filter);
            }
            #endregion
        }
    }
}