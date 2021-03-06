﻿using System;

namespace CallReminder.Core.Infrastructure
{
    public interface IDialogService
    {
        void ShowError(Exception error);

        void ShowNotification(string message);
    }
}
