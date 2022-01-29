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
			Console.WriteLine("#{0},{1}",this.no1,this.no2);
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
			Console.WriteLine("#{0},{1}",this.no1,this.no2);
		}
  }
  class StuctAppExample
  {
	public static void Main()
	{
		Console.WriteLine("#***********************************************");
		StructApp sa=new StructApp(23,21);
		Console.WriteLine("*After object has been created for StructApp   *");
		sa.ShowValues();
		ModifyStructValues(sa);
		sa.ShowValues();
		Console.WriteLine("#**********************************************#");
		ClassApp ca=new ClassApp(23,21);
		Console.WriteLine("#After object has been created for ClassApp    #");
		ca.ShowValues();
		ModifyClassValues(ca);
		ca.ShowValues();
		Console.WriteLine("#**********************************************#");
	}
	private static void ModifyClassValues(ClassApp ca)
	{
		ca.no1+=100;
		ca.no2+=100;
		Console.WriteLine("#Within ModifyClassValue: {0},{1}#",ca.no1,ca.no2);
	}
	private static void ModifyStructValues(StructApp sa)
	{
		sa.no1+=100;
		sa.no2+=100;
		Console.WriteLine("#Within ModifyStructValue: {0},{1}#",sa.no1,sa.no2);
	}
  }
}