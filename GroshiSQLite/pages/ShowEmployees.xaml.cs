using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GroshiSQLite
{
	public partial class ShowEmployees : ContentPage
	{
		public ShowEmployees()
		{
			InitializeComponent();
			//Employee e = new Employee();
			var vList = App.DAUtil.GetAllEmployees();
			List<string> a = new List<string>();
			List<long> id = new List<long>();
			for(int i = 0; i < vList.Count;i++)
			{
				id.Add(vList[i].EmpId);
				a.Add(vList[i].EmpName);
			}

			EmployeeView1.ItemsSource = id;
			EmployeeView2.ItemsSource = a;
			id = null;
			a = null;
			vList = null;
		}
	}
}
