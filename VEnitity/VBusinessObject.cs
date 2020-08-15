using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace VEntityFramework.Data
{
	public abstract class VBusinessObject : INotifyPropertyChanged
	{
		public VBusinessObject()
		{
			Context = new VDataContext();
			SetDefaultValues();
		}

		protected virtual void SetDefaultValues()
		{
		}

		public bool ExistsInXML { get; set; }

		public VDataContext Context { get; set; }

		public abstract string BizoName { get; }

		public void Save()
		{
			OnSaving();
			Context.SaveAsXML(this);
			OnSaved();
		}

		protected virtual void OnSaving()
		{
		}

		protected virtual void OnSaved()
		{
		}

		public void Delete()
		{
			Context.DeleteXML(this);
		}

		public void RunPreSaveValidation()
		{
			Notifications.Clear();
			RunPreSaveValidationCore();
		}

		protected virtual void RunPreSaveValidationCore()
		{
		}

		public NotificationManager Notifications
		{
			get => fNotifications ?? (fNotifications = new NotificationManager());
		}
		NotificationManager fNotifications;

		#region Children

		protected IList<VBusinessObject> Children => fChildren ?? (fChildren = new List<VBusinessObject>());
		IList<VBusinessObject> fChildren;

		protected void RegisterChild(VBusinessObject bizo)
		{
			Children.Add(bizo);
		}

		#endregion

		#region HasChanges

		public bool HasChanges
		{
			get
			{
				return fHasChanges || Children.Any(child => child.HasChanges);
			}
			set
			{
				if (!SuspendSettingHasChanges && fHasChanges != value)
				{
					fHasChanges = value;
					OnHasChangesChanged(this, new HasChangesEventArgs { HasChanges = value });
				}
			}
		}
		bool fHasChanges;

		public bool SuspendSettingHasChanges { get; set; }

		protected internal virtual string GetSaveNameForXML()
		{
			return null;
		}

		internal string XmlLocation { get; set; }

		#endregion

		#region Events

		#region OnChanged

		public event EventHandler<HasChangesEventArgs> HasChangesChanged;

		void OnHasChangesChanged(object sender, HasChangesEventArgs e)
		{
			HasChangesChanged?.Invoke(this, e);
		}

		#endregion

		#region PropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			PropertyChanged?.Invoke(this, e);
		}

		#endregion

		#region LoadedFromXML

		internal event EventHandler<OnLoadedEventArgs> LoadedFromXML;

		public virtual void OnLoadedFromXML(OnLoadedEventArgs e)
		{
			LoadedFromXML?.Invoke(this, e);
		}

		#endregion

		#endregion
	}
}
