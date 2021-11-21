using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VEntityFramework.Model;

namespace VEntityFramework.Data
{
	public abstract class BusinessObject : INotifyPropertyChanged, IXmlObject
	{
		#region Constructor

		public BusinessObject(BusinessObject parent)
		{
			Parent = parent;
			SetDefaultValues();
		}

		public BusinessObject()
		{
			SetDefaultValues();
		}

		#endregion

		#region SetDefaultValues

		void SetDefaultValues()
		{
			using (SuspendSettingHasChanges())
			{
				IsSettingDefaultValues = true;
				SetDefaultValuesCore();
				IsSettingDefaultValues = false;
			}
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
			BizoSaved?.Invoke(this, new EventArgs());
		}

		public event EventHandler BizoSaved;

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

		protected IList<BusinessObject> Children => fChildren ??= new List<BusinessObject>();
		IList<BusinessObject> fChildren;

		void RegisterChild(BusinessObject bizo)
		{
			Children.Add(bizo);
			if (IsSettingHasChangesSuspended)
			{
				childHasChangesDisposables.Add(bizo.SuspendSettingHasChanges());
			}
		}

		public void DeregisterChild(BusinessObject bizo)
		{
			if (Children.Contains(bizo))
			{
				Children.Remove(bizo);
			}
		}

		#endregion

		#region Parent

		[VXML(false)]
		internal BusinessObject Parent
		{
			get => fParent;
			set
			{
				if (fParent != value)
				{
					fParent = value;
					fParent?.RegisterChild(this);
				}
				else
				{
					ErrorReporter.ReportDebug(fParent != null, "Why are we adding a parent twice?");
				}
			}
		}
		BusinessObject fParent;

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

			return new DisposableAction(() =>
			{
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
			OnPropertyChanged(nameof(HasChanges));
			Parent?.RefreshHasChanges();
		}

		#endregion

		#region IsLoading

		public IDisposable StartLoading()
		{
			IsLoading = true;

			return new DisposableAction(() =>
			{
				IsLoading = false;
				OnLoaded();
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

		protected virtual void OnPropertyChanged(string bindingName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(bindingName));
		}

		#endregion

		#region LoadedFromXML

		internal event EventHandler<OnLoadedEventArgs> LoadedFromXML;

		protected internal virtual void OnLoadedFromXML(OnLoadedEventArgs e)
		{
			// this is the on loaded event for a top level bizo, we should probably refactor this
			LoadedFromXML?.Invoke(this, e);
		}

		public virtual void OnLoaded() { }

		#endregion

		#endregion
	}
}
