﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktop
{
	public static class FormExtensions
	{
		/// <summary>
		/// Returns a bool indicating whether the form is on the current virtual desktop.
		/// </summary>
		public static bool IsCurrentVirtualDesktop(this Form form)
		{
			return VirtualDesktopHelper.IsCurrentVirtualDesktop(form.Handle);
		}

		/// <summary>
		/// Moves a form to the specified virtual desktop.
		/// </summary>
		public static void MoveToDesktop(this Form form, VirtualDesktop virtualDesktop)
		{
			VirtualDesktopHelper.MoveToDesktop(form.Handle, virtualDesktop);
		}
		/// <summary>
		/// Returns the virtual desktop the specified form is located on, or null if the form cannot be found.
		/// </summary>
		public static VirtualDesktop GetCurrentDesktop(this Form form)
		{
			return VirtualDesktop.FromHwnd(form.Handle);
		}
	}
}
