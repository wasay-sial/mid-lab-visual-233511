internal class Program
{
    public static List<string> triphistory = new List<string>();
    public static Trip trip = new Trip();
    public class USER
    {
        //ridesharing r=new ridesharing();
        private int u_id;
        private string name;
        private string phone_num;

        public void setName()
        {
            string n;
            Console.WriteLine("Enter the name: ");
            n= Console.ReadLine();
            name = n;
        }
        public string getName()
        {
            return name;
        }

        public void setID()
        {
            int i;
            Console.WriteLine("Enter the ID: ");
            i = int.Parse(Console.ReadLine());
            u_id = i;
        }
        public int getID()
        {
            return u_id;
        }

        public void setphonenimber()
        {
            string p;
            Console.WriteLine("Enter the phone number: ");
            p= Console.ReadLine();
            phone_num = p;
        }
        public string getPhonenum()
        {
            return phone_num;
        }

        public void Register_user()
        {
            Console.WriteLine("Enter your details: ");
            setName();
            setID();
            setphonenimber();
            //r.riders.Add(name);
            Console.WriteLine("USER registered successfully");
        }

        //public void showdrivers()
        //{
        //    Conso
        //}




    }

    public class Rider:USER
    {
        //Trip t2 = new Trip();
        private List<string> riderhistory=new List<string>();

        public void requestride()
        {
            trip.setstartloc();
            trip.setendloc();
            Console.WriteLine("Ride added suceessfully");
        }

        public void viewhistory()
        {
            Console.WriteLine("The rides list is: ");
            Console.WriteLine(riderhistory);
        }

        public void viewridehistory()
        {
            //t2.setstartloc();
            //t2.settripID();
            //t2.setendloc() ;
            Console.WriteLine("Trip id: "+trip.getTripID()+" from: "+trip.getstartloc()+" to: " + trip.getendloc()+" fare: "+trip.getfare());
        }

    }


    public class driver:USER
    {
        Trip t=new Trip();
        private int driver_id;
        private bool isavalable;
        private string vehicle_details;
        
        public void acceptride()
        {
            Console.WriteLine("your ride has been acccepted");
            isavalable = false;
        }

        public void toggle_history()
        {
            Console.WriteLine("This driver is now available");
            isavalable = true;
        }

        public void viewtriphistory()
        {
            Console.WriteLine("The trip history is: ");
            Console.WriteLine(triphistory.ToString());    
        }

        public void completetrip()
        {
            t.setstartloc();
            t.setendloc();
            Console.WriteLine("Trip from " + t.getstartloc() + " to " + t.getendloc()+" has been completed Fare: " + t.getfare());
        }

        
    }

    public class Trip()
    {
        private int trip_id;
        private string rider_name;
        private string driver_name;
        private string startloc;
        private string destination;
        private double fare;
        private bool status;

        public void settripID()
        {
            Console.WriteLine("enter id :");
            trip_id = int.Parse(Console.ReadLine());
        }
        public int getTripID()
        {
            return trip_id;
        }

        public void setridername()
        {
            Console.WriteLine("enter rider name :");
            rider_name = Console.ReadLine();
        }
        public string getridername()
        {
            return rider_name;
        }

        public void setdrivername()
        {
            Console.WriteLine("enter driver name :");
            driver_name = Console.ReadLine();
        }
        public string getdrivername()
        {
            return driver_name;
        }

        public void setstartloc()
        {
            Console.WriteLine("enter start location :");
            startloc = Console.ReadLine();
        }
        public string getstartloc()
        {
            return startloc;
        }

        public void setendloc()
        {
            Console.WriteLine("enter your destination :");
            destination = Console.ReadLine();
        }
        public string getendloc()
        {
            return destination;
        }

        public void setfare()
        {
            Console.WriteLine("Enter the fare");
            fare=int.Parse(Console.ReadLine());
        }
        public double getfare()
        {
            return fare;
        }

        public void calculate_fare()
        {
            Console.WriteLine("The fare is: "+fare);

        }

        public void starttrip()
        {
            Console.WriteLine("The trip has been started");
        }
        public void endtrip()
        {
            Console.WriteLine("The trip has been ended");
        }

        public void displaytripdetails()
        {
            Console.WriteLine("Rider name: " + rider_name);
            Console.WriteLine("Driver name: " + driver_name);
            Console.WriteLine("TripID: " + trip_id);
            Console.WriteLine("start location: " + startloc);
            Console.WriteLine("End location: " + destination);
            Console.WriteLine("The fare is: " + fare);
        }

    }

    public class ridesharing
    {
        Rider rider=new Rider();
        driver driver = new driver();

        public List<string> riders= new List<string>();
        public List<string> drivers= new List<string>();
        public List<string> available_trips= new List<string>();

        //public  void addrider()
        //{
        //    riders.Add(rider.getName());
        //}
        //public void adddriver()
        //{
        //    drivers.Add(driver.getName());
        //}
    }


    private static void Main(string[] args)
    {
        char key;
        Rider r = new Rider();
        driver d = new driver();
        

        //trip.setdrivername();
        //trip.setridername();
        //trip.settripID();
        //trip.setfare();
        //trip.setstartloc();
        //trip.setendloc();


        do
        {
            int choice;
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1---Register as rider");
            Console.WriteLine("2---Register as driver");
            Console.WriteLine("3---Request ride");
            Console.WriteLine("4---Accept ride");
            Console.WriteLine("5---complete a trip");
            Console.WriteLine("6---View ride history");
            Console.WriteLine("7---view trip history");
            Console.WriteLine("8---display all trips");
            Console.WriteLine("9---Exit");

            Console.WriteLine("Choose one option: ");
            choice = int.Parse(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    r.Register_user();
                    break;

                case 2:
                    d.Register_user();
                    break;

                case 3:
                    r.requestride();
                    break;

                case 4:
                    d.acceptride();
                    break;

                case 5:
                    d.completetrip();
                    break;

                case 6:
                    r.viewridehistory();
                    break;

                case 7:
                    d.viewtriphistory();
                    break;

                case 8:
                    trip.displaytripdetails();
                    break;

                case 9:
                    Console.WriteLine("The program will exit.....press any key to close the program");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
            Console.WriteLine("Do you want to continue? (Y/N)");
            key = char.Parse(Console.ReadLine());
            Console.Clear();

        } while (key == 'Y' || key == 'y');


    }
}