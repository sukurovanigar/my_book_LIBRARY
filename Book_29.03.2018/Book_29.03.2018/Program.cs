using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Consolun rengini deyisir..
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        //------------------------

        Book bk = null;
        var library = new List<Book>();
        void Emrlerim()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------>> ANA EKRAN <<------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Kitab elave et");
            Console.WriteLine("2. Kitablari goster");
            Console.WriteLine("3. Kitab sil");
            Console.WriteLine("4. Kitab melumatlarini deyisdir");
            Console.WriteLine("5. Kitablari tarix siralamasina gore goster");
            Console.WriteLine("6. Kitablari qiymet siralamasina gore goster");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Istediyiniz emrin nomresini daxil edin : ");
            Console.ResetColor();
            var Emr_et = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_______________________________________________");
            switch (Emr_et)
            {
                case 1:
                    Create();
                    break;
                case 2:
                    Read();
                    break;
                case 3:
                    Delete();
                    break;
                case 4:
                    Update();
                    break;
                case 5:
                    Order_by_Date();
                    break;
                case 6:
                    Order_by_Price();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    Console.WriteLine("Daxil etdiyiniz emr movcud deyil, sizi ana ekrana yonlendirirem:");
                    Console.WriteLine("_______________________________________________________________");
                    Emrlerim();
                    break;
                    Console.ResetColor();
            }
        }
        Emrlerim();
        // kitabin elave edilmesi prosesi
        void Create()
        {   // Adi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin adini daxil edin:");
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var name = Console.ReadLine();
            string first = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            //-----------------------------------------
            // Yazicisi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin muellifini daxil edin:");
            Console.Write("Author: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var author = Console.ReadLine();
            string first_auth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author);
            //----------------------------------------- 
            // Barcode
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin Barcodunu daxil edin:");
            Console.Write("Barcode: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var isbn = Console.ReadLine();
            //-----------------------------------------
            // Tarix
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin Istehsal olundugu tarixi daxil edin:");
            Console.Write("Date: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var publish_date = Convert.ToDateTime(Console.ReadLine());
            //-----------------------------------------
            // qiymet
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin qiymetini daxil edin:");
            Console.Write("Price: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var price = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            //-----------------------------------------
            // Melumati saxlamaq
             bk = new Book(first, first_auth, isbn, publish_date, price);
            library.Add(bk);
            Emrlerim();
            //------------------------------------------
        }
        // kitabin gosterilmesi prosesi
        void Read()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("#  |  Adi   |   Muellifi   |   Qiymeti   |  Tarix  |   Barcodu  |");
            Console.ResetColor();
            bk.Show(library);
            Emrlerim();
        }
        // kitabin deyisdirilmesi prosesi
        void Update()
        {
            bk.Show(library);
            Console.Write("Deyismek istediyiniz kitabin sira nomresini daxil edin: ");
            var update = Convert.ToInt32(Console.ReadLine());
            // Adi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin adini daxil edin:");
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var name = Console.ReadLine();
            string first = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            //-----------------------------------------
            // Yazicisi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin muellifini daxil edin:");
            Console.Write("Author: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var author = Console.ReadLine();
            string first_auth = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author);
            //----------------------------------------- 
            // Barcode
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin Barcodunu daxil edin:");
            Console.Write("Barcode: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var isbn = Console.ReadLine();
            //-----------------------------------------
            // Tarix
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin Istehsal olundugu tarixi daxil edin:");
            Console.Write("Date: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var publish_date = Convert.ToDateTime(Console.ReadLine());
            //-----------------------------------------
            // qiymet
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kitabin qiymetini daxil edin:");
            Console.Write("Price: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var price = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            //-----------------------------------------
            // Melumati saxlamaq
            bk = new Book(first, first_auth, isbn, publish_date, price);
            library[update - 1] = bk;
            Emrlerim();

        }
        // kitabin silinmesi prosesi
        void Delete()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->>SELECT THE BOOK FOR DELETE<<---");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            bk.Show(library);
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Silmek istediyiniz kitabin sira nomresini daxil edin: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            var dlt = Convert.ToInt32(Console.ReadLine());
            library.Remove(library[dlt - 1]);
            Emrlerim();
        }
        // kitabin tarixe gore duzulmesi
        void Order_by_Date()
        {
            List<Book> OrderedByDate = new List<Book>();
            OrderedByDate = library.OrderBy(d => d.PublishDate).ToList();
            OrderedByDate.Reverse();
            var count = 0;
            Console.WriteLine("#  |  Adi   |   Muellifi   |   Qiymeti   |  Tarix |");
            foreach (var item in OrderedByDate)
            {
                count++;
                Console.WriteLine("\n"+ count + " - " + item.Name + " | " + item.Author + " | " + item.Price + " AZN" +  "  |  "+ item.PublishDate.Year);
            }
            Emrlerim();
        }
        // kitabiin qiymete gore duzulmesi
        void Order_by_Price()
        {
            List<Book> OrderedByPrice = new List<Book>();
            OrderedByPrice = library.OrderBy(p => p.Price).ToList();
            var count = 0;
            Console.WriteLine("#  |  Adi   |   Muellifi   |  Tarix  |  Qiymeti  |");
            foreach (var item in OrderedByPrice)
            {
                count++;
                Console.WriteLine("\n" + count + " - " + item.Name + " | " + item.Author + " | " + item.PublishDate.Date + " | " + item.Price + " AZN" );
            }
            Emrlerim(); 
        }
    }

    class Book
    {
        public string Name;
        public string Author;
        public string ISBN;
        public DateTime PublishDate;
        public int Price;
        public Book(string name, string author, string isbn, DateTime publish_date, int price)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
            PublishDate = publish_date;
            Price = price;
        }
        // Kitablarin siralanmasi ve gosterilmesi metodu
        public void Show(List<Book> db)
        {
            var count = 0;
            foreach (var kitab in db)
            {
                count++;
                Console.WriteLine(count + " - "  + kitab.Name + " - " + kitab.Author + " - " + kitab.Price + " AZN - " + kitab.PublishDate.Date + " - " + kitab.ISBN);
            }
        }
    }

}

