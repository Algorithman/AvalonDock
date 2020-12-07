using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace TestApp
{
	public class TestBehavior : BehaviorBase<TextBox>
	{
		public TestBehavior()
		{
			Debug.WriteLine("CTOR");
		}

		protected override void OnAttached()
		{
			base.OnAttached();
			Debug.WriteLine("ATTACHED");
		}

		private void DetachMe(object sender, RoutedEventArgs e)
		{
			Debug.WriteLine("DETACHME");
		}

		protected override void OnDetaching()
		{
			
			base.OnDetaching();
		}

		protected override void OnSetup()
		{
			Debug.WriteLine("ATTACHING");
			base.OnSetup();
		}

		protected override void OnCleanup()
		{
			Debug.WriteLine("DETACHING");
			base.OnCleanup();
		}

		protected override void OnChanged()
		{
			Debug.WriteLine("CHANGING");
			base.OnChanged();
		}
	}
}