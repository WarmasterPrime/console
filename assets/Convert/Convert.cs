using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.assets.Convert
{
	internal class Convert
	{
		public static string ToString(string msg)
		{
			return "<str>"+msg+"</str>";
		}
		public static string ToString(int msg)
		{
			return "<num>"+msg.ToString()+"</num>";
		}
		public static string ToString(uint msg)
		{
			return "<num>"+msg.ToString()+"</num>";
		}
		public static string ToString(long msg)
		{
			return "<num>"+msg.ToString()+"</num>";
		}
		public static string ToString(byte msg)
		{
			return "<num>"+msg.ToString("X")+"</num>";
		}
		public static string ToString(float msg)
		{
			return "<num>"+msg.ToString()+"</num>";
		}
		public static string ToString(double msg)
		{
			return "<num>"+msg.ToString()+"</num>";
		}
		public static string ToString(char msg)
		{
			return "<str>"+msg.ToString()+"</str>";
		}
		public static string ToString(bool msg)
		{
			return msg ? "<bool>true</bool>" : "<bool>false</bool>";
		}
		public static string ToString(string[] msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Length)
			{
				if(i>0)
					buff+=",\n\t<str>"+msg[i]+"</str>";
				else
					buff+="\n\t<str>"+msg[i]+"</str>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(char[] msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Length)
			{
				if(i>0)
					buff+=",\n\t<str>"+msg[i]+"</str>";
				else
					buff+="\n\t<str>"+msg[i]+"</str>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<string> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<str>"+msg[i]+"</str>";
				else
					buff+="\n\t<str>"+msg[i]+"</str>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<char> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<str>"+msg[i]+"</str>";
				else
					buff+="\n\t<str>"+msg[i]+"</str>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<int> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<long> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<uint> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<double> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<float> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<byte> msg)
		{
			int i=0;
			string buff="\n[";
			while(i<msg.Count)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString("X")+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString("X")+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(List<bool> msg)
		{
			int i=0;
			string buff="\n[";
			string sel;
			while(i<msg.Count)
			{
				sel=msg[i] ? "true" : "false";
				if (i>0)
					buff+=",\n\t<bool>"+sel+"</bool>";
				else
					buff+="\n\t<bool>"+sel+"</bool>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(Dictionary<string,string> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(string key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<str>"+msg[key]+"</str>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<str>"+msg[key]+"</str>";
					i=true;
				}
			}
			return buff+"\n}";
		}
		public static string ToString(int[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(uint[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(long[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(byte[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString("X")+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString("X")+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(float[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(double[] msg)
		{
			string buff="\n[";
			int i=0;
			while(i<msg.Length)
			{
				if (i>0)
					buff+=",\n\t<num>"+msg[i].ToString()+"</num>";
				else
					buff+="\n\t<num>"+msg[i].ToString()+"</num>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(bool[] msg)
		{
			string buff="\n[";
			int i=0;
			string sel;
			while(i<msg.Length)
			{
				sel=msg[i] ? "true" : "false";
				if (i>0)
					buff+=",\n\t<bool>"+sel+"</bool>";
				else
					buff+="\n\t<bool>"+sel+"</bool>";
				i++;
			}
			return buff+"\n]";
		}
		public static string ToString(Dictionary<int,int> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,bool> msg)
		{
			string buff="\n{";
			bool i=false;
			string sel;
			foreach(var key in msg.Keys)
			{
				sel=msg[key] ? "true" : "false";
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<bool>"+sel+"</bool>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<bool>"+sel+"</bool>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,byte> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString("X")+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString("X")+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,double> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,float> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,uint> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,long> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,string> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key.ToString()+"</num>:<str>"+msg[key]+"</str>";
				else
				{
					buff+="\n\t<num>"+key.ToString()+"</num>:<str>"+msg[key]+"</str>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<int,char> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<num>"+key+"</num>:<str>"+msg[key]+"</str>";
				else
				{
					buff+="\n\t<num>"+key+"</num>:<str>"+msg[key]+"</str>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,int> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,uint> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,float> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,double> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,long> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString()+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,bool> msg)
		{
			string buff="\n{";
			bool i=false;
			string sel;
			foreach(var key in msg.Keys)
			{
				sel=msg[key] ? "true" : "false";
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<bool>"+msg[key].ToString()+"</bool>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<bool>"+msg[key].ToString()+"</bool>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,char> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<str>"+msg[key].ToString()+"</str>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<str>"+msg[key].ToString()+"</str>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,byte> msg)
		{
			string buff="\n{";
			bool i=false;
			foreach(var key in msg.Keys)
			{
				if(i)
					buff+=",\n\t<str>"+key+"</str>:<num>"+msg[key].ToString("X")+"</num>";
				else
				{
					buff+="\n\t<str>"+key+"</str>:<num>"+msg[key].ToString("X")+"</num>";
					i=true;
				}
			}
			return buff;
		}
		public static string ToString(Dictionary<string,object> msg)
		{
			string buff="\n{";
			bool i=false;
			var ty=msg.GetType().Name;
			string t=GetType(ty);
			foreach(var key in msg.Keys)
			{
				if (i)
					buff+=",\n\t<str>"+key+"</str>:<"+t+">"+msg[key].ToString()+"</"+t+">";
			}
			return buff;
		}
		public static string ToString(object msg)
		{
			string t=GetType(msg);
			return "<"+t+">"+msg.ToString()+"</"+t+">";
		}

		private static string GetType(object? q)
		{
			return GetType(q.GetType());
		}
		private static string GetType(Type? q)
		{
			return GetType(q.Name);
		}
		private static string GetType(string q)
		{
			q=q.ToLower();
			return q=="string"||q=="char" ? "str" : q=="bool" ? "bool" : q=="int"||q=="uint"||q=="double"||q=="float" ? "num" : q=="object" ? "obj" : q=="class" ? "class" : q=="method"||q=="function" ? "func" : q;
		}
	}
}
