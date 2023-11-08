create database dbproject
use dbproject

--User Table
create  table Users
(UserId int Primary key,
Email varchar(100) not null,
Password varchar(40) not null)

sp_help Users

-- Category Table
create table Category 
(Category_ID int Primary key,
Category_Name varchar(50) not null,
Category_color varchar(20))

sp_help Category

-- Event Table
create table Events
(Event_ID int Primary key,
Title varchar(100) not null ,
Description varchar(255),
Event_start_date date not null,
Event_end_date date,
Event_start_Time time,
Event_end_Time time, 
Location varchar(100),
Category_ID int constraint fk_cat_id foreign key references category(category_id))

sp_help Events

-- Reminder Table
create table Reminder 
(Reminder_ID int Primary key,
Event_ID int constraint sk_event_id foreign key references events(event_id),
Reminder_Date_Time datetime not null,
Notification_Preferences varchar(50))

sp_help Reminder

-- User_Event Relationship Table
create table User_Events
(User_Event_ID int Primary key,
UserId int constraint fk_user_id foreign key references users(userid),
Event_ID int constraint dk_event_id foreign key references events(event_id),
Relation_type varchar(40))

sp_help User_Events

-- Recurring Event Table
create table Recurring_Event
(Recurring_Event_ID int Primary key,
Event_ID int constraint mk_event_id foreign key references events(event_id),
Pattern_Type varchar(20) not null)

sp_help Recurring_Event

-- Shared Event Table
create table Shared_Event
(Shared_Event_ID int Primary key,
Event_ID int  constraint tk_event_id foreign key references events(event_id),
Shared_With_UserID int)

sp_help Shared_Event

-- User Preferences Table
create table User_Preferences
(UserId int Primary key, 
Event_visibility_settings varchar(20),
DefaultCalendarView varchar(50),
Sync_Integration varchar(255),
Foreign key (UserId) references users(userid))
 
sp_help User_Preferences
