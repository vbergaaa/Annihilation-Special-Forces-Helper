using VEntityFramework;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class UnitsCollection : BusinessObjectList<VUnit>
	{
		public UnitsCollection(BusinessObject parent) : base(parent)
		{
		}

		VLoadout loadout => parent as VLoadout;

		public override void Add(VUnit item)
		{
			base.Add(item);
			loadout.OnUnitsUpdated();
		}

		public override void Insert(int index, VUnit item)
		{
			base.Insert(index, item);
			loadout.OnUnitsUpdated();
		}

		public override bool Remove(VUnit item)
		{
			var result = base.Remove(item);
			loadout.OnUnitsUpdated();
			return result;
		}

		public override void Clear()
		{
			base.Clear();
			loadout.OnUnitsUpdated();
		}
	}
}
