using System;
using System.Collections.Generic;
using System.Linq;
using DotNet.models;
using Newtonsoft.Json.Linq;


namespace DotNet
{
    public class Solver
    {
        private static List<Double> bagType_price = new List<double> { 1.7, 1.75, 6.0, 25.0, 200.0 };
        private static List<double> bagType_co2_transport = new List<double> { 3.0, 4.2, 1.8, 3.6, 12.0 };
        private static List<int> bagType_co2_production = new List<int> { 30, 24, 36, 42, 60 };

        public static int population;
        public static int companyBudget;
        public static int days;


        private Solution solution = null;

        public Solver(int ipopulation, int icompanyBudget, int idays)
        {
            population = ipopulation;
            companyBudget = icompanyBudget;
            days = idays;

            solution = new Solution();
        }

        public Solution Solve(int bagtype, string mapName)
        {
            solution.recycleRefundChoice = true;
            solution.bagPrice = 10;
            solution.refundAmount = 1;
            solution.bagType = bagtype;
            solution.mapName = mapName;

            List<int> orders = new List<int>();
            for (int day = 0; day < days; day++)
            {
                orders.Add(holdMoney(bagtype));
            }

            solution.orders = orders;
            return solution;
        }

        // Solution 1: "Spend all money day 1"
        private static int wasteMoney(int bagtype)
        {
            return (int)Math.Floor(companyBudget / bagType_price[bagtype]);
        }

        // Solution 2: "Spend equally money every day"
        private static int splitMoney(int bagtype)
        {
            return (int)Math.Floor(companyBudget / bagType_price[bagtype] / days);
        }

        // Solution 3: "Everyone get one bag every day"
        private static int holdMoney(int bagtype)
        {
            return (int)Math.Floor(companyBudget / bagType_price[bagtype] / population / days);
        }
    }
}
