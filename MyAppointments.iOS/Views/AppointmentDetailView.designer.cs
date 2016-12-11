// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyAppointments.iOS
{
    [Register ("AppointmentDetailView")]
    partial class AppointmentDetailView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateAndTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DateAndTimeTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HostDetailsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HostLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HostTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NotesLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView NotesTextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DateAndTimeLabel != null) {
                DateAndTimeLabel.Dispose ();
                DateAndTimeLabel = null;
            }

            if (DateAndTimeTextField != null) {
                DateAndTimeTextField.Dispose ();
                DateAndTimeTextField = null;
            }

            if (HostDetailsButton != null) {
                HostDetailsButton.Dispose ();
                HostDetailsButton = null;
            }

            if (HostLabel != null) {
                HostLabel.Dispose ();
                HostLabel = null;
            }

            if (HostTextField != null) {
                HostTextField.Dispose ();
                HostTextField = null;
            }

            if (NotesLabel != null) {
                NotesLabel.Dispose ();
                NotesLabel = null;
            }

            if (NotesTextView != null) {
                NotesTextView.Dispose ();
                NotesTextView = null;
            }
        }
    }
}