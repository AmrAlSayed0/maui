﻿using Tizen.UIExtensions.ElmSharp;

namespace Microsoft.Maui.Platform
{
	public static class PickerExtensions
	{
		public static void UpdateTitle(this Entry platformPicker, IPicker picker) =>
			UpdatePicker(platformPicker, picker);

		public static void UpdateTitleColor(this Entry platformPicker, IPicker picker) =>
			platformPicker.PlaceholderColor = picker.TitleColor.ToPlatform();

		public static void UpdateSelectedIndex(this Entry platformPicker, IPicker picker) =>
			UpdatePicker(platformPicker, picker);

		internal static void UpdatePicker(this Entry platformPicker, IPicker picker)
		{
			if (picker.SelectedIndex == -1 || picker.SelectedIndex >= picker.GetCount())
				platformPicker.Text = string.Empty;
			else
				platformPicker.Text = picker.GetItem(picker.SelectedIndex);
		}
	}
}