using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaseConsoleApp
{
    class Program
    {
        public int ID { get; set; }
        public string PMNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        static async Task Main(string[] args)
        {
            List<Program> pg = new List<Program>
            { new Program{
                PMNo = "IKJ234",
                StartDate = DateTime.Parse("2020/10/20"),
                EndDate = DateTime.Parse("2021/10/21") },
                 new Program{
                PMNo = "IKJ235",
                StartDate = DateTime.Parse("2020/9/21"),
                EndDate = DateTime.Parse("2021/9/21")},
                  new Program{
                PMNo = "IKJ236",
                StartDate = DateTime.Parse("2020/8/21"),
                EndDate = DateTime.Parse("2021/8/21")},
                   new Program{
                PMNo = "IKJ237",
                StartDate = DateTime.Parse("2020/7/21"),
                EndDate = DateTime.Parse("2021/7/21")},
                    new Program{
                PMNo = "IKJ238",
                StartDate = DateTime.Parse("2020/4/30"),
                EndDate = DateTime.Parse("2021/4/30")},
            };

            var res = pg;


            foreach (var b in res) 
            {
                Console.WriteLine(b.EndDate.DayOfYear - DateTime.Now.DayOfYear);
                switch (b.EndDate.DayOfYear - DateTime.Now.DayOfYear)
                {
                    case 180:
                        Console.WriteLine( "Mail sent to "+b.PMNo);
                        break;
                    case 90:
                        Console.WriteLine("Mail sent to " + b.PMNo);
                        break;
                    case 60:
                        Console.WriteLine("Mail sent to " + b.PMNo);
                        break;
                    case 30:
                        Console.WriteLine("Mail sent to " + b.PMNo);
                        break;
                    case 0:
                        Console.WriteLine("Mail sent to " + b.PMNo);
                        break;
                    default:
                        Console.WriteLine("Mail not sent");
                        break;
                }
            }         
               
            
            Console.ReadKey();

        }
    }
}
