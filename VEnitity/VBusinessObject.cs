using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace VEntityFramework.Data
{
	public abstract class VBusinessObject : INotifyPropertyChanged
	{
		#region Constructor

		public VBusinessObject(VBusinessObject parent) : this()
		{
			Parent = parent;
		}

		public VBusinessObject()
		{
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

		public VDataContext Context => VDataContext.Instance;

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
			get => fNotifications ??= new NotificationManager();
		}
		NotificationManager fNotifications;

		#endregion

		#region Abstract Members

		public abstract string BizoName { get; }

		#endregion

		#region Children

		protected IList<VBusinessObject> Children => fChildren ??= new List<VBusinessObject>();
		IList<VBusinessObject> fChildren;

		void RegisterChild(VBusinessObject bizo)
		{
			Children.Add(bizo);
			if (IsSettingHasChangesSuspended)
			{
				childHasChangesDisposables.Add(bizo.SuspendSettingHasChanges());
			}
		}

		#endregion

		#region Parent

		[VXML(false)]
		internal VBusinessObject Parent
		{
			get => fParent;
			set
			{
				if (fParent != value)
				{
					fParent = value;
					fParent?.RegisterChild(this);
				}
#if DEBUG
				else if (fParent != null)
				{
					throw new DeveloperException("Why are we adding a parent twice?");
				}
#endif

			}
		}
		VBusinessObject fParent;

#endregion

		#region HasChanges

		public virtual bool HasChanges
		{
			get
			{
				return fHasChanges || Children.Any(child => child.HasChanges);
			}
			set
			{
				if (!IsSettingHasChangesSuspended && fHasChanges != value)
				{
					fHasChanges = value;
					RefreshHasChanges();
				}
				if (value)
				{
					OnChangeMade();
				}
			}
		}

		protected virtual void OnChangeMade()
		{
		}

		bool fHasChanges;

		public IDisposable SuspendSettingHasChanges()
		{
			suspendSettingHasChangesIncrement++;
			childHasChangesDisposables = Children.Select(c => c.SuspendSettingHasChanges()).ToList();

			return new DisposableAction(() => {
				suspendSettingHasChangesIncrement--;

				foreach (var disposable in childHasChangesDisposables)
				{
					disposable.Dispose();
				}
			});
		}
		List<IDisposable> childHasChangesDisposables;

		public bool IsSettingHasChangesSuspended => suspendSettingHasChangesIncrement > 0;
		int suspendSettingHasChangesIncrement;

		void RefreshHasChanges()
		{
			OnPropertyChanged(new PropertyChangedEventArgs(nameof(HasChanges)));
			Parent?.RefreshHasChanges();
		}

		#endregion

		#region IsLoading

		public IDisposable StartLoading()
		{
			IsLoading = true;

			return new DisposableAction(() => {
				IsLoading = false;
			});
		}

		public bool IsLoading { get; private set; }

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
