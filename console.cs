using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;

namespace console
{
	public class console
	{
		public static bool Enabled = true;
		public static int Count = 0;
		public static List<string> Buffer = new();
		public static byte Mode = ConsoleSourcePrincipal.Event;
		private static readonly string Log_Pre = "[LOG]:\t\t";
		private static readonly string Warn_Pre = "[WARN]:\t\t";
		private static readonly string Error_Pre = "[ERROR]:\t\t";
		private static readonly string Info_Pre = "[INFO]:\t\t";
		private static readonly string Success_Pre = "[SUCCESS]:\t\t";
		private static object? _Source;

		public static object Source
		{
			get
			{
				return _Source;
			}
			set
			{
				if (value!=null)
					_Source=value;
			}
		}

		public static void Log(object? msg)
		{
			Output(Convert.ToString(msg));
		}

		public static void Warn(object? msg)
		{
			Output(Convert.ToString(msg));
		}

		public static void Error(object? msg)
		{
			Output(Convert.ToString(msg));
		}

		public static void Info(object? msg)
		{
			Output(Convert.ToString(msg));
		}

		public static void Success(object? msg)
		{
			Output(Convert.ToString(msg));
		}

		private static void Output(string msg)
		{
			if(Enabled)
			{
				if(Mode==ConsoleSourcePrincipal.Console)
					ConsoleOut(msg);
				else if (Mode==ConsoleSourcePrincipal.Event)
					EventOut(msg);
				else
					NormOut(msg);

			}
		}

		private static void NormOut(string q)
		{
			string m = GetMethod();
			string pre = Error_Pre;
			if(m!=null)
				pre=m=="log" ? Log_Pre : m=="warn" ? Warn_Pre : m=="info" ? Info_Pre : m=="success" ? Success_Pre : Error_Pre;
			try
			{
				string t=Source.GetType().Name.ToLower();
				if(t=="label"||t=="groupbox"||t=="panel")
				{
#pragma warning disable CS1061
					//Source.Text+=""+q+"\n";
#pragma warning restore CS1061
				}
			}
			catch(Exception e)
			{

			}
			q=Parse(q);
		}

		private static void EventOut(string q)
		{
			string m = GetMethod();
			string pre = Error_Pre;
			int id=0;
			EventLogEntryType t=EventLogEntryType.Information;
			if(m!=null)
			{
				pre=m=="log" ? Log_Pre : m=="warn" ? Warn_Pre : m=="info" ? Info_Pre : m=="success" ? Success_Pre : Error_Pre;
				id=m=="warn" ? 1 : m=="error" ? 8194 : 16384;
				t=m=="warn" ? EventLogEntryType.Warning : m=="error" ? EventLogEntryType.Error : EventLogEntryType.Information;
			}
#pragma warning disable CA1416 // Validate platform compatibility
			using(EventLog con = new("Application",".","Application"))
			{
				con.WriteEntry(Parse(q),t,id);
				con.Close();
			}
#pragma warning restore CA1416 // Validate platform compatibility
		}

		private static void ConsoleOut(string q)
		{
			string m = GetMethod();
			string pre = Error_Pre;
			if(m!=null)
				pre=m=="log" ? Log_Pre : m=="warn" ? Warn_Pre : m=="info" ? Info_Pre : m=="success" ? Success_Pre : Error_Pre;
			CColor("log");
			Console.Write("\n[");
			CColor("num");
			Console.Write(GetTime());
			CColor("log");
			Console.Write("]");
			CColor(m);
			Console.Write(pre);
			CProcess(q);
			CColor("log");
			Console.Write("\n\t\t"+GetCallingFunction()+"\n");
		}

		private static string Parse(string q)
		{
			string r="<([\\/]*)(str|bool|num|null)>";
			if(Regex.IsMatch(q,r))
			{
				q=Regex.Replace(q,r,"");
			}
			return q;
		}

		private static void CProcess(string q)
		{
			string r="<([\\/]*)(str|bool|num|null)>";
			if(Regex.IsMatch(q,r))
			{
				int i=0;
				var list=Regex.Matches(q,r);
				while(i<list.Count)
				{
					if(list[i].Captures.Count>2)
					{
						CColor(list[i].Captures[2].Value);
						if(list[i].Captures[2].Value=="str")
							Console.Write("\"");
					} else {
						if(list[i].Captures[1].Value=="str")
							Console.Write("\"");
						CColor("log");
					}
					i++;
				}
			}
		}

		private static void CColor(string m)
		{
			Console.ForegroundColor=m=="log" ? ConsoleColor.White : m=="warn" ? ConsoleColor.Yellow : m=="info" ? ConsoleColor.Cyan : m=="success" ? ConsoleColor.Green : m=="num" ? ConsoleColor.Magenta : m=="str" ? ConsoleColor.Gray : m=="bool" ? ConsoleColor.DarkMagenta : ConsoleColor.Red;
		}

		private static string GetTime()
		{
			DateTime dt=new(DateTime.Now.Ticks);
			return dt.ToString("MM-dd-yyyy | hh:mm:ss tt");
		}

		private static string GetMethod()
		{
			string? res=null;
			StackTrace s=new();
			if(s.FrameCount>1)
				res=s.GetFrame(2).GetMethod().Name.ToLower();
			return res;
		}
		private static string GetCallingFunction()
		{
			string res="";
			StackTrace s=new();
			int i=s.FrameCount-1;
			if (i>8)
				i=7;
			int lim=i;
			while(i>3)
			{
				if (i<lim)
					res+="->"+s.GetFrame(i).GetMethod().Name+"()";
				else
					res+=s.GetFrame(i).GetMethod().Name+"()";
				i--;
			}
			return res;
		}
	}
}