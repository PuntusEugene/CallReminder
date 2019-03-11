﻿// <auto-generated />
// ReSharper disable All
using System;
using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V4.Widget;
using Android.Support.V4.View;

namespace CallReminder.Droid.Views
{
    public partial class DetailActivityViewHolder
    {
         private readonly Activity activity;

         private AppBarLayout pageAppbar;
         private Toolbar actionToolbar;
         private Button backButton;
         private TextView detailTextView;

        public DetailActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public AppBarLayout PageAppbar =>
            pageAppbar ?? (pageAppbar = activity.FindViewById<AppBarLayout>(Resource.Id.page_appbar));

        
        public Toolbar ActionToolbar =>
            actionToolbar ?? (actionToolbar = activity.FindViewById<Toolbar>(Resource.Id.action_toolbar));

        
        public Button BackButton =>
            backButton ?? (backButton = activity.FindViewById<Button>(Resource.Id.back_button));

        
        public TextView DetailTextView =>
            detailTextView ?? (detailTextView = activity.FindViewById<TextView>(Resource.Id.detail_text_view));
    }

    public partial class HomeActivityViewHolder
    {
         private readonly Activity activity;

         private RecyclerView reminderRecyclerView;
         private FloatingActionButton addNewReminder;

        public HomeActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public RecyclerView ReminderRecyclerView =>
            reminderRecyclerView ?? (reminderRecyclerView = activity.FindViewById<RecyclerView>(Resource.Id.reminder_recycler_view));

        
        public FloatingActionButton AddNewReminder =>
            addNewReminder ?? (addNewReminder = activity.FindViewById<FloatingActionButton>(Resource.Id.add_new_reminder));
    }

    public partial class ReminderItemCellViewHolder
    {
         private TextView reminderName;
         private TextView reminderTime;
         private Android.Support.V7.Widget.SwitchCompat reminderActive;
         private TextView reminderDuration;



        
        public TextView ReminderName =>
            reminderName ?? (reminderName = ItemView.FindViewById<TextView>(Resource.Id.reminder_name));

        
        public TextView ReminderTime =>
            reminderTime ?? (reminderTime = ItemView.FindViewById<TextView>(Resource.Id.reminder_time));

        
        public Android.Support.V7.Widget.SwitchCompat ReminderActive =>
            reminderActive ?? (reminderActive = ItemView.FindViewById<Android.Support.V7.Widget.SwitchCompat>(Resource.Id.reminder_active));

        
        public TextView ReminderDuration =>
            reminderDuration ?? (reminderDuration = ItemView.FindViewById<TextView>(Resource.Id.reminder_duration));
    }

}
// ReSharper restore All