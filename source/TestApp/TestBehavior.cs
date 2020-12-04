using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace TestApp
{
	public class TestBehavior : Behavior<TextBox>
	{
		public TestBehavior()
		{
			Debug.WriteLine("CTOR");
		}

		protected override void OnAttached()
		{
			base.OnAttached();
			AssociatedObject.Unloaded += DetachMe;
			Debug.WriteLine("ATTACHED");
		}

		private void DetachMe(object sender, RoutedEventArgs e)
		{
			Debug.WriteLine("DETACHME");
			Detach();
		}

		protected override void OnDetaching()
		{
			AssociatedObject.Unloaded -= DetachMe;
			Debug.WriteLine("DETACHING");
			base.OnDetaching();
		}
	}
}