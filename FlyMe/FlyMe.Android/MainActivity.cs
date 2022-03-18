using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using AndroidX;
///using static Sdk.Pendo.IO.Pendo;
using PendoIO;
using static Sdk.Pendo.IO.NativePendo;

namespace FlyMe.Droid
{
    [Activity(Label = "FlyMe", Theme = "@style/MainTheme", MainLauncher = false,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            PendoInitParams initParams = new PendoInitParams();
            initParams.SetVisitorId("ff ff");
            initParams.SetAccountId("ff ff");

            const string pendoAppKey = "eyJhbGciOiJSUzI1NiIsImtpZCI6IiIsInR5cCI6IkpXVCJ9.eyJkYXRhY2VudGVyIjoidXMiLCJrZXkiOiI1YTgzNDUxNDk4NDg4NTI0YTUxMWYyMDQyMTliY2VjNjVmN2RmNjMyOTU1Mjc2NTZhZmEzNjE0YTM0NDk5N2FmMzc1ZDQ0OTBkMDVmMmU3NmQ0ZjdlZDg4MTM2Yjk0YTJmNTJhZjgwNWNlZjljNTQ2MWFhMDI4NGU2ODVkODBiMjAwMmUyOGQxYWFjYTQ2OWYwZGYxZWQzM2NiZDM0NTljLjZkYWUyM2JmZDBjZjgzYzM1MmU1OTNjZjBiZDI2ZWNjLmZhY2VlYjQ1NWE3M2Q3ZWIyM2E2MzQ0ZTgxNjU2OTMwMTNmMWRkMzAzNWE4ZjQwNDdjODlhNzc5NWQ0OTYxMzcifQ.s4W6t53pOxYIh3-sNF6sWR1wxzmeI0H6jic6eGcpDBYdxDSAQ1-uqzjiylRgorF8IULvYcOZIEK7Yp1GWsLH_4PnOLrAsGigY5sqAkDJ7S9fjcskNAUNANDTiBU85BeVs3QuL-eCTQfn-nr1ZZ41OkVD1TJOdHVbS7NQErOpw6Q";
            InitSDK(this, pendoAppKey, initParams);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            this.SetStatusBarColor(Color.Black);
            

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}