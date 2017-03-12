using System;
using System.Collections.ObjectModel;
using FormAssistControl;

namespace FormsAssistControl
{
	public class StudentDirectory:ObservableBaseObject
	{
		private ObservableCollection<Student> students = new ObservableCollection<Student>();

		public ObservableCollection<Student> Students
		{
			get { return students; }
			set { students = value; OnPropertyChanged();}
		}
	}
}