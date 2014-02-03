using System;

namespace MvvmCrossViewModelInitialization
{
	public class ComplexObjectType
	{
		public string Foo { get; set; }
		public NestedObjectType Child {
			get;
			set;
		}
	}

	public class NestedObjectType
	{
		public string Foobar {
			get;
			set;
		}
	}
}

