using Chain.IDAL;
using Chain.Model;
using System;
using System.Data;

namespace Chain.BLL
{
	public class MemSign
	{
		private readonly Chain.IDAL.MemSign dal = new Chain.IDAL.MemSign();

		public int Add(Chain.Model.MemSign model)
		{
			return this.dal.Add(model);
		}

		public bool Delete(int MoneyID)
		{
			return this.dal.Delete(MoneyID);
		}

		public Chain.Model.MemSign GetModel(int MoneyID)
		{
			return this.dal.GetModel(MoneyID);
		}

		public DataSet GetList(int Top, string strWhere, string filedOrder)
		{
			return this.dal.GetList(Top, strWhere, filedOrder);
		}

		public DataSet GetList(string strWhere)
		{
			return this.dal.GetList(strWhere);
		}

		public DataSet GetListSP(int PageSize, int PageIndex, out int resCount, params string[] strWhere)
		{
			return this.dal.GetListSP(PageSize, PageIndex, out resCount, strWhere);
		}

		public DataSet GetListSP(bool isasc, string order, int PageSize, int PageIndex, out int resCount, params string[] strWhere)
		{
			return this.dal.GetListSP(isasc, order, PageSize, PageIndex, out resCount, strWhere);
		}

		public int GetRecordCount(string strWhere)
		{
			return this.dal.GetRecordCount(strWhere);
		}

		public decimal GetMoneySum(string strWhere)
		{
			return this.dal.GetMoneySum(strWhere);
		}
	}
}
