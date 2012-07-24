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
        
        public class Groups : VKAPIBranch {
            
            private const string API_BRANCH = "groups.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Groups"/>.</summary>
            public Groups(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region groups.get
            /// <summary>Возвращает список групп указанного пользователя.</summary>
            /// <param name="uid">ID пользователя, группы которого необходимо получить</param>
            /// <param name="extended">Если указать в качестве этого параметра 1, то будет возвращена полная информация о группах пользователя</param>
            /// <param name="filter">Список фильтров сообществ, которые необходимо вернуть, перечисленные через запятую</param>
            /// <param name="fields">Список полей из информации о группах, которые необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(System.Int64? uid, bool? extended, Filter filter, ProfileFields? fields) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@extended", extended);
                manager.AddValueByName("@filter", filter);
                manager.AddValueByName("@fields", fields);
                return GetResponse("get");
            }
            #endregion
            
            #region groups.getById
            /// <summary>Возвращает информацию о заданной группе или о нескольких группах.</summary>
            /// <param name="gids">ID групп, перечисленные через запятую, информацию о которых необходимо получить</param>
            /// <param name="fields">Список полей из информации о группах, которые необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getById(string gids, ProfileFields? fields) {
                manager.AddValueByName("@gids", gids);
                manager.AddValueByName("@fields", fields);
                return GetResponse("getById");
            }
            #endregion
            
            #region groups.isMember
            /// <summary>Возвращает информацию о том является ли пользователь участником заданной группы.</summary>
            /// <param name="gid">ID или короткое имя группы</param>
            /// <param name="uid">ID пользователя</param>
            /// <param name="extended">1 - вернуть ответ в расширенной форме, 2 - возвращать ответ в сокращённой форме (по умолчанию) </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string isMember(System.Int64? gid, System.Int64? uid, bool? extended) {
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@extended", extended);
                return GetResponse("isMember");
            }
            #endregion
            
            #region groups.getMembers
            /// <summary>Возвращает список участников группы.</summary>
            /// <param name="gid">ID или короткое имя группы, список пользователей которой необходимо получить</param>
            /// <param name="count">Максимальное количество участников группы, которое необходимо получить</param>
            /// <param name="offset">Число, обозначающее смещение, для получения следующих после него участников</param>
            /// <param name="sort">Сортировка с которой необходимо вернуть список групп</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getMembers(System.Int64? gid, System.Int32? count, System.Int32? offset, SortOrder sort) {
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@sort", sort);
                return GetResponse("getMembers");
            }
            #endregion
            
            #region groups.search
            /// <summary>Осуществляет поиск групп по заданной подстроке.</summary>
            /// <param name="q">Поисковый запрос по которому необходимо найти группу</param>
            /// <param name="offset">Смещение, необходимое для выборки определённого подмножества результатов поиска</param>
            /// <param name="count">Количество результатов поиска которое необходимо вернуть</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string search(string q, System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@q", q);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return GetResponse("search");
            }
            #endregion
            
            #region groups.join
            /// <summary>Данный метод позволяет вступить в группу, публичную страницу, а также подтверждать об участии во встрече.</summary>
            /// <param name="gid">Идентификатор группы, публичной страницы или встречи</param>
            /// <param name="not_sure">Опциональный параметр учитываемый, если gid принадлежит встрече</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string join(System.Int64? gid, string not_sure) {
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@not_sure", not_sure);
                return GetResponse("join");
            }
            #endregion
            
            #region groups.leave
            /// <summary>Данный метод позволяет выходить из группы, публичной страницы, или встречи.</summary>
            /// <param name="gid">Идентификатор группы, публичной страницы или встречи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string leave(System.Int64? gid) {
                manager.AddValueByName("@gid", gid);
                return GetResponse("leave");
            }
            #endregion
        }
    }
}