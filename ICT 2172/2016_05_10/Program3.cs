using System;
	class Book
	{
		private string fTitle;
		private string fAuthor;
		private string fSubject;
		private string fDescription;
		
		public Book (string title,string author,string subj,string descr)
		{
			fTitle=title;
			fAuthor=author;
			fSubject=subj;
			fDescription=descr;
		}
		
		public Book()
		{}
		
		//Define an indexer
		public string this[string index]
		{
			get
			{
				if(index=="Title")
					return fTitle;
				if(index=="Author")
					return fAuthor;
				if(index=="Subject")
					return fSubject;
				if(index=="Description")
					return fDescription;
				return "Unknown";
			}
			set
			{
				if(index=="Title")
					fTitle=value;
				if(index=="Author")
					fAuthor=value;
				if(index=="Subject")
					fSubject=value;
				if(index=="Description")
					fDescription=value;
			}
		}
		
		public string this[int index]
		{
			get
			{
				if(index==1)
					return fTitle;
				if(index==2)
					return fAuthor;
				if(index==3)
					return fSubject;
				if(index==4)
					return fDescription;
				return "Unknown";
			}
			set
			{
				if(index==1)
					fTitle=value;
				if(index==2)
					fAuthor=value;
				if(index==3)
					fSubject=value;
				if(index==4)
					fDescription=value;
			}
		}
	}
	
	class Program3
	{
		static void Main(string [] args)
		{
			
			Book b=new Book("C# Black Book","Matt Telles","C# programming","A great book");
			Console.WriteLine("Book Title : {0} \nAuthor :{1} \nSubject : {2} \nDescription : {3}",b["Title"],b["Author"],b["Subject"],b["Description"]);
			Book b2=new Book();
			b2["Title"]="The Internet Programing";
			b2[2]="David Rich";
			b2["Subject"]="Internet programming";
			b2["Description"]="Internet Programing using PHP";
			Console.WriteLine("Book Title : {0}",b2[1]);
			Console.WriteLine("Book Title : {0} \nAuthor :{1} \nSubject : {2} \nDescription : {3}",b["title"],b["Author"],b["Subject"],b["Description"]);
		}
	}