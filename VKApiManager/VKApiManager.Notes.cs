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
        
        public class Notes : VKAPIBranch {
            
            private const string API_BRANCH = "notes.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Notes"/>.</summary>
            public Notes(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region notes.get
            /// <summary>Возвращает список заметок, созданных пользователем.</summary>
            /// <param name="uid">id пользователя, заметки которого нужно вернуть</param>
            /// <param name="nids">перечисленные через запятую id заметок, входящие в выборку по uid</param>
            /// <param name="sort">сортировка результатов (0 - по дате создания в порядке убывания, 1 - по дате создания в порядке возрастания)</param>
            /// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества заметок</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(System.Int64? uid, string nids, SortOrder sort, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@nids", nids);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("get");
            }
            #endregion
            
            #region notes.getById
            /// <summary>Возвращает заметку по её id.</summary>
            /// <param name="nid">id запрашиваемой заметки</param>
            /// <param name="owner_id">id владельца заметки (по умолчанию используется id текущего пользователя) </param>
            /// <param name="need_wiki">определяет, требуется ли в ответе wiki-представление заметки (работает, только если запрашиваются заметки текущего пользователя) </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getById(string nid, System.Int64? owner_id, string need_wiki) {
                manager.AddValueByName("@nid", nid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@need_wiki", need_wiki);
                return GetResponse("getById");
            }
            #endregion
            
            #region notes.getFriendsNotes
            /// <summary>Возвращает список заметок, друзей пользователя.</summary>
            /// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества заметок</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getFriendsNotes(System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("getFriendsNotes");
            }
            #endregion
            
            #region notes.add
            /// <summary>Создает новую заметку у текущего пользователя.</summary>
            /// <param name="title">заголовок заметки</param>
            /// <param name="text">текст заметки</param>
            /// <param name="privacy">уровень доступа к заметке</param>
            /// <param name="comment_privacy">уровень доступа к комментированию заметки</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string add(string title, string text, string privacy, string comment_privacy) {
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@text", text);
                manager.AddValueByName("@privacy", privacy);
                manager.AddValueByName("@comment_privacy", comment_privacy);
                return GetResponse("add");
            }
            #endregion
            
            #region notes.edit
            /// <summary>Редактирует заметку текущего пользователя.</summary>
            /// <param name="nid">id редактируемой заметки</param>
            /// <param name="title">заголовок заметки</param>
            /// <param name="text">текст заметки</param>
            /// <param name="privacy">уровень доступа к заметке</param>
            /// <param name="comment_privacy">уровень доступа к комментированию заметки</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string edit(string nid, string title, string text, string privacy, string comment_privacy) {
                manager.AddValueByName("@nid", nid);
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@text", text);
                manager.AddValueByName("@privacy", privacy);
                manager.AddValueByName("@comment_privacy", comment_privacy);
                return GetResponse("edit");
            }
            #endregion
            
            #region notes.delete
            /// <summary>Удаляет заметку текущего пользователя.</summary>
            /// <param name="nid">id удаляемой заметки</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string delete(string nid) {
                manager.AddValueByName("@nid", nid);
                return GetResponse("delete");
            }
            #endregion
            
            #region notes.getComments
            /// <summary>Возращает список комментариев к заметке.</summary>
            /// <param name="nid">id заметки, комментарии которой нужно вернуть </param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="sort">сортировка результатов (0 - по дате добавления в порядке возрастания, 1 - по дате добавления в порядке убывания)</param>
            /// <param name="count">количество комментариев, которое необходимо получить (не более 100)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getComments(string nid, System.Int64? owner_id, SortOrder sort, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@nid", nid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("getComments");
            }
            #endregion
            
            #region notes.createComment
            /// <summary>Добавляет новый комментарий к заметке.</summary>
            /// <param name="nid">id заметки, в которой нужно создать комментарий </param>
            /// <param name="owner_id">идентификатор пользователя, владельца заметки (по умолчанию - текущий пользователь)</param>
            /// <param name="reply_to">id пользователя, ответом на комментарий которого является добавляемый комментарий (не передаётся если комментарий не является ответом)</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string createComment(string nid, System.Int64? owner_id, string reply_to, string message) {
                manager.AddValueByName("@nid", nid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@reply_to", reply_to);
                manager.AddValueByName("@message", message);
                return GetResponse("createComment");
            }
            #endregion
            
            #region notes.editComment
            /// <summary>Редактирует указанный комментарий у заметки.</summary>
            /// <param name="сid">id комментария, котороый нужно отредактировать </param>
            /// <param name="owner_id">идентификатор пользователя, владельца заметки (по умолчанию - текущий пользователь)</param>
            /// <param name="message">новый текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string editComment(string сid, System.Int64? owner_id, string message) {
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@message", message);
                return GetResponse("editComment");
            }
            #endregion
            
            #region notes.deleteComment
            /// <summary>Удаляет комментарий.</summary>
            /// <param name="сid">id комментария, котороый нужно удалить </param>
            /// <param name="owner_id">идентификатор пользователя, владельца заметки (по-умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string deleteComment(string сid, System.Int64? owner_id) {
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@owner_id", owner_id);
                return GetResponse("deleteComment");
            }
            #endregion
            
            #region notes.restoreComment
            /// <summary>Восстанавливает удалённый комментарий.</summary>
            /// <param name="сid">id комментария, который нужно восстановить </param>
            /// <param name="owner_id">идентификатор пользователя, владельца заметки (по умолчанию - текущий пользователь)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string restoreComment(string сid, System.Int64? owner_id) {
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@owner_id", owner_id);
                return GetResponse("restoreComment");
            }
            #endregion
        }
    }
}