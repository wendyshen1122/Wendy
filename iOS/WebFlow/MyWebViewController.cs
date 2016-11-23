using System;

using UIKit;

namespace Wendy.iOS
{
	public partial class MyWebViewController : UIViewController
	{
		public MyWebViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			//註冊事件
			//Observe : IOC觀察者模式：做完某事後將控制權交還
			UIKeyboard.Notifications.ObserveWillChangeFrame((sender, e) =>
			{

				var beginRect = e.FrameBegin;
				var endRect = e.FrameEnd;

				Console.WriteLine($"ObserveWillChangeFrame endRect:{endRect.Height}");

				//匿名委派
				InvokeOnMainThread(() =>
				{

					UIView.Animate(1, () =>
					{
						btnGoBottomConstraint.Constant = endRect.Height + 5;;
						this.View.LayoutIfNeeded();
					});

				});
			});

			this.NavigationController.PopViewController(true);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


	}
}

