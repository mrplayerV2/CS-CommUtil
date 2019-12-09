using System;
using System.IO;
using System.Text;

public class CommUtil
{
	public static void WriteToFile(string strFileName, string strToWrite, char chFileMode, string strEncode)
	{
		Encoding encoding = Encoding.GetEncoding((strEncode == "") ? "UTF-8" : strEncode);
		using (StreamWriter streamWriter = new StreamWriter(File.Open(strFileName, (File.Exists(strFileName) && chFileMode == 'A') ? FileMode.Append : FileMode.Create), encoding))
		{
			streamWriter.WriteLine(strToWrite);
		}
	}

	public static bool isInteger(object objNum)
	{
		try
		{
			Convert.ToInt64(objNum);
			return true;
		}
		catch
		{
			return false;
		}
	}
}