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
    [Register ("AppointmentCell")]
    partial class AppointmentCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DateAndTimeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HostLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DateAndTimeLabel != null) {
                DateAndTimeLabel.Dispose ();
                DateAndTimeLabel = null;
            }

            if (HostLabel != null) {
                HostLabel.Dispose ();
                HostLabel = null;
            }
        }
    }
}