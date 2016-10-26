using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorldbestlearningcenterExample.Go();

            var s = new ProductConsts.BpmStatus("bf458b24-ac55-4fb5-9579-e6c656cc6c44");
            Console.WriteLine(s.OneCStatus);
            Console.Read();
        }
    }

    public static class ProductConsts
    {
        public class BpmStatus
        {
            private Dictionary<string, string> bpmStatus
            {
                get
                {
                    return new Dictionary<string, string>
                    {
                        {"New",             New/*"bf458b24-ac55-4fb5-9579-e6c656cc6c44"*/},
                        {"Calculated",      Calculated/*"29fa66e3-ef69-4feb-a5af-ec1de125a614"*/},
                        {"TechParamChange", TechParamChange/*"c8742634-ea8b-46d9-ba71-1989b951772d"*/},
                        {"ConcludeATreaty", ConcludeATreaty/*"40de86ee-274d-4098-9b92-9ebdcf83d4fc"*/},
                        {"Cancelled",       Cancelled/*"8ab0f830-908b-40d7-80a3-7f49ef70ce70"*/},
                        {"Ready",           Ready/*"1f3ad326-effd-4ac3-a3e2-957e7def3684"*/},
                        {"Executed",        Executed/*"db55d8b1-441d-4ae2-8e86-7a5c44d1fd01"*/},
                        {"Shipped",         Shipped/*"dbdee4c3-9400-47ad-8e76-993a253df656"*/}
                    };
                }
            }

            private string BpmStaus { get; set; }

            public BpmStatus(string bpmStatus)
            {
                this.BpmStaus = bpmStatus;
            }

            public string OneCStatus
            {
                get
                {
                    var name = bpmStatus.FirstOrDefault(s => s.Value.Contains(this.BpmStaus)).Key;
                    return typeof(OneCStatus).GetProperty(name).GetValue(null, null).ToString();
                }
            }

            // Статус продукта 1. Новый"
            public static string New
            {
                get { return "bf458b24-ac55-4fb5-9579-e6c656cc6c44"; }
            }
            // Статус продукта 2. Цена просчитана"
            public static string Calculated
            {
                get { return "29fa66e3-ef69-4feb-a5af-ec1de125a614"; }
            }
            // Статус продукта 3. Изменение тех.параметров"
            public static string TechParamChange
            {
                get { return "c8742634-ea8b-46d9-ba71-1989b951772d"; }
            }
            // Статус продукта 4. Заключение договора"
            public static string ConcludeATreaty
            {
                get { return "40de86ee-274d-4098-9b92-9ebdcf83d4fc"; }
            }
            // Статус продукта 5. Отменен"
            public static string Cancelled
            {
                get { return "8ab0f830-908b-40d7-80a3-7f49ef70ce70"; }
            }
            // Статус продукта 6. Готово"
            public static string Ready
            {
                get { return "1f3ad326-effd-4ac3-a3e2-957e7def3684"; }
            }
            // Статус продукта 7. Выполнен"
            public static string Executed
            {
                get { return "db55d8b1-441d-4ae2-8e86-7a5c44d1fd01"; }
            }
            // Статус продукта 8. Отгружен"
            public static string Shipped
            {
                get { return "dbdee4c3-9400-47ad-8e76-993a253df656"; }
            }
        }

        public static class OneCStatus
        {
            // Статус продукта 1. Новый"
            public static string New
            {
                get { return "c52a5627-e836-11e1-89b0-386077c315f8"; }
            }
            // Статус продукта 2. Цена просчитана"
            public static string Calculated
            {
                get { return "1a61b1d0-1e7d-11e6-8b5a-c46e1f03e668"; }
            }
            // Статус продукта 3. Изменение тех.параметров"
            public static string TechParamChange
            {
                get { return "1a61b1d1-1e7d-11e6-8b5a-c46e1f03e668"; }
            }
            // Статус продукта 4. Заключение договора"
            public static string ConcludeATreaty
            {
                get { return "1a61b1d2-1e7d-11e6-8b5a-c46e1f03e668"; }
            }
            // Статус продукта 5. Отменен"
            public static string Cancelled
            {
                get { return "c52a5627-e836-11e1-89b0-386077c315f8"; }
            }
            // Статус продукта 6. Готово"
            public static string Ready
            {
                get { return "953956f9-8c37-11e5-9e26-005056c00008"; }
            }
            // Статус продукта 7. Выполнен"
            public static string Executed
            {
                get { return "afd6e792-0a3f-44cd-baf9-94ac8371a69a"; }
            }
            // Статус продукта 8. Отгружен"
            public static string Shipped
            {
                get { return "defcbd16-1202-11e2-940f-50e54958fe81"; }
            }
        }
    }



    public class StatusResolver
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        private Guid bpmStatus { get; set; }

        public StatusResolver(Guid bpmStatus)
        {
            dict.Add("1", "2");
            //dict.g
            this.bpmStatus = bpmStatus;
        }

        public string GetOneCStatusString()
        {
            var t = typeof(ProductConsts.OneCStatus);
            t.GetProperty("Shipped");
            return "";
        }

    }
}
