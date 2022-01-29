using System;
namespace propertiesx
{
	class ProDemo
	{
		private string sname;
		private int sage;
		
		public string Name
		{
			get
			{
				return sname;
			}
			set
			{
				sname=value;
			}
		}
		
		public int Age
		{
			get
			{
				return sage;
			}
			set
			{
				if(value>18 && value<100)
					sage=value;
			}
		}
		
		public string Address
		{
			get;
			set;
		}
	}
}