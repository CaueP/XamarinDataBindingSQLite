using System;
using System.Collections.Generic;
using FormsAssistControl;
using Xamarin.Forms;

namespace FormAssistControl
{
	public partial class StudentDetailPage : ContentPage
	{
		public StudentDetailPage(Student selectedStudent)
		{
			InitializeComponent();

			//setting binding context
			this.BindingContext = selectedStudent;
		}
	}
}
