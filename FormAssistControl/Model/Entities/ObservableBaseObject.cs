using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormAssistControl
{
	public class ObservableBaseObject:INotifyPropertyChanged
	{
		public ObservableBaseObject()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate {
			
		};

		// get the name of the prpoperty tgat invoked
		public void OnPropertyChanged([CallerMemberName] string name="")
		{
			if (PropertyChanged == null)
			{
				return;
			}

			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
