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
        
        public class Video : VKAPIBranch {
            
            private const string API_BRANCH = "video.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Video"/>.</summary>
            public Video(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region video.get
            /// <summary>Возвращает информацию о видеозаписях.</summary>
            /// <param name="videos">перечисленные через запятую идентификаторы – идущие через знак подчеркивания id пользователей, которым принадлежат видеозаписи, и id самих видеозаписей</param>
            /// <param name="uid">id пользователя, видеозаписи которого нужно вернуть</param>
            /// <param name="gid">id группы, видеозаписи которой нужно вернуть</param>
            /// <param name="aid">id альбома видеозаписи из которого нужно вернуть</param>
            /// <param name="width">требуемая ширина изображений видеозаписей в пикселах</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase get(IdList videos, System.Int64? uid, System.Int64? gid, System.Int64? aid, System.Int32? width, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@videos", videos);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@width", width);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("get"), IsXMLResponse);
            }
            
            /// <summary>Возвращает информацию о видеозаписях.</summary>
            /// <param name="videos">перечисленные через запятую идентификаторы – идущие через знак подчеркивания id пользователей, которым принадлежат видеозаписи, и id самих видеозаписей</param>
            /// <param name="width">требуемая ширина изображений видеозаписей в пикселах</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(IdList videos, System.Int32? width = null, System.Int32? count = null, System.Int32? offset = null) {
                return get(videos, null, null, null, width, count, offset);
            }
            
            /// <summary>Возвращает информацию о видеозаписях.</summary>
            /// <param name="uid">id пользователя, видеозаписи которого нужно вернуть</param>
            /// <param name="width">требуемая ширина изображений видеозаписей в пикселах</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(System.Int64? uid, System.Int32? width = null, System.Int32? count = null, System.Int32? offset = null) {
                return get(null, uid, null, null, width, count, offset);
            }
            #endregion
            
            #region video.edit
            /// <summary>Редактирует данные видеозаписи на странице пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <param name="name">название видеозаписи</param>
            /// <param name="desc">описание видеозаписи</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase edit(Id vid, System.Int64? oid, string name, string desc, AccessValue? privacy_view, AccessValue? privacy_comment) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@desc", desc);
                manager.AddValueByName("@privacy_view", privacy_view);
                manager.AddValueByName("@privacy_comment", privacy_comment);
                return new VKResponseBase(GetResponse("edit"), IsXMLResponse);
            }
            
            /// <summary>Редактирует данные видеозаписи на странице пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <param name="name">название видеозаписи</param>
            /// <param name="desc">описание видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Edit(Id vid, System.Int64? oid, string name = null, string desc = null) {
                return edit(vid, oid, name, desc, null, null);
            }
            
            /// <summary>Редактирует данные видеозаписи на странице пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <param name="name">название видеозаписи</param>
            /// <param name="desc">описание видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Edit(Id vid, System.Int64? oid, AccessValue? privacy_view = null, AccessValue? privacy_comment = null, string name = null, string desc = null) {
                return edit(vid, oid, name, desc, privacy_view, privacy_comment);
            }
            #endregion
            
            #region video.add
            /// <summary>Копирует видеозапись на страницу пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase add(Id vid, System.Int64? oid) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("add"), IsXMLResponse);
            }
            
            /// <summary>Копирует видеозапись на страницу пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Add(Id vid, System.Int64? oid) {
                return add(vid, oid);
            }
            #endregion
            
            #region video.delete
            /// <summary>Удаляет видеозапись со страницы пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase delete(Id vid, System.Int64? oid) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("delete"), IsXMLResponse);
            }
            
            /// <summary>Удаляет видеозапись со страницы пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Delete(Id vid, System.Int64? oid) {
                return delete(vid, oid);
            }
            #endregion
            
            #region video.search
            /// <summary>Возвращает список видеозаписей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="sort">Вид сортировки</param>
            /// <param name="hd">Если не равен нулю, то поиск производится только по видеозаписям высокого качества</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase search(string q, VideoSortOrder? sort, System.Boolean? hd, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@q", q);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@hd", hd);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("search"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список видеозаписей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="sort">Вид сортировки</param>
            /// <param name="hd">Если не равен нулю, то поиск производится только по видеозаписям высокого качества</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Search(string q, VideoSortOrder? sort = null, System.Boolean? hd = null, System.Int32? count = null, System.Int32? offset = null) {
                return search(q, sort, hd, count, offset);
            }
            #endregion
            
            #region video.getUserVideos
            /// <summary>Возвращает список видеозаписей, на которых отмечен пользователь.</summary>
            /// <param name="uid">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества видеозаписей</param>
            /// <param name="count">количество видеозаписей, которое необходимо получить (но не более 100)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUserVideos(System.Int64? uid, System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return new VKResponseBase(GetResponse("getUserVideos"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список видеозаписей, на которых отмечен пользователь.</summary>
            /// <param name="uid">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества видеозаписей</param>
            /// <param name="count">количество видеозаписей, которое необходимо получить (но не более 100)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetUserVideos(System.Int64? uid, System.Int32? offset = null, System.Int32? count = null) {
                return getUserVideos(uid, offset, count);
            }
            #endregion
            
            #region video.getComments
            /// <summary>Возвращает список комментариев к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить (но не более 100)</param>
            /// <param name="sort">порядок сортировки комментариев (asc - от старых к новым, desc - от новых к старым) </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getComments(Id vid, System.Int64? owner_id, System.Int32? offset, System.Int32? count, SortOrder? sort) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@sort", sort);
                return new VKResponseBase(GetResponse("getComments"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список комментариев к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="sort">порядок сортировки комментариев (asc - от старых к новым, desc - от новых к старым) </param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить (но не более 100)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetComments(Id vid, SortOrder? sort = null, System.Int32? offset = null, System.Int32? count = null) {
                return getComments(vid, null, offset, count, sort);
            }
            
            /// <summary>Возвращает список комментариев к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="sort">порядок сортировки комментариев (asc - от старых к новым, desc - от новых к старым) </param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить (но не более 100)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetComments(Id vid, System.Int64? owner_id, SortOrder? sort = null, System.Int32? offset = null, System.Int32? count = null) {
                return getComments(vid, owner_id, offset, count, sort);
            }
            #endregion
            
            #region video.createComment
            /// <summary>Cоздает новый комментарий к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase createComment(Id vid, System.Int64? owner_id, string message) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("createComment"), IsXMLResponse);
            }
            
            /// <summary>Cоздает новый комментарий к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase CreateComment(Id vid, string message, System.Int64? owner_id = null) {
                return createComment(vid, owner_id, message);
            }
            #endregion
            
            #region video.editComment
            /// <summary>Изменяет текст комментария к видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="сid">идентификатор комментария</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase editComment(System.Int64? owner_id, System.Int64? сid, string message) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("editComment"), IsXMLResponse);
            }
            
            /// <summary>Изменяет текст комментария к видеозаписи.</summary>
            /// <param name="сid">идентификатор комментария</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase EditComment(System.Int64? сid, string message, System.Int64? owner_id = null) {
                return editComment(owner_id, сid, message);
            }
            #endregion
            
            #region video.deleteComment
            /// <summary>Удаляет комментарий к видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по-умолчанию - текущий пользователь)</param>
            /// <param name="cid">идентификатор комментария</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase deleteComment(System.Int64? owner_id, Id cid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@cid", cid);
                return new VKResponseBase(GetResponse("deleteComment"), IsXMLResponse);
            }
            
            /// <summary>Удаляет комментарий к видеозаписи.</summary>
            /// <param name="cid">идентификатор комментария</param>
            /// <param name="owner_id">идентификатор пользователя (по-умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase DeleteComment(Id cid, System.Int64? owner_id = null) {
                return deleteComment(owner_id, cid);
            }
            #endregion
            
            #region video.getTags
            /// <summary>Возвращает список отметок на видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getTags(System.Int64? owner_id, Id vid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                return new VKResponseBase(GetResponse("getTags"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список отметок на видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase GetTags(Id vid, System.Int64? owner_id = null) {
                return getTags(owner_id, vid);
            }
            #endregion
            
            #region video.putTag
            /// <summary>Добавляет отметку на видеозапись.</summary>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="uid">идентификатор пользователя, которого нужно отметить на видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase putTag(System.Int64? owner_id, Id vid, System.Int64? uid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@uid", uid);
                return new VKResponseBase(GetResponse("putTag"), IsXMLResponse);
            }
            
            /// <summary>Добавляет отметку на видеозапись.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="uid">идентификатор пользователя, которого нужно отметить на видеозаписи</param>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase PutTag(Id vid, System.Int64? uid, System.Int64? owner_id = null) {
                return putTag(owner_id, vid, uid);
            }
            #endregion
            
            #region video.removeTag
            /// <summary>Удаляет отметку с видеозаписи.</summary>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="tag_id">идентификатор отметки, которую нужно удалить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase removeTag(System.Int64? owner_id, Id vid, System.Int64? tag_id) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@tag_id", tag_id);
                return new VKResponseBase(GetResponse("removeTag"), IsXMLResponse);
            }
            
            /// <summary>Удаляет отметку с видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="tag_id">идентификатор отметки, которую нужно удалить</param>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase RemoveTag(Id vid, System.Int64? tag_id, System.Int64? owner_id = null) {
                return removeTag(owner_id, vid, tag_id);
            }
            #endregion
            
            #region video.save
            /// <summary>Возвращает адрес сервера (необходимый для</summary>
            /// <param name="name">название видеофайла</param>
            /// <param name="description">описание видеофайла</param>
            /// <param name="gid">Группа, в которую будет сохранён видеофайл</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase save(string name, string description, System.Int64? gid, AccessValue? privacy_view, AccessValue? privacy_comment) {
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@description", description);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@privacy_view", privacy_view);
                manager.AddValueByName("@privacy_comment", privacy_comment);
                return new VKResponseBase(GetResponse("save"), IsXMLResponse);
            }
            
            /// <summary>Возвращает адрес сервера (необходимый для</summary>
            /// <param name="name">название видеофайла</param>
            /// <param name="gid">Группа, в которую будет сохранён видеофайл</param>
            /// <param name="description">описание видеофайла</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Save(string name, System.Int64? gid, string description = null, AccessValue? privacy_view = null, AccessValue? privacy_comment = null) {
                return save(name, description, gid, privacy_view, privacy_comment);
            }
            #endregion
        }
    }
}
