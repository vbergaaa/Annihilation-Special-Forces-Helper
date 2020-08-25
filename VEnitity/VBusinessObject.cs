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
		#region Constructor

		public VBusinessObject()
		{
			Context = new VDataContext();
			SetDefaultValues();
		}

		#endregion

		#region SetDefaultValues

		void SetDefaultValues()
		{
			IsSettingDefaultValues = true;
			SetDefaultValuesCore();
			IsSettingDefaultValues = false;
		}

		protected virtual void SetDefaultValuesCore()
		{
		}

		protected bool IsSettingDefaultValues { get; set; }

		#endregion

		#region DataContext

		public VDataContext Context { get; set; }

		#endregion

		#region Saving

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

		public void RunPreSaveValidation()
		{
			Notifications.Clear();
			RunPreSaveValidationCore();
		}

		protected virtual void RunPreSaveValidationCore()
		{
		}

		public bool ExistsInXML { get; set; }

		internal string XmlLocation { get; set; }

		protected internal virtual string GetSaveNameForXML()
		{
			return null;
		}

		#endregion

		#region Notifications

		public NotificationManager Notifications
		{
			get => fNotifications ?? (fNotifications = new NotificationManager());
		}
		NotificationManager fNotifications;

		#endregion

		#region Delete

		public void Delete()
		{
			Context.DeleteXML(this);
		}

		#endregion

		#region Abstract Members

		public abstract string BizoName { get; }

		#endregion

		#region Children

		protected IList<VBusinessObject> Children => fChildren ?? (fChildren = new List<VBusinessObject>());
		IList<VBusinessObject> fChildren;

		protected void RegisterChild(VBusinessObject bizo)
		{
			Children.Add(bizo);
			bizo.Parent = this;
		}

		#endregion

		#region Parent

		[VXML(false)]
		internal VBusinessObject Parent { get; set; }

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
					RefreshHasChanges();
				}
			}
		}
		bool fHasChanges;

		public bool SuspendSettingHasChanges { get; set; }

		void RefreshHasChanges()
		{
			OnPropertyChanged(new PropertyChangedEventArgs(nameof(HasChanges)));
			Parent?.RefreshHasChanges();
		}

		#endregion

		#region Events

		#region PropertyChanged

		public void RefreshPropertyBinding(string property)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}

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
