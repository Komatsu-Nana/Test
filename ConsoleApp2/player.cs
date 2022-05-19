using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    public  class player
    {
        public string playerName { get; set; }//玩家名称
        public int win { get; set; }//赢的次数
        public int pin { get; set; }//平局次数
        public int loe { get; set; }//输的次数
        public int counts { get; set; }//总次数

        public int sum => win + pin + loe;//游戏次数

        public int gamesum => win + pin - loe;//总得分
        public CQtype CQtype { get; set; }//出拳类型

        /// <summary>
        /// 玩家出拳
        /// </summary>
        public void zhonglei()
        {
            Console.WriteLine("请出拳");
           var CQ=(CQtype)int.Parse( Console.ReadLine())-1 ;
            switch (CQ)
            {
                case CQtype.shitou:
                  
                case CQtype.jiandao:
               
                case CQtype.bu:
                    CQtype = CQ;
                    break;
                default:
                    Console.WriteLine("出拳错误，请重新出拳");
                    break;
            }
        }
        /// <summary>
        /// 机器人出拳
        /// </summary>
        public void computer()
        {
            Console.WriteLine("电脑出拳");
            Random rand = new Random();
            CQtype = (CQtype) rand.Next(0,3);
        }
    }
    
}
