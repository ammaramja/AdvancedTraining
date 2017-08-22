using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes;

namespace classes
{
    class AreaMaster
    {
        int id, areaId;
        String code,name, description;

        public enum areaType { Country = 1, State, City, District };

        areaType a;

        protected static List<AreaMaster> AreaCollection = new List<AreaMaster>();
        public AreaMaster()
        {

        }
        public AreaMaster(int id, string name, string code, string description, areaType area, int AreaId)
        {
            this.id = id;
            this.code = code;
            this.areaId = AreaId;
            this.name = name;
            this.description = description;
            this.AreaType_property = area;
            AreaCollection.Add(this);
        }

        public int Id_property { get { return id; } set { id = value; } }

        public string Name_property { get { return name; } set { name = value; } }

        public string Description_property { get { return description; } set { description = value; } }

        public string Code_property { get { return code; } set { code = value; } }

        public int AreaId_property { get { return areaId; } set { areaId = value; } }

        public virtual areaType AreaType_property { get { return a; } set { a = value; } }

        public string GetById(int id)
        {
            foreach(AreaMaster list_iterator in AreaCollection)
            {
                if(list_iterator.Id_property == id)
                {
                    return list_iterator.Name_property;
                }
            }
            return "";
        }
        public int GetAreaIdByName(string stateName)
        {
            foreach (AreaMaster list_iterator in AreaCollection)
            {
                if (list_iterator.Name_property == stateName)
                {
                    return list_iterator.AreaId_property;
                }
            }
            return 0;
        }




    }

    class CountryMaster : AreaMaster
    {
        public CountryMaster()
        {

        }

        public override areaType AreaType_property
        {
            get
            {
                return base.AreaType_property;
            }

            set
            {
                base.AreaType_property = value;
            }
        }

        public void GetAreaMasterByCountry(string country)
        {
            int flag = 0;
            foreach (AreaMaster country_iterator in AreaCollection)
            {
                flag = 1;
                Console.WriteLine();
                if (country_iterator.AreaType_property == areaType.Country && country_iterator.Name_property == country)
                {
                    flag = 1;
                    Console.WriteLine("Name: " + country_iterator.Name_property);
                    Console.WriteLine("Code: " + country_iterator.Code_property);
                    Console.WriteLine("Description: " + country_iterator.Description_property);
                }

            }
            if(flag == 1)
            {

            }
                else
                {
                Console.WriteLine("Not Found!!!!");
            }
        }

    }
    class StateMaster : AreaMaster
    {
        public StateMaster()
        {
        }

        public override areaType AreaType_property
        {
            get
            {
                return base.AreaType_property;
            }

            set
            {
                base.AreaType_property = value;
            }
        }

        public void GetAreaMasterByState(string state)
        {
            int flag = 1;
            foreach (AreaMaster state_iterator in AreaCollection)
            {
                Console.WriteLine();
                if (state_iterator.AreaType_property == areaType.State && state_iterator.Name_property == state)
                {
                    flag = 0;
                    Console.WriteLine("Name: " + state_iterator.Name_property);
                    string country = GetById(state_iterator.AreaId_property);
                    Console.WriteLine("Country: " + country);
                    Console.WriteLine("Code: " + state_iterator.Code_property);
                    Console.WriteLine("Description: " + state_iterator.Description_property);
                }

            }
            if(flag == 0 )
            {

            }
            else
            {
                Console.WriteLine("Not Found!!!!");
            }

        }
    }
    class CityMaster : AreaMaster
    {
        public CityMaster()
        {
        }

        public override areaType AreaType_property
        {
            get
            {
                return base.AreaType_property;
            }

            set
            {
                base.AreaType_property = value;
            }
        }

        public void GetAreaMasterByCity(string city)
        {
            int flag = 1;
            foreach (AreaMaster city_iterator in AreaCollection)
            {
                Console.WriteLine();
                if (city_iterator.AreaType_property == areaType.City && city_iterator.Name_property == city)
                {
                    flag = 0;
                    Console.WriteLine("Name: " + city_iterator.Name_property);
                    string state = GetById(city_iterator.AreaId_property);
                    int stateAreaId = GetAreaIdByName(state);
                    string country = GetById(stateAreaId);
                    Console.WriteLine("State: " + state);
                    Console.WriteLine("Country: " + country);
                    Console.WriteLine("Code: " + city_iterator.Code_property);
                    Console.WriteLine("Description: " + city_iterator.Description_property);
                }

            }
            if (flag == 0)
            {

            }
            else
            {
                Console.WriteLine("Not Found!!!!");
            }
        }
    }
    class DistrictMaster : AreaMaster
    {
        public DistrictMaster(int id, string name, string code, string description, areaType area, int AreaId) : base(id, name, code, description, area, AreaId)
        {
        }

        public override areaType AreaType_property
        {
            get
            {
                return base.AreaType_property;
            }

            set
            {
                base.AreaType_property = value;
            }
        }
    }
}

namespace day4_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<4;i++)
            { 
            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            String name = Console.ReadLine();

            Console.Write("Enter Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Area-Type: ");
            int dummy_for_areaType = Convert.ToInt32(Console.ReadLine());
            AreaMaster.areaType area = (AreaMaster.areaType)dummy_for_areaType;

            //Console.WriteLine(area);

            Console.Write("Enter Area Id: ");
            int AreaId = Convert.ToInt32(Console.ReadLine());

                AreaMaster object1 = new AreaMaster(id, name, code, description, area, AreaId);

        }
            int ch;

            do
            {
                Console.WriteLine();
                Console.WriteLine("How would you like to get Area master by? ");
                Console.WriteLine("Country : 1");
                Console.WriteLine("State : 2");
                Console.WriteLine("City : 3");
                Console.WriteLine("Exit : 4");
                Console.WriteLine();

                ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        CountryMaster a = new CountryMaster();
                        Console.Write("Enter country to be searched!: ");
                        string countryForSearch = Console.ReadLine();
                        a.GetAreaMasterByCountry(countryForSearch);
                        break;

                    case 2:
                        StateMaster s = new StateMaster();
                        Console.Write("Enter state to be searched!: ");
                        string stateForSearch = Console.ReadLine();
                        s.GetAreaMasterByState(stateForSearch);
                        break;

                    case 3:
                        CityMaster c = new CityMaster();
                        Console.Write("Enter state to be searched!: ");
                        string CityForSearch = Console.ReadLine();
                        c.GetAreaMasterByCity(CityForSearch);
                        break;
                }

            } while (ch!=4);

        }
    }
}

