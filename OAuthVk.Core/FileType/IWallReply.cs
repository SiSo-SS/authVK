﻿namespace OAuthVk.Core.FileType
{
  public interface IWallReply
  {
    /// <summary>
    /// Идентификатор комментария.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор автора комментария.
    /// </summary>
    int FromId { get; set; }

    /// <summary>
    /// Дата создания комментария в формате Unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Текст комментария.
    /// </summary>
    string Text { get; set; }

    /// <summary>
    /// Идентификатор пользователя или сообщества, в ответ которому оставлен текущий комментарий (если применимо).
    /// </summary>
    int? ReplyToUser { get; set; }

    /// <summary>
    /// Идентификатор комментария, в ответ на который оставлен текущий (если применимо).
    /// </summary>
    int? ReplyToComment { get; set; }

    /// <summary>
    /// Медиавложения комментария (фотографии, ссылки и т.п.).
    /// </summary>
    IAttachment Attachments { get; }
  }
}