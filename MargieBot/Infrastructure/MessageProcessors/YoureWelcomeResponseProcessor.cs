﻿using MargieBot.Infrastructure.Models;
using System.Text.RegularExpressions;

namespace MargieBot.Infrastructure.MessageProcessors
{
    public class YoureWelcomeResponseProcessor : IResponseProcessor
    {
        public bool CanRespond(MargieContext context)
        {
            return Regex.IsMatch(context.Message.Text, @"thanks(.+)?(margie|margie\sbot|<@" + context.MargiesUserID + @">)", RegexOptions.IgnoreCase);
        }

        public string GetResponse(MargieContext context)
        {
            return context.Phrasebook.GetYoureWelcome();
        }
    }
}