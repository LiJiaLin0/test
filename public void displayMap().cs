using System;
namespace XiangQi{
public void displayMap()
{
	int i,j,k;
	Console.Write(" ");
	for(k=0;k<COLS;k++)
	{
		Console.Write(" "+k);
	}
	Console.WriteConsole.Write("\n");
	for(i=0;i<ROWS;i++)
	{
		Console.Write(i+" ");
		for(j=0;j<COLS;j++)
		{
			if(map[i,j]==0)
			{
				
				Console.Write("  ");
			}
			else
			{
				switch(map[i,j])
				{
					case 1:
						Console.Write("車");
						break;
					case 11:
						Console.Write("车");
						break;
					case 2:
						Console.Write("馬");
						break;
					case 12:
						Console.Write("马");
						break;
					case 3:
						Console.Write("相");
						break;
					case 13:
						Console.Write("象");
						break;
					case 4:
						Console.Write("仕");
						break;
					case 14:
						Console.Write("士");
						break;
					case 5:
						Console.Write("帥");
						break;
					case 15:
						Console.Write("將");
						break;
					case 6:
						Console.Write("炮");
						break;
					case 16:
						Console.Write("砲");
						break;
					case 7:
						Console.Write("兵");
						break;
					case 17:
						Console.Write("卒");
						break;
				}	
			}
		}	
		Console.Write("\n");