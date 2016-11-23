using System;
using System.Threading.Tasks;

using UIKit;

namespace Wendy.iOS
{
	public partial class ViewController : UIViewController
	{
		
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			//另開執行緒執行
			Task.Run(() => {

				Task.Delay(2000); //UI延遲2秒

				InvokeOnMainThread(() => {

					PerformSegue("moveToLoginViewSegue", this); //切換到LoginView畫面
				
				});
			
			});


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}


	}
}
