using System;
using System.Collections.Generic;
using System.Linq;
using DotNet.models;


namespace DotNet
{
    public class Solver
    {
        private readonly Solution _solution = new();

        public Solver()
        {
            return _solution;
        }

        public List<PointPackage> Solve(int bagtype, int days)
        {
            solution.setRecycleRefundChoice(true);
            solution.setBagPrice(10);
            solution.setRefundAmount(1);
            solution.setBagType(bagtype);
            
            List<int> orders = new ArrayList<>();
            for (int day = 0; day < days, day++) {
                orders.add(wasteMoney(bag_type));
            }
            
            solution.setOrders(orders);
            return solution;
        }

        // Solution 1: "Spend all money day 1"
        private static int wasteMoney(bagtype) {
            return Math.floor(companyBudget / bagType_price[bagtype]);
        }

        // Solution 2: "Spend equally money every day"
        private static int splitMoney(bagtype) {
            return Math.floor(companyBudget / bagType_price[bagtype] / days);
        }

        // Solution 3: "Everyone get one bag every day"
        private static int holdMoney(bagtype) {
            return Math.floor(companyBudget / bagType_price[bagtype] / population / days);
        }
}