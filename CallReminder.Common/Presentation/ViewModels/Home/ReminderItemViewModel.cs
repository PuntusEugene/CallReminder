﻿using System;
using System.Threading;
using CallReminder.Core.Domain;
using CallReminder.Core.Repositories.Interfaces;
using CallReminder.Core.ValueConverters;
using FlexiMvvm;

namespace CallReminder.Core.Presentation.ViewModels.Home
{
    public class ReminderItemViewModel : ViewModelBase
    {
        private readonly IReminderRepository _reminderRepository;
        private string _name;
        private string _phone;
        private DateTime _time;
        private DayOfWeeksFlags _dayOfWeeks;
        private bool _repeat;
        private bool _removeState;
        private bool _selectedByRemove;

        public Guid Id { get; }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public string Phone
        {
            get => _phone;
            set => Set(ref _phone, value);
        }

        public DateTime Time
        {
            get => _time;
            set => Set(ref _time, value);
        }

        public DayOfWeeksFlags DayOfWeeks
        {
            get => _dayOfWeeks;
            set => Set(ref _dayOfWeeks, value);
        }

        public bool Repeat
        {
            get => _repeat;
            set
            {
                Set(ref _repeat, value);
                ReminderUpdate();
            }
        }

        public bool RemoveState
        {
            get => _removeState;
            set => Set(ref _removeState, value);
        }

        public bool SelectedByRemove
        {
            get => _selectedByRemove;
            set
            {
                Set(ref _selectedByRemove, value);
                SelectedByRemoveChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler SelectedByRemoveChanged;

        public ReminderItemViewModel(ReminderModel model, IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;

            Id = model.Id;
            Name = model.Name;
            Phone = model.Phone;
            Time = model.Time;
            DayOfWeeks = model.DayOfWeeks;
            Repeat = model.Repeat;
        }

        private void ReminderUpdate()
        {
            var model = new ReminderModel()
            {
                Id = Id,
                Phone = Phone,
                Name = Name,
                Time = Time,
                Repeat = Repeat,
                DayOfWeeks = DayOfWeeks
            };

            _reminderRepository.CreateOrUpdateReminderAsync(model, CancellationToken.None);
        }
    }
}
