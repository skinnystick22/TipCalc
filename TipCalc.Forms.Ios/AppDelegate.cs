using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using TipCalc.Core;
using TipCalc.Forms.Ui;
using UIKit;

namespace TipCalc.Forms.Ios
{
    // The UIApplicationDelegate for the uiApplication. This class is responsible for launching the
    // User Interface of the uiApplication, as well as listening (and optionally responding) to uiApplication events from iOS.
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<App, FormsApp>, App, FormsApp>
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
