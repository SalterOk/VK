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
        
        public class Audio : VKAPIBranch {
            
            private const string API_BRANCH = "audio.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Audio"/>.</summary>
            public Audio(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region audio.get
            /// <summary>Возвращает список аудиозаписей пользователя или группы.</summary>
            /// <param name="uid">id пользователя, которому принадлежат аудиозаписи (по умолчанию — текущий пользователь) </param>
            /// <param name="gid">id группы, которой принадлежат аудиозаписи</param>
            /// <param name="album_id">id альбома, аудиозаписи которого необходимо вернуть (по умолчанию возвращаются аудиозаписи из всех альбомов)</param>
            /// <param name="aids">перечисленные через запятую id аудиозаписей, входящие в выборку по uid или gid</param>
            /// <param name="need_user">если этот параметр равен 1, сервер возвратит базовую информацию о владельце аудиозаписей в структуре user (id, photo, name, name_gen)</param>
            /// <param name="count">количество возвращаемых аудиозаписей</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase get(System.Int64? uid, System.Int64? gid, System.Int64? album_id, IdList aids, System.Boolean? need_user, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@album_id", album_id);
                manager.AddValueByName("@aids", aids);
                manager.AddValueByName("@need_user", need_user);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("get"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список аудиозаписей пользователя или группы.</summary>
            /// <param name="uid">id пользователя, которому принадлежат аудиозаписи (по умолчанию — текущий пользователь) </param>
            /// <param name="album_id">id альбома, аудиозаписи которого необходимо вернуть (по умолчанию возвращаются аудиозаписи из всех альбомов)</param>
            /// <param name="aids">перечисленные через запятую id аудиозаписей, входящие в выборку по uid или gid</param>
            /// <param name="count">количество возвращаемых аудиозаписей</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <param name="need_user">если этот параметр равен 1, сервер возвратит базовую информацию о владельце аудиозаписей в структуре user (id, photo, name, name_gen)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(long uid, System.Int64? album_id = null, IdList aids = null, System.Int32? count = null, System.Int32? offset = null, System.Boolean? need_user = null) {
                return get(uid, null, album_id, aids, need_user, count, offset);
            }
            
            /// <summary>Возвращает список аудиозаписей пользователя или группы.</summary>
            /// <param name="album_id">id альбома, аудиозаписи которого необходимо вернуть (по умолчанию возвращаются аудиозаписи из всех альбомов)</param>
            /// <param name="aids">перечисленные через запятую id аудиозаписей, входящие в выборку по uid или gid</param>
            /// <param name="need_user">если этот параметр равен 1, сервер возвратит базовую информацию о владельце аудиозаписей в структуре user (id, photo, name, name_gen)</param>
            /// <param name="count">количество возвращаемых аудиозаписей</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(long album_id, IdList aids = null, System.Boolean? need_user = null, System.Int32? count = null, System.Int32? offset = null) {
                return get(null, null, album_id, aids, need_user, count, offset);
            }
            
            /// <summary>Возвращает список аудиозаписей пользователя или группы.</summary>
            /// <param name="gid">id группы, которой принадлежат аудиозаписи</param>
            /// <param name="album_id">id альбома, аудиозаписи которого необходимо вернуть (по умолчанию возвращаются аудиозаписи из всех альбомов)</param>
            /// <param name="aids">перечисленные через запятую id аудиозаписей, входящие в выборку по uid или gid</param>
            /// <param name="count">количество возвращаемых аудиозаписей</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <param name="need_user">если этот параметр равен 1, сервер возвратит базовую информацию о владельце аудиозаписей в структуре user (id, photo, name, name_gen)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetGroup(long gid, System.Int64? album_id = null, IdList aids = null, System.Int32? count = null, System.Int32? offset = null, System.Boolean? need_user = null) {
                return get(null, gid, album_id, aids, need_user, count, offset);
            }
            #endregion
            
            #region audio.getById
            /// <summary>Возвращает информацию об аудиозаписях.</summary>
            /// <param name="audios">перечисленные через запятую идентификаторы – идущие через знак подчеркивания id пользователей, которым принадлежат аудиозаписи, и id самих аудиозаписей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getById(IdList audios) {
                manager.AddValueByName("@audios", audios);
                return new VKResponseBase(GetResponse("getById"), IsXMLResponse);
            }
            
            /// <summary>Возвращает информацию об аудиозаписях.</summary>
            /// <param name="audios">перечисленные через запятую идентификаторы – идущие через знак подчеркивания id пользователей, которым принадлежат аудиозаписи, и id самих аудиозаписей</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetById(IdList audios) {
                return getById(audios);
            }
            #endregion
            
            #region audio.getCount
            /// <summary>Возвращает количество аудиозаписей пользователя или группы.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getCount() {
                return new VKResponseBase(GetResponse("getCount"), IsXMLResponse);
            }
            
            /// <summary>Возвращает количество аудиозаписей пользователя или группы.</summary>
            /// <param name="oid"></param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetCount(long oid) {
                return getCount();
            }
            #endregion
            
            #region audio.getLyrics
            /// <summary>Возвращает текст аудиозаписи по параметру lyrics_id, полученному в результате работы методов</summary>
            /// <param name="lyrics_id">id текста аудиозаписи, полученный в audio</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getLyrics(System.Int64? lyrics_id) {
                manager.AddValueByName("@lyrics_id", lyrics_id);
                return new VKResponseBase(GetResponse("getLyrics"), IsXMLResponse);
            }
            
            /// <summary>Возвращает текст аудиозаписи по параметру lyrics_id, полученному в результате работы методов</summary>
            /// <param name="lyrics_id">id текста аудиозаписи, полученный в audio</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetLyrics(long lyrics_id) {
                return getLyrics(lyrics_id);
            }
            #endregion
            
            #region audio.getUploadServer
            /// <summary></summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUploadServer() {
                return new VKResponseBase(GetResponse("getUploadServer"), IsXMLResponse);
            }
            
            /// <summary></summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetUploadServer() {
                return getUploadServer();
            }
            #endregion
            
            #region audio.save
            /// <summary>Сохраняет аудиозаписи после успешной</summary>
            /// <param name="server">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="audio">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="hash">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="artist">автор композиции</param>
            /// <param name="title">название композиции</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase save(string server, string audio, string hash, string artist, string title) {
                manager.AddValueByName("@server", server);
                manager.AddValueByName("@audio", audio);
                manager.AddValueByName("@hash", hash);
                manager.AddValueByName("@artist", artist);
                manager.AddValueByName("@title", title);
                return new VKResponseBase(GetResponse("save"), IsXMLResponse);
            }
            
            /// <summary>Сохраняет аудиозаписи после успешной</summary>
            /// <param name="server">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="audio">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="hash">параметр, возвращаемый в результате загрузки аудиофайла на сервер</param>
            /// <param name="artist">автор композиции</param>
            /// <param name="title">название композиции</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Save(string server, string audio, string hash, string artist = null, string title = null) {
                return save(server, audio, hash, artist, title);
            }
            #endregion
            
            #region audio.search
            /// <summary>Возвращает список аудиозаписей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="auto_complete">Если этот параметр равен 1, возможные ошибки в поисковом запросе будут исправлены</param>
            /// <param name="sort">Вид сортировки</param>
            /// <param name="lyrics">Если этот параметр равен 1, поиск будет производиться только по тем аудиозаписям, которые содержат тексты</param>
            /// <param name="count">количество возвращаемых аудиозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase search(string q, System.Boolean? auto_complete, AudioSortOrder? sort, System.Boolean? lyrics, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@q", q);
                manager.AddValueByName("@auto_complete", auto_complete);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@lyrics", lyrics);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("search"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список аудиозаписей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="auto_complete">Если этот параметр равен 1, возможные ошибки в поисковом запросе будут исправлены</param>
            /// <param name="sort">Вид сортировки</param>
            /// <param name="lyrics">Если этот параметр равен 1, поиск будет производиться только по тем аудиозаписям, которые содержат тексты</param>
            /// <param name="count">количество возвращаемых аудиозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной аудиозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Search(string q, System.Boolean? auto_complete = null, AudioSortOrder? sort = null, System.Boolean? lyrics = null, System.Int32? count = null, System.Int32? offset = null) {
                return search(q, auto_complete, sort, lyrics, count, offset);
            }
            #endregion
            
            #region audio.add
            /// <summary>Копирует аудиозапись на страницу пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <param name="gid">id группы, в которую следует копировать аудиозапись</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase add(System.Int64? aid, System.Int64? oid, System.Int64? gid) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                manager.AddValueByName("@gid", gid);
                return new VKResponseBase(GetResponse("add"), IsXMLResponse);
            }
            
            /// <summary>Копирует аудиозапись на страницу пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <param name="gid">id группы, в которую следует копировать аудиозапись</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Add(long aid, long oid, System.Int64? gid = null) {
                return add(aid, oid, gid);
            }
            #endregion
            
            #region audio.delete
            /// <summary>Удаляет аудиозапись со страницы пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase delete(System.Int64? aid, System.Int64? oid) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("delete"), IsXMLResponse);
            }
            
            /// <summary>Удаляет аудиозапись со страницы пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Delete(long aid, long oid) {
                return delete(aid, oid);
            }
            #endregion
            
            #region audio.edit
            /// <summary>Редактирует данные аудиозаписи на странице пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <param name="artist">название исполнителя аудиозаписи</param>
            /// <param name="title">название аудиозаписи</param>
            /// <param name="text">текст аудиозаписи, если введен</param>
            /// <param name="no_search">1 - скрывает аудиозапись из поиска по аудиозаписям, 0 (по умолчанию) - не скрывает</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase edit(System.Int64? aid, System.Int64? oid, string artist, string title, string text, System.Boolean? no_search) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                manager.AddValueByName("@artist", artist);
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@text", text);
                manager.AddValueByName("@no_search", no_search);
                return new VKResponseBase(GetResponse("edit"), IsXMLResponse);
            }
            
            /// <summary>Редактирует данные аудиозаписи на странице пользователя или группы.</summary>
            /// <param name="aid">id аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <param name="artist">название исполнителя аудиозаписи</param>
            /// <param name="title">название аудиозаписи</param>
            /// <param name="text">текст аудиозаписи, если введен</param>
            /// <param name="no_search">1 - скрывает аудиозапись из поиска по аудиозаписям, 0 (по умолчанию) - не скрывает</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Edit(long aid, long oid, string artist, string title, string text, System.Boolean? no_search = null) {
                return edit(aid, oid, artist, title, text, no_search);
            }
            #endregion
            
            #region audio.restore
            /// <summary>Восстанавливает удаленную аудиозапись пользователя после</summary>
            /// <param name="aid">id удаленной аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase restore(System.Int64? aid, System.Int64? oid) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("restore"), IsXMLResponse);
            }
            
            /// <summary>Восстанавливает удаленную аудиозапись пользователя после</summary>
            /// <param name="aid">id удаленной аудиозаписи</param>
            /// <param name="oid">id владельца аудиозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Restore(long aid, System.Int64? oid = null) {
                return restore(aid, oid);
            }
            #endregion
            
            #region audio.reorder
            /// <summary>Изменяет порядок аудиозаписи, перенося ее между аудиозаписями, идентификаторы которых переданы параметрами after и before.</summary>
            /// <param name="aid">id аудиозаписи, порядок которой изменяется</param>
            /// <param name="oid">id владельца изменяемой аудиозаписи</param>
            /// <param name="after">id аудиозаписи, после которой нужно поместить аудиозапись</param>
            /// <param name="before">id аудиозаписи, перед которой нужно поместить аудиозапись</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase reorder(System.Int64? aid, System.Int64? oid, System.Int64? after, System.Int64? before) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                manager.AddValueByName("@after", after);
                manager.AddValueByName("@before", before);
                return new VKResponseBase(GetResponse("reorder"), IsXMLResponse);
            }
            
            /// <summary>Изменяет порядок аудиозаписи, перенося ее между аудиозаписями, идентификаторы которых переданы параметрами after и before.</summary>
            /// <param name="aid">id аудиозаписи, порядок которой изменяется</param>
            /// <param name="after">id аудиозаписи, после которой нужно поместить аудиозапись</param>
            /// <param name="before">id аудиозаписи, перед которой нужно поместить аудиозапись</param>
            /// <param name="oid">id владельца изменяемой аудиозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Reorder(long aid, long after, long before, System.Int64? oid = null) {
                return reorder(aid, oid, after, before);
            }
            #endregion
        }
    }
}
