using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using JabbrMobile.Common.ViewModels;

namespace JabbrMobile.Android.Views
{
	public class MenuFragment : MvxFragment
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);

			var view = this.BindingInflate (Resource.Layout.Fragment_Menu, null);

			var rooms = view.FindViewById<MvxListView> (Resource.Id.mvxListViewRooms);

			rooms.SetSelector (Resource.Drawable.ListItem_Menu_Room_Selector);
			//rooms.ChoiceMode = ChoiceMode.Single;

			return view;
		}
	}
}

