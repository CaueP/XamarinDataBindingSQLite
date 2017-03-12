using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FormsAssistControl;
using Xamarin.Forms;

namespace FormAssistControl
{
	// ViewModel that will load students into student`s collection
	public class SudentDirectoryVM:ObservableBaseObject
	{
		public ObservableCollection<Student> students { get; set; }

		bool isBusy = false;
		public bool IsBusy
		{ 
			get { return isBusy; }
			set { isBusy = value; OnPropertyChanged();}
		}

		public Command LoadDirectoryCommand
		{
			get;
			set;
		}

		public SudentDirectoryVM()
		{
			students = new ObservableCollection<FormsAssistControl.Student>();
			IsBusy = false;
			LoadDirectoryCommand = new Command((obj) => LoadDirectory());
		}

		async void LoadDirectory()
		{
			if (!IsBusy) {
				IsBusy = true;

				// simulate external data reading
				await Task.Delay(3000);

				var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();

				foreach (var student in loadedDirectory.Students) 
				{
					students.Add(student);
				}

				IsBusy = false;
			}
		}
	}
}
