﻿using Microsoft.Extensions.Logging;
using Saturn.Bot.Service.Operations.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Saturn.Bot.Service.Operations;

public class ShowChatLinkOperation : OperationBase
{
    private readonly TelegramBotClient _telegramBotClient;

    public ShowChatLinkOperation(TelegramBotClient telegramBotClient, ILogger<ShowChatLinkOperation> logger) : base(logger)
    {
        _telegramBotClient = telegramBotClient;
    }

    protected override async Task ProcessOnMessageAsync(Message msg, UpdateType type)
    {
        var chat = await _telegramBotClient.GetChat(msg.Chat);
        if (string.IsNullOrEmpty(chat.InviteLink))
        {
            return;
        }
        await _telegramBotClient.SendMessage(msg.Chat, $"🔗*Ссылка на чат*: `{chat.InviteLink}`", ParseMode.MarkdownV2);
        await _telegramBotClient.SendMessage(msg.Chat, chat.InviteLink);
    }

    protected override bool ValidateOnMessage(Message msg, UpdateType type) =>
        type == UpdateType.Message &&
        !string.IsNullOrEmpty(msg.Text) &&
        msg.Text.Contains("ссылк", StringComparison.CurrentCultureIgnoreCase);
}