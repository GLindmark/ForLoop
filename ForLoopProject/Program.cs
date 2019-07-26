using System;

namespace ForLoopProject {
    class customer {
        public string Name { get; set; }
        public string State { get; set; }
    }
    class Program {
        static void Main(string[] args) {


            customer[] customers = {
                new customer { Name = "PG", State = "OH" },
                new customer { Name = "SDCust", State = "SD"},
                new customer { Name = "MTCust", State = "MT"}
            };

            bool FoundSDCust = false;//Define the FoundSDCust as a bool
            bool FoundMTCust = false;

            foreach (customer cust in customers) {

                switch (cust.State) {
                    case "MT":
                        FoundMTCust = true;
                        break;
                    case "SD":
                        FoundSDCust = true;
                        break;
                }

                //if (cust.State == "MT") {
                //    FoundMTCust = true;
                //    continue;
                //Once a MT customer is identified, it will then go back to the beginning for the 
                //next record rather than check further for another state.
                //}


                //if (cust.State == "SD") {
                //    FoundSDCust = true;
                //}

                //if(FoundSDCust && FoundMTCust) {
                //    break;
            }
            Console.WriteLine($"Found MT customer: {FoundMTCust}");
            Console.WriteLine($"Found SD customer: {FoundSDCust}");

        }

        //Console.WriteLine($"Found MT customer: {FoundMTCust}");
        //Console.WriteLine($"Found SD customer: {FoundSDCust}");




















        //int[] ints = { 89 , 188, 295, 943, 975, 277, 119,
        //    736, 952, 321, 521, 444, 758, 397,
        //    915, 878, 674, 701, 379, 331, 804,
        //    461, 459, 908, 373 };

        //    string[] names = {
        //        "Brailee", "Brianna", "Marianne", "Alex", "Jesse", "Titus", "Maggie", "Glenn"
        //    };

        //    string allNames = "";// create an "empty" string variable


        //    foreach (string name in names) {

        //        string upperName = name.ToUpper();// sets all of the names to all UPPERCASE

        //        allNames += upperName;// this will take the value of allnames and 'concatenate' it to upperName

        //    }
        //    Console.WriteLine(allNames);//Remember to put the Console Writeline outside of the statement
    }

        //int total = 0;

        //foreach(int anInt in ints) {
        //    total += anInt;
        //}

        //for(int idx = 0; idx< ints.Length; idx++) {
        //    total += ints[idx] *3 / 4;
        //}

        //decimal average = total / (decimal) ints.Length;// putting 'decimal' infront is a CAST which returns a decimal
        //Console.WriteLine($"Total; {total} , Average: {average}");
    }

