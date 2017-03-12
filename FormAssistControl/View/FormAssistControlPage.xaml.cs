using FormsAssistControl;
using Xamarin.Forms;

namespace FormAssistControl
{
	public partial class FormAssistControlPage : ContentPage
	{
		public FormAssistControlPage()
		{
			InitializeComponent();

			// providing binding context for my data bindings on the xaml
			this.BindingContext = new StudentDirectoryVM();
			lvStudents.ItemSelected += LvStudents_ItemSelected; 
		}

		// event when an Item on the list is selected
		void LvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Student selectedStudent = (Student)e.SelectedItem;
			if (selectedStudent == null)
				return;
			Navigation.PushAsync(new StudentDetailPage(selectedStudent));
			lvStudents.SelectedItem = null;
		}
	}
}
