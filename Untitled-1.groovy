//将（x1,y1）的棋子移动到（x2,y2） 
void movePiece(int x1,int y1,int x2,int y2)
{
	map[x2][y2]=map[x1][y1];
	map[x1][y1]=white;
}

//获取玩家需要移动的棋子位置和移动到的目标位置
int getInput(int *x1,int *y1,int *x2,int *y2)
{
	Consle.write("\n输入棋子坐标和目的坐标（全为-1时表示查看当前棋谱）:\n");
	scanf("%d %d %d %d",x1,y1,x2,y2);
	if((*x1)<0||(*x1)>ROWS||(*y1)<0||(*y1)>COLS||(*x2)<0||(*x2)>ROWS||(*y2<0)||(*y2)>COLS)
	{
		return 0;
	}
	else if((*x1)==(*x2)&&(*y1)==(*y2))
	{
		return 0;
	}
	return 1;
} 

//判断是否已经结束游戏（-1：黑胜 0：还没结束 1：红胜） 
int isOver()
{
	int i,j;
	//没有將时红胜，没有帥时黑胜
	int haveShuai=0,haveJiang=0;
	for(i=0;i<ROWS;i++)
	{
		for(j=0;j<COLS;j++)
		{
			if(map[i][j]==shuai)
			{
				haveShuai=1;		
			}	
			else if(map[i][j]==Jiang)
			{
				haveJiang=1;
			}
		}	
	}	
	if(haveShuai==0)
	{
		return -1;
	}
	else if(haveJiang==0)
	{
		return 1;
	}
	else
	{
		return 0;
	}
} 

//输出赢家 
void displayWinner(int winner)
{
	if(winner==1)
	{
		printf("红胜！\n");
	}
	else if(winner==-1)
	{
		printf("黑胜！\n");
	}
}

//打印当前回合的玩家
void displayPlayer(int player)
{
	printf("=======");
	if(player==red)
	{
		printf("红方回合"); 
	}
	else if(player==black)
	{
		printf("黑方回合"); 	
	}
	printf("=======");	
} 

//交替到对方回合 
void exchangePlayer(int *player)
{
	if((*player)==red)
	{
		*player=black;
	}
	else if((*player)==black)
	{
		*player=red;
	}
}

//坐标（x1,y1）上的棋子是否能移动到（x2,y2）上 
int canMove(int x1,int y1,int x2,int y2,int player)
{
	//当（x2,y2）为己方棋子时，不可以
	if(map[x2][y2]>0&&map[x2][y2]<10&&player==red||map[x2][y2]>10&&player==black)
	{
		return 0;	
	} 
	int piece=map[x1][y1];
	int i,j;
	int start,end;
	int eye_x=-1,eye_y=-1;
	int count=0;
	switch(piece)
	{
