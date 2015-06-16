﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicObserver.Window.Plugins
{
	public abstract class DialogPlugin : IPluginHost
	{
		public PluginType PluginType
		{
			get { return PluginType.Dialog; }
		}

		public abstract string MenuTitle { get; }

		public abstract Form GetToolWindow();

		public abstract Form GetSettingsWindow();

		public virtual string Version
		{
			get { return "1.0.0.0"; }
		}

		public virtual bool RunService( FormMain main )
		{
			return false;
		}
	}
}
