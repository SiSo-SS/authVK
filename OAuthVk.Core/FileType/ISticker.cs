﻿namespace OAuthVk.Core.FileType
{
  public interface ISticker
  {
    /// <summary>
    /// Идентификатор стикера.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор набора.
    /// </summary>
    int ProductId { get; set; }

    /// <summary>
    /// URL изображения с высотой 64 px.
    /// </summary>
    string Photo64 { get; set; }

    /// <summary>
    /// URL изображения с высотой 128 px.
    /// </summary>
    string Photo128 { get; set; }

    /// <summary>
    /// URL изображения с высотой 256 px.
    /// </summary>
    string Photo256 { get; set; }

    /// <summary>
    /// URL изображения с высотой 352 px.
    /// </summary>
    string Photo352 { get; set; }

    /// <summary>
    /// Ширина в px.
    /// </summary>
    int Width { get; set; }

    /// <summary>
    /// Высота в px.
    /// </summary>
    int Height { get; set; }
  }
}