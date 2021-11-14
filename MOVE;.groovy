using System;

namespace XiangQi{
    class chess:programme{
        int red = 0;
        int black = 1;
        void movePiece(int x1,int y1,int x2,int y2){
            map[x2,y2] = map[x1,y1];
	        map[x1,y1] = 0;
        }
        int moveRule(int x1,int y1,int x2,int y2,int player){
             //turn
             if(map[x2,y2]>0 && map[x2,y2]<10 && player==red||map[x2,y2]>10 && map[x2,y2]<20&&player==black)
	{
		return 0;
    }
        }
    //获取玩家需要移动的棋子位置和移动到的目标位置
    Console.Read（"int x1, int y1, int x2, int y2"）{
        Console.WriteLine("Enter the coordinates of the piece and the destination: ");
        Console.ReadLine("Target coordinates have the same color chess")
        	if((x1)<0||(x1)>ROWS||(y1)<0||(y1)>COLS||(x2)<0||(x2)>ROWS||(y2<0)||(y2)>COLS)
	{
		return 0;
	}
	else if((*x1)==(*x2)&&(*y1)==(*y2))
	{
		return 0;
	}
	return 1;
}
//检测输入坐标是否有棋子,是否是当前回合方的棋子
public static void chosechess(map[] chessboard){
    chess.chosen = ture;
    chosenX = Chess.x;
    chosenY = Chess.y;
    if （map[x1,y1] != con）

}
public void MoveTO(ChessPoint){
    //选择棋子于目标棋子不能是同一方的
    //检测选择棋子要走的坐标下是否有棋子
    if(map[])
   
    Chess  = 
}  
         

    }
}
