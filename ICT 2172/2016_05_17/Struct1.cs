using System;
namespace StructNClass
{
	struct StructApp
	{
		public int no1,no2;
		
		public StructApp(int n1,int n2)
		{
			this.no1=n1;
			this.no2=n2;
		}
		
		public void ShowValues()
		{
			Console.WriteLine("{0},{1}",this.no1,this.no2);
		}	
	}
	
	class ClassApp
	{
		public int no1,no2;
		
		public ClassApp(int n1,int n2)
		{
			this.no1=n1;
			this.no2=n2;
		}
		
		public void ShowValues()
		{
			Console.WriteLine("{0},{1}",this.no1,this.no2);
		}	
	}
	
	class StructAppExample
	{
		public static void Main()
		{
			StructApp sa=new StructApp(10,20);
			Console.WriteLine("After Object for structure created : ");
			sa.ShowValues();
			ModifyStructValues(sa);
			Console.WriteLine("After ModifyStructValues method Invoked : ");
			sa.ShowValues();
			
			
			Console.WriteLine("......................................");
			
			ClassApp ca=new ClassApp(10,20);
			Console.WriteLine("After Object for class created : ");
			ca.ShowValues();
			ModifyClassValues(ca);
			Console.WriteLine("After ModifyClassValues method Invoked : ");
			ca.ShowValues();
		}
		
		private static void ModifyStructValues(StructApp sa) //struct is value type
		{
			sa.no1+=100;
			sa.no2+=100;
			Console.WriteLine("Within ModifyStructValues : {0},{1}",sa.no1,sa.no2);
		}
		
		private static void ModifyClassValues(ClassApp ca) //class is reference type
		{
			ca.no1+=100;
			ca.no2+=100;
			Console.WriteLine("Within ModifyClassValues : {0},{1}",ca.no1,ca.no2);
		}
	}
}






