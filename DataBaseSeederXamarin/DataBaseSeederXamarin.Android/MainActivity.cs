﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using DataBaseSeeder;
using Prism;
using Prism.Autofac;
using Prism.Ioc;

namespace DataBaseSeederXamarin.Droid
{
    [Activity(Label = "DataBaseSeederXamarin", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Ioc_Register.Load(containerRegistry.GetBuilder());
        }
    }
}

