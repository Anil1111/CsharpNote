//using System;

//namespace chapter06
//{
//    struct order
//    {
//        public string itemName;
//        public int unitCount;
//        public double unitCost;
//        public double Summary() => unitCost * unitCount;
//        public void Display()
//        {
//            string itemInformation = "Order Information: " + Convert.ToString(unitCount) + " " + itemName + " items as $" + Convert.ToString(unitCost)
//                                      + " each, total cost $" + Convert.ToString(Summary()) + ".";
//            Console.WriteLine(itemInformation);
//        }
//    }
//    class Ch06Ex06
//    {
//        static void Main(string[] args)
//        {
//            order myOrder;
//            myOrder.itemName = "clothes";
//            myOrder.unitCost = 12;
//            myOrder.unitCount = 10;
//            Console.WriteLine(myOrder.Summary());
//            myOrder.Display();

//            Console.ReadKey();
//        }
//    }
//}
