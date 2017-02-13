using System;
using Xamarin.Forms;

namespace GroshiSQLite
{
	public partial class GroshiSQLitePage : ContentPage
	{
		public GroshiSQLitePage()
		{
			InitializeComponent();
		}

		public void saveData( object sender,EventArgs args)
		{
			//Navigation.PushAsync(new ShowEmployees());
			var vEmployee = new Employee()
			{
				EmpName = name.Text
				//Department = txtDepartment.Text,
				//Designation = txtDesign.Text,
				//Qualification = txtQualification.Text
			};
			App.DAUtil.SaveEmployee(vEmployee);
			DisplayAlert("alert", "data Save successfully", "ok");
			name.Text = null;
			//Navigation.PushAsync(new ManageEmployee());
		}
		public void showData(object sender, EventArgs args)
		{
			
			Navigation.PushAsync(new ShowEmployees());
		}
		public void deleteData(object sender, EventArgs args)
		{
			var vEmployee = new Employee()
			{
				EmpName = name.Text
				//Department = txtDepartment.Text,
				//Designation = txtDesign.Text,
				//Qualification = txtQualification.Text

			};
			App.DAUtil.DeleteEmployee(vEmployee);
			//App.DAUtil.DeleteEmployee();
			name.Text = null;
			DisplayAlert("alert", "data erased successfully", "ok");

		}

	}
}
