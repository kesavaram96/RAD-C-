using System;
namespace PropertiesEx
{
	class PropertiesExample
	{
		private string sName;
		private int sAge;
		
		public void setName(string name)
		{
			sName=name;
		}
		
		public void setAge(int age)
		{
			sAge=age;
		}
		
		public string getName()
		{
			return sName;
		}
		
		public int getAge()
		{
			return sAge;
		}
	}
}