﻿using Chat.Contracts.Users;

namespace Chat.Contracts.Chats;

public class ChatMessageDto
{
    public Guid Id { get; set; }

    /// <summary>
    ///     内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    ///     类型
    /// </summary>
    public ChatType Type { get; set; }

    /// <summary>
    ///     id
    /// </summary>
    public Guid UserId { get; set; }

    public GetUserDto User { get; set; }


    public DateTime CreationTime { get; set; }
}