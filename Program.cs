using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {
            Building build1 = new Building ("7104 Corner Drive");
            build1.Stories = 3;
            build1.Width = 50;
            build1.Depth = 50;
            build1.Construct ();

            Building build2 = new Building ("104 Kurr Drive");
            build2.Stories = 1;
            build2.Width = 100;
            build2.Depth = 50;
            build2.Construct ();

            Building build3 = new Building ("754 Abbett Ave");
            build3.Stories = 3;
            build3.Width = 150;
            build3.Depth = 150;
            build3.Construct ();

            build1.Purchase ("Andy McNally");
            build2.Purchase ("Gail Peck");
            build3.Purchase ("Chris Diez");

            City city1 = new City ("megalopolis", 1944);
            city1.Mayor = "Boss Hog";

            city1.buildings.Add (build1);
            city1.buildings.Add (build2);
            city1.buildings.Add (build3);

            Console.WriteLine ($"City {city1.GetNameOfCity()}");
            Console.WriteLine ($"Year Established: {city1.GetYear()}");
            Console.WriteLine ($"City Buildings:");

            foreach (Building building in city1.buildings) {
                Console.WriteLine ($"{building.GetAddress()}");
            }

        }

    }
}