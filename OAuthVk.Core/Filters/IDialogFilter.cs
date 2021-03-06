﻿namespace OAuthVk.Core.Filters
{
  public interface IDialogFilter
  {
    /// <summary>
    /// Идентификатор беседы.
    /// </summary>
    int? ChatId { get; set; }

    /// <summary>
    /// Смещение, необходимое для выборки определенного подмножества диалогов.
    /// </summary>
    int? Offset { get; set; }

    /// <summary>
    /// Количество диалогов, которое необходимо получить.
    /// </summary>
    int? Count { get; set; }

    /// <summary>
    /// Идентификатор сообщения, начиная с которого нужно вернуть список диалогов.
    /// </summary>
    /// <remarks>
    /// Если был передан параметр start_message_id, будет найдена позиция диалога в списке,
    /// идентификатор последнего сообщения которого равен start_message_id (или ближайший к нему более ранний).
    /// Начиная с этой позиции будет возвращено count диалогов.
    /// </remarks>
    int? StartMessageId { get; set; }

    /// <summary>
    /// Количество символов, по которому нужно обрезать сообщение.
    /// </summary>
    /// <remarks>
    /// Обратите внимание, текст обрезается по словам,
    /// точное число символов может не совпадать с указанным значением.
    /// </remarks>
    int? PreviewLength { get; set; }

    /// <summary>
    /// Признак того, что есть непрочитанные входящие сообщения.
    /// </summary>
    bool Unread { get; set; }

    /// <summary>
    /// Признак того, что есть диалоги с пометкой «Важные» (для сообщений сообществ).
    /// </summary>
    bool Important { get; set; }

    /// <summary>
    /// Признак того, что есть диалоги с пометкой «Неотвеченные» (для сообщений сообществ).
    /// </summary>
    bool Unanswered { get; set; }

    /// <summary>
    /// Признак удаления сообщений для сообщества иначе групповой беседы.
    /// </summary>
    bool ForCommunities { get; set; }
  }
}