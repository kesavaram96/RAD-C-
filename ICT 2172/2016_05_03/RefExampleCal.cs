using System;
class RefExampleCal
{
	static void GetCalculations(ref int add,ref int sub,ref double div,ref int mul,int a,int b)
	{
		add=a+b;
		sub=a-b;
		div=a/(double)b;
		mul=a*b;
	}
	
	static void Main()
	{
		int myadd=0,mysub=0,mymul=0; //must be initalize
		double mydiv=0;
		int x=25,y=12;
		GetCalculations(ref myadd,ref mysub,ref mydiv,ref mymul,x,y);
		Console.WriteLine("After calling GetCalculations\nAddition = {0} \nSubstraction = {1} \nDivision = {2} \nMultiplication = {3}",myadd,mysub,mydiv,mymul);
	}
}