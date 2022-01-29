using System;
namespace PropertiesEx
{
	class PropertiesExample2
	{
		private string sName;
		private int sAge;
		
		public string Name
		{
			get
			{
				return sName;
			}
			set
			{
				sName=value;
			}
		}
		
		public int Age
		{
			get
			{
				return sAge;
			}
			set
			{
				if(value>18 && value<70)
					sAge=value;
			}
		}
		
		public string Address
		{
			get;
			set;
		}
	}
}