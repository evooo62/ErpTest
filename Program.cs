using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TableOne firstTable = new TableOne()
            {
                KayıtNo = 1,
                StartDateTime = DateTime.Now.AddHours(-12),
                FinishDateTime = DateTime.Now.AddHours(-11),
                Statu = "ÜRETİM",
                Description = "A"
            };
            TableOne firstTablee = new TableOne()
            {
                KayıtNo = 2,
                StartDateTime = DateTime.Now.AddHours(-10),
                FinishDateTime = DateTime.Now.AddHours(-9),
                Statu = "ÜRETİM",
                Description = "B"
            };
            TableOne firstTableee = new TableOne()
            {
                KayıtNo = 3,
                StartDateTime = DateTime.Now.AddHours(-7),
                FinishDateTime = DateTime.Now.AddHours(-4),
                Statu = "ÜRETİM",
                Description = "C"
            };
            TableOne firstTableeee = new TableOne()
            {
                KayıtNo = 4,
                StartDateTime = DateTime.Now.AddHours(-3),
                FinishDateTime = DateTime.Now.AddHours(-2),
                Statu = "ÜRETİM",
                Description = "D"
            };
            List<TableOne> TableList = new List<TableOne>();
            TableList.Add(firstTable);
            TableList.Add(firstTablee);
            TableList.Add(firstTableee);
            TableList.Add(firstTableeee);
            firstTable.Time();
            firstTablee.Time();
            firstTableee.Time();
            firstTableeee.Time();
            TableTwo secondTable = new TableTwo()
            {
                StartTime = DateTime.Now.AddHours(-3),
                FinishTime = DateTime.Now.AddHours(-2.5),
                Description = "ARA"
            };
            TableTwo secondTablee = new TableTwo()
            {
                StartTime = DateTime.Now.AddHours(-5),
                FinishTime = DateTime.Now.AddHours(-4.5),
                Description = "ARA"
            };
            TableTwo secondTableee = new TableTwo()
            {
                StartTime = DateTime.Now.AddHours(-7),
                FinishTime = DateTime.Now.AddHours(-6.5),
                Description = "ARA"
            };
            List<TableTwo> TableListt = new List<TableTwo>();
            TableListt.Add(secondTableee);
            TableListt.Add(secondTablee);
            TableListt.Add(secondTable);
            List<Result> results = new List<Result>();

            foreach (var item in TableList)
            {
                Console.WriteLine($"{item.KayıtNo},{item.StartDateTime},{item.FinishDateTime},{item.TimeDiff},{item.Statu},{item.Description}");
            }
            foreach (var item in TableListt)
            {
                Console.WriteLine($"{item.StartTime},{item.FinishTime},{item.Description}");
            }
            int tekrar;
            foreach (var item in TableList)
            {
                int tekrar2;
                bool control = false;
                DateTime currentDate;
                foreach (var i in TableListt)
                { 
                    if ((item.StartDateTime.Hour <= i.StartTime.Hour) && item.FinishDateTime.Hour >= i.FinishTime.Hour)
                    {
                        if (!control)
                        {
                            Result r = new Result();
                            r.StartDateTime = item.StartDateTime;
                            r.KayıtNo = item.KayıtNo;
                            r.Statu = item.Statu;
                            r.Description = item.Description;
                            r.FinishDateTime = i.StartTime;
                            r.TimeDiff = i.StartTime.Date - item.StartDateTime.Date;
                            results.Add(r);
                            Result rr = new Result();
                            rr.StartDateTime = i.StartTime;
                            rr.KayıtNo = item.KayıtNo;
                            rr.Statu = item.Statu;
                            rr.Description = i.Description;
                            rr.FinishDateTime = i.FinishTime;
                            rr.TimeDiff = i.FinishTime - i.StartTime;
                            results.Add(rr);
                            Result rrr = new Result();
                            rrr.StartDateTime = i.FinishTime;
                            rrr.KayıtNo = item.KayıtNo;
                            rrr.Statu = item.Statu;
                            rrr.Description = item.Description;
                            rrr.FinishDateTime = item.FinishDateTime;
                            rrr.TimeDiff = item.FinishDateTime - i.FinishTime;
                            results.Add(rrr);
                            control = true;
                            currentDate = item.FinishDateTime;
                        }
                        else
                        {
                            //tekrar2++;
                        }
                            
                       
                    }
                    
                }
                if (!control)
                {
                    Result x = new Result();
                    x.Description = item.Description;
                    x.FinishDateTime = item.FinishDateTime;
                    x.KayıtNo = item.KayıtNo;
                    x.StartDateTime = item.StartDateTime;
                    x.Statu = item.Statu;
                    x.TimeDiff = item.TimeDiff;
                    results.Add(x);
                }
                //tekrar = tekrar2;
            }
            foreach (var item in results)
            {
                Console.WriteLine($"{item.KayıtNo},{item.StartDateTime},{item.FinishDateTime},{item.TimeDiff},{item.Statu},{item.Description}");
            }
            Console.ReadLine();
        }
    }
}
