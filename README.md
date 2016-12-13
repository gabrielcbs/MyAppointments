# MyAppointments

The whole application has been developed using Xamarin Studio version 6.1.2 (build 44)

For the time being, in order to test, you might set the Debug to iPhone 6 iOS 10.1 Further implementation are intended for other mobile models/version.

Features:
- All appointments: display all appointments in the application scope;
- This Week: display only the appointments within the current week (today + 7 days);
- Notes can be edited according to user needs and the value persists during the application execution;

The following components have been used to facilite the implementation of the MVVM pattern:
- MVVMCross

Projects: The approach adopted was PCL (Portable Class Library).
- MyAppointments.Core: It's a PCL containing the business logic and data related to the core functionality. Implemented using MVVM. 
- MyAppointments.iOS: The app project, which has been developed using the Storyboard approach. 
- MyAppointments.Localization: A project to implement future globalization aspects such as specific language and/or currency.

Missed Implementations so far (13 Dec 2016):
- Database persistence;
- Localization;
