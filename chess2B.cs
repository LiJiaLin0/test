using System;
namespace XiangQi{
    class chess:borad{
        int red=0;
        int black=1;
void movePiece(int x1,int y1,int x2,int y2)
{
	map[x2,y2] = map[x1,y1];
	map[x1,y1] = 0;
}
int moveRule(int x1,int y1,int x2,int y2,int player){
    //turn
if(map[x2,y2]>0 && map[x2,y2]<10 && player==red||map[x2,y2]>10 && map[x2,y2]<20&&player==black)
	{
		return 0;	
	} 
	int piece=map[x1,y1];
	int i,j;
	int start,end;
	int resist_x=-1,resist__y=-1;
	int count=0;
    //chess rule
	
    switch(piece)
	{    
        //CAR 车
		case 车:
		case 車:
           if(x1==x2){
            start=y1;
            end=y2;
            i=x1;
            if(y1<y2){
             start=y2;
             end=y1;
            }
            for(j=start+1;j<end;j++){
                if(map[i,j]!=0){
                    return 0;
                }
            }
           }
           else if(y1==y2){
               start=x1;
               end=x2;
               j=y1;
               if(x1<x2){
                   start=x2;
                   end=x1;
               }
               for(i=start+1;i<end;i++){
                   if(map[i,j]==0){
                       return 0;
                   }
               }
           }
           else{
               return 0;
           }
        break;
       
       
        //horse 马
		case 马:
		case 馬:
            if(System.Math.Abs(x1-x2)==1&&y1-y2==2){
              resist__x=x1;
              resist_y=y1-1;
            }
            else if(System.Math.Abs(x1-x2)==1&&y1-y2==-2){
               resist__x=x1;
               resist_y=y1+1;
            }
            else if(System.Math.Abs(y1-y2)==1&&x1-x2==2){
               resist_y=y1;
               resist_x=x1-1;
            }
            else if(System.Math.Abs(y1-y2)==1&&x1-x2==-2){
               resist_y=y1;
               resist_x=x1+1;
            }
            if(map[resist_x,resist_y]!=0){
                return 0;
            }
            else {
                return 0;
            }
			break;
       
       
        //prime minister 相 象
		case 相:
		case 象:
			//prime minister cross the median line
			if(player==red&&x2<5||player==black&&x2>4){
                return 0;
            } else if(System.Math.Abs(y1-y2)==2&&System.Math.Abs(x1-x2)==2){
               resist_y=(y1+y2)/2;
               resist_x=(x1+x2)/2;
            
            if(map[resist_x,resist_y]!=0){
                return 0;
            }
            }
            else {
                return 0;
            }
			break;
        
        
        //official 士 仕
		case 士:
		case 仕:
			if(player==red&&(x2<7||y2<3||y2>5)||player==black&&(x2>2||y2<3||y2>5)){
                return 0;
            }
            else if(System.Math.Abs(x1-x2)!=1||System.Math.Abs(y1-y2)!=1){
                return 0;
            }
			break;
        
        
        //princes 帅 将
		case 帅:
		case 将:
			//When two generals are in the same column and no other pieces are in the same column
            if((player==red&&x2<3||player==black&&x2>7)&&y1==y2){
                start=x1;
                end=x2;
                j=y1;
                if(x1<x2){
                    start=x2;
                    end=x1;
                }
                for(i=start+1;i<end;i++){
                    if(map[i,j]!=0){
                        return 0;
                    }
                }
            }
			if(player==red&&(x2<7||y2<3||y2>5)||player==black&&(x2>2||y2<3||y2>5)){
                return 0;
            }
             else if(System.Math.Abs(x1-x2)==1||System.Math.Abs(y1-y2)==1){
                return 0;
            }
			break;
        
        
        //cannon 炮 砲
		case 炮:
		case 砲:
			if(x1==x2){
                start=y1;
				end=y2;
				i=x1;
				if(y1>y2)
				{
					start=y2;
					end=y1;
				}
                for(j=start+1;j<end;j++){
                    if(map[i,j]!=0){
                    count++;}
                }
                if(count>1){
                    return 0;
                }else if(count==1){
                    if(map[x2,y2]>10&&player==red||map[x2,y2]>0&&map[x2,y2]<10&&player==black)
					{
						return 1;
					}
					else
					{
						return 0;
					}
                }
            }
            else if(y1==y2){
                start=x1;
				end=x2;
				j=y1;
				if(x1>x2)
				{
					start=x2;
					end=x1;
				}
                for(i=start+1;i<end;i++){
                    if(map[i,j]!=0){
                    count++;}
                }
                if(count>1){
                    return 0;
                }else if(count==1){
                    if(map[x2,y2]>10&&player==red||map[x2,y2]>0&&map[x2,y2]<10&&player==black)
					{
						return 1;
					}
					else
					{
						return 0;
					}
                }
            }
            else
			{
				return 0;
			}
			break;
        
        
        //soldiers 卒 兵
		case 兵:
		case 卒:
        
        //Move left and right before crossing the center line
        if(player==red && x2>=5 && System.Math.Abs(y1-y2) ==1 || player == black && x2 <= 4 && System.Math.Abs(y1-y2) == 1){
            return 0;
        }
        
        //It's not one square in the vertical direction
        else if(System.Math.Abs(y1-y2)+System.Math.Abs(x1-x2)!=1){
            return 0;
        }
        
        //Walk back
        
        else if(player==red&&(x1-x2)==-1||player==red&&(x1-x2)==1){
            return 0;
        }
			
			break;
	}
	return 1;
} 

}

    }
