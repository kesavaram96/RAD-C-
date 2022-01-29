using System;
//using propertiesx;
class ProDemoApp
{
	propertiesx.ProDemo pd=new propertiesx.ProDemo();
	pd.Name="jack";
	pd.Age=25;
	Console.WriteLine("Name : "+pd.Name);
	Console.WriteLine("Age : "+pd.Age);
	pd.Address="Jaffna";
	Console.WriteLine("Address : "+pd.Address);
}