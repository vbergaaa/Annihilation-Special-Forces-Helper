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
		}

		public VDataContext Context { get; set; }

		public abstract string BizoName { get; }

		public bool Save()
		{
			Context.SaveAsXML(this, GetExistingXMLFileName);
			UpdateExistingXMLName();
			return true;
		}

		public void Delete()
		{
			Context.DeleteXML(this, GetExistingXMLFileName);
		}

		protected virtual void UpdateExistingXMLName() { }

		protected virtual string GetExistingXMLFileName => null;

		#region Children

		protected IEnumerable<VBusinessObject> Children
		{
			get
			{
				if (fChildren == null)
				{
					fChildren = GetType()
						.GetProperties()
						.Where(prop => prop.IsBusinessObject())
						.Select(prop => prop.GetValue(this))
						.Where(child => child != null)
						.Cast<VBusinessObject>();
				}
				return fChildren;
			}
		}
		IEnumerable<VBusinessObject> fChildren;

		#endregion

		#region HasChanges

		public void CascadeHasChanges()
		{
			if (!fHasCascadedHasChanges)
			{
				foreach (var child in Children)
				{
					child.HasChangesChanged += OnHasChangesChanged;
					child.CascadeHasChanges();
				}
			}
		}
		bool fHasCascadedHasChanges;

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

		internal bool SuspendSettingHasChanges { get; set; }

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
