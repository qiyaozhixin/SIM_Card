using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System003
{
    public partial class Zhexiantu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double[] manqpfl = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; ;
            SqlConnection sqlcon = new SqlConnection("server=PC-201401242045;database=aspnetdb;uid=sa;pwd=123456;");//创建数据库连接对象
            if (sqlcon.State == ConnectionState.Closed)     //判断连接是否关闭
            {
                sqlcon.Open();                              //打开数据库连接
            }
            //创建SqlCommand对象
            SqlCommand sqlcmd = new SqlCommand("select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-03-05 00:00:00' and 销售时间 < '2018-03-12 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-03-12 00:00:00' and 销售时间 < '2018-03-19 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-03-19 00:00:00' and 销售时间 < '2018-03-26 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-03-26 00:00:00' and 销售时间 < '2018-04-02 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-04-02 00:00:00' and 销售时间 < '2018-04-09 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-04-09 00:00:00' and 销售时间 < '2018-04-16 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-04-16 00:00:00' and 销售时间 < '2018-04-23 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-04-23 00:00:00' and 销售时间 < '2018-04-30 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-04-30 00:00:00' and 销售时间 < '2018-05-07 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-05-07 00:00:00' and 销售时间 < '2018-05-14 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-05-14 00:00:00' and 销售时间 < '2018-05-21 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-05-21 00:00:00' and 销售时间 < '2018-05-28 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-05-28 00:00:00' and 销售时间 < '2018-06-04 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-06-04 00:00:00' and 销售时间 < '2018-06-11 00:00:00';select count(*) from aspnet_Xiaoshoutest where 销售时间 > '2018-06-11 00:00:00' and 销售时间 < '2018-06-18 00:00:00'", sqlcon);
            //使用ExecuteReader方法的返回值创建SqlDataReader对象
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[0] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[1] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[2] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[3] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[4] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[5] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[6] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[7] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[8] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[9] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[10] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[11] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[12] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            do
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        manqpfl[13] = Convert.ToDouble(sqldr[0]);
                    }
                }
            }
            while (sqldr.NextResult() == false);
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    manqpfl[14] = Convert.ToDouble(sqldr[0]);
                }
            }
            sqldr.Dispose();
            sqldr.Close();//关闭SqlDataReader对象
            sqlcon.Close();//关闭数据库连接





            //初始化数据

            double[] manqpfl0 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //double[] manqpfl = { 25, 30, 7, 14, 41, 8, 18, 22, 24, 13, 7, 46, 11, 39, 17 };
            //double[] manqpfl1 = { 72, 71, 71, 72, 71, 72, 71, 72, 71, 72, 71, 72, 71, 72, 71 };
            //double[] manqpfl2 = { 60, 61, 60, 61, 60, 61, 60, 61, 60, 61, 60, 61, 60, 61, 62 };
            int TotalMonths = 14;



            Bitmap image = new Bitmap(1000, 500);
            Graphics graphics = Graphics.FromImage(image);
            try
            {
                graphics.Clear(Color.White);
                Font font = new Font("Arial", 9, FontStyle.Regular);//坐标刻度所使用的字体
                Font font1 = new Font("宋体", 15, FontStyle.Regular);//图片标题所使用的字体
                Font font2 = new Font("宋体", 10, FontStyle.Regular);//注释信息所使用的字体
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Gray, Color.Gray, 1.2f, true);//绘制网格线的LinearGradientBrush
                LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Red, Color.Red, 1.2f, true);//注释信息的LinearGradientBrush
                LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Green, Color.Green, 1.2f, true);//注释信息的LinearGradientBrush
                LinearGradientBrush brush4 = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Brown, Color.Brown, 1.2f, true);//注释信息的LinearGradientBrush

                graphics.FillRectangle(Brushes.White, 0, 0, 1000, 1000);
                Brush brush1 = new SolidBrush(Color.Black);

                //判断是否有数据
                if (manqpfl.Length > 0)
                {
                    graphics.DrawString("员工每周销售电话卡数据折线图", font1, brush1, new PointF(1000 / 2 - 200, 30));//标注图片标题
                    //graphics.DrawString("商业险为红色折线", font2, brush2, new PointF(1000 / 2 + 200, 500));//标注注释信息
                    //graphics.DrawString("交强险为绿色折线", font2, brush3, new PointF(1000 / 2 + 200, 530));//标注注释信息
                    //graphics.DrawString("车 险为棕色折线", font2, brush4, new PointF(1000 / 2 + 200, 560));//标注注释信息
                }
                //画图片的边框线
                graphics.DrawRectangle(new Pen(Color.Black), 0, 0, image.Width - 1, image.Height - 1);

                //绘制Y轴
                int x = 60;
                Pen mypen1 = new Pen(Color.Black, 2);
                graphics.DrawLine(mypen1, x, 120, x, 458);
                //绘制网格纵线
                Pen mypen = new Pen(brush, 1);
                for (int i = 0; i < TotalMonths; i++)
                {
                    graphics.DrawLine(mypen, x, 120, x, 458);
                    x = x + 60;  //Y轴上每60像素为一个单位刻度
                }
                //绘制网格横线
                int y = 158;
                for (int i = 0; i < 5; i++)
                {
                    graphics.DrawLine(mypen, 60, y, 1000 - 15, y);
                    y = y + 60;  //X轴上每60像素为一个单位刻度
                }
                //绘制X轴
                graphics.DrawLine(mypen1, 60, y, 1000 - 15, y);

                //标注x轴文字
                x = 50;
                for (int i = 0; i < TotalMonths; i++)
                {
                    string month = manqpfl0[i].ToString();  //直接显示年月
                    graphics.DrawString(month.ToString(), font, Brushes.Red, x, 460); //设置文字内容及输出位置
                    x = x + 60;  //X轴上每60像素为一个单位刻度
                }
                //y轴文字
                String[] m = { " 50", " 40", " 30", " 20", " 10", " 0" };
                y = 150;
                for (int i = 0; i < 6; i++)
                {
                    graphics.DrawString(m[i].ToString(), font, Brushes.Red, 40, y); //设置文字内容及输出位置
                    y = y + 60; //Y轴上每60像素为一个单位刻度
                }

                int[] Count = new int[TotalMonths];
                int[] Count1 = new int[TotalMonths];
                int[] Count2 = new int[TotalMonths];
                for (int j = 0; j < TotalMonths; j++)
                {
                    Count[j] = Convert.ToInt32(manqpfl[j] * 360 / 60);//求数据点对坐标轴的相对位移
                    //Count1[j] = Convert.ToInt32(manqpfl1[j] * 360 / 60);
                    //Count2[j] = Convert.ToInt32(manqpfl2[j] * 360 / 60);
                }

                Point[] myPoint = caculatePoints(Count, TotalMonths);//求出数据点在屏幕上的绝对位置
                Point[] myPoint1 = caculatePoints(Count1, TotalMonths);
                Point[] myPoint2 = caculatePoints(Count2, TotalMonths);

                Pen mypen2 = new Pen(Color.Red, 2);//manqpfl折线为红色
                //Pen mypen3 = new Pen(Color.Green, 2);//manqpfl1折线为绿色
                //Pen mypen4 = new Pen(Color.Brown, 2);//manqpfl2折线为棕色

                graphics.DrawLines(mypen2, myPoint);  //绘制manqpfl折线
                //graphics.DrawLines(mypen3, myPoint1);  //绘制manqpfl1折线
                //graphics.DrawLines(mypen4, myPoint2);  //绘制manqpfl2折线

                //标注数据点的值
                for (int i = 0; i < TotalMonths; i++)
                {
                    graphics.DrawString(manqpfl[i].ToString(), font, Brushes.Blue, myPoint[i].X - 8, myPoint[i].Y - 15);
                    //graphics.DrawString(manqpfl1[i].ToString(), font, Brushes.Blue, myPoint1[i].X - 8, myPoint1[i].Y - 15);
                    //graphics.DrawString(manqpfl2[i].ToString(), font, Brushes.Blue, myPoint2[i].X - 8, myPoint2[i].Y - 15);
                }

                //输出Bitmap
                System.IO.MemoryStream MStream = new System.IO.MemoryStream();
                image.Save(MStream, System.Drawing.Imaging.ImageFormat.Gif);
                Response.ClearContent();
                Response.ContentType = "image/Gif";
                Response.BinaryWrite(MStream.ToArray());

            }
            finally
            {
                graphics.Dispose();
                image.Dispose();
            }
        }


        //计算折线中点的坐标
        protected Point[] caculatePoints(int[] Count, int TotalNumber)
        {
            Point[] myPoint = new Point[TotalNumber];
            for (int i = 0; i < TotalNumber; i++)
            {
                myPoint[i].X = 60 + i * 60; myPoint[i].Y = 458 - Count[i];
            }
            return myPoint;
        }
    }
}