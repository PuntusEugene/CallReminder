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
    public partial class ContactActivityViewHolder
    {
         private readonly Activity activity;

         private Toolbar contactToolbar;
         private Button backButton;
         private Button applyButton;
         private RecyclerView contactRecyclerView;

        public ContactActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public Toolbar ContactToolbar =>
            contactToolbar ?? (contactToolbar = activity.FindViewById<Toolbar>(Resource.Id.contact_toolbar));

        
        public Button BackButton =>
            backButton ?? (backButton = activity.FindViewById<Button>(Resource.Id.back_button));

        
        public Button ApplyButton =>
            applyButton ?? (applyButton = activity.FindViewById<Button>(Resource.Id.apply_button));

        
        public RecyclerView ContactRecyclerView =>
            contactRecyclerView ?? (contactRecyclerView = activity.FindViewById<RecyclerView>(Resource.Id.contact_recycler_view));
    }

    public partial class DetailActivityViewHolder
    {
         private readonly Activity activity;

         private AppBarLayout pageAppbar;
         private Toolbar actionToolbar;
         private Button backButton;
         private Button personAdd;
         private TextInputLayout nameContact;
         private TextInputLayout phoneContact;
         private View separator1;
         private TextView timeReminder;
         private View separator2;
         private WeekDayFragmentViewHolder calendarWeekDayViewHolder;
         private FloatingActionButton saveReminderButton;

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

        
        public Button PersonAdd =>
            personAdd ?? (personAdd = activity.FindViewById<Button>(Resource.Id.person_add));

        
        public TextInputLayout NameContact =>
            nameContact ?? (nameContact = activity.FindViewById<TextInputLayout>(Resource.Id.name_contact));

        
        public TextInputLayout PhoneContact =>
            phoneContact ?? (phoneContact = activity.FindViewById<TextInputLayout>(Resource.Id.phone_contact));

        
        public View Separator1 =>
            separator1 ?? (separator1 = activity.FindViewById<View>(Resource.Id.separator1));

        
        public TextView TimeReminder =>
            timeReminder ?? (timeReminder = activity.FindViewById<TextView>(Resource.Id.time_reminder));

        
        public View Separator2 =>
            separator2 ?? (separator2 = activity.FindViewById<View>(Resource.Id.separator2));

        
        public WeekDayFragmentViewHolder CalendarWeekDayViewHolder =>
            calendarWeekDayViewHolder ?? (calendarWeekDayViewHolder = new WeekDayFragmentViewHolder(activity.FindViewById<LinearLayout>(Resource.Id.calendar_week_day)));

        
        public FloatingActionButton SaveReminderButton =>
            saveReminderButton ?? (saveReminderButton = activity.FindViewById<FloatingActionButton>(Resource.Id.save_reminder_button));
    }

    public partial class HomeActivityViewHolder
    {
         private readonly Activity activity;

         private AppBarLayout pageAppbar;
         private Toolbar mainToolbar;
         private TextView backButton;
         private SwipeRefreshLayout swipeRefresh;
         private RecyclerView reminderRecyclerView;
         private FloatingActionButton addNewReminder;

        public HomeActivityViewHolder( Activity activity)
        {
            if (activity == null) throw new ArgumentNullException(nameof(activity));

            this.activity = activity;
        }

        
        public AppBarLayout PageAppbar =>
            pageAppbar ?? (pageAppbar = activity.FindViewById<AppBarLayout>(Resource.Id.page_appbar));

        
        public Toolbar MainToolbar =>
            mainToolbar ?? (mainToolbar = activity.FindViewById<Toolbar>(Resource.Id.main_toolbar));

        
        public TextView BackButton =>
            backButton ?? (backButton = activity.FindViewById<TextView>(Resource.Id.back_button));

        
        public SwipeRefreshLayout SwipeRefresh =>
            swipeRefresh ?? (swipeRefresh = activity.FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_refresh));

        
        public RecyclerView ReminderRecyclerView =>
            reminderRecyclerView ?? (reminderRecyclerView = activity.FindViewById<RecyclerView>(Resource.Id.reminder_recycler_view));

        
        public FloatingActionButton AddNewReminder =>
            addNewReminder ?? (addNewReminder = activity.FindViewById<FloatingActionButton>(Resource.Id.add_new_reminder));
    }

    public partial class ContactItemCellViewHolder
    {
         private ImageView contactImage;
         private TextView contactName;
         private TextView contactPhone;



        
        public ImageView ContactImage =>
            contactImage ?? (contactImage = ItemView.FindViewById<ImageView>(Resource.Id.contact_image));

        
        public TextView ContactName =>
            contactName ?? (contactName = ItemView.FindViewById<TextView>(Resource.Id.contact_name));

        
        public TextView ContactPhone =>
            contactPhone ?? (contactPhone = ItemView.FindViewById<TextView>(Resource.Id.contact_phone));
    }

    public partial class ReminderHeaderCellViewHolder
    {
         private TextView lastUpdateTime;



        
        public TextView LastUpdateTime =>
            lastUpdateTime ?? (lastUpdateTime = ItemView.FindViewById<TextView>(Resource.Id.last_update_time));
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

    public partial class WeekDayFragmentViewHolder
    {
         private readonly View rootView;

         private CheckBox monday;
         private CheckBox tuesday;
         private CheckBox wednesday;
         private CheckBox thursday;
         private CheckBox friday;
         private CheckBox suturday;
         private CheckBox sunday;

        public WeekDayFragmentViewHolder( View rootView)
        {
            if (rootView == null) throw new ArgumentNullException(nameof(rootView));

            this.rootView = rootView;
        }

        
        public CheckBox Monday =>
            monday ?? (monday = rootView.FindViewById<CheckBox>(Resource.Id.monday));

        
        public CheckBox Tuesday =>
            tuesday ?? (tuesday = rootView.FindViewById<CheckBox>(Resource.Id.tuesday));

        
        public CheckBox Wednesday =>
            wednesday ?? (wednesday = rootView.FindViewById<CheckBox>(Resource.Id.wednesday));

        
        public CheckBox Thursday =>
            thursday ?? (thursday = rootView.FindViewById<CheckBox>(Resource.Id.thursday));

        
        public CheckBox Friday =>
            friday ?? (friday = rootView.FindViewById<CheckBox>(Resource.Id.friday));

        
        public CheckBox Suturday =>
            suturday ?? (suturday = rootView.FindViewById<CheckBox>(Resource.Id.suturday));

        
        public CheckBox Sunday =>
            sunday ?? (sunday = rootView.FindViewById<CheckBox>(Resource.Id.sunday));
    }

}
// ReSharper restore All
